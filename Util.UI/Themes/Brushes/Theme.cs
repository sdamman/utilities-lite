using Util.UI;
using System.Windows;
using System.Windows.Media;

namespace ALMACO.UI
{
  public sealed class Theme
  {
    [ThreadStatic]
    private static ResourceDictionary resourceDictionary;
    private static readonly Application app = App.Current;

    internal static ResourceDictionary ResourceDictionary
    {
      get
      {
        if (resourceDictionary != null)
        {
          return resourceDictionary;
        }
        resourceDictionary = new ResourceDictionary();
        return resourceDictionary;
      }
    }




    public static ThemeType ThemeType { get; set; }

    public static void LoadThemeType(ThemeType type)
    {
      ThemeType = type;
      // ###########################################################
      // -- Colors that do not change based on Light of Dark Theme
      // ###########################################################
      SetResource(ThemeResourceKey.White.ToString(), "brushWhite");
      SetResource(ThemeResourceKey.Dark40.ToString(), "brushDark40");
      SetResource(ThemeResourceKey.Black.ToString(), "brushBlack");
      SetResource(ThemeResourceKey.DarkBlue.ToString(), "brushDarkBlue");
      SetResource(ThemeResourceKey.CombineBlue.ToString(), "brushCombineBlue");
      SetResource(ThemeResourceKey.LightBlue.ToString(), "brushLightBlue");
      SetResource(ThemeResourceKey.LightBlueTranslucent.ToString(), "brushLightBlueTranslucent");
      SetResource(ThemeResourceKey.UranianBlue.ToString(), "brushUranianBlue");
      SetResource(ThemeResourceKey.Eggshell.ToString(), "brushEggshell");
      SetResource(ThemeResourceKey.WarningAmber.ToString(), "brushWarningAmber");
      SetResource(ThemeResourceKey.GoodBlue.ToString(), "brushGoodBlue");

      SetResource(ThemeResourceKey.TestWeight1.ToString(), "brushTestWeight1");
      SetResource(ThemeResourceKey.TestWeight2.ToString(), "brushTestWeight2");
      SetResource(ThemeResourceKey.TestWeight3.ToString(), "brushTestWeight3");
      SetResource(ThemeResourceKey.TestWeight4.ToString(), "brushTestWeight4");
      SetResource(ThemeResourceKey.TestWeight5.ToString(), "brushTestWeight5");

      SetResource(ThemeResourceKey.Weight1.ToString(), "brushWeight1");
      SetResource(ThemeResourceKey.Weight2.ToString(), "brushWeight2");
      SetResource(ThemeResourceKey.Weight3.ToString(), "brushWeight3");
      SetResource(ThemeResourceKey.Weight4.ToString(), "brushWeight4");
      SetResource(ThemeResourceKey.Weight5.ToString(), "brushWeight5");

      SetResource(ThemeResourceKey.Moisture1.ToString(), "brushMoisture1");
      SetResource(ThemeResourceKey.Moisture2.ToString(), "brushMoisture2");
      SetResource(ThemeResourceKey.Moisture3.ToString(), "brushMoisture3");
      SetResource(ThemeResourceKey.Moisture4.ToString(), "brushMoisture4");
      SetResource(ThemeResourceKey.Moisture5.ToString(), "brushMoisture5");

      SetResource(ThemeResourceKey.Temperature1.ToString(), "brushTemperature1");
      SetResource(ThemeResourceKey.Temperature2.ToString(), "brushTemperature2");
      SetResource(ThemeResourceKey.Temperature3.ToString(), "brushTemperature3");
      SetResource(ThemeResourceKey.Temperature4.ToString(), "brushTemperature4");
      SetResource(ThemeResourceKey.Temperature5.ToString(), "brushTemperature5");

      SetResource(ThemeResourceKey.TransparentBackground.ToString(), "brushTransparentHit");
      SetResource(ThemeResourceKey.ControlDisabledOpacity.ToString(), "Opacity", 0.4d);

      // ##################################################
      // -- Colors that will change value depending on
      // -- whether the theme is light or dark.
      // ##################################################


      switch (type)
      {
        case ThemeType.Light:
          {
            SetResource(ThemeResourceKey.MinContrast.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.MaxContrast.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.Foreground.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.Background.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.MutedContrast.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.Highlight.ToString(), "brushDark40");
            SetResource(ThemeResourceKey.MutedHighlight.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.Complement.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.BoldHighlight.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.BoldCombo.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.MutedAccent.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.ToastBackground.ToString(), "brushUranianBlue80t");
            SetResource(ThemeResourceKey.Logo.ToString(), "brushCombineBlue");

            SetResource(ThemeResourceKey.ContentForeground.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.ContentBackground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.ContentBorder.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.MouseOverForeground.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.MouseOverBackground.ToString(), "brushDark40");
            SetResource(ThemeResourceKey.MouseOverBorder.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.PressedForeground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.PressedBackground.ToString(), "brushDarkMid");
            SetResource(ThemeResourceKey.PressedBorder.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.SelectedForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.SelectedBackground.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.SelectedBorder.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.ActiveBackground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.DisabledForeground.ToString(), "brushDark60");

            SetResource(ThemeResourceKey.WindowBackground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.WindowHeaderBackground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.WindowHeaderForeground.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.WindowHeaderMouseOverBackground.ToString(), "brushDarkMid");
            SetResource(ThemeResourceKey.WindowHeaderMouseOverForeground.ToString(), "brushBlack");

            SetResource(ThemeResourceKey.IconForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.IconPressed.ToString(), "brushCombineBlue");

            SetResource(ThemeResourceKey.BasicGreyButtonForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.BasicGreyButtonBackground.ToString(), "brushDark40");
            SetResource(ThemeResourceKey.BasicGreyButtonBorder.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.BasicGreyButtonMouseOverBackground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.BasicGreyButtonMouseOverForeground.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.BasicGreyButtonMouseOverBorder.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.BasicGreyButtonPressedBorder.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.BasicGreyButtonPressedForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.BasicGreyButtonPressedBackground.ToString(), "brushDark20");

            SetResource(ThemeResourceKey.BlueButtonForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.BlueButtonBackground.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.BlueButtonBorder.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.BlueButtonMouseOverForeground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.BlueButtonMouseOverBackground.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.BlueButtonMouseOverBorder.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.BlueButtonPressedForeground.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.BlueButtonPressedBackground.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.BlueButtonPressedBorder.ToString(), "brushWhite");

            SetResource(ThemeResourceKey.LightBlueButtonForeground.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.LightBlueButtonBackground.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.LightBlueButtonBorder.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.LightBlueButtonMouseOverForeground.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.LightBlueButtonMouseOverBackground.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.LightBlueButtonMouseOverBorder.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.LightBlueButtonPressedForeground.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.LightBlueButtonPressedBackground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.LightBlueButtonPressedBorder.ToString(), "brushCombineBlue");

            break;
          }
        case ThemeType.Dark:
          {
            SetResource(ThemeResourceKey.MinContrast.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.MaxContrast.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.Foreground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.Background.ToString(), "brushDark60");
            SetResource(ThemeResourceKey.MutedContrast.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.Highlight.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.MutedHighlight.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.Complement.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.BoldHighlight.ToString(), "brushMoisture5");
            SetResource(ThemeResourceKey.BoldCombo.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.MutedAccent.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.ToastBackground.ToString(), "brushCombineBlue80t");
            SetResource(ThemeResourceKey.Logo.ToString(), "brushWhite");

            SetResource(ThemeResourceKey.ContentForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.ContentBackground.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.ContentBorder.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.MouseOverForeground.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.MouseOverBackground.ToString(), "brushDark60");
            SetResource(ThemeResourceKey.MouseOverBorder.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.PressedForeground.ToString(), "brushDarkMid");
            SetResource(ThemeResourceKey.PressedBackground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.PressedBorder.ToString(), "brushDark40");
            SetResource(ThemeResourceKey.SelectedForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.SelectedBackground.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.SelectedBorder.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.ActiveBackground.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.DisabledForeground.ToString(), "brushDark50");

            SetResource(ThemeResourceKey.WindowBackground.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.WindowHeaderBackground.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.WindowHeaderForeground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.WindowHeaderMouseOverBackground.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.WindowHeaderMouseOverForeground.ToString(), "brushWhite");

            SetResource(ThemeResourceKey.IconForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.IconPressed.ToString(), "brushUranianBlue");

            SetResource(ThemeResourceKey.BasicGreyButtonForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.BasicGreyButtonBackground.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.BasicGreyButtonBorder.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.BasicGreyButtonMouseOverBackground.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.BasicGreyButtonMouseOverForeground.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.BasicGreyButtonMouseOverBorder.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.BasicGreyButtonPressedBorder.ToString(), "brushDarkMid");
            SetResource(ThemeResourceKey.BasicGreyButtonPressedForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.BasicGreyButtonPressedBackground.ToString(), "brushDarkMid");

            SetResource(ThemeResourceKey.BlueButtonForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.BlueButtonBackground.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.BlueButtonBorder.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.BlueButtonMouseOverForeground.ToString(), "brushDark40");
            SetResource(ThemeResourceKey.BlueButtonMouseOverBackground.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.BlueButtonMouseOverBorder.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.BlueButtonPressedForeground.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.BlueButtonPressedBackground.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.BlueButtonPressedBorder.ToString(), "brushWhite");

            SetResource(ThemeResourceKey.LightBlueButtonForeground.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.LightBlueButtonBackground.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.LightBlueButtonBorder.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.LightBlueButtonMouseOverForeground.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.LightBlueButtonMouseOverBackground.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.LightBlueButtonMouseOverBorder.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.LightBlueButtonPressedForeground.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.LightBlueButtonPressedBackground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.LightBlueButtonPressedBorder.ToString(), "brushCombineBlue");

            break;
          }
      }
    }

    public static object GetResources(ThemeResourceKey resourceKey)
    {
      return ResourceDictionary.Contains(resourceKey.ToString()) ? ResourceDictionary[resourceKey.ToString()] : null;
    }

    internal static void SetResource(object key, string resource)
    {
      if (resource.StartsWith("brush"))
        ResourceDictionary[key] = (SolidColorBrush)app.TryFindResource(resource);
      else
        ResourceDictionary[key] = (Color)app.TryFindResource(resource);
    }

    internal static void SetResource(object key, string resourceType, double value)
    {
      ResourceDictionary[key] = value;
    }

  }
}
