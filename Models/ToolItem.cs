using System;
using System.ComponentModel;
using Informatica_Minecraft_Verifica_Pratica.Models.Interface;
using Informatica_Minecraft_Verifica_Prativa.Models.Enumerable;

namespace Informatica_Minecraft_Verifica_Pratica.Models
{
    public class ToolItem : Item, ICraftable
    {
        public int Durability { get; set; }
        public Tooltype ToolType { get; set; } 
        
        public ToolItem(int durability, int toolType): base()
        {
            Durability = durability;
            ToolType = (Tooltype)toolType;
        }

        public void Craft()
        {
            if (CanCraft())
            {
                if (Durability >= 100)
                {
                    Durability -= 100;
                    Console.WriteLine($"Craftato {Name}, Durabilità rimasta: {Durability}");
                }
                Durability = 0;
                Console.WriteLine($"Craftato {Name}, Durabilità rimasta: {Durability}");
            }
            else
            {
                Console.WriteLine($"Non puoi craftare {Name}, Durabilità insufficiente o tipo di strumento non valido.");
            }
        }

        public bool CanCraft()
        {
            if(Durability > 0 && ToolType == Tooltype.Pickaxe)
            {
                return true;
            }
            return false;
        }
    }
}