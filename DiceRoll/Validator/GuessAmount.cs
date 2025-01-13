using DiceRoll.Helpers;

namespace DiceRoll.Validator;
public class GuessAmount
{
  public bool isAllowed(int numberOfRetries) => numberOfRetries < GuessHelpers.allowedRetries;
}
