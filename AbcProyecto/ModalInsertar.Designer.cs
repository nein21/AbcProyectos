namespace AbcProyecto
{
    partial class ModalInsertar
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
            this.btnAlta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsNombre = new System.Windows.Forms.TextBox();
            this.txtInsDescr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsCant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInsID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(111, 229);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE";
            // 
            // txtInsNombre
            // 
            this.txtInsNombre.Location = new System.Drawing.Point(111, 100);
            this.txtInsNombre.Name = "txtInsNombre";
            this.txtInsNombre.Size = new System.Drawing.Size(162, 20);
            this.txtInsNombre.TabIndex = 2;
            // 
            // txtInsDescr
            // 
            this.txtInsDescr.Location = new System.Drawing.Point(111, 141);
            this.txtInsDescr.Name = "txtInsDescr";
            this.txtInsDescr.Size = new System.Drawing.Size(162, 20);
            this.txtInsDescr.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DESCRIPCION";
            // 
            // txtInsCant
            // 
            this.txtInsCant.Location = new System.Drawing.Point(111, 179);
            this.txtInsCant.Name = "txtInsCant";
            this.txtInsCant.Size = new System.Drawing.Size(162, 20);
            this.txtInsCant.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CANTIDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "INSERTAR";
            // 
            // txtInsID
            // 
            this.txtInsID.Enabled = false;
            this.txtInsID.Location = new System.Drawing.Point(111, 61);
            this.txtInsID.Name = "txtInsID";
            this.txtInsID.Size = new System.Drawing.Size(162, 20);
            this.txtInsID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(25, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID";
            // 
            // ModalInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(315, 264);
            this.Controls.Add(this.txtInsID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInsCant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInsDescr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInsNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlta);
            this.Name = "ModalInsertar";
            this.Text = "ModalInsertar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInsNombre;
        private System.Windows.Forms.TextBox txtInsDescr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInsCant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInsID;
        private System.Windows.Forms.Label label5;
    }
}