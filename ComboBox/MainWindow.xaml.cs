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

namespace ComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            comboBoxColors.ItemsSource = typeof(Colors).GetProperties();
           



        }

        private void comboBoxColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            {
               
                  
                    BrushConverter conv = new BrushConverter();
                    SolidColorBrush? brush = conv.ConvertFromString(comboBoxColors.SelectedItem.ToString().Substring(27)) as SolidColorBrush;
                    StackOne.Background = brush; //change the stack background to the chosen color
                    hexArea.Background = brush;
                    hexArea.Text = brush.ToString(); //Show the hexadecimal of the chosen color



            }
 
        }

  
    }
}
