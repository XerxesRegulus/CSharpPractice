using CookieCookbook.Enums;
using CookieCookbook.FileWriters;
using CookieCookbook.Fixtures;
using CookieCookbook.Printers;
using CookieCookbook.Validators;

namespace CookieCookbook;

internal class RecipeBuilder
{
  private readonly List<Ingredient> ingredients = IngredientList.All();

  private List<int> SelectedIngredientIDs = new List<int>();
  const FileFormat format = FileFormat.Txt;
  public void Build()
  {
    Console.WriteLine("Create a new cookie recipe! Available Ingredients are: \n");
    IngredientPrinter.InList(ingredients);

    bool validInput;

    do
    {
      Console.WriteLine("Add an ingredient its ID or type anything else if finished.");
      string userInput = Console.ReadLine();
      validInput = RecipeBuilderInputValidator.isValid(userInput, out int selectedIngredient);
      int offsetSelectedIngredient = selectedIngredient - 1;

      if (!validInput) { break; }
      if (offsetSelectedIngredient < 0 && offsetSelectedIngredient > ingredients.Count) { continue; }

      SelectedIngredientIDs.Add(offsetSelectedIngredient);
    } while (validInput);

    RecipeFileWriter writer = new RecipeFileWriter(format);

    writer.Write(SelectedIngredientIDs);
    Console.WriteLine("IDs written down");
  }

}
