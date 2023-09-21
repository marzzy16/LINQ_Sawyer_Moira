using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Sawyer_Moira
{
    internal class Game
    {
        // A propertie with an automatic getter, called "Title" of string type.
        public string Title { get; }

        // A propertie with an automatic getter, called "Esrb" of char type.
        public char Esrb { get; }

        // A propertie with an automatic getter, called "Genre" of string type.
        public string Genre { get; }

        // A constructor that passes 3 parameters, title, esrb, and genre.
        public Game(string titleParam, char esrbParam, string genreParam)
        {
            // Assigns each parameter to the corresponding property.
            Title = titleParam;
            Esrb = esrbParam; 
            Genre = genreParam;
        }

    }
}
