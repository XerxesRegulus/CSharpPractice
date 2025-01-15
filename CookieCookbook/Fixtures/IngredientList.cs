using CookieCookbook.Ingredients;

namespace CookieCookbook.Fixtures;

static class IngredientList
{
  public static List<Ingredient> All()
  {
    return
    [
      new Wheat(),
      new Coconut(),
      new Butter(),
      new Chocolate(),
      new Sugar(),
      new Cardamom(),
      new Cinnamon(),
      new Cocoa()
    ];
  }
}
