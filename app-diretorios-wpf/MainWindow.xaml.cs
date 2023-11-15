using System;
using System.Collections.Generic;
using System.IO;
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

namespace app_diretorios_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var path = txtDiretorio.Text;
                Directory.CreateDirectory(path);
                MessageBox.Show("Diretório criado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
               MessageBox.Show($"Erro {ex.Message}", "Erro do Sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var directory = Directory.GetFileSystemEntries(txtDiretorio.Text);  
                treeView.ItemsSource = directory;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro {ex.Message}", "Erro do Sistema", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
