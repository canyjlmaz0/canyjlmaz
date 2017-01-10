using MySql.Data.MySqlClient;
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

namespace deneme.Pages
{
    /// <summary>
    /// Interaction logic for teslimal.xaml
    /// </summary>
    public partial class teslimal : UserControl
    {
                MySqlConnection baglanti = new MySqlConnection("Server=localhost;Port=3306;Database=test;Uid=root;Pwd=;Convert Zero Datetime=True;Allow Zero Datetime=True;");

        public teslimal()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int sayi = 0;
            string bos = "";
            try
            {
                baglanti.Open();
                MySqlCommand kirala = new MySqlCommand("UPDATE galari set  satimtarih='" + sayi + "', teslimtarih='" + sayi + "',gün=" + sayi + ",m_ad='" + bos.ToString() + "',m_soyad='" + bos.ToString()  +"', m_adres = '" + bos.ToString() + "'  , m_no=" + sayi + " , m_tc=" + sayi + "  where id=" + txtteslim.Text + "", baglanti);
                kirala.ExecuteNonQuery();
                kirala.Dispose();
                baglanti.Close();
                MessageBox.Show("araç teslim alma başarıyla yapıldı");
            }
            catch
            {
                MessageBox.Show(txtteslim.Text+" id li araba olmadığından teslim alınamadı");
            }
        }
    }
}
