using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        static int i =0;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void input2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            i += 1;
            string email = input1.Text;
            string title = input2.Text;
            string content = input5.Text;
            TxtBlock.Text += "Sented Email : \n";
            TxtBlock.Text += "-"+i+"  email : "+email+"\nTitle :"+title+"\nContent : "+content;
        }
    }
}
