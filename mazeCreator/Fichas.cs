using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace mazeCreator
{
    public class Piece
    {
        string name;
        int player;
        string sym;
        int movBonus;
        string trap;
        string skill;
        public Piece(string name, int player, string sym, int movBonus, string trap, string skill)
        {
            this.name = name;
            this.sym = sym;
            this.movBonus = movBonus;
            this.trap = trap;
            this.skill = skill;
        }
        public string pieceSym
        {
            get { return sym; }
        }
        public int pieceMov
        {
            get { return pieceMov; }
        }
        //I'll add more as I go
    
    


    } 
}
 //????why what did i do???


