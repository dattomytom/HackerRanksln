using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanksln.SortingComparator
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Player(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }
        public override string ToString()
        {
            return string.Format("Name : {0}, Score {1}", Name, Score);
        }
    }
    public class Checker : IComparer<Player>
    {
        public int Compare(Player? x, Player? y)
        {
            //sort score desc
            if (x?.Score < y?.Score)
                return 1;
            else if (x?.Score > y?.Score)
                return -1;
            else //this case compare name and sort asc
            {
                int minLenght = Math.Min(x.Name.Length, y.Name.Length);
                for (int i = 0; i < minLenght; i++)
                {
                    var aChar = (x.Name.ToCharArray()[i]);
                    var bChar = (y.Name.ToCharArray()[i]);

                    if (aChar > bChar)
                        return 1;
                    else if (aChar < bChar)
                        return -1;
                }
                if (x.Name.Length > y.Name.Length)
                    return 1;
                else if (x.Name.Length < y.Name.Length)
                    return -1;
                else return 0;
            }
        }
    }
}
