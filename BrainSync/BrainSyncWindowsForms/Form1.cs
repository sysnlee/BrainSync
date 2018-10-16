using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace BrainSyncWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var classes = Assembly.Load("System").GetTypes();
            foreach (var item in classes)
            {
                Console.WriteLine(item.Name);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
