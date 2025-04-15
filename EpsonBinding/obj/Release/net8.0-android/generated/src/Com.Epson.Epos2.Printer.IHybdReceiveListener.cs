using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='HybdReceiveListener']"
	[Register ("com/epson/epos2/printer/HybdReceiveListener", "", "Com.Epson.Epos2.Printer.IHybdReceiveListenerInvoker")]
	public partial interface IHybdReceiveListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='HybdReceiveListener']/method[@name='onHybdReceive' and count(parameter)=5 and parameter[1][@type='com.epson.epos2.printer.HybridPrinter'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.epson.epos2.printer.HybridPrinterStatusInfo']]"
		[Register ("onHybdReceive", "(Lcom/epson/epos2/printer/HybridPrinter;IILjava/lang/String;Lcom/epson/epos2/printer/HybridPrinterStatusInfo;)V", "GetOnHybdReceive_Lcom_epson_epos2_printer_HybridPrinter_IILjava_lang_String_Lcom_epson_epos2_printer_HybridPrinterStatusInfo_Handler:Com.Epson.Epos2.Printer.IHybdReceiveListenerInvoker, EpsonBinding")]
		void OnHybdReceive (global::Com.Epson.Epos2.Printer.HybridPrinter? p0, int p1, int p2, string? p3, global::Com.Epson.Epos2.Printer.HybridPrinterStatusInfo? p4);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/printer/HybdReceiveListener", DoNotGenerateAcw=true)]
	internal partial class IHybdReceiveListenerInvoker : global::Java.Lang.Object, IHybdReceiveListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/printer/HybdReceiveListener", typeof (IHybdReceiveListenerInvoker));

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

		public static IHybdReceiveListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHybdReceiveListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.printer.HybdReceiveListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHybdReceiveListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onHybdReceive_Lcom_epson_epos2_printer_HybridPrinter_IILjava_lang_String_Lcom_epson_epos2_printer_HybridPrinterStatusInfo_;
#pragma warning disable 0169
		static Delegate GetOnHybdReceive_Lcom_epson_epos2_printer_HybridPrinter_IILjava_lang_String_Lcom_epson_epos2_printer_HybridPrinterStatusInfo_Handler ()
		{
			if (cb_onHybdReceive_Lcom_epson_epos2_printer_HybridPrinter_IILjava_lang_String_Lcom_epson_epos2_printer_HybridPrinterStatusInfo_ == null)
				cb_onHybdReceive_Lcom_epson_epos2_printer_HybridPrinter_IILjava_lang_String_Lcom_epson_epos2_printer_HybridPrinterStatusInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIILL_V (n_OnHybdReceive_Lcom_epson_epos2_printer_HybridPrinter_IILjava_lang_String_Lcom_epson_epos2_printer_HybridPrinterStatusInfo_));
			return cb_onHybdReceive_Lcom_epson_epos2_printer_HybridPrinter_IILjava_lang_String_Lcom_epson_epos2_printer_HybridPrinterStatusInfo_;
		}

		static void n_OnHybdReceive_Lcom_epson_epos2_printer_HybridPrinter_IILjava_lang_String_Lcom_epson_epos2_printer_HybridPrinterStatusInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.IHybdReceiveListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.HybridPrinter> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.HybridPrinterStatusInfo> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnHybdReceive (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_onHybdReceive_Lcom_epson_epos2_printer_HybridPrinter_IILjava_lang_String_Lcom_epson_epos2_printer_HybridPrinterStatusInfo_;
		public unsafe void OnHybdReceive (global::Com.Epson.Epos2.Printer.HybridPrinter? p0, int p1, int p2, string? p3, global::Com.Epson.Epos2.Printer.HybridPrinterStatusInfo? p4)
		{
			if (id_onHybdReceive_Lcom_epson_epos2_printer_HybridPrinter_IILjava_lang_String_Lcom_epson_epos2_printer_HybridPrinterStatusInfo_ == IntPtr.Zero)
				id_onHybdReceive_Lcom_epson_epos2_printer_HybridPrinter_IILjava_lang_String_Lcom_epson_epos2_printer_HybridPrinterStatusInfo_ = JNIEnv.GetMethodID (class_ref, "onHybdReceive", "(Lcom/epson/epos2/printer/HybridPrinter;IILjava/lang/String;Lcom/epson/epos2/printer/HybridPrinterStatusInfo;)V");
			IntPtr native_p3 = JNIEnv.NewString ((string?)p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHybdReceive_Lcom_epson_epos2_printer_HybridPrinter_IILjava_lang_String_Lcom_epson_epos2_printer_HybridPrinterStatusInfo_, __args);
			JNIEnv.DeleteLocalRef (native_p3);
		}

	}
}
