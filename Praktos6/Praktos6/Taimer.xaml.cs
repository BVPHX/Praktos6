using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Praktos6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Taimer : ContentPage
    {
        TimeSpan q= new TimeSpan(0,0,1);
        TimeSpan previousSpan;
        bool isTimeGone;
        public Taimer()
        {
            InitializeComponent();
        }
        private async void TimerTick()
        {
            while (timePicker.Time.TotalSeconds !=0)
            {
                timePicker.Time = timePicker.Time - q;
                await Task.Delay(1000);
            }
            DisplayAlert("Vremya","Vremya vishlo","ok");
            timerButton.IsEnabled = true;
            isTimeGone = true;
        }

        private void StartTimer(object sender, EventArgs e)
        {
            previousSpan = timePicker.Time;
            
            TimerTick();
            timerButton.IsEnabled = false;
            isTimeGone = false;
        }

        private void RestartTimer(object sender, EventArgs e)
        {
            if (isTimeGone == true)
            {
                timePicker.Time = previousSpan;
                TimerTick();
            }
            else
            {
                DisplayAlert("☺", "Ti durak?)", "ok");
            }
        }
    }
}