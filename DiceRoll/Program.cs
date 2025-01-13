
var dice = new DiceRoll.Dice();
dice.Roll();

Console.WriteLine("A dice has been rolled, you have 3 tries to guess the number that was rolled.");
string guess = Console.ReadLine();

bool successGuess = false;
var inputValidator = new DiceRoll.Validator.Input();

for (int i = 0; i < 3; i++)
{
  if (inputValidator.isValid(guess))
  {
    if (successGuess)
    {
      break;
    }
  }
  else
  {
    Console.WriteLine($"Input is not valid because: {inputValidator.ErrorMessage}");
  }
}