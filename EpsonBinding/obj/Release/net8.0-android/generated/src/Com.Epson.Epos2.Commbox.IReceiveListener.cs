using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Commbox {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.commbox']/interface[@name='ReceiveListener']"
	[Register ("com/epson/epos2/commbox/ReceiveListener", "", "Com.Epson.Epos2.Commbox.IReceiveListenerInvoker")]
	public partial interface IReceiveListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.commbox']/interface[@name='ReceiveListener']/method[@name='onCommBoxReceive' and count(parameter)=4 and parameter[1][@type='com.epson.epos2.commbox.CommBox'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("onCommBoxReceive", "(Lcom/epson/epos2/commbox/CommBox;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnCommBoxReceive_Lcom_epson_epos2_commbox_CommBox_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Epson.Epos2.Commbox.IReceiveListenerInvoker, EpsonBinding")]
		void OnCommBoxReceive (global::Com.Epson.Epos2.Commbox.CommBox? p0, string? p1, string? p2, string? p3);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/commbox/ReceiveListener", DoNotGenerateAcw=true)]
	internal partial class IReceiveListenerInvoker : global::Java.Lang.Object, IReceiveListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/commbox/ReceiveListener", typeof (IReceiveListenerInvoker));

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
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.commbox.ReceiveListener'.");
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

		static Delegate? cb_onCommBoxReceive_Lcom_epson_epos2_commbox_CommBox_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCommBoxReceive_Lcom_epson_epos2_commbox_CommBox_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onCommBoxReceive_Lcom_epson_epos2_commbox_CommBox_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onCommBoxReceive_Lcom_epson_epos2_commbox_CommBox_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_V (n_OnCommBoxReceive_Lcom_epson_epos2_commbox_CommBox_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_));
			return cb_onCommBoxReceive_Lcom_epson_epos2_commbox_CommBox_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnCommBoxReceive_Lcom_epson_epos2_commbox_CommBox_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Commbox.IReceiveListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Commbox.CommBox> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnCommBoxReceive (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onCommBoxReceive_Lcom_epson_epos2_commbox_CommBox_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnCommBoxReceive (global::Com.Epson.Epos2.Commbox.CommBox? p0, string? p1, string? p2, string? p3)
		{
			if (id_onCommBoxReceive_Lcom_epson_epos2_commbox_CommBox_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onCommBoxReceive_Lcom_epson_epos2_commbox_CommBox_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCommBoxReceive", "(Lcom/epson/epos2/commbox/CommBox;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			IntPtr native_p3 = JNIEnv.NewString ((string?)p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCommBoxReceive_Lcom_epson_epos2_commbox_CommBox_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

	}

	// event args for com.epson.epos2.commbox.ReceiveListener.onCommBoxReceive
	public partial class ReceiveEventArgs : global::System.EventArgs {
		public ReceiveEventArgs (global::Com.Epson.Epos2.Commbox.CommBox? p0, string? p1, string? p2, string? p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		global::Com.Epson.Epos2.Commbox.CommBox? p0;

		public global::Com.Epson.Epos2.Commbox.CommBox? P0 {
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

		string? p3;

		public string? P3 {
			get { return p3; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/epos2/commbox/ReceiveListenerImplementor")]
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

		public void OnCommBoxReceive (global::Com.Epson.Epos2.Commbox.CommBox? p0, string? p1, string? p2, string? p3)
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
