﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_midterm_9A713001.Properties;

namespace WP_2020_01_midterm_9A713001
{
    public partial class frmGame : Form
    {
        List<Image> list = new List<Image>();

        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            list.Add(Resources._001);
            list.Add(Resources._002);
            list.Add(Resources._003);
            list.Add(Resources._004);
            list.Add(Resources._005);
            list.Add(Resources._006);
            list.Add(Resources._10);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int index = 6;//模擬隨機產生 一個值;
            picResult.Image = list[index];
        }
    }
}
