using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploMVC.View
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fecha = "";
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            fecha = dateTimePicker1.Value.Date.ToShortDateString();
            MessageBox.Show("La fecha actual es: "+fecha,"Mensaje desde el sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
