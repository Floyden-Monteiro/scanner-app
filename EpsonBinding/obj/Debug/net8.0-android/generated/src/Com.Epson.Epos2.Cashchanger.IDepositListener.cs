using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Cashchanger {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.cashchanger']/interface[@name='DepositListener']"
	[Register ("com/epson/epos2/cashchanger/DepositListener", "", "Com.Epson.Epos2.Cashchanger.IDepositListenerInvoker")]
	public partial interface IDepositListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.cashchanger']/interface[@name='DepositListener']/method[@name='onCChangerDeposit' and count(parameter)=5 and parameter[1][@type='com.epson.epos2.cashchanger.CashChanger'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.util.Map&lt;java.lang.String, java.lang.Integer&gt;']]"
		[Register ("onCChangerDeposit", "(Lcom/epson/epos2/cashchanger/CashChanger;IIILjava/util/Map;)V", "GetOnCChangerDeposit_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_util_Map_Handler:Com.Epson.Epos2.Cashchanger.IDepositListenerInvoker, EpsonBinding")]
		void OnCChangerDeposit (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1, int p2, int p3, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer>? p4);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/cashchanger/DepositListener", DoNotGenerateAcw=true)]
	internal partial class IDepositListenerInvoker : global::Java.Lang.Object, IDepositListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/cashchanger/DepositListener", typeof (IDepositListenerInvoker));

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

		public static IDepositListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDepositListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.cashchanger.DepositListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDepositListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCChangerDeposit_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnCChangerDeposit_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_util_Map_Handler ()
		{
			if (cb_onCChangerDeposit_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_util_Map_ == null)
				cb_onCChangerDeposit_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_util_Map_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIIL_V (n_OnCChangerDeposit_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_util_Map_));
			return cb_onCChangerDeposit_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_util_Map_;
		}

		static void n_OnCChangerDeposit_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cashchanger.IDepositListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cashchanger.CashChanger> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnCChangerDeposit (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_onCChangerDeposit_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_util_Map_;
		public unsafe void OnCChangerDeposit (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1, int p2, int p3, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer>? p4)
		{
			if (id_onCChangerDeposit_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_util_Map_ == IntPtr.Zero)
				id_onCChangerDeposit_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onCChangerDeposit", "(Lcom/epson/epos2/cashchanger/CashChanger;IIILjava/util/Map;)V");
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.ToLocalJniHandle (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCChangerDeposit_Lcom_epson_epos2_cashchanger_CashChanger_IIILjava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p4);
		}

	}

	// event args for com.epson.epos2.cashchanger.DepositListener.onCChangerDeposit
	public partial class DepositEventArgs : global::System.EventArgs {
		public DepositEventArgs (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1, int p2, int p3, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer>? p4)
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

		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer>? p4;

		public global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer>? P4 {
			get { return p4; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/epos2/cashchanger/DepositListenerImplementor")]
	internal sealed partial class IDepositListenerImplementor : global::Java.Lang.Object, IDepositListener {

		object? sender;

		public unsafe IDepositListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<DepositEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnCChangerDeposit (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1, int p2, int p3, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer>? p4)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DepositEventArgs (p0, p1, p2, p3, p4));
		}

		internal static bool __IsEmpty (IDepositListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
