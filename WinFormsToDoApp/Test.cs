using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsToDoApp
{
    public class Test
    {

        public int Cislo { get; set; }
        public string Jmeno { get; set; }

        public Test()
        {
            
        }
        public Test(string jmeno,int cislo)   
        {
            this.Cislo = cislo;
            this.Jmeno = jmeno;
        }



    }
}
