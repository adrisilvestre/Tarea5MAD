using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Tarea5MAD.iOS.Services;
using Tarea5MAD.Services;
using UIKit;
using Xamarin.Forms.Internals;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceOrientationService))]
namespace Tarea5MAD.iOS.Services
{
    public class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
                orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}