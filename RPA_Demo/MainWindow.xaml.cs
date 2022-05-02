using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RPA_Demo.View;
namespace RPA_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static MainWindow _obj;
        public static MainWindow Instance
        {
            get { return _obj ?? (_obj = new MainWindow()); }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value;  }
        }

        public Button nextBtn
        {
            get { return btnNext; }
            set { btnNext = value; }
        }

        private void mainUC_load(object sender, EventArgs e)
        {
            btnNext.Visible = false;
            _obj = this;

            MainView uc = new MainView();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        public MainWindow()
        {
            InitializeComponent();
            load_UserControl();
            //Main.MouseUp += new MouseButtonEventHandler(OnNext);
        }

        //private void OnNext(object sender, MouseButtonEventArgs e)
        //{

        //}
        private void load_UserControl()
        {
            MainView mainCtrl = new MainView();
            Canceled cancelCtrl = new Canceled();
            loadView.Children.Add(mainCtrl);
            loadView.Children.Add(cancelCtrl);
        }
    }
}
