using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposdevice {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposdevice']/interface[@name='CreateDeviceListener']"
	[Register ("com/epson/eposdevice/CreateDeviceListener", "", "Com.Epson.Eposdevice.ICreateDeviceListenerInvoker")]
	public partial interface ICreateDeviceListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice']/interface[@name='CreateDeviceListener']/method[@name='onCreateDevice' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='int']]"
		[Register ("onCreateDevice", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Object;I)V", "GetOnCreateDevice_Ljava_lang_String_Ljava_lang_String_ILjava_lang_Object_IHandler:Com.Epson.Eposdevice.ICreateDeviceListenerInvoker, EpsonBinding")]
		void OnCreateDevice (string? p0, string? p1, int p2, global::Java.Lang.Object? p3, int p4);

	}

	[global::Android.Runtime.Register ("com/epson/eposdevice/CreateDeviceListener", DoNotGenerateAcw=true)]
	internal partial class ICreateDeviceListenerInvoker : global::Java.Lang.Object, ICreateDeviceListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposdevice/CreateDeviceListener", typeof (ICreateDeviceListenerInvoker));

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

		public static ICreateDeviceListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICreateDeviceListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposdevice.CreateDeviceListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICreateDeviceListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCreateDevice_Ljava_lang_String_Ljava_lang_String_ILjava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetOnCreateDevice_Ljava_lang_String_Ljava_lang_String_ILjava_lang_Object_IHandler ()
		{
			if (cb_onCreateDevice_Ljava_lang_String_Ljava_lang_String_ILjava_lang_Object_I == null)
				cb_onCreateDevice_Ljava_lang_String_Ljava_lang_String_ILjava_lang_Object_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLILI_V (n_OnCreateDevice_Ljava_lang_String_Ljava_lang_String_ILjava_lang_Object_I));
			return cb_onCreateDevice_Ljava_lang_String_Ljava_lang_String_ILjava_lang_Object_I;
		}

		static void n_OnCreateDevice_Ljava_lang_String_Ljava_lang_String_ILjava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, int p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.ICreateDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnCreateDevice (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_onCreateDevice_Ljava_lang_String_Ljava_lang_String_ILjava_lang_Object_I;
		public unsafe void OnCreateDevice (string? p0, string? p1, int p2, global::Java.Lang.Object? p3, int p4)
		{
			if (id_onCreateDevice_Ljava_lang_String_Ljava_lang_String_ILjava_lang_Object_I == IntPtr.Zero)
				id_onCreateDevice_Ljava_lang_String_Ljava_lang_String_ILjava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "onCreateDevice", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Object;I)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreateDevice_Ljava_lang_String_Ljava_lang_String_ILjava_lang_Object_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
