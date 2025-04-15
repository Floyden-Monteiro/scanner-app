using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='FirmwareUpdateListener']"
	[Register ("com/epson/epos2/printer/FirmwareUpdateListener", "", "Com.Epson.Epos2.Printer.IFirmwareUpdateListenerInvoker")]
	public partial interface IFirmwareUpdateListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='FirmwareUpdateListener']/method[@name='onDownloadFirmwareList' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.epson.epos2.printer.FirmwareInfo[]']]"
		[Register ("onDownloadFirmwareList", "(I[Lcom/epson/epos2/printer/FirmwareInfo;)V", "GetOnDownloadFirmwareList_IarrayLcom_epson_epos2_printer_FirmwareInfo_Handler:Com.Epson.Epos2.Printer.IFirmwareUpdateListenerInvoker, EpsonBinding")]
		void OnDownloadFirmwareList (int p0, global::Com.Epson.Epos2.Printer.FirmwareInfo[]? p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='FirmwareUpdateListener']/method[@name='onFirmwareUpdateProgress' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("onFirmwareUpdateProgress", "(Ljava/lang/String;F)V", "GetOnFirmwareUpdateProgress_Ljava_lang_String_FHandler:Com.Epson.Epos2.Printer.IFirmwareUpdateListenerInvoker, EpsonBinding")]
		void OnFirmwareUpdateProgress (string? p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='FirmwareUpdateListener']/method[@name='onReceiveFirmwareInformation' and count(parameter)=1 and parameter[1][@type='com.epson.epos2.printer.FirmwareInfo']]"
		[Register ("onReceiveFirmwareInformation", "(Lcom/epson/epos2/printer/FirmwareInfo;)V", "GetOnReceiveFirmwareInformation_Lcom_epson_epos2_printer_FirmwareInfo_Handler:Com.Epson.Epos2.Printer.IFirmwareUpdateListenerInvoker, EpsonBinding")]
		void OnReceiveFirmwareInformation (global::Com.Epson.Epos2.Printer.FirmwareInfo? p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='FirmwareUpdateListener']/method[@name='onUpdateFirmware' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onUpdateFirmware", "(II)V", "GetOnUpdateFirmware_IIHandler:Com.Epson.Epos2.Printer.IFirmwareUpdateListenerInvoker, EpsonBinding")]
		void OnUpdateFirmware (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='FirmwareUpdateListener']/method[@name='onUpdateVerify' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onUpdateVerify", "(I)V", "GetOnUpdateVerify_IHandler:Com.Epson.Epos2.Printer.IFirmwareUpdateListenerInvoker, EpsonBinding")]
		void OnUpdateVerify (int p0);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/printer/FirmwareUpdateListener", DoNotGenerateAcw=true)]
	internal partial class IFirmwareUpdateListenerInvoker : global::Java.Lang.Object, IFirmwareUpdateListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/printer/FirmwareUpdateListener", typeof (IFirmwareUpdateListenerInvoker));

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

		public static IFirmwareUpdateListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFirmwareUpdateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.printer.FirmwareUpdateListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFirmwareUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onDownloadFirmwareList_IarrayLcom_epson_epos2_printer_FirmwareInfo_;
#pragma warning disable 0169
		static Delegate GetOnDownloadFirmwareList_IarrayLcom_epson_epos2_printer_FirmwareInfo_Handler ()
		{
			if (cb_onDownloadFirmwareList_IarrayLcom_epson_epos2_printer_FirmwareInfo_ == null)
				cb_onDownloadFirmwareList_IarrayLcom_epson_epos2_printer_FirmwareInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_V (n_OnDownloadFirmwareList_IarrayLcom_epson_epos2_printer_FirmwareInfo_));
			return cb_onDownloadFirmwareList_IarrayLcom_epson_epos2_printer_FirmwareInfo_;
		}

		static void n_OnDownloadFirmwareList_IarrayLcom_epson_epos2_printer_FirmwareInfo_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.IFirmwareUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p1 = (global::Com.Epson.Epos2.Printer.FirmwareInfo[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Epson.Epos2.Printer.FirmwareInfo));
			__this.OnDownloadFirmwareList (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onDownloadFirmwareList_IarrayLcom_epson_epos2_printer_FirmwareInfo_;
		public unsafe void OnDownloadFirmwareList (int p0, global::Com.Epson.Epos2.Printer.FirmwareInfo[]? p1)
		{
			if (id_onDownloadFirmwareList_IarrayLcom_epson_epos2_printer_FirmwareInfo_ == IntPtr.Zero)
				id_onDownloadFirmwareList_IarrayLcom_epson_epos2_printer_FirmwareInfo_ = JNIEnv.GetMethodID (class_ref, "onDownloadFirmwareList", "(I[Lcom/epson/epos2/printer/FirmwareInfo;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDownloadFirmwareList_IarrayLcom_epson_epos2_printer_FirmwareInfo_, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate? cb_onFirmwareUpdateProgress_Ljava_lang_String_F;
#pragma warning disable 0169
		static Delegate GetOnFirmwareUpdateProgress_Ljava_lang_String_FHandler ()
		{
			if (cb_onFirmwareUpdateProgress_Ljava_lang_String_F == null)
				cb_onFirmwareUpdateProgress_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLF_V (n_OnFirmwareUpdateProgress_Ljava_lang_String_F));
			return cb_onFirmwareUpdateProgress_Ljava_lang_String_F;
		}

		static void n_OnFirmwareUpdateProgress_Ljava_lang_String_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.IFirmwareUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFirmwareUpdateProgress (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onFirmwareUpdateProgress_Ljava_lang_String_F;
		public unsafe void OnFirmwareUpdateProgress (string? p0, float p1)
		{
			if (id_onFirmwareUpdateProgress_Ljava_lang_String_F == IntPtr.Zero)
				id_onFirmwareUpdateProgress_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "onFirmwareUpdateProgress", "(Ljava/lang/String;F)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFirmwareUpdateProgress_Ljava_lang_String_F, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate? cb_onReceiveFirmwareInformation_Lcom_epson_epos2_printer_FirmwareInfo_;
#pragma warning disable 0169
		static Delegate GetOnReceiveFirmwareInformation_Lcom_epson_epos2_printer_FirmwareInfo_Handler ()
		{
			if (cb_onReceiveFirmwareInformation_Lcom_epson_epos2_printer_FirmwareInfo_ == null)
				cb_onReceiveFirmwareInformation_Lcom_epson_epos2_printer_FirmwareInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnReceiveFirmwareInformation_Lcom_epson_epos2_printer_FirmwareInfo_));
			return cb_onReceiveFirmwareInformation_Lcom_epson_epos2_printer_FirmwareInfo_;
		}

		static void n_OnReceiveFirmwareInformation_Lcom_epson_epos2_printer_FirmwareInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.IFirmwareUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.FirmwareInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReceiveFirmwareInformation (p0);
		}
#pragma warning restore 0169

		IntPtr id_onReceiveFirmwareInformation_Lcom_epson_epos2_printer_FirmwareInfo_;
		public unsafe void OnReceiveFirmwareInformation (global::Com.Epson.Epos2.Printer.FirmwareInfo? p0)
		{
			if (id_onReceiveFirmwareInformation_Lcom_epson_epos2_printer_FirmwareInfo_ == IntPtr.Zero)
				id_onReceiveFirmwareInformation_Lcom_epson_epos2_printer_FirmwareInfo_ = JNIEnv.GetMethodID (class_ref, "onReceiveFirmwareInformation", "(Lcom/epson/epos2/printer/FirmwareInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceiveFirmwareInformation_Lcom_epson_epos2_printer_FirmwareInfo_, __args);
		}

		static Delegate? cb_onUpdateFirmware_II;
#pragma warning disable 0169
		static Delegate GetOnUpdateFirmware_IIHandler ()
		{
			if (cb_onUpdateFirmware_II == null)
				cb_onUpdateFirmware_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_V (n_OnUpdateFirmware_II));
			return cb_onUpdateFirmware_II;
		}

		static void n_OnUpdateFirmware_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.IFirmwareUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnUpdateFirmware (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onUpdateFirmware_II;
		public unsafe void OnUpdateFirmware (int p0, int p1)
		{
			if (id_onUpdateFirmware_II == IntPtr.Zero)
				id_onUpdateFirmware_II = JNIEnv.GetMethodID (class_ref, "onUpdateFirmware", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateFirmware_II, __args);
		}

		static Delegate? cb_onUpdateVerify_I;
#pragma warning disable 0169
		static Delegate GetOnUpdateVerify_IHandler ()
		{
			if (cb_onUpdateVerify_I == null)
				cb_onUpdateVerify_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_OnUpdateVerify_I));
			return cb_onUpdateVerify_I;
		}

		static void n_OnUpdateVerify_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.IFirmwareUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnUpdateVerify (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUpdateVerify_I;
		public unsafe void OnUpdateVerify (int p0)
		{
			if (id_onUpdateVerify_I == IntPtr.Zero)
				id_onUpdateVerify_I = JNIEnv.GetMethodID (class_ref, "onUpdateVerify", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateVerify_I, __args);
		}

	}
}
