using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace CrossPlatform.iOS.Views
{
    [Register("FirstView")]
    public class FirstView : MvxTableViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

			// ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
               EdgesForExtendedLayout = UIRectEdge.None;

            var source = new MvxStandardTableViewSource(TableView, "TitleText Name; ImageUrl ImageUrl");
            TableView.Source = source;

            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
            set.Bind(source).To(vm => vm.Kittens);
            set.Bind(source).For(x => x.SelectionChangedCommand).To(vm => vm.ShowKittenCommand);
            set.Apply();
        }
    }
}