using System;
using System.IO;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string ProfesoriFile = @"C:\Users\Work\source\repos\ProjekatOOP\Profesori.txt";
        private const string UceniciFile = @"C:\Users\Work\source\repos\ProjekatOOP\Ucenici.txt";
        private const string PredmetiFile = @"C:\Users\Work\source\repos\ProjekatOOP\Predmeti.txt";
        private const string OceneFile = @"C:\Users\Work\source\repos\ProjekatOOP\Ocene.txt";

        private List<Profesor> profesori = new List<Profesor>();
        private List<Predmet> predmeti = new List<Predmet>();
        private List<Ucenik> ucenici = new List<Ucenik>();
        private List<Ocena> ocene = new List<Ocena>();  
        private bool prikazProfesora = true;
        private bool prikazUcenika = false;
        private bool prikazPredmeta = false;
        private bool prikazDnevnika = false; 
        public MainWindow()
        {
            InitializeComponent();
            //UcitajPodatke();
            PrikaziProfesore();
        }
        private void UcitajPodatke()
        { 
            if (File.Exists(ProfesoriFile))
            {
                var lines = File.ReadAllLines(ProfesoriFile);
                profesori = lines.Select(line =>
                {
                    var parts = line.Split(',');
                    return new Profesor(parts[0], parts[1], int.Parse(parts[2]));
                }).ToList();
            } 
            if (File.Exists(UceniciFile))
            {
                var lines = File.ReadAllLines(UceniciFile);
                ucenici = lines.Select(line =>
                {
                    var parts = line.Split(',');
                    return new Ucenik(parts[0], parts[1]);
                }).ToList();
            }
            if (File.Exists(PredmetiFile))
            {
                var lines = File.ReadAllLines(PredmetiFile);
                predmeti = lines.Select(line =>
                {
                    var parts = line.Split(',');
                    return new Predmet(parts[0]);
                }).ToList();
            }
            if (File.Exists(OceneFile))
            {
                var lines = File.ReadAllLines(OceneFile);
                ocene = lines.Select(line =>
                {
                    var parts = line.Split(',');
                    return new Ocena(int.Parse(parts[0]), parts[1], parts[2], parts[3]);
                }).ToList();
            }
        } 
        /*private void SnimiPodatke()
        {
            // Snimi knjige
            var knjigeLines = knjige.Select(k => $"{k.Naziv},{k.Autor},{k.Datum:yyyy-MM-dd HH:mm:ss}");
            File.WriteAllLines(KnjigeFile, knjigeLines);

            // Snimi autore
            var autoriLines = autori.Select(a => $"{a.Ime},{a.Prezime}");
            File.WriteAllLines(AutoriFile, autoriLines);
        }*/
        private void PrikaziProfesore()
        {
            dataGridCentralni.ItemsSource = null;
            dataGridCentralni.ItemsSource = profesori;
            prikazProfesora = true;
            prikazPredmeta = false;
            prikazUcenika = false; 
            prikazDnevnika = false;
        }
        private void btnPrikaziProfesore_Click(object sender, RoutedEventArgs e)
        {
            PrikaziProfesore();
        }
        private void PrikaziPredmete()
        {
            dataGridCentralni.ItemsSource = null;
            dataGridCentralni.ItemsSource = predmeti;
            prikazProfesora = false;
            prikazPredmeta = true;
            prikazUcenika = false; 
            prikazDnevnika = false;
        }
        private void btnPrikaziPredmete_Click(object sender, RoutedEventArgs e)
        {
            PrikaziPredmete();
        }
        private void PrikaziUcenike()
        {
            dataGridCentralni.ItemsSource = null;
            dataGridCentralni.ItemsSource = ucenici;
            prikazProfesora = false;
            prikazPredmeta = false;
            prikazUcenika = true; 
            prikazDnevnika = false;
        }
        private void btnPrikaziUcenike_Click(object sender, RoutedEventArgs e)
        {
            PrikaziUcenike();
        }
        private void PrikaziDnevnik()
        {
            dataGridCentralni.ItemsSource = null;
            dataGridCentralni.ItemsSource = ocene;
            prikazProfesora = false;
            prikazPredmeta = false;
            prikazUcenika = false;
            prikazDnevnika = true;
        }
        private void btnPrikaziDnevnik_Click(object sender, RoutedEventArgs e)
        {
            PrikaziDnevnik();
        }
        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            if (prikazProfesora)
            {
                DodajProfesora(); 
            }  
            else if (prikazPredmeta)
            {
                DodajPredmet();
            }
            else if (prikazUcenika)
            {
                DodajUcenika();
            }
            else if(prikazDnevnika)
            {
                DodajOcenu();
            }
        }
        private void DodajProfesora()
        {
            var prozor = new DodajProfesoraProzor();
            if (prozor.ShowDialog() == true)
            {
                profesori.Add(prozor.Profesor);
                //SnimiPodatke();
                PrikaziProfesore();
            }
        }
        private void DodajPredmet()
        {
            var prozor = new DodajPredmetProzor();
            if (prozor.ShowDialog() == true)
            {
                predmeti.Add(prozor.Predmet);
                //SnimiPodatke();
                PrikaziPredmete();
            }
        }
        private void DodajUcenika()
        {
            var prozor = new DodajUcenikaProzor();
            if (prozor.ShowDialog() == true)
            {
                ucenici.Add(prozor.Ucenik);
                //SnimiPodatke();
                PrikaziUcenike();
            }
        }
        private void DodajOcenu()
        {
            var prozor = new DodajOcenuProzor();
            if (prozor.ShowDialog() == true)
            {
                ocene.Add(prozor.Ocena);
                //SnimiPodatke();
                PrikaziDnevnik();
            }
        }
    }
}
