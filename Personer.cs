using System;
using System.Collections.Generic;
using System.Text;

namespace TestTjuvOchPolis
{
        internal class Personer
        {
            public string Name { get; set; }
            public int PlatsX { get; set; }
            public int PlatsY { get; set; }
            public int DirectionX { get; set; }
            public int DirectionY { get; set; }


            public Personer(string name, int platsX, int platsY, int directionX, int directionY)
            {
                Name = name;
                PlatsX = platsX;
                PlatsY = platsY;
                DirectionX = directionX;
                DirectionY = directionY;


            }
            public virtual void Move()
            {

            }

        }
        class Tjuv : Personer
        {
            public string Stöldgods { get; set; }
            public Tjuv(string name, int platsX, int platsY, int directionX, int directionY, string stöldgods) : base(name, platsX, platsY, directionX, directionY)
            {
                Stöldgods = stöldgods;
            }
            public override void Move()
            {
            }
        }
        class Polis : Personer
        {
            public string Beslagtaget { get; set; }
            public Polis(string name, int platsX, int platsY, int directionX, int directionY, string beslagtaget) : base(name, platsX, platsY, directionX, directionY)
            {
                Beslagtaget = beslagtaget;
            }

        }
        class Medborgare : Personer
        {
            public string Tillhörigheter { get; set; }
            public Medborgare(string name, int platsX, int platsY, int directionX, int directionY, string tillhörigheter) : base(name, platsX, platsY, directionX, directionY)
            {
                Tillhörigheter = tillhörigheter;
            }
        }
    }
