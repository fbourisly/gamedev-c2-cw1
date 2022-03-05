using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string characterName = "crash";
            string superPower1 = "flying";
            string superPower2 = "night vision";
            int age = 9;
            double speed = 70.5;
            Console.WriteLine("My name is {0} , My super Powers are {1} , {2}, i'm {3} , My speed is {4} ", characterName, superPower1, superPower2, age, speed);

            //Console.WriteLine("My name is {0} , My super Powers are {1} , {2}, i'm {3} , My speed is {4} ",characterName, superPower1, superPower2, age, speed);
        }
    }
}
