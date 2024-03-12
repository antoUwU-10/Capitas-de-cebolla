using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static MaterialDesignThemes.Wpf.Theme;

namespace InterfazWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dgUsuarios.ItemsSource = ModeloNegocios.users.get();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Datoss.Usuarios nuevoUsuario = new Datoss.Usuarios
            {
                Nombre = txtAgregarNombre.Text,
                Estado = txtAgregarEstado.Text,
                Apellido = txtAgregarApellido.Text,
                Email = txtAgregarEmail.Text,
                Contraseña = txtAgregarContraseña.Text,
                FechaRegistro = DateTime.Now

            };


            ModeloNegocios.users.insert(nuevoUsuario);

            dgUsuarios.ItemsSource = ModeloNegocios.users.get();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ModeloNegocios.users.deleteByName(txtBorrasNombre.Text);

            dgUsuarios.ItemsSource = ModeloNegocios.users.get();
        }


       
            private void dgUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                if (dgUsuarios.SelectedItem != null && dgUsuarios.SelectedItem is Datoss.Usuarios)
                {
                    Datoss.Usuarios usuario = (Datoss.Usuarios)dgUsuarios.SelectedItem;

                    // Asigna los datos a tus TextBox
                    txtEditarNombre.Text = usuario.Nombre;
                    txtEditarApellido.Text = usuario.Apellido;
                    txtEditarEstado.Text = usuario.Estado;
                    txtEditarEmail.Text = usuario.Email;
                    txtEditarContraseña.Text = usuario.Contraseña;
                }
            }




        private int ObtenerIdUsuarioSeleccionado()
        {
            if (dgUsuarios.SelectedItem != null && dgUsuarios.SelectedItem is Datoss.Usuarios)
            {
                Datoss.Usuarios usuario = (Datoss.Usuarios)dgUsuarios.SelectedItem;

                // Obtén el ID del usuario seleccionado
                int userId = usuario.ID; // Ajusta el nombre de la propiedad ID según tu modelo de datos
                return userId;
            }

            // Si no hay filas seleccionadas o algo salió mal, devuelve un valor predeterminado o maneja el caso según tus necesidades
            return -1;
        }



        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Datoss.Usuarios usuarioEditar = new Datoss.Usuarios
            {
                ID = ObtenerIdUsuarioSeleccionado(), // Reemplaza esto con el método que obtiene el ID seleccionado
                Nombre = txtEditarNombre.Text,
                Apellido = txtEditarApellido.Text,
                Estado = txtEditarEstado.Text,
                Email = txtEditarEmail.Text,
                Contraseña = txtEditarContraseña.Text
            };

            // Llama a la función update para aplicar los cambios en la base de datos
            ModeloNegocios.users.update(usuarioEditar);

            dgUsuarios.ItemsSource = ModeloNegocios.users.get();
        }

       
    }
}