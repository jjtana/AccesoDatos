namespace AccesoDatos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            btnNuevo = new Button();
            PanelDatos = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblApellido = new Label();
            lblNacimiento = new Label();
            lblDireccion = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblGenero = new Label();
            lblEstadoCivil = new Label();
            txtboxNombre = new TextBox();
            lblNombre = new Label();
            txtboxApellido = new TextBox();
            txtboxDireccion = new TextBox();
            txtboxEmail = new TextBox();
            txtboxTelefono = new TextBox();
            comboBoxCivil = new ComboBox();
            comboBoxGenero = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btnEliminar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            flowLayoutPanel1.SuspendLayout();
            PanelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(24, 119, 242);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1236, 130);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(389, 32);
            label1.TabIndex = 0;
            label1.Text = "AGENDA ELECTRONICA | ITLA";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ActiveCaption;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Location = new Point(12, 136);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(96, 41);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // PanelDatos
            // 
            PanelDatos.BackColor = Color.Silver;
            PanelDatos.Controls.Add(dataGridView1);
            PanelDatos.Location = new Point(615, 136);
            PanelDatos.Name = "PanelDatos";
            PanelDatos.Size = new Size(609, 473);
            PanelDatos.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(606, 470);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(12, 233);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 43);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ActiveCaption;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(12, 321);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(96, 43);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(74, 572);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(183, 37);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.ActiveCaption;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Location = new Point(301, 572);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(187, 37);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // lblApellido
            // 
            lblApellido.Location = new Point(214, 299);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(100, 23);
            lblApellido.TabIndex = 16;
            // 
            // lblNacimiento
            // 
            lblNacimiento.Location = new Point(402, 363);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(100, 23);
            lblNacimiento.TabIndex = 15;
            // 
            // lblDireccion
            // 
            lblDireccion.Location = new Point(449, 406);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(100, 23);
            lblDireccion.TabIndex = 14;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(388, 406);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 13;
            // 
            // lblTelefono
            // 
            lblTelefono.Location = new Point(388, 386);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(100, 23);
            lblTelefono.TabIndex = 12;
            // 
            // lblGenero
            // 
            lblGenero.Location = new Point(458, 360);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(100, 23);
            lblGenero.TabIndex = 11;
            // 
            // lblEstadoCivil
            // 
            lblEstadoCivil.Location = new Point(411, 383);
            lblEstadoCivil.Name = "lblEstadoCivil";
            lblEstadoCivil.Size = new Size(100, 23);
            lblEstadoCivil.TabIndex = 10;
            // 
            // txtboxNombre
            // 
            txtboxNombre.Location = new Point(201, 137);
            txtboxNombre.Name = "txtboxNombre";
            txtboxNombre.Size = new Size(255, 23);
            txtboxNombre.TabIndex = 9;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(203, 299);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 23);
            lblNombre.TabIndex = 8;
            // 
            // txtboxApellido
            // 
            txtboxApellido.Location = new Point(219, 178);
            txtboxApellido.Name = "txtboxApellido";
            txtboxApellido.Size = new Size(237, 23);
            txtboxApellido.TabIndex = 7;
            // 
            // txtboxDireccion
            // 
            txtboxDireccion.Location = new Point(228, 270);
            txtboxDireccion.Name = "txtboxDireccion";
            txtboxDireccion.Size = new Size(228, 23);
            txtboxDireccion.TabIndex = 6;
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(192, 456);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(264, 23);
            txtboxEmail.TabIndex = 5;
            // 
            // txtboxTelefono
            // 
            txtboxTelefono.Location = new Point(219, 406);
            txtboxTelefono.Name = "txtboxTelefono";
            txtboxTelefono.Size = new Size(237, 23);
            txtboxTelefono.TabIndex = 4;
            // 
            // comboBoxCivil
            // 
            comboBoxCivil.Items.AddRange(new object[] { "Casado/a", "Soltero/a" });
            comboBoxCivil.Location = new Point(255, 357);
            comboBoxCivil.Name = "comboBoxCivil";
            comboBoxCivil.Size = new Size(121, 23);
            comboBoxCivil.TabIndex = 3;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otros" });
            comboBoxGenero.Location = new Point(203, 312);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(121, 23);
            comboBoxGenero.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(291, 219);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(165, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 402);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 46);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(132, 140);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 17;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(132, 182);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 18;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(132, 222);
            label4.Name = "label4";
            label4.Size = new Size(153, 19);
            label4.TabIndex = 19;
            label4.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(132, 270);
            label5.Name = "label5";
            label5.Size = new Size(90, 19);
            label5.TabIndex = 20;
            label5.Text = "Direccion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(132, 312);
            label6.Name = "label6";
            label6.Size = new Size(63, 19);
            label6.TabIndex = 21;
            label6.Text = "Genero";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(132, 357);
            label7.Name = "label7";
            label7.Size = new Size(117, 19);
            label7.TabIndex = 22;
            label7.Text = "Estado Civil";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(132, 406);
            label8.Name = "label8";
            label8.Size = new Size(81, 19);
            label8.TabIndex = 23;
            label8.Text = "Telefono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(132, 456);
            label9.Name = "label9";
            label9.Size = new Size(54, 19);
            label9.TabIndex = 24;
            label9.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 642);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBoxGenero);
            Controls.Add(comboBoxCivil);
            Controls.Add(txtboxTelefono);
            Controls.Add(txtboxEmail);
            Controls.Add(txtboxDireccion);
            Controls.Add(txtboxApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtboxNombre);
            Controls.Add(lblEstadoCivil);
            Controls.Add(lblGenero);
            Controls.Add(lblTelefono);
            Controls.Add(lblEmail);
            Controls.Add(lblDireccion);
            Controls.Add(lblNacimiento);
            Controls.Add(lblApellido);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(PanelDatos);
            Controls.Add(btnNuevo);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            PanelDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnNuevo;
        private FlowLayoutPanel PanelDatos;
        private Button btnBuscar;
        private Button btnModificar;
        public Label label1;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblApellido;
        private Label lblNacimiento;
        private Label lblDireccion;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblGenero;
        private Label lblEstadoCivil;
        private TextBox txtboxNombre;
        private Label lblNombre;
        private TextBox txtboxApellido;
        private TextBox txtboxDireccion;
        private TextBox txtboxEmail;
        private TextBox txtboxTelefono;
        private ComboBox comboBoxCivil;
        private ComboBox comboBoxGenero;
        private DateTimePicker dateTimePicker1;
        private Button btnEliminar;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}