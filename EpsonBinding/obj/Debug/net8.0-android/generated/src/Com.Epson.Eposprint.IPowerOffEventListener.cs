using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposprint {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposprint']/interface[@name='PowerOffEventListener']"
	[Register ("com/epson/eposprint/PowerOffEventListener", "", "Com.Epson.Eposprint.IPowerOffEventListenerInvoker")]
	public partial interface IPowerOffEventListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposprint']/interface[@name='PowerOffEventListener']/method[@name='onPowerOffEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onPowerOffEvent", "(Ljava/lang/String;)V", "GetOnPowerOffEvent_Ljava_lang_String_Handler:Com.Epson.Eposprint.IPowerOffEventListenerInvoker, EpsonBinding")]
		void OnPowerOffEvent (string? p0);

	}

	[global::Android.Runtime.Register ("com/epson/eposprint/PowerOffEventListener", DoNotGenerateAcw=true)]
	internal partial class IPowerOffEventListenerInvoker : global::Java.Lang.Object, IPowerOffEventListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposprint/PowerOffEventListener", typeof (IPowerOffEventListenerInvoker));

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

		public static IPowerOffEventListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPowerOffEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposprint.PowerOffEventListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPowerOffEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onPowerOffEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnPowerOffEvent_Ljava_lang_String_Handler ()
		{
			if (cb_onPowerOffEvent_Ljava_lang_String_ == null)
				cb_onPowerOffEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnPowerOffEvent_Ljava_lang_String_));
			return cb_onPowerOffEvent_Ljava_lang_String_;
		}

		static void n_OnPowerOffEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposprint.IPowerOffEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPowerOffEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPowerOffEvent_Ljava_lang_String_;
		public unsafe void OnPowerOffEvent (string? p0)
		{
			if (id_onPowerOffEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_onPowerOffEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPowerOffEvent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPowerOffEvent_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
