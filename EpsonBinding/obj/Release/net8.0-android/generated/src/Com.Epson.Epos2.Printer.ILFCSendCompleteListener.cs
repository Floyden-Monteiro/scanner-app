using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='LFCSendCompleteListener']"
	[Register ("com/epson/epos2/printer/LFCSendCompleteListener", "", "Com.Epson.Epos2.Printer.ILFCSendCompleteListenerInvoker")]
	public partial interface ILFCSendCompleteListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='LFCSendCompleteListener']/method[@name='onSendComplete' and count(parameter)=4 and parameter[1][@type='com.epson.epos2.printer.LFCPrinter'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.epson.epos2.printer.LFCPrinterStatusInfo']]"
		[Register ("onSendComplete", "(Lcom/epson/epos2/printer/LFCPrinter;IILcom/epson/epos2/printer/LFCPrinterStatusInfo;)V", "GetOnSendComplete_Lcom_epson_epos2_printer_LFCPrinter_IILcom_epson_epos2_printer_LFCPrinterStatusInfo_Handler:Com.Epson.Epos2.Printer.ILFCSendCompleteListenerInvoker, EpsonBinding")]
		void OnSendComplete (global::Com.Epson.Epos2.Printer.LFCPrinter? p0, int p1, int p2, global::Com.Epson.Epos2.Printer.LFCPrinterStatusInfo? p3);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/printer/LFCSendCompleteListener", DoNotGenerateAcw=true)]
	internal partial class ILFCSendCompleteListenerInvoker : global::Java.Lang.Object, ILFCSendCompleteListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/printer/LFCSendCompleteListener", typeof (ILFCSendCompleteListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ILFCSendCompleteListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILFCSendCompleteListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.printer.LFCSendCompleteListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILFCSendCompleteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onSendComplete_Lcom_epson_epos2_printer_LFCPrinter_IILcom_epson_epos2_printer_LFCPrinterStatusInfo_;
#pragma warning disable 0169
		static Delegate GetOnSendComplete_Lcom_epson_epos2_printer_LFCPrinter_IILcom_epson_epos2_printer_LFCPrinterStatusInfo_Handler ()
		{
			if (cb_onSendComplete_Lcom_epson_epos2_printer_LFCPrinter_IILcom_epson_epos2_printer_LFCPrinterStatusInfo_ == null)
				cb_onSendComplete_Lcom_epson_epos2_printer_LFCPrinter_IILcom_epson_epos2_printer_LFCPrinterStatusInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIL_V (n_OnSendComplete_Lcom_epson_epos2_printer_LFCPrinter_IILcom_epson_epos2_printer_LFCPrinterStatusInfo_));
			return cb_onSendComplete_Lcom_epson_epos2_printer_LFCPrinter_IILcom_epson_epos2_printer_LFCPrinterStatusInfo_;
		}

		static void n_OnSendComplete_Lcom_epson_epos2_printer_LFCPrinter_IILcom_epson_epos2_printer_LFCPrinterStatusInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.ILFCSendCompleteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.LFCPrinter> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.LFCPrinterStatusInfo> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnSendComplete (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onSendComplete_Lcom_epson_epos2_printer_LFCPrinter_IILcom_epson_epos2_printer_LFCPrinterStatusInfo_;
		public unsafe void OnSendComplete (global::Com.Epson.Epos2.Printer.LFCPrinter? p0, int p1, int p2, global::Com.Epson.Epos2.Printer.LFCPrinterStatusInfo? p3)
		{
			if (id_onSendComplete_Lcom_epson_epos2_printer_LFCPrinter_IILcom_epson_epos2_printer_LFCPrinterStatusInfo_ == IntPtr.Zero)
				id_onSendComplete_Lcom_epson_epos2_printer_LFCPrinter_IILcom_epson_epos2_printer_LFCPrinterStatusInfo_ = JNIEnv.GetMethodID (class_ref, "onSendComplete", "(Lcom/epson/epos2/printer/LFCPrinter;IILcom/epson/epos2/printer/LFCPrinterStatusInfo;)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSendComplete_Lcom_epson_epos2_printer_LFCPrinter_IILcom_epson_epos2_printer_LFCPrinterStatusInfo_, __args);
		}

	}
}
