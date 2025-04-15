using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Eposdevice.Commbox {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.eposdevice.commbox']/interface[@name='GetCommHistoryListener']"
	[Register ("com/epson/eposdevice/commbox/GetCommHistoryListener", "", "Com.Epson.Eposdevice.Commbox.IGetCommHistoryListenerInvoker")]
	public partial interface IGetCommHistoryListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.eposdevice.commbox']/interface[@name='GetCommHistoryListener']/method[@name='onGetCommHistory' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.util.ArrayList&lt;java.util.HashMap&lt;java.lang.String, java.lang.String&gt;&gt;'] and parameter[4][@type='int']]"
		[Register ("onGetCommHistory", "(Ljava/lang/String;ILjava/util/ArrayList;I)V", "GetOnGetCommHistory_Ljava_lang_String_ILjava_util_ArrayList_IHandler:Com.Epson.Eposdevice.Commbox.IGetCommHistoryListenerInvoker, EpsonBinding")]
		void OnGetCommHistory (string? p0, int p1, global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, string>>? p2, int p3);

	}

	[global::Android.Runtime.Register ("com/epson/eposdevice/commbox/GetCommHistoryListener", DoNotGenerateAcw=true)]
	internal partial class IGetCommHistoryListenerInvoker : global::Java.Lang.Object, IGetCommHistoryListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/eposdevice/commbox/GetCommHistoryListener", typeof (IGetCommHistoryListenerInvoker));

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

		public static IGetCommHistoryListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGetCommHistoryListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.eposdevice.commbox.GetCommHistoryListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGetCommHistoryListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onGetCommHistory_Ljava_lang_String_ILjava_util_ArrayList_I;
#pragma warning disable 0169
		static Delegate GetOnGetCommHistory_Ljava_lang_String_ILjava_util_ArrayList_IHandler ()
		{
			if (cb_onGetCommHistory_Ljava_lang_String_ILjava_util_ArrayList_I == null)
				cb_onGetCommHistory_Ljava_lang_String_ILjava_util_ArrayList_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILI_V (n_OnGetCommHistory_Ljava_lang_String_ILjava_util_ArrayList_I));
			return cb_onGetCommHistory_Ljava_lang_String_ILjava_util_ArrayList_I;
		}

		static void n_OnGetCommHistory_Ljava_lang_String_ILjava_util_ArrayList_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Eposdevice.Commbox.IGetCommHistoryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, string>>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnGetCommHistory (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onGetCommHistory_Ljava_lang_String_ILjava_util_ArrayList_I;
		public unsafe void OnGetCommHistory (string? p0, int p1, global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, string>>? p2, int p3)
		{
			if (id_onGetCommHistory_Ljava_lang_String_ILjava_util_ArrayList_I == IntPtr.Zero)
				id_onGetCommHistory_Ljava_lang_String_ILjava_util_ArrayList_I = JNIEnv.GetMethodID (class_ref, "onGetCommHistory", "(Ljava/lang/String;ILjava/util/ArrayList;I)V");
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, string>>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGetCommHistory_Ljava_lang_String_ILjava_util_ArrayList_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	// event args for com.epson.eposdevice.commbox.GetCommHistoryListener.onGetCommHistory
	public partial class GetCommHistoryEventArgs : global::System.EventArgs {
		public GetCommHistoryEventArgs (string? p0, int p1, global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, string>>? p2, int p3)
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

		int p1;

		public int P1 {
			get { return p1; }
		}

		global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, string>>? p2;

		public global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, string>>? P2 {
			get { return p2; }
		}

		int p3;

		public int P3 {
			get { return p3; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/eposdevice/commbox/GetCommHistoryListenerImplementor")]
	internal sealed partial class IGetCommHistoryListenerImplementor : global::Java.Lang.Object, IGetCommHistoryListener {

		object? sender;

		public unsafe IGetCommHistoryListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<GetCommHistoryEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnGetCommHistory (string? p0, int p1, global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, string>>? p2, int p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new GetCommHistoryEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IGetCommHistoryListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
