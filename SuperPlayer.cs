// Author: Webster B
// Date: 2/13/2025
// Purpose: SuperPlayer class that inherits from Player class and adds a Fly method

using System;

namespace Module5Lab
{
    // SuperPlayer class inherits from the Player class
    internal class SuperPlayer : Player
    {
        // Constructor to initialize the SuperPlayer with a name and lives
        public SuperPlayer() : base("SuperPlayer", 3) // Default 3 lives
        {
        }

        // Method to simulate flying for the SuperPlayer
        internal void Fly()
        {
            // Print a message indicating the SuperPlayer is flying
            Console.WriteLine($"{GetName()} is flying through the sky!");
        }

        // Nested class (optional) that also inherits from Player
        internal class SuperPlayerNested : Player
        {
            // Additional properties or methods specific to the nested SuperPlayer class
            public void Fly()
            {
                Console.WriteLine("SuperPlayerNested is flying!");
            }
        }
    }
}
