using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Visual.ComponentesMod
{
    //ESTA CLASE SE USA COMO UNA UTILIDAD PARA PODER USAR UN COMPONENTE MÁS BONITO
    //LA USAREMOS EN EL GRUPO PERO LOS CREDITOS SON DE -ARTAN ACADEMY- 
    public class PanelMod : Panel
    {
        //FIELDS
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;

        //CONSTRUCTOR
        public PanelMod()
        {
            BackColor = Color.White;
            ForeColor = Color.Black;
            Size = new Size(350, 200);

        }

        //PROPIEDADES
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }

        public float GradientAngle
        {
            get => gradientAngle;
            set { gradientAngle = value; Invalidate(); }
        }

        public Color GradientTopColor
        {
            get => gradientTopColor;
            set { gradientTopColor = value; Invalidate(); }
        }

        public Color GradientBottomColor
        {
            get => gradientBottomColor;
            set { gradientBottomColor = value; Invalidate(); }
        }

        //MÉTODOS PA USAR :3
        private GraphicsPath GetArtanPath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;

        }


        //METODOS SOBREESCRITOS
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Gradiente
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brushArtan = new LinearGradientBrush(ClientRectangle,
                gradientTopColor, gradientBottomColor, GradientAngle);
            Graphics graphicsArtan = e.Graphics;
            graphicsArtan.FillRectangle(brushArtan, ClientRectangle);

            //BorderRadius
            RectangleF rectangleF = new RectangleF(0, 0, Width, Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetArtanPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(Parent.BackColor, 2))
                {
                    Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);

                }
            }
            else Region = new Region(rectangleF);

        }

    }
}
