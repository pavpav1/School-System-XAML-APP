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

namespace ProjekatOOP
{
    /// <summary>
    /// Interaction logic for DodajOcenuProzor.xaml
    /// </summary>
    public partial class DodajOcenuProzor : Window
    {
        public Ocena Ocena { get; private set; }
        public DodajOcenuProzor()
        {
            InitializeComponent();
        }
        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            string predmet = (string)cmbPredmet.SelectedItem;
            var ocena = int.Parse(txtOcena.Text);
            var odeljenje = (string)cmbOdeljenje.SelectedItem;
            string ucenik = (string)cmbUcenik.SelectedItem;
            string profesor = (string)cmbProfesor.SelectedItem; 
            if (ocena >= 1 && ocena <= 5)
            {
                if (predmet != null && !string.IsNullOrEmpty(odeljenje) && ucenik != null && profesor != null)
                {
                    Ocena = new Ocena(ocena, ucenik, predmet, profesor);
                    DialogResult = true;
                }
                else
                {
                    MessageBox.Show("Popunite sva polja.");
                }
            }
            else
            {
                MessageBox.Show("Ocena mora biti izmedju 1 i 5");
            }
        }
    }
}
