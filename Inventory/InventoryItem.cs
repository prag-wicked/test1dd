namespace Inventory
{
    // This is for deveopt branch
    public struct InventoryItem
    {
        public Color Color { get; private set; }
        public string Description { get; private set; }

        public InventoryItem(Color color, string description)
        {
            Color = color;
            Description = description;
        }
        public bool IsRed()
        {
            return Color == Color.Red;
        }
    }
}
