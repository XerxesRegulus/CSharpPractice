using CookieCookbook.Enums;

namespace CookieCookbook.FileWriters;

public class RecipeFileWriter
{
  public FileFormat Format { get; init; }
  private string FileName { get; init; }
  public RecipeFileWriter(FileFormat format)
  {
    Format = format;
    FileName = $"recipes.{format}";
  }

  public void Write(List<int> ingredientIDs)
  {
    if (Format == FileFormat.Json)
    {
      Console.WriteLine("not yet implemented");
    }
    else
    {
      WriteAsTxt(ingredientIDs);
    }
  }

  private void WriteAsJSON(List<int> ingredientIDs)
  {

  }

  private void WriteAsTxt(List<int> ingredientIDs)
  {
    StreamWriter writer = File.AppendText(FileName);
    string convertedIDs = String.Join(',', ingredientIDs.ToArray());
    writer.WriteLine(convertedIDs);
    writer.Close();
  }

  private void initializeJSONFile()
  {

  }
}
