// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LMT46 {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("DemoADIPhone")]
	public partial class DemoADIPhone {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.iAd.ADBannerView __mt_adBanner;
		
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
		
		[MonoTouch.Foundation.Connect("adBanner")]
		private MonoTouch.iAd.ADBannerView adBanner {
			get {
				this.__mt_adBanner = ((MonoTouch.iAd.ADBannerView)(this.GetNativeField("adBanner")));
				return this.__mt_adBanner;
			}
			set {
				this.__mt_adBanner = value;
				this.SetNativeField("adBanner", value);
			}
		}
	}
}
