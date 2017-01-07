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
        
        MySqlConnection bagekle = new MySqlConnection("Server = localhost; Database = galari; Uid = root; Pwd=;");
        public ekle()
        {
            InitializeComponent();         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bagekle.Open();
            MySqlCommand ekle = new MySqlCommand("INSERT INTO galari(marka,model,renk,yil,fiyat) VALUES ('" + txteklemarka.Text + "','" + txteklemodel.Text + "','" + txteklerenk.Text + "','" + txtekleyil.Text + "','" + txteklefiyat.Text + "')",bagekle );
            ekle.ExecuteNonQuery();
            ekle.Dispose();
            bagekle.Close();
        }
    }
}
