
using DiceRoll.Game;
using DiceRoll.Helpers;

var game = new DiceGame(new Dice(6));
GameResult result = game.Play();
ResultPrinter.Print(result);
