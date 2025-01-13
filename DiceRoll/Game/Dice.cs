namespace DiceRoll.Game;

public class Dice
{
    public int Number { get; private set; }
    public readonly int NumberOfSides;

    public Dice(int numberOfSides)
    {
      NumberOfSides = numberOfSides + 1;
    }

    public int Roll()
    {
        Number = new Random().Next(1, NumberOfSides);
        return Number;
    }
}
