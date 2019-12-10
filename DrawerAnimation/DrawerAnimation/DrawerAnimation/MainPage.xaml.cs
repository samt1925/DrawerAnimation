using System.ComponentModel;
using Xamarin.Forms;

namespace DrawerAnimation
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        double SelectedVal = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Frame1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (((DrawerDetailFrame)sender).SelectedValue != SelectedVal && Frame2.IsVisible)
            {
                SelectedVal = ((DrawerDetailFrame)sender).SelectedValue;
                Frame2.TranslateTo(Frame2.TranslationX, SelectedVal == 275 ? Frame2.TranslationY + 200 : Frame2.TranslationY - 200, 500, Easing.SinOut);
            }
        }
    }
}
