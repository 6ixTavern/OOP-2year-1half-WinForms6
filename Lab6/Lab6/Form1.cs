using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        MyСontainer <Cheat> cheats = new MyСontainer<Cheat>();
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void addNewCheatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddCheatForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                cheats.AddLast(form.newCheat);
            }
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cheatLinkedList.Items.Clear();
            foreach (var car in cheats)
            {
                cheatLinkedList.Items.Add(car);
            }
            Invalidate();
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = int.Parse(maskedTextBox1.Text);
            var result = new MyСontainer<Cheat>();
            if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == ">")
            {
                result = cheats.FindAll(t => t.Version > value);
            }
            if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "<")
            {
                result = cheats.FindAll(t => t.Version < value);
            }
            if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "=")
            {
                result = cheats.FindAll(t => t.Version == value);
            }
            cheatLinkedList.Items.Clear();
            foreach (var car in result)
            {
                cheatLinkedList.Items.Add(car);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadCheatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] file = File.ReadAllLines("input.txt");
            for (int i = 0; i < file.Length; i++)
            {
                string[] s = file[i].Split(' ');
                if (s.Length == 3)
                {
                    if (int.TryParse(s[2], out int number))
                    {
                        Cheat cht = new Cheat(s[0], s[1], int.Parse(s[2]));
                        cheats.AddLast(cht);
                    }
                }
            }
        }
    }
}