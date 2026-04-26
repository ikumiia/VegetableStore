using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;
using VegetableStore.Context;

namespace VegetableStore.Views
{
    public partial class MainWindow : Window
    {
   

        public void BtnClick(object sender, RoutedEventArgs e)
        {
    
            var email = this.FindControl<TextBox>("EmailBox");
            var pass = this.FindControl<TextBox>("PassBox");
            var list = this.FindControl<ListBox>("ResultList");
            var error = this.FindControl<TextBlock>("ErrorText");

            using (var db = new MyDbContext())
            {
                var user = db.Accounts.FirstOrDefault(a => a.Email == email.Text && a.Password == pass.Text);

                if (user != null)
                {
                    error.Text = "Доступ разрешен!";
   
                    var prods = db.Products.ToList();
                    list.ItemsSource = prods.Select(p => $"{p.Name} - {p.Price} руб.");
                }
                else
                {
                    error.Text = "Неверный логин или пароль!";
                }
            }
        }
    }
}
