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
    /// Interaction logic for CheckSuccessful.xaml
    /// </summary>
    public partial class CheckSuccessful : UserControl
    {
        public CheckSuccessful()
        {
            InitializeComponent();
            CheckSuccess.MouseUp += new MouseButtonEventHandler(OnConfirm);
            CheckSuccess.MouseUp += new MouseButtonEventHandler(OnCancel);

        }
        private void OnConfirm(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("User clicks button Confirm, at " + e.GetPosition(this).ToString());
        }

        private void OnCancel(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("User clicks button Cancel, at " + e.GetPosition(this).ToString());
        }
    }
}
