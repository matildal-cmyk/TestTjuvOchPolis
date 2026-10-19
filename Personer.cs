using System;
using System.Collections.Generic;
using System.Text;

namespace TestTjuvOchPolis
{
    internal class Personer
    {
        public string Name { get; set; }
        public int[,] Position { get; set; }
        public int Direction { get; set; }
        public List<string> Inventory = new List<string>();
        public Personer(string name, int platsX, int platsY, int direction)
        {
            Name = name;
            Position = new int[platsX, platsY];
            Direction = direction;
        }
        public virtual void Utskrift()
            {
            Console.WriteLine("Okända personer hälsar på varandra"); 
            }
        
    }
    class Tjuv : Personer
    {
        public string Stöldgods { get; set; }
        public Tjuv(string name,int platsX, int platsY, int direction,string stöldgods):base (name, platsX,platsY, direction) 
        {
            Stöldgods = stöldgods;
        }
        //public override void Move()
        //{
        //}
    }
    class Polis:Personer
    {
        public string Beslagtaget { get; set; }
        public Polis(string name, int platsX,int platsY, int direction,string beslagtaget) : base(name,platsX,platsY,direction)
        {
            Beslagtaget = beslagtaget;
        }

    }
    class Medborgare:Personer
    {
        public string Tillhörigheter { get; set; }
        public Medborgare(string name, int platsX,int platsY, int direction,string tillhörigheter) : base(name,platsX,platsY,direction)
        {
            Tillhörigheter = tillhörigheter;
        }
    }
}
