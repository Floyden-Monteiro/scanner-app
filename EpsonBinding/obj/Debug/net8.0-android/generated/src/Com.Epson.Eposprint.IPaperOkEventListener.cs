using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposprint {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposprint']/interface[@name='PaperOkEventListener']"
	[Register ("com/epson/eposprint/PaperOkEventListener", "", "Com.Epson.Eposprint.IPaperOkEventListenerInvoker")]
	public partial interface IPaperOkEventListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposprint']/interface[@name='PaperOkEventListener']/method[@name='onPaperOkEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onPaperOkEvent", "(Ljava/lang/String;)V", "GetOnPaperOkEvent_Ljava_lang_String_Handler:Com.Epson.Eposprint.IPaperOkEventListenerInvoker, EpsonBinding")]
		void OnPaperOkEvent (string? p0);

	}

	[global::Android.Runtime.Register ("com/epson/eposprint/PaperOkEventListener", DoNotGenerateAcw=true)]
	internal partial class IPaperOkEventListenerInvoker : global::Java.Lang.Object, IPaperOkEventListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposprint/PaperOkEventListener", typeof (IPaperOkEventListenerInvoker));

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

		public static IPaperOkEventListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPaperOkEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposprint.PaperOkEventListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPaperOkEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onPaperOkEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnPaperOkEvent_Ljava_lang_String_Handler ()
		{
			if (cb_onPaperOkEvent_Ljava_lang_String_ == null)
				cb_onPaperOkEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnPaperOkEvent_Ljava_lang_String_));
			return cb_onPaperOkEvent_Ljava_lang_String_;
		}

		static void n_OnPaperOkEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposprint.IPaperOkEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPaperOkEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPaperOkEvent_Ljava_lang_String_;
		public unsafe void OnPaperOkEvent (string? p0)
		{
			if (id_onPaperOkEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_onPaperOkEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPaperOkEvent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPaperOkEvent_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
