using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace RandomSampling
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("th.jpg"))
            {
                bgimg.ImageSource = new BitmapImage(new Uri("th.jpg", UriKind.Relative));
            }
            this.DataContext = new MainViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
