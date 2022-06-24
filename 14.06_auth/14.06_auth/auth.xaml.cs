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

namespace _14._06_auth
{
    /// <summary>
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Page
    {
        public auth()
        {
            InitializeComponent();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox.IsChecked.Value)
            {
                visible_pass.Text = password_.Password;
                password_.Visibility = Visibility.Hidden;
                visible_pass.Visibility = Visibility.Visible;

            }
            else
            {
                password_.Password = visible_pass.Text;
                visible_pass.Visibility = Visibility.Hidden;
                password_.Visibility = Visibility.Visible;
            }


        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string actual_login = login.Text;
            string actual_password_1 = password_.Password;
            string actual_password_2 = visible_pass.Text;
            this.NavigationService.Navigate(new User());


            switch (actual_login)
            {
                case "Admin":
                    {
                        if (actual_password_1 == "admin" || actual_password_2 == "admin")

                            this.NavigationService.Navigate(new Admin());
                        break;
                    }
                case "User":
                    {
                        if (actual_password_1 == "user" || actual_password_2 == "user")
                            this.NavigationService.Navigate(new User());
                        break;
                    }
            }
        }
    }
}
