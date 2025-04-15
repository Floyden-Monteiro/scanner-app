using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Cashchanger {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.cashchanger']/interface[@name='DirectIOCommandReplyListener']"
	[Register ("com/epson/epos2/cashchanger/DirectIOCommandReplyListener", "", "Com.Epson.Epos2.Cashchanger.IDirectIOCommandReplyListenerInvoker")]
	public partial interface IDirectIOCommandReplyListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.cashchanger']/interface[@name='DirectIOCommandReplyListener']/method[@name='onCChangerDirectIOCommandReply' and count(parameter)=5 and parameter[1][@type='com.epson.epos2.cashchanger.CashChanger'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register ("onCChangerDirectIOCommandReply", "(Lcom/epson/epos2/cashchanger/CashChanger;IIILjava/lang/String;)V", "GetOnCChangerDirectIOCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_lang_String_Handler:Com.Epson.Epos2.Cashchanger.IDirectIOCommandReplyListenerInvoker, EpsonBinding")]
		void OnCChangerDirectIOCommandReply (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1, int p2, int p3, string? p4);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/cashchanger/DirectIOCommandReplyListener", DoNotGenerateAcw=true)]
	internal partial class IDirectIOCommandReplyListenerInvoker : global::Java.Lang.Object, IDirectIOCommandReplyListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/cashchanger/DirectIOCommandReplyListener", typeof (IDirectIOCommandReplyListenerInvoker));

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

		public static IDirectIOCommandReplyListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDirectIOCommandReplyListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.cashchanger.DirectIOCommandReplyListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDirectIOCommandReplyListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCChangerDirectIOCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCChangerDirectIOCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_lang_String_Handler ()
		{
			if (cb_onCChangerDirectIOCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_lang_String_ == null)
				cb_onCChangerDirectIOCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIIL_V (n_OnCChangerDirectIOCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_lang_String_));
			return cb_onCChangerDirectIOCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_lang_String_;
		}

		static void n_OnCChangerDirectIOCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cashchanger.IDirectIOCommandReplyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cashchanger.CashChanger> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnCChangerDirectIOCommandReply (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_onCChangerDirectIOCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_lang_String_;
		public unsafe void OnCChangerDirectIOCommandReply (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1, int p2, int p3, string? p4)
		{
			if (id_onCChangerDirectIOCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_lang_String_ == IntPtr.Zero)
				id_onCChangerDirectIOCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCChangerDirectIOCommandReply", "(Lcom/epson/epos2/cashchanger/CashChanger;IIILjava/lang/String;)V");
			IntPtr native_p4 = JNIEnv.NewString ((string?)p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCChangerDirectIOCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p4);
		}

	}

	// event args for com.epson.epos2.cashchanger.DirectIOCommandReplyListener.onCChangerDirectIOCommandReply
	public partial class DirectIOCommandReplyEventArgs : global::System.EventArgs {
		public DirectIOCommandReplyEventArgs (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1, int p2, int p3, string? p4)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
		}

		global::Com.Epson.Epos2.Cashchanger.CashChanger? p0;

		public global::Com.Epson.Epos2.Cashchanger.CashChanger? P0 {
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

		string? p4;

		public string? P4 {
			get { return p4; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/epos2/cashchanger/DirectIOCommandReplyListenerImplementor")]
	internal sealed partial class IDirectIOCommandReplyListenerImplementor : global::Java.Lang.Object, IDirectIOCommandReplyListener {

		object? sender;

		public unsafe IDirectIOCommandReplyListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<DirectIOCommandReplyEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnCChangerDirectIOCommandReply (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1, int p2, int p3, string? p4)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DirectIOCommandReplyEventArgs (p0, p1, p2, p3, p4));
		}

		internal static bool __IsEmpty (IDirectIOCommandReplyListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
