﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Create_Menu
{
    public partial class FormCreateMenu : Form
    {
        MenuStrip menu;
        public FormCreateMenu()
        {
            InitializeComponent();
        }



        private void btnAddTopLevelMenu_Click(object sender, EventArgs e)
        {
            menu = new MenuStrip();
        }

        private void FormCreateMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
