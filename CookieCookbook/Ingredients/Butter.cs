namespace CookieCookbook.Ingredients;
public class Butter : Ingredient
{
  public override int ID { get { return 3; } }
  public override string Name { get { return "Butter"; } }
  public override string Instructions
  {
    get
    {
      return "Melt on low heat. Add to other ingredients.";
    }
  }
}
