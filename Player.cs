// Author : Webster B
// Date : 2/13/2025
// Purpose : This class is used to create a player object that will be used in the game. 
// The player object will have a name, score, and lives left. The player object will be used 
// to keep track of the player's progress in the game.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5Lab
{
    internal class Player
    {
        // Fields to store player's name, score, and remaining lives
        private string name;
        private int score;
        private int livesLeft;

        // Default constructor - initializes with default values
        public Player()
        {
            name = "Unknown"; // Default name if none provided
            score = 0; // Initial score is zero
            livesLeft = 0; // Default lives count
        }

        // Constructor that accepts a name
        public Player(string name)
        {
            this.name = name; // Assigns provided name
            score = 0; // Initializes score to zero
            livesLeft = 0; // Initializes lives to zero
        }

        // Constructor that accepts a name and starting lives
        public Player(string name, int startingLives)
        {
            this.name = name; // Assigns provided name
            this.livesLeft = startingLives; // Sets the initial lives
            score = 0; // Initializes score to zero
        }

        // Method to retrieve the current score
        public int GetScore()
        {
            return score;
        }

        // Method to add points to the player's score
        public void AddPoints(int totalPoints)
        {
            score += totalPoints; // Increases the score by the specified amount
        }

        // Method to decrease lives when the player dies
        public void Kill()
        {
            // Ensures that lives do not go negative
            if (livesLeft > 0)
            {
                livesLeft--; // Decrements the lives count
            }
        }

        // Method to retrieve the number of lives left
        public int GetLivesLeft()
        {
            return livesLeft;
        }

        // Method to retrieve the player's name
        public string GetName()
        {
            return name;
        }

        // Method to update the player's name
        public void SetName(string newName)
        {
            name = newName;
        }

        // Method to reset the player's score to zero
        public void ResetScore()
        {
            score = 0;
        }

        // Method to reset the player's lives to a specified value
        public void ResetLives(int newLives)
        {
            livesLeft = newLives;
        }

    } //end class
} //end namespace
