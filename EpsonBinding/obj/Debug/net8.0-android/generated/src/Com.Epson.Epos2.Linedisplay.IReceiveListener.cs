using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Linedisplay {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.linedisplay']/interface[@name='ReceiveListener']"
	[Register ("com/epson/epos2/linedisplay/ReceiveListener", "", "Com.Epson.Epos2.Linedisplay.IReceiveListenerInvoker")]
	public partial interface IReceiveListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.linedisplay']/interface[@name='ReceiveListener']/method[@name='onDispReceive' and count(parameter)=2 and parameter[1][@type='com.epson.epos2.linedisplay.LineDisplay'] and parameter[2][@type='int']]"
		[Register ("onDispReceive", "(Lcom/epson/epos2/linedisplay/LineDisplay;I)V", "GetOnDispReceive_Lcom_epson_epos2_linedisplay_LineDisplay_IHandler:Com.Epson.Epos2.Linedisplay.IReceiveListenerInvoker, EpsonBinding")]
		void OnDispReceive (global::Com.Epson.Epos2.Linedisplay.LineDisplay? p0, int p1);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/linedisplay/ReceiveListener", DoNotGenerateAcw=true)]
	internal partial class IReceiveListenerInvoker : global::Java.Lang.Object, IReceiveListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/linedisplay/ReceiveListener", typeof (IReceiveListenerInvoker));

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
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.linedisplay.ReceiveListener'.");
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

		static Delegate? cb_onDispReceive_Lcom_epson_epos2_linedisplay_LineDisplay_I;
#pragma warning disable 0169
		static Delegate GetOnDispReceive_Lcom_epson_epos2_linedisplay_LineDisplay_IHandler ()
		{
			if (cb_onDispReceive_Lcom_epson_epos2_linedisplay_LineDisplay_I == null)
				cb_onDispReceive_Lcom_epson_epos2_linedisplay_LineDisplay_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_OnDispReceive_Lcom_epson_epos2_linedisplay_LineDisplay_I));
			return cb_onDispReceive_Lcom_epson_epos2_linedisplay_LineDisplay_I;
		}

		static void n_OnDispReceive_Lcom_epson_epos2_linedisplay_LineDisplay_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Linedisplay.IReceiveListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Linedisplay.LineDisplay> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDispReceive (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onDispReceive_Lcom_epson_epos2_linedisplay_LineDisplay_I;
		public unsafe void OnDispReceive (global::Com.Epson.Epos2.Linedisplay.LineDisplay? p0, int p1)
		{
			if (id_onDispReceive_Lcom_epson_epos2_linedisplay_LineDisplay_I == IntPtr.Zero)
				id_onDispReceive_Lcom_epson_epos2_linedisplay_LineDisplay_I = JNIEnv.GetMethodID (class_ref, "onDispReceive", "(Lcom/epson/epos2/linedisplay/LineDisplay;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDispReceive_Lcom_epson_epos2_linedisplay_LineDisplay_I, __args);
		}

	}
}
