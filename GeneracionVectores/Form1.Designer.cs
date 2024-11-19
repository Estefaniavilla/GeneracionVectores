namespace GeneracionVectores
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
            txtTamaño = new TextBox();
            label1 = new Label();
            btnGenerar = new Button();
            label2 = new Label();
            lstVector = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtTamaño
            // 
            txtTamaño.Location = new Point(32, 58);
            txtTamaño.Name = "txtTamaño";
            txtTamaño.Size = new Size(168, 23);
            txtTamaño.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 31);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "Tamaño del Vector";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(32, 117);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(168, 23);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar el Vector";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 99);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // lstVector
            // 
            lstVector.FormattingEnabled = true;
            lstVector.ItemHeight = 15;
            lstVector.Location = new Point(262, 58);
            lstVector.Name = "lstVector";
            lstVector.Size = new Size(186, 109);
            lstVector.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 31);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 5;
            label3.Text = "Mostrar el Vector";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lstVector);
            Controls.Add(label2);
            Controls.Add(btnGenerar);
            Controls.Add(label1);
            Controls.Add(txtTamaño);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTamaño;
        private Label label1;
        private Button btnGenerar;
        private Label label2;
        private ListBox lstVector;
        private Label label3;
    }
}
