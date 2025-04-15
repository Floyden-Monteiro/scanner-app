using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposdevice.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposdevice.printer']/interface[@name='BatteryStatusChangeListener']"
	[Register ("com/epson/eposdevice/printer/BatteryStatusChangeListener", "", "Com.Epson.Eposdevice.Printer.IBatteryStatusChangeListenerInvoker")]
	public partial interface IBatteryStatusChangeListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.printer']/interface[@name='BatteryStatusChangeListener']/method[@name='onPtrBatteryStatusChange' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("onPtrBatteryStatusChange", "(Ljava/lang/String;Ljava/lang/String;I)V", "GetOnPtrBatteryStatusChange_Ljava_lang_String_Ljava_lang_String_IHandler:Com.Epson.Eposdevice.Printer.IBatteryStatusChangeListenerInvoker, EpsonBinding")]
		void OnPtrBatteryStatusChange (string? p0, string? p1, int p2);

	}

	[global::Android.Runtime.Register ("com/epson/eposdevice/printer/BatteryStatusChangeListener", DoNotGenerateAcw=true)]
	internal partial class IBatteryStatusChangeListenerInvoker : global::Java.Lang.Object, IBatteryStatusChangeListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposdevice/printer/BatteryStatusChangeListener", typeof (IBatteryStatusChangeListenerInvoker));

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

		public static IBatteryStatusChangeListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBatteryStatusChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposdevice.printer.BatteryStatusChangeListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBatteryStatusChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onPtrBatteryStatusChange_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnPtrBatteryStatusChange_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_onPtrBatteryStatusChange_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_onPtrBatteryStatusChange_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLI_V (n_OnPtrBatteryStatusChange_Ljava_lang_String_Ljava_lang_String_I));
			return cb_onPtrBatteryStatusChange_Ljava_lang_String_Ljava_lang_String_I;
		}

		static void n_OnPtrBatteryStatusChange_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Printer.IBatteryStatusChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPtrBatteryStatusChange (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onPtrBatteryStatusChange_Ljava_lang_String_Ljava_lang_String_I;
		public unsafe void OnPtrBatteryStatusChange (string? p0, string? p1, int p2)
		{
			if (id_onPtrBatteryStatusChange_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_onPtrBatteryStatusChange_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onPtrBatteryStatusChange", "(Ljava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPtrBatteryStatusChange_Ljava_lang_String_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
