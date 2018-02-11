using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMVC.Controller
{
    class control
    {
        View.User us=null;
        public control(View.User user) {
            this.us = user;
            us.button1.Click += new EventHandler(cargardatos);
        }
        public void cargardatos(object sender, EventArgs e) {
            var val = us.textBox1.Text;
            var val2 = us.textBox2.Text;
            us.label3.Text = Convert.ToString(int.Parse(val) * int.Parse(val2));
        }
    }
}
