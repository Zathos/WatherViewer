﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherViewer
{
    public partial class WeatherViewerForm : Form
    {
        public WeatherViewerForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO show about dialog box
            MessageBox.Show("Dev 0.0.0.1", "About Weather Viewer", MessageBoxButtons.OK);
        }
    }
}
