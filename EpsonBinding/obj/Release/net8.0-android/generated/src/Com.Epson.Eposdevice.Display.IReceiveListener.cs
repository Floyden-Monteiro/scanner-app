using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposdevice.Display {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposdevice.display']/interface[@name='ReceiveListener']"
	[Register ("com/epson/eposdevice/display/ReceiveListener", "", "Com.Epson.Eposdevice.Display.IReceiveListenerInvoker")]
	public partial interface IReceiveListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.display']/interface[@name='ReceiveListener']/method[@name='onDspReceive' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onDspReceive", "(Ljava/lang/String;Ljava/lang/String;II)V", "GetOnDspReceive_Ljava_lang_String_Ljava_lang_String_IIHandler:Com.Epson.Eposdevice.Display.IReceiveListenerInvoker, EpsonBinding")]
		void OnDspReceive (string? p0, string? p1, int p2, int p3);

	}

	[global::Android.Runtime.Register ("com/epson/eposdevice/display/ReceiveListener", DoNotGenerateAcw=true)]
	internal partial class IReceiveListenerInvoker : global::Java.Lang.Object, IReceiveListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposdevice/display/ReceiveListener", typeof (IReceiveListenerInvoker));

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

		public static IReceiveListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IReceiveListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposdevice.display.ReceiveListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IReceiveListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onDspReceive_Ljava_lang_String_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetOnDspReceive_Ljava_lang_String_Ljava_lang_String_IIHandler ()
		{
			if (cb_onDspReceive_Ljava_lang_String_Ljava_lang_String_II == null)
				cb_onDspReceive_Ljava_lang_String_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLII_V (n_OnDspReceive_Ljava_lang_String_Ljava_lang_String_II));
			return cb_onDspReceive_Ljava_lang_String_Ljava_lang_String_II;
		}

		static void n_OnDspReceive_Ljava_lang_String_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Display.IReceiveListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnDspReceive (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onDspReceive_Ljava_lang_String_Ljava_lang_String_II;
		public unsafe void OnDspReceive (string? p0, string? p1, int p2, int p3)
		{
			if (id_onDspReceive_Ljava_lang_String_Ljava_lang_String_II == IntPtr.Zero)
				id_onDspReceive_Ljava_lang_String_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "onDspReceive", "(Ljava/lang/String;Ljava/lang/String;II)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDspReceive_Ljava_lang_String_Ljava_lang_String_II, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	// event args for com.epson.eposdevice.display.ReceiveListener.onDspReceive
	public partial class ReceiveEventArgs : global::System.EventArgs {
		public ReceiveEventArgs (string? p0, string? p1, int p2, int p3)
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

		int p3;

		public int P3 {
			get { return p3; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/eposdevice/display/ReceiveListenerImplementor")]
	internal sealed partial class IReceiveListenerImplementor : global::Java.Lang.Object, IReceiveListener {

		object? sender;

		public unsafe IReceiveListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<ReceiveEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnDspReceive (string? p0, string? p1, int p2, int p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ReceiveEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IReceiveListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
