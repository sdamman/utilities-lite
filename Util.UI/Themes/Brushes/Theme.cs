using System;
using System.Windows;
using System.Windows.Media;
using Util.UI;

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
            SetResource(ThemeResourceKey.BackgroundColor.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.MutedContrast.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.Highlight.ToString(), "brushDark40");
            SetResource(ThemeResourceKey.MutedHighlight.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.ComplementColor.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.DayDeepBlueNightGrey.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.DayLightBlueNightGrey.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.BoldHighlight.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.MutedAccent.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.BoldCombo.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.ToastBackground.ToString(), "brushUranianBlue80t");
            SetResource(ThemeResourceKey.TransparentBackground.ToString(), "brushTransparentHit");

            SetResource(ThemeResourceKey.Logo.ToString(), "brushCombineBlue");

            SetResource(ThemeResourceKey.ComboBoxForeground.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.ComboBoxBackground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.ComboBoxBorder.ToString(), "brushDark40");
            SetResource(ThemeResourceKey.ComboBoxMouseOverForeground.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.ComboBoxMouseOverBackground.ToString(), "brushDark40");
            SetResource(ThemeResourceKey.ComboBoxMouseOverBorder.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.ComboBoxPressedForeground.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.ComboBoxPressedBackground.ToString(), "brushDarkMid");
            SetResource(ThemeResourceKey.ComboBoxPressedBorder.ToString(), "brushCombineBlue");

            SetResource(ThemeResourceKey.ComboBoxSelectedForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.ComboBoxSelectedBackground.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.EditableComboBoxForeground.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.EditableComboBoxBackground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.EditableComboBoxBorder.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.EditableComboBoxMouseOverForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.EditableComboBoxMouseOverBackground.ToString(), "brushDarkMid");
            SetResource(ThemeResourceKey.EditableComboBoxMouseOverBorder.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.EditableComboBoxPressedBorder.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.EditableComboBoxPressedForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.EditableComboBoxPressedBackground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.EditableComboBoxSelectedForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.EditableComboBoxSelectedBackground.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.EditableComboBoxHighlight.ToString(), "brushCombineBlue");

            SetResource(ThemeResourceKey.GroupBoxFont.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.GroupBoxTopBar.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.GroupBoxFunContrastFont.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.GroupBoxFunContrastTopBar.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.GroupBoxBoldFont.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.GroupBoxBoldTopBar.ToString(), "brushDarkBlue");

            SetResource(ThemeResourceKey.CheckBoxForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.CheckBoxBackground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.CheckBoxIcon.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.CheckBoxBorder.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.CheckBoxMouseOverForeground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.CheckBoxMouseOverBackground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.CheckBoxMouseOverBorder.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.CheckBoxPressedForeground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.CheckBoxPressedBackground.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.CheckBoxPressedBorder.ToString(), "brushDark40");

            SetResource(ThemeResourceKey.ListViewForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.ListViewBackground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.ListViewBorder.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.ListViewMouseOverForeground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.ListViewMouseOverBackground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.ListViewMouseOverBorder.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.ListViewPressedForeground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.ListViewPressedBackground.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.ListViewPressedBorder.ToString(), "brushDark40");

            SetResource(ThemeResourceKey.Heading1.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.Heading2.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.Heading3.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.Link.ToString(), "brushDarkBlue");

            SetResource(ThemeResourceKey.TextBoxBackground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.TextboxForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.TextBoxBorder.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.TextBoxMouseOverBackground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.TextboxMouseOverForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.TextBoxMouseOverBorder.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.TextBoxPressedBackground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.TextboxPressedForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.TextBoxPressedBorder.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.TextBoxHighlight.ToString(), "brushCombineBlue");

            SetResource(ThemeResourceKey.WindowBackground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.WindowHeaderBackground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.WindowHeaderForeground.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.WindowHeaderMouseOverBackground.ToString(), "brushDarkMid");
            SetResource(ThemeResourceKey.WindowHeaderMouseOverForeground.ToString(), "brushBlack");

            SetResource(ThemeResourceKey.ContentForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.ContentBackground.ToString(), "brushWhite");

            SetResource(ThemeResourceKey.TabItemStaticBorder.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.TabItemStaticForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.TabItemStaticBackground.ToString(), "brushDark40");
            SetResource(ThemeResourceKey.TabItemContentBackground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.TabItemMouseOverBorder.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.TabItemMouseOverBackground.ToString(), "brushEggshell");
            SetResource(ThemeResourceKey.TabItemSelectedBorder.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.TabItemSelectedBackground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.TabItemDisabledBorder.ToString(), "brushDarkMid");
            SetResource(ThemeResourceKey.TabItemDisabledForeground.ToString(), "brushDark60");
            SetResource(ThemeResourceKey.TabItemDisabledBackground.ToString(), "brushDarkMid");

            SetResource(ThemeResourceKey.IconForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.IconPressed.ToString(), "brushCombineBlue");

            SetResource(ThemeResourceKey.RadioButtonForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.RadioButtonBackground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.RadioButtonBorder.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.RadioButtonPressedForeground.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.RadioButtonPressedBackground.ToString(), "brushDarkMid");
            SetResource(ThemeResourceKey.RadioButtonPressedBorder.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.RadioButtonMouseOverForeground.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.RadioButtonMouseOverBackground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.RadioButtonMouseOverBorder.ToString(), "brushDarkMid");

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
            SetResource(ThemeResourceKey.BackgroundColor.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.MutedContrast.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.Highlight.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.MutedHighlight.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.ComplementColor.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.DayDeepBlueNightGrey.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.DayLightBlueNightGrey.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.BoldHighlight.ToString(), "brushMoisture5");
            SetResource(ThemeResourceKey.MutedAccent.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.BoldCombo.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.ToastBackground.ToString(), "brushCombineBlue80t");
            SetResource(ThemeResourceKey.TransparentBackground.ToString(), "brushTransparentHit");

            SetResource(ThemeResourceKey.Logo.ToString(), "brushWhite");

            SetResource(ThemeResourceKey.ComboBoxForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.ComboBoxBackground.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.ComboBoxBorder.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.ComboBoxMouseOverForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.ComboBoxMouseOverBackground.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.ComboBoxMouseOverBorder.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.ComboBoxPressedForeground.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.ComboBoxPressedBackground.ToString(), "brushDark40");
            SetResource(ThemeResourceKey.ComboBoxPressedBorder.ToString(), "brushCombineBlue");

            SetResource(ThemeResourceKey.ComboBoxSelectedForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.ComboBoxSelectedBackground.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.EditableComboBoxForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.EditableComboBoxBackground.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.EditableComboBoxBorder.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.EditableComboBoxMouseOverForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.EditableComboBoxMouseOverBackground.ToString(), "brushDarkMid");
            SetResource(ThemeResourceKey.EditableComboBoxMouseOverBorder.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.EditableComboBoxPressedBorder.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.EditableComboBoxPressedForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.EditableComboBoxPressedBackground.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.EditableComboBoxSelectedForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.EditableComboBoxSelectedBackground.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.EditableComboBoxHighlight.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.GroupBoxFont.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.GroupBoxTopBar.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.GroupBoxFunContrastFont.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.GroupBoxFunContrastTopBar.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.GroupBoxBoldFont.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.GroupBoxBoldTopBar.ToString(), "brushDarkBlue");

            SetResource(ThemeResourceKey.CheckBoxForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.CheckBoxBackground.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.CheckBoxIcon.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.CheckBoxBorder.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.CheckBoxMouseOverForeground.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.CheckBoxMouseOverBackground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.CheckBoxMouseOverBorder.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.CheckBoxPressedForeground.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.CheckBoxPressedBackground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.CheckBoxPressedBorder.ToString(), "brushDark100");

            SetResource(ThemeResourceKey.ListViewForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.ListViewBackground.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.ListViewBorder.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.ListViewMouseOverForeground.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.ListViewMouseOverBackground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.ListViewMouseOverBorder.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.ListViewPressedForeground.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.ListViewPressedBackground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.ListViewPressedBorder.ToString(), "brushDark100");

            SetResource(ThemeResourceKey.Heading1.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.Heading2.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.Heading3.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.Link.ToString(), "brushDarkBlue");

            SetResource(ThemeResourceKey.TextBoxBackground.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.TextboxForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.TextBoxBorder.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.TextBoxMouseOverBackground.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.TextboxMouseOverForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.TextBoxMouseOverBorder.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.TextBoxPressedBackground.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.TextboxPressedForeground.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.TextBoxPressedBorder.ToString(), "brushBlack");
            SetResource(ThemeResourceKey.TextBoxHighlight.ToString(), "brushUranianBlue");

            SetResource(ThemeResourceKey.WindowBackground.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.WindowHeaderBackground.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.WindowHeaderForeground.ToString(), "brushDark20");
            SetResource(ThemeResourceKey.WindowHeaderMouseOverBackground.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.WindowHeaderMouseOverForeground.ToString(), "brushWhite");

            SetResource(ThemeResourceKey.ContentForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.ContentBackground.ToString(), "brushDark80");

            SetResource(ThemeResourceKey.TabItemStaticBorder.ToString(), "brushDark40");
            SetResource(ThemeResourceKey.TabItemStaticForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.TabItemStaticBackground.ToString(), "brushDark60");
            SetResource(ThemeResourceKey.TabItemContentBackground.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.TabItemMouseOverBorder.ToString(), "brushDarkBlue");
            SetResource(ThemeResourceKey.TabItemMouseOverBackground.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.TabItemSelectedBorder.ToString(), "brushDark40");
            SetResource(ThemeResourceKey.TabItemSelectedBackground.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.TabItemDisabledBorder.ToString(), "brushDarkMid");
            SetResource(ThemeResourceKey.TabItemDisabledForeground.ToString(), "brushDark50");
            SetResource(ThemeResourceKey.TabItemDisabledBackground.ToString(), "brushDarkMid");

            SetResource(ThemeResourceKey.IconForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.IconPressed.ToString(), "brushUranianBlue");

            SetResource(ThemeResourceKey.RadioButtonForeground.ToString(), "brushWhite");
            SetResource(ThemeResourceKey.RadioButtonBackground.ToString(), "brushDark80");
            SetResource(ThemeResourceKey.RadioButtonBorder.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.RadioButtonPressedForeground.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.RadioButtonPressedBackground.ToString(), "brushDark40");
            SetResource(ThemeResourceKey.RadioButtonPressedBorder.ToString(), "brushCombineBlue");
            SetResource(ThemeResourceKey.RadioButtonMouseOverForeground.ToString(), "brushUranianBlue");
            SetResource(ThemeResourceKey.RadioButtonMouseOverBackground.ToString(), "brushDark100");
            SetResource(ThemeResourceKey.RadioButtonMouseOverBorder.ToString(), "brushWhite");

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
