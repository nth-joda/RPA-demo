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

namespace RPA_Demo.View
{
    /// <summary>
    /// Interaction logic for CheckingZero.xaml
    /// </summary>
    public partial class CheckingZero : UserControl
    {
        public CheckingZero()
        {
            InitializeComponent();
            CheckingZeros.MouseUp += new MouseButtonEventHandler(OnConfirm);
        }
        private void OnConfirm(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("User clicks button Confirm, at " + e.GetPosition(this).ToString());
        }
    }
}
