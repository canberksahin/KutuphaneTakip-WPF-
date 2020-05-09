using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace KutuphaneTakip.uControls
{
    /// <summary>
    /// Interaction logic for KitapListesi.xaml
    /// </summary>
    public partial class KitapListesi : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=KutuphaneDb;Integrated Security=True");
        public KitapListesi()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("select KitapAdi,YazarAdiID,KitapTuru,EmanetDurumu from tbl_KitapListesi", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKitapListesi.ItemsSource = dt.DefaultView;
            con.Close();
        }
        MainWindow mw = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

        private void btnKitapEKle_Click(object sender, RoutedEventArgs e)
        {
            WinKitapEkle frm = new WinKitapEkle();
            frm.Owner = mw;
            mw.Opacity = 0.9;
            frm.ShowDialog();
        }
    }
}
