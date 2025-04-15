using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Cat {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.cat']/interface[@name='CashDepositListener']"
	[Register ("com/epson/epos2/cat/CashDepositListener", "", "Com.Epson.Epos2.Cat.ICashDepositListenerInvoker")]
	public partial interface ICashDepositListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.cat']/interface[@name='CashDepositListener']/method[@name='onCatCashDeposit' and count(parameter)=5 and parameter[1][@type='com.epson.epos2.cat.Cat'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.epson.epos2.cat.CashDepositResult']]"
		[Register ("onCatCashDeposit", "(Lcom/epson/epos2/cat/Cat;IIILcom/epson/epos2/cat/CashDepositResult;)V", "GetOnCatCashDeposit_Lcom_epson_epos2_cat_Cat_IIILcom_epson_epos2_cat_CashDepositResult_Handler:Com.Epson.Epos2.Cat.ICashDepositListenerInvoker, EpsonBinding")]
		void OnCatCashDeposit (global::Com.Epson.Epos2.Cat.Cat? p0, int p1, int p2, int p3, global::Com.Epson.Epos2.Cat.CashDepositResult? p4);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/cat/CashDepositListener", DoNotGenerateAcw=true)]
	internal partial class ICashDepositListenerInvoker : global::Java.Lang.Object, ICashDepositListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/cat/CashDepositListener", typeof (ICashDepositListenerInvoker));

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

		public static ICashDepositListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICashDepositListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.cat.CashDepositListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICashDepositListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCatCashDeposit_Lcom_epson_epos2_cat_Cat_IIILcom_epson_epos2_cat_CashDepositResult_;
#pragma warning disable 0169
		static Delegate GetOnCatCashDeposit_Lcom_epson_epos2_cat_Cat_IIILcom_epson_epos2_cat_CashDepositResult_Handler ()
		{
			if (cb_onCatCashDeposit_Lcom_epson_epos2_cat_Cat_IIILcom_epson_epos2_cat_CashDepositResult_ == null)
				cb_onCatCashDeposit_Lcom_epson_epos2_cat_Cat_IIILcom_epson_epos2_cat_CashDepositResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIIL_V (n_OnCatCashDeposit_Lcom_epson_epos2_cat_Cat_IIILcom_epson_epos2_cat_CashDepositResult_));
			return cb_onCatCashDeposit_Lcom_epson_epos2_cat_Cat_IIILcom_epson_epos2_cat_CashDepositResult_;
		}

		static void n_OnCatCashDeposit_Lcom_epson_epos2_cat_Cat_IIILcom_epson_epos2_cat_CashDepositResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cat.ICashDepositListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cat.Cat> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cat.CashDepositResult> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnCatCashDeposit (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_onCatCashDeposit_Lcom_epson_epos2_cat_Cat_IIILcom_epson_epos2_cat_CashDepositResult_;
		public unsafe void OnCatCashDeposit (global::Com.Epson.Epos2.Cat.Cat? p0, int p1, int p2, int p3, global::Com.Epson.Epos2.Cat.CashDepositResult? p4)
		{
			if (id_onCatCashDeposit_Lcom_epson_epos2_cat_Cat_IIILcom_epson_epos2_cat_CashDepositResult_ == IntPtr.Zero)
				id_onCatCashDeposit_Lcom_epson_epos2_cat_Cat_IIILcom_epson_epos2_cat_CashDepositResult_ = JNIEnv.GetMethodID (class_ref, "onCatCashDeposit", "(Lcom/epson/epos2/cat/Cat;IIILcom/epson/epos2/cat/CashDepositResult;)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCatCashDeposit_Lcom_epson_epos2_cat_Cat_IIILcom_epson_epos2_cat_CashDepositResult_, __args);
		}

	}
}
