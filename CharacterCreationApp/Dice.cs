namespace CharacterCreationApp;

public class Dice : iDiceRoller
{
    public int Roll(int diceValue)
    {
        return Random.Shared.Next(1, diceValue + 1);
    }
}