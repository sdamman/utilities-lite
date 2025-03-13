using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;

namespace Util.UI.UserControls
{
  /// <summary>
  /// Interaction logic for BreakLines.xaml
  /// </summary>
  public partial class BreakLines : UserControl
  {
    public BreakLines()
    {
      InitializeComponent();
    }

    private void GetFileOnClick(object sender, RoutedEventArgs e)
    {
      var dialog = new OpenFileDialog
      {
        DefaultDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
        DefaultExt = ".txt",
        Filter = "text files (.txt)|*.txt"
      };
      bool? result = dialog.ShowDialog();
      if (result == true)
        fileName.Text = dialog.FileName;

  }
}
}
