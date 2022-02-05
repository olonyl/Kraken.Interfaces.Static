using System.Windows;
using static Kraken.WPF.Consumer.RepositoryFactory;

namespace Kraken.WPF.Consumer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();
            this.DataContext = _viewModel;
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.ClearData();
        }

        private void ServiceRepositoryButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.FetchData(RepositoryType.Service);
            ShowRepositoryType();
        }

        private void CSVRepositoryButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.FetchData(RepositoryType.CSV);
            ShowRepositoryType();
        }

        private void SQLRepositoryButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.FetchData(RepositoryType.SQL);
            ShowRepositoryType();
        }

        private void ShowRepositoryType()
        {
            MessageBox.Show(string.Format("Repositry Type:\n{0}",
                _viewModel.RepositoryType));
        }
    }
}
