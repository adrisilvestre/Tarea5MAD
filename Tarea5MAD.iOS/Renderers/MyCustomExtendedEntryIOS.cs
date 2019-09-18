using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Tarea5MAD.Controls;
using Tarea5MAD.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyCustomExtendedEntry), typeof(MyCustomExtendedEntryIOS))]
namespace Tarea5MAD.iOS.Renderers
{
    public class MyCustomExtendedEntryIOS:EntryRenderer
    {
        public MyCustomExtendedEntryIOS()
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
            }
        }
    }
}