namespace CookieCookbook.Printers;

static class IngredientPrinter
{
  public static void InList(List<Ingredient> ingredients)
  {
    foreach (Ingredient ingredient in ingredients)
    {
      Console.WriteLine($"{ingredient.ID}. {ingredient.Name}");
    }

  }
  public static void InRecipe(List<Ingredient> ingredients)
  {
  }
}
