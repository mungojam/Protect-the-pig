using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace protect_the_pig
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int score;
        Random random=new Random();
        private int buttonleft = 1;
        private int buttontop = 1;
        public MainWindow()
        {
            InitializeComponent();
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 5);
            dispatcherTimer.Start();


            
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            var currentmargin = button1.Margin;
            currentmargin.Left += buttonleft;
            currentmargin.Top += buttontop;
            button1.Margin = currentmargin;
            if (currentmargin.Left>769.5)
            {
                buttonleft = -1;

            }
            if (currentmargin.Top >399)
            {
                buttontop = -1;

            }
            if (currentmargin.Left <0)
            {
                buttonleft = 1;

            }
            if (currentmargin.Top <0)
            {
                buttontop = 1;

            }
            if (currentmargin.Left > 275.973 && currentmargin.Left < 499.451 && currentmargin.Top > 147.254 && currentmargin.Top < 272.06 )
            {
                Gameover.Visibility = Visibility.Visible;
                button1.Visibility = Visibility.Hidden;

            }
           


        }

        private void Button1_OnClick(object sender, MouseEventArgs mouseEventArgs)
        {
            var margin = new Thickness(random.Next(0, 769), random.Next(0, 399),0,0);
            button1.Margin=margin;
            score+=1;
            scorelabel.Content = score;
        }

    }
}
