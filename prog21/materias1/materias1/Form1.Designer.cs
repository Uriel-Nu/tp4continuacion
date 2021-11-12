
namespace materias1
{
    partial class ForMaterias
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
            this.dg = new System.Windows.Forms.DataGridView();
            this.cmbnombre = new System.Windows.Forms.ComboBox();
            this.txttp1 = new System.Windows.Forms.TextBox();
            this.txttp2 = new System.Windows.Forms.TextBox();
            this.txttp3 = new System.Windows.Forms.TextBox();
            this.txttp4 = new System.Windows.Forms.TextBox();
            this.txtnotafinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btcargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(85, 188);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(609, 393);
            this.dg.TabIndex = 0;
            // 
            // cmbnombre
            // 
            this.cmbnombre.FormattingEnabled = true;
            this.cmbnombre.Items.AddRange(new object[] {
            "ingles",
            "matematica",
            "arquitectura",
            "programacion",
            "sistemas",
            "lengua"});
            this.cmbnombre.Location = new System.Drawing.Point(4, 125);
            this.cmbnombre.Name = "cmbnombre";
            this.cmbnombre.Size = new System.Drawing.Size(121, 32);
            this.cmbnombre.TabIndex = 1;
            this.cmbnombre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txttp1
            // 
            this.txttp1.Location = new System.Drawing.Point(170, 125);
            this.txttp1.Name = "txttp1";
            this.txttp1.Size = new System.Drawing.Size(100, 29);
            this.txttp1.TabIndex = 2;
            this.txttp1.TextChanged += new System.EventHandler(this.txttp1_TextChanged);
            // 
            // txttp2
            // 
            this.txttp2.Location = new System.Drawing.Point(276, 124);
            this.txttp2.Name = "txttp2";
            this.txttp2.Size = new System.Drawing.Size(100, 29);
            this.txttp2.TabIndex = 3;
            this.txttp2.TextChanged += new System.EventHandler(this.txttp2_TextChanged);
            // 
            // txttp3
            // 
            this.txttp3.Location = new System.Drawing.Point(382, 124);
            this.txttp3.Name = "txttp3";
            this.txttp3.Size = new System.Drawing.Size(100, 29);
            this.txttp3.TabIndex = 4;
            this.txttp3.TextChanged += new System.EventHandler(this.txttp3_TextChanged);
            // 
            // txttp4
            // 
            this.txttp4.Location = new System.Drawing.Point(488, 124);
            this.txttp4.Name = "txttp4";
            this.txttp4.Size = new System.Drawing.Size(100, 29);
            this.txttp4.TabIndex = 5;
            this.txttp4.TextChanged += new System.EventHandler(this.txttp4_TextChanged);
            // 
            // txtnotafinal
            // 
            this.txtnotafinal.Location = new System.Drawing.Point(594, 125);
            this.txtnotafinal.Name = "txtnotafinal";
            this.txtnotafinal.Size = new System.Drawing.Size(100, 29);
            this.txtnotafinal.TabIndex = 6;
            this.txtnotafinal.TextChanged += new System.EventHandler(this.txtnotafinal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "materias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "tp1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "tp2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "tp3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "tp4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "nota final";
            // 
            // btcargar
            // 
            this.btcargar.Location = new System.Drawing.Point(779, 124);
            this.btcargar.Name = "btcargar";
            this.btcargar.Size = new System.Drawing.Size(75, 33);
            this.btcargar.TabIndex = 13;
            this.btcargar.Text = "cargar";
            this.btcargar.UseVisualStyleBackColor = true;
            this.btcargar.Click += new System.EventHandler(this.btcargar_Click);
            // 
            // ForMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 781);
            this.Controls.Add(this.btcargar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnotafinal);
            this.Controls.Add(this.txttp4);
            this.Controls.Add(this.txttp3);
            this.Controls.Add(this.txttp2);
            this.Controls.Add(this.txttp1);
            this.Controls.Add(this.cmbnombre);
            this.Controls.Add(this.dg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ForMaterias";
            this.Text = "materias de primer año";
            this.Load += new System.EventHandler(this.ForMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.ComboBox cmbnombre;
        private System.Windows.Forms.TextBox txttp1;
        private System.Windows.Forms.TextBox txttp2;
        private System.Windows.Forms.TextBox txttp3;
        private System.Windows.Forms.TextBox txttp4;
        private System.Windows.Forms.TextBox txtnotafinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btcargar;
    }
}

