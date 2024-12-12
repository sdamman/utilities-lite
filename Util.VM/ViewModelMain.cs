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

    public ViewModelMain()
    {
      // --- Command Instantiation ---
      BreakLinesCommand = new RelayCommand(BreakLines);
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



    // #####################
    // --- Methods ---
    // #####################

    public void GetFile(string fileName)
    {
      OriginalFile = fileName;
      string fileOnly = Path.GetFileNameWithoutExtension(fileName);
      string tempPath = Path.GetDirectoryName(fileName);
      NewFile = Path.Combine(tempPath, fileOnly + "-updated" + Path.GetExtension(fileName));

      using (StreamReader sr = new StreamReader(OriginalFile))
      {
        string line = sr.ReadLine();
        StringBuilder sb = new(line);
        while (!sr.EndOfStream)
          sb.Append(sr.ReadLine());
        FileContentsOriginal = sb.ToString();
      }

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

  }
}
