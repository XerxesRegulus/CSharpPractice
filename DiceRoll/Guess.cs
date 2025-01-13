namespace DiceRoll;

internal class Guess
{
  public int AmountOfAttempts { get; private set; }
  public bool isCorrect { get; private set; }

  public void Attempt(int targetNumber, int guessNumber)
  {
    AmountOfAttempts++;
    isCorrect = isGuessCorrect(targetNumber, guessNumber);
  }

  public bool isGuessCorrect(int targetNumber, int guessNumber) => targetNumber == guessNumber;
}
