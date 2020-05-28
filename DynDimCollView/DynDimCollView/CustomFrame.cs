using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DynDimCollView
{
    class CustomFrame : Frame
    {
        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == WidthRequestProperty.PropertyName)
            {
                //base.ForceLayout();
            }
        }
    }
}
