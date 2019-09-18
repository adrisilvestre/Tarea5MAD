using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

using Tarea5MAD.Views;

namespace Tarea5MAD.ViewModels
{
    public class TestRenderersPageViewModel
    {
        public ICommand FEffectCommand { get; set; }
        public TestRenderersPageViewModel()
        {
            FEffectCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new TestFocusEffectPage());
            });
        }
    }
}
