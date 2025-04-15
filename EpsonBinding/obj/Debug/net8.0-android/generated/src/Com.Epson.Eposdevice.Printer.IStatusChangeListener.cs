using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposdevice.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposdevice.printer']/interface[@name='StatusChangeListener']"
	[Register ("com/epson/eposdevice/printer/StatusChangeListener", "", "Com.Epson.Eposdevice.Printer.IStatusChangeListenerInvoker")]
	public partial interface IStatusChangeListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.printer']/interface[@name='StatusChangeListener']/method[@name='onPtrStatusChange' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("onPtrStatusChange", "(Ljava/lang/String;Ljava/lang/String;I)V", "GetOnPtrStatusChange_Ljava_lang_String_Ljava_lang_String_IHandler:Com.Epson.Eposdevice.Printer.IStatusChangeListenerInvoker, EpsonBinding")]
		void OnPtrStatusChange (string? p0, string? p1, int p2);

	}

	[global::Android.Runtime.Register ("com/epson/eposdevice/printer/StatusChangeListener", DoNotGenerateAcw=true)]
	internal partial class IStatusChangeListenerInvoker : global::Java.Lang.Object, IStatusChangeListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposdevice/printer/StatusChangeListener", typeof (IStatusChangeListenerInvoker));

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

		public static IStatusChangeListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStatusChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposdevice.printer.StatusChangeListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStatusChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onPtrStatusChange_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnPtrStatusChange_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_onPtrStatusChange_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_onPtrStatusChange_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLI_V (n_OnPtrStatusChange_Ljava_lang_String_Ljava_lang_String_I));
			return cb_onPtrStatusChange_Ljava_lang_String_Ljava_lang_String_I;
		}

		static void n_OnPtrStatusChange_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Printer.IStatusChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPtrStatusChange (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onPtrStatusChange_Ljava_lang_String_Ljava_lang_String_I;
		public unsafe void OnPtrStatusChange (string? p0, string? p1, int p2)
		{
			if (id_onPtrStatusChange_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_onPtrStatusChange_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onPtrStatusChange", "(Ljava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPtrStatusChange_Ljava_lang_String_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
