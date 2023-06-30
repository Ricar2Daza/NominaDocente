
namespace PresentacionGUI
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.comboBoxGrupo = new System.Windows.Forms.ComboBox();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.comboBoxPosgrado = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblPosgrado = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.textBoxNomina = new System.Windows.Forms.TextBox();
            this.comboBoxMT = new System.Windows.Forms.ComboBox();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.lblNomina = new System.Windows.Forms.Label();
            this.lblMT = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.errorProviderRegistro = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCedula);
            this.groupBox1.Controls.Add(this.lblCedula);
            this.groupBox1.Controls.Add(this.textBoxApellidos);
            this.groupBox1.Controls.Add(this.textBoxNombres);
            this.groupBox1.Controls.Add(this.comboBoxGrupo);
            this.groupBox1.Controls.Add(this.comboBoxCargo);
            this.groupBox1.Controls.Add(this.comboBoxPosgrado);
            this.groupBox1.Controls.Add(this.lblGrupo);
            this.groupBox1.Controls.Add(this.lblPosgrado);
            this.groupBox1.Controls.Add(this.lblCargo);
            this.groupBox1.Controls.Add(this.lblApellidos);
            this.groupBox1.Controls.Add(this.lblNombres);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(61, 20);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(121, 20);
            this.textBoxCedula.TabIndex = 11;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(15, 23);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 10;
            this.lblCedula.Text = "Cedula";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(61, 72);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(121, 20);
            this.textBoxApellidos.TabIndex = 9;
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(61, 46);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombres.TabIndex = 8;
            // 
            // comboBoxGrupo
            // 
            this.comboBoxGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrupo.FormattingEnabled = true;
            this.comboBoxGrupo.Items.AddRange(new object[] {
            "A1",
            "A",
            "B",
            "C",
            "Reconocidos por colciencias",
            "Semillero"});
            this.comboBoxGrupo.Location = new System.Drawing.Point(61, 152);
            this.comboBoxGrupo.Name = "comboBoxGrupo";
            this.comboBoxGrupo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGrupo.TabIndex = 7;
            this.comboBoxGrupo.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrupo_SelectedIndexChanged);
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Items.AddRange(new object[] {
            "Auxiliar de tiempo completo",
            "Auxiliar de medio tiempo",
            "Asistente de tiempo completo",
            "Asistente de medio tiempo",
            "Asociado de tiempo completo",
            "Asociado de medio tiempo",
            "Titular de tiempo completo",
            "Titular de medio tiempo"});
            this.comboBoxCargo.Location = new System.Drawing.Point(61, 98);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCargo.TabIndex = 6;
            this.comboBoxCargo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCargo_SelectedIndexChanged);
            // 
            // comboBoxPosgrado
            // 
            this.comboBoxPosgrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosgrado.FormattingEnabled = true;
            this.comboBoxPosgrado.Items.AddRange(new object[] {
            "Especializacion",
            "Maestria",
            "Doctorado",
            "Postdoctorado"});
            this.comboBoxPosgrado.Location = new System.Drawing.Point(61, 125);
            this.comboBoxPosgrado.Name = "comboBoxPosgrado";
            this.comboBoxPosgrado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPosgrado.TabIndex = 5;
            this.comboBoxPosgrado.SelectedIndexChanged += new System.EventHandler(this.comboBoxPosgrado_SelectedIndexChanged);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(19, 155);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(36, 13);
            this.lblGrupo.TabIndex = 4;
            this.lblGrupo.Text = "Grupo";
            // 
            // lblPosgrado
            // 
            this.lblPosgrado.AutoSize = true;
            this.lblPosgrado.Location = new System.Drawing.Point(3, 128);
            this.lblPosgrado.Name = "lblPosgrado";
            this.lblPosgrado.Size = new System.Drawing.Size(52, 13);
            this.lblPosgrado.TabIndex = 3;
            this.lblPosgrado.Text = "Posgrado";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(20, 101);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(6, 75);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(6, 49);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegistrar);
            this.groupBox2.Controls.Add(this.textBoxNomina);
            this.groupBox2.Controls.Add(this.comboBoxMT);
            this.groupBox2.Controls.Add(this.textBoxSalario);
            this.groupBox2.Controls.Add(this.lblNomina);
            this.groupBox2.Controls.Add(this.lblMT);
            this.groupBox2.Controls.Add(this.lblSalario);
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salario y Nomina";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(61, 101);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(121, 36);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // textBoxNomina
            // 
            this.textBoxNomina.Enabled = false;
            this.textBoxNomina.Location = new System.Drawing.Point(61, 75);
            this.textBoxNomina.Name = "textBoxNomina";
            this.textBoxNomina.Size = new System.Drawing.Size(121, 20);
            this.textBoxNomina.TabIndex = 11;
            // 
            // comboBoxMT
            // 
            this.comboBoxMT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMT.FormattingEnabled = true;
            this.comboBoxMT.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxMT.Location = new System.Drawing.Point(61, 48);
            this.comboBoxMT.Name = "comboBoxMT";
            this.comboBoxMT.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMT.TabIndex = 10;
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.Enabled = false;
            this.textBoxSalario.Location = new System.Drawing.Point(61, 22);
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(121, 20);
            this.textBoxSalario.TabIndex = 10;
            // 
            // lblNomina
            // 
            this.lblNomina.AutoSize = true;
            this.lblNomina.Location = new System.Drawing.Point(12, 78);
            this.lblNomina.Name = "lblNomina";
            this.lblNomina.Size = new System.Drawing.Size(43, 13);
            this.lblNomina.TabIndex = 3;
            this.lblNomina.Text = "Nomina";
            // 
            // lblMT
            // 
            this.lblMT.AutoSize = true;
            this.lblMT.Location = new System.Drawing.Point(29, 51);
            this.lblMT.Name = "lblMT";
            this.lblMT.Size = new System.Drawing.Size(26, 13);
            this.lblMT.TabIndex = 2;
            this.lblMT.Text = "M.T";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(16, 25);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Salario";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConsultar);
            this.groupBox3.Controls.Add(this.dgvListado);
            this.groupBox3.Location = new System.Drawing.Point(222, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 327);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(204, 19);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(121, 36);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(6, 63);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(503, 214);
            this.dgvListado.TabIndex = 0;
            // 
            // errorProviderRegistro
            // 
            this.errorProviderRegistro.ContainerControl = this;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 351);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPosgrado;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.ComboBox comboBoxGrupo;
        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.ComboBox comboBoxPosgrado;
        private System.Windows.Forms.TextBox textBoxNomina;
        private System.Windows.Forms.ComboBox comboBoxMT;
        private System.Windows.Forms.TextBox textBoxSalario;
        private System.Windows.Forms.Label lblNomina;
        private System.Windows.Forms.Label lblMT;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.ErrorProvider errorProviderRegistro;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Label lblCedula;
    }
}