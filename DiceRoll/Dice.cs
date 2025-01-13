namespace DiceRoll;

public class Dice
{
  public int Number { get; private set; }

  public int Roll()
  {
    Number = new Random().Next(1, 7);
    return Number;
  }
}
