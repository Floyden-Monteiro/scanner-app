using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='ReceiveListener']"
	[Register ("com/epson/epos2/printer/ReceiveListener", "", "Com.Epson.Epos2.Printer.IReceiveListenerInvoker")]
	public partial interface IReceiveListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='ReceiveListener']/method[@name='onPtrReceive' and count(parameter)=4 and parameter[1][@type='com.epson.epos2.printer.Printer'] and parameter[2][@type='int'] and parameter[3][@type='com.epson.epos2.printer.PrinterStatusInfo'] and parameter[4][@type='java.lang.String']]"
		[Register ("onPtrReceive", "(Lcom/epson/epos2/printer/Printer;ILcom/epson/epos2/printer/PrinterStatusInfo;Ljava/lang/String;)V", "GetOnPtrReceive_Lcom_epson_epos2_printer_Printer_ILcom_epson_epos2_printer_PrinterStatusInfo_Ljava_lang_String_Handler:Com.Epson.Epos2.Printer.IReceiveListenerInvoker, EpsonBinding")]
		void OnPtrReceive (global::Com.Epson.Epos2.Printer.Printer? p0, int p1, global::Com.Epson.Epos2.Printer.PrinterStatusInfo? p2, string? p3);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/printer/ReceiveListener", DoNotGenerateAcw=true)]
	internal partial class IReceiveListenerInvoker : global::Java.Lang.Object, IReceiveListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/printer/ReceiveListener", typeof (IReceiveListenerInvoker));

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

		public static IReceiveListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IReceiveListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.printer.ReceiveListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IReceiveListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onPtrReceive_Lcom_epson_epos2_printer_Printer_ILcom_epson_epos2_printer_PrinterStatusInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnPtrReceive_Lcom_epson_epos2_printer_Printer_ILcom_epson_epos2_printer_PrinterStatusInfo_Ljava_lang_String_Handler ()
		{
			if (cb_onPtrReceive_Lcom_epson_epos2_printer_Printer_ILcom_epson_epos2_printer_PrinterStatusInfo_Ljava_lang_String_ == null)
				cb_onPtrReceive_Lcom_epson_epos2_printer_Printer_ILcom_epson_epos2_printer_PrinterStatusInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILL_V (n_OnPtrReceive_Lcom_epson_epos2_printer_Printer_ILcom_epson_epos2_printer_PrinterStatusInfo_Ljava_lang_String_));
			return cb_onPtrReceive_Lcom_epson_epos2_printer_Printer_ILcom_epson_epos2_printer_PrinterStatusInfo_Ljava_lang_String_;
		}

		static void n_OnPtrReceive_Lcom_epson_epos2_printer_Printer_ILcom_epson_epos2_printer_PrinterStatusInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.IReceiveListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.Printer> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.PrinterStatusInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnPtrReceive (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onPtrReceive_Lcom_epson_epos2_printer_Printer_ILcom_epson_epos2_printer_PrinterStatusInfo_Ljava_lang_String_;
		public unsafe void OnPtrReceive (global::Com.Epson.Epos2.Printer.Printer? p0, int p1, global::Com.Epson.Epos2.Printer.PrinterStatusInfo? p2, string? p3)
		{
			if (id_onPtrReceive_Lcom_epson_epos2_printer_Printer_ILcom_epson_epos2_printer_PrinterStatusInfo_Ljava_lang_String_ == IntPtr.Zero)
				id_onPtrReceive_Lcom_epson_epos2_printer_Printer_ILcom_epson_epos2_printer_PrinterStatusInfo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPtrReceive", "(Lcom/epson/epos2/printer/Printer;ILcom/epson/epos2/printer/PrinterStatusInfo;Ljava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString ((string?)p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPtrReceive_Lcom_epson_epos2_printer_Printer_ILcom_epson_epos2_printer_PrinterStatusInfo_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p3);
		}

	}
}
