using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Triqui;
namespace DefinityTriqui
{
    public partial class Form1 : Form
    {
        triqui TriquiMulti;
        IAtriqui IAjuego;
        public Form1()
        {
            InitializeComponent();

            TriquiMulti = new triqui();
            IAjuego = new IAtriqui();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TriquiMulti.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            IAjuego.ShowDialog();
        }
    }
}
