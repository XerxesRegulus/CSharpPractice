
namespace DiceRoll.Helpers
{
  public class ResultPrinter
  {
    public static void Print(GameResult result)
    {
      string results = result == GameResult.Victory ? "Victory!" : "Defeat";

      Console.WriteLine(results);
    }
  }
}
