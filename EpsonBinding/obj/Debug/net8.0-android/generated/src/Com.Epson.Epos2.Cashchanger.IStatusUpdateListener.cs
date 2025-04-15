using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Cashchanger {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.cashchanger']/interface[@name='StatusUpdateListener']"
	[Register ("com/epson/epos2/cashchanger/StatusUpdateListener", "", "Com.Epson.Epos2.Cashchanger.IStatusUpdateListenerInvoker")]
	public partial interface IStatusUpdateListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.cashchanger']/interface[@name='StatusUpdateListener']/method[@name='onCChangerStatusUpdate' and count(parameter)=2 and parameter[1][@type='com.epson.epos2.cashchanger.CashChanger'] and parameter[2][@type='int']]"
		[Register ("onCChangerStatusUpdate", "(Lcom/epson/epos2/cashchanger/CashChanger;I)V", "GetOnCChangerStatusUpdate_Lcom_epson_epos2_cashchanger_CashChanger_IHandler:Com.Epson.Epos2.Cashchanger.IStatusUpdateListenerInvoker, EpsonBinding")]
		void OnCChangerStatusUpdate (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/cashchanger/StatusUpdateListener", DoNotGenerateAcw=true)]
	internal partial class IStatusUpdateListenerInvoker : global::Java.Lang.Object, IStatusUpdateListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/cashchanger/StatusUpdateListener", typeof (IStatusUpdateListenerInvoker));

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

		public static IStatusUpdateListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStatusUpdateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.cashchanger.StatusUpdateListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStatusUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCChangerStatusUpdate_Lcom_epson_epos2_cashchanger_CashChanger_I;
#pragma warning disable 0169
		static Delegate GetOnCChangerStatusUpdate_Lcom_epson_epos2_cashchanger_CashChanger_IHandler ()
		{
			if (cb_onCChangerStatusUpdate_Lcom_epson_epos2_cashchanger_CashChanger_I == null)
				cb_onCChangerStatusUpdate_Lcom_epson_epos2_cashchanger_CashChanger_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_OnCChangerStatusUpdate_Lcom_epson_epos2_cashchanger_CashChanger_I));
			return cb_onCChangerStatusUpdate_Lcom_epson_epos2_cashchanger_CashChanger_I;
		}

		static void n_OnCChangerStatusUpdate_Lcom_epson_epos2_cashchanger_CashChanger_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cashchanger.IStatusUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cashchanger.CashChanger> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCChangerStatusUpdate (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCChangerStatusUpdate_Lcom_epson_epos2_cashchanger_CashChanger_I;
		public unsafe void OnCChangerStatusUpdate (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1)
		{
			if (id_onCChangerStatusUpdate_Lcom_epson_epos2_cashchanger_CashChanger_I == IntPtr.Zero)
				id_onCChangerStatusUpdate_Lcom_epson_epos2_cashchanger_CashChanger_I = JNIEnv.GetMethodID (class_ref, "onCChangerStatusUpdate", "(Lcom/epson/epos2/cashchanger/CashChanger;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCChangerStatusUpdate_Lcom_epson_epos2_cashchanger_CashChanger_I, __args);
		}

	}

	// event args for com.epson.epos2.cashchanger.StatusUpdateListener.onCChangerStatusUpdate
	public partial class StatusUpdateEventArgs : global::System.EventArgs {
		public StatusUpdateEventArgs (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Epson.Epos2.Cashchanger.CashChanger? p0;

		public global::Com.Epson.Epos2.Cashchanger.CashChanger? P0 {
			get { return p0; }
		}

		int p1;

		public int P1 {
			get { return p1; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/epos2/cashchanger/StatusUpdateListenerImplementor")]
	internal sealed partial class IStatusUpdateListenerImplementor : global::Java.Lang.Object, IStatusUpdateListener {

		object? sender;

		public unsafe IStatusUpdateListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<StatusUpdateEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnCChangerStatusUpdate (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new StatusUpdateEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IStatusUpdateListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
