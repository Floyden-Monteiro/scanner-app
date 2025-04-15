using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='LFCPrintCompleteListener']"
	[Register ("com/epson/epos2/printer/LFCPrintCompleteListener", "", "Com.Epson.Epos2.Printer.ILFCPrintCompleteListenerInvoker")]
	public partial interface ILFCPrintCompleteListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='LFCPrintCompleteListener']/method[@name='onPrintComplete' and count(parameter)=2 and parameter[1][@type='com.epson.epos2.printer.LFCPrinter'] and parameter[2][@type='int']]"
		[Register ("onPrintComplete", "(Lcom/epson/epos2/printer/LFCPrinter;I)V", "GetOnPrintComplete_Lcom_epson_epos2_printer_LFCPrinter_IHandler:Com.Epson.Epos2.Printer.ILFCPrintCompleteListenerInvoker, EpsonBinding")]
		void OnPrintComplete (global::Com.Epson.Epos2.Printer.LFCPrinter? p0, int p1);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/printer/LFCPrintCompleteListener", DoNotGenerateAcw=true)]
	internal partial class ILFCPrintCompleteListenerInvoker : global::Java.Lang.Object, ILFCPrintCompleteListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/printer/LFCPrintCompleteListener", typeof (ILFCPrintCompleteListenerInvoker));

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

		public static ILFCPrintCompleteListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILFCPrintCompleteListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.printer.LFCPrintCompleteListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILFCPrintCompleteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onPrintComplete_Lcom_epson_epos2_printer_LFCPrinter_I;
#pragma warning disable 0169
		static Delegate GetOnPrintComplete_Lcom_epson_epos2_printer_LFCPrinter_IHandler ()
		{
			if (cb_onPrintComplete_Lcom_epson_epos2_printer_LFCPrinter_I == null)
				cb_onPrintComplete_Lcom_epson_epos2_printer_LFCPrinter_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_OnPrintComplete_Lcom_epson_epos2_printer_LFCPrinter_I));
			return cb_onPrintComplete_Lcom_epson_epos2_printer_LFCPrinter_I;
		}

		static void n_OnPrintComplete_Lcom_epson_epos2_printer_LFCPrinter_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.ILFCPrintCompleteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.LFCPrinter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPrintComplete (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPrintComplete_Lcom_epson_epos2_printer_LFCPrinter_I;
		public unsafe void OnPrintComplete (global::Com.Epson.Epos2.Printer.LFCPrinter? p0, int p1)
		{
			if (id_onPrintComplete_Lcom_epson_epos2_printer_LFCPrinter_I == IntPtr.Zero)
				id_onPrintComplete_Lcom_epson_epos2_printer_LFCPrinter_I = JNIEnv.GetMethodID (class_ref, "onPrintComplete", "(Lcom/epson/epos2/printer/LFCPrinter;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPrintComplete_Lcom_epson_epos2_printer_LFCPrinter_I, __args);
		}

	}
}
