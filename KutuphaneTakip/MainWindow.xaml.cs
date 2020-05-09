using Data;
using KutuphaneTakip.Classes;
using KutuphaneTakip.uControls;
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

namespace KutuphaneTakip
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
            MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void btnKapat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void brdSagust_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ucCagir.uc_Cagir(contentIcerik, new KitapListesi());
        }

        private void btnSimgeDurumu_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnTamEkran_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnHamburgerMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (lblMenu1.Visibility == Visibility.Hidden)
            {
                GridLength grd1 = new GridLength(220, GridUnitType.Pixel);
                grdColumnMenu.Width = grd1;

                lblMenu1.Visibility = Visibility.Visible;
                lblMenu2.Visibility = Visibility.Visible;
                lblMenu3.Visibility = Visibility.Visible;
                lblMenu4.Visibility = Visibility.Visible;
                lblMenu5.Visibility = Visibility.Visible;
                lblMenu6.Visibility = Visibility.Visible;
                lblLogoyazi.Width = 176;
                btnHamburgerMenu.Width = 100;
                altLbl.Visibility = Visibility.Visible;
                altPencereResim.Visibility = Visibility.Visible;
                Lblalt.Visibility = Visibility.Visible;
            }
            else
            {

                GridLength grd = new GridLength(125, GridUnitType.Pixel);
                grdColumnMenu.Width = grd;

                lblMenu1.Visibility = Visibility.Hidden;
                lblMenu2.Visibility = Visibility.Hidden;
                lblMenu3.Visibility = Visibility.Hidden;
                lblMenu4.Visibility = Visibility.Hidden;
                lblMenu5.Visibility = Visibility.Hidden;
                lblMenu6.Visibility = Visibility.Hidden;
                lblLogoyazi.Width = 0;
                btnHamburgerMenu.Width = 60;
                altLbl.Visibility = Visibility.Hidden;
                altPencereResim.Visibility = Visibility.Hidden;
                Lblalt.Visibility = Visibility.Hidden;
            }
        }

        #region Menü Butonları Click
        int secilen;
        private void btnKitapListesi_Click(object sender, RoutedEventArgs e)
        {
            ucCagir.uc_Cagir(contentIcerik, new KitapListesi());
            secilen = 1;
            Secilen();
        }

        private void btnHakkında_Click(object sender, RoutedEventArgs e)
        {
            secilen = 6;
            Secilen();
        }

        private void btnAyarlar_Click(object sender, RoutedEventArgs e)
        {
            secilen = 5;
            Secilen();
        }

        private void btnZamanıDolanlar_Click(object sender, RoutedEventArgs e)
        {
            secilen = 4;
            Secilen();
        }

        private void btnEmanetListesi_Click(object sender, RoutedEventArgs e)
        {
            secilen = 3;
            Secilen();
        }

        private void btnOkuyucuListesi_Click(object sender, RoutedEventArgs e)
        {
            secilen = 2;
            Secilen();
        }
        #endregion

        void Secilen()
        {
            if (secilen == 1)
                btnKitapListesi.IsChecked = true;
            else
                btnKitapListesi.IsChecked = false;
            if (secilen == 2)
                btnOkuyucuListesi.IsChecked = true;
            else
                btnOkuyucuListesi.IsChecked = false;
            if (secilen == 3)
                btnEmanetListesi.IsChecked = true;
            else
                btnEmanetListesi.IsChecked = false;
            if (secilen == 4)
                btnZamanıDolanlar.IsChecked = true;
            else
                btnZamanıDolanlar.IsChecked = false;
            if (secilen == 5)
                btnAyarlar.IsChecked = true;
            else
                btnAyarlar.IsChecked = false;
            if (secilen == 6)
                btnHakkında.IsChecked = true;
            else
                btnHakkında.IsChecked = false;

        }


        private void btnSatisfactionForm_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnSatisfactionForm_MouseDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mw = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            SatisfactionForm frm = new SatisfactionForm();
            frm.Owner = mw;
            frm.ShowDialog();

        }
    }
}
