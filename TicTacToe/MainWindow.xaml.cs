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

namespace TicTacToe
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

        private void KaestchenClick(object sender, RoutedEventArgs e)
        {
            var bisherigerVordergrund = kaestchen_0_0.Foreground;
            kaestchen_0_0.Foreground = kaestchen_0_0.Background;
            kaestchen_0_0.Background = bisherigerVordergrund;
        }

        private void Kaestchen_1_0_Click(object sender, RoutedEventArgs e)
        {
            var bisherigerVordergrund = kaestchen_1_0.Foreground;
            kaestchen_1_0.Foreground = kaestchen_1_0.Background;
            kaestchen_1_0.Background = bisherigerVordergrund;
        }

        private void Kaestchen_2_0_Click(object sender, RoutedEventArgs e)
        {
            var bisherigerVordergrund = kaestchen_2_0.Foreground;
            kaestchen_2_0.Foreground = kaestchen_2_0.Background;
            kaestchen_2_0.Background = bisherigerVordergrund;
        }

        private void Kaestchen_0_1_Click(object sender, RoutedEventArgs e)
        {
            var bisherigerVordergrund = kaestchen_0_1.Foreground;
            kaestchen_0_1.Foreground = kaestchen_0_1.Background;
            kaestchen_0_1.Background = bisherigerVordergrund;
        }

        private void Kaestchen_1_1_Click(object sender, RoutedEventArgs e)
        {
            var bisherigerVordergrund = kaestchen_1_1.Foreground;
            kaestchen_1_1.Foreground = kaestchen_1_1.Background;
            kaestchen_1_1.Background = bisherigerVordergrund;
        }

        private void Kaestchen_2_1_Click(object sender, RoutedEventArgs e)
        {
            var bisherigerVordergrund = kaestchen_2_1.Foreground;
            kaestchen_2_1.Foreground = kaestchen_2_1.Background;
            kaestchen_2_1.Background = bisherigerVordergrund;
        }

        private void Kaestchen_0_2_Click(object sender, RoutedEventArgs e)
        {
            var bisherigerVordergrund = kaestchen_0_2.Foreground;
            kaestchen_0_2.Foreground = kaestchen_0_2.Background;
            kaestchen_0_2.Background = bisherigerVordergrund;
        }

        private void Kaestchen_1_2_Click(object sender, RoutedEventArgs e)
        {
            var bisherigerVordergrund = kaestchen_1_2.Foreground;
            kaestchen_1_2.Foreground = kaestchen_1_2.Background;
            kaestchen_1_2.Background = bisherigerVordergrund;
        }

        private void Kaestchen_2_2_Click(object sender, RoutedEventArgs e)
        {
            var bisherigerVordergrund = kaestchen_2_2.Foreground;
            kaestchen_2_2.Foreground = kaestchen_2_2.Background;
            kaestchen_2_2.Background = bisherigerVordergrund;
        }
    }
}
