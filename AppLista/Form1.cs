namespace AppLista
{
    public partial class Form1 : Form
    {
        List<ListaBiblioteca> listaBiblioteca = new List<ListaBiblioteca>();

        public Form1()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text;
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            string genero = cmbGenero.SelectedItem.ToString();
            bool disponible = bool.Parse(cmbDisponible.SelectedItem.ToString());

            ListaBiblioteca nuevoLibro = new ListaBiblioteca(isbn, titulo, autor, genero, disponible);
            listaBiblioteca.Add(nuevoLibro);

            MostrarEnDataGridView();
            LimpiarFormulario();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lógica para consultar y mostrar un libro específico según el ISBN
            string isbnConsultar = txtISBN.Text;
            foreach (var libro in listaBiblioteca)
            {
                if (libro.ISBN == isbnConsultar)
                {
                    // Mostrar el libro consultado en el formulario
                    txtISBN.Text = libro.ISBN;
                    txtTitulo.Text = libro.Titulo;
                    txtAutor.Text = libro.Autor;
                    cmbGenero.SelectedItem = libro.Genero;
                    cmbDisponible.Text = libro.Disponible.ToString();
                    break;
                }
            }

        }

    

        private void MostrarEnDataGridView()
        {
            dgvLista.DataSource = null;
            dgvLista.DataSource = listaBiblioteca.ToArray();

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string isbnEliminar = txtISBN.Text;
            foreach (var libro in listaBiblioteca)
            {
                if (libro.ISBN == isbnEliminar)
                {
                    listaBiblioteca.Remove(libro);
                    break;
                }
            }

            // Mostrar en el DataGridView
            MostrarEnDataGridView();
        }

        private void LimpiarFormulario()
        {
            txtISBN.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtAutor.Text = string.Empty;
            cmbGenero.SelectedIndex = -1; // Establece el índice del ComboBox en -1 para deseleccionar cualquier elemento
            cmbDisponible.SelectedIndex = -1;
        }

    }
}