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
        public MainWindow()
        {
            InitializeComponent();
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            dispatcherTimer.Start();


            
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            var currentmargin = button1.Margin;
            currentmargin.Left += 1;
            currentmargin.Top += 1;
            button1.Margin = currentmargin;

        }

        private void Button1_OnClick(object sender, MouseEventArgs mouseEventArgs)
        {
            button1.Visibility = Visibility.Hidden;
            score+=1;
            scorelabel.Content = score;
        }

    }
}
