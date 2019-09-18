using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Tarea5MAD.Controls;
using Tarea5MAD.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyCustomExtendedEntry), typeof(MyCustomExtendedEntryDroid))]
namespace Tarea5MAD.Droid.Renderers
{

    public class MyCustomExtendedEntryDroid:EntryRenderer
    {
        public MyCustomExtendedEntryDroid(Context context): base (context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
            }
        }
    }
}