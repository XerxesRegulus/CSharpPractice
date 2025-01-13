namespace DiceRoll.Validator;

public class Input
{
  public string ErrorMessage { get; private set; }
  public bool Validate(string input)
  {
    bool parsable = int.TryParse(input, out int guessNumber);
    
    if(!parsable)
    {
      ErrorMessage = "Input is non parsable";
      return false;
    }
    
    if(!isInRange(guessNumber))
    {
      ErrorMessage = "Input is not in acceptable range";
      return false;
    }

    return true;
  }

  private bool isInRange(int guessNumber)
  {
    return (guessNumber is > 0 and <= 6);
  }
}

