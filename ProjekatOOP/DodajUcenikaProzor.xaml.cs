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
    /// Interaction logic for DodajUcenikaProzor.xaml
    /// </summary>
    public partial class DodajUcenikaProzor : Window
    {
        public Ucenik Ucenik { get; private set; }

        public DodajUcenikaProzor()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            var ime = txtIme.Text;
            var prezime = txtPrezime.Text;
            if (!string.IsNullOrEmpty(ime) && !string.IsNullOrEmpty(prezime))
            {
                Ucenik = new Ucenik(ime, prezime);
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Popunite sva polja.");
            }
        }
    }
}
