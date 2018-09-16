namespace Lector_de_archivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txbLecturaFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbResultPalabras = new System.Windows.Forms.TextBox();
            this.txbResultCaracteres = new System.Windows.Forms.TextBox();
            this.txbResultEspacioBlanco = new System.Windows.Forms.TextBox();
            this.txbResultTabuladores = new System.Windows.Forms.TextBox();
            this.txbResultLineas = new System.Windows.Forms.TextBox();
            this.txbResultVocales = new System.Windows.Forms.TextBox();
            this.txbResultConsonates = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxOpcionesQuitar = new System.Windows.Forms.ComboBox();
            this.btnProcesarEdit = new System.Windows.Forms.Button();
            this.btnGuardarFile = new System.Windows.Forms.Button();
            this.btnExaminarFile = new System.Windows.Forms.Button();
            this.txbRutaFile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo";
            // 
            // txbLecturaFile
            // 
            this.txbLecturaFile.Location = new System.Drawing.Point(27, 82);
            this.txbLecturaFile.Multiline = true;
            this.txbLecturaFile.Name = "txbLecturaFile";
            this.txbLecturaFile.ReadOnly = true;
            this.txbLecturaFile.Size = new System.Drawing.Size(752, 138);
            this.txbLecturaFile.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Palabras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Caracteres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Espacios en Blanco:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tabuladores:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Líneas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Vocales:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Consonantes:";
            // 
            // txbResultPalabras
            // 
            this.txbResultPalabras.Enabled = false;
            this.txbResultPalabras.Location = new System.Drawing.Point(498, 267);
            this.txbResultPalabras.Name = "txbResultPalabras";
            this.txbResultPalabras.ReadOnly = true;
            this.txbResultPalabras.Size = new System.Drawing.Size(46, 22);
            this.txbResultPalabras.TabIndex = 9;
            // 
            // txbResultCaracteres
            // 
            this.txbResultCaracteres.Enabled = false;
            this.txbResultCaracteres.Location = new System.Drawing.Point(498, 303);
            this.txbResultCaracteres.Name = "txbResultCaracteres";
            this.txbResultCaracteres.ReadOnly = true;
            this.txbResultCaracteres.Size = new System.Drawing.Size(46, 22);
            this.txbResultCaracteres.TabIndex = 10;
            // 
            // txbResultEspacioBlanco
            // 
            this.txbResultEspacioBlanco.Enabled = false;
            this.txbResultEspacioBlanco.Location = new System.Drawing.Point(498, 339);
            this.txbResultEspacioBlanco.Name = "txbResultEspacioBlanco";
            this.txbResultEspacioBlanco.ReadOnly = true;
            this.txbResultEspacioBlanco.Size = new System.Drawing.Size(46, 22);
            this.txbResultEspacioBlanco.TabIndex = 11;
            // 
            // txbResultTabuladores
            // 
            this.txbResultTabuladores.Enabled = false;
            this.txbResultTabuladores.Location = new System.Drawing.Point(498, 381);
            this.txbResultTabuladores.Name = "txbResultTabuladores";
            this.txbResultTabuladores.ReadOnly = true;
            this.txbResultTabuladores.Size = new System.Drawing.Size(46, 22);
            this.txbResultTabuladores.TabIndex = 12;
            // 
            // txbResultLineas
            // 
            this.txbResultLineas.Enabled = false;
            this.txbResultLineas.Location = new System.Drawing.Point(498, 420);
            this.txbResultLineas.Name = "txbResultLineas";
            this.txbResultLineas.ReadOnly = true;
            this.txbResultLineas.Size = new System.Drawing.Size(46, 22);
            this.txbResultLineas.TabIndex = 13;
            // 
            // txbResultVocales
            // 
            this.txbResultVocales.Enabled = false;
            this.txbResultVocales.Location = new System.Drawing.Point(498, 463);
            this.txbResultVocales.Name = "txbResultVocales";
            this.txbResultVocales.ReadOnly = true;
            this.txbResultVocales.Size = new System.Drawing.Size(46, 22);
            this.txbResultVocales.TabIndex = 14;
            // 
            // txbResultConsonates
            // 
            this.txbResultConsonates.Enabled = false;
            this.txbResultConsonates.Location = new System.Drawing.Point(498, 504);
            this.txbResultConsonates.Name = "txbResultConsonates";
            this.txbResultConsonates.ReadOnly = true;
            this.txbResultConsonates.Size = new System.Drawing.Size(46, 22);
            this.txbResultConsonates.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 545);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(824, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "_________________________________________________________________________________" +
    "_____________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 601);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Quitar:";
            // 
            // cbxOpcionesQuitar
            // 
            this.cbxOpcionesQuitar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOpcionesQuitar.FormattingEnabled = true;
            this.cbxOpcionesQuitar.Location = new System.Drawing.Point(201, 598);
            this.cbxOpcionesQuitar.Name = "cbxOpcionesQuitar";
            this.cbxOpcionesQuitar.Size = new System.Drawing.Size(183, 24);
            this.cbxOpcionesQuitar.TabIndex = 18;
            // 
            // btnProcesarEdit
            // 
            this.btnProcesarEdit.Location = new System.Drawing.Point(411, 593);
            this.btnProcesarEdit.Name = "btnProcesarEdit";
            this.btnProcesarEdit.Size = new System.Drawing.Size(104, 33);
            this.btnProcesarEdit.TabIndex = 19;
            this.btnProcesarEdit.Text = "Procesar";
            this.btnProcesarEdit.UseVisualStyleBackColor = true;
            this.btnProcesarEdit.Click += new System.EventHandler(this.btnProcesarEdit_Click);
            // 
            // btnGuardarFile
            // 
            this.btnGuardarFile.Location = new System.Drawing.Point(549, 593);
            this.btnGuardarFile.Name = "btnGuardarFile";
            this.btnGuardarFile.Size = new System.Drawing.Size(135, 33);
            this.btnGuardarFile.TabIndex = 20;
            this.btnGuardarFile.Text = "Guardar como...";
            this.btnGuardarFile.UseVisualStyleBackColor = true;
            this.btnGuardarFile.Click += new System.EventHandler(this.btnGuardarFile_Click);
            // 
            // btnExaminarFile
            // 
            this.btnExaminarFile.Location = new System.Drawing.Point(641, 21);
            this.btnExaminarFile.Name = "btnExaminarFile";
            this.btnExaminarFile.Size = new System.Drawing.Size(103, 33);
            this.btnExaminarFile.TabIndex = 21;
            this.btnExaminarFile.Text = "Examinar...";
            this.btnExaminarFile.UseVisualStyleBackColor = true;
            this.btnExaminarFile.Click += new System.EventHandler(this.btnExaminarFile_Click);
            // 
            // txbRutaFile
            // 
            this.txbRutaFile.Enabled = false;
            this.txbRutaFile.Location = new System.Drawing.Point(151, 26);
            this.txbRutaFile.Name = "txbRutaFile";
            this.txbRutaFile.ReadOnly = true;
            this.txbRutaFile.Size = new System.Drawing.Size(460, 22);
            this.txbRutaFile.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-1, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(824, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "_________________________________________________________________________________" +
    "_____________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 665);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbRutaFile);
            this.Controls.Add(this.btnExaminarFile);
            this.Controls.Add(this.btnGuardarFile);
            this.Controls.Add(this.btnProcesarEdit);
            this.Controls.Add(this.cbxOpcionesQuitar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbResultConsonates);
            this.Controls.Add(this.txbResultVocales);
            this.Controls.Add(this.txbResultLineas);
            this.Controls.Add(this.txbResultTabuladores);
            this.Controls.Add(this.txbResultEspacioBlanco);
            this.Controls.Add(this.txbResultCaracteres);
            this.Controls.Add(this.txbResultPalabras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbLecturaFile);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lector y Editor de Archivos de Texto - v0.3a - By Janjell";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbLecturaFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbResultPalabras;
        private System.Windows.Forms.TextBox txbResultCaracteres;
        private System.Windows.Forms.TextBox txbResultEspacioBlanco;
        private System.Windows.Forms.TextBox txbResultTabuladores;
        private System.Windows.Forms.TextBox txbResultLineas;
        private System.Windows.Forms.TextBox txbResultVocales;
        private System.Windows.Forms.TextBox txbResultConsonates;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxOpcionesQuitar;
        private System.Windows.Forms.Button btnProcesarEdit;
        private System.Windows.Forms.Button btnGuardarFile;
        private System.Windows.Forms.Button btnExaminarFile;
        private System.Windows.Forms.TextBox txbRutaFile;
        private System.Windows.Forms.Label label11;
    }
}

