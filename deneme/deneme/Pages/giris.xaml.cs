using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace deneme.Pages
{
    /// <summary>
    /// Interaction logic for giris.xaml
    /// </summary>
    public partial class giris : UserControl
    {
      static  string baglanti = "Server=localhost;Port=3306;Database=test;Uid=root;Pwd=;Convert Zero Datetime=True;Allow Zero Datetime=True;";

        MySqlConnection bag = new MySqlConnection(baglanti);

        public giris()
        {
            InitializeComponent();
            deneme.Items.Add("bmw");
            deneme.Items.Add("audi");
            deneme.Items.Add("honda");
            deneme.Items.Add("mercedes");
            deneme.Items.Add("nissan");
            deneme.Items.Add("tofaş");

        }
        private void deneme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                MySqlCommand goster = new MySqlCommand("Select id,marka,model,renk,yil,fiyat,satimtarih,teslimtarih,gün,m_ad,m_soyad,m_adres,m_no,m_tc from galari where marka='" + deneme.SelectedItem + "'", bag);
                MySqlDataAdapter ad = new MySqlDataAdapter(goster);
                DataTable ta = new DataTable();
                ad.Fill(ta);
                datagrid.ItemsSource = ta.AsDataView();
            }
            catch {
                MySqlCommand goster = new MySqlCommand("Select id,marka,model,renk,yil,fiyat,gün,m_ad,m_soyad,m_adres,m_no,m_tc from galari where marka='" + deneme.SelectedItem + "'", bag);
                MySqlDataAdapter ad = new MySqlDataAdapter(goster);
                DataTable ta = new DataTable();
                ad.Fill(ta);
                datagrid.ItemsSource = ta.AsDataView();
            }
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FirstFloor.ModernUI.Presentation.LinkGroup menuler = new FirstFloor.ModernUI.Presentation.LinkGroup();

            FirstFloor.ModernUI.Presentation.Link kirala = new FirstFloor.ModernUI.Presentation.Link();
            kirala.DisplayName = "KİRALA";
            kirala.Source = new Uri("Pages/kirala.xaml", UriKind.Relative);
            menuler.Links.Add(kirala);

            FirstFloor.ModernUI.Presentation.Link ekle = new FirstFloor.ModernUI.Presentation.Link();
            ekle.DisplayName = " ARAÇ EKLE";
            ekle.Source = new Uri("Pages/ekle.xaml", UriKind.Relative);
            menuler.Links.Add(ekle);

            FirstFloor.ModernUI.Presentation.Link sil = new FirstFloor.ModernUI.Presentation.Link();
            sil.DisplayName = " ARAÇ SİL";
            sil.Source = new Uri("Pages/sil.xaml", UriKind.Relative);
            menuler.Links.Add(sil);

            MainWindow ab = Application.Current.MainWindow as MainWindow;
            ab.MenuLinkGroups.Clear();
            ab.MenuLinkGroups.Add(menuler);
        }

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}

