using Datos;
using Entidades;
using Individual.Visual;
using System.Data;

namespace TokiosProject.Visual
{
    

    public partial class ChangePwd : Form
    {
        private int posX = 0, posY = 0;
        private Persona sesion;
        

        public ChangePwd(Persona sesion)
        {
            InitializeComponent();
            this.sesion = sesion;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if(tbPwdAnt.Texts != "" && tbPwdNew.Texts != "" && tbPwdRep.Texts != "")
            {
                if (BCrypt.Net.BCrypt.Verify(tbPwdAnt.Texts, sesion.Password))
                {
                    if(tbPwdNew.Texts == tbPwdRep.Texts)
                    {
                        DataBase db = new DataBase();
                        
                        db.instruccionDB("UPDATE Personas SET Password = '" +
                            BCrypt.Net.BCrypt.HashPassword(tbPwdNew.Texts.Trim())+
                            "' WHERE Cedula = '" + sesion.Cedula + "'");
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
