using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace Praktos6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StopWatch : ContentPage
    {
        bool isTimeRunning;
        TimeSpan x = new TimeSpan(0, 0, 1);
        public StopWatch()
        {
            InitializeComponent();
        }
        List<TimeSpan> time = new List<TimeSpan>();
        private void startWatch_Clicked(object sender, EventArgs e)
        {
            isTimeRunning = true;
            StopWatch_Tick();
        } 
        private void stopWatch_Clicked(object sender, EventArgs e)
        {
            isTimeRunning = false;
            time.Add(timePicker.Time);
            timePicker.Time = new TimeSpan(0, 0, 0, 0);
        }
        private async void StopWatch_Tick()
        {
            while (isTimeRunning == true)
            {
                timePicker.Time = timePicker.Time + x;
                await Task.Delay(1000);
            }
            
        }

       
    }
}