﻿using Chinook.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook.UI.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var da = new ArtistDA();
            var filtro = $"{txtBusquedaNombre.Text.Trim()}%";

            //var result = da.GetArtists(filtro);
            var result = da.GetArtisWithSP(filtro);
            dgvBuscar.DataSource = result;
            dgvBuscar.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
