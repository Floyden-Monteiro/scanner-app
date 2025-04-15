using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposdevice.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposdevice.printer']/interface[@name='JobReceiveListener']"
	[Register ("com/epson/eposdevice/printer/JobReceiveListener", "", "Com.Epson.Eposdevice.Printer.IJobReceiveListenerInvoker")]
	public partial interface IJobReceiveListener : global::Com.Epson.Eposdevice.Printer.IReceiveListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.printer']/interface[@name='JobReceiveListener']/method[@name='onPtrReceive' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String']]"
		[Register ("onPtrReceive", "(Ljava/lang/String;Ljava/lang/String;IIIILjava/lang/String;)V", "GetOnPtrReceive_Ljava_lang_String_Ljava_lang_String_IIIILjava_lang_String_Handler:Com.Epson.Eposdevice.Printer.IJobReceiveListenerInvoker, EpsonBinding")]
		void OnPtrReceive (string? p0, string? p1, int p2, int p3, int p4, int p5, string? p6);

	}

	[global::Android.Runtime.Register ("com/epson/eposdevice/printer/JobReceiveListener", DoNotGenerateAcw=true)]
	internal partial class IJobReceiveListenerInvoker : global::Java.Lang.Object, IJobReceiveListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposdevice/printer/JobReceiveListener", typeof (IJobReceiveListenerInvoker));

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

		public static IJobReceiveListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJobReceiveListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposdevice.printer.JobReceiveListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJobReceiveListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onPtrReceive_Ljava_lang_String_Ljava_lang_String_IIIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnPtrReceive_Ljava_lang_String_Ljava_lang_String_IIIILjava_lang_String_Handler ()
		{
			if (cb_onPtrReceive_Ljava_lang_String_Ljava_lang_String_IIIILjava_lang_String_ == null)
				cb_onPtrReceive_Ljava_lang_String_Ljava_lang_String_IIIILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLIIIIL_V (n_OnPtrReceive_Ljava_lang_String_Ljava_lang_String_IIIILjava_lang_String_));
			return cb_onPtrReceive_Ljava_lang_String_Ljava_lang_String_IIIILjava_lang_String_;
		}

		static void n_OnPtrReceive_Ljava_lang_String_Ljava_lang_String_IIIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4, int p5, IntPtr native_p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Printer.IJobReceiveListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			__this.OnPtrReceive (p0, p1, p2, p3, p4, p5, p6);
		}
#pragma warning restore 0169

		IntPtr id_onPtrReceive_Ljava_lang_String_Ljava_lang_String_IIIILjava_lang_String_;
		public unsafe void OnPtrReceive (string? p0, string? p1, int p2, int p3, int p4, int p5, string? p6)
		{
			if (id_onPtrReceive_Ljava_lang_String_Ljava_lang_String_IIIILjava_lang_String_ == IntPtr.Zero)
				id_onPtrReceive_Ljava_lang_String_Ljava_lang_String_IIIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPtrReceive", "(Ljava/lang/String;Ljava/lang/String;IIIILjava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p6 = JNIEnv.NewString ((string?)p6);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue (native_p6);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPtrReceive_Ljava_lang_String_Ljava_lang_String_IIIILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p6);
		}

		static Delegate? cb_onPtrReceive_Ljava_lang_String_Ljava_lang_String_IIII;
#pragma warning disable 0169
		static Delegate GetOnPtrReceive_Ljava_lang_String_Ljava_lang_String_IIIIHandler ()
		{
			if (cb_onPtrReceive_Ljava_lang_String_Ljava_lang_String_IIII == null)
				cb_onPtrReceive_Ljava_lang_String_Ljava_lang_String_IIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLIIII_V (n_OnPtrReceive_Ljava_lang_String_Ljava_lang_String_IIII));
			return cb_onPtrReceive_Ljava_lang_String_Ljava_lang_String_IIII;
		}

		static void n_OnPtrReceive_Ljava_lang_String_Ljava_lang_String_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4, int p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Printer.IJobReceiveListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPtrReceive (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_onPtrReceive_Ljava_lang_String_Ljava_lang_String_IIII;
		public unsafe void OnPtrReceive (string? p0, string? p1, int p2, int p3, int p4, int p5)
		{
			if (id_onPtrReceive_Ljava_lang_String_Ljava_lang_String_IIII == IntPtr.Zero)
				id_onPtrReceive_Ljava_lang_String_Ljava_lang_String_IIII = JNIEnv.GetMethodID (class_ref, "onPtrReceive", "(Ljava/lang/String;Ljava/lang/String;IIII)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPtrReceive_Ljava_lang_String_Ljava_lang_String_IIII, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
