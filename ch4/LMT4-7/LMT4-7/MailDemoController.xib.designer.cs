// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LMT47 {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("MailDemoController")]
	public partial class MailDemoController {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UIButton __mt_mailButton;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("mailButton")]
		private MonoTouch.UIKit.UIButton mailButton {
			get {
				this.__mt_mailButton = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("mailButton")));
				return this.__mt_mailButton;
			}
			set {
				this.__mt_mailButton = value;
				this.SetNativeField("mailButton", value);
			}
		}
	}
}
