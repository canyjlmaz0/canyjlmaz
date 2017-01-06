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
using System.Data;
using MySql.Data.MySqlClient;

namespace deneme.Pages
{
    /// <summary>
    /// Interaction logic for kirala.xaml
    /// </summary>
    public partial class kirala : UserControl
    {
        public kirala()
        {
            InitializeComponent();
            MySqlConnection bag = new MySqlConnection("Server = localhost; Database = galari; Uid = root; Pwd=;");

            bag.Open();
            MySqlCommand ekle = new MySqlCommand("update galari set gün='"+txtgün.Text+"' , m_ad='"+txtad.Text+ "', m_soyad='"+txtsoyad.Text+ "', m_adres ='" + txtadres.Text + "' , m_no='" + txtno.Text + "',m_tc='" + txttc.Text + "' " ,bag);
            ekle.ExecuteNonQuery();
            ekle.Dispose();
            bag.Close();

        }
    }
}
