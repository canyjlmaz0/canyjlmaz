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
    /// Interaction logic for giris.xaml
    /// </summary>
    public partial class giris : UserControl
    {
        public giris()
        {
            InitializeComponent();
            deneme.Items.Add("bmw");
            deneme.Items.Add("audi");
            deneme.Items.Add("honda");
            deneme.Items.Add("mercedes");
        }

        private void deneme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         

        }
    }
}
