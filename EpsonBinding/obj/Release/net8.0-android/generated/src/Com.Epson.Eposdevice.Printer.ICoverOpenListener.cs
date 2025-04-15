using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposdevice.Printer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposdevice.printer']/interface[@name='CoverOpenListener']"
	[Register ("com/epson/eposdevice/printer/CoverOpenListener", "", "Com.Epson.Eposdevice.Printer.ICoverOpenListenerInvoker")]
	public partial interface ICoverOpenListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.printer']/interface[@name='CoverOpenListener']/method[@name='onPtrCoverOpen' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onPtrCoverOpen", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnPtrCoverOpen_Ljava_lang_String_Ljava_lang_String_Handler:Com.Epson.Eposdevice.Printer.ICoverOpenListenerInvoker, EpsonBinding")]
		void OnPtrCoverOpen (string? p0, string? p1);

	}

	[global::Android.Runtime.Register ("com/epson/eposdevice/printer/CoverOpenListener", DoNotGenerateAcw=true)]
	internal partial class ICoverOpenListenerInvoker : global::Java.Lang.Object, ICoverOpenListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposdevice/printer/CoverOpenListener", typeof (ICoverOpenListenerInvoker));

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

		public static ICoverOpenListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICoverOpenListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposdevice.printer.CoverOpenListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICoverOpenListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onPtrCoverOpen_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnPtrCoverOpen_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onPtrCoverOpen_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onPtrCoverOpen_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnPtrCoverOpen_Ljava_lang_String_Ljava_lang_String_));
			return cb_onPtrCoverOpen_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnPtrCoverOpen_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Printer.ICoverOpenListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPtrCoverOpen (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPtrCoverOpen_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnPtrCoverOpen (string? p0, string? p1)
		{
			if (id_onPtrCoverOpen_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onPtrCoverOpen_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPtrCoverOpen", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPtrCoverOpen_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
