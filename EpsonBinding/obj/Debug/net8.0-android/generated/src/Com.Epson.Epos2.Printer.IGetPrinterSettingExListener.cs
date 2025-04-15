using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='GetPrinterSettingExListener']"
	[Register ("com/epson/epos2/printer/GetPrinterSettingExListener", "", "Com.Epson.Epos2.Printer.IGetPrinterSettingExListenerInvoker")]
	public partial interface IGetPrinterSettingExListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='GetPrinterSettingExListener']/method[@name='onGetPrinterSettingEx' and count(parameter)=3 and parameter[1][@type='com.epson.epos2.printer.Printer'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onGetPrinterSettingEx", "(Lcom/epson/epos2/printer/Printer;ILjava/lang/String;)V", "GetOnGetPrinterSettingEx_Lcom_epson_epos2_printer_Printer_ILjava_lang_String_Handler:Com.Epson.Epos2.Printer.IGetPrinterSettingExListenerInvoker, EpsonBinding")]
		void OnGetPrinterSettingEx (global::Com.Epson.Epos2.Printer.Printer? p0, int p1, string? p2);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/printer/GetPrinterSettingExListener", DoNotGenerateAcw=true)]
	internal partial class IGetPrinterSettingExListenerInvoker : global::Java.Lang.Object, IGetPrinterSettingExListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/printer/GetPrinterSettingExListener", typeof (IGetPrinterSettingExListenerInvoker));

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

		public static IGetPrinterSettingExListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGetPrinterSettingExListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.printer.GetPrinterSettingExListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGetPrinterSettingExListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onGetPrinterSettingEx_Lcom_epson_epos2_printer_Printer_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnGetPrinterSettingEx_Lcom_epson_epos2_printer_Printer_ILjava_lang_String_Handler ()
		{
			if (cb_onGetPrinterSettingEx_Lcom_epson_epos2_printer_Printer_ILjava_lang_String_ == null)
				cb_onGetPrinterSettingEx_Lcom_epson_epos2_printer_Printer_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIL_V (n_OnGetPrinterSettingEx_Lcom_epson_epos2_printer_Printer_ILjava_lang_String_));
			return cb_onGetPrinterSettingEx_Lcom_epson_epos2_printer_Printer_ILjava_lang_String_;
		}

		static void n_OnGetPrinterSettingEx_Lcom_epson_epos2_printer_Printer_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.IGetPrinterSettingExListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.Printer> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnGetPrinterSettingEx (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onGetPrinterSettingEx_Lcom_epson_epos2_printer_Printer_ILjava_lang_String_;
		public unsafe void OnGetPrinterSettingEx (global::Com.Epson.Epos2.Printer.Printer? p0, int p1, string? p2)
		{
			if (id_onGetPrinterSettingEx_Lcom_epson_epos2_printer_Printer_ILjava_lang_String_ == IntPtr.Zero)
				id_onGetPrinterSettingEx_Lcom_epson_epos2_printer_Printer_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onGetPrinterSettingEx", "(Lcom/epson/epos2/printer/Printer;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGetPrinterSettingEx_Lcom_epson_epos2_printer_Printer_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}
}
