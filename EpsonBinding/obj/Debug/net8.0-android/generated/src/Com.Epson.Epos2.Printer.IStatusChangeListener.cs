using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='StatusChangeListener']"
	[Register ("com/epson/epos2/printer/StatusChangeListener", "", "Com.Epson.Epos2.Printer.IStatusChangeListenerInvoker")]
	public partial interface IStatusChangeListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='StatusChangeListener']/method[@name='onPtrStatusChange' and count(parameter)=2 and parameter[1][@type='com.epson.epos2.printer.Printer'] and parameter[2][@type='int']]"
		[Register ("onPtrStatusChange", "(Lcom/epson/epos2/printer/Printer;I)V", "GetOnPtrStatusChange_Lcom_epson_epos2_printer_Printer_IHandler:Com.Epson.Epos2.Printer.IStatusChangeListenerInvoker, EpsonBinding")]
		void OnPtrStatusChange (global::Com.Epson.Epos2.Printer.Printer? p0, int p1);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/printer/StatusChangeListener", DoNotGenerateAcw=true)]
	internal partial class IStatusChangeListenerInvoker : global::Java.Lang.Object, IStatusChangeListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/printer/StatusChangeListener", typeof (IStatusChangeListenerInvoker));

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

		public static IStatusChangeListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStatusChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.printer.StatusChangeListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStatusChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onPtrStatusChange_Lcom_epson_epos2_printer_Printer_I;
#pragma warning disable 0169
		static Delegate GetOnPtrStatusChange_Lcom_epson_epos2_printer_Printer_IHandler ()
		{
			if (cb_onPtrStatusChange_Lcom_epson_epos2_printer_Printer_I == null)
				cb_onPtrStatusChange_Lcom_epson_epos2_printer_Printer_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_OnPtrStatusChange_Lcom_epson_epos2_printer_Printer_I));
			return cb_onPtrStatusChange_Lcom_epson_epos2_printer_Printer_I;
		}

		static void n_OnPtrStatusChange_Lcom_epson_epos2_printer_Printer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.IStatusChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.Printer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPtrStatusChange (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPtrStatusChange_Lcom_epson_epos2_printer_Printer_I;
		public unsafe void OnPtrStatusChange (global::Com.Epson.Epos2.Printer.Printer? p0, int p1)
		{
			if (id_onPtrStatusChange_Lcom_epson_epos2_printer_Printer_I == IntPtr.Zero)
				id_onPtrStatusChange_Lcom_epson_epos2_printer_Printer_I = JNIEnv.GetMethodID (class_ref, "onPtrStatusChange", "(Lcom/epson/epos2/printer/Printer;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPtrStatusChange_Lcom_epson_epos2_printer_Printer_I, __args);
		}

	}
}
