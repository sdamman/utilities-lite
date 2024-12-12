using ALMACO.UI;
using System.Windows;
using Util.UI.Windows;

namespace Util.UI
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    private WndMain wndMain;

    public App()
    {
      Current.Startup += Current_Startup;
    }

    // Code to set the last known window position and state on startup.
    private void Current_Startup(object sender, StartupEventArgs e)
    {
      wndMain = new();

      Rect positionAndSize = UI.Properties.Settings.Default.StartWindowPosition;
      WindowState state = UI.Properties.Settings.Default.StartWindowState;
      Theme.ThemeType = UI.Properties.Settings.Default.SavedThemeType;

      wndMain.Closing += WndMain_Closing;
      if (positionAndSize.IsEmpty
          || (SystemParameters.VirtualScreenWidth < positionAndSize.Left)
          || (SystemParameters.VirtualScreenHeight < positionAndSize.Top))
      {
        positionAndSize = new Rect(50, 50, 450, 600);
      }

      wndMain.Left = positionAndSize.Left;
      wndMain.Top = positionAndSize.Top;
      wndMain.Width = positionAndSize.Width;
      wndMain.Height = positionAndSize.Height;
      wndMain.WindowState = state;
      Theme.LoadThemeType(Theme.ThemeType);

      wndMain.Show();
    }

    // Code to save the window position and state on shutdown.
    private void WndMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
      UI.Properties.Settings.Default.StartWindowPosition
        = new Rect(wndMain.Left, wndMain.Top, wndMain.Width, wndMain.Height);
      UI.Properties.Settings.Default.StartWindowState = wndMain.WindowState;
      UI.Properties.Settings.Default.SavedThemeType = Theme.ThemeType;
      UI.Properties.Settings.Default.Save();
      Current.Shutdown();
    }
  }

}
