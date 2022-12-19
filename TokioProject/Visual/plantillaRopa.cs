namespace Individual.Visual
{
    public partial class plantillaRopa : UserControl
    {
        private int id = 0;
        private string descripcion = "Descripción de la ropa";

        public plantillaRopa()
        {
            InitializeComponent();
        }

        public int Id { get { return id; } set { id = value; } }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Image ImgRopa
        {
            get { return ImgRopa; }
            set { imagenRopa.Image = value; }
        }

        public string NombreRopa
        {
            get { return NombreRopa; }
            set { nombreRopa.Text = value; }
        }

        public string Categoria
        {
            get { return Categoria; }
            set { nombreRopa.Text = value; }
        }

        public int Stock
        {
            get { return Stock; }
            set { lblstock.Text = value.ToString(); }
        }
    }
}
