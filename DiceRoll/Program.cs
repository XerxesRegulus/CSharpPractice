
var dice = new DiceRoll.Dice();
dice.Roll();
Console.WriteLine("A dice has been rolled, you have 3 tries to guess the number that was rolled.");

bool successGuess = false;

for(int i = 0; i < 3; i++)
{
  if(successGuess)
  {
    break;
  }
}