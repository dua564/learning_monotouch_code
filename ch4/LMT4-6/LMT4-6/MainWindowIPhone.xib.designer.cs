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
	
	
	// Base type probably should be MonoTouch.Foundation.NSObject or subclass
	[MonoTouch.Foundation.Register("AppDelegateIPhone")]
	public partial class AppDelegateIPhone {
		
		private MonoTouch.UIKit.UIWindow __mt_window;
		
		private DemoADIPhone __mt_demoAdIPhone;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("window")]
		private MonoTouch.UIKit.UIWindow window {
			get {
				this.__mt_window = ((MonoTouch.UIKit.UIWindow)(this.GetNativeField("window")));
				return this.__mt_window;
			}
			set {
				this.__mt_window = value;
				this.SetNativeField("window", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("demoAdIPhone")]
		private DemoADIPhone demoAdIPhone {
			get {
				this.__mt_demoAdIPhone = ((DemoADIPhone)(this.GetNativeField("demoAdIPhone")));
				return this.__mt_demoAdIPhone;
			}
			set {
				this.__mt_demoAdIPhone = value;
				this.SetNativeField("demoAdIPhone", value);
			}
		}
	}
}