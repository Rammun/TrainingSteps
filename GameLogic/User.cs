using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public enum Race { Human, Magic }

    public class User
    {
        string name;
        Race race;

        public User(string name, Race race)
        {
            this.name = name;
            this.race = race;
        }
        public string Name { get { return name; } }
        public Race Race { get { return race; } }
    }
}
