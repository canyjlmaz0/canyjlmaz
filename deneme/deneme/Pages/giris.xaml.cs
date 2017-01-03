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
    }
}
