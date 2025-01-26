using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace mazeCreator
{
    internal class Fichas
    {
        string name;
        int movimiento;
        string trampa;
        string habilidad;
        public Fichas(string name, int movimiento,string trampa,string habilidad) {
            // El escurridizo
            this.name = name;
            this.movimiento=movimiento;
            this.trampa=trampa;
            this.habilidad=habilidad;
        }
        
    }
}
