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
        public ObservableCollection<Film> ListaFilmow { get; set; } = new ObservableCollection<Film>(new Film[]{
            new Film(){Tytul="Marian",Rezyser="A. Sosnowski",Wydawca="Wydawca1",Nosnik="DVD",DataWydania=DateTime.Parse("1.1.1900")},
            new Film(){Tytul="Marian",Rezyser="A. Sosnowski",Wydawca="Wydawca1",Nosnik="DVD",DataWydania=DateTime.Parse("1.1.1900")},
            new Film(){Tytul="Marian",Rezyser="A. Sosnowski",Wydawca="Wydawca1",Nosnik="DVD",DataWydania=DateTime.Parse("1.1.1900")},
            new Film(){Tytul="Marian",Rezyser="A. Sosnowski",Wydawca="Wydawca1",Nosnik="DVD",DataWydania=DateTime.Parse("1.1.1900")}
            //new Film(){Tytul="Jan", Rezyser="Sosnowski", DataUrodzenia=DateTime.Parse("1.1.1990")},
            //new Film(){Tytul="Adam",Rezyser="Dąbrowski", DataUrodzenia=DateTime.Parse("2.2.1995")},
            //new Film(){Tytul="Anna",Rezyser="Wiśniewska", DataUrodzenia=DateTime.Parse("3.3.2000")},
            //new Film(){Tytul="Julia",Rezyser="Jabłońska", DataUrodzenia=DateTime.Parse("4.4.2005")}
        });

        internal Film NowyFilm()
        {
            Film nowa = new Film();
            ListaFilmow.Add(nowa);
            return nowa;
        }
    }
}
