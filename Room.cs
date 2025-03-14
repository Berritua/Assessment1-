namespace DungeonExplorer
{
    public class Room
    {
        // Properties to store room details
        private string description;
        private string item;

        // Constructor to initialize room with a description and item
        public Room(string description, string item)
        {
            this.description = description;
            Item = item;
        }

        public string Item { get; private set; }

        // Method to display the description of the room
        public string GetDescription()
        {
            if (!string.IsNullOrEmpty(Item))
            {
                return $"{description} You see a {Item} here.";
            }
            return description;
        }

        public string PickUpItem()
        {
            if (!string.IsNullOrEmpty(Item))
                // Returns true if there's an item in the room
            {
                string pickedItem = Item;
                Item = null;
                return $"You picked up a {pickedItem}.";
            }
            else
            {
                return "There is nothing to pick up.";
            }
        }

    }
}