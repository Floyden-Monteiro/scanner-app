using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Msr {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.msr']/interface[@name='DataListener']"
	[Register ("com/epson/epos2/msr/DataListener", "", "Com.Epson.Epos2.Msr.IDataListenerInvoker")]
	public partial interface IDataListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.msr']/interface[@name='DataListener']/method[@name='onData' and count(parameter)=2 and parameter[1][@type='com.epson.epos2.msr.Msr'] and parameter[2][@type='com.epson.epos2.msr.Data']]"
		[Register ("onData", "(Lcom/epson/epos2/msr/Msr;Lcom/epson/epos2/msr/Data;)V", "GetOnData_Lcom_epson_epos2_msr_Msr_Lcom_epson_epos2_msr_Data_Handler:Com.Epson.Epos2.Msr.IDataListenerInvoker, EpsonBinding")]
		void OnData (global::Com.Epson.Epos2.Msr.Msr? p0, global::Com.Epson.Epos2.Msr.Data? p1);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/msr/DataListener", DoNotGenerateAcw=true)]
	internal partial class IDataListenerInvoker : global::Java.Lang.Object, IDataListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/msr/DataListener", typeof (IDataListenerInvoker));

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

		public static IDataListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.msr.DataListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onData_Lcom_epson_epos2_msr_Msr_Lcom_epson_epos2_msr_Data_;
#pragma warning disable 0169
		static Delegate GetOnData_Lcom_epson_epos2_msr_Msr_Lcom_epson_epos2_msr_Data_Handler ()
		{
			if (cb_onData_Lcom_epson_epos2_msr_Msr_Lcom_epson_epos2_msr_Data_ == null)
				cb_onData_Lcom_epson_epos2_msr_Msr_Lcom_epson_epos2_msr_Data_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnData_Lcom_epson_epos2_msr_Msr_Lcom_epson_epos2_msr_Data_));
			return cb_onData_Lcom_epson_epos2_msr_Msr_Lcom_epson_epos2_msr_Data_;
		}

		static void n_OnData_Lcom_epson_epos2_msr_Msr_Lcom_epson_epos2_msr_Data_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Msr.IDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Msr.Msr> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Msr.Data> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnData (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onData_Lcom_epson_epos2_msr_Msr_Lcom_epson_epos2_msr_Data_;
		public unsafe void OnData (global::Com.Epson.Epos2.Msr.Msr? p0, global::Com.Epson.Epos2.Msr.Data? p1)
		{
			if (id_onData_Lcom_epson_epos2_msr_Msr_Lcom_epson_epos2_msr_Data_ == IntPtr.Zero)
				id_onData_Lcom_epson_epos2_msr_Msr_Lcom_epson_epos2_msr_Data_ = JNIEnv.GetMethodID (class_ref, "onData", "(Lcom/epson/epos2/msr/Msr;Lcom/epson/epos2/msr/Data;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onData_Lcom_epson_epos2_msr_Msr_Lcom_epson_epos2_msr_Data_, __args);
		}

	}
}
