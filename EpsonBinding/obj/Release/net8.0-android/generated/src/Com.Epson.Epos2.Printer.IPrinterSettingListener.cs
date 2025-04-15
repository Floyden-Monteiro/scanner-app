using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='PrinterSettingListener']"
	[Register ("com/epson/epos2/printer/PrinterSettingListener", "", "Com.Epson.Epos2.Printer.IPrinterSettingListenerInvoker")]
	public partial interface IPrinterSettingListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='PrinterSettingListener']/method[@name='onGetPrinterSetting' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onGetPrinterSetting", "(III)V", "GetOnGetPrinterSetting_IIIHandler:Com.Epson.Epos2.Printer.IPrinterSettingListenerInvoker, EpsonBinding")]
		void OnGetPrinterSetting (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='PrinterSettingListener']/method[@name='onSetPrinterSetting' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onSetPrinterSetting", "(I)V", "GetOnSetPrinterSetting_IHandler:Com.Epson.Epos2.Printer.IPrinterSettingListenerInvoker, EpsonBinding")]
		void OnSetPrinterSetting (int p0);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/printer/PrinterSettingListener", DoNotGenerateAcw=true)]
	internal partial class IPrinterSettingListenerInvoker : global::Java.Lang.Object, IPrinterSettingListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/printer/PrinterSettingListener", typeof (IPrinterSettingListenerInvoker));

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

		public static IPrinterSettingListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPrinterSettingListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.printer.PrinterSettingListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPrinterSettingListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onGetPrinterSetting_III;
#pragma warning disable 0169
		static Delegate GetOnGetPrinterSetting_IIIHandler ()
		{
			if (cb_onGetPrinterSetting_III == null)
				cb_onGetPrinterSetting_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_V (n_OnGetPrinterSetting_III));
			return cb_onGetPrinterSetting_III;
		}

		static void n_OnGetPrinterSetting_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.IPrinterSettingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnGetPrinterSetting (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onGetPrinterSetting_III;
		public unsafe void OnGetPrinterSetting (int p0, int p1, int p2)
		{
			if (id_onGetPrinterSetting_III == IntPtr.Zero)
				id_onGetPrinterSetting_III = JNIEnv.GetMethodID (class_ref, "onGetPrinterSetting", "(III)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGetPrinterSetting_III, __args);
		}

		static Delegate? cb_onSetPrinterSetting_I;
#pragma warning disable 0169
		static Delegate GetOnSetPrinterSetting_IHandler ()
		{
			if (cb_onSetPrinterSetting_I == null)
				cb_onSetPrinterSetting_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_V (n_OnSetPrinterSetting_I));
			return cb_onSetPrinterSetting_I;
		}

		static void n_OnSetPrinterSetting_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.IPrinterSettingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnSetPrinterSetting (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSetPrinterSetting_I;
		public unsafe void OnSetPrinterSetting (int p0)
		{
			if (id_onSetPrinterSetting_I == IntPtr.Zero)
				id_onSetPrinterSetting_I = JNIEnv.GetMethodID (class_ref, "onSetPrinterSetting", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSetPrinterSetting_I, __args);
		}

	}
}
