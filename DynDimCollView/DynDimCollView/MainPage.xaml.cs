using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DynDimCollView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Items = new ObservableCollection<Item> { new Item { Name = "Item1" }, new Item { Name = "Item2" }, new Item { Name = "Item3" }, new Item { Name = "Item4" }, new Item { Name = "Item5" } };
        }

        private void PageSizeChanged(object sender, EventArgs e)
        {
            var width = this.Width;
            var height = this.Height;
            if (width != 0 && height != 0)
            {
                ItemsWidth = width / 4;
                ItemsHeight = height / 4;
            }
        }

        //protected override void OnSizeAllocated(double width, double height)
        //{
            
        //    base.OnSizeAllocated(width, height);
            
        //}

        public static BindableProperty ItemsProperty =
            BindableProperty.Create(
                nameof(Items),
                typeof(ObservableCollection<Item>),
                typeof(MainPage),
                null,
                BindingMode.OneWay);


        public static BindableProperty ItemsHeightProperty =
            BindableProperty.Create(
                nameof(ItemsHeight),
                typeof(double),
                typeof(MainPage),
                null,
                BindingMode.OneWay);

        public static BindableProperty ItemsWidthProperty =
            BindableProperty.Create(
                nameof(ItemsWidth),
                typeof(double),
                typeof(MainPage),
                null,
                BindingMode.OneWay);

        public ObservableCollection<Item> Items
        {
            get => (ObservableCollection<Item>)GetValue(ItemsProperty);
            set => SetValue(ItemsProperty, value);
        }

        public double ItemsHeight
        {
            get => (double)GetValue(ItemsHeightProperty);
            set => SetValue(ItemsHeightProperty, value);
        }

        public double ItemsWidth
        {
            get => (double)GetValue(ItemsWidthProperty);
            set => SetValue(ItemsWidthProperty, value);
        }

    }
}
