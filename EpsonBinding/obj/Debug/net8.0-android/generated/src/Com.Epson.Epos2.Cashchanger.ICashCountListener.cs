using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Cashchanger {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.cashchanger']/interface[@name='CashCountListener']"
	[Register ("com/epson/epos2/cashchanger/CashCountListener", "", "Com.Epson.Epos2.Cashchanger.ICashCountListenerInvoker")]
	public partial interface ICashCountListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.cashchanger']/interface[@name='CashCountListener']/method[@name='onCChangerCashCount' and count(parameter)=3 and parameter[1][@type='com.epson.epos2.cashchanger.CashChanger'] and parameter[2][@type='int'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.Integer&gt;']]"
		[Register ("onCChangerCashCount", "(Lcom/epson/epos2/cashchanger/CashChanger;ILjava/util/Map;)V", "GetOnCChangerCashCount_Lcom_epson_epos2_cashchanger_CashChanger_ILjava_util_Map_Handler:Com.Epson.Epos2.Cashchanger.ICashCountListenerInvoker, EpsonBinding")]
		void OnCChangerCashCount (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer>? p2);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/cashchanger/CashCountListener", DoNotGenerateAcw=true)]
	internal partial class ICashCountListenerInvoker : global::Java.Lang.Object, ICashCountListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/cashchanger/CashCountListener", typeof (ICashCountListenerInvoker));

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

		public static ICashCountListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICashCountListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.cashchanger.CashCountListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICashCountListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCChangerCashCount_Lcom_epson_epos2_cashchanger_CashChanger_ILjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnCChangerCashCount_Lcom_epson_epos2_cashchanger_CashChanger_ILjava_util_Map_Handler ()
		{
			if (cb_onCChangerCashCount_Lcom_epson_epos2_cashchanger_CashChanger_ILjava_util_Map_ == null)
				cb_onCChangerCashCount_Lcom_epson_epos2_cashchanger_CashChanger_ILjava_util_Map_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIL_V (n_OnCChangerCashCount_Lcom_epson_epos2_cashchanger_CashChanger_ILjava_util_Map_));
			return cb_onCChangerCashCount_Lcom_epson_epos2_cashchanger_CashChanger_ILjava_util_Map_;
		}

		static void n_OnCChangerCashCount_Lcom_epson_epos2_cashchanger_CashChanger_ILjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cashchanger.ICashCountListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cashchanger.CashChanger> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnCChangerCashCount (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onCChangerCashCount_Lcom_epson_epos2_cashchanger_CashChanger_ILjava_util_Map_;
		public unsafe void OnCChangerCashCount (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer>? p2)
		{
			if (id_onCChangerCashCount_Lcom_epson_epos2_cashchanger_CashChanger_ILjava_util_Map_ == IntPtr.Zero)
				id_onCChangerCashCount_Lcom_epson_epos2_cashchanger_CashChanger_ILjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onCChangerCashCount", "(Lcom/epson/epos2/cashchanger/CashChanger;ILjava/util/Map;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCChangerCashCount_Lcom_epson_epos2_cashchanger_CashChanger_ILjava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	// event args for com.epson.epos2.cashchanger.CashCountListener.onCChangerCashCount
	public partial class CashCountEventArgs : global::System.EventArgs {
		public CashCountEventArgs (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer>? p2)
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

		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer>? p2;

		public global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer>? P2 {
			get { return p2; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/epos2/cashchanger/CashCountListenerImplementor")]
	internal sealed partial class ICashCountListenerImplementor : global::Java.Lang.Object, ICashCountListener {

		object? sender;

		public unsafe ICashCountListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<CashCountEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnCChangerCashCount (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer>? p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CashCountEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (ICashCountListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
