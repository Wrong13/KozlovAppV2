using KozlovAppV2.Models;
using KozlovAppV2.Views;
using Microsoft.EntityFrameworkCore;
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

namespace KozlovAppV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User13Context db;
        public MainWindow()
        {
            InitializeComponent();
            db = new User13Context();
            db.Users.Load();
            db.Roles.Load();
            db.Roles.Local.ToBindingList();
        }

        private async void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            var AuthUser = await db.Users.Where(x => x.UserPassword == PassBox.Password)
                .Where(x => x.UserLogin == LogBox.Text).FirstOrDefaultAsync();
            if (AuthUser != null)
            {
                ProductList productList = new ProductList(AuthUser.UserSurname + " " + AuthUser.UserName + " " + AuthUser.UserPatronymic,AuthUser.UserRoleNavigation.RoleName);
                productList.Show();
                this.Close();
            }
            else
            {
                DangerBlock.Text = "Неверные данные";
            }
        }
    }
}
