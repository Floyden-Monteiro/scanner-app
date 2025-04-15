using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Cashchanger {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.cashchanger']/interface[@name='ConfigChangeListener']"
	[Register ("com/epson/epos2/cashchanger/ConfigChangeListener", "", "Com.Epson.Epos2.Cashchanger.IConfigChangeListenerInvoker")]
	public partial interface IConfigChangeListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.cashchanger']/interface[@name='ConfigChangeListener']/method[@name='onCChangerConfigChange' and count(parameter)=2 and parameter[1][@type='com.epson.epos2.cashchanger.CashChanger'] and parameter[2][@type='int']]"
		[Register ("onCChangerConfigChange", "(Lcom/epson/epos2/cashchanger/CashChanger;I)V", "GetOnCChangerConfigChange_Lcom_epson_epos2_cashchanger_CashChanger_IHandler:Com.Epson.Epos2.Cashchanger.IConfigChangeListenerInvoker, EpsonBinding")]
		void OnCChangerConfigChange (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/cashchanger/ConfigChangeListener", DoNotGenerateAcw=true)]
	internal partial class IConfigChangeListenerInvoker : global::Java.Lang.Object, IConfigChangeListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/cashchanger/ConfigChangeListener", typeof (IConfigChangeListenerInvoker));

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

		public static IConfigChangeListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConfigChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.cashchanger.ConfigChangeListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConfigChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCChangerConfigChange_Lcom_epson_epos2_cashchanger_CashChanger_I;
#pragma warning disable 0169
		static Delegate GetOnCChangerConfigChange_Lcom_epson_epos2_cashchanger_CashChanger_IHandler ()
		{
			if (cb_onCChangerConfigChange_Lcom_epson_epos2_cashchanger_CashChanger_I == null)
				cb_onCChangerConfigChange_Lcom_epson_epos2_cashchanger_CashChanger_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_OnCChangerConfigChange_Lcom_epson_epos2_cashchanger_CashChanger_I));
			return cb_onCChangerConfigChange_Lcom_epson_epos2_cashchanger_CashChanger_I;
		}

		static void n_OnCChangerConfigChange_Lcom_epson_epos2_cashchanger_CashChanger_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cashchanger.IConfigChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cashchanger.CashChanger> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCChangerConfigChange (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCChangerConfigChange_Lcom_epson_epos2_cashchanger_CashChanger_I;
		public unsafe void OnCChangerConfigChange (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1)
		{
			if (id_onCChangerConfigChange_Lcom_epson_epos2_cashchanger_CashChanger_I == IntPtr.Zero)
				id_onCChangerConfigChange_Lcom_epson_epos2_cashchanger_CashChanger_I = JNIEnv.GetMethodID (class_ref, "onCChangerConfigChange", "(Lcom/epson/epos2/cashchanger/CashChanger;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCChangerConfigChange_Lcom_epson_epos2_cashchanger_CashChanger_I, __args);
		}

	}

	// event args for com.epson.epos2.cashchanger.ConfigChangeListener.onCChangerConfigChange
	public partial class ConfigChangeEventArgs : global::System.EventArgs {
		public ConfigChangeEventArgs (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1)
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

	[global::Android.Runtime.Register ("mono/com/epson/epos2/cashchanger/ConfigChangeListenerImplementor")]
	internal sealed partial class IConfigChangeListenerImplementor : global::Java.Lang.Object, IConfigChangeListener {

		object? sender;

		public unsafe IConfigChangeListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<ConfigChangeEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnCChangerConfigChange (global::Com.Epson.Epos2.Cashchanger.CashChanger? p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ConfigChangeEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IConfigChangeListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
