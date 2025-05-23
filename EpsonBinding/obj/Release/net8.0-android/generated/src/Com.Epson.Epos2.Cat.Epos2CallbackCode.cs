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

namespace Com.Epson.Epos2.Cat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']"
	[global::Android.Runtime.Register ("com/epson/epos2/cat/Epos2CallbackCode", DoNotGenerateAcw=true)]
	public partial class Epos2CallbackCode : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']/field[@name='CODE_ABORT_FAILURE']"
		[Register ("CODE_ABORT_FAILURE")]
		public const int CodeAbortFailure = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']/field[@name='CODE_BUSY']"
		[Register ("CODE_BUSY")]
		public const int CodeBusy = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']/field[@name='CODE_DISAGREEMENT']"
		[Register ("CODE_DISAGREEMENT")]
		public const int CodeDisagreement = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']/field[@name='CODE_ERR_CENTER']"
		[Register ("CODE_ERR_CENTER")]
		public const int CodeErrCenter = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']/field[@name='CODE_ERR_COMMAND']"
		[Register ("CODE_ERR_COMMAND")]
		public const int CodeErrCommand = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']/field[@name='CODE_ERR_DEVICE']"
		[Register ("CODE_ERR_DEVICE")]
		public const int CodeErrDevice = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']/field[@name='CODE_ERR_FAILURE']"
		[Register ("CODE_ERR_FAILURE")]
		public const int CodeErrFailure = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']/field[@name='CODE_ERR_OPOSCODE']"
		[Register ("CODE_ERR_OPOSCODE")]
		public const int CodeErrOposcode = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']/field[@name='CODE_ERR_PARAM']"
		[Register ("CODE_ERR_PARAM")]
		public const int CodeErrParam = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']/field[@name='CODE_ERR_SYSTEM']"
		[Register ("CODE_ERR_SYSTEM")]
		public const int CodeErrSystem = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']/field[@name='CODE_ERR_TIMEOUT']"
		[Register ("CODE_ERR_TIMEOUT")]
		public const int CodeErrTimeout = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']/field[@name='CODE_EXCEEDING_LIMIT']"
		[Register ("CODE_EXCEEDING_LIMIT")]
		public const int CodeExceedingLimit = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']/field[@name='CODE_INVALID_CARD']"
		[Register ("CODE_INVALID_CARD")]
		public const int CodeInvalidCard = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']/field[@name='CODE_RESET']"
		[Register ("CODE_RESET")]
		public const int CodeReset = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']/field[@name='CODE_SUCCESS']"
		[Register ("CODE_SUCCESS")]
		public const int CodeSuccess = (int) 0;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/epson/epos2/cat/Epos2CallbackCode", typeof (Epos2CallbackCode));

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

		protected Epos2CallbackCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.epson.epos2.cat']/class[@name='Epos2CallbackCode']/constructor[@name='Epos2CallbackCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Epos2CallbackCode () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

	}
}
