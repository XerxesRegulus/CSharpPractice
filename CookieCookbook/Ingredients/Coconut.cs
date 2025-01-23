namespace CookieCookbook.Ingredients;
public class Coconut : Ingredient
{
  public override int ID { get { return 2; } }
  public override string Name { get { return "Coconut flour"; } }
  public override string Instructions
  {
    get
    {
      return "Sieve. Add to other ingredients.";
    }
  }
}
