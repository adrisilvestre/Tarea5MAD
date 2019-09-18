using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tarea5MAD.ViewModels;

namespace Tarea5MAD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestOrientationPage : ContentPage
    {
        public TestOrientationPage()
        {
            InitializeComponent();
            BindingContext = new TestOrientationPageViewModel();
        }
    }
}