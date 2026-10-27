using Informatica_Minecraft_Verifica_Pratica.Models.Enumerable;
using Informatica_Minecraft_Verifica_Pratica.Models.Interface;

namespace Informatica_Minecraft_Verifica_Pratica.Models
{
    public class BlockItem : Item
    {
        public bool IsStackable { get; set; }
        public float Hardness { get; set; }
        public BlockItem (string id, string name, int value, Rarity rarity, bool isStackable, float hardness): base()
        {
            Id = id;
            Name = name;
            Value = value;
            Rarity = rarity;
            IsStackable = isStackable;
            Hardness = hardness;
        }
        
        public override string GetDetails()
            {
                return base.GetDetails() + $", IsStackable: {IsStackable}, Hardness: {Hardness}";
            }
    }
}