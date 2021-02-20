using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Abrudan_Sergiu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    enum ActionState
    {
        New,
        Edit,
        Delete,
        Nothing
    }
    public partial class MainWindow : Window
    {
        private void frmMain_Loaded(object sender, RoutedEventArgs e)
        {

            Abrudan_Sergiu.PhoneNumbersDataSet1 phoneNumbersDataSet1 = ((Abrudan_Sergiu.PhoneNumbersDataSet1)(this.FindResource("phoneNumbersDataSet1")));
            // Load data into the table Contracts. You can modify this code as needed.
            Abrudan_Sergiu.PhoneNumbersDataSet1TableAdapters.ContractsTableAdapter phoneNumbersDataSet1ContractsTableAdapter = new Abrudan_Sergiu.PhoneNumbersDataSet1TableAdapters.ContractsTableAdapter();
            phoneNumbersDataSet1ContractsTableAdapter.Fill(phoneNumbersDataSet1.Contracts);
            System.Windows.Data.CollectionViewSource contractsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("contractsViewSource")));
            contractsViewSource.View.MoveCurrentToFirst();
            // Load data into the table PhoneNumbers. You can modify this code as needed.
            Abrudan_Sergiu.PhoneNumbersDataSet1TableAdapters.PhoneNumbersTableAdapter phoneNumbersDataSet1PhoneNumbersTableAdapter = new Abrudan_Sergiu.PhoneNumbersDataSet1TableAdapters.PhoneNumbersTableAdapter();
            phoneNumbersDataSet1PhoneNumbersTableAdapter.Fill(phoneNumbersDataSet1.PhoneNumbers);
            System.Windows.Data.CollectionViewSource phoneNumbersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("phoneNumbersViewSource")));
            phoneNumbersViewSource.View.MoveCurrentToFirst();
            // Load data into the table CommunicationsProvider. You can modify this code as needed.
            Abrudan_Sergiu.PhoneNumbersDataSet1TableAdapters.CommunicationsProviderTableAdapter phoneNumbersDataSet1CommunicationsProviderTableAdapter = new Abrudan_Sergiu.PhoneNumbersDataSet1TableAdapters.CommunicationsProviderTableAdapter();
            phoneNumbersDataSet1CommunicationsProviderTableAdapter.Fill(phoneNumbersDataSet1.CommunicationsProvider);
            System.Windows.Data.CollectionViewSource communicationsProviderViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("communicationsProviderViewSource")));
            communicationsProviderViewSource.View.MoveCurrentToFirst();
        }

        private void communicationsProviderDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
