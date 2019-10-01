using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using SoccerBetting.Interface;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(SoccerBetting.iOS.DependenceService.DeviceInfoImpl))]
namespace SoccerBetting.iOS.DependenceService
{
    public class DeviceInfoImpl : DeviceInfo
    {
        public bool IsIphoneXDevice()
        {
            if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone)
            {
                if ((UIScreen.MainScreen.Bounds.Height * UIScreen.MainScreen.Scale) == 1792 || /* XR */
                    (UIScreen.MainScreen.Bounds.Height * UIScreen.MainScreen.Scale) == 2436 || /* X, XS*/
                    (UIScreen.MainScreen.Bounds.Height * UIScreen.MainScreen.Scale) == 2688)   /* XS Max*/
                {
                    return true;
                }
            }
            return false;
        }
    }
}