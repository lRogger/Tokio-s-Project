using Datos;
using Individual.Visual;
using System.Data;

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

        private async void rjButton1_Click(object sender, EventArgs e)
        {
            if(tbPwdAnt.Texts != "" && tbPwdNew.Texts != "" && tbPwdRep.Texts != "")
            {
                if (BCrypt.Net.BCrypt.Verify(tbPwdAnt.Texts, dsCuenta.Tables[0].Rows[0]["Password"].ToString()))
                {
                    if(tbPwdNew.Texts == tbPwdRep.Texts)
                    {
                        DataBase db = new DataBase();
                        
                        await Task.Run(() => db.instruccionDB("UPDATE Personas SET Password = '" +
                            BCrypt.Net.BCrypt.HashPassword(tbPwdNew.Texts.Trim())+
                            "' WHERE Cedula = '" + dsCuenta.Tables[0].Rows[0]["Cedula"].ToString() + "'"));
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
