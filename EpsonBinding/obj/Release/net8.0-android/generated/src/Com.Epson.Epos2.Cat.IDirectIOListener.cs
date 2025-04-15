using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Cat {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.cat']/interface[@name='DirectIOListener']"
	[Register ("com/epson/epos2/cat/DirectIOListener", "", "Com.Epson.Epos2.Cat.IDirectIOListenerInvoker")]
	public partial interface IDirectIOListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.cat']/interface[@name='DirectIOListener']/method[@name='onCatDirectIO' and count(parameter)=4 and parameter[1][@type='com.epson.epos2.cat.Cat'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("onCatDirectIO", "(Lcom/epson/epos2/cat/Cat;IILjava/lang/String;)V", "GetOnCatDirectIO_Lcom_epson_epos2_cat_Cat_IILjava_lang_String_Handler:Com.Epson.Epos2.Cat.IDirectIOListenerInvoker, EpsonBinding")]
		void OnCatDirectIO (global::Com.Epson.Epos2.Cat.Cat? p0, int p1, int p2, string? p3);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/cat/DirectIOListener", DoNotGenerateAcw=true)]
	internal partial class IDirectIOListenerInvoker : global::Java.Lang.Object, IDirectIOListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/cat/DirectIOListener", typeof (IDirectIOListenerInvoker));

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

		public static IDirectIOListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDirectIOListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.cat.DirectIOListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDirectIOListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCatDirectIO_Lcom_epson_epos2_cat_Cat_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCatDirectIO_Lcom_epson_epos2_cat_Cat_IILjava_lang_String_Handler ()
		{
			if (cb_onCatDirectIO_Lcom_epson_epos2_cat_Cat_IILjava_lang_String_ == null)
				cb_onCatDirectIO_Lcom_epson_epos2_cat_Cat_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIL_V (n_OnCatDirectIO_Lcom_epson_epos2_cat_Cat_IILjava_lang_String_));
			return cb_onCatDirectIO_Lcom_epson_epos2_cat_Cat_IILjava_lang_String_;
		}

		static void n_OnCatDirectIO_Lcom_epson_epos2_cat_Cat_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cat.IDirectIOListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cat.Cat> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnCatDirectIO (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onCatDirectIO_Lcom_epson_epos2_cat_Cat_IILjava_lang_String_;
		public unsafe void OnCatDirectIO (global::Com.Epson.Epos2.Cat.Cat? p0, int p1, int p2, string? p3)
		{
			if (id_onCatDirectIO_Lcom_epson_epos2_cat_Cat_IILjava_lang_String_ == IntPtr.Zero)
				id_onCatDirectIO_Lcom_epson_epos2_cat_Cat_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCatDirectIO", "(Lcom/epson/epos2/cat/Cat;IILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString ((string?)p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCatDirectIO_Lcom_epson_epos2_cat_Cat_IILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p3);
		}

	}

	// event args for com.epson.epos2.cat.DirectIOListener.onCatDirectIO
	public partial class DirectIOEventArgs : global::System.EventArgs {
		public DirectIOEventArgs (global::Com.Epson.Epos2.Cat.Cat? p0, int p1, int p2, string? p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		global::Com.Epson.Epos2.Cat.Cat? p0;

		public global::Com.Epson.Epos2.Cat.Cat? P0 {
			get { return p0; }
		}

		int p1;

		public int P1 {
			get { return p1; }
		}

		int p2;

		public int P2 {
			get { return p2; }
		}

		string? p3;

		public string? P3 {
			get { return p3; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/epos2/cat/DirectIOListenerImplementor")]
	internal sealed partial class IDirectIOListenerImplementor : global::Java.Lang.Object, IDirectIOListener {

		object? sender;

		public unsafe IDirectIOListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<DirectIOEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnCatDirectIO (global::Com.Epson.Epos2.Cat.Cat? p0, int p1, int p2, string? p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DirectIOEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IDirectIOListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
