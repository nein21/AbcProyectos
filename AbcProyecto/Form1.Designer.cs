namespace AbcProyecto
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBuscarGral = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnNombre = new System.Windows.Forms.Button();
            this.btnId = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMsql = new System.Windows.Forms.DataGridView();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.btnPgDelete = new System.Windows.Forms.Button();
            this.btnPgBuscar = new System.Windows.Forms.Button();
            this.btnPgUpdate = new System.Windows.Forms.Button();
            this.btnPgInsertar = new System.Windows.Forms.Button();
            this.txtPgName = new System.Windows.Forms.TextBox();
            this.txtPgId = new System.Windows.Forms.TextBox();
            this.btnPgName = new System.Windows.Forms.Button();
            this.btnPgId = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPsql = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMsql)).BeginInit();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsql)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Location = new System.Drawing.Point(5, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 383);
            this.tabControl1.TabIndex = 1;
            // 
            // tab1
            // 
            this.tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tab1.Controls.Add(this.btnDelete);
            this.tab1.Controls.Add(this.btnBuscarGral);
            this.tab1.Controls.Add(this.txtNombre);
            this.tab1.Controls.Add(this.txtId);
            this.tab1.Controls.Add(this.btnUpdate);
            this.tab1.Controls.Add(this.btnInsertar);
            this.tab1.Controls.Add(this.btnNombre);
            this.tab1.Controls.Add(this.btnId);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Controls.Add(this.label1);
            this.tab1.Controls.Add(this.dgvMsql);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(572, 357);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "MicrosoftSqlServer";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(450, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Borra Proucto";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBuscarGral
            // 
            this.btnBuscarGral.Location = new System.Drawing.Point(6, 154);
            this.btnBuscarGral.Name = "btnBuscarGral";
            this.btnBuscarGral.Size = new System.Drawing.Size(111, 23);
            this.btnBuscarGral.TabIndex = 11;
            this.btnBuscarGral.Text = "Busqueda General";
            this.btnBuscarGral.UseVisualStyleBackColor = true;
            this.btnBuscarGral.Click += new System.EventHandler(this.btnBuscarGral_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(139, 16);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(140, 20);
            this.txtId.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(301, 154);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Actualizar Producto";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(153, 154);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(112, 23);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "Insertar Producto";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnNombre
            // 
            this.btnNombre.Location = new System.Drawing.Point(322, 74);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(95, 23);
            this.btnNombre.TabIndex = 6;
            this.btnNombre.Text = "Buscar Nombre";
            this.btnNombre.UseVisualStyleBackColor = true;
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // btnId
            // 
            this.btnId.Location = new System.Drawing.Point(322, 11);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(95, 23);
            this.btnId.TabIndex = 5;
            this.btnId.Text = "Buscar id";
            this.btnId.UseVisualStyleBackColor = true;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Busqueda por nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busqueda por id";
            // 
            // dgvMsql
            // 
            this.dgvMsql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMsql.Location = new System.Drawing.Point(6, 201);
            this.dgvMsql.Name = "dgvMsql";
            this.dgvMsql.Size = new System.Drawing.Size(560, 150);
            this.dgvMsql.TabIndex = 0;
            this.dgvMsql.DoubleClick += new System.EventHandler(this.dgvMsql_DoubleClick);
            // 
            // tab2
            // 
            this.tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tab2.Controls.Add(this.btnPgDelete);
            this.tab2.Controls.Add(this.btnPgBuscar);
            this.tab2.Controls.Add(this.btnPgUpdate);
            this.tab2.Controls.Add(this.btnPgInsertar);
            this.tab2.Controls.Add(this.txtPgName);
            this.tab2.Controls.Add(this.txtPgId);
            this.tab2.Controls.Add(this.btnPgName);
            this.tab2.Controls.Add(this.btnPgId);
            this.tab2.Controls.Add(this.label3);
            this.tab2.Controls.Add(this.label4);
            this.tab2.Controls.Add(this.dgvPsql);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(572, 357);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "PostgresSql";
            // 
            // btnPgDelete
            // 
            this.btnPgDelete.Location = new System.Drawing.Point(450, 167);
            this.btnPgDelete.Name = "btnPgDelete";
            this.btnPgDelete.Size = new System.Drawing.Size(116, 23);
            this.btnPgDelete.TabIndex = 22;
            this.btnPgDelete.Text = "Borra Proucto";
            this.btnPgDelete.UseVisualStyleBackColor = true;
            this.btnPgDelete.Click += new System.EventHandler(this.btnPgDelete_Click);
            // 
            // btnPgBuscar
            // 
            this.btnPgBuscar.Location = new System.Drawing.Point(6, 167);
            this.btnPgBuscar.Name = "btnPgBuscar";
            this.btnPgBuscar.Size = new System.Drawing.Size(111, 23);
            this.btnPgBuscar.TabIndex = 21;
            this.btnPgBuscar.Text = "Busqueda General";
            this.btnPgBuscar.UseVisualStyleBackColor = true;
            this.btnPgBuscar.Click += new System.EventHandler(this.btnPgBuscar_Click);
            // 
            // btnPgUpdate
            // 
            this.btnPgUpdate.Location = new System.Drawing.Point(301, 167);
            this.btnPgUpdate.Name = "btnPgUpdate";
            this.btnPgUpdate.Size = new System.Drawing.Size(116, 23);
            this.btnPgUpdate.TabIndex = 20;
            this.btnPgUpdate.Text = "Actualizar Producto";
            this.btnPgUpdate.UseVisualStyleBackColor = true;
            // 
            // btnPgInsertar
            // 
            this.btnPgInsertar.Location = new System.Drawing.Point(153, 167);
            this.btnPgInsertar.Name = "btnPgInsertar";
            this.btnPgInsertar.Size = new System.Drawing.Size(112, 23);
            this.btnPgInsertar.TabIndex = 19;
            this.btnPgInsertar.Text = "Insertar Producto";
            this.btnPgInsertar.UseVisualStyleBackColor = true;
            this.btnPgInsertar.Click += new System.EventHandler(this.btnPgInsertar_Click);
            // 
            // txtPgName
            // 
            this.txtPgName.Location = new System.Drawing.Point(151, 88);
            this.txtPgName.Name = "txtPgName";
            this.txtPgName.Size = new System.Drawing.Size(140, 20);
            this.txtPgName.TabIndex = 18;
            // 
            // txtPgId
            // 
            this.txtPgId.Location = new System.Drawing.Point(151, 27);
            this.txtPgId.Name = "txtPgId";
            this.txtPgId.Size = new System.Drawing.Size(140, 20);
            this.txtPgId.TabIndex = 17;
            // 
            // btnPgName
            // 
            this.btnPgName.Location = new System.Drawing.Point(334, 91);
            this.btnPgName.Name = "btnPgName";
            this.btnPgName.Size = new System.Drawing.Size(95, 23);
            this.btnPgName.TabIndex = 14;
            this.btnPgName.Text = "Buscar Nombre";
            this.btnPgName.UseVisualStyleBackColor = true;
            this.btnPgName.Click += new System.EventHandler(this.btnPgName_Click);
            // 
            // btnPgId
            // 
            this.btnPgId.Location = new System.Drawing.Point(334, 22);
            this.btnPgId.Name = "btnPgId";
            this.btnPgId.Size = new System.Drawing.Size(95, 23);
            this.btnPgId.TabIndex = 13;
            this.btnPgId.Text = "Buscar id";
            this.btnPgId.UseVisualStyleBackColor = true;
            this.btnPgId.Click += new System.EventHandler(this.btnPgId_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Busqueda por nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Busqueda por id";
            // 
            // dgvPsql
            // 
            this.dgvPsql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPsql.Location = new System.Drawing.Point(6, 201);
            this.dgvPsql.Name = "dgvPsql";
            this.dgvPsql.Size = new System.Drawing.Size(560, 150);
            this.dgvPsql.TabIndex = 1;
            this.dgvPsql.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPsql_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 418);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMsql)).EndInit();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsql)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMsql;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.DataGridView dgvPsql;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnNombre;
        private System.Windows.Forms.Button btnId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPgName;
        private System.Windows.Forms.TextBox txtPgId;
        private System.Windows.Forms.Button btnPgName;
        private System.Windows.Forms.Button btnPgId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarGral;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPgDelete;
        private System.Windows.Forms.Button btnPgBuscar;
        private System.Windows.Forms.Button btnPgUpdate;
        private System.Windows.Forms.Button btnPgInsertar;
    }
}

