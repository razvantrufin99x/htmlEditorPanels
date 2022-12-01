using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace htmlEditorPanels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "<html>";
             s += "\r\n";
             s += "<head><title></title></head>";
             s += "\r\n";
             s += "<body>";
             s += "\r\n";
             s += "<h1>Titlu principal</h1>";
             s += "\r\n";
             s += "<h2>Titlu secundar</h2>";
             s += "\r\n";
             s += "<b>Capitolul 1.</b><br>";
             s += "\r\n";
             s += "</body>";
             s += "\r\n";
             s += "</html>";

            //textBox1.Text = s;

            webBrowser1.DocumentText = textBox1.Text;

           
        }

        public void addTAGtoText(string s)
        {
            textBox1.Text+= s;
            textBox1.Refresh();
        }

        private void populateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                webBrowser1.DocumentText = textBox1.Text;
        }

       

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            webBrowser1.DocumentText = textBox1.Text;
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible != true)
            {
                listBox1.Visible = true;
            }
            else
            {
                listBox1.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            addTAGtoText(listBox1.SelectedItem.ToString());
            listBox1.Visible = false;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox1.DeselectAll();
        }

       
      

       
    }
}
