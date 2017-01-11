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
using MySql.Data.MySqlClient;
using System.Configuration;

namespace deneme.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl 

    {

       

        string baglanti = "Server=localhost;Port=3306;Database=test;Uid=root;Pwd=;Convert Zero Datetime=True;Allow Zero Datetime=True;";
        
       
        public Home()
        {            InitializeComponent();

            Random rnd = new Random();
           int randomsayi= rnd.Next(999, 9999);
            txtrand.Text = randomsayi.ToString();

            
        }
         giris a = new giris();
        private void button_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection bag = new MySqlConnection(baglanti);
            MySqlConnection bag2 = new MySqlConnection(baglanti);
            bag.Open();
            bag2.Open();

            MySqlCommand girisyap = new MySqlCommand("Select * from kullanicilar where ad='" + kad.Text + "' and sifre = '" + sifre.Password.ToString() + "'", bag);
            MySqlDataReader reader = girisyap.ExecuteReader();
            MySqlCommand giris = new MySqlCommand("INSERT INTO kullanicilar(ad) values('" + kad.Text + "')", bag2);
            giris.ExecuteNonQuery();
            giris.Dispose();
            bag2.Close();

            if (kad.Text == "can" && sifre.Password == "123" && txtrand.Text==txtkod.Text )
            {
                // giriş sayfasından digerine gönderme  
                FirstFloor.ModernUI.Presentation.LinkGroup menuler = new FirstFloor.ModernUI.Presentation.LinkGroup();
                FirstFloor.ModernUI.Presentation.Link menuekle = new FirstFloor.ModernUI.Presentation.Link();
                menuekle.DisplayName = "ARAÇ KİRALA";
                menuekle.Source = new Uri("Pages/giris.xaml", UriKind.Relative);
                menuler.Links.Add(menuekle);


                FirstFloor.ModernUI.Presentation.Link ekle = new FirstFloor.ModernUI.Presentation.Link();
                ekle.DisplayName = " ARAÇ EKLE";
                ekle.Source = new Uri("Pages/ekle.xaml", UriKind.Relative);
                menuler.Links.Add(ekle);

                FirstFloor.ModernUI.Presentation.Link sil = new FirstFloor.ModernUI.Presentation.Link();
                sil.DisplayName = " ARAÇ SİL";
                sil.Source = new Uri("Pages/sil.xaml", UriKind.Relative);
                menuler.Links.Add(sil);

                FirstFloor.ModernUI.Presentation.Link deneme = new FirstFloor.ModernUI.Presentation.Link();
                deneme.DisplayName = " ARACI TESLİM AL";
                deneme.Source = new Uri("Pages/teslimal.xaml", UriKind.Relative);
                menuler.Links.Add(deneme);



                MainWindow ab = Application.Current.MainWindow as MainWindow;
                ab.MenuLinkGroups.Clear();
                ab.MenuLinkGroups.Add(menuler);
                bag.Close();
                //--------------------------------------
            }
            else {
                MessageBox.Show("kullanıcı adı , şifre  veya güvenlik kodu yanlış tekrar deneyin" , "HATA" );
                txtkod.Text = "";
                kad.Text = "";
                sifre.Password = "";
                Random rnd = new Random();
                int randomsayi = rnd.Next(999, 9999);
                txtrand.Text = randomsayi.ToString();
            }
        }
    }
}
