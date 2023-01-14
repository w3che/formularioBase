namespace formularioBase
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
            this.labelSaludo = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPaterno = new System.Windows.Forms.Label();
            this.labelMaterno = new System.Windows.Forms.Label();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNombre = new System.Windows.Forms.Button();
            this.btnPaterno = new System.Windows.Forms.Button();
            this.btnMaterno = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSaludo
            // 
            this.labelSaludo.AutoSize = true;
            this.labelSaludo.Location = new System.Drawing.Point(73, 50);
            this.labelSaludo.Name = "labelSaludo";
            this.labelSaludo.Size = new System.Drawing.Size(38, 13);
            this.labelSaludo.TabIndex = 0;
            this.labelSaludo.Text = "saludo";
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Location = new System.Drawing.Point(183, 50);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(34, 13);
            this.labelCargo.TabIndex = 1;
            this.labelCargo.Text = "cargo";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(300, 50);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(42, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "nombre";
            // 
            // labelPaterno
            // 
            this.labelPaterno.AutoSize = true;
            this.labelPaterno.Location = new System.Drawing.Point(414, 50);
            this.labelPaterno.Name = "labelPaterno";
            this.labelPaterno.Size = new System.Drawing.Size(43, 13);
            this.labelPaterno.TabIndex = 3;
            this.labelPaterno.Text = "paterno";
            // 
            // labelMaterno
            // 
            this.labelMaterno.AutoSize = true;
            this.labelMaterno.Location = new System.Drawing.Point(540, 50);
            this.labelMaterno.Name = "labelMaterno";
            this.labelMaterno.Size = new System.Drawing.Size(45, 13);
            this.labelMaterno.TabIndex = 4;
            this.labelMaterno.Text = "materno";
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(62, 114);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(75, 23);
            this.btnSaludar.TabIndex = 5;
            this.btnSaludar.Text = "saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludo);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "saludar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCargo);
            // 
            // btnNombre
            // 
            this.btnNombre.Location = new System.Drawing.Point(289, 114);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(75, 23);
            this.btnNombre.TabIndex = 7;
            this.btnNombre.Text = "saludar";
            this.btnNombre.UseVisualStyleBackColor = true;
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // btnPaterno
            // 
            this.btnPaterno.Location = new System.Drawing.Point(409, 114);
            this.btnPaterno.Name = "btnPaterno";
            this.btnPaterno.Size = new System.Drawing.Size(75, 23);
            this.btnPaterno.TabIndex = 8;
            this.btnPaterno.Text = "saludar";
            this.btnPaterno.UseVisualStyleBackColor = true;
            this.btnPaterno.Click += new System.EventHandler(this.btnPaterno_Click);
            // 
            // btnMaterno
            // 
            this.btnMaterno.Location = new System.Drawing.Point(531, 114);
            this.btnMaterno.Name = "btnMaterno";
            this.btnMaterno.Size = new System.Drawing.Size(75, 23);
            this.btnMaterno.TabIndex = 9;
            this.btnMaterno.Text = "saludar";
            this.btnMaterno.UseVisualStyleBackColor = true;
            this.btnMaterno.Click += new System.EventHandler(this.btnMaterno_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(62, 167);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 233);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMaterno);
            this.Controls.Add(this.btnPaterno);
            this.Controls.Add(this.btnNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.labelMaterno);
            this.Controls.Add(this.labelPaterno);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelSaludo);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Base";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSaludo;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPaterno;
        private System.Windows.Forms.Label labelMaterno;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNombre;
        private System.Windows.Forms.Button btnPaterno;
        private System.Windows.Forms.Button btnMaterno;
        private System.Windows.Forms.Button btnReset;
    }
}

