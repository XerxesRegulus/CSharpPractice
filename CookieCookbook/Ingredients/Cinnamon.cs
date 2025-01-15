namespace CookieCookbook.Ingredients;
public class Cinnamon: Ingredient
{
  public override int ID { get { return 7; } }
  public override string Name { get { return "Butter"; } }
  public override string Instructions
  {
    get
    {
      return "Take half a teaspoon. Add to other ingredients.";
    }
  }
}
