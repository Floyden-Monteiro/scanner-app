using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposdevice.Scanner {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposdevice.scanner']/interface[@name='DataListener']"
	[Register ("com/epson/eposdevice/scanner/DataListener", "", "Com.Epson.Eposdevice.Scanner.IDataListenerInvoker")]
	public partial interface IDataListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.scanner']/interface[@name='DataListener']/method[@name='onScanData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onScanData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Epson.Eposdevice.Scanner.IDataListenerInvoker, EpsonBinding")]
		void OnScanData (string? p0, string? p1, string? p2);

	}

	[global::Android.Runtime.Register ("com/epson/eposdevice/scanner/DataListener", DoNotGenerateAcw=true)]
	internal partial class IDataListenerInvoker : global::Java.Lang.Object, IDataListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposdevice/scanner/DataListener", typeof (IDataListenerInvoker));

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
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposdevice.scanner.DataListener'.");
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

		static Delegate? cb_onScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_OnScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_));
			return cb_onScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Scanner.IDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnScanData (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnScanData (string? p0, string? p1, string? p2)
		{
			if (id_onScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onScanData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	// event args for com.epson.eposdevice.scanner.DataListener.onScanData
	public partial class DataEventArgs : global::System.EventArgs {
		public DataEventArgs (string? p0, string? p1, string? p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string? p0;

		public string? P0 {
			get { return p0; }
		}

		string? p1;

		public string? P1 {
			get { return p1; }
		}

		string? p2;

		public string? P2 {
			get { return p2; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/eposdevice/scanner/DataListenerImplementor")]
	internal sealed partial class IDataListenerImplementor : global::Java.Lang.Object, IDataListener {

		object? sender;

		public unsafe IDataListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<DataEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnScanData (string? p0, string? p1, string? p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DataEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IDataListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
