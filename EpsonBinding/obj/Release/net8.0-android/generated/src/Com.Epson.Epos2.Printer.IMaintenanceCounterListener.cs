using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='MaintenanceCounterListener']"
	[Register ("com/epson/epos2/printer/MaintenanceCounterListener", "", "Com.Epson.Epos2.Printer.IMaintenanceCounterListenerInvoker")]
	public partial interface IMaintenanceCounterListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='MaintenanceCounterListener']/method[@name='onGetMaintenanceCounter' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onGetMaintenanceCounter", "(III)V", "GetOnGetMaintenanceCounter_IIIHandler:Com.Epson.Epos2.Printer.IMaintenanceCounterListenerInvoker, EpsonBinding")]
		void OnGetMaintenanceCounter (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.printer']/interface[@name='MaintenanceCounterListener']/method[@name='onResetMaintenanceCounter' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onResetMaintenanceCounter", "(II)V", "GetOnResetMaintenanceCounter_IIHandler:Com.Epson.Epos2.Printer.IMaintenanceCounterListenerInvoker, EpsonBinding")]
		void OnResetMaintenanceCounter (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/printer/MaintenanceCounterListener", DoNotGenerateAcw=true)]
	internal partial class IMaintenanceCounterListenerInvoker : global::Java.Lang.Object, IMaintenanceCounterListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/printer/MaintenanceCounterListener", typeof (IMaintenanceCounterListenerInvoker));

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

		public static IMaintenanceCounterListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMaintenanceCounterListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.printer.MaintenanceCounterListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMaintenanceCounterListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onGetMaintenanceCounter_III;
#pragma warning disable 0169
		static Delegate GetOnGetMaintenanceCounter_IIIHandler ()
		{
			if (cb_onGetMaintenanceCounter_III == null)
				cb_onGetMaintenanceCounter_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIII_V (n_OnGetMaintenanceCounter_III));
			return cb_onGetMaintenanceCounter_III;
		}

		static void n_OnGetMaintenanceCounter_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.IMaintenanceCounterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnGetMaintenanceCounter (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onGetMaintenanceCounter_III;
		public unsafe void OnGetMaintenanceCounter (int p0, int p1, int p2)
		{
			if (id_onGetMaintenanceCounter_III == IntPtr.Zero)
				id_onGetMaintenanceCounter_III = JNIEnv.GetMethodID (class_ref, "onGetMaintenanceCounter", "(III)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGetMaintenanceCounter_III, __args);
		}

		static Delegate? cb_onResetMaintenanceCounter_II;
#pragma warning disable 0169
		static Delegate GetOnResetMaintenanceCounter_IIHandler ()
		{
			if (cb_onResetMaintenanceCounter_II == null)
				cb_onResetMaintenanceCounter_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_V (n_OnResetMaintenanceCounter_II));
			return cb_onResetMaintenanceCounter_II;
		}

		static void n_OnResetMaintenanceCounter_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Printer.IMaintenanceCounterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnResetMaintenanceCounter (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onResetMaintenanceCounter_II;
		public unsafe void OnResetMaintenanceCounter (int p0, int p1)
		{
			if (id_onResetMaintenanceCounter_II == IntPtr.Zero)
				id_onResetMaintenanceCounter_II = JNIEnv.GetMethodID (class_ref, "onResetMaintenanceCounter", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResetMaintenanceCounter_II, __args);
		}

	}
}
