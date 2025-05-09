//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposdevice.Scanner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.epson.eposdevice.scanner']/class[@name='Scanner']"
	[global::Android.Runtime.Register ("com/epson/eposdevice/scanner/Scanner", DoNotGenerateAcw=true)]
	public abstract partial class Scanner : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposdevice/scanner/Scanner", typeof (Scanner));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected Scanner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.epson.eposdevice.scanner']/class[@name='Scanner']/constructor[@name='Scanner' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe Scanner (long scanHandle) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (scanHandle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate? cb_getInnerHandle;
#pragma warning disable 0169
		static Delegate GetGetInnerHandleHandler ()
		{
			if (cb_getInnerHandle == null)
				cb_getInnerHandle = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_GetInnerHandle));
			return cb_getInnerHandle;
		}

		static long n_GetInnerHandle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Scanner.Scanner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.InnerHandle;
		}
#pragma warning restore 0169

		protected virtual unsafe long InnerHandle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.scanner']/class[@name='Scanner']/method[@name='getInnerHandle' and count(parameter)=0]"
			[Register ("getInnerHandle", "()J", "GetGetInnerHandleHandler")]
			get {
				const string __id = "getInnerHandle.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate? cb_innerDeleteInstance;
#pragma warning disable 0169
		static Delegate GetInnerDeleteInstanceHandler ()
		{
			if (cb_innerDeleteInstance == null)
				cb_innerDeleteInstance = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_InnerDeleteInstance));
			return cb_innerDeleteInstance;
		}

		static void n_InnerDeleteInstance (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Scanner.Scanner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.InnerDeleteInstance ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.scanner']/class[@name='Scanner']/method[@name='innerDeleteInstance' and count(parameter)=0]"
		[Register ("innerDeleteInstance", "()V", "GetInnerDeleteInstanceHandler")]
		protected virtual unsafe void InnerDeleteInstance ()
		{
			const string __id = "innerDeleteInstance.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_nativeOnScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNativeOnScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_nativeOnScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_nativeOnScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_NativeOnScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_));
			return cb_nativeOnScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_NativeOnScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ipAddress, IntPtr native_deviceId, IntPtr native_input)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Scanner.Scanner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var ipAddress = JNIEnv.GetString (native_ipAddress, JniHandleOwnership.DoNotTransfer);
			var deviceId = JNIEnv.GetString (native_deviceId, JniHandleOwnership.DoNotTransfer);
			var input = JNIEnv.GetString (native_input, JniHandleOwnership.DoNotTransfer);
			__this.NativeOnScanData (ipAddress, deviceId, input);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.scanner']/class[@name='Scanner']/method[@name='nativeOnScanData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("nativeOnScanData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetNativeOnScanData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void NativeOnScanData (string? ipAddress, string? deviceId, string? input)
		{
			const string __id = "nativeOnScanData.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_ipAddress = JNIEnv.NewString ((string?)ipAddress);
			IntPtr native_deviceId = JNIEnv.NewString ((string?)deviceId);
			IntPtr native_input = JNIEnv.NewString ((string?)input);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_ipAddress);
				__args [1] = new JniArgumentValue (native_deviceId);
				__args [2] = new JniArgumentValue (native_input);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ipAddress);
				JNIEnv.DeleteLocalRef (native_deviceId);
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static Delegate? cb_outputException_Ljava_lang_String_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOutputException_Ljava_lang_String_Ljava_lang_Exception_Handler ()
		{
			if (cb_outputException_Ljava_lang_String_Ljava_lang_Exception_ == null)
				cb_outputException_Ljava_lang_String_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OutputException_Ljava_lang_String_Ljava_lang_Exception_));
			return cb_outputException_Ljava_lang_String_Ljava_lang_Exception_;
		}

		static void n_OutputException_Ljava_lang_String_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Scanner.Scanner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OutputException (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.scanner']/class[@name='Scanner']/method[@name='outputException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("outputException", "(Ljava/lang/String;Ljava/lang/Exception;)V", "GetOutputException_Ljava_lang_String_Ljava_lang_Exception_Handler")]
		protected abstract void OutputException (string? p0, global::Java.Lang.Exception? p1);

		static Delegate? cb_outputLogCallFunction_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOutputLogCallFunction_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_outputLogCallFunction_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_outputLogCallFunction_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OutputLogCallFunction_Ljava_lang_String_arrayLjava_lang_Object_));
			return cb_outputLogCallFunction_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_OutputLogCallFunction_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Scanner.Scanner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.Object[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.OutputLogCallFunction (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.scanner']/class[@name='Scanner']/method[@name='outputLogCallFunction' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("outputLogCallFunction", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetOutputLogCallFunction_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		protected abstract void OutputLogCallFunction (string? p0, params global::Java.Lang.Object[]? p1);

		static Delegate? cb_outputLogEvent_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOutputLogEvent_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_outputLogEvent_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_outputLogEvent_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OutputLogEvent_Ljava_lang_String_arrayLjava_lang_Object_));
			return cb_outputLogEvent_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_OutputLogEvent_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Scanner.Scanner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.Object[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.OutputLogEvent (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.scanner']/class[@name='Scanner']/method[@name='outputLogEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("outputLogEvent", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetOutputLogEvent_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		protected abstract void OutputLogEvent (string? p0, params global::Java.Lang.Object[]? p1);

		static Delegate? cb_outputLogReturnFunction_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOutputLogReturnFunction_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_outputLogReturnFunction_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_outputLogReturnFunction_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OutputLogReturnFunction_Ljava_lang_String_arrayLjava_lang_Object_));
			return cb_outputLogReturnFunction_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_OutputLogReturnFunction_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Scanner.Scanner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Java.Lang.Object[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.OutputLogReturnFunction (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.scanner']/class[@name='Scanner']/method[@name='outputLogReturnFunction' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("outputLogReturnFunction", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetOutputLogReturnFunction_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		protected abstract void OutputLogReturnFunction (string? p0, params global::Java.Lang.Object[]? p1);

		static Delegate? cb_setDataEventCallback_Lcom_epson_eposdevice_scanner_DataListener_;
#pragma warning disable 0169
		static Delegate GetSetDataEventCallback_Lcom_epson_eposdevice_scanner_DataListener_Handler ()
		{
			if (cb_setDataEventCallback_Lcom_epson_eposdevice_scanner_DataListener_ == null)
				cb_setDataEventCallback_Lcom_epson_eposdevice_scanner_DataListener_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetDataEventCallback_Lcom_epson_eposdevice_scanner_DataListener_));
			return cb_setDataEventCallback_Lcom_epson_eposdevice_scanner_DataListener_;
		}

		static void n_SetDataEventCallback_Lcom_epson_eposdevice_scanner_DataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Scanner.Scanner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var target = (global::Com.Epson.Eposdevice.Scanner.IDataListener?)global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Scanner.IDataListener> (native_target, JniHandleOwnership.DoNotTransfer);
			__this.SetDataEventCallback (target);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.scanner']/class[@name='Scanner']/method[@name='setDataEventCallback' and count(parameter)=1 and parameter[1][@type='com.epson.eposdevice.scanner.DataListener']]"
		[Register ("setDataEventCallback", "(Lcom/epson/eposdevice/scanner/DataListener;)V", "GetSetDataEventCallback_Lcom_epson_eposdevice_scanner_DataListener_Handler")]
		public virtual unsafe void SetDataEventCallback (global::Com.Epson.Eposdevice.Scanner.IDataListener? target)
		{
			const string __id = "setDataEventCallback.(Lcom/epson/eposdevice/scanner/DataListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (target);
			}
		}

		#region "Event implementation for Com.Epson.Eposdevice.Scanner.IDataListener"

		public event EventHandler<global::Com.Epson.Eposdevice.Scanner.DataEventArgs> DataEventCallback {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Epson.Eposdevice.Scanner.IDataListener, global::Com.Epson.Eposdevice.Scanner.IDataListenerImplementor>(
				ref weak_implementor_SetDataEventCallback,
				__CreateIDataListenerImplementor,
				SetDataEventCallback,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Epson.Eposdevice.Scanner.IDataListener, global::Com.Epson.Eposdevice.Scanner.IDataListenerImplementor>(
				ref weak_implementor_SetDataEventCallback,
				global::Com.Epson.Eposdevice.Scanner.IDataListenerImplementor.__IsEmpty,
				__v => SetDataEventCallback (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference? weak_implementor_SetDataEventCallback;

		global::Com.Epson.Eposdevice.Scanner.IDataListenerImplementor __CreateIDataListenerImplementor ()
		{
			return new global::Com.Epson.Eposdevice.Scanner.IDataListenerImplementor (this);
		}

		#endregion

	}

	[global::Android.Runtime.Register ("com/epson/eposdevice/scanner/Scanner", DoNotGenerateAcw=true)]
	internal partial class ScannerInvoker : Scanner {
		public ScannerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposdevice/scanner/Scanner", typeof (ScannerInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.scanner']/class[@name='Scanner']/method[@name='outputException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("outputException", "(Ljava/lang/String;Ljava/lang/Exception;)V", "GetOutputException_Ljava_lang_String_Ljava_lang_Exception_Handler")]
		protected override unsafe void OutputException (string? p0, global::Java.Lang.Exception? p1)
		{
			const string __id = "outputException.(Ljava/lang/String;Ljava/lang/Exception;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.scanner']/class[@name='Scanner']/method[@name='outputLogCallFunction' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("outputLogCallFunction", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetOutputLogCallFunction_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		protected override unsafe void OutputLogCallFunction (string? p0, params global::Java.Lang.Object[]? p1)
		{
			const string __id = "outputLogCallFunction.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.scanner']/class[@name='Scanner']/method[@name='outputLogEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("outputLogEvent", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetOutputLogEvent_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		protected override unsafe void OutputLogEvent (string? p0, params global::Java.Lang.Object[]? p1)
		{
			const string __id = "outputLogEvent.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.scanner']/class[@name='Scanner']/method[@name='outputLogReturnFunction' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("outputLogReturnFunction", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetOutputLogReturnFunction_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		protected override unsafe void OutputLogReturnFunction (string? p0, params global::Java.Lang.Object[]? p1)
		{
			const string __id = "outputLogReturnFunction.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
