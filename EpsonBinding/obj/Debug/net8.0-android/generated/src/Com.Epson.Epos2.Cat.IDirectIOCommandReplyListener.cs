using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Cat {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.cat']/interface[@name='DirectIOCommandReplyListener']"
	[Register ("com/epson/epos2/cat/DirectIOCommandReplyListener", "", "Com.Epson.Epos2.Cat.IDirectIOCommandReplyListenerInvoker")]
	public partial interface IDirectIOCommandReplyListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.cat']/interface[@name='DirectIOCommandReplyListener']/method[@name='onCatDirectIOCommandReply' and count(parameter)=8 and parameter[1][@type='com.epson.epos2.cat.Cat'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='com.epson.epos2.cat.DirectIOResult']]"
		[Register ("onCatDirectIOCommandReply", "(Lcom/epson/epos2/cat/Cat;IIILjava/lang/String;IILcom/epson/epos2/cat/DirectIOResult;)V", "GetOnCatDirectIOCommandReply_Lcom_epson_epos2_cat_Cat_IIILjava_lang_String_IILcom_epson_epos2_cat_DirectIOResult_Handler:Com.Epson.Epos2.Cat.IDirectIOCommandReplyListenerInvoker, EpsonBinding")]
		void OnCatDirectIOCommandReply (global::Com.Epson.Epos2.Cat.Cat? p0, int p1, int p2, int p3, string? p4, int p5, int p6, global::Com.Epson.Epos2.Cat.DirectIOResult? p7);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/cat/DirectIOCommandReplyListener", DoNotGenerateAcw=true)]
	internal partial class IDirectIOCommandReplyListenerInvoker : global::Java.Lang.Object, IDirectIOCommandReplyListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/cat/DirectIOCommandReplyListener", typeof (IDirectIOCommandReplyListenerInvoker));

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

		public static IDirectIOCommandReplyListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDirectIOCommandReplyListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.cat.DirectIOCommandReplyListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDirectIOCommandReplyListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCatDirectIOCommandReply_Lcom_epson_epos2_cat_Cat_IIILjava_lang_String_IILcom_epson_epos2_cat_DirectIOResult_;
#pragma warning disable 0169
		static Delegate GetOnCatDirectIOCommandReply_Lcom_epson_epos2_cat_Cat_IIILjava_lang_String_IILcom_epson_epos2_cat_DirectIOResult_Handler ()
		{
			if (cb_onCatDirectIOCommandReply_Lcom_epson_epos2_cat_Cat_IIILjava_lang_String_IILcom_epson_epos2_cat_DirectIOResult_ == null)
				cb_onCatDirectIOCommandReply_Lcom_epson_epos2_cat_Cat_IIILjava_lang_String_IILcom_epson_epos2_cat_DirectIOResult_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLIIILIIL_V (n_OnCatDirectIOCommandReply_Lcom_epson_epos2_cat_Cat_IIILjava_lang_String_IILcom_epson_epos2_cat_DirectIOResult_));
			return cb_onCatDirectIOCommandReply_Lcom_epson_epos2_cat_Cat_IIILjava_lang_String_IILcom_epson_epos2_cat_DirectIOResult_;
		}

		static void n_OnCatDirectIOCommandReply_Lcom_epson_epos2_cat_Cat_IIILjava_lang_String_IILcom_epson_epos2_cat_DirectIOResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, IntPtr native_p4, int p5, int p6, IntPtr native_p7)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cat.IDirectIOCommandReplyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cat.Cat> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			var p7 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cat.DirectIOResult> (native_p7, JniHandleOwnership.DoNotTransfer);
			__this.OnCatDirectIOCommandReply (p0, p1, p2, p3, p4, p5, p6, p7);
		}
#pragma warning restore 0169

		IntPtr id_onCatDirectIOCommandReply_Lcom_epson_epos2_cat_Cat_IIILjava_lang_String_IILcom_epson_epos2_cat_DirectIOResult_;
		public unsafe void OnCatDirectIOCommandReply (global::Com.Epson.Epos2.Cat.Cat? p0, int p1, int p2, int p3, string? p4, int p5, int p6, global::Com.Epson.Epos2.Cat.DirectIOResult? p7)
		{
			if (id_onCatDirectIOCommandReply_Lcom_epson_epos2_cat_Cat_IIILjava_lang_String_IILcom_epson_epos2_cat_DirectIOResult_ == IntPtr.Zero)
				id_onCatDirectIOCommandReply_Lcom_epson_epos2_cat_Cat_IIILjava_lang_String_IILcom_epson_epos2_cat_DirectIOResult_ = JNIEnv.GetMethodID (class_ref, "onCatDirectIOCommandReply", "(Lcom/epson/epos2/cat/Cat;IIILjava/lang/String;IILcom/epson/epos2/cat/DirectIOResult;)V");
			IntPtr native_p4 = JNIEnv.NewString ((string?)p4);
			JValue* __args = stackalloc JValue [8];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue (p6);
			__args [7] = new JValue ((p7 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p7).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCatDirectIOCommandReply_Lcom_epson_epos2_cat_Cat_IIILjava_lang_String_IILcom_epson_epos2_cat_DirectIOResult_, __args);
			JNIEnv.DeleteLocalRef (native_p4);
		}

	}

	// event args for com.epson.epos2.cat.DirectIOCommandReplyListener.onCatDirectIOCommandReply
	public partial class DirectIOCommandReplyEventArgs : global::System.EventArgs {
		public DirectIOCommandReplyEventArgs (global::Com.Epson.Epos2.Cat.Cat? p0, int p1, int p2, int p3, string? p4, int p5, int p6, global::Com.Epson.Epos2.Cat.DirectIOResult? p7)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
			this.p5 = p5;
			this.p6 = p6;
			this.p7 = p7;
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

		int p3;

		public int P3 {
			get { return p3; }
		}

		string? p4;

		public string? P4 {
			get { return p4; }
		}

		int p5;

		public int P5 {
			get { return p5; }
		}

		int p6;

		public int P6 {
			get { return p6; }
		}

		global::Com.Epson.Epos2.Cat.DirectIOResult? p7;

		public global::Com.Epson.Epos2.Cat.DirectIOResult? P7 {
			get { return p7; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/epos2/cat/DirectIOCommandReplyListenerImplementor")]
	internal sealed partial class IDirectIOCommandReplyListenerImplementor : global::Java.Lang.Object, IDirectIOCommandReplyListener {

		object? sender;

		public unsafe IDirectIOCommandReplyListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<DirectIOCommandReplyEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnCatDirectIOCommandReply (global::Com.Epson.Epos2.Cat.Cat? p0, int p1, int p2, int p3, string? p4, int p5, int p6, global::Com.Epson.Epos2.Cat.DirectIOResult? p7)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DirectIOCommandReplyEventArgs (p0, p1, p2, p3, p4, p5, p6, p7));
		}

		internal static bool __IsEmpty (IDirectIOCommandReplyListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
