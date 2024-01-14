namespace CalculadoraCsharp
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
            txtDatos = new TextBox();
            btnSuma = new Button();
            btnResta = new Button();
            btnIgual = new Button();
            btnValor1 = new Button();
            btnValor2 = new Button();
            btnValor3 = new Button();
            btnValor4 = new Button();
            btnValor5 = new Button();
            btnValor6 = new Button();
            btnValor7 = new Button();
            btnValor8 = new Button();
            btnValor9 = new Button();
            btnValor0 = new Button();
            btnMultiplicar = new Button();
            btnDivision = new Button();
            btnCe = new Button();
            btnBorrarTodo = new Button();
            SuspendLayout();
            // 
            // txtDatos
            // 
            txtDatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDatos.Location = new Point(14, 36);
            txtDatos.Margin = new Padding(3, 4, 3, 4);
            txtDatos.MaxLength = 21;
            txtDatos.Name = "txtDatos";
            txtDatos.ReadOnly = true;
            txtDatos.Size = new Size(300, 34);
            txtDatos.TabIndex = 0;
            txtDatos.Text = "0";
            txtDatos.TextAlign = HorizontalAlignment.Right;
            txtDatos.TextChanged += txtDatos_TextChanged;
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuma.Location = new Point(233, 241);
            btnSuma.Margin = new Padding(3, 4, 3, 4);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(48, 43);
            btnSuma.TabIndex = 1;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += clickOperador;
            // 
            // btnResta
            // 
            btnResta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnResta.Location = new Point(233, 191);
            btnResta.Margin = new Padding(3, 4, 3, 4);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(48, 43);
            btnResta.TabIndex = 2;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += clickOperador;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIgual.Location = new Point(173, 292);
            btnIgual.Margin = new Padding(3, 4, 3, 4);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(109, 40);
            btnIgual.TabIndex = 3;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += clickIGual;
            // 
            // btnValor1
            // 
            btnValor1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValor1.Location = new Point(58, 244);
            btnValor1.Margin = new Padding(3, 4, 3, 4);
            btnValor1.Name = "btnValor1";
            btnValor1.Size = new Size(50, 40);
            btnValor1.TabIndex = 4;
            btnValor1.Text = "1";
            btnValor1.UseVisualStyleBackColor = true;
            btnValor1.Click += agregarNumero;
            // 
            // btnValor2
            // 
            btnValor2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValor2.Location = new Point(115, 244);
            btnValor2.Margin = new Padding(3, 4, 3, 4);
            btnValor2.Name = "btnValor2";
            btnValor2.Size = new Size(50, 40);
            btnValor2.TabIndex = 5;
            btnValor2.Text = "2";
            btnValor2.UseVisualStyleBackColor = true;
            btnValor2.Click += agregarNumero;
            // 
            // btnValor3
            // 
            btnValor3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValor3.Location = new Point(173, 244);
            btnValor3.Margin = new Padding(3, 4, 3, 4);
            btnValor3.Name = "btnValor3";
            btnValor3.Size = new Size(50, 40);
            btnValor3.TabIndex = 6;
            btnValor3.Text = "3";
            btnValor3.UseVisualStyleBackColor = true;
            btnValor3.Click += agregarNumero;
            // 
            // btnValor4
            // 
            btnValor4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValor4.Location = new Point(58, 196);
            btnValor4.Margin = new Padding(3, 4, 3, 4);
            btnValor4.Name = "btnValor4";
            btnValor4.Size = new Size(50, 40);
            btnValor4.TabIndex = 7;
            btnValor4.Text = "4";
            btnValor4.UseVisualStyleBackColor = true;
            btnValor4.Click += agregarNumero;
            // 
            // btnValor5
            // 
            btnValor5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValor5.Location = new Point(115, 196);
            btnValor5.Margin = new Padding(3, 4, 3, 4);
            btnValor5.Name = "btnValor5";
            btnValor5.Size = new Size(50, 40);
            btnValor5.TabIndex = 8;
            btnValor5.Text = "5";
            btnValor5.UseVisualStyleBackColor = true;
            btnValor5.Click += agregarNumero;
            // 
            // btnValor6
            // 
            btnValor6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValor6.Location = new Point(173, 196);
            btnValor6.Margin = new Padding(3, 4, 3, 4);
            btnValor6.Name = "btnValor6";
            btnValor6.Size = new Size(50, 40);
            btnValor6.TabIndex = 9;
            btnValor6.Text = "6";
            btnValor6.UseVisualStyleBackColor = true;
            btnValor6.Click += agregarNumero;
            // 
            // btnValor7
            // 
            btnValor7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValor7.Location = new Point(58, 145);
            btnValor7.Margin = new Padding(3, 4, 3, 4);
            btnValor7.Name = "btnValor7";
            btnValor7.Size = new Size(50, 40);
            btnValor7.TabIndex = 10;
            btnValor7.Text = "7";
            btnValor7.UseVisualStyleBackColor = true;
            btnValor7.Click += agregarNumero;
            // 
            // btnValor8
            // 
            btnValor8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValor8.Location = new Point(117, 145);
            btnValor8.Margin = new Padding(3, 4, 3, 4);
            btnValor8.Name = "btnValor8";
            btnValor8.Size = new Size(50, 40);
            btnValor8.TabIndex = 11;
            btnValor8.Text = "8";
            btnValor8.UseVisualStyleBackColor = true;
            btnValor8.Click += agregarNumero;
            // 
            // btnValor9
            // 
            btnValor9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValor9.Location = new Point(173, 147);
            btnValor9.Margin = new Padding(3, 4, 3, 4);
            btnValor9.Name = "btnValor9";
            btnValor9.Size = new Size(50, 40);
            btnValor9.TabIndex = 12;
            btnValor9.Text = "9";
            btnValor9.UseVisualStyleBackColor = true;
            btnValor9.Click += agregarNumero;
            // 
            // btnValor0
            // 
            btnValor0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValor0.Location = new Point(115, 292);
            btnValor0.Margin = new Padding(3, 4, 3, 4);
            btnValor0.Name = "btnValor0";
            btnValor0.Size = new Size(50, 40);
            btnValor0.TabIndex = 13;
            btnValor0.Text = "0";
            btnValor0.UseVisualStyleBackColor = true;
            btnValor0.Click += agregarNumero;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplicar.Location = new Point(231, 147);
            btnMultiplicar.Margin = new Padding(3, 4, 3, 4);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(50, 40);
            btnMultiplicar.TabIndex = 14;
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += clickOperador;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivision.Location = new Point(231, 103);
            btnDivision.Margin = new Padding(3, 4, 3, 4);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(50, 40);
            btnDivision.TabIndex = 15;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += clickOperador;
            // 
            // btnCe
            // 
            btnCe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCe.Location = new Point(173, 103);
            btnCe.Margin = new Padding(3, 4, 3, 4);
            btnCe.Name = "btnCe";
            btnCe.Size = new Size(50, 40);
            btnCe.TabIndex = 16;
            btnCe.Text = "C";
            btnCe.UseVisualStyleBackColor = true;
            btnCe.Click += btnCe_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrarTodo.Location = new Point(115, 103);
            btnBorrarTodo.Margin = new Padding(3, 4, 3, 4);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(50, 40);
            btnBorrarTodo.TabIndex = 17;
            btnBorrarTodo.Text = "Ce";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnCe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 384);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnCe);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnValor0);
            Controls.Add(btnValor9);
            Controls.Add(btnValor8);
            Controls.Add(btnValor7);
            Controls.Add(btnValor6);
            Controls.Add(btnValor5);
            Controls.Add(btnValor4);
            Controls.Add(btnValor3);
            Controls.Add(btnValor2);
            Controls.Add(btnValor1);
            Controls.Add(btnIgual);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(txtDatos);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDatos;
        private Button btnSuma;
        private Button btnResta;
        private Button btnIgual;
        private Button btnValor1;
        private Button btnValor2;
        private Button btnValor3;
        private Button btnValor4;
        private Button btnValor5;
        private Button btnValor6;
        private Button btnValor7;
        private Button btnValor8;
        private Button btnValor9;
        private Button btnValor0;
        private Button btnMultiplicar;
        private Button btnDivision;
        private Button btnCe;
        private Button btnBorrarTodo;
    }
}