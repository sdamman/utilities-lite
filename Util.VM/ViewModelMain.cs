using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Text;

namespace Util.VM
{
  public partial class ViewModelMain : ObservableObject
  {

    // #####################
    // --- Command Declarations ---
    // #####################
    public IRelayCommand BreakLinesCommand { get; }
    public IRelayCommand RoundDigitsCommand { get; }

    public ViewModelMain()
    {
      // --- Command Instantiation ---
      BreakLinesCommand = new RelayCommand(BreakLines);
      RoundDigitsCommand = new RelayCommand(RoundDigits);
    }

    // #####################
    // --- Properties ---
    // #####################

    [ObservableProperty]
    private string originalFile = "choose a file to re-organize";
    [ObservableProperty]
    private string newFile = null;
    [ObservableProperty]
    private string endText = "<NUL>";
    [ObservableProperty]
    private string fileContentsOriginal = null;
    [ObservableProperty]
    private string fileContentsNew = null;
    [ObservableProperty]
    private string inputText = null;
    [ObservableProperty]
    private string outputText = null;
    [ObservableProperty]
    private string numberOfDigits = "4";



    // #####################
    // --- Methods ---
    // #####################

    public void GetFile()
    {
      string fileOnly = Path.GetFileNameWithoutExtension(OriginalFile);
      string tempPath = Path.GetDirectoryName(OriginalFile);
      NewFile = Path.Combine(tempPath, fileOnly + "-updated" + Path.GetExtension(OriginalFile));

      using StreamReader sr = new(OriginalFile);
      string line = sr.ReadLine();
      StringBuilder sb = new(line);
      while (!sr.EndOfStream)
        sb.Append(sr.ReadLine());
      FileContentsOriginal = sb.ToString();

    }

    public void BreakLines()
    {
      string[] fileContentsTemp = FileContentsOriginal.Split(EndText);
      StringBuilder sb = new();
      using (StreamWriter sw = new(NewFile))
      {
        foreach (string line in fileContentsTemp)
        {
          sb.AppendLine(line + EndText);
          sw.WriteLine(line + EndText);
        }
      }
      FileContentsNew = sb.ToString();
    }

    public void RoundDigits()
    {
      if (string.IsNullOrEmpty(InputText)) return;
      char splitChar = ' ';
      int digits = Convert.ToInt32(NumberOfDigits);
      string[] inputStrings = InputText.Split(splitChar);
      StringBuilder sb = new();
      foreach (string inputString in inputStrings)
      {
        if (double.TryParse(inputString, out double outNum))
          sb.Append(Math.Round(outNum, digits));
        else
          sb.Append(inputString);
        sb.Append(splitChar);
      }
      OutputText = sb.ToString();
    }

  }
}
