using MinecraftManager.Models.Enumerable;

namespace MinecraftManager.Models
{
    public class BlockItem : Item
    {
        public bool IsStackable { get; set; }
        public float Hardness { get; set; }

        public BlockItem(string id, string name, int value, Rarity rarity, bool isStackable, float hardness)
            : base(id, name, value, rarity)
        {
            IsStackable = isStackable;
            Hardness = hardness;
        }

        public override string GetDetails()
        {
            string stack = IsStackable ? "Sì" : "No";
            return "[Block] Rarità: " + Rarity + " | Valore: " + Value +
                   " | Stackabile: " + stack + " | Durezza: " + Hardness;
        }
    }
}
