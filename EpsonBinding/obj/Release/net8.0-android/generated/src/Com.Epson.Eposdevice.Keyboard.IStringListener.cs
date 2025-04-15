using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposdevice.Keyboard {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposdevice.keyboard']/interface[@name='StringListener']"
	[Register ("com/epson/eposdevice/keyboard/StringListener", "", "Com.Epson.Eposdevice.Keyboard.IStringListenerInvoker")]
	public partial interface IStringListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.keyboard']/interface[@name='StringListener']/method[@name='onKbdString' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("onKbdString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "GetOnKbdString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler:Com.Epson.Eposdevice.Keyboard.IStringListenerInvoker, EpsonBinding")]
		void OnKbdString (string? p0, string? p1, string? p2, int p3);

	}

	[global::Android.Runtime.Register ("com/epson/eposdevice/keyboard/StringListener", DoNotGenerateAcw=true)]
	internal partial class IStringListenerInvoker : global::Java.Lang.Object, IStringListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposdevice/keyboard/StringListener", typeof (IStringListenerInvoker));

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

		public static IStringListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStringListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposdevice.keyboard.StringListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStringListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onKbdString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnKbdString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_onKbdString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_onKbdString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLI_V (n_OnKbdString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I));
			return cb_onKbdString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		}

		static void n_OnKbdString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Keyboard.IStringListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnKbdString (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onKbdString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		public unsafe void OnKbdString (string? p0, string? p1, string? p2, int p3)
		{
			if (id_onKbdString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_onKbdString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onKbdString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onKbdString_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	// event args for com.epson.eposdevice.keyboard.StringListener.onKbdString
	public partial class StringEventArgs : global::System.EventArgs {
		public StringEventArgs (string? p0, string? p1, string? p2, int p3)
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

		string? p2;

		public string? P2 {
			get { return p2; }
		}

		int p3;

		public int P3 {
			get { return p3; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/eposdevice/keyboard/StringListenerImplementor")]
	internal sealed partial class IStringListenerImplementor : global::Java.Lang.Object, IStringListener {

		object? sender;

		public unsafe IStringListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<StringEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnKbdString (string? p0, string? p1, string? p2, int p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new StringEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IStringListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
