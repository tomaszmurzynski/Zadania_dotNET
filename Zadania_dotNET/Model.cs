using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_dotNET
{
    class Model
    {
        public bool IsNewElement = false;
        public ObservableCollection<Film> ListaFilmow { get; set; } = new ObservableCollection<Film>(new Film[]{
            new Film(){Tytul="Czarny telefon",Rezyser="Scott Derrickson",Wydawca="USA",Nosnik="DVD",DataWydania=DateTime.Parse("24.06.2022")},
            new Film(){Tytul="Yang",Rezyser="Kogonada",Wydawca="USA",Nosnik="DVD",DataWydania=DateTime.Parse("1.07.2022")},
            new Film(){Tytul="Hocus Pocus 2",Rezyser="Adam Shankman",Wydawca="USA",Nosnik="DVD",DataWydania=DateTime.Parse("15.09.2022")},
            new Film(){Tytul="Rzut życia",Rezyser="Jeremiah Zagar",Wydawca="Wydawca1",Nosnik="DVD",DataWydania=DateTime.Parse("8.06.2022")}
        });

        internal Film NowyElement()
        {
            if (!IsNewElement)
            {
                return new Film();
            }
            //Film nowy = new Film();
            //ListaFilmow.Add(nowy);
            return new Film();
        }
    }
}
