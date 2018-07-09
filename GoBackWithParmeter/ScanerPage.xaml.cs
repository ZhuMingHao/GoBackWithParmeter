using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GoBackWithParmeter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ScanerPage : Page
    {
    
        public ScanerPage()
        {
            this.InitializeComponent();
        }
        private MainPage mainPage;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            mainPage = e.Parameter as MainPage;
           
            base.OnNavigatedTo(e);
           
        }
        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {   
            base.OnNavigatingFrom(e);
            mainPage.InvokeAction("Hello Word");
        }

        private  void Button_Click(object sender, RoutedEventArgs e)
        {
           this.Frame.GoBack();
        }
    }
}
