﻿using Datos;
using Entidades;
using Individual.Visual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIs.Visual
{
    public partial class RegistroHistorial : Form
    {

        private List<Registros> listaRegistros;

        public RegistroHistorial()
        {
            InitializeComponent();
            listaRegistros= new List<Registros>();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress= true;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private async void CargarTabla()
        {
            try
            {
                btnRefrescar.Enabled = false;


                listaRegistros = await new DBRegistros().LeerRegistros();

                btnRefrescar.Enabled = true;



                registrosDGV.Rows.Clear();

                for (int i = 0; i < listaRegistros.Count; i++)
                {
                    registrosDGV.Rows.Add(listaRegistros[i].Id, listaRegistros[i].Fecha,
                        listaRegistros[i].Usuario.Nombre, listaRegistros[i].Producto.Nombre,
                        listaRegistros[i].Descripcion, listaRegistros[i].Cantidad);

                }
            }

            catch (Exception ex)
            {
                new Emergente("advertencia", "ERROR", "Ha ocurrido un error al conectar con la base de datos\n " +
                     ex.Message).ShowDialog();
            }
        }
    }
}