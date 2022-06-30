﻿using System;
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
        public ObservableCollection<Osoba> ListaOsób { get; set; } = new ObservableCollection<Osoba>(new Osoba[]{
            new Osoba(){
                Imię="Marian",
                Nazwisko="Sosnowski",
                DataUrodzenia=DateTime.Parse("1.1.1900"),
                DataŚmierci=DateTime.Parse("1.1.1950"),
            },
            new Osoba(){Imię="Jan", Nazwisko="Sosnowski", DataUrodzenia=DateTime.Parse("1.1.1990")},
            new Osoba(){Imię="Adam",Nazwisko="Dąbrowski", DataUrodzenia=DateTime.Parse("2.2.1995")},
            new Osoba(){Imię="Anna",Nazwisko="Wiśniewska", DataUrodzenia=DateTime.Parse("3.3.2000")},
            new Osoba(){Imię="Julia",Nazwisko="Jabłońska", DataUrodzenia=DateTime.Parse("4.4.2005")}
        });

        internal Osoba NowaOsoba()
        {
            Osoba nowa = new Osoba();
            ListaOsób.Add(nowa);
            return nowa;
        }
    }
}
