using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        // Properties to store player's name and health
        public string Name { get; private set; }
        public int Health { get; private set; }
        private List<string> inventory = new List<string>();

        // Constructor to initialize the player's name and health
        public Player(string name, int health)
        {
            Name = name;
            Health = health;
        }

        // Method to pick up an item and add it to the player's inventory
        public string PickUpItem(string item)
        {
            inventory.Add(item);  // add the item.
            return $"You picked up a {item}."; // Inform the player about the item picked up
        }
        
        // Method to display the player's inventory contents
        public string InventoryContents()
        {
            return string.Join(", ", inventory); // Return all items in the inventory as a comma-separated string
            
        }
        // Method to display the player's status: name, health, and inventory
        public void DisplayStatus()
        {
            Console.WriteLine($"Player: {Name}, Health: {Health}");
            Console.WriteLine("Inventory: " + (inventory.Count > 0 ? string.Join(", ", inventory) : "Empty"));
        }
    }
}