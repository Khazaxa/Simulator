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

namespace Intel886
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> rosters = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            rosters.Add("DX");
            rosters.Add("CX");
            rosters.Add("BX");
            rosters.Add("AX");
            Source.ItemsSource = rosters;
            Destination.ItemsSource = rosters;

                }

        private void MOV(object sender, RoutedEventArgs e)
        {
            TextBox SelectedSource = null;
            TextBox SelectedDestination = null;
            switch(Source.SelectedItem)
            {
                case "DX":
                    SelectedSource = DX;
                    break;          
                case "CX":
                    SelectedSource = CX;
                    break;               
                case "BX":
                    SelectedSource = BX;
                    break;              
                case "AX":
                    SelectedSource = AX;
                    break;

            }
            switch(Destination.SelectedItem)
            {
                case "DX":
                    SelectedDestination = DX;
                    break;          
                case "CX":
                    SelectedDestination = CX;
                    break;               
                case "BX":
                    SelectedDestination = BX;
                    break;              
                case "AX":
                    SelectedDestination = AX;
                    break;

            }
            if(SelectedSource!=null && SelectedDestination!=null && SelectedSource!= SelectedDestination)
            {
                SelectedDestination.Text = SelectedSource.Text;
                     Console.Text += "\n Moving Complete.";
            }
            else
            {
                Console.Text += "\nThere was an Error. Moving Incompleate.";
            }
        }
    }
}
