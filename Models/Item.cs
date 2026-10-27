using Informatica_Minecraft_Verifica_Pratica.Models.Enumerable;

namespace Informatica_Minecraft_Verifica_Prativa.Models
{
    public abstract class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public Rarity Rarity { get; set; }

        public Item(string id, string name, int value, Rarity rarity)
        {
            Id = id;
            Name = name;
            Value = value;
            Rarity = rarity;
        }

        public abstract string GetDetails();
    }
}