using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WpfApp2.Commands;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public string SomeText
        {
            get { return (string)GetValue(SomeTextProperty); }
            set { SetValue(SomeTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SomeText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SomeTextProperty =
            DependencyProperty.Register("SomeText", typeof(string), typeof(MainWindow));

        public MessageCommand DisplayCommand { get; set; }
        public SendCommand SendCommand { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            SomeText = "Salam";

            DisplayCommand = new MessageCommand(Display);

            SendCommand = new SendCommand(() =>
              {
                  MessageBox.Show("You clicked to Send Button");
              });
            this.DataContext = this;
        }

        private void Display()
        {
            MessageBox.Show("We are displaying");
        }



        //private void Help_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        //{
        //    try
        //    {

        //    if (SomeText.Length < 10)
        //    {
        //        e.CanExecute = false;
        //    }
        //    else
        //    {
        //        e.CanExecute = true;
        //    }
        //    }catch 
        //    {

        //    }
        //}

        //private void Help_Executed(object sender, ExecutedRoutedEventArgs e)
        //{
        //    Process.Start("calc.exe");
        //}
    }
}
