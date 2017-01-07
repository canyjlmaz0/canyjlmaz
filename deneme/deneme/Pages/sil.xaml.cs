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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace deneme.Pages
{
    /// <summary>
    /// Interaction logic for sil.xaml
    /// </summary>
    public partial class sil : UserControl
    {
        MySqlConnection bagekle = new MySqlConnection("Server = localhost; DataSoruce=galari.sql; Database = galari; Uid = root; Pwd=;");
        public sil()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            bagekle.Open();
            MySqlCommand sil = new MySqlCommand("delete from galari where id='" + txtsil.Text + "'", bagekle);
            MySqlDataAdapter adabtor2 = new MySqlDataAdapter(sil);
            sil.ExecuteNonQuery();
            sil.Dispose();
            bagekle.Close();
            
        }
    }
}
