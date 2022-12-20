using Individual;
using Individual.Modelos;
using Individual.Visual;
using LibreriaGrupal;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokiosProject.Visual
{
    

    public partial class ChangePwd : Form
    {
        private DataSet dsCuenta;
        private int posX = 0, posY = 0;
        

public ChangePwd(DataSet ds)
        {
            InitializeComponent();
            dsCuenta = ds;
        }

        private void tbPwdAnt__TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPwdAnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private async void rjButton1_Click(object sender, EventArgs e)
        {
            if(tbPwdAnt.Texts != "" && tbPwdNew.Texts != "" && tbPwdRep.Texts != "")
            {
                if (BCrypt.Net.BCrypt.Verify(tbPwdAnt.Texts, dsCuenta.Tables[0].Rows[0]["password"].ToString()))
                {
                    if(tbPwdNew.Texts == tbPwdRep.Texts)
                    {
                        DataBase db = new DataBase();
                        
                        await Task.Run(() => db.instruccionDB("UPDATE personas SET password = '" +
                            BCrypt.Net.BCrypt.HashPassword(tbPwdNew.Texts.Trim())+
                            "' WHERE cedula = '" + dsCuenta.Tables[0].Rows[0]["cedula"].ToString() + "'"));
                        this.Close();

                        new Emergente("advertencia", "Hecho", "La contraseña se ha cambiado correctamente" +
                            ", los cambios se aplicarán en la siguiente sesión").ShowDialog();
                    }
                    else
                    {
                        new Emergente("advertencia", "Error", "Las contraseñas no coinciden").ShowDialog();
                    }
                }
                else
                {
                    new Emergente("advertencia", "Error", "La contraseña actual es incorrecta").ShowDialog();
                }
            }
            else
            {
                new Emergente("advertencia", "Error", "Hay campos vacíos!").ShowDialog();
            }
        }

        private void ChangePwd_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
