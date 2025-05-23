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

namespace Com.Epson.Epsonio.Usb {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.epson.epsonio.usb']/class[@name='NetUsb']"
	[global::Android.Runtime.Register ("com/epson/epsonio/usb/NetUsb", DoNotGenerateAcw=true)]
	public partial class NetUsb : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epsonio/usb/NetUsb", typeof (NetUsb));

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

		protected NetUsb (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.epson.epsonio.usb']/class[@name='NetUsb']/constructor[@name='NetUsb' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetUsb () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio.usb']/class[@name='NetUsb']/method[@name='checkDeviceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkDeviceName", "(Ljava/lang/String;)Z", "")]
		protected static unsafe bool CheckDeviceName (string? deviceName)
		{
			const string __id = "checkDeviceName.(Ljava/lang/String;)Z";
			IntPtr native_deviceName = JNIEnv.NewString ((string?)deviceName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_deviceName);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio.usb']/class[@name='NetUsb']/method[@name='close' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("close", "(I)I", "")]
		public static unsafe int Close (int usbHandle)
		{
			const string __id = "close.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (usbHandle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio.usb']/class[@name='NetUsb']/method[@name='enableFlowControl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("enableFlowControl", "(II)I", "")]
		public static unsafe int EnableFlowControl (int usbHandle, int enalbe)
		{
			const string __id = "enableFlowControl.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (usbHandle);
				__args [1] = new JniArgumentValue (enalbe);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio.usb']/class[@name='NetUsb']/method[@name='getAdapter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAdapter", "(I)Lcom/epson/epsonio/usb/Usb;", "")]
		protected static unsafe global::Com.Epson.Epsonio.Usb.Usb? GetAdapter (int handle)
		{
			const string __id = "getAdapter.(I)Lcom/epson/epsonio/usb/Usb;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Epson.Epsonio.Usb.Usb> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio.usb']/class[@name='NetUsb']/method[@name='getOnlineDMStatus' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int[]']]"
		[Register ("getOnlineDMStatus", "(I[I)I", "")]
		public static unsafe int GetOnlineDMStatus (int usbHandle, int[]? onlineStatus)
		{
			const string __id = "getOnlineDMStatus.(I[I)I";
			IntPtr native_onlineStatus = JNIEnv.NewArray (onlineStatus);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (usbHandle);
				__args [1] = new JniArgumentValue (native_onlineStatus);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (onlineStatus != null) {
					JNIEnv.CopyArray (native_onlineStatus, onlineStatus);
					JNIEnv.DeleteLocalRef (native_onlineStatus);
				}
				global::System.GC.KeepAlive (onlineStatus);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio.usb']/class[@name='NetUsb']/method[@name='getOnlineTMStatus' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int[]']]"
		[Register ("getOnlineTMStatus", "(I[I)I", "")]
		public static unsafe int GetOnlineTMStatus (int usbHandle, int[]? onlineStatus)
		{
			const string __id = "getOnlineTMStatus.(I[I)I";
			IntPtr native_onlineStatus = JNIEnv.NewArray (onlineStatus);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (usbHandle);
				__args [1] = new JniArgumentValue (native_onlineStatus);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (onlineStatus != null) {
					JNIEnv.CopyArray (native_onlineStatus, onlineStatus);
					JNIEnv.DeleteLocalRef (native_onlineStatus);
				}
				global::System.GC.KeepAlive (onlineStatus);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio.usb']/class[@name='NetUsb']/method[@name='getUsbType' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int[]']]"
		[Register ("getUsbType", "(I[I)I", "")]
		public static unsafe int GetUsbType (int usbHandle, int[]? usbType)
		{
			const string __id = "getUsbType.(I[I)I";
			IntPtr native_usbType = JNIEnv.NewArray (usbType);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (usbHandle);
				__args [1] = new JniArgumentValue (native_usbType);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (usbType != null) {
					JNIEnv.CopyArray (native_usbType, usbType);
					JNIEnv.DeleteLocalRef (native_usbType);
				}
				global::System.GC.KeepAlive (usbType);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio.usb']/class[@name='NetUsb']/method[@name='isPowerOn' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isPowerOn", "(I)Z", "")]
		public static unsafe bool IsPowerOn (int usbHandle)
		{
			const string __id = "isPowerOn.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (usbHandle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio.usb']/class[@name='NetUsb']/method[@name='kill' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("kill", "(I)I", "")]
		public static unsafe int Kill (int usbHandle)
		{
			const string __id = "kill.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (usbHandle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio.usb']/class[@name='NetUsb']/method[@name='open' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int[]'] and parameter[4][@type='java.lang.Object']]"
		[Register ("open", "(Ljava/lang/String;Ljava/lang/String;[ILjava/lang/Object;)I", "")]
		public static unsafe int Open (string? deviceName, string? deviceSettings, int[]? usbHandle, global::Java.Lang.Object? context)
		{
			const string __id = "open.(Ljava/lang/String;Ljava/lang/String;[ILjava/lang/Object;)I";
			IntPtr native_deviceName = JNIEnv.NewString ((string?)deviceName);
			IntPtr native_deviceSettings = JNIEnv.NewString ((string?)deviceSettings);
			IntPtr native_usbHandle = JNIEnv.NewArray (usbHandle);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_deviceName);
				__args [1] = new JniArgumentValue (native_deviceSettings);
				__args [2] = new JniArgumentValue (native_usbHandle);
				__args [3] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceName);
				JNIEnv.DeleteLocalRef (native_deviceSettings);
				if (usbHandle != null) {
					JNIEnv.CopyArray (native_usbHandle, usbHandle);
					JNIEnv.DeleteLocalRef (native_usbHandle);
				}
				global::System.GC.KeepAlive (usbHandle);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio.usb']/class[@name='NetUsb']/method[@name='read' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int[]']]"
		[Register ("read", "(I[BIII[I)I", "")]
		public static unsafe int Read (int usbHandle, byte[]? data, int offset, int dataSize, int timelimit, int[]? readSize)
		{
			const string __id = "read.(I[BIII[I)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			IntPtr native_readSize = JNIEnv.NewArray (readSize);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (usbHandle);
				__args [1] = new JniArgumentValue (native_data);
				__args [2] = new JniArgumentValue (offset);
				__args [3] = new JniArgumentValue (dataSize);
				__args [4] = new JniArgumentValue (timelimit);
				__args [5] = new JniArgumentValue (native_readSize);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				if (readSize != null) {
					JNIEnv.CopyArray (native_readSize, readSize);
					JNIEnv.DeleteLocalRef (native_readSize);
				}
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (readSize);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio.usb']/class[@name='NetUsb']/method[@name='removeAdapter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeAdapter", "(I)Z", "")]
		protected static unsafe bool RemoveAdapter (int handle)
		{
			const string __id = "removeAdapter.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epsonio.usb']/class[@name='NetUsb']/method[@name='write' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int[]']]"
		[Register ("write", "(I[BIII[I)I", "")]
		public static unsafe int Write (int usbHandle, byte[]? data, int offset, int dataSize, int timelimit, int[]? sentSize)
		{
			const string __id = "write.(I[BIII[I)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			IntPtr native_sentSize = JNIEnv.NewArray (sentSize);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (usbHandle);
				__args [1] = new JniArgumentValue (native_data);
				__args [2] = new JniArgumentValue (offset);
				__args [3] = new JniArgumentValue (dataSize);
				__args [4] = new JniArgumentValue (timelimit);
				__args [5] = new JniArgumentValue (native_sentSize);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				if (sentSize != null) {
					JNIEnv.CopyArray (native_sentSize, sentSize);
					JNIEnv.DeleteLocalRef (native_sentSize);
				}
				global::System.GC.KeepAlive (data);
				global::System.GC.KeepAlive (sentSize);
			}
		}

	}
}
