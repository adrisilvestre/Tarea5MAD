using System;
using System.Collections.Generic;
using System.Text;
using Tarea5MAD.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using System.Windows.Input;
using System.ComponentModel;

namespace Tarea5MAD.ViewModels
{
    public class TestOrientationPageViewModel:INotifyPropertyChanged
    {
        public string StringOrientation { get; set; }
        
        public ICommand OrientationCommand { get; set; }
        public TestOrientationPageViewModel()
        {
            OrientationCommand= new Command(async () =>
            {
                DeviceOrientation orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();

                if (orientation == DeviceOrientation.Landscape)
                {
                    StringOrientation = "El dispositivo está en modo landscape";
                   
                }
                if (orientation == DeviceOrientation.Portrait)
                {
                    StringOrientation = "El dispositivo está en modo portrait";
                    
                }
            });

                
            
        }
        public event PropertyChangedEventHandler PropertyChanged;


    }
}
