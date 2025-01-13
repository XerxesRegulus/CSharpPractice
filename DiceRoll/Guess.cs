namespace DiceRoll;
internal class Guess
{
  private const int allowedRetries = 3;
  public int AmountOfAttempts { get; private set; }
  public bool isCorrect { get; private set; }

  public bool Attempt(int targetNumber, int guessNumber)
  {
    AmountOfAttempts++;
    if (isGuessCorrect(targetNumber, guessNumber))
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool isGuessCorrect(int targetNumber, int guessNumber) => targetNumber == guessNumber;
  public bool isRetryAllowed() => AmountOfAttempts <= allowedRetries;
}
