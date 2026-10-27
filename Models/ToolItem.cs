using MinecraftManager.Models.Enumerable;
using MinecraftManager.Models.Interface;

namespace MinecraftManager.Models
{
    public class ToolItem : Item, ICraftable
    {
        public int Durability { get; set; }
        public ToolType ToolType { get; set; }

        public ToolItem(string id, string name, int value, Rarity rarity, int durability, ToolType toolType)
            : base(id, name, value, rarity)
        {
            Durability = durability;
            ToolType = toolType;
        }

        public override string GetDetails()
        {
            return "[Tool] " + ToolType + " | Rarità: " + Rarity +
                   " | Valore: " + Value + " | Durabilità: " + Durability;
        }

        
        public bool CanCraft()
        {
            return Durability >= 10;
        }

        
        public void Craft()
        {
            Durability = Durability - 10;
            Value = Value + 5;
        }
    }
}
