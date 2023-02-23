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
using System.IO;

namespace WPFNepesseg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            List<Telepules> telepulesek = AdatokBetoltese("Adatok\\kozerdeku_lakossag_2022.csv");
            dgTelepulesk.ItemsSource = telepulesek;
            cbMegyek.ItemsSource = telepulesek.Select(obj => obj.Megye).Distinct().ToList();
        }
        
        private List<Telepules> AdatokBetoltese(string fajlNev)
        {
            List<Telepules> ujLista = new List<Telepules>();
            string[] beolvasott = File.ReadAllLines(fajlNev);
            for (int i = 1; i < beolvasott.Length; i++)
            {
                string[] splittelt = beolvasott[i].Split(";");
                ujLista.Add(new Telepules(splittelt[2], splittelt[3], splittelt[4], Convert.ToInt32(splittelt[5].Replace(" ", "")), Convert.ToInt32(splittelt[6].Replace(" ", ""))));
            }
            return ujLista;
        }
        
        private void cbMegyek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
