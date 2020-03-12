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

namespace MusicPlayer
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

        private void AddSongButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void Reverse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Shuffle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
