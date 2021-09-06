
namespace WindowsApp02
{
    partial class FrmOperacionesBasicas
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.ResultadosListBox = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SalirButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.OperacionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(107, 52);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Numero1TextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero 2:";
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(107, 88);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Numero2TextBox.TabIndex = 1;
            // 
            // ResultadosListBox
            // 
            this.ResultadosListBox.FormattingEnabled = true;
            this.ResultadosListBox.Location = new System.Drawing.Point(26, 259);
            this.ResultadosListBox.Name = "ResultadosListBox";
            this.ResultadosListBox.Size = new System.Drawing.Size(230, 121);
            this.ResultadosListBox.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SalirButton
            // 
            this.SalirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SalirButton.Image = global::WindowsApp02.Properties.Resources.shutdown_36px;
            this.SalirButton.Location = new System.Drawing.Point(205, 405);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(51, 44);
            this.SalirButton.TabIndex = 5;
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Image = global::WindowsApp02.Properties.Resources.save_24px;
            this.OKButton.Location = new System.Drawing.Point(26, 178);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(62, 54);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Image = global::WindowsApp02.Properties.Resources.cancel_24px;
            this.CancelarButton.Location = new System.Drawing.Point(194, 178);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(62, 54);
            this.CancelarButton.TabIndex = 4;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // OperacionComboBox
            // 
            this.OperacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperacionComboBox.FormattingEnabled = true;
            this.OperacionComboBox.Location = new System.Drawing.Point(107, 131);
            this.OperacionComboBox.Name = "OperacionComboBox";
            this.OperacionComboBox.Size = new System.Drawing.Size(121, 21);
            this.OperacionComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Operación:";
            // 
            // FrmOperacionesBasicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.OperacionComboBox);
            this.Controls.Add(this.ResultadosListBox);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "FrmOperacionesBasicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones Básicas";
            this.Load += new System.EventHandler(this.FrmOperacionesBasicas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero2TextBox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.ListBox ResultadosListBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.ComboBox OperacionComboBox;
        private System.Windows.Forms.Label label3;
    }
}

