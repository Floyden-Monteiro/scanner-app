using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Barcodescanner {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.barcodescanner']/interface[@name='ScanListener']"
	[Register ("com/epson/epos2/barcodescanner/ScanListener", "", "Com.Epson.Epos2.Barcodescanner.IScanListenerInvoker")]
	public partial interface IScanListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.barcodescanner']/interface[@name='ScanListener']/method[@name='onScanData' and count(parameter)=2 and parameter[1][@type='com.epson.epos2.barcodescanner.BarcodeScanner'] and parameter[2][@type='java.lang.String']]"
		[Register ("onScanData", "(Lcom/epson/epos2/barcodescanner/BarcodeScanner;Ljava/lang/String;)V", "GetOnScanData_Lcom_epson_epos2_barcodescanner_BarcodeScanner_Ljava_lang_String_Handler:Com.Epson.Epos2.Barcodescanner.IScanListenerInvoker, EpsonBinding")]
		void OnScanData (global::Com.Epson.Epos2.Barcodescanner.BarcodeScanner? p0, string? p1);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/barcodescanner/ScanListener", DoNotGenerateAcw=true)]
	internal partial class IScanListenerInvoker : global::Java.Lang.Object, IScanListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/barcodescanner/ScanListener", typeof (IScanListenerInvoker));

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

		public static IScanListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScanListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.barcodescanner.ScanListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScanListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onScanData_Lcom_epson_epos2_barcodescanner_BarcodeScanner_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnScanData_Lcom_epson_epos2_barcodescanner_BarcodeScanner_Ljava_lang_String_Handler ()
		{
			if (cb_onScanData_Lcom_epson_epos2_barcodescanner_BarcodeScanner_Ljava_lang_String_ == null)
				cb_onScanData_Lcom_epson_epos2_barcodescanner_BarcodeScanner_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnScanData_Lcom_epson_epos2_barcodescanner_BarcodeScanner_Ljava_lang_String_));
			return cb_onScanData_Lcom_epson_epos2_barcodescanner_BarcodeScanner_Ljava_lang_String_;
		}

		static void n_OnScanData_Lcom_epson_epos2_barcodescanner_BarcodeScanner_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Barcodescanner.IScanListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Barcodescanner.BarcodeScanner> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnScanData (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onScanData_Lcom_epson_epos2_barcodescanner_BarcodeScanner_Ljava_lang_String_;
		public unsafe void OnScanData (global::Com.Epson.Epos2.Barcodescanner.BarcodeScanner? p0, string? p1)
		{
			if (id_onScanData_Lcom_epson_epos2_barcodescanner_BarcodeScanner_Ljava_lang_String_ == IntPtr.Zero)
				id_onScanData_Lcom_epson_epos2_barcodescanner_BarcodeScanner_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onScanData", "(Lcom/epson/epos2/barcodescanner/BarcodeScanner;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScanData_Lcom_epson_epos2_barcodescanner_BarcodeScanner_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
