using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GridActivity1
{
    public partial class MainPage : ContentPage
    {
        bool continueBlinking = true;

        public MainPage()
        {
            InitializeComponent();
            mainLabel.Text = "";
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            if (mainLabel.Text.Length < 30)
            {
                mainLabel.Text = mainLabel.Text + "1";
                adjustFontsize();
            }
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            if (mainLabel.Text.Length < 30)
            {
                mainLabel.Text = mainLabel.Text + "2";
                adjustFontsize();
            }
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            if (mainLabel.Text.Length < 30)
            {
                mainLabel.Text = mainLabel.Text + "3";
                adjustFontsize();
            }
        }
        private void Button4_Clicked(object sender, EventArgs e)
        {
            if (mainLabel.Text.Length < 30)
            {
                mainLabel.Text = mainLabel.Text + "4";
                adjustFontsize();
            }
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            if (mainLabel.Text.Length < 30)
            {
                mainLabel.Text = mainLabel.Text + "5";
                adjustFontsize();
            }
        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            if (mainLabel.Text.Length < 30)
            {
                mainLabel.Text = mainLabel.Text + "6";
                adjustFontsize();
            }
        }
        private void Button7_Clicked(object sender, EventArgs e)
        {
            if (mainLabel.Text.Length < 30)
            {
                mainLabel.Text = mainLabel.Text + "7";
                adjustFontsize();
            }
        }

        private void Button8_Clicked(object sender, EventArgs e)
        {
            if (mainLabel.Text.Length < 30)
            {
                mainLabel.Text = mainLabel.Text + "8";
                adjustFontsize();
            }
        }

        private void Button9_Clicked(object sender, EventArgs e)
        {
            if (mainLabel.Text.Length < 30)
            {
                mainLabel.Text = mainLabel.Text + "9";
                adjustFontsize();
            }
        }

        private void Button0_Clicked(object sender, EventArgs e)
        {
            if (mainLabel.Text.Length < 30)
            {
                mainLabel.Text = mainLabel.Text + "0";
                adjustFontsize();
            }
        }

        private void ButtonClear_Clicked(object sender, EventArgs e)
        {
            mainLabel.Text = "";
            dialLabel.Text = "";
            mainLabel.FontSize = 50;
        }

        private void ButtonBack_Clicked(object sender, EventArgs e)
        {  
            if (mainLabel.Text != "")
            {
                mainLabel.Text = mainLabel.Text.Substring(0, mainLabel.Text.Length - 1);
                adjustFontsize();
            }
        }


        private void ButtonDial_Clicked(object sender, EventArgs e)
        {
            if (mainLabel.Text != "")
            {
                buttonStop.IsVisible = true;
                dialLabel.Text = "Dialing..";
                Blink();
                disableButtons();
                buttonDial.IsVisible = false;
            }
        }

        private void ButtonStop_Clicked(object sender, EventArgs e)
        {
            continueBlinking = false;
            if (mainLabel.Text != "")
            {
                dialLabel.Text = "";
                enableButtons();
                buttonDial.IsVisible = true;
                buttonStop.IsVisible = false;
            }
        }

        private void disableButtons()
        {
            button1.IsEnabled = false;
            button2.IsEnabled = false;
            button3.IsEnabled = false;
            button4.IsEnabled = false;
            button5.IsEnabled = false;
            button6.IsEnabled = false;
            button7.IsEnabled = false;
            button8.IsEnabled = false;
            button9.IsEnabled = false;
            button0.IsEnabled = false;
            buttonClear.IsEnabled = false;
            buttonBack.IsEnabled = false;
        }

        private void enableButtons()
        {
            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;
            button0.IsEnabled = true;
            buttonClear.IsEnabled = true;
            buttonBack.IsEnabled = true;
        }

        private void adjustFontsize()
        {
            if (mainLabel.Text != "")
            {
                if (mainLabel.Text.Length > 6)
                {
                    mainLabel.FontSize = 30;
                }
                if (mainLabel.Text.Length > 10)
                {
                    mainLabel.FontSize = 20;
                }
                if (mainLabel.Text.Length <= 6)
                {
                    mainLabel.FontSize = 50;
                }
                if (mainLabel.Text.Length < 10 && mainLabel.Text.Length > 6)
                {
                    mainLabel.FontSize = 30;
                }
            }
        }

        private async void Blink()
        {
            continueBlinking = true;
            while (continueBlinking)
            {
                await Task.Delay(800);
                dialLabel.TextColor = dialLabel.TextColor == Color.FromHex("#354242") ? Color.White : Color.FromHex("#354242");
            }
        }
    }
}
