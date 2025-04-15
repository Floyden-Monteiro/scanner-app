using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Commbox {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.commbox']/interface[@name='SendMessageCallback']"
	[Register ("com/epson/epos2/commbox/SendMessageCallback", "", "Com.Epson.Epos2.Commbox.ISendMessageCallbackInvoker")]
	public partial interface ISendMessageCallback : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.commbox']/interface[@name='SendMessageCallback']/method[@name='onCommBoxSendMessage' and count(parameter)=3 and parameter[1][@type='com.epson.epos2.commbox.CommBox'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onCommBoxSendMessage", "(Lcom/epson/epos2/commbox/CommBox;II)V", "GetOnCommBoxSendMessage_Lcom_epson_epos2_commbox_CommBox_IIHandler:Com.Epson.Epos2.Commbox.ISendMessageCallbackInvoker, EpsonBinding")]
		void OnCommBoxSendMessage (global::Com.Epson.Epos2.Commbox.CommBox? p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/commbox/SendMessageCallback", DoNotGenerateAcw=true)]
	internal partial class ISendMessageCallbackInvoker : global::Java.Lang.Object, ISendMessageCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/commbox/SendMessageCallback", typeof (ISendMessageCallbackInvoker));

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

		public static ISendMessageCallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISendMessageCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.commbox.SendMessageCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISendMessageCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCommBoxSendMessage_Lcom_epson_epos2_commbox_CommBox_II;
#pragma warning disable 0169
		static Delegate GetOnCommBoxSendMessage_Lcom_epson_epos2_commbox_CommBox_IIHandler ()
		{
			if (cb_onCommBoxSendMessage_Lcom_epson_epos2_commbox_CommBox_II == null)
				cb_onCommBoxSendMessage_Lcom_epson_epos2_commbox_CommBox_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_V (n_OnCommBoxSendMessage_Lcom_epson_epos2_commbox_CommBox_II));
			return cb_onCommBoxSendMessage_Lcom_epson_epos2_commbox_CommBox_II;
		}

		static void n_OnCommBoxSendMessage_Lcom_epson_epos2_commbox_CommBox_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Commbox.ISendMessageCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Commbox.CommBox> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCommBoxSendMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onCommBoxSendMessage_Lcom_epson_epos2_commbox_CommBox_II;
		public unsafe void OnCommBoxSendMessage (global::Com.Epson.Epos2.Commbox.CommBox? p0, int p1, int p2)
		{
			if (id_onCommBoxSendMessage_Lcom_epson_epos2_commbox_CommBox_II == IntPtr.Zero)
				id_onCommBoxSendMessage_Lcom_epson_epos2_commbox_CommBox_II = JNIEnv.GetMethodID (class_ref, "onCommBoxSendMessage", "(Lcom/epson/epos2/commbox/CommBox;II)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCommBoxSendMessage_Lcom_epson_epos2_commbox_CommBox_II, __args);
		}

	}
}
