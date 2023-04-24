using System;
using System.Windows;


namespace Compte_CAMALEX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double solde;
        private string devise;

        public MainWindow()
        {
        InitializeComponent();

        }

        private void Show_Debit_Click(object sender, RoutedEventArgs e)
        {
            MyPopup.IsOpen = true;
        }

        private void Hide_Debit_Click(object sender, RoutedEventArgs e)
        {
            MyPopup.IsOpen = false;
        }


        public void CompteBancaire(double soldeInitial, string devise)
        {
            this.solde = soldeInitial;
            this.devise = " €";
        }
        public override string ToString()
        {
            return "Le solde de votre compte est de " + solde + " " + devise;
        }

        public double GetSolde()
        {
            return solde;
        }

        public double Debiter(double montant)
        {
            return solde -= montant;
        }
        public double Crediter(double montant)
        {
            return solde += montant;
        }

    }


    public class CompteBancaire
    {
        

    }
}
