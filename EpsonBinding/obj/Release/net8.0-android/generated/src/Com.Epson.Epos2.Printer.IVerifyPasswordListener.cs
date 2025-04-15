using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='VerifyPasswordListener']"
	[Register ("com/epson/epos2/printer/VerifyPasswordListener", "", "Com.Epson.Epos2.Printer.IVerifyPasswordListenerInvoker")]
	public partial interface IVerifyPasswordListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='VerifyPasswordListener']/method[@name='onVerifyPassword' and count(parameter)=2 and parameter[1][@type='com.epson.epos2.printer.Printer'] and parameter[2][@type='int']]"
		[Register ("onVerifyPassword", "(Lcom/epson/epos2/printer/Printer;I)V", "GetOnVerifyPassword_Lcom_epson_epos2_printer_Printer_IHandler:Com.Epson.Epos2.Printer.IVerifyPasswordListenerInvoker, EpsonBinding")]
		void OnVerifyPassword (global::Com.Epson.Epos2.Printer.Printer? p0, int p1);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/printer/VerifyPasswordListener", DoNotGenerateAcw=true)]
	internal partial class IVerifyPasswordListenerInvoker : global::Java.Lang.Object, IVerifyPasswordListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/printer/VerifyPasswordListener", typeof (IVerifyPasswordListenerInvoker));

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

		public static IVerifyPasswordListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVerifyPasswordListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.printer.VerifyPasswordListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVerifyPasswordListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onVerifyPassword_Lcom_epson_epos2_printer_Printer_I;
#pragma warning disable 0169
		static Delegate GetOnVerifyPassword_Lcom_epson_epos2_printer_Printer_IHandler ()
		{
			if (cb_onVerifyPassword_Lcom_epson_epos2_printer_Printer_I == null)
				cb_onVerifyPassword_Lcom_epson_epos2_printer_Printer_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_OnVerifyPassword_Lcom_epson_epos2_printer_Printer_I));
			return cb_onVerifyPassword_Lcom_epson_epos2_printer_Printer_I;
		}

		static void n_OnVerifyPassword_Lcom_epson_epos2_printer_Printer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.IVerifyPasswordListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.Printer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnVerifyPassword (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onVerifyPassword_Lcom_epson_epos2_printer_Printer_I;
		public unsafe void OnVerifyPassword (global::Com.Epson.Epos2.Printer.Printer? p0, int p1)
		{
			if (id_onVerifyPassword_Lcom_epson_epos2_printer_Printer_I == IntPtr.Zero)
				id_onVerifyPassword_Lcom_epson_epos2_printer_Printer_I = JNIEnv.GetMethodID (class_ref, "onVerifyPassword", "(Lcom/epson/epos2/printer/Printer;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVerifyPassword_Lcom_epson_epos2_printer_Printer_I, __args);
		}

	}
}
