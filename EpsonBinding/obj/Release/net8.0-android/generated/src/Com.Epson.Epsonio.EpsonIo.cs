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

namespace Com.Epson.Epsonio {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.epson.epsonio']/class[@name='EpsonIo']"
	[global::Android.Runtime.Register ("com/epson/epsonio/EpsonIo", DoNotGenerateAcw=true)]
	public partial class EpsonIo : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epsonio/EpsonIo", typeof (EpsonIo));

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

		protected EpsonIo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.epson.epsonio']/class[@name='EpsonIo']/constructor[@name='EpsonIo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EpsonIo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Close));
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epsonio.EpsonIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio']/class[@name='EpsonIo']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_open_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpen_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_open_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_open_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILL_V (n_Open_ILjava_lang_String_Ljava_lang_String_));
			return cb_open_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_Open_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int deviceType, IntPtr native_deviceName, IntPtr native_deviceSettings)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epsonio.EpsonIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var deviceName = JNIEnv.GetString (native_deviceName, JniHandleOwnership.DoNotTransfer);
			var deviceSettings = JNIEnv.GetString (native_deviceSettings, JniHandleOwnership.DoNotTransfer);
			__this.Open (deviceType, deviceName, deviceSettings);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio']/class[@name='EpsonIo']/method[@name='open' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("open", "(ILjava/lang/String;Ljava/lang/String;)V", "GetOpen_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Open (int deviceType, string? deviceName, string? deviceSettings)
		{
			const string __id = "open.(ILjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_deviceName = JNIEnv.NewString ((string?)deviceName);
			IntPtr native_deviceSettings = JNIEnv.NewString ((string?)deviceSettings);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (deviceType);
				__args [1] = new JniArgumentValue (native_deviceName);
				__args [2] = new JniArgumentValue (native_deviceSettings);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceName);
				JNIEnv.DeleteLocalRef (native_deviceSettings);
			}
		}

		static Delegate? cb_open_ILjava_lang_String_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOpen_ILjava_lang_String_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_open_ILjava_lang_String_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_open_ILjava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLL_V (n_Open_ILjava_lang_String_Ljava_lang_String_Landroid_content_Context_));
			return cb_open_ILjava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		}

		static void n_Open_ILjava_lang_String_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, int deviceType, IntPtr native_deviceName, IntPtr native_deviceSettings, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epsonio.EpsonIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var deviceName = JNIEnv.GetString (native_deviceName, JniHandleOwnership.DoNotTransfer);
			var deviceSettings = JNIEnv.GetString (native_deviceSettings, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Open (deviceType, deviceName, deviceSettings, context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio']/class[@name='EpsonIo']/method[@name='open' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.content.Context']]"
		[Register ("open", "(ILjava/lang/String;Ljava/lang/String;Landroid/content/Context;)V", "GetOpen_ILjava_lang_String_Ljava_lang_String_Landroid_content_Context_Handler")]
		public virtual unsafe void Open (int deviceType, string? deviceName, string? deviceSettings, global::Android.Content.Context? context)
		{
			const string __id = "open.(ILjava/lang/String;Ljava/lang/String;Landroid/content/Context;)V";
			IntPtr native_deviceName = JNIEnv.NewString ((string?)deviceName);
			IntPtr native_deviceSettings = JNIEnv.NewString ((string?)deviceSettings);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (deviceType);
				__args [1] = new JniArgumentValue (native_deviceName);
				__args [2] = new JniArgumentValue (native_deviceSettings);
				__args [3] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceName);
				JNIEnv.DeleteLocalRef (native_deviceSettings);
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate? cb_read_arrayBIII;
#pragma warning disable 0169
		static Delegate GetRead_arrayBIIIHandler ()
		{
			if (cb_read_arrayBIII == null)
				cb_read_arrayBIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIII_I (n_Read_arrayBIII));
			return cb_read_arrayBIII;
		}

		static int n_Read_arrayBIII (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int offset, int size, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epsonio.EpsonIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (data, offset, size, timeout);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio']/class[@name='EpsonIo']/method[@name='read' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("read", "([BIII)I", "GetRead_arrayBIIIHandler")]
		public virtual unsafe int Read (byte[]? data, int offset, int size, int timeout)
		{
			const string __id = "read.([BIII)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (size);
				__args [3] = new JniArgumentValue (timeout);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate? cb_write_arrayBIII;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBIIIHandler ()
		{
			if (cb_write_arrayBIII == null)
				cb_write_arrayBIII = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIII_I (n_Write_arrayBIII));
			return cb_write_arrayBIII;
		}

		static int n_Write_arrayBIII (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int offset, int size, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epsonio.EpsonIo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var data = (byte[]?) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Write (data, offset, size, timeout);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio']/class[@name='EpsonIo']/method[@name='write' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("write", "([BIII)I", "GetWrite_arrayBIIIHandler")]
		public virtual unsafe int Write (byte[]? data, int offset, int size, int timeout)
		{
			const string __id = "write.([BIII)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (size);
				__args [3] = new JniArgumentValue (timeout);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

	}
}
