using System.Text;
using scannermaui.Models;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using iText.IO.Font.Constants;

#if ANDROID
using Android.Runtime;
using Com.Epson.Epos2;
using Com.Epson.Epos2.Printer;
using Com.Epson.Epos2.Discovery;
using Platform = Microsoft.Maui.ApplicationModel.Platform;
#endif

using ITextCell = iText.Layout.Element.Cell;
using ITextAlignment = iText.Layout.Properties.TextAlignment;
using iText.Kernel.Font;

namespace scannermaui.Services
{
    public class PrintService : IDisposable
    {
#if ANDROID
        private Printer _printer;
        private string _selectedPrinterIp;
        private bool _isDiscovering;
#endif
        private const int ALIGN_CENTER = 1;
        private const int LANG_MODEL_ANK = 1;
        private const int PARAM_DEFAULT = 0;
        private const int CUT_FEED = 1;

        public async Task HandleInvoice(List<CartItem> items, decimal totalAmount, bool isShare)
        {
            try
            {
                if (isShare)
                {
                    string pdfPath = await GenerateInvoicePdf(items, totalAmount);
                    await ShareInvoice(pdfPath);
                    if (File.Exists(pdfPath)) File.Delete(pdfPath);
                    return;
                }

#if ANDROID
                if (!await FindPrinter())
                    throw new InvalidOperationException("No printer found. Please check printer connection.");

                await PrintInvoice(items, totalAmount);
#endif
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"HandleInvoice error: {ex}");
                if (!isShare)
                {
                    await Shell.Current.DisplayAlert("Printer Error",
                        "Failed to print invoice. Please check printer connection.", "OK");
                }
            }
        }

        private async Task<string> GenerateInvoicePdf(List<CartItem> items, decimal totalAmount)
        {
            string fileName = $"invoice_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            string filePath = Path.Combine(FileSystem.CacheDirectory, fileName);

            using var writer = new PdfWriter(filePath);
            using var pdf = new PdfDocument(writer);
            using var document = new Document(pdf);

            var normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            var boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

            foreach (var item in items)
            {
                document.Add(new Paragraph($"{item.ProductName} x{item.Quantity} @ Rs. {item.Price:N2} = Rs. {(item.Price * item.Quantity):N2}")
                    .SetFont(normalFont));
            }

            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Total Amount: Rs. {totalAmount:N2}")
                .SetFont(boldFont)
                .SetTextAlignment(ITextAlignment.RIGHT)
                .SetFontSize(14));

            return filePath;
        }

        private async Task ShareInvoice(string pdfPath)
        {
            if (!File.Exists(pdfPath))
                throw new FileNotFoundException("Invoice file not found");

            var request = new ShareFileRequest
            {
                Title = "Share Invoice",
                File = new ShareFile(pdfPath)
            };
            await Share.Default.RequestAsync(request);
        }

#if ANDROID
        private async Task<bool> FindPrinter()
        {
            if (_isDiscovering)
            {
                System.Diagnostics.Debug.WriteLine("Printer discovery already in progress");
                return false;
            }
            
            _isDiscovering = true;
            System.Diagnostics.Debug.WriteLine("Starting printer discovery...");

            var tcs = new TaskCompletionSource<bool>();
            var listener = new DiscoveryListener();
            var filterOption = new FilterOption { PortType = Discovery.PorttypeTcp };

            listener.OnPrinterFound += (s, deviceInfo) =>
            {
                _selectedPrinterIp = deviceInfo.Target;
                System.Diagnostics.Debug.WriteLine($"Found printer at IP: {_selectedPrinterIp}");
                System.Diagnostics.Debug.WriteLine($"Printer details: {deviceInfo.DeviceName}");
                System.Diagnostics.Debug.WriteLine($"Printer type: {deviceInfo.DeviceType}");
                tcs.TrySetResult(true);
            };

            try
            {
                System.Diagnostics.Debug.WriteLine("Initializing printer discovery...");
                Discovery.Start(Platform.CurrentActivity, filterOption, listener);
                
                var timeoutTask = Task.Delay(10000);
                System.Diagnostics.Debug.WriteLine("Waiting for printer (10 second timeout)...");
                
                var completedTask = await Task.WhenAny(tcs.Task, timeoutTask);
                
                if (completedTask == timeoutTask)
                {
                    System.Diagnostics.Debug.WriteLine("Printer discovery timed out");
                    return false;
                }

                var result = completedTask == tcs.Task && await tcs.Task;
                System.Diagnostics.Debug.WriteLine($"Printer discovery completed. Success: {result}");
                return result;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Printer discovery error: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                return false;
            }
            finally
            {
                System.Diagnostics.Debug.WriteLine("Stopping printer discovery...");
                Discovery.Stop();
                _isDiscovering = false;
                System.Diagnostics.Debug.WriteLine("Printer discovery stopped");
            }
        }

        private async Task PrintInvoice(List<CartItem> items, decimal totalAmount)
        {
            try
            {
                _printer = new Printer(Printer.TmM30iii, LANG_MODEL_ANK, Platform.CurrentActivity);
                string printerAddress = _selectedPrinterIp.Replace("TCP:", "");
                System.Diagnostics.Debug.WriteLine($"Connecting to printer at: {printerAddress}...");
                
                await Task.Delay(1000);
                _printer.Connect($"TCP:{printerAddress}", 30000);
                await Task.Delay(1000);
                
                try
                {
                    _printer.BeginTransaction();
                    
                    _printer.AddTextAlign(ALIGN_CENTER);
                    _printer.AddFeedLine(1);
                    _printer.AddText("=============================\n");
                    _printer.AddText("SALES RECEIPT\n");
                    _printer.AddText("=============================\n\n");

           
                    foreach (var item in items)
                    {
                        _printer.AddText($"{item.ProductName}\n");
                        _printer.AddText($"x{item.Quantity} @ Rs. {item.Price:N2} = Rs. {(item.Price * item.Quantity):N2}\n");
                        _printer.AddFeedLine(1);
                    }

               
                    _printer.AddText("-----------------------------\n");
                    _printer.AddText($"Total Amount: Rs. {totalAmount:N2}\n");
                    
             
                    _printer.AddFeedLine(2);
                    _printer.AddText("Thank you for your purchase!\n");
                    _printer.AddFeedLine(2);
                    

                    _printer.AddCut(CUT_FEED);
                    
                    System.Diagnostics.Debug.WriteLine("Sending data to printer...");
                    _printer.SendData(10000);
                    
                    await Task.Delay(1000);
                    _printer.EndTransaction();
                }
                finally
                {
                    if (_printer != null)
                    {
                        try
                        {
                            await Task.Delay(1000);
                            _printer.Disconnect();
                            System.Diagnostics.Debug.WriteLine("Printer disconnected");
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Disconnect error: {ex.Message}");
                        }
                        _printer = null;
                    }
                }
            }
            catch (Epos2Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Printer error: {GetPrinterErrorMessage(ex.ErrorStatus)}");
                throw;
            }
        }
#endif

        private string GetPrinterErrorMessage(int errorCode) => errorCode switch
        {
            1 => "Invalid printer settings",
            2 => "Connection failed - Check printer power and network",
            3 => "Connection timeout",
            4 => "Printer not found",
            8 => "Paper end or cover open",
            _ => $"Printer error (Code: {errorCode})"
        };

        public void Dispose()
        {
#if ANDROID
            try
            {
                if (_isDiscovering) Discovery.Stop();
                _printer?.Disconnect();
                _printer = null;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Dispose error: {ex.Message}");
            }
#endif
        }
    }

#if ANDROID
    public class DiscoveryListener : Java.Lang.Object, IDiscoveryListener
    {
        public event EventHandler<Com.Epson.Epos2.Discovery.DeviceInfo> OnPrinterFound;

        public void OnDiscovery([GeneratedEnum] Com.Epson.Epos2.Discovery.DeviceInfo deviceInfo)
        {
            if (deviceInfo != null)
                OnPrinterFound?.Invoke(this, deviceInfo);
        }
    }
#endif
}
