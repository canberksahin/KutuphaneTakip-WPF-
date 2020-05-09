using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace KutuphaneTakip
{
    /// <summary>
    /// Interaction logic for SatisfactionForm.xaml
    /// </summary>
    public partial class SatisfactionForm : Window
    {
        public SatisfactionForm()
        {
            InitializeComponent();
        }

        private void btnSatisfactionKapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnBir_Click(object sender, RoutedEventArgs e)
        {
            Satisfaction4 frm = new Satisfaction4();
            frm.Show();
            Close();
        }

        private void btnIki_Click(object sender, RoutedEventArgs e)
        {
            Satisfaction4 frm = new Satisfaction4();
            frm.Show();
            Close();
        }

        private void btnUc_Click(object sender, RoutedEventArgs e)
        {
            Satisfaction4 frm = new Satisfaction4();
            frm.Show();
            Close();
        }

        private void btnDört_Click(object sender, RoutedEventArgs e)
        {
            Satisfaction4 frm = new Satisfaction4();
            frm.Show();
            Close();
        }

    }
}
