namespace PresentacionNomina
{
    partial class FrmConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnConsultar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtgConsultar = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONSULTAR";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.ActiveBorderThickness = 1;
            this.btnFiltrar.ActiveCornerRadius = 20;
            this.btnFiltrar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnFiltrar.ActiveForecolor = System.Drawing.Color.White;
            this.btnFiltrar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnFiltrar.BackColor = System.Drawing.Color.White;
            this.btnFiltrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.BackgroundImage")));
            this.btnFiltrar.ButtonText = "Filtrar";
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFiltrar.IdleBorderThickness = 1;
            this.btnFiltrar.IdleCornerRadius = 20;
            this.btnFiltrar.IdleFillColor = System.Drawing.Color.White;
            this.btnFiltrar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnFiltrar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnFiltrar.Location = new System.Drawing.Point(429, 60);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(144, 41);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFiltrar.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.ActiveBorderThickness = 1;
            this.btnConsultar.ActiveCornerRadius = 20;
            this.btnConsultar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnConsultar.ActiveForecolor = System.Drawing.Color.White;
            this.btnConsultar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnConsultar.BackColor = System.Drawing.Color.White;
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.ButtonText = "Consultar";
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnConsultar.IdleBorderThickness = 1;
            this.btnConsultar.IdleCornerRadius = 20;
            this.btnConsultar.IdleFillColor = System.Drawing.Color.White;
            this.btnConsultar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnConsultar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnConsultar.Location = new System.Drawing.Point(26, 60);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(144, 41);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtgConsultar
            // 
            this.dtgConsultar.AllowUserToAddRows = false;
            this.dtgConsultar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgConsultar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgConsultar.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgConsultar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgConsultar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgConsultar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConsultar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgConsultar.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgConsultar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgConsultar.DoubleBuffered = true;
            this.dtgConsultar.EnableHeadersVisualStyles = false;
            this.dtgConsultar.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgConsultar.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtgConsultar.HeaderForeColor = System.Drawing.Color.White;
            this.dtgConsultar.Location = new System.Drawing.Point(26, 120);
            this.dtgConsultar.Name = "dtgConsultar";
            this.dtgConsultar.ReadOnly = true;
            this.dtgConsultar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConsultar.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgConsultar.RowHeadersVisible = false;
            this.dtgConsultar.RowTemplate.DividerHeight = 1;
            this.dtgConsultar.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgConsultar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConsultar.Size = new System.Drawing.Size(529, 181);
            this.dtgConsultar.TabIndex = 5;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this.dtgConsultar;
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 346);
            this.Controls.Add(this.dtgConsultar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultar";
            this.Text = "FrmConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFiltrar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConsultar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgConsultar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}