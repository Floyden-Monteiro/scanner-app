using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposdevice.Keyboard {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposdevice.keyboard']/interface[@name='KeyPressListener']"
	[Register ("com/epson/eposdevice/keyboard/KeyPressListener", "", "Com.Epson.Eposdevice.Keyboard.IKeyPressListenerInvoker")]
	public partial interface IKeyPressListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.keyboard']/interface[@name='KeyPressListener']/method[@name='onKbdKeyPress' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("onKbdKeyPress", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", "GetOnKbdKeyPress_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Handler:Com.Epson.Eposdevice.Keyboard.IKeyPressListenerInvoker, EpsonBinding")]
		void OnKbdKeyPress (string? p0, string? p1, int p2, string? p3);

	}

	[global::Android.Runtime.Register ("com/epson/eposdevice/keyboard/KeyPressListener", DoNotGenerateAcw=true)]
	internal partial class IKeyPressListenerInvoker : global::Java.Lang.Object, IKeyPressListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposdevice/keyboard/KeyPressListener", typeof (IKeyPressListenerInvoker));

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

		public static IKeyPressListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IKeyPressListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposdevice.keyboard.KeyPressListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IKeyPressListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onKbdKeyPress_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnKbdKeyPress_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Handler ()
		{
			if (cb_onKbdKeyPress_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ == null)
				cb_onKbdKeyPress_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLIL_V (n_OnKbdKeyPress_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_));
			return cb_onKbdKeyPress_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_;
		}

		static void n_OnKbdKeyPress_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Keyboard.IKeyPressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnKbdKeyPress (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onKbdKeyPress_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_;
		public unsafe void OnKbdKeyPress (string? p0, string? p1, int p2, string? p3)
		{
			if (id_onKbdKeyPress_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
				id_onKbdKeyPress_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onKbdKeyPress", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p3 = JNIEnv.NewString ((string?)p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onKbdKeyPress_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
		}

	}

	// event args for com.epson.eposdevice.keyboard.KeyPressListener.onKbdKeyPress
	public partial class KeyPressEventArgs : global::System.EventArgs {
		public KeyPressEventArgs (string? p0, string? p1, int p2, string? p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		string? p0;

		public string? P0 {
			get { return p0; }
		}

		string? p1;

		public string? P1 {
			get { return p1; }
		}

		int p2;

		public int P2 {
			get { return p2; }
		}

		string? p3;

		public string? P3 {
			get { return p3; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/eposdevice/keyboard/KeyPressListenerImplementor")]
	internal sealed partial class IKeyPressListenerImplementor : global::Java.Lang.Object, IKeyPressListener {

		object? sender;

		public unsafe IKeyPressListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;
			var h = JniPeerMembers.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
			SetHandle (h.Handle, JniHandleOwnership.TransferLocalRef);
			JniPeerMembers.InstanceMethods.FinishCreateInstance (__id, this, null);
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<KeyPressEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnKbdKeyPress (string? p0, string? p1, int p2, string? p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new KeyPressEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IKeyPressListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
