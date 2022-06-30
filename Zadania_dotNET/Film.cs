using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_dotNET
{
    public class Film : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        readonly static Dictionary<string, string[]> powiązaneWłaściwości = new Dictionary<string, string[]>()
        {
            ["Tytuł"] = new string[] { "TytulRezyser" },
            ["Rezyser"] = new string[] { "TytulRezyser" },

            ["Wydawca"] = new string[] { "Wydawca" },
            ["Nosnik"] = new string[] { "Nośnik" },

            ["DataWydania"] = new string[] { "Wydanie" },
        };
        public void OnPropertyChanged(
            [CallerMemberName] string właściwość = null,
            HashSet<string> załatwioneWłaściwości = null
            )
        {
            if (załatwioneWłaściwości == null)
                załatwioneWłaściwości = new HashSet<string>();

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(właściwość));
            załatwioneWłaściwości.Add(właściwość);

            if (powiązaneWłaściwości.ContainsKey(właściwość))
                foreach (string powiązanaWłaściwość in powiązaneWłaściwości[właściwość])
                    if (!załatwioneWłaściwości.Contains(powiązanaWłaściwość))
                        OnPropertyChanged(
                            powiązanaWłaściwość,
                            załatwioneWłaściwości
                            );
        }

        public static uint następneID = 0;

        public uint ID { get; } = następneID++;
        string
            tytul,
            rezyser,
            wydawca,
            nosnik
            ;
        DateTime?
            dataWydania
            ;

        public string TytulRezyser
        {
            get { return $"{Tytul} , {Rezyser}"; }
        }

        public string Wydawca
        {
            get => wydawca;
            set
            {
                wydawca = value;
                OnPropertyChanged();
            }
        }

        public string Nosnik
        {
            get => nosnik;
            set
            {
                nosnik = value;
                OnPropertyChanged();
            }
        }
        public string Tytul
        {
            get => tytul;
            set
            {
                tytul = value;
                OnPropertyChanged();
            }
        }
        public string Rezyser
        {
            get => rezyser;
            set
            {
                rezyser = value;
                OnPropertyChanged();
            }
        }

        public DateTime? DataWydania
        {
            get => dataWydania;
            set
            {
                dataWydania = value;
                OnPropertyChanged();
            }
        }
      
      
        public string Szczegóły => $"{TytulRezyser}";

       public override string ToString()
        {
            return TytulRezyser;
        }
    }
}
