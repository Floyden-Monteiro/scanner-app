using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2 {

	[Register ("com/epson/epos2/ConnectionListener", DoNotGenerateAcw=true)]
	[global::System.Obsolete (@"Use the 'Com.Epson.Epos2.IConnectionListener' type. This class will be removed in a future release.")]
	public abstract class ConnectionListener : Java.Lang.Object {
		internal ConnectionListener ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2']/interface[@name='ConnectionListener']/field[@name='EVENT_DISCONNECT']"
		[Register ("EVENT_DISCONNECT")]
		[global::System.Obsolete (@"Use 'Com.Epson.Epos2.IConnectionListener.EventDisconnect'. This class will be removed in a future release.")]
		public const int EventDisconnect = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2']/interface[@name='ConnectionListener']/field[@name='EVENT_RECONNECT']"
		[Register ("EVENT_RECONNECT")]
		[global::System.Obsolete (@"Use 'Com.Epson.Epos2.IConnectionListener.EventReconnect'. This class will be removed in a future release.")]
		public const int EventReconnect = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2']/interface[@name='ConnectionListener']/field[@name='EVENT_RECONNECTING']"
		[Register ("EVENT_RECONNECTING")]
		[global::System.Obsolete (@"Use 'Com.Epson.Epos2.IConnectionListener.EventReconnecting'. This class will be removed in a future release.")]
		public const int EventReconnecting = (int) 0;

		// The following are fields from: java.util.EventListener

		// The following are fields from: Android.Runtime.IJavaObject

		// The following are fields from: System.IDisposable

		// The following are fields from: Java.Interop.IJavaPeerable

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2']/interface[@name='ConnectionListener']"
	[Register ("com/epson/epos2/ConnectionListener", "", "Com.Epson.Epos2.IConnectionListenerInvoker")]
	public partial interface IConnectionListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2']/interface[@name='ConnectionListener']/field[@name='EVENT_DISCONNECT']"
		[Register ("EVENT_DISCONNECT")]
		public const int EventDisconnect = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2']/interface[@name='ConnectionListener']/field[@name='EVENT_RECONNECT']"
		[Register ("EVENT_RECONNECT")]
		public const int EventReconnect = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2']/interface[@name='ConnectionListener']/field[@name='EVENT_RECONNECTING']"
		[Register ("EVENT_RECONNECTING")]
		public const int EventReconnecting = (int) 0;

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2']/interface[@name='ConnectionListener']/method[@name='onConnection' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("onConnection", "(Ljava/lang/Object;I)V", "GetOnConnection_Ljava_lang_Object_IHandler:Com.Epson.Epos2.IConnectionListenerInvoker, EpsonBinding")]
		void OnConnection (global::Java.Lang.Object? p0, int p1);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/ConnectionListener", DoNotGenerateAcw=true)]
	internal partial class IConnectionListenerInvoker : global::Java.Lang.Object, IConnectionListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/ConnectionListener", typeof (IConnectionListenerInvoker));

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

		public static IConnectionListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.ConnectionListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onConnection_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetOnConnection_Ljava_lang_Object_IHandler ()
		{
			if (cb_onConnection_Ljava_lang_Object_I == null)
				cb_onConnection_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_OnConnection_Ljava_lang_Object_I));
			return cb_onConnection_Ljava_lang_Object_I;
		}

		static void n_OnConnection_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.IConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnection (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onConnection_Ljava_lang_Object_I;
		public unsafe void OnConnection (global::Java.Lang.Object? p0, int p1)
		{
			if (id_onConnection_Ljava_lang_Object_I == IntPtr.Zero)
				id_onConnection_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "onConnection", "(Ljava/lang/Object;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnection_Ljava_lang_Object_I, __args);
		}

	}
}
