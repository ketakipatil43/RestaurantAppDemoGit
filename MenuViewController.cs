// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
//using RestaurantApp.WebRepository;
using UIKit;

namespace RestaurantApp
{
	public partial class MenuViewController : UIViewController
    {
        public static List<String> imagedata = new List<string>();
        public MenuViewController (IntPtr handle) : base (handle)
		{
		}
        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            MenuTableViewSource mm = new MenuTableViewSource();
            imagedata = await mm.LoadImageData();
            LoadMainTableData();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
        public void LoadMainTableData()
        {
            GetData gg = new GetData();
            var str = MainTableViewSource.selectedName;
            var hotels = gg.distinctMenu(str);
            menuTableView.Source = new MenuTableViewSource(this, hotels);
        }
    }
}