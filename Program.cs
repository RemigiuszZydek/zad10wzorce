using System;
using System.Collections.Generic;

public class Game
{
    private List<Player> players = new List<Player>();

    public void AddPlayer(Player player)
    {
        players.Add(player);
    }

    public void RemovePlayer(Player player)
    {
        players.Remove(player);
    }

    public void UpdateScore(Player player, int score)
    {
        player.Update(score);
    }
}

public class Player
{
    public string Name { get; }
    public int Score { get; private set; }

    public Player(string name)
    {
        Name = name;
        Score = 0;
    }

    public void Update(int score)
    {
        Score = score;
        Console.WriteLine($"Gracz {Name} - Aktualny wynik: {Score}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        
       
        Player player1 = new Player("Gracz1");
        Player player2 = new Player("Gracz2");

      
        game.AddPlayer(player1);
        game.AddPlayer(player2);

       
        game.UpdateScore(player1, 10);
        game.UpdateScore(player2, 15);
    }
}