using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Collectable : Displayable
    {
        public CollectionBoard Board { get; set; } = new CollectionBoard();
        public string Description { get; set; }

        public Collectable(string description)
        {
            Description = description;
        }

        public virtual void AddMe(List<Collectable> collection)
        {
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }

        public virtual void Display()
        {
        }
    }

}
