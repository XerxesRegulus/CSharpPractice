using System.Text.Json;
using System.Text.Json.Nodes;

namespace CookieCookbook.Readers;

public class RecipeJsonDeserializer
{
  public static List<string> Data(string FileName)
  {
    if (File.Exists(FileName))
    {
      string jsonString = File.ReadAllText(FileName);
      if(!(string.IsNullOrEmpty(jsonString)))
      {
        return JsonSerializer.Deserialize<List<string>>(jsonString);
      }
    }

    return new List<string>();
  }
}
