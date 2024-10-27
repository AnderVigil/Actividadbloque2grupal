namespace ACTIVIDAD_BLOQUE_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtclasificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtduracion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsinopsis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblregistro = new System.Windows.Forms.Label();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtclasificacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtduracion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtsinopsis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtautor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttitulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peliculas";
            // 
            // txtclasificacion
            // 
            this.txtclasificacion.Location = new System.Drawing.Point(148, 199);
            this.txtclasificacion.Name = "txtclasificacion";
            this.txtclasificacion.Size = new System.Drawing.Size(185, 20);
            this.txtclasificacion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Clasificacion";
            // 
            // txtduracion
            // 
            this.txtduracion.Location = new System.Drawing.Point(148, 161);
            this.txtduracion.Name = "txtduracion";
            this.txtduracion.Size = new System.Drawing.Size(185, 20);
            this.txtduracion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Duracion";
            // 
            // txtsinopsis
            // 
            this.txtsinopsis.Location = new System.Drawing.Point(148, 120);
            this.txtsinopsis.Name = "txtsinopsis";
            this.txtsinopsis.Size = new System.Drawing.Size(367, 20);
            this.txtsinopsis.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sinopsis";
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(148, 80);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(185, 20);
            this.txtautor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor";
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(148, 28);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(185, 20);
            this.txttitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblregistro);
            this.groupBox2.Controls.Add(this.btnultimo);
            this.groupBox2.Controls.Add(this.btnsiguiente);
            this.groupBox2.Controls.Add(this.btnanterior);
            this.groupBox2.Controls.Add(this.btnprimero);
            this.groupBox2.Location = new System.Drawing.Point(34, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navegacion";
            // 
            // lblregistro
            // 
            this.lblregistro.AutoSize = true;
            this.lblregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistro.Location = new System.Drawing.Point(112, 20);
            this.lblregistro.Name = "lblregistro";
            this.lblregistro.Size = new System.Drawing.Size(57, 20);
            this.lblregistro.TabIndex = 10;
            this.lblregistro.Text = "x de n";
            // 
            // btnultimo
            // 
            this.btnultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnultimo.Location = new System.Drawing.Point(232, 20);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(40, 23);
            this.btnultimo.TabIndex = 3;
            this.btnultimo.Text = ">l";
            this.btnultimo.UseVisualStyleBackColor = true;
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiguiente.Location = new System.Drawing.Point(186, 19);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(40, 24);
            this.btnsiguiente.TabIndex = 2;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            // 
            // btnanterior
            // 
            this.btnanterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanterior.Location = new System.Drawing.Point(53, 19);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(40, 23);
            this.btnanterior.TabIndex = 1;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = true;
            // 
            // btnprimero
            // 
            this.btnprimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprimero.Location = new System.Drawing.Point(7, 20);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(40, 23);
            this.btnprimero.TabIndex = 0;
            this.btnprimero.Text = "l<";
            this.btnprimero.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btneliminar);
            this.groupBox3.Controls.Add(this.btnmodificar);
            this.groupBox3.Controls.Add(this.btnnuevo);
            this.groupBox3.Location = new System.Drawing.Point(333, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edicion";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(6, 21);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(85, 23);
            this.btnnuevo.TabIndex = 11;
            this.btnnuevo.Text = "NUEVO";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(97, 20);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(103, 23);
            this.btnmodificar.TabIndex = 12;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(206, 19);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(103, 23);
            this.btneliminar.TabIndex = 13;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Administracion de Peliculas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtclasificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtduracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsinopsis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnprimero;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblregistro;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
    }
}

