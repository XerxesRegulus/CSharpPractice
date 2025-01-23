namespace CookieCookbook.Ingredients;
public class Wheat : Ingredient
{
  public override int ID { get { return 1; } }
  public override string Name { get { return "Wheat flour"; } }
  public override string Instructions
  {
    get
    {
      return "Sieve. Add to other ingredients.";
    }
  }
}
