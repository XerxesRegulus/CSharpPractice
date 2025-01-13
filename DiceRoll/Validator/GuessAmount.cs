using DiceRoll.Helpers;

namespace DiceRoll.Validator;
public static class GuessAmount
{
  public static bool IsAllowed(int numberOfRetries) => numberOfRetries < GuessHelpers.allowedRetries;
}
