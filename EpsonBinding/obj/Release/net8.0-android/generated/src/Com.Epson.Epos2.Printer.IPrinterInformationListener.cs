using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='PrinterInformationListener']"
	[Register ("com/epson/epos2/printer/PrinterInformationListener", "", "Com.Epson.Epos2.Printer.IPrinterInformationListenerInvoker")]
	public partial interface IPrinterInformationListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='PrinterInformationListener']/method[@name='onGetPrinterInformation' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onGetPrinterInformation", "(ILjava/lang/String;)V", "GetOnGetPrinterInformation_ILjava_lang_String_Handler:Com.Epson.Epos2.Printer.IPrinterInformationListenerInvoker, EpsonBinding")]
		void OnGetPrinterInformation (int p0, string? p1);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/printer/PrinterInformationListener", DoNotGenerateAcw=true)]
	internal partial class IPrinterInformationListenerInvoker : global::Java.Lang.Object, IPrinterInformationListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/printer/PrinterInformationListener", typeof (IPrinterInformationListenerInvoker));

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

		public static IPrinterInformationListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPrinterInformationListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.printer.PrinterInformationListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPrinterInformationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onGetPrinterInformation_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnGetPrinterInformation_ILjava_lang_String_Handler ()
		{
			if (cb_onGetPrinterInformation_ILjava_lang_String_ == null)
				cb_onGetPrinterInformation_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_OnGetPrinterInformation_ILjava_lang_String_));
			return cb_onGetPrinterInformation_ILjava_lang_String_;
		}

		static void n_OnGetPrinterInformation_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.IPrinterInformationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnGetPrinterInformation (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onGetPrinterInformation_ILjava_lang_String_;
		public unsafe void OnGetPrinterInformation (int p0, string? p1)
		{
			if (id_onGetPrinterInformation_ILjava_lang_String_ == IntPtr.Zero)
				id_onGetPrinterInformation_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onGetPrinterInformation", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGetPrinterInformation_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
