
using DiceRoll;
using DiceRoll.Validator;

var dice = new DiceRoll.Dice();
dice.Roll();

Console.WriteLine("A dice has been rolled, you have 3 tries to guess the number that was rolled.");

bool successGuess = false;
var inputValidator = new DiceRoll.Validator.Input();
var guessValidator = new DiceRoll.Validator.GuessAmount();
var guess = new Guess();
var guessAmount = new GuessAmount();

while (guessValidator.isAllowed(guess.AmountOfAttempts) && !successGuess)
{
  Console.WriteLine("Please enter a number:");
  string userGuess = Console.ReadLine();
  if (inputValidator.isValid(userGuess, out int userGuessNumber))
  {
    guess.Attempt(dice.Number, userGuessNumber);
    if (guess.isCorrect)
    {
      successGuess = true;
      break;
    }
    else
    {
      Console.WriteLine("Sorry but that's wrong");
    }
  }
  else
  {
    Console.WriteLine($"Input is not valid because: {inputValidator.ErrorMessage}");
  }
}

if (successGuess)
{
  Console.WriteLine("Congrats you got it right!");
}
else
{
  Console.WriteLine("Sorry you run out of attempts :(");
}
