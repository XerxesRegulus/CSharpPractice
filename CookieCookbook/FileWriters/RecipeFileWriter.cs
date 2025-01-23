using CookieCookbook.Enums;
using CookieCookbook.Readers;
using System.Text.Json;
using System.Text.Json.Nodes;

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
    switch(Format)
    {
      case FileFormat.Json:
        WriteAsJSON(ingredientIDs);
        break;
      case FileFormat.Txt:
        WriteAsTxt(ingredientIDs);
        break;
      default:
        Console.WriteLine("Format not implemented");
        break;
    }
  }

  private void WriteAsJSON(List<int> ingredientIDs)
  {
    List<string> existingData = RecipeJsonDeserializer.Data(FileName);
    existingData.Add(String.Join(",", ingredientIDs));

    string jsonString = JsonSerializer.Serialize(existingData);
    File.WriteAllText(FileName, jsonString);
  }

  private void WriteAsTxt(List<int> ingredientIDs)
  {
    StreamWriter writer = File.AppendText(FileName);
    string convertedIDs = String.Join(',', ingredientIDs.ToArray());
    writer.WriteLine(convertedIDs);
    writer.Close();
  }
}

