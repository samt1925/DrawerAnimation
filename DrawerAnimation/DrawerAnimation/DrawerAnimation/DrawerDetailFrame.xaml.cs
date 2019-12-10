using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrawerAnimation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrawerDetailFrame : ContentView
    {
        bool isExpanded = false;
        public DrawerDetailFrame()
        {
            InitializeComponent();
        }

        private void Frame_Tapped(object sender, EventArgs e)
        {
            if (!isExpanded)
                AnimateIn();
            else
                AnimateOut();

            isExpanded = !isExpanded;
        }

        private void AnimateIn()
        {
            Dog1Frame.LayoutTo(new Rectangle(Dog1Frame.X, Dog1Frame.Y, Dog1Frame.Width, 275), 500, Easing.SinOut);
            SelectedValue = 275;
        }

        private void AnimateOut()
        {
            Dog1Frame.LayoutTo(new Rectangle(Dog1Frame.X, Dog1Frame.Y, Dog1Frame.Width, 75), 500, Easing.SinOut);
            SelectedValue = 75;
        }

        public static readonly BindableProperty SelectedValueProperty =
BindableProperty.Create("SelectedValue", typeof(double), typeof(DrawerDetailFrame), defaultBindingMode: BindingMode.OneWay);
        public double SelectedValue
        {
            get { return ((double)(base.GetValue(SelectedValueProperty))); }
            set { SetValue(SelectedValueProperty, value); }
        }
    }
}