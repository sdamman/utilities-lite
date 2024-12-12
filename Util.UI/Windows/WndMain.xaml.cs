using Microsoft.Win32;
using System.Windows;
using Util.VM;

namespace Util.UI.Windows
{
  /// <summary>
  /// Interaction logic for WndMain.xaml
  /// </summary>
  public partial class WndMain : Window
  {
    ViewModelMain vmm = new();
    public WndMain()
    {

      DataContext = vmm;
      InitializeComponent();
    }


    private void Click_SelectFile(object sender, RoutedEventArgs e)
    {
      var dialog = new OpenFileDialog
      {
        DefaultDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
        DefaultExt = ".txt",
        Filter = "text files (.txt)|*.txt"
      };
      bool? result = dialog.ShowDialog();
      if (result == true)
        vmm.GetFile(dialog.FileName);
    }
  }
}
