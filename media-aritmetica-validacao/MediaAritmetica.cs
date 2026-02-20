using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_aritmetica_validacao
{
    class MediaAritmetica
    {
        private string n1;
        private string n2;
        private string n3;  
        private string n4;

        public void setN1(string _n1) { n1 = _n1; }
        public String getN1() { return n1; }

        public void setN2(string _n2) { n2 = _n2; }
        public String getN2() { return n2; }
        public void setN3(string _n3) { n3 = _n3; }
        public String getN3() { return n3; }
        public void setN4(string _n4) { n4 = _n4; }
        public String getN4() { return n4; }

        public String getMediaAritmetica()
        {
            return ((float.Parse(n1) + float.Parse(n2) + float.Parse(n3) + float.Parse(n4)) / 4).ToString();
        }

    }
}
