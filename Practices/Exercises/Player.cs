namespace Practices.Exercises;

public class Player
{
    public int RollDie()
    {
        Random random = new Random();
        return random.Next(1, 7); // Generates a random number between 1 and 6 (inclusive)

        throw new NotImplementedException("Please implement the Player.RollDie() method");
    }

    public double GenerateSpellStrength()
    {
        Random random = new Random();
        return random.NextDouble() * 100.0; // Generates a random double between 0.0 and 100.0

        throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
    }
}