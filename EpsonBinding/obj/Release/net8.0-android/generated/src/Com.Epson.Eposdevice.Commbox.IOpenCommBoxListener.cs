using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposdevice.Commbox {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposdevice.commbox']/interface[@name='OpenCommBoxListener']"
	[Register ("com/epson/eposdevice/commbox/OpenCommBoxListener", "", "Com.Epson.Eposdevice.Commbox.IOpenCommBoxListenerInvoker")]
	public partial interface IOpenCommBoxListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.commbox']/interface[@name='OpenCommBoxListener']/method[@name='onOpenCommBox' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.epson.eposdevice.commbox.CommBox'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onOpenCommBox", "(Ljava/lang/String;Lcom/epson/eposdevice/commbox/CommBox;II)V", "GetOnOpenCommBox_Ljava_lang_String_Lcom_epson_eposdevice_commbox_CommBox_IIHandler:Com.Epson.Eposdevice.Commbox.IOpenCommBoxListenerInvoker, EpsonBinding")]
		void OnOpenCommBox (string? p0, global::Com.Epson.Eposdevice.Commbox.CommBox? p1, int p2, int p3);

	}

	[global::Android.Runtime.Register ("com/epson/eposdevice/commbox/OpenCommBoxListener", DoNotGenerateAcw=true)]
	internal partial class IOpenCommBoxListenerInvoker : global::Java.Lang.Object, IOpenCommBoxListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposdevice/commbox/OpenCommBoxListener", typeof (IOpenCommBoxListenerInvoker));

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

		public static IOpenCommBoxListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOpenCommBoxListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposdevice.commbox.OpenCommBoxListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOpenCommBoxListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onOpenCommBox_Ljava_lang_String_Lcom_epson_eposdevice_commbox_CommBox_II;
#pragma warning disable 0169
		static Delegate GetOnOpenCommBox_Ljava_lang_String_Lcom_epson_eposdevice_commbox_CommBox_IIHandler ()
		{
			if (cb_onOpenCommBox_Ljava_lang_String_Lcom_epson_eposdevice_commbox_CommBox_II == null)
				cb_onOpenCommBox_Ljava_lang_String_Lcom_epson_eposdevice_commbox_CommBox_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLII_V (n_OnOpenCommBox_Ljava_lang_String_Lcom_epson_eposdevice_commbox_CommBox_II));
			return cb_onOpenCommBox_Ljava_lang_String_Lcom_epson_eposdevice_commbox_CommBox_II;
		}

		static void n_OnOpenCommBox_Ljava_lang_String_Lcom_epson_eposdevice_commbox_CommBox_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Commbox.IOpenCommBoxListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Commbox.CommBox> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnOpenCommBox (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onOpenCommBox_Ljava_lang_String_Lcom_epson_eposdevice_commbox_CommBox_II;
		public unsafe void OnOpenCommBox (string? p0, global::Com.Epson.Eposdevice.Commbox.CommBox? p1, int p2, int p3)
		{
			if (id_onOpenCommBox_Ljava_lang_String_Lcom_epson_eposdevice_commbox_CommBox_II == IntPtr.Zero)
				id_onOpenCommBox_Ljava_lang_String_Lcom_epson_eposdevice_commbox_CommBox_II = JNIEnv.GetMethodID (class_ref, "onOpenCommBox", "(Ljava/lang/String;Lcom/epson/eposdevice/commbox/CommBox;II)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOpenCommBox_Ljava_lang_String_Lcom_epson_eposdevice_commbox_CommBox_II, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.epson.eposdevice.commbox.OpenCommBoxListener.onOpenCommBox
	public partial class OpenCommBoxEventArgs : global::System.EventArgs {
		public OpenCommBoxEventArgs (string? p0, global::Com.Epson.Eposdevice.Commbox.CommBox? p1, int p2, int p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		string? p0;

		public string? P0 {
			get { return p0; }
		}

		global::Com.Epson.Eposdevice.Commbox.CommBox? p1;

		public global::Com.Epson.Eposdevice.Commbox.CommBox? P1 {
			get { return p1; }
		}

		int p2;

		public int P2 {
			get { return p2; }
		}

		int p3;

		public int P3 {
			get { return p3; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/eposdevice/commbox/OpenCommBoxListenerImplementor")]
	internal sealed partial class IOpenCommBoxListenerImplementor : global::Java.Lang.Object, IOpenCommBoxListener {

		object? sender;

		public unsafe IOpenCommBoxListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<OpenCommBoxEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnOpenCommBox (string? p0, global::Com.Epson.Eposdevice.Commbox.CommBox? p1, int p2, int p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new OpenCommBoxEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IOpenCommBoxListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
