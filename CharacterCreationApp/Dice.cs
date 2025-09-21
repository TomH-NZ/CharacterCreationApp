namespace CharacterCreationApp;

public class Dice : iDiceRoller
{
    public int Roll(int diceValue)
    {
        var randomDice = new Random();
        return randomDice.Next(diceValue) + 1;
    }
}