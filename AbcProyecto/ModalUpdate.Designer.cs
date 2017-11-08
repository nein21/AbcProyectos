namespace AbcProyecto
{
    partial class ModalUpdate
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
            this.txtUpID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpCant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpDescr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUpID
            // 
            this.txtUpID.Location = new System.Drawing.Point(104, 54);
            this.txtUpID.Name = "txtUpID";
            this.txtUpID.ReadOnly = true;
            this.txtUpID.Size = new System.Drawing.Size(162, 20);
            this.txtUpID.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(119, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "ACTUALIZAR";
            // 
            // txtUpCant
            // 
            this.txtUpCant.Location = new System.Drawing.Point(104, 172);
            this.txtUpCant.Name = "txtUpCant";
            this.txtUpCant.Size = new System.Drawing.Size(162, 20);
            this.txtUpCant.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "CANTIDAD";
            // 
            // txtUpDescr
            // 
            this.txtUpDescr.Location = new System.Drawing.Point(104, 134);
            this.txtUpDescr.Name = "txtUpDescr";
            this.txtUpDescr.Size = new System.Drawing.Size(162, 20);
            this.txtUpDescr.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "DESCRIPCION";
            // 
            // txtUpNombre
            // 
            this.txtUpNombre.Location = new System.Drawing.Point(104, 93);
            this.txtUpNombre.Name = "txtUpNombre";
            this.txtUpNombre.Size = new System.Drawing.Size(162, 20);
            this.txtUpNombre.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "NOMBRE";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(104, 222);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 10;
            this.btnAlta.Text = "ACTUALIZAR";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // ModalUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(303, 261);
            this.Controls.Add(this.txtUpID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUpCant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUpDescr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUpNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlta);
            this.Name = "ModalUpdate";
            this.Text = "ModalUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUpID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpCant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpDescr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlta;
    }
}