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
            this.name = "Nieznana Kategoria";
            id++;
        }

        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
            id++;
        }

        public Category(string name_)
        {
            this.name = name_;
            id++;
        }

        public Category(int id_, string name_, int[] underCetegory_)
        {
            this.id = id_;
            this.name = name_;
            this.underCategory = underCetegory_;
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

        public void ShowCategoryList()
        {
            foreach (var category in underCategory)
            {
 
            }
        }
    }
}
