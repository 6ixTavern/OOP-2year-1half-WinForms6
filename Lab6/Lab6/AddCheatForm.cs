using System;
using System.Windows.Forms;

namespace Lab6
{
    public partial class AddCheatForm : Form
    {
        public Cheat newCheat; 
        public AddCheatForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newCheat = new Cheat();
            newCheat.Name = textBox1.Text;
            newCheat.Version = (int) numericUpDown1.Value;
            newCheat.Author = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
