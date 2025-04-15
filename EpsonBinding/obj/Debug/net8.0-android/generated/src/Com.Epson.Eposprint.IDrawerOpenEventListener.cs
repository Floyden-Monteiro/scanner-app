using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposprint {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposprint']/interface[@name='DrawerOpenEventListener']"
	[Register ("com/epson/eposprint/DrawerOpenEventListener", "", "Com.Epson.Eposprint.IDrawerOpenEventListenerInvoker")]
	public partial interface IDrawerOpenEventListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposprint']/interface[@name='DrawerOpenEventListener']/method[@name='onDrawerOpenEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onDrawerOpenEvent", "(Ljava/lang/String;)V", "GetOnDrawerOpenEvent_Ljava_lang_String_Handler:Com.Epson.Eposprint.IDrawerOpenEventListenerInvoker, EpsonBinding")]
		void OnDrawerOpenEvent (string? p0);

	}

	[global::Android.Runtime.Register ("com/epson/eposprint/DrawerOpenEventListener", DoNotGenerateAcw=true)]
	internal partial class IDrawerOpenEventListenerInvoker : global::Java.Lang.Object, IDrawerOpenEventListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposprint/DrawerOpenEventListener", typeof (IDrawerOpenEventListenerInvoker));

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

		public static IDrawerOpenEventListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDrawerOpenEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposprint.DrawerOpenEventListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDrawerOpenEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onDrawerOpenEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnDrawerOpenEvent_Ljava_lang_String_Handler ()
		{
			if (cb_onDrawerOpenEvent_Ljava_lang_String_ == null)
				cb_onDrawerOpenEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnDrawerOpenEvent_Ljava_lang_String_));
			return cb_onDrawerOpenEvent_Ljava_lang_String_;
		}

		static void n_OnDrawerOpenEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposprint.IDrawerOpenEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawerOpenEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDrawerOpenEvent_Ljava_lang_String_;
		public unsafe void OnDrawerOpenEvent (string? p0)
		{
			if (id_onDrawerOpenEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_onDrawerOpenEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onDrawerOpenEvent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDrawerOpenEvent_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
