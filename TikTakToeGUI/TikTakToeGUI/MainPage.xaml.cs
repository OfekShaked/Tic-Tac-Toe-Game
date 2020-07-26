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
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TikTakToeGUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int countTurn = 1;
        public MainPage()
        {
            this.InitializeComponent();
            
        }
        private async static void PrintWinner(int count)
        {
            MessageDialog md;
            if (count % 2 == 0)
            {
                
                md = new MessageDialog("---------------------------------------------------------------------------------------------------\n" +
                    "- xx     xx            xx    xx      xxxxxxx      xx     xx       xx           xx     xx     xx     xx----\n" +
                    "-  xx   xx             xx    xx     xx     xx     xx     xx       xx           xx     xx     xxxx   xx----\n" +
                    "-   xx xx              xx    xx     xx     xx     xx     xx        xx         xx      xx     xx x   xx----\n" +
                    "-     xx                xx  xx      xx     xx     xx     xx        xx         xx      xx     xx   x xx----\n" +
                    "-   xx xx                 xx        xx     xx     xx     xx         xx  xxx  xx       xx     xx   x xx----\n" +
                    "-  xx   xx                xx        xx     xx     xx     xx          xx xxx xx        xx     xx    xxx----\n" +
                    "- xx     xx               xx          xxxxx         xxxxx             xx   xx         xx     xx     xx----\n" +
                    "----------------------------------------------------------------------------------------------------------");
                await md.ShowAsync();
            }
            else
            {
                md = new MessageDialog("--------------------------------------------------------------------------------------\n" +
                    "-   xxxxxxx         xx    xx      xxxxxxx      xx     xx      xx             xx     xx     xx     xx-----\n" +
                    "-  xx     xx        xx    xx     xx     xx     xx     xx      xx             xx     xx     xxxx   xx-----\n" +
                    "-  xx     xx        xx    xx     xx     xx     xx     xx      xx             xx     xx     xx x   xx-----\n" +
                    "-  xx     xx         xx  xx      xx     xx     xx     xx       xx           xx      xx     xx x   xx-----\n" +
                    "-  xx     xx           xx        xx     xx     xx     xx        xx   xxx   xx       xx     xx   x xx-----\n" +
                    "-  xx     xx           xx        xx     xx     xx     xx        xx   xxx   xx       xx     xx   x xx-----\n" +
                    "-   xxxxxxx            xx          xxxxx         xxxxx             xx   xx          xx     xx     xx-----\n" +
                    "---------------------------------------------------------------------------------------------------------");
                await md.ShowAsync();
            }
        }
        private void StartNewGame()
        {
            if (countTurn % 2 == 0)
                txtWinner.Text = "X Won";
            else txtWinner.Text = "O Won";
            txtNewStart.Text = "Do You Want To Start A New Game?";
            btnNo.Visibility = Windows.UI.Xaml.Visibility.Visible;
            btnYes.Visibility = Windows.UI.Xaml.Visibility.Visible;
           
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (btn1.Content == "")
            {
                if (countTurn % 2 == 0)
                    btn1.Content = "X";
                else
                    btn1.Content = "O";
                if (countTurn>2)
                {
                    if (btn1.Content == btn2.Content && btn2.Content == btn3.Content ||
                        btn1.Content == btn4.Content && btn4.Content == btn7.Content ||
                        btn1.Content == btn5.Content && btn5.Content == btn9.Content)
                    {
                        if (btn1.Content == btn4.Content)
                            brdr147.Visibility = Windows.UI.Xaml.Visibility.Visible;
                        else if (btn1.Content == btn2.Content)
                            brdr123.Visibility = Windows.UI.Xaml.Visibility.Visible;
                        else brdr159.Visibility = Windows.UI.Xaml.Visibility.Visible;

                        PrintWinner(countTurn);
                        StartNewGame();
                    }
                    else if (countTurn == 9)
                    {
                        txtWinner.Text = "Draw";
                        StartNewGame();

                    }


                }
                countTurn++;
                btn1.IsEnabled = false;
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (btn2.Content == "")
            {
                if (countTurn % 2 == 0)
                    btn2.Content = "X";
                else
                    btn2.Content = "O";
                if (countTurn > 2)
                {
                    if (btn2.Content == btn3.Content && btn2.Content == btn1.Content ||
                        btn2.Content == btn5.Content && btn5.Content == btn8.Content)
                    { 
                        PrintWinner(countTurn);
                        StartNewGame();
                    }
                    else if (countTurn == 9)
                    {
                        txtWinner.Text = "Draw";
                        StartNewGame();

                    }
                }
                countTurn++;
                btn2.IsEnabled = false;
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (btn3.Content == "")
            {
                if (countTurn % 2 == 0)
                    btn3.Content = "X";
                else
                    btn3.Content = "O";
                if (countTurn>2)
                {
                    if (btn3.Content == btn2.Content && btn2.Content == btn1.Content ||
                        btn3.Content == btn6.Content && btn6.Content == btn9.Content ||
                        btn3.Content == btn5.Content && btn5.Content == btn7.Content)
                    { 
                        PrintWinner(countTurn);
                        StartNewGame();
                    }
                    else if (countTurn == 9)
                    {
                        txtWinner.Text = "Draw";
                        StartNewGame();

                    }
                }
                countTurn++;
                btn3.IsEnabled = false;
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (btn4.Content == "")
            {
                if (countTurn % 2 == 0)
                    btn4.Content = "X";
                else
                    btn4.Content = "O";
                if (countTurn>2)
                {
                    if (btn4.Content == btn1.Content && btn4.Content == btn7.Content ||
                        btn4.Content == btn5.Content && btn5.Content == btn6.Content)
                    { 
                        PrintWinner(countTurn);
                        StartNewGame();
                    }
                    else if (countTurn == 9)
                    {
                        txtWinner.Text = "Draw";
                        StartNewGame();

                    }
                }
                countTurn++;
                btn4.IsEnabled = false;
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (btn5.Content == "")
            {
                if (countTurn % 2 == 0)
                    btn5.Content = "X";
                else
                    btn5.Content = "O";
                if (countTurn>2)
                {
                    if (btn5.Content == btn2.Content && btn5.Content == btn8.Content ||
                        btn5.Content == btn4.Content && btn5.Content == btn6.Content ||
                        btn5.Content == btn1.Content && btn5.Content == btn9.Content ||
                        btn5.Content == btn3.Content && btn5.Content == btn7.Content)
                    { 
                        PrintWinner(countTurn);
                        StartNewGame();
                    }
                    else if (countTurn == 9)
                    {
                        txtWinner.Text = "Draw";
                        StartNewGame();

                    }
                }
                countTurn++;
                btn5.IsEnabled = false;
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (btn6.Content == "")
            {
                if (countTurn % 2 == 0)
                    btn6.Content = "X";
                else
                    btn6.Content = "O";
                if (countTurn>2)
                {
                    if (btn6.Content == btn3.Content && btn6.Content == btn9.Content ||
                        btn6.Content == btn5.Content && btn6.Content == btn4.Content)
                    { 
                        PrintWinner(countTurn);
                        StartNewGame();
                    }
                    else if (countTurn == 9)
                    {
                        txtWinner.Text = "Draw";
                        StartNewGame();

                    }
                }
                countTurn++;
                btn6.IsEnabled = false;
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (btn7.Content == "")
            {
                if (countTurn % 2 == 0)
                    btn7.Content = "X";
                else
                    btn7.Content = "O";
                if (countTurn>2)
                {
                    if (btn7.Content == btn4.Content && btn7.Content == btn1.Content ||
                        btn7.Content == btn8.Content && btn7.Content == btn9.Content ||
                        btn7.Content == btn5.Content && btn7.Content == btn3.Content)
                    { 
                        PrintWinner(countTurn);
                        StartNewGame();
                    }
                    else if (countTurn == 9)
                    {
                        txtWinner.Text = "Draw";
                        StartNewGame();

                    }
                }
                countTurn++;
                btn7.IsEnabled = false;
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (btn8.Content == "")
            {
                if (countTurn % 2 == 0)
                    btn8.Content = "X";
                else
                    btn8.Content = "O";
                if (countTurn>2)
                {
                    if (btn8.Content == btn5.Content && btn8.Content == btn2.Content ||
                        btn8.Content == btn7.Content && btn8.Content == btn9.Content)
                    { 
                        PrintWinner(countTurn);
                        StartNewGame();
                    }
                    else if (countTurn == 9)
                    {
                        txtWinner.Text = "Draw";
                        StartNewGame();

                    }
                }
                countTurn++;
                btn8.IsEnabled = false;
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (btn9.Content == "")
            {
                if (countTurn % 2 == 0)
                    btn9.Content = "X";
                else
                    btn9.Content = "O";
                if (countTurn>2)
                {
                    if (btn9.Content == btn6.Content && btn9.Content == btn3.Content ||
                        btn9.Content == btn8.Content && btn9.Content == btn7.Content ||
                        btn9.Content == btn5.Content && btn9.Content == btn1.Content)
                    { 
                        PrintWinner(countTurn);
                        StartNewGame();
                    }
                    else if (countTurn == 9)
                    {
                        txtWinner.Text = "Draw";
                        StartNewGame();

                    }
                }
                countTurn++;
                btn9.IsEnabled = false;
            }
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            btn1.Content = "";
            btn2.Content = "";
            btn3.Content = "";
            btn4.Content = "";
            btn5.Content = "";
            btn6.Content = "";
            btn7.Content = "";
            btn8.Content = "";
            btn9.Content = "";
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;
            txtWinner.Text = "";
            txtNewStart.Text = "";
            btnNo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            btnYes.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            countTurn = 1;

        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
