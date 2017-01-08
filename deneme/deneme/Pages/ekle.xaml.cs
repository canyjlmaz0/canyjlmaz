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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace deneme.Pages
{
    /// <summary>
    /// Interaction logic for ekle.xaml
    /// </summary>
    public partial class ekle : UserControl
    {

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Port=3306;Database=test;Uid=root;Pwd=;Convert Zero Datetime=True;Allow Zero Datetime=True;");
        public ekle()
        {
            InitializeComponent();         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            baglanti.Open();
            MySqlCommand kirala = new MySqlCommand("INSERT INTO galari(marka,model,renk,yil,fiyat) values('"+txteklemarka.Text+"','"+txteklemodel.Text+"','"+txteklerenk.Text+"',"+txtekleyil.Text+","+txteklefiyat.Text+")",baglanti);
            kirala.ExecuteNonQuery();
            kirala.Dispose();
            baglanti.Close();
            MessageBox.Show("araç ekleme yapıldı");
        }
    }
}
