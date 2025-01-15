namespace CookieCookbook.Validators;

public class RecipeBuilderInputValidator
{
  public static bool isValid(string input, out int selectedIngredient)
  {
    bool parsable = int.TryParse(input, out selectedIngredient);

    if (!parsable)
    {
      return false;
    }

    return true;
  }
}
