using DiceRoll.Validator;

namespace DiceRoll.Game
{
  public class DiceGame(Dice dice)
  {
    private readonly Dice _dice = dice;
    private int attempts;
    private InputValidator _inputValidator = new InputValidator();
    private Guess _guess = new Guess();

    public GameResult Play()
    {
      _dice.Roll();
      Console.WriteLine("A dice has been rolled, you have 3 tries to guess the number that was rolled.");
      
      while(GuessAmount.IsAllowed(attempts))
      {
        Console.WriteLine("Please Enter a Number");
        string userGuess = Console.ReadLine();
        if (_inputValidator.IsValid(userGuess, out int userGuessNumber))
        {
          _guess.Attempt(_dice.Number, userGuessNumber);

          if (_guess.isCorrect)
          {
            return GameResult.Victory;
          }
          else
          {
            Console.WriteLine("Sorry but that's wrong");
          }
          attempts++;
        }
        else
        {
          Console.WriteLine(_inputValidator.ErrorMessage);
        }
      }
      return GameResult.Defeat;
    }
  }
}

