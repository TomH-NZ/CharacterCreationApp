namespace CharacterCreationApp;

public class DiceRoller : iDiceRoller
{
    public int DiceRoll(int diceValue)
    {
        var randomDice = new Random();
        return randomDice.Next(diceValue) + 1;
    }
}