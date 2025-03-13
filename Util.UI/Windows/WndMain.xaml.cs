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


  }
}
