using System;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Gaming.Input;
using Windows.UI.Popups;

namespace HelloUWP
{

    public sealed partial class MainPage : Page
    {
        Gamepad controller;
        public int scenarioCounter = 0;
        public RotationClass rotation;
        double randomRotation;
        ContentDialog dialog;
        DispatcherTimer dispatcherTimer;
        TimeSpan period = TimeSpan.FromMilliseconds(100);


        public MainPage()
        {
            Random random = new Random();
            randomRotation = random.Next(5, 85);
            rotation = new RotationClass(randomRotation);

            this.InitializeComponent();
            this.DataContext = rotation;
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dialog = new ContentDialog();
            dialog.Content = "Kwadraty muszą być identycznie obrócone (Y = podpowiedź)";

            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, object e)
        {
            if (Gamepad.Gamepads.Count > 0)
            {
                controller = Gamepad.Gamepads.First();
                var reading = controller.GetCurrentReading();

                if (reading.Buttons.HasFlag(GamepadButtons.Y))
                {
                    dialog.Hide();
                    if (rotation.Rotation == rotation.RandomRotation)
                    {
                        textBlock1.Text = "Można przejść dalej";
                    }
                    else
                    {
                        textBlock1.Text = "Pomyłka: " + (rotation.Rotation - rotation.RandomRotation).ToString();
                    }
                }
                else
                {
                    textBlock1.Text = "";
                }

            }

        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            if (rotation.Rotation == rotation.RandomRotation)
            {
                this.Frame.Navigate(typeof(Page2));
            }
            else
            {
                try
                {await dialog.ShowAsync();} catch{ dialog.Hide(); }
            }
        }

    }

    public class RotationClass
    {
        public RotationClass(double random)
        {
            this.randomRotationValue = random;
        }

        private double rotationValue;
        public double Rotation
        {
            get { return rotationValue; }
            set { rotationValue = value; }
        }

        private double randomRotationValue;
        public double RandomRotation
        {
            get { return randomRotationValue; }
            set { randomRotationValue = value; }
        }
    }
}
