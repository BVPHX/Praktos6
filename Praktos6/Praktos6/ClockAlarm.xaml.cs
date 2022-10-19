using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace Praktos6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClockAlarm : ContentPage
    {
      
        TimeSpan alarmTime;
        public ClockAlarm()
        {
            InitializeComponent();
        }
        private async void BudiCompare()
        {
            List<DayOfWeek> dates = new List<DayOfWeek>();
            if (d1.IsToggled == true) dates.Add(DayOfWeek.Monday);
            if (d2.IsToggled == true) dates.Add(DayOfWeek.Tuesday);
            if (d3.IsToggled == true) dates.Add(DayOfWeek.Wednesday);
            if (d4.IsToggled == true) dates.Add(DayOfWeek.Thursday);
            if (d5.IsToggled == true) dates.Add(DayOfWeek.Friday);
            if (d6.IsToggled == true) dates.Add(DayOfWeek.Saturday);
            if (d7.IsToggled == true) dates.Add(DayOfWeek.Sunday);
            while (dates.Contains(DateTime.Now.DayOfWeek) && (int)DateTime.Now.TimeOfDay.TotalMinutes !=  (int)alarmTime.TotalMinutes)
            {
                await Task.Delay(100);
            }
            
            DisplayAlert("Внимание","Просыпайтесь","ОК");
        }

        private void Budi(object sender, EventArgs e)
        {
            alarmTime = timePicker.Time;
            DisplayAlert("1", "Будильник сработает в " + alarmTime.ToString(), "ОК");
            BudiCompare();
        }

        
    }
}