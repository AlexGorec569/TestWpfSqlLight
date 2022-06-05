using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Wpf2_SQL
{

    

    class Phone
    {

        public int id { get; set; }
        private string name;
        private int naber { get; set; }


        public string Name
        {

            get { return name; }
            set { name = value; }

        }

        public int Naber
        {
            get { return naber; }
            set { naber = value; }
        }


        public Phone() { }

        public Phone(int Nom, string name) {

            this.Name = name;
            this.Naber = Nom;


        }


    }
}
