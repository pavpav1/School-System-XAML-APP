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

namespace ProjekatOOP
{
    /// <summary>
    /// Interaction logic for DodajPredmetProzor.xaml
    /// </summary>
    public partial class DodajPredmetProzor : Window
    {
        public Predmet Predmet { get; private set; }

        public DodajPredmetProzor()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            var naziv = txtNaziv.Text;  
            if (!string.IsNullOrEmpty(naziv))
            {
                Predmet = new Predmet(naziv);
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Popunite sva polja.");
            }
        }
    }
}
