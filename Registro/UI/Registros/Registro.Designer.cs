namespace Registro.UI.Consultas
{
    partial class Registro
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
            this.IDlabel = new System.Windows.Forms.Label();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.Siglaslabel = new System.Windows.Forms.Label();
            this.Tipolibrolabel = new System.Windows.Forms.Label();
            this.IDLibronumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxSiglas = new System.Windows.Forms.TextBox();
            this.textBoxTiposLibro = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDLibronumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(52, 71);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(84, 25);
            this.IDlabel.TabIndex = 2;
            this.IDlabel.Text = " ID Libro";
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Descripcionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcionlabel.Location = new System.Drawing.Point(53, 127);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(110, 24);
            this.Descripcionlabel.TabIndex = 3;
            this.Descripcionlabel.Text = "Descripcion";
            // 
            // Siglaslabel
            // 
            this.Siglaslabel.AutoSize = true;
            this.Siglaslabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Siglaslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Siglaslabel.Location = new System.Drawing.Point(53, 180);
            this.Siglaslabel.Name = "Siglaslabel";
            this.Siglaslabel.Size = new System.Drawing.Size(60, 24);
            this.Siglaslabel.TabIndex = 4;
            this.Siglaslabel.Text = "Siglas";
            // 
            // Tipolibrolabel
            // 
            this.Tipolibrolabel.AutoSize = true;
            this.Tipolibrolabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Tipolibrolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipolibrolabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tipolibrolabel.Location = new System.Drawing.Point(53, 233);
            this.Tipolibrolabel.Name = "Tipolibrolabel";
            this.Tipolibrolabel.Size = new System.Drawing.Size(125, 24);
            this.Tipolibrolabel.TabIndex = 5;
            this.Tipolibrolabel.Text = "Tipos de libro";
            // 
            // IDLibronumericUpDown
            // 
            this.IDLibronumericUpDown.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.IDLibronumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLibronumericUpDown.Location = new System.Drawing.Point(213, 68);
            this.IDLibronumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.IDLibronumericUpDown.Name = "IDLibronumericUpDown";
            this.IDLibronumericUpDown.Size = new System.Drawing.Size(127, 28);
            this.IDLibronumericUpDown.TabIndex = 6;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDescripcion.Location = new System.Drawing.Point(213, 127);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(276, 22);
            this.textBoxDescripcion.TabIndex = 7;
            // 
            // textBoxSiglas
            // 
            this.textBoxSiglas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSiglas.Location = new System.Drawing.Point(213, 179);
            this.textBoxSiglas.Name = "textBoxSiglas";
            this.textBoxSiglas.Size = new System.Drawing.Size(276, 22);
            this.textBoxSiglas.TabIndex = 8;
            // 
            // textBoxTiposLibro
            // 
            this.textBoxTiposLibro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxTiposLibro.Location = new System.Drawing.Point(213, 233);
            this.textBoxTiposLibro.Name = "textBoxTiposLibro";
            this.textBoxTiposLibro.Size = new System.Drawing.Size(276, 22);
            this.textBoxTiposLibro.TabIndex = 9;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevobutton.Image = global::Registro.Properties.Resources.icons8_nuevo_48;
            this.Nuevobutton.Location = new System.Drawing.Point(57, 300);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(133, 67);
            this.Nuevobutton.TabIndex = 14;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton.Image = global::Registro.Properties.Resources.Eliminar;
            this.Eliminarbutton.Location = new System.Drawing.Point(366, 300);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(123, 67);
            this.Eliminarbutton.TabIndex = 13;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton.Image = global::Registro.Properties.Resources.icons8_guardar_48;
            this.Guardarbutton.Location = new System.Drawing.Point(213, 300);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(135, 67);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Registro.Properties.Resources.Buscar;
            this.Buscarbutton.Location = new System.Drawing.Point(366, 63);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(123, 58);
            this.Buscarbutton.TabIndex = 10;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Crimson;
            this.textBox1.Location = new System.Drawing.Point(163, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 38);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Libro De La Biblia";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.textBoxTiposLibro);
            this.Controls.Add(this.textBoxSiglas);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.IDLibronumericUpDown);
            this.Controls.Add(this.Tipolibrolabel);
            this.Controls.Add(this.Siglaslabel);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.IDlabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDLibronumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.Label Siglaslabel;
        private System.Windows.Forms.Label Tipolibrolabel;
        private System.Windows.Forms.NumericUpDown IDLibronumericUpDown;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxSiglas;
        private System.Windows.Forms.TextBox textBoxTiposLibro;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}