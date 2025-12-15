using System;

class VariablesExample
{
    public static void Run()
    {
        string playerName = "Luis";
        int level = 5;
        double health = 92.5;
        bool isAlive = true;

        Console.WriteLine(
            $"Player: {playerName}, Level: {level}, Health: {health}, Alive: {isAlive}"
        );
    }
}
