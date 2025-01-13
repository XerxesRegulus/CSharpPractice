namespace DiceRoll.Validator;

public class InputValidator
{
  public string ErrorMessage { get; private set; }
  public bool IsValid(string input, out int guessNumber)
  {
    bool parsable = int.TryParse(input, out guessNumber);

    if (!parsable)
    {
      ErrorMessage = "Input is non parsable";
      return false;
    }

    return true;
  }

}

