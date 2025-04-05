using System.IO;
using scannermaui.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace scannermaui.Services
{
    public class PrintService
    {
        private readonly IServiceProvider _serviceProvider;

        public PrintService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

        }

        public async Task PrintInvoice(List<CartItem> items, decimal totalAmount)
        {
            try
            {

                Random random = new Random();
                string invoiceNumber = $"INV-{DateTime.Now:yyyyMM}-{random.Next(1000, 9999)}";

                string directoryPath = Path.Combine(FileSystem.AppDataDirectory, "Invoices");
                Directory.CreateDirectory(directoryPath);

                string fileName = $"invoice_{DateTime.Now:yyyyMMddHHmmss}.pdf";
                string tempPdfPath = Path.Combine(directoryPath, fileName);

                using (var fs = new FileStream(tempPdfPath, FileMode.Create))
                {
                    var document = new Document(PageSize.A4, 50, 50, 50, 50);
                    var writer = PdfWriter.GetInstance(document, fs);
                    document.Open();


                    var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                    var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);


                    var header = new Paragraph("INVOICE", titleFont);
                    header.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    document.Add(header);
                    document.Add(new Paragraph("\n"));


                    var headerTable = new PdfPTable(2);
                    headerTable.WidthPercentage = 100;
                    headerTable.SetWidths(new float[] { 1f, 1f });


                    var dateCell = new PdfPCell(new Phrase($"Date: {DateTime.Now:dd/MM/yyyy HH:mm}", normalFont));
                    dateCell.Border = Rectangle.NO_BORDER;
                    dateCell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
                    headerTable.AddCell(dateCell);


                    var invoiceCell = new PdfPCell(new Phrase($"Invoice #: {invoiceNumber}", normalFont));
                    invoiceCell.Border = Rectangle.NO_BORDER;
                    invoiceCell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                    headerTable.AddCell(invoiceCell);

                    document.Add(headerTable);
                    document.Add(new Paragraph("\n"));

                    var table = new PdfPTable(4);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 3f, 1f, 1f, 1f });


                    var headerStyle = new PdfPCell
                    {
                        BackgroundColor = new BaseColor(240, 240, 240),
                        Padding = 5
                    };


                    table.AddCell(new PdfPCell(new Phrase("Item", titleFont)) { BackgroundColor = headerStyle.BackgroundColor, Padding = 5 });
                    table.AddCell(new PdfPCell(new Phrase("Qty", titleFont)) { BackgroundColor = headerStyle.BackgroundColor, Padding = 5 });
                    table.AddCell(new PdfPCell(new Phrase("Price", titleFont)) { BackgroundColor = headerStyle.BackgroundColor, Padding = 5 });
                    table.AddCell(new PdfPCell(new Phrase("Total", titleFont)) { BackgroundColor = headerStyle.BackgroundColor, Padding = 5 });


                    foreach (var item in items)
                    {
                        table.AddCell(new PdfPCell(new Phrase(item.ProductName, normalFont)) { Padding = 5 });
                        table.AddCell(new PdfPCell(new Phrase(item.Quantity.ToString(), normalFont)) { Padding = 5 });
                        table.AddCell(new PdfPCell(new Phrase($"₹{item.Price:N2}", normalFont)) { Padding = 5 });
                        table.AddCell(new PdfPCell(new Phrase($"₹{(item.Price * item.Quantity):N2}", normalFont)) { Padding = 5 });
                    }

                    document.Add(table);
                    document.Add(new Paragraph("\n"));


                    var total = new Paragraph($"Total Amount: ₹{totalAmount:N2}", titleFont);
                    total.Alignment = iTextSharp.text.Element.ALIGN_RIGHT;
                    document.Add(total);

                    document.Close();
                }
                if (File.Exists(tempPdfPath))
                {
                    await Share.RequestAsync(new ShareFileRequest
                    {
                        File = new ShareFile(tempPdfPath)
                    });
                    File.Delete(tempPdfPath);
                }

                // if (File.Exists(tempPdfPath))
                // {
                //     try
                //     {
                //         await _platformPrintService.PrintFile(tempPdfPath);
                //         await Shell.Current.DisplayAlert("Success", "Sent to printer", "OK");
                //     }
                //     catch (Exception printEx)
                //     {
                //         await Shell.Current.DisplayAlert("Printer Error",
                //             "Please check if printer is connected", "OK");
                //     }
                //     finally
                //     {
                //         File.Delete(tempPdfPath);
                //     }
                // }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}