using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposprint {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposprint']/interface[@name='StatusChangeEventListener']"
	[Register ("com/epson/eposprint/StatusChangeEventListener", "", "Com.Epson.Eposprint.IStatusChangeEventListenerInvoker")]
	public partial interface IStatusChangeEventListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposprint']/interface[@name='StatusChangeEventListener']/method[@name='onStatusChangeEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onStatusChangeEvent", "(Ljava/lang/String;I)V", "GetOnStatusChangeEvent_Ljava_lang_String_IHandler:Com.Epson.Eposprint.IStatusChangeEventListenerInvoker, EpsonBinding")]
		void OnStatusChangeEvent (string? p0, int p1);

	}

	[global::Android.Runtime.Register ("com/epson/eposprint/StatusChangeEventListener", DoNotGenerateAcw=true)]
	internal partial class IStatusChangeEventListenerInvoker : global::Java.Lang.Object, IStatusChangeEventListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposprint/StatusChangeEventListener", typeof (IStatusChangeEventListenerInvoker));

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

		public static IStatusChangeEventListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStatusChangeEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposprint.StatusChangeEventListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStatusChangeEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onStatusChangeEvent_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnStatusChangeEvent_Ljava_lang_String_IHandler ()
		{
			if (cb_onStatusChangeEvent_Ljava_lang_String_I == null)
				cb_onStatusChangeEvent_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_OnStatusChangeEvent_Ljava_lang_String_I));
			return cb_onStatusChangeEvent_Ljava_lang_String_I;
		}

		static void n_OnStatusChangeEvent_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposprint.IStatusChangeEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStatusChangeEvent (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onStatusChangeEvent_Ljava_lang_String_I;
		public unsafe void OnStatusChangeEvent (string? p0, int p1)
		{
			if (id_onStatusChangeEvent_Ljava_lang_String_I == IntPtr.Zero)
				id_onStatusChangeEvent_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onStatusChangeEvent", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStatusChangeEvent_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
