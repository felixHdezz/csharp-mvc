using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMVC.Model
{
    class Model
    {
        private int _val1;
        private int _val2;
        public Model(int val1, int val2) {
            _v1 = val1;
            _v2 = val2;
        }
        public int _v1 {
            get { return _val1; }
            set { _val1 = value; }
        }
        public int _v2 {
            get { return _val2; }
            set { _val2 = value; }
        } 
    }
}
