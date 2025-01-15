namespace CookieCookbook.Ingredients;
public class Cocoa : Ingredient
{
  public override int ID { get { return 8; } }
  public override string Name { get { return "Cocoa Powder"; } }
  public override string Instructions
  {
    get
    {
      return "Add to other ingredients.";
    }
  }
}
