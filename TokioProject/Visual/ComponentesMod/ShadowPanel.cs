using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GUIs.Visual.ComponentesMod
{
    internal class ShadowPanel : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Dibujar el borde sombreado
            Rectangle shadowBounds = new Rectangle(0, 0, Width, Height);
            Color shadowColor = Color.Black; // Color de la sombra
            int shadowWidth = 20; // Ancho de la sombra
            ControlPaint.DrawBorder(e.Graphics, shadowBounds,
                shadowColor, shadowWidth, ButtonBorderStyle.Solid,
                shadowColor, shadowWidth, ButtonBorderStyle.Solid,
                shadowColor, shadowWidth, ButtonBorderStyle.Solid,
                shadowColor, shadowWidth, ButtonBorderStyle.Solid);
        }
    }
}
