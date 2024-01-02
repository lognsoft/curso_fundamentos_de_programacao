namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.rbMulher = new System.Windows.Forms.RadioButton();
            this.rbHomem = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.btnCadastrar);
            this.gbSexo.Controls.Add(this.rbMulher);
            this.gbSexo.Controls.Add(this.rbHomem);
            this.gbSexo.Location = new System.Drawing.Point(301, 165);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(200, 119);
            this.gbSexo.TabIndex = 0;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Selecione um sexo";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(18, 58);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(149, 45);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // rbMulher
            // 
            this.rbMulher.AutoSize = true;
            this.rbMulher.Checked = true;
            this.rbMulher.Location = new System.Drawing.Point(104, 33);
            this.rbMulher.Name = "rbMulher";
            this.rbMulher.Size = new System.Drawing.Size(63, 19);
            this.rbMulher.TabIndex = 1;
            this.rbMulher.TabStop = true;
            this.rbMulher.Text = "Mulher";
            this.rbMulher.UseVisualStyleBackColor = true;
            this.rbMulher.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbHomem
            // 
            this.rbHomem.AutoSize = true;
            this.rbHomem.Location = new System.Drawing.Point(24, 31);
            this.rbHomem.Name = "rbHomem";
            this.rbHomem.Size = new System.Drawing.Size(69, 19);
            this.rbHomem.TabIndex = 0;
            this.rbHomem.Text = "Homem";
            this.rbHomem.UseVisualStyleBackColor = true;
            this.rbHomem.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbSexo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbSexo;
        private RadioButton rbHomem;
        private RadioButton rbMulher;
        private Button btnCadastrar;
        private Button button1;
    }
}