using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Touch.Views;
using CrossPlatform.Core.ViewModels;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace CrossPlatform.iOS.Views
{
    [Register("SecondView")]
    public class SecondView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
                EdgesForExtendedLayout = UIRectEdge.None;

            var set = this.CreateBindingSet<SecondView, SecondViewModel>();
            set.Bind(this).For("Title").To(vm => vm.Price);
            set.Apply();
        }
    }
}