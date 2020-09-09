using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Attendee a1 = new Attendee(100, "Nepe", "Liam", "Rotorua Boys High School", 9);
            Attendee a2 = new Attendee(99, "Gage", "Rikirangi", "Rotorua Boys High School", 10);

            Console.WriteLine(a1.ToString());
            Console.WriteLine(a2);

            a1.Firstname = "Darius";
            a1.Surname = "Apanui-Nepe";
            a2.School = "Omaio High";
            a2.YearLevel = 13;
            a2.Register();

            Console.WriteLine(a1.ToString());
            Console.WriteLine(a2);
        }
    }
}
