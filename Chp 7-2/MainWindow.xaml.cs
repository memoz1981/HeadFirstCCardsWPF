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

namespace Chp_7_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Deck deck1;
        Deck deck2;
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void moveToDeck2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void moveToDeck1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void reset1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void reset2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void shuffle1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void shuffle2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ResetDeck(int i)
        {
            if (i == 1)
            {
                deck1=new Deck()
            
            }
        
        
        
        }
    }
}
