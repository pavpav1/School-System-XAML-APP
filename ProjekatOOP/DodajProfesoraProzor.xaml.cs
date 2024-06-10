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
    /// Interaction logic for DodajProfesoraProzor.xaml
    /// </summary>
    public partial class DodajProfesoraProzor : Window
    {   
        public Profesor Profesor { get; private set; } 

        public DodajProfesoraProzor()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            var ime = txtIme.Text;
            var prezime = txtPrezime.Text;
            int godine = int.Parse(txtGodine.Text);
            if (!string.IsNullOrEmpty(ime) && !string.IsNullOrEmpty(prezime))
            {
                Profesor = new Profesor(ime, prezime, godine);
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Popunite sva polja.");
            }
        } 
    }
}
