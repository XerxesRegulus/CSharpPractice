namespace CookieCookbook.Ingredients;
public class Chocolate : Ingredient
{
  public override int ID { get { return 4; } }
  public override string Name { get { return "Chocolate"; } }
  public override string Instructions
  {
    get
    {
      return "Melt in a water bath. Add to other ingredients.";
    }
  }
}
