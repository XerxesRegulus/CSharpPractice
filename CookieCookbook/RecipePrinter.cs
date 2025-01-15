using CookieCookbook.Enums;
using CookieCookbook.Fixtures;

namespace CookieCookbook;

public class RecipePrinter
{
  private FileFormat Format { get; init; }
  private string FileName { get; init; }
  public RecipePrinter(FileFormat format)
  {
    Format = format;
    FileName = $"recipes.{format}";
  }

  public void Print()
  {
    switch (Format)
    {
      case FileFormat.Json:
        Console.WriteLine("Not Implemented");
        break;
      case FileFormat.Txt:
        PrintTxt();
        break;
      default:
        Console.WriteLine("Not Implemented");
        break;
    }
  }

  private void PrintTxt()
  {
    StreamReader reader = new StreamReader(FileName);
    string fileText = reader.ReadToEnd();
    string[] recipeIDs = fileText.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

    for (int i = 0; i < recipeIDs.Length; i++)
    {
      Console.WriteLine($"***** {i + 1} *****");
      int[] ingredientIDs = recipeIDs[i].Split(',').Select(int.Parse).ToArray();

      foreach (int id in ingredientIDs)
      {
        Ingredient ingredient = IngredientList.All()[id];

        Console.WriteLine($"{ingredient.Name}. {ingredient.Instructions}");
      }
      Console.WriteLine("");
    }

    reader.Close();
  }
}
