using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposdevice.Simpleserial {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposdevice.simpleserial']/interface[@name='CommandReplayListener']"
	[Register ("com/epson/eposdevice/simpleserial/CommandReplayListener", "", "Com.Epson.Eposdevice.Simpleserial.ICommandReplayListenerInvoker")]
	public partial interface ICommandReplayListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.simpleserial']/interface[@name='CommandReplayListener']/method[@name='onSimpleSerialCommandReplay' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("onSimpleSerialCommandReplay", "(Ljava/lang/String;Ljava/lang/String;[B)V", "GetOnSimpleSerialCommandReplay_Ljava_lang_String_Ljava_lang_String_arrayBHandler:Com.Epson.Eposdevice.Simpleserial.ICommandReplayListenerInvoker, EpsonBinding")]
		void OnSimpleSerialCommandReplay (string? p0, string? p1, byte[]? p2);

	}

	[global::Android.Runtime.Register ("com/epson/eposdevice/simpleserial/CommandReplayListener", DoNotGenerateAcw=true)]
	internal partial class ICommandReplayListenerInvoker : global::Java.Lang.Object, ICommandReplayListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposdevice/simpleserial/CommandReplayListener", typeof (ICommandReplayListenerInvoker));

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

		public static ICommandReplayListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICommandReplayListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposdevice.simpleserial.CommandReplayListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICommandReplayListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onSimpleSerialCommandReplay_Ljava_lang_String_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetOnSimpleSerialCommandReplay_Ljava_lang_String_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_onSimpleSerialCommandReplay_Ljava_lang_String_Ljava_lang_String_arrayB == null)
				cb_onSimpleSerialCommandReplay_Ljava_lang_String_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_OnSimpleSerialCommandReplay_Ljava_lang_String_Ljava_lang_String_arrayB));
			return cb_onSimpleSerialCommandReplay_Ljava_lang_String_Ljava_lang_String_arrayB;
		}

		static void n_OnSimpleSerialCommandReplay_Ljava_lang_String_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Simpleserial.ICommandReplayListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]?) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnSimpleSerialCommandReplay (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_onSimpleSerialCommandReplay_Ljava_lang_String_Ljava_lang_String_arrayB;
		public unsafe void OnSimpleSerialCommandReplay (string? p0, string? p1, byte[]? p2)
		{
			if (id_onSimpleSerialCommandReplay_Ljava_lang_String_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_onSimpleSerialCommandReplay_Ljava_lang_String_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "onSimpleSerialCommandReplay", "(Ljava/lang/String;Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSimpleSerialCommandReplay_Ljava_lang_String_Ljava_lang_String_arrayB, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

	// event args for com.epson.eposdevice.simpleserial.CommandReplayListener.onSimpleSerialCommandReplay
	public partial class CommandReplayEventArgs : global::System.EventArgs {
		public CommandReplayEventArgs (string? p0, string? p1, byte[]? p2)
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

		byte[]? p2;

		public byte[]? P2 {
			get { return p2; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/eposdevice/simpleserial/CommandReplayListenerImplementor")]
	internal sealed partial class ICommandReplayListenerImplementor : global::Java.Lang.Object, ICommandReplayListener {

		object? sender;

		public unsafe ICommandReplayListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<CommandReplayEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnSimpleSerialCommandReplay (string? p0, string? p1, byte[]? p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CommandReplayEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (ICommandReplayListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
