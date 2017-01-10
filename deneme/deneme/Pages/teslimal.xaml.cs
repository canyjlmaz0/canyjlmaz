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
            try
            {
                baglanti.Open();
                MySqlCommand kirala = new MySqlCommand("UPDATE galari set  satimtarih='" + txtsatimtarih.Text + "', teslimtarih='" + txtteslimtarih.Text + "',gün=" + txtgün.Text + ",m_ad='" + txtad.Text + "',m_soyad='" + txtsoyad.Text + "',m_adres='" + txtadres.Text + "'  , m_no=" + txtno.Text + " , m_tc=" + txttc.Text + "  where id=" + txtserino.Text + "", baglanti);
                kirala.ExecuteNonQuery();
                kirala.Dispose();
                baglanti.Close();
                MessageBox.Show("kiralama yapıldı");
            }
            catch
            {
                MessageBox.Show("lütfen gerkeli yerleri doldurunuz.");
            }
        }
    }
}
