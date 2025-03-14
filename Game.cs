using System;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;
        private bool playing;

        public void Start()
        {
            // Starts the game and initiates the game loop
            Console.WriteLine("Welcome to Dungeon Explorer!");
            Console.Write("Enter your character's name: ");
            string playerName = Console.ReadLine();

            // Initialize player with name and default health
            player = new Player(name: playerName, health: 100);
            
            // Create a room with a description and an item
            currentRoom = new Room("A dark, creepy dungeon room with a flickering torch on the wall.", "sword");

            playing = true;

            while (playing)
            {
                Console.WriteLine("\n" + currentRoom.GetDescription());

                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("Type 'look' to see the room, 'pick up' to take an item, 'status' to check player, 'exit' to quit.");
                string input = Console.ReadLine().ToLower();

                ProcessCommand(input);
            }
        }

        private void ProcessCommand(string command)
        {
            // Logic for processing the commands (look, pick up, etc.)
            switch (command)
            {
                case "look":
                    Console.WriteLine(currentRoom.GetDescription());
                    break;
                case "pick up":
                    Console.WriteLine(player.PickUpItem(currentRoom.PickUpItem()));
                    break;
                case "status":
                    player.DisplayStatus();
                    break;
                case "exit":
                    playing = false;
                    Console.WriteLine("Thanks for playing! Goodbye.");
                    break;
                default:
                    Console.WriteLine("Invalid command. Try again.");
                    break;
            }
        }
    }
}