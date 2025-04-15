using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Cat {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.cat']/interface[@name='ClearOutputListener']"
	[Register ("com/epson/epos2/cat/ClearOutputListener", "", "Com.Epson.Epos2.Cat.IClearOutputListenerInvoker")]
	public partial interface IClearOutputListener : global::Java.Util.IEventListener {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.cat']/interface[@name='ClearOutputListener']/method[@name='onCatClearOutput' and count(parameter)=3 and parameter[1][@type='com.epson.epos2.cat.Cat'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onCatClearOutput", "(Lcom/epson/epos2/cat/Cat;II)V", "GetOnCatClearOutput_Lcom_epson_epos2_cat_Cat_IIHandler:Com.Epson.Epos2.Cat.IClearOutputListenerInvoker, EpsonBinding")]
		void OnCatClearOutput (global::Com.Epson.Epos2.Cat.Cat? p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/cat/ClearOutputListener", DoNotGenerateAcw=true)]
	internal partial class IClearOutputListenerInvoker : global::Java.Lang.Object, IClearOutputListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/cat/ClearOutputListener", typeof (IClearOutputListenerInvoker));

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

		public static IClearOutputListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClearOutputListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.cat.ClearOutputListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClearOutputListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onCatClearOutput_Lcom_epson_epos2_cat_Cat_II;
#pragma warning disable 0169
		static Delegate GetOnCatClearOutput_Lcom_epson_epos2_cat_Cat_IIHandler ()
		{
			if (cb_onCatClearOutput_Lcom_epson_epos2_cat_Cat_II == null)
				cb_onCatClearOutput_Lcom_epson_epos2_cat_Cat_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLII_V (n_OnCatClearOutput_Lcom_epson_epos2_cat_Cat_II));
			return cb_onCatClearOutput_Lcom_epson_epos2_cat_Cat_II;
		}

		static void n_OnCatClearOutput_Lcom_epson_epos2_cat_Cat_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cat.IClearOutputListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Cat.Cat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCatClearOutput (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onCatClearOutput_Lcom_epson_epos2_cat_Cat_II;
		public unsafe void OnCatClearOutput (global::Com.Epson.Epos2.Cat.Cat? p0, int p1, int p2)
		{
			if (id_onCatClearOutput_Lcom_epson_epos2_cat_Cat_II == IntPtr.Zero)
				id_onCatClearOutput_Lcom_epson_epos2_cat_Cat_II = JNIEnv.GetMethodID (class_ref, "onCatClearOutput", "(Lcom/epson/epos2/cat/Cat;II)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCatClearOutput_Lcom_epson_epos2_cat_Cat_II, __args);
		}

	}
}
