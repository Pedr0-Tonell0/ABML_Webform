namespace TP2_AppComercio
{
    partial class FrmPantallaPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.bttnModificar = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.bttnDetalles = new System.Windows.Forms.Button();
            this.bttnBaja = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 233);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(10, 19);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(564, 201);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(169, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "BIENVENIDOS";
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgregar.Location = new System.Drawing.Point(22, 373);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(75, 23);
            this.bttnAgregar.TabIndex = 17;
            this.bttnAgregar.Text = "Agregar";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.BttnAgregar_Click);
            // 
            // bttnModificar
            // 
            this.bttnModificar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnModificar.Location = new System.Drawing.Point(142, 373);
            this.bttnModificar.Name = "bttnModificar";
            this.bttnModificar.Size = new System.Drawing.Size(75, 23);
            this.bttnModificar.TabIndex = 18;
            this.bttnModificar.Text = "Modificar";
            this.bttnModificar.UseVisualStyleBackColor = true;
            this.bttnModificar.Click += new System.EventHandler(this.BttnModificar_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEliminar.Location = new System.Drawing.Point(389, 373);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(75, 23);
            this.bttnEliminar.TabIndex = 19;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.BttnEliminar_Click);
            // 
            // textBusqueda
            // 
            this.textBusqueda.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBusqueda.Location = new System.Drawing.Point(125, 92);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(355, 20);
            this.textBusqueda.TabIndex = 20;
            this.textBusqueda.TextChanged += new System.EventHandler(this.TextBusqueda_TextChanged);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::TP2_AppComercio.Properties.Resources.icons8_box_64;
            this.pictureBox8.Location = new System.Drawing.Point(387, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(69, 70);
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::TP2_AppComercio.Properties.Resources.icons8_close_window_26;
            this.pictureBox7.Location = new System.Drawing.Point(576, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(26, 30);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.PictureBox7_Click);
            // 
            // bttnDetalles
            // 
            this.bttnDetalles.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDetalles.Location = new System.Drawing.Point(262, 373);
            this.bttnDetalles.Name = "bttnDetalles";
            this.bttnDetalles.Size = new System.Drawing.Size(75, 23);
            this.bttnDetalles.TabIndex = 21;
            this.bttnDetalles.Text = "Detalles";
            this.bttnDetalles.UseVisualStyleBackColor = true;
            this.bttnDetalles.Click += new System.EventHandler(this.BttnDetalles_Click_1);
            // 
            // bttnBaja
            // 
            this.bttnBaja.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBaja.Location = new System.Drawing.Point(511, 373);
            this.bttnBaja.Name = "bttnBaja";
            this.bttnBaja.Size = new System.Drawing.Size(75, 23);
            this.bttnBaja.TabIndex = 22;
            this.bttnBaja.Text = "Baja Logica";
            this.bttnBaja.UseVisualStyleBackColor = true;
            this.bttnBaja.Click += new System.EventHandler(this.BttnBaja_Click);
            // 
            // FrmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(604, 440);
            this.ControlBox = false;
            this.Controls.Add(this.bttnBaja);
            this.Controls.Add(this.bttnDetalles);
            this.Controls.Add(this.textBusqueda);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnModificar);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox7);
            this.Name = "FrmPantallaPrincipal";
            this.Load += new System.EventHandler(this.FrmPantallaPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.Button bttnModificar;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.Button bttnDetalles;
        private System.Windows.Forms.Button bttnBaja;
    }
}