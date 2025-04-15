using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposprint {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposprint']/interface[@name='CoverOpenEventListener']"
	[Register ("com/epson/eposprint/CoverOpenEventListener", "", "Com.Epson.Eposprint.ICoverOpenEventListenerInvoker")]
	public partial interface ICoverOpenEventListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposprint']/interface[@name='CoverOpenEventListener']/method[@name='onCoverOpenEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onCoverOpenEvent", "(Ljava/lang/String;)V", "GetOnCoverOpenEvent_Ljava_lang_String_Handler:Com.Epson.Eposprint.ICoverOpenEventListenerInvoker, EpsonBinding")]
		void OnCoverOpenEvent (string? p0);

	}

	[global::Android.Runtime.Register ("com/epson/eposprint/CoverOpenEventListener", DoNotGenerateAcw=true)]
	internal partial class ICoverOpenEventListenerInvoker : global::Java.Lang.Object, ICoverOpenEventListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposprint/CoverOpenEventListener", typeof (ICoverOpenEventListenerInvoker));

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

		public static ICoverOpenEventListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICoverOpenEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposprint.CoverOpenEventListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICoverOpenEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCoverOpenEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCoverOpenEvent_Ljava_lang_String_Handler ()
		{
			if (cb_onCoverOpenEvent_Ljava_lang_String_ == null)
				cb_onCoverOpenEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnCoverOpenEvent_Ljava_lang_String_));
			return cb_onCoverOpenEvent_Ljava_lang_String_;
		}

		static void n_OnCoverOpenEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposprint.ICoverOpenEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCoverOpenEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCoverOpenEvent_Ljava_lang_String_;
		public unsafe void OnCoverOpenEvent (string? p0)
		{
			if (id_onCoverOpenEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_onCoverOpenEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCoverOpenEvent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCoverOpenEvent_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
