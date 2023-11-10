using System;

public class Player
{
    Random rnd = new Random();
    public int RollDie()
    {
        //throw new NotImplementedException("Please implement the Player.RollDie() method");
        return rnd.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        //throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
        return rnd.NextDouble() * 100.0;
    }
}
