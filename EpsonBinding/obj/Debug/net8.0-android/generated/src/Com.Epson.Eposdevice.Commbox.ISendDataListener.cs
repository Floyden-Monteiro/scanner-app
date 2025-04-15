using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposdevice.Commbox {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposdevice.commbox']/interface[@name='SendDataListener']"
	[Register ("com/epson/eposdevice/commbox/SendDataListener", "", "Com.Epson.Eposdevice.Commbox.ISendDataListenerInvoker")]
	public partial interface ISendDataListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.commbox']/interface[@name='SendDataListener']/method[@name='onCommBoxSendData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onCommBoxSendData", "(Ljava/lang/String;III)V", "GetOnCommBoxSendData_Ljava_lang_String_IIIHandler:Com.Epson.Eposdevice.Commbox.ISendDataListenerInvoker, EpsonBinding")]
		void OnCommBoxSendData (string? p0, int p1, int p2, int p3);

	}

	[global::Android.Runtime.Register ("com/epson/eposdevice/commbox/SendDataListener", DoNotGenerateAcw=true)]
	internal partial class ISendDataListenerInvoker : global::Java.Lang.Object, ISendDataListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposdevice/commbox/SendDataListener", typeof (ISendDataListenerInvoker));

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

		public static ISendDataListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISendDataListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposdevice.commbox.SendDataListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISendDataListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCommBoxSendData_Ljava_lang_String_III;
#pragma warning disable 0169
		static Delegate GetOnCommBoxSendData_Ljava_lang_String_IIIHandler ()
		{
			if (cb_onCommBoxSendData_Ljava_lang_String_III == null)
				cb_onCommBoxSendData_Ljava_lang_String_III = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIII_V (n_OnCommBoxSendData_Ljava_lang_String_III));
			return cb_onCommBoxSendData_Ljava_lang_String_III;
		}

		static void n_OnCommBoxSendData_Ljava_lang_String_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Commbox.ISendDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCommBoxSendData (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onCommBoxSendData_Ljava_lang_String_III;
		public unsafe void OnCommBoxSendData (string? p0, int p1, int p2, int p3)
		{
			if (id_onCommBoxSendData_Ljava_lang_String_III == IntPtr.Zero)
				id_onCommBoxSendData_Ljava_lang_String_III = JNIEnv.GetMethodID (class_ref, "onCommBoxSendData", "(Ljava/lang/String;III)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCommBoxSendData_Ljava_lang_String_III, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.epson.eposdevice.commbox.SendDataListener.onCommBoxSendData
	public partial class SendDataEventArgs : global::System.EventArgs {
		public SendDataEventArgs (string? p0, int p1, int p2, int p3)
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

		int p1;

		public int P1 {
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

	[global::Android.Runtime.Register ("mono/com/epson/eposdevice/commbox/SendDataListenerImplementor")]
	internal sealed partial class ISendDataListenerImplementor : global::Java.Lang.Object, ISendDataListener {

		object? sender;

		public unsafe ISendDataListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<SendDataEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnCommBoxSendData (string? p0, int p1, int p2, int p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new SendDataEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (ISendDataListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
