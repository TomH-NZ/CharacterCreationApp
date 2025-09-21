using CharacterCreationApp.Constants;

namespace CharacterCreationApp;

    //This class will roll 4d6 and drop the lowest result to calculate the value for each of the player stats
    public class Stats
    {
        int Roll(int diceValue)
        {
            var output = 0;
            var statRolls = new List<int>();
            var dice = new Dice();

            while (output < 5)
            {
                for (var i = 0; i < 4; i++)
                {
                    statRolls.Add(dice.Roll(diceValue));
                }
                statRolls.Sort((a, b) => b.CompareTo(a));
                output = statRolls.Take(3).Sum();
            }

            return output;
        }
    }