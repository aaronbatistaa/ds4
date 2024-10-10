namespace Laboratorio122
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            inputNota1 = new TextBox();
            inputNota2 = new TextBox();
            inputNota3 = new TextBox();
            btnPromedio = new Button();
            btnReset = new Button();
            btnClose = new Button();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Nota Promedio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 46);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "NOTA No. 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 87);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "NOTA No. 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 130);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 3;
            label4.Text = "NOTA No. 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 214);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 4;
            label5.Text = "Nota Promedio";
            // 
            // inputNota1
            // 
            inputNota1.Location = new Point(154, 43);
            inputNota1.Name = "inputNota1";
            inputNota1.Size = new Size(100, 23);
            inputNota1.TabIndex = 5;
            // 
            // inputNota2
            // 
            inputNota2.Location = new Point(154, 84);
            inputNota2.Name = "inputNota2";
            inputNota2.Size = new Size(100, 23);
            inputNota2.TabIndex = 6;
            // 
            // inputNota3
            // 
            inputNota3.Location = new Point(154, 127);
            inputNota3.Name = "inputNota3";
            inputNota3.Size = new Size(100, 23);
            inputNota3.TabIndex = 7;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(63, 169);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(75, 23);
            btnPromedio.TabIndex = 8;
            btnPromedio.Text = "Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(157, 169);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reiniciar";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(252, 169);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 10;
            btnClose.Text = "Salir";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(164, 211);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 285);
            Controls.Add(textBox4);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(btnPromedio);
            Controls.Add(inputNota3);
            Controls.Add(inputNota2);
            Controls.Add(inputNota1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculadora de Promedio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        protected TextBox inputNota1;
        private TextBox inputNota2;
        private TextBox inputNota3;
        private Button btnPromedio;
        private Button btnReset;
        private Button btnClose;
        private TextBox textBox4;
    }
}
