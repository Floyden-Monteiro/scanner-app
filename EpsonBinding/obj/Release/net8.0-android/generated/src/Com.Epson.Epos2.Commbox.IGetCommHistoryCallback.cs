using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Commbox {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.commbox']/interface[@name='GetCommHistoryCallback']"
	[Register ("com/epson/epos2/commbox/GetCommHistoryCallback", "", "Com.Epson.Epos2.Commbox.IGetCommHistoryCallbackInvoker")]
	public partial interface IGetCommHistoryCallback : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.commbox']/interface[@name='GetCommHistoryCallback']/method[@name='onGetCommHistory' and count(parameter)=3 and parameter[1][@type='com.epson.epos2.commbox.CommBox'] and parameter[2][@type='int'] and parameter[3][@type='java.util.ArrayList&lt;java.util.HashMap&lt;java.lang.String, java.lang.String&gt;&gt;']]"
		[Register ("onGetCommHistory", "(Lcom/epson/epos2/commbox/CommBox;ILjava/util/ArrayList;)V", "GetOnGetCommHistory_Lcom_epson_epos2_commbox_CommBox_ILjava_util_ArrayList_Handler:Com.Epson.Epos2.Commbox.IGetCommHistoryCallbackInvoker, EpsonBinding")]
		void OnGetCommHistory (global::Com.Epson.Epos2.Commbox.CommBox? p0, int p1, global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, string>>? p2);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/commbox/GetCommHistoryCallback", DoNotGenerateAcw=true)]
	internal partial class IGetCommHistoryCallbackInvoker : global::Java.Lang.Object, IGetCommHistoryCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/commbox/GetCommHistoryCallback", typeof (IGetCommHistoryCallbackInvoker));

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

		public static IGetCommHistoryCallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGetCommHistoryCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.commbox.GetCommHistoryCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGetCommHistoryCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onGetCommHistory_Lcom_epson_epos2_commbox_CommBox_ILjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetOnGetCommHistory_Lcom_epson_epos2_commbox_CommBox_ILjava_util_ArrayList_Handler ()
		{
			if (cb_onGetCommHistory_Lcom_epson_epos2_commbox_CommBox_ILjava_util_ArrayList_ == null)
				cb_onGetCommHistory_Lcom_epson_epos2_commbox_CommBox_ILjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIL_V (n_OnGetCommHistory_Lcom_epson_epos2_commbox_CommBox_ILjava_util_ArrayList_));
			return cb_onGetCommHistory_Lcom_epson_epos2_commbox_CommBox_ILjava_util_ArrayList_;
		}

		static void n_OnGetCommHistory_Lcom_epson_epos2_commbox_CommBox_ILjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Commbox.IGetCommHistoryCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Commbox.CommBox> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, string>>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnGetCommHistory (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onGetCommHistory_Lcom_epson_epos2_commbox_CommBox_ILjava_util_ArrayList_;
		public unsafe void OnGetCommHistory (global::Com.Epson.Epos2.Commbox.CommBox? p0, int p1, global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, string>>? p2)
		{
			if (id_onGetCommHistory_Lcom_epson_epos2_commbox_CommBox_ILjava_util_ArrayList_ == IntPtr.Zero)
				id_onGetCommHistory_Lcom_epson_epos2_commbox_CommBox_ILjava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "onGetCommHistory", "(Lcom/epson/epos2/commbox/CommBox;ILjava/util/ArrayList;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, string>>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGetCommHistory_Lcom_epson_epos2_commbox_CommBox_ILjava_util_ArrayList_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}
}
