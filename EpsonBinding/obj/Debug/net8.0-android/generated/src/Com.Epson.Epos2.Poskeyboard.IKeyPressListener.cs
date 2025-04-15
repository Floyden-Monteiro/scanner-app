using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Poskeyboard {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.poskeyboard']/interface[@name='KeyPressListener']"
	[Register ("com/epson/epos2/poskeyboard/KeyPressListener", "", "Com.Epson.Epos2.Poskeyboard.IKeyPressListenerInvoker")]
	public partial interface IKeyPressListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.poskeyboard']/interface[@name='KeyPressListener']/method[@name='onPosKbdKeyPress' and count(parameter)=2 and parameter[1][@type='com.epson.epos2.poskeyboard.PosKeyboard'] and parameter[2][@type='int']]"
		[Register ("onPosKbdKeyPress", "(Lcom/epson/epos2/poskeyboard/PosKeyboard;I)V", "GetOnPosKbdKeyPress_Lcom_epson_epos2_poskeyboard_PosKeyboard_IHandler:Com.Epson.Epos2.Poskeyboard.IKeyPressListenerInvoker, EpsonBinding")]
		void OnPosKbdKeyPress (global::Com.Epson.Epos2.Poskeyboard.PosKeyboard? p0, int p1);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/poskeyboard/KeyPressListener", DoNotGenerateAcw=true)]
	internal partial class IKeyPressListenerInvoker : global::Java.Lang.Object, IKeyPressListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/poskeyboard/KeyPressListener", typeof (IKeyPressListenerInvoker));

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

		public static IKeyPressListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IKeyPressListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.poskeyboard.KeyPressListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IKeyPressListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onPosKbdKeyPress_Lcom_epson_epos2_poskeyboard_PosKeyboard_I;
#pragma warning disable 0169
		static Delegate GetOnPosKbdKeyPress_Lcom_epson_epos2_poskeyboard_PosKeyboard_IHandler ()
		{
			if (cb_onPosKbdKeyPress_Lcom_epson_epos2_poskeyboard_PosKeyboard_I == null)
				cb_onPosKbdKeyPress_Lcom_epson_epos2_poskeyboard_PosKeyboard_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_OnPosKbdKeyPress_Lcom_epson_epos2_poskeyboard_PosKeyboard_I));
			return cb_onPosKbdKeyPress_Lcom_epson_epos2_poskeyboard_PosKeyboard_I;
		}

		static void n_OnPosKbdKeyPress_Lcom_epson_epos2_poskeyboard_PosKeyboard_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Poskeyboard.IKeyPressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Poskeyboard.PosKeyboard> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPosKbdKeyPress (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPosKbdKeyPress_Lcom_epson_epos2_poskeyboard_PosKeyboard_I;
		public unsafe void OnPosKbdKeyPress (global::Com.Epson.Epos2.Poskeyboard.PosKeyboard? p0, int p1)
		{
			if (id_onPosKbdKeyPress_Lcom_epson_epos2_poskeyboard_PosKeyboard_I == IntPtr.Zero)
				id_onPosKbdKeyPress_Lcom_epson_epos2_poskeyboard_PosKeyboard_I = JNIEnv.GetMethodID (class_ref, "onPosKbdKeyPress", "(Lcom/epson/epos2/poskeyboard/PosKeyboard;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPosKbdKeyPress_Lcom_epson_epos2_poskeyboard_PosKeyboard_I, __args);
		}

	}
}
