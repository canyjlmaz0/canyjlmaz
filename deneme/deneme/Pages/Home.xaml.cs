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
using System.Drawing;
using System.Data;


namespace deneme.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        
        public Home()
        {
            InitializeComponent();
        }
        giris a = new giris();
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (kad.Text == "can" && sifre.Text == "123")
            {
                // giriş sayfasından digerine gönderme  
                FirstFloor.ModernUI.Presentation.LinkGroup menuler = new FirstFloor.ModernUI.Presentation.LinkGroup();
                FirstFloor.ModernUI.Presentation.Link menuekle = new FirstFloor.ModernUI.Presentation.Link();
                menuekle.DisplayName = "araç seç";
                menuekle.Source = new Uri("Pages/giris.xaml", UriKind.Relative);
                menuler.Links.Add(menuekle);
                MainWindow ab = Application.Current.MainWindow as MainWindow;
                ab.MenuLinkGroups.Clear();
                ab.MenuLinkGroups.Add(menuler);
                //--------------------------------------
            }
            else {
                MessageBox.Show("kullanıcı adı şifresi hatalı");
            }
        }
    }
}
