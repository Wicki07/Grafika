namespace Lab6
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tb2_c = new System.Windows.Forms.TextBox();
            this.tb2_b = new System.Windows.Forms.TextBox();
            this.tb2_a = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.Location = new System.Drawing.Point(1, 79);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(800, 400);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.x_Change);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "RysujFunkcje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb2_c
            // 
            this.tb2_c.Location = new System.Drawing.Point(329, 34);
            this.tb2_c.Margin = new System.Windows.Forms.Padding(2);
            this.tb2_c.Name = "tb2_c";
            this.tb2_c.Size = new System.Drawing.Size(25, 20);
            this.tb2_c.TabIndex = 6;
            this.tb2_c.Text = "1";
            this.tb2_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb2_b
            // 
            this.tb2_b.Location = new System.Drawing.Point(282, 34);
            this.tb2_b.Margin = new System.Windows.Forms.Padding(2);
            this.tb2_b.Name = "tb2_b";
            this.tb2_b.Size = new System.Drawing.Size(25, 20);
            this.tb2_b.TabIndex = 7;
            this.tb2_b.Text = "1";
            this.tb2_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb2_a
            // 
            this.tb2_a.Location = new System.Drawing.Point(224, 34);
            this.tb2_a.Margin = new System.Windows.Forms.Padding(2);
            this.tb2_a.Name = "tb2_a";
            this.tb2_a.Size = new System.Drawing.Size(25, 20);
            this.tb2_a.TabIndex = 8;
            this.tb2_a.Text = "1";
            this.tb2_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(308, 36);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "x +";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "x^2 +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "y =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.tb2_c);
            this.Controls.Add(this.tb2_b);
            this.Controls.Add(this.tb2_a);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb2_c;
        private System.Windows.Forms.TextBox tb2_b;
        private System.Windows.Forms.TextBox tb2_a;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

