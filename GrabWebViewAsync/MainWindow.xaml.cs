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

namespace GrabWebViewAsync
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //System.Threading.Timer timer = new System.Threading.Timer(LoadWeb, null, 1000, 10000000);
            
        }

        public async void LoadWeb(object obj)
        {
            
          await  Task.Run(() => {

                for (var x = 0; x < 5000; x++)
                {
                    Debug.Write(x);
                }                
            }); 

         await   Dispatcher.BeginInvoke(new Action(UpdateWebView));

            web1.Navigate("http://yahoo.com");
        }

        private void UpdateWebView()
        {
            web1.NavigateToString(@"<h1>HELLO</h1>");
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadWeb(null);
        }
    }
}
