using Data;
using Microsoft.Identity.Client;
using System;
using System.Windows.Forms;

namespace AccesoDatos
{
    public partial class Form1 : Form
    {
        // Instancia de la clase SqlClient
        private SqlClient sqlClient = new SqlClient();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true; // Generación automática de columnas
            ToggleTextBoxes(false); // Desactiva las TextBox al inicio
            LoadDataIntoPanel();    // Carga los datos al iniciar
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes agregar la lógica del evento
        }

        // Método para alternar la habilitación de las TextBox
        private void ToggleTextBoxes(bool enabled)
        {
            txtboxNombre.Enabled = enabled;
            txtboxApellido.Enabled = enabled;
            dateTimePicker1.Enabled = enabled;
            txtboxDireccion.Enabled = enabled;
            txtboxEmail.Enabled = enabled;
            txtboxTelefono.Enabled = enabled;
            comboBoxGenero.Enabled = enabled;
            comboBoxCivil.Enabled = enabled;
        }

        // Método para limpiar las TextBox
        private void ClearTextBoxes()
        {
            txtboxNombre.Clear();
            txtboxApellido.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txtboxDireccion.Clear();
            txtboxEmail.Clear();
            txtboxTelefono.Clear();
            comboBoxGenero.SelectedIndex = -1; // Limpiar selección
            comboBoxCivil.SelectedIndex = -1;  // Limpiar selección
        }

        // Cargar los datos en el DataGridView
        private void LoadDataIntoPanel()
        {
            try
            {
                var dataTable = sqlClient.GetAllContacts();
                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No se encontraron contactos.");
                    dataGridView1.DataSource = null; // Si no hay registros, limpia el DataGridView
                }
                dataGridView1.Refresh(); // Refresca el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Inserta un nuevo contacto
                sqlClient.InsertContact(
                    txtboxNombre.Text,
                    txtboxApellido.Text,
                    dateTimePicker1.Value,
                    txtboxDireccion.Text,
                    comboBoxGenero.SelectedItem?.ToString() ?? "",
                    comboBoxCivil.SelectedItem?.ToString() ?? "",
                    txtboxTelefono.Text,
                    txtboxTelefono.Text,  // Suponiendo que Movil y Telefono son iguales aquí
                    txtboxEmail.Text
                );

                MessageBox.Show("Registro agregado");
                ClearTextBoxes();       // Limpia los campos después de insertar
                ToggleTextBoxes(false); // Desactiva los campos tras la inserción
                LoadDataIntoPanel();     // Recarga los datos en el panel
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón Buscar presionado");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();       // Limpia el contenido de las TextBox
            ToggleTextBoxes(true);  // Habilita las TextBox
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();       // Limpia los campos
            ToggleTextBoxes(false); // Desactiva los TextBoxes
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Carga los datos seleccionados en las TextBox
                txtboxNombre.Text = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtboxApellido.Text = dataGridView1.SelectedRows[0].Cells["Apellido"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["FechaNacimiento"].Value);
                txtboxDireccion.Text = dataGridView1.SelectedRows[0].Cells["Direccion"].Value.ToString();
                txtboxEmail.Text = dataGridView1.SelectedRows[0].Cells["CorreoElectronico"].Value.ToString();
                txtboxTelefono.Text = dataGridView1.SelectedRows[0].Cells["Telefono"].Value.ToString();
                comboBoxGenero.SelectedItem = dataGridView1.SelectedRows[0].Cells["Genero"].Value.ToString();
                comboBoxCivil.SelectedItem = dataGridView1.SelectedRows[0].Cells["EstadoCivil"].Value.ToString();

                ToggleTextBoxes(true); // Habilita las TextBox para modificar
            }
            else
            {
                MessageBox.Show("Por favor seleccione un registro para modificar.");
            }
        }

        private void btnAceptarModificacion_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Crea un nuevo objeto con los datos modificados
                var contact = new Contact
                {
                    Id = selectedId,
                    Nombre = txtboxNombre.Text,
                    Apellido = txtboxApellido.Text,
                    FechaNacimiento = dateTimePicker1.Value,
                    Direccion = txtboxDireccion.Text,
                    CorreoElectronico = txtboxEmail.Text,
                    Telefono = txtboxTelefono.Text,
                    Genero = comboBoxGenero.SelectedItem?.ToString() ?? "",
                    EstadoCivil = comboBoxCivil.SelectedItem?.ToString() ?? ""
                };

                try
                {
                    // Llama a la función para actualizar el registro
                    sqlClient.UpdateContact(contact);
                    MessageBox.Show("Registro modificado correctamente.");
                    ClearTextBoxes();       // Limpia los campos después de la modificación
                    ToggleTextBoxes(false); // Desactiva los campos tras la modificación
                    LoadDataIntoPanel();     // Recarga el DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el registro: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                try
                {
                    // Llama a la función para eliminar el registro
                    sqlClient.DeleteContact(selectedId);
                    MessageBox.Show("Registro eliminado correctamente.");
                    ClearTextBoxes();       // Limpia los campos después de eliminar
                    ToggleTextBoxes(false); // Desactiva los campos tras la eliminación
                    LoadDataIntoPanel();     // Recarga el DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un registro para eliminar.");
            }

            


        }
    }
}