using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Simpleserial {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.simpleserial']/interface[@name='ReceiveListener']"
	[Register ("com/epson/epos2/simpleserial/ReceiveListener", "", "Com.Epson.Epos2.Simpleserial.IReceiveListenerInvoker")]
	public partial interface IReceiveListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.simpleserial']/interface[@name='ReceiveListener']/method[@name='onSimpleSerialReceive' and count(parameter)=2 and parameter[1][@type='com.epson.epos2.simpleserial.SimpleSerial'] and parameter[2][@type='byte[]']]"
		[Register ("onSimpleSerialReceive", "(Lcom/epson/epos2/simpleserial/SimpleSerial;[B)V", "GetOnSimpleSerialReceive_Lcom_epson_epos2_simpleserial_SimpleSerial_arrayBHandler:Com.Epson.Epos2.Simpleserial.IReceiveListenerInvoker, EpsonBinding")]
		void OnSimpleSerialReceive (global::Com.Epson.Epos2.Simpleserial.SimpleSerial? p0, byte[]? p1);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/simpleserial/ReceiveListener", DoNotGenerateAcw=true)]
	internal partial class IReceiveListenerInvoker : global::Java.Lang.Object, IReceiveListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/simpleserial/ReceiveListener", typeof (IReceiveListenerInvoker));

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

		public static IReceiveListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IReceiveListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.simpleserial.ReceiveListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IReceiveListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onSimpleSerialReceive_Lcom_epson_epos2_simpleserial_SimpleSerial_arrayB;
#pragma warning disable 0169
		static Delegate GetOnSimpleSerialReceive_Lcom_epson_epos2_simpleserial_SimpleSerial_arrayBHandler ()
		{
			if (cb_onSimpleSerialReceive_Lcom_epson_epos2_simpleserial_SimpleSerial_arrayB == null)
				cb_onSimpleSerialReceive_Lcom_epson_epos2_simpleserial_SimpleSerial_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnSimpleSerialReceive_Lcom_epson_epos2_simpleserial_SimpleSerial_arrayB));
			return cb_onSimpleSerialReceive_Lcom_epson_epos2_simpleserial_SimpleSerial_arrayB;
		}

		static void n_OnSimpleSerialReceive_Lcom_epson_epos2_simpleserial_SimpleSerial_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Simpleserial.IReceiveListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Simpleserial.SimpleSerial> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnSimpleSerialReceive (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onSimpleSerialReceive_Lcom_epson_epos2_simpleserial_SimpleSerial_arrayB;
		public unsafe void OnSimpleSerialReceive (global::Com.Epson.Epos2.Simpleserial.SimpleSerial? p0, byte[]? p1)
		{
			if (id_onSimpleSerialReceive_Lcom_epson_epos2_simpleserial_SimpleSerial_arrayB == IntPtr.Zero)
				id_onSimpleSerialReceive_Lcom_epson_epos2_simpleserial_SimpleSerial_arrayB = JNIEnv.GetMethodID (class_ref, "onSimpleSerialReceive", "(Lcom/epson/epos2/simpleserial/SimpleSerial;[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSimpleSerialReceive_Lcom_epson_epos2_simpleserial_SimpleSerial_arrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
