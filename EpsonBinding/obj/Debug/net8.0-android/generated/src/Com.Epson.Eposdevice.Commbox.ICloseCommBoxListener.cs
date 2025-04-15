using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposdevice.Commbox {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposdevice.commbox']/interface[@name='CloseCommBoxListener']"
	[Register ("com/epson/eposdevice/commbox/CloseCommBoxListener", "", "Com.Epson.Eposdevice.Commbox.ICloseCommBoxListenerInvoker")]
	public partial interface ICloseCommBoxListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.commbox']/interface[@name='CloseCommBoxListener']/method[@name='onCloseCommBox' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onCloseCommBox", "(Ljava/lang/String;II)V", "GetOnCloseCommBox_Ljava_lang_String_IIHandler:Com.Epson.Eposdevice.Commbox.ICloseCommBoxListenerInvoker, EpsonBinding")]
		void OnCloseCommBox (string? p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/epson/eposdevice/commbox/CloseCommBoxListener", DoNotGenerateAcw=true)]
	internal partial class ICloseCommBoxListenerInvoker : global::Java.Lang.Object, ICloseCommBoxListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposdevice/commbox/CloseCommBoxListener", typeof (ICloseCommBoxListenerInvoker));

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

		public static ICloseCommBoxListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICloseCommBoxListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposdevice.commbox.CloseCommBoxListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICloseCommBoxListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCloseCommBox_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetOnCloseCommBox_Ljava_lang_String_IIHandler ()
		{
			if (cb_onCloseCommBox_Ljava_lang_String_II == null)
				cb_onCloseCommBox_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_V (n_OnCloseCommBox_Ljava_lang_String_II));
			return cb_onCloseCommBox_Ljava_lang_String_II;
		}

		static void n_OnCloseCommBox_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Commbox.ICloseCommBoxListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCloseCommBox (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onCloseCommBox_Ljava_lang_String_II;
		public unsafe void OnCloseCommBox (string? p0, int p1, int p2)
		{
			if (id_onCloseCommBox_Ljava_lang_String_II == IntPtr.Zero)
				id_onCloseCommBox_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "onCloseCommBox", "(Ljava/lang/String;II)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCloseCommBox_Ljava_lang_String_II, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.epson.eposdevice.commbox.CloseCommBoxListener.onCloseCommBox
	public partial class CloseCommBoxEventArgs : global::System.EventArgs {
		public CloseCommBoxEventArgs (string? p0, int p1, int p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string? p0;

		public string? P0 {
			get { return p0; }
		}

		int p1;

		public int P1 {
			get { return p1; }
		}

		int p2;

		public int P2 {
			get { return p2; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/eposdevice/commbox/CloseCommBoxListenerImplementor")]
	internal sealed partial class ICloseCommBoxListenerImplementor : global::Java.Lang.Object, ICloseCommBoxListener {

		object? sender;

		public unsafe ICloseCommBoxListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<CloseCommBoxEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnCloseCommBox (string? p0, int p1, int p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CloseCommBoxEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (ICloseCommBoxListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
