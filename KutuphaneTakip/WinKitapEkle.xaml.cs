using KutuphaneTakip.Classes;
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
using System.Windows.Shapes;

namespace KutuphaneTakip
{
    /// <summary>
    /// Interaction logic for WinKitapEkle.xaml
    /// </summary>
    public partial class WinKitapEkle : Window
    {
        public WinKitapEkle()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text,e.Text.Length-1))
            {
                e.Handled = true;
            }
        }

        private void txtSayfaSayisi_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void txtStokAdedi_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void btnKitapEkleKapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mw = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            mw.Opacity = 1;
        }

        private void btnKitapEkleBilgi_Click(object sender, RoutedEventArgs e)
        {
            Bonus.PopUpShow(popupBilgi); 
        }
    }
}
