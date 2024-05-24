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

namespace test8.Pages
{
    /// <summary>
    /// Логика взаимодействия для ZapisNaYslygy.xaml
    /// </summary>
    public partial class ZapisNaYslygy : Page
    {
        public ZapisNaYslygy()
        {
            InitializeComponent();
        }

        private void vihod_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new StartPage());
        }
    }
}
