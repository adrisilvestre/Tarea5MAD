using System;
using System.Collections.Generic;
using System.Text;
using Tarea5MAD.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using System.Windows.Input;
using System.ComponentModel;
using Tarea5MAD.Views;

namespace Tarea5MAD.ViewModels
{
    public class TestOrientationPageViewModel:INotifyPropertyChanged
    {
        public string StringOrientation { get; set; }
        
        public ICommand OrientationCommand { get; set; }
        public ICommand RenderersCommand { get; set; }
        public TestOrientationPageViewModel()
        {
            OrientationCommand= new Command(async () =>
            {
                DeviceOrientation orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();

                if (orientation == DeviceOrientation.Landscape)
                {
                    StringOrientation = "El dispositivo está en modo Landscape";
                   
                }
                if (orientation == DeviceOrientation.Portrait)
                {
                    StringOrientation = "El dispositivo está en modo Portrait";
                    
                }
            });

            RenderersCommand = new Command(async () =>
            {
                
                await App.Current.MainPage.Navigation.PushModalAsync(new TestRenderersPage());
                await App.Current.MainPage.Navigation.PopToRootAsync();
            });


        }
      
        public event PropertyChangedEventHandler PropertyChanged;


    }
}
