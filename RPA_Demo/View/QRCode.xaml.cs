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
    /// Interaction logic for QRCode.xaml
    /// </summary>
    public partial class QRCode : UserControl
    {
        public QRCode()
        {
            InitializeComponent();
            QR.MouseUp += new MouseButtonEventHandler(OnConfirm);
            QR.MouseUp += new MouseButtonEventHandler(OnResend);

        }

        private void OnConfirm(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("User clicks button Confirm, at " + e.GetPosition(this).ToString());
        }

        private void OnResend(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("User clicks button resend, at " + e.GetPosition(this).ToString());
        }
    }
}
