using System.Windows;

namespace ALMACO.UI
{
  public sealed class ThemeResourceDictionary : ResourceDictionary
  {
    public ThemeResourceDictionary()
    {
      MergedDictionaries.Add(Theme.ResourceDictionary);
    }
  }
}
