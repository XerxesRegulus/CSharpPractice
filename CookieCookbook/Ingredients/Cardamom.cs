namespace CookieCookbook.Ingredients;
public class Cardamom : Ingredient
{
  public override int ID { get { return 6; } }
  public override string Name { get { return "Cardamom"; } }
  public override string Instructions
  {
    get
    {
      return "Take half a teaspoon. Add to other ingredients.";
    }
  }
}
