using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Cashchanger {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.cashchanger']/interface[@name='CommandReplyListener']"
	[Register ("com/epson/epos2/cashchanger/CommandReplyListener", "", "Com.Epson.Epos2.Cashchanger.ICommandReplyListenerInvoker")]
	public partial interface ICommandReplyListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.cashchanger']/interface[@name='CommandReplyListener']/method[@name='onCChangerCommandReply' and count(parameter)=3 and parameter[1][@type='com.epson.epos2.cashchanger.CashChanger'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("onCChangerCommandReply", "(Lcom/epson/epos2/cashchanger/CashChanger;I[B)V", "GetOnCChangerCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IarrayBHandler:Com.Epson.Epos2.Cashchanger.ICommandReplyListenerInvoker, EpsonBinding")]
		void OnCChangerCommandReply (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1, byte[]? p2);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/cashchanger/CommandReplyListener", DoNotGenerateAcw=true)]
	internal partial class ICommandReplyListenerInvoker : global::Java.Lang.Object, ICommandReplyListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/cashchanger/CommandReplyListener", typeof (ICommandReplyListenerInvoker));

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

		public static ICommandReplyListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICommandReplyListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.cashchanger.CommandReplyListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICommandReplyListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCChangerCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IarrayB;
#pragma warning disable 0169
		static Delegate GetOnCChangerCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IarrayBHandler ()
		{
			if (cb_onCChangerCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IarrayB == null)
				cb_onCChangerCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIL_V (n_OnCChangerCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IarrayB));
			return cb_onCChangerCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IarrayB;
		}

		static void n_OnCChangerCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cashchanger.ICommandReplyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cashchanger.CashChanger> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnCChangerCommandReply (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_onCChangerCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IarrayB;
		public unsafe void OnCChangerCommandReply (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1, byte[]? p2)
		{
			if (id_onCChangerCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IarrayB == IntPtr.Zero)
				id_onCChangerCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IarrayB = JNIEnv.GetMethodID (class_ref, "onCChangerCommandReply", "(Lcom/epson/epos2/cashchanger/CashChanger;I[B)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCChangerCommandReply_Lcom_epson_epos2_cashchanger_CashChanger_IarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

	// event args for com.epson.epos2.cashchanger.CommandReplyListener.onCChangerCommandReply
	public partial class CommandReplyEventArgs : global::System.EventArgs {
		public CommandReplyEventArgs (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1, byte[]? p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Epson.Epos2.Cashchanger.CashChanger? p0;

		public global::Com.Epson.Epos2.Cashchanger.CashChanger? P0 {
			get { return p0; }
		}

		int p1;

		public int P1 {
			get { return p1; }
		}

		byte[]? p2;

		public byte[]? P2 {
			get { return p2; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/epos2/cashchanger/CommandReplyListenerImplementor")]
	internal sealed partial class ICommandReplyListenerImplementor : global::Java.Lang.Object, ICommandReplyListener {

		object? sender;

		public unsafe ICommandReplyListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<CommandReplyEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnCChangerCommandReply (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1, byte[]? p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CommandReplyEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (ICommandReplyListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
