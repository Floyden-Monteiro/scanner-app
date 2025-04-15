using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Epson.Epos2.Discovery {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.epson.epos2.discovery']/interface[@name='DiscoveryListener']"
	[Register ("com/epson/epos2/discovery/DiscoveryListener", "", "Com.Epson.Epos2.Discovery.IDiscoveryListenerInvoker")]
	public partial interface IDiscoveryListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.epson.epos2.discovery']/interface[@name='DiscoveryListener']/method[@name='onDiscovery' and count(parameter)=1 and parameter[1][@type='com.epson.epos2.discovery.DeviceInfo']]"
		[Register ("onDiscovery", "(Lcom/epson/epos2/discovery/DeviceInfo;)V", "GetOnDiscovery_Lcom_epson_epos2_discovery_DeviceInfo_Handler:Com.Epson.Epos2.Discovery.IDiscoveryListenerInvoker, EpsonBinding")]
		void OnDiscovery (global::Com.Epson.Epos2.Discovery.DeviceInfo? p0);

	}

	[global::Android.Runtime.Register ("com/epson/epos2/discovery/DiscoveryListener", DoNotGenerateAcw=true)]
	internal partial class IDiscoveryListenerInvoker : global::Java.Lang.Object, IDiscoveryListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/discovery/DiscoveryListener", typeof (IDiscoveryListenerInvoker));

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

		public static IDiscoveryListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDiscoveryListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.epson.epos2.discovery.DiscoveryListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDiscoveryListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onDiscovery_Lcom_epson_epos2_discovery_DeviceInfo_;
#pragma warning disable 0169
		static Delegate GetOnDiscovery_Lcom_epson_epos2_discovery_DeviceInfo_Handler ()
		{
			if (cb_onDiscovery_Lcom_epson_epos2_discovery_DeviceInfo_ == null)
				cb_onDiscovery_Lcom_epson_epos2_discovery_DeviceInfo_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnDiscovery_Lcom_epson_epos2_discovery_DeviceInfo_));
			return cb_onDiscovery_Lcom_epson_epos2_discovery_DeviceInfo_;
		}

		static void n_OnDiscovery_Lcom_epson_epos2_discovery_DeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Discovery.IDiscoveryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Epson.Epos2.Discovery.DeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDiscovery (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDiscovery_Lcom_epson_epos2_discovery_DeviceInfo_;
		public unsafe void OnDiscovery (global::Com.Epson.Epos2.Discovery.DeviceInfo? p0)
		{
			if (id_onDiscovery_Lcom_epson_epos2_discovery_DeviceInfo_ == IntPtr.Zero)
				id_onDiscovery_Lcom_epson_epos2_discovery_DeviceInfo_ = JNIEnv.GetMethodID (class_ref, "onDiscovery", "(Lcom/epson/epos2/discovery/DeviceInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDiscovery_Lcom_epson_epos2_discovery_DeviceInfo_, __args);
		}

	}

	// event args for com.epson.epos2.discovery.DiscoveryListener.onDiscovery
	public partial class DiscoveryEventArgs : global::System.EventArgs {
		public DiscoveryEventArgs (global::Com.Epson.Epos2.Discovery.DeviceInfo? p0)
		{
			this.p0 = p0;
		}

		global::Com.Epson.Epos2.Discovery.DeviceInfo? p0;

		public global::Com.Epson.Epos2.Discovery.DeviceInfo? P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/epson/epos2/discovery/DiscoveryListenerImplementor")]
	internal sealed partial class IDiscoveryListenerImplementor : global::Java.Lang.Object, IDiscoveryListener {

		object? sender;

		public unsafe IDiscoveryListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
		public EventHandler<DiscoveryEventArgs>? Handler;
		#pragma warning restore 0649

		public void OnDiscovery (global::Com.Epson.Epos2.Discovery.DeviceInfo? p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DiscoveryEventArgs (p0));
		}

		internal static bool __IsEmpty (IDiscoveryListenerImplementor value)
		{
			return value.Handler == null;
		}

	}
}
