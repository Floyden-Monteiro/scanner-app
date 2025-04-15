using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Cat {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.cat']/interface[@name='StatusUpdateListener']"
	[Register ("com/epson/epos2/cat/StatusUpdateListener", "", "Com.Epson.Epos2.Cat.IStatusUpdateListenerInvoker")]
	public partial interface IStatusUpdateListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.cat']/interface[@name='StatusUpdateListener']/method[@name='onCatStatusUpdate' and count(parameter)=2 and parameter[1][@type='com.epson.epos2.cat.Cat'] and parameter[2][@type='int']]"
		[Register ("onCatStatusUpdate", "(Lcom/epson/epos2/cat/Cat;I)V", "GetOnCatStatusUpdate_Lcom_epson_epos2_cat_Cat_IHandler:Com.Epson.Epos2.Cat.IStatusUpdateListenerInvoker, EpsonBinding")]
		void OnCatStatusUpdate (global::Com.Epson.Epos2.Cat.Cat? p0, int p1);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/cat/StatusUpdateListener", DoNotGenerateAcw=true)]
	internal partial class IStatusUpdateListenerInvoker : global::Java.Lang.Object, IStatusUpdateListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/cat/StatusUpdateListener", typeof (IStatusUpdateListenerInvoker));

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

		public static IStatusUpdateListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStatusUpdateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.cat.StatusUpdateListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStatusUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCatStatusUpdate_Lcom_epson_epos2_cat_Cat_I;
#pragma warning disable 0169
		static Delegate GetOnCatStatusUpdate_Lcom_epson_epos2_cat_Cat_IHandler ()
		{
			if (cb_onCatStatusUpdate_Lcom_epson_epos2_cat_Cat_I == null)
				cb_onCatStatusUpdate_Lcom_epson_epos2_cat_Cat_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_OnCatStatusUpdate_Lcom_epson_epos2_cat_Cat_I));
			return cb_onCatStatusUpdate_Lcom_epson_epos2_cat_Cat_I;
		}

		static void n_OnCatStatusUpdate_Lcom_epson_epos2_cat_Cat_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cat.IStatusUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cat.Cat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCatStatusUpdate (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCatStatusUpdate_Lcom_epson_epos2_cat_Cat_I;
		public unsafe void OnCatStatusUpdate (global::Com.Epson.Epos2.Cat.Cat? p0, int p1)
		{
			if (id_onCatStatusUpdate_Lcom_epson_epos2_cat_Cat_I == IntPtr.Zero)
				id_onCatStatusUpdate_Lcom_epson_epos2_cat_Cat_I = JNIEnv.GetMethodID (class_ref, "onCatStatusUpdate", "(Lcom/epson/epos2/cat/Cat;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCatStatusUpdate_Lcom_epson_epos2_cat_Cat_I, __args);
		}

	}

	// event args for com.epson.epos2.cat.StatusUpdateListener.onCatStatusUpdate
	public partial class StatusUpdateEventArgs : global::System.EventArgs {
		public StatusUpdateEventArgs (global::Com.Epson.Epos2.Cat.Cat? p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Epson.Epos2.Cat.Cat? p0;

		public global::Com.Epson.Epos2.Cat.Cat? P0 {
			get { return p0; }
		}

		int p1;

		public int P1 {
			get { return p1; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/epos2/cat/StatusUpdateListenerImplementor")]
	internal sealed partial class IStatusUpdateListenerImplementor : global::Java.Lang.Object, IStatusUpdateListener {

		object? sender;

		public unsafe IStatusUpdateListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<StatusUpdateEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnCatStatusUpdate (global::Com.Epson.Epos2.Cat.Cat? p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new StatusUpdateEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IStatusUpdateListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
