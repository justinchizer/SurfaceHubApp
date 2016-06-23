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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SurfaceHubApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        private Windows.System.Display.DisplayRequest _displayRequest; // This should make the hub always be awake

        public void ActivateDisplay()

        {
            //create the request instance if needed

            if (_displayRequest == null)

                _displayRequest = new Windows.System.Display.DisplayRequest();

            //make request to put in active state

            _displayRequest.RequestActive(); //Read more at https://blogs.windows.com/buildingapps/2016/05/24/how-to-prevent-screen-locks-in-your-uwp-apps/#VqWEXSXJBvGD8WzJ.99
        }



    }
}