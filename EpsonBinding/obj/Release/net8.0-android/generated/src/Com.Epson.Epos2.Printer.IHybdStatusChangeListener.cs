using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='HybdStatusChangeListener']"
	[Register ("com/epson/epos2/printer/HybdStatusChangeListener", "", "Com.Epson.Epos2.Printer.IHybdStatusChangeListenerInvoker")]
	public partial interface IHybdStatusChangeListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='HybdStatusChangeListener']/method[@name='onHybdStatusChange' and count(parameter)=2 and parameter[1][@type='com.epson.epos2.printer.HybridPrinter'] and parameter[2][@type='int']]"
		[Register ("onHybdStatusChange", "(Lcom/epson/epos2/printer/HybridPrinter;I)V", "GetOnHybdStatusChange_Lcom_epson_epos2_printer_HybridPrinter_IHandler:Com.Epson.Epos2.Printer.IHybdStatusChangeListenerInvoker, EpsonBinding")]
		void OnHybdStatusChange (global::Com.Epson.Epos2.Printer.HybridPrinter? p0, int p1);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/printer/HybdStatusChangeListener", DoNotGenerateAcw=true)]
	internal partial class IHybdStatusChangeListenerInvoker : global::Java.Lang.Object, IHybdStatusChangeListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/printer/HybdStatusChangeListener", typeof (IHybdStatusChangeListenerInvoker));

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

		public static IHybdStatusChangeListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHybdStatusChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.printer.HybdStatusChangeListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHybdStatusChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onHybdStatusChange_Lcom_epson_epos2_printer_HybridPrinter_I;
#pragma warning disable 0169
		static Delegate GetOnHybdStatusChange_Lcom_epson_epos2_printer_HybridPrinter_IHandler ()
		{
			if (cb_onHybdStatusChange_Lcom_epson_epos2_printer_HybridPrinter_I == null)
				cb_onHybdStatusChange_Lcom_epson_epos2_printer_HybridPrinter_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_OnHybdStatusChange_Lcom_epson_epos2_printer_HybridPrinter_I));
			return cb_onHybdStatusChange_Lcom_epson_epos2_printer_HybridPrinter_I;
		}

		static void n_OnHybdStatusChange_Lcom_epson_epos2_printer_HybridPrinter_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.IHybdStatusChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.HybridPrinter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHybdStatusChange (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onHybdStatusChange_Lcom_epson_epos2_printer_HybridPrinter_I;
		public unsafe void OnHybdStatusChange (global::Com.Epson.Epos2.Printer.HybridPrinter? p0, int p1)
		{
			if (id_onHybdStatusChange_Lcom_epson_epos2_printer_HybridPrinter_I == IntPtr.Zero)
				id_onHybdStatusChange_Lcom_epson_epos2_printer_HybridPrinter_I = JNIEnv.GetMethodID (class_ref, "onHybdStatusChange", "(Lcom/epson/epos2/printer/HybridPrinter;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHybdStatusChange_Lcom_epson_epos2_printer_HybridPrinter_I, __args);
		}

	}
}
