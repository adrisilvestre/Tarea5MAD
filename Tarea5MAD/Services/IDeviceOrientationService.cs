using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace Tarea5MAD.Services
{
    public interface IDeviceOrientationService
    {
        DeviceOrientation GetOrientation();
    }
}
