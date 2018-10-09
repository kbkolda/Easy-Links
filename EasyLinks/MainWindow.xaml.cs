using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XAMLButton
{

    /// <summary> 
    /// Interaction logic for MainWindow.xaml 
    /// </summary>

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        void OnClick1(object sender, RoutedEventArgs e)
        {
            button1.Foreground = new SolidColorBrush(Colors.Black);
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        void OnClick2(object sender, RoutedEventArgs e)
        {
            button2.Foreground = new SolidColorBrush(Colors.Black);
            System.Diagnostics.Process.Start("http://www.reddit.com");
        }

        void OnClick3(object sender, RoutedEventArgs e)
        {
            button3.Foreground = new SolidColorBrush(Colors.Black);
            System.Diagnostics.Process.Start("https://analytics.google.com/analytics/web/?authuser=0#/realtime/rt-location/a126296840w184981340p182242360/filter.list=10==~2F;/");
        }

        void OnClick4(object sender, RoutedEventArgs e)
        {
            button4.Foreground = new SolidColorBrush(Colors.Black);
            System.Diagnostics.Process.Start("https://search.google.com/search-console?resource_id=http%3A%2F%2Fsupremeresale.org%2F");
        }
        void OnClick5(object sender, RoutedEventArgs e)
        {
            button5.Foreground = new SolidColorBrush(Colors.Black);
            System.Diagnostics.Process.Start("http://www.google.com");
            System.Diagnostics.Process.Start("http://www.reddit.com");
            System.Diagnostics.Process.Start("https://analytics.google.com/analytics/web/?authuser=0#/realtime/rt-location/a126296840w184981340p182242360/filter.list=10==~2F;/");
            System.Diagnostics.Process.Start("https://wordpress.com/stats/day/supremeresale.org?tab=views");
        }

    }
}
