using System;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Gaming.Input;
using Windows.UI.Popups;

namespace HelloUWP
{

    public sealed partial class Page3 : Page
    {
        Gamepad controller;
        DispatcherTimer dispatcherTimer;
        TimeSpan period = TimeSpan.FromMilliseconds(100);
        double xyz;

        public Page3()
        {

            this.InitializeComponent();
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Start();
            textBlock.Visibility = Visibility.Collapsed;
            textBlock2.Visibility = Visibility.Collapsed;
        }

        private void dispatcherTimer_Tick(object sender, object e)
        {
            if (Gamepad.Gamepads.Count > 0)
            {
                controller = Gamepad.Gamepads.First();
                var reading = controller.GetCurrentReading();
                if (reading.LeftTrigger > 0.1)
                {
                    double lt = Math.Round(reading.LeftTrigger, 1);
                    textBlock.Text = lt.ToString();
                }
                else
                {
                    textBlock.Text = "0";
                }

                if (reading.RightTrigger > 0.1)
                {
                    double rt = Math.Round(reading.RightTrigger, 1);
                    textBlock2.Text = rt.ToString();
                }
                else
                {
                    textBlock2.Text = "0";
                }

                if (reading.Buttons.HasFlag(GamepadButtons.Y))
                {
                    
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Windows.ApplicationModel.Core.CoreApplication.Exit();
        }
    }

}
