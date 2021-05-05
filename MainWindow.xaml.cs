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

namespace ProjektBiblioteka
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ZarzadzanieKsiazki ksiazki = new ZarzadzanieKsiazki();
        ZarzadzanieCzytelnik czytelnicy = new ZarzadzanieCzytelnik();


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void NowaKsiazkaClick(object sender, RoutedEventArgs e)
        {
            NowaKsiazka.Visibility = Visibility.Visible;
            ListaKsiazek.Visibility = Visibility.Hidden;
            WypozyczKsiazke.Visibility = Visibility.Hidden;
            OddajKsiazke.Visibility = Visibility.Hidden;
            NowyCzytelnik.Visibility = Visibility.Hidden;
            ZnajdzCzytelnika.Visibility = Visibility.Hidden;
            ListaCzytelnikow.Visibility = Visibility.Hidden;
           
        }

        private void WypozyczKsiazkeClick(object sender, RoutedEventArgs e)
        {
            NowaKsiazka.Visibility = Visibility.Hidden;
            ListaKsiazek.Visibility = Visibility.Hidden;
            WypozyczKsiazke.Visibility = Visibility.Visible;
            OddajKsiazke.Visibility = Visibility.Hidden;
            NowyCzytelnik.Visibility = Visibility.Hidden;
            ZnajdzCzytelnika.Visibility = Visibility.Hidden;
            ListaCzytelnikow.Visibility = Visibility.Hidden;
        }

        private void WyszukajKsiazkeClick(object sender, RoutedEventArgs e)
        {
            NowaKsiazka.Visibility = Visibility.Hidden;
            ListaKsiazek.Visibility = Visibility.Visible;
            WypozyczKsiazke.Visibility = Visibility.Hidden;
            OddajKsiazke.Visibility = Visibility.Hidden;
            NowyCzytelnik.Visibility = Visibility.Hidden;
            ZnajdzCzytelnika.Visibility = Visibility.Hidden;
            ListaCzytelnikow.Visibility = Visibility.Hidden;
            list_view.Items.Refresh();
            list_view.ItemsSource = ksiazki.pozycje;
            
        }

        private void OddajKsiazkeClick(object sender, RoutedEventArgs e)
        {
            NowaKsiazka.Visibility = Visibility.Hidden;
            ListaKsiazek.Visibility = Visibility.Hidden;
            WypozyczKsiazke.Visibility = Visibility.Hidden;
            OddajKsiazke.Visibility = Visibility.Visible;
            NowyCzytelnik.Visibility = Visibility.Hidden;
            ZnajdzCzytelnika.Visibility = Visibility.Hidden;
            ListaCzytelnikow.Visibility = Visibility.Hidden;
        }
        private void NowyCzytelnikClick(object sender, RoutedEventArgs e)
        {
            NowaKsiazka.Visibility = Visibility.Hidden;
            ListaKsiazek.Visibility = Visibility.Hidden;
            WypozyczKsiazke.Visibility = Visibility.Hidden;
            OddajKsiazke.Visibility = Visibility.Hidden;
            NowyCzytelnik.Visibility = Visibility.Visible;
            ZnajdzCzytelnika.Visibility = Visibility.Hidden;
            ListaCzytelnikow.Visibility = Visibility.Hidden;
        }

        private void ZnajdzCzytelnikaClick(object sender, RoutedEventArgs e)
        {
            NowaKsiazka.Visibility = Visibility.Hidden;
            ListaKsiazek.Visibility = Visibility.Hidden;
            WypozyczKsiazke.Visibility = Visibility.Hidden;
            OddajKsiazke.Visibility = Visibility.Hidden;
            NowyCzytelnik.Visibility = Visibility.Hidden;
            ZnajdzCzytelnika.Visibility = Visibility.Visible;
            ListaCzytelnikow.Visibility = Visibility.Hidden;
        }

        private void ListaCzytelnikowClick(object sender, RoutedEventArgs e)
        {
            NowaKsiazka.Visibility = Visibility.Hidden;
            ListaKsiazek.Visibility = Visibility.Hidden;
            WypozyczKsiazke.Visibility = Visibility.Hidden;
            OddajKsiazke.Visibility = Visibility.Hidden;
            NowyCzytelnik.Visibility = Visibility.Hidden;
            ZnajdzCzytelnika.Visibility = Visibility.Hidden;
            ListaCzytelnikow.Visibility = Visibility.Visible;

            lista_czytelnikow.Items.Refresh();
            lista_czytelnikow.ItemsSource = czytelnicy.uzytkownicy;
        }

        private void ZatwierdzNowaKsiazkaClick(object sender, RoutedEventArgs e)
        {
            
            int id, rokWydania, liczbaStron;
            int.TryParse(nowaKsiazkaId.Text, out id);
            int.TryParse(nowaKsiazkaRokWydania.Text, out rokWydania);
            int.TryParse(nowaKsiazkaLiczbaStron.Text, out liczbaStron);
            ksiazki.DodajPozycje(nowaKsiazkaTytul.Text, id, nowaKsiazkaWydawnictwo.Text, rokWydania, liczbaStron, nowaKsiazkaAutor.Text);

            nowaKsiazkaAutor.Text = "Autor";
            nowaKsiazkaLiczbaStron.Text = "Liczba Stron";
            nowaKsiazkaRokWydania.Text = "Rok Wydania";
            nowaKsiazkaTytul.Text = "Tytul";
            nowaKsiazkaWydawnictwo.Text = "Wydawnictwo";


            MessageBox.Show("Dodano!");
            
        }

        private void ZatwierdzNowyCzytelnikClick(object sender, RoutedEventArgs e)
        {

            int nrKarty, wiek;
            int.TryParse(nrKartyCzytelnika.Text, out nrKarty);
            int.TryParse(wiekCzytelnika.Text, out wiek);
            
            czytelnicy.DodajCzytelnika(imieCzytelnika.Text, nazwiskoCzytelnika.Text, nrKarty, wiek);

            imieCzytelnika.Text = "Imie";
            nazwiskoCzytelnika.Text = "Nazwisko";
            wiekCzytelnika.Text = "Wiek";

            MessageBox.Show("Dodano!");

        }

        private void ZatwierdzWypozyczKsiazke(object sender, RoutedEventArgs e)
        {
            int Id = int.Parse(WypozyczKsiazkeId.Text);

            ksiazki.WypozyczKsiazke(Id);

            WypozyczKsiazkeId.Text = "Id";
            MessageBox.Show("Sukces!");
        }

        private void ZatwierdzOddajKsiazke(object sender, RoutedEventArgs e)
        {
            int Id2 = int.Parse(OddajKsiazkeId.Text);

            ksiazki.OddajKsiazke(Id2);

            OddajKsiazkeId.Text = "Id";
            MessageBox.Show("Sukces!");
        }

        private void ZatwierdzZnajdzCzytelnika(object sender, RoutedEventArgs e)
        {
            int id;
            int.TryParse(ZnajdzNrKartyCzytelnik.Text, out id);
            WynikZnajdzCzytelnika.Content = czytelnicy.WyszukajCzytelnika(id);
            ZnajdzNrKartyCzytelnik.Text = "Nr Karty";
        }
    }
}
