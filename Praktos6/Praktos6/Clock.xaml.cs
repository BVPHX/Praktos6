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
    public partial class Clock : ContentPage
    {

        public Clock()
        {
            InitializeComponent();
            ClockTick();
        }
        private async void ClockTick()
        {
            while (true)
            {
                timePicker.Time = DateTime.Now.TimeOfDay;
                await Task.Delay(1000);
            }
        }
    }
}