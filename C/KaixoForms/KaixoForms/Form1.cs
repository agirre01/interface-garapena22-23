﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaixoDII;

namespace KaixoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //Objetuak instantziaturik(ez estatikoa)
            //Kaixo kaixo = new Kaixo();
            //MessageBox.Show(kaixo.MezuaIkusi());

            MessageBox.Show(Kaixo.MezuaIkusi());
        }
    }
}
