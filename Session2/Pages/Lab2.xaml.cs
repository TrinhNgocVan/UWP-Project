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
using Session2.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Session2.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Lab2 : Page
    {
        public Lab2()
        {
            this.InitializeComponent();
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            SV.IsPaneOpen = !SV.IsPaneOpen;
        }
        private void ListEmail_Loaded(object sender, RoutedEventArgs e)
        {
            Email email = new Email("sainteric1993hd@gmail", "tang luong", "khong tang luong thi nghi viec");

            ListEmail.Items.Add(email);
        }
        private void submit_Click(object sender, RoutedEventArgs e)
        {
            Email email = new Email(recievedEmailInput.Text ,TitleInput.Text, ContextInput.Text);

            ListEmail.Items.Add(email);
        }
    }
}
