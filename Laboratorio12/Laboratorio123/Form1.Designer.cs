namespace Laboratorio123
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
            inputA = new TextBox();
            inputB = new TextBox();
            inputC = new TextBox();
            btnSemi = new Button();
            btnArea = new Button();
            btnReset = new Button();
            btnClose = new Button();
            label4 = new Label();
            label5 = new Label();
            textResultSem = new TextBox();
            textResultArea = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 32);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la longitud del lado A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 71);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese la longitud del lado B:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 111);
            label3.Name = "label3";
            label3.Size = new Size(164, 15);
            label3.TabIndex = 2;
            label3.Text = "Ingrese la longitud del lado C:";
            // 
            // inputA
            // 
            inputA.Location = new Point(271, 29);
            inputA.Name = "inputA";
            inputA.Size = new Size(100, 23);
            inputA.TabIndex = 3;
            // 
            // inputB
            // 
            inputB.Location = new Point(271, 68);
            inputB.Name = "inputB";
            inputB.Size = new Size(100, 23);
            inputB.TabIndex = 4;
            // 
            // inputC
            // 
            inputC.Location = new Point(271, 106);
            inputC.Name = "inputC";
            inputC.Size = new Size(100, 23);
            inputC.TabIndex = 5;
            // 
            // btnSemi
            // 
            btnSemi.Location = new Point(43, 155);
            btnSemi.Name = "btnSemi";
            btnSemi.Size = new Size(97, 23);
            btnSemi.TabIndex = 6;
            btnSemi.Text = "Semiperímetro";
            btnSemi.UseVisualStyleBackColor = true;
            btnSemi.Click += btnSemi_Click;
            // 
            // btnArea
            // 
            btnArea.Location = new Point(157, 155);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(75, 23);
            btnArea.TabIndex = 7;
            btnArea.Text = "Área";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(252, 155);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reiniciar";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(348, 155);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 9;
            btnClose.Text = "Salir";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 206);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 10;
            label4.Text = "Semiperímetro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 240);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 11;
            label5.Text = "Área: ";
            // 
            // textResultSem
            // 
            textResultSem.Location = new Point(271, 203);
            textResultSem.Name = "textResultSem";
            textResultSem.ReadOnly = true;
            textResultSem.Size = new Size(100, 23);
            textResultSem.TabIndex = 12;
            // 
            // textResultArea
            // 
            textResultArea.Location = new Point(271, 237);
            textResultArea.Name = "textResultArea";
            textResultArea.ReadOnly = true;
            textResultArea.Size = new Size(100, 23);
            textResultArea.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 314);
            Controls.Add(textResultArea);
            Controls.Add(textResultSem);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(btnArea);
            Controls.Add(btnSemi);
            Controls.Add(inputC);
            Controls.Add(inputB);
            Controls.Add(inputA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Triángulos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox inputA;
        private TextBox inputB;
        private TextBox inputC;
        private Button btnSemi;
        private Button btnArea;
        private Button btnReset;
        private Button btnClose;
        private Label label4;
        private Label label5;
        private TextBox textResultSem;
        private TextBox textResultArea;
    }
}
