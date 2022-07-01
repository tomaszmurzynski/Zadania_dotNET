using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_dotNET
{
    internal class Category
    {
        private int id = 0;
        private string name;
        public int[] underCategory = new int[5];
        public Category()
        {
            this.id = 0;
            this.name = "Nieznana Kategoria";
            id++;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
    }
}
