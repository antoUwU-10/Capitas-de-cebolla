using System.Windows.Forms;

namespace Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ModeloNegocios.users.get();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datoss.Usuarios nuevoUsuario = new Datoss.Usuarios
            {
                Nombre = textBox1.Text,
                Estado = textBox2.Text,
                Apellido = textBox3.Text,
                Email = textBox4.Text,
                Contraseña = textBox5.Text,
                FechaRegistro = DateTime.Now

            };


            ModeloNegocios.users.insert(nuevoUsuario);

            dataGridView1.DataSource = ModeloNegocios.users.get();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModeloNegocios.users.deleteByName(textBox6.Text);

            dataGridView1.DataSource = ModeloNegocios.users.get();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica si se hizo clic en una fila válida
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Obtén el ID del usuario desde la fila seleccionada
                int userId = Convert.ToInt32(row.Cells["ID"].Value);

                // Obtén el usuario desde la base de datos usando el ID
                Datoss.Usuarios usuario = ModeloNegocios.users.get().FirstOrDefault(u => u.ID == userId);


                // Asigna los datos a tus TextBox
                textBox7.Text = usuario.Nombre;
                textBox9.Text = usuario.Apellido;
                textBox8.Text = usuario.Estado;
                textBox10.Text = usuario.Email;
                textBox11.Text = usuario.Contraseña;
            }
        }

        private int ObtenerIdUsuarioSeleccionado()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MessageBox.Show("Cell selec!");
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                object cellValue = selectedRow.Cells["ID"].Value;
                Console.WriteLine($"Valor de la celda: {cellValue}");
                int userId = Convert.ToInt32(cellValue);

                return userId;
            }

            // Si no hay filas seleccionadas o algo salió mal, devuelve un valor predeterminado o maneja el caso según tus necesidades
            return -1;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Datoss.Usuarios usuarioEditar = new Datoss.Usuarios
            {
                ID = ObtenerIdUsuarioSeleccionado(), // Reemplaza esto con el método que obtiene el ID seleccionado
                Nombre = textBox7.Text,
                Apellido = textBox9.Text,
                Estado = textBox8.Text,
                Email = textBox10.Text,
                Contraseña = textBox11.Text
            };

            // Llama a la función update para aplicar los cambios en la base de datos
            ModeloNegocios.users.update(usuarioEditar);

            // Actualiza el DataGridView o cualquier otro control necesario
            dataGridView1.DataSource = ModeloNegocios.users.get();
        }

    }
}
