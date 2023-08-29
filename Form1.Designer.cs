namespace ejercicio_4_Laboratorio_1
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
            button1 = new Button();
            resultadolbl = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Atxt = new TextBox();
            Btxt = new TextBox();
            Ctxt = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(379, 147);
            button1.Name = "button1";
            button1.Size = new Size(146, 58);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resultadolbl
            // 
            resultadolbl.AutoSize = true;
            resultadolbl.BackColor = Color.FromArgb(255, 192, 192);
            resultadolbl.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            resultadolbl.Location = new Point(563, 154);
            resultadolbl.Name = "resultadolbl";
            resultadolbl.Size = new Size(129, 38);
            resultadolbl.TabIndex = 1;
            resultadolbl.Text = "              ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 57);
            label2.Name = "label2";
            label2.Size = new Size(125, 38);
            label2.TabIndex = 2;
            label2.Text = "Salon A :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 147);
            label3.Name = "label3";
            label3.Size = new Size(123, 38);
            label3.TabIndex = 3;
            label3.Text = "Salon B :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 229);
            label4.Name = "label4";
            label4.Size = new Size(124, 38);
            label4.TabIndex = 4;
            label4.Text = "Salon C :";
            // 
            // Atxt
            // 
            Atxt.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            Atxt.Location = new Point(195, 57);
            Atxt.Name = "Atxt";
            Atxt.Size = new Size(151, 45);
            Atxt.TabIndex = 5;
            // 
            // Btxt
            // 
            Btxt.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            Btxt.Location = new Point(195, 147);
            Btxt.Name = "Btxt";
            Btxt.Size = new Size(151, 45);
            Btxt.TabIndex = 6;
            // 
            // Ctxt
            // 
            Ctxt.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            Ctxt.Location = new Point(195, 226);
            Ctxt.Name = "Ctxt";
            Ctxt.Size = new Size(151, 45);
            Ctxt.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 321);
            Controls.Add(Ctxt);
            Controls.Add(Btxt);
            Controls.Add(Atxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(resultadolbl);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label resultadolbl;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Atxt;
        private TextBox Btxt;
        private TextBox Ctxt;
    }
}