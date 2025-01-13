namespace DiceRoll.Validator;

public class Guess
{
  public bool isAllowed(int numberOfRetries, int allowedRetries) => numberOfRetries <= allowedRetries;
}
