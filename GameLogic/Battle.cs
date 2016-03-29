using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Battle
    {
        User user1;
        User user2;

        public Battle(User user1, User user2)
        {
            this.user1 = user1;
            this.user2 = user2;
        }

        public User User1 { get { return user1; } }
        public User User2 { get { return user2; } }
    }
}
