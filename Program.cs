// Author: Webster B
// Date: 2/13/2025
// Purpose: This class is used to create a player object that will be used in the game.

using Module5Lab;

// Create a new player with one life and add points to the player's score
Player player = new Player("Kirby", 1); // Initialize player with name "Kirby" and 1 life
player.AddPoints(100); // Add 100 points to the player's score

// Display the player's current score and remaining lives
Console.WriteLine("Welcome to the game! Your score is: " + player.GetScore() +
    " You have " + player.GetLivesLeft() + " lives left.");

// Kill off the player's character
player.Kill(); // Simulate the player's death

// Notify the player that their character was killed
Console.WriteLine("An orc attacks you. Sorry, you were killed. You have " 
    + player.GetLivesLeft() + " lives left!");

// Create a super player with special abilities
SuperPlayer superPlayer = new SuperPlayer(); // Initialize a new super player
superPlayer.AddPoints(200); // Add 200 points to the super player's score
superPlayer.Fly(); // Demonstrate the additional ability to fly

// Display the super player's score and remaining lives
Console.WriteLine($"SuperPlayer score: {superPlayer.GetScore()}, Lives left: {superPlayer.GetLivesLeft()}");
