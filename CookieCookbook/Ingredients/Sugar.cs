namespace CookieCookbook.Ingredients;
public class Sugar : Ingredient
{
  public override int ID { get { return 5; } }
  public override string Name { get { return "Sugar"; } }
  public override string Instructions
  {
    get
    {
      return "Add to other ingredients.";
    }
  }
}
