namespace Calculadora_teste
{
    partial class Calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_caixa = new System.Windows.Forms.TextBox();
            this.lb_1 = new System.Windows.Forms.Button();
            this.lb_2 = new System.Windows.Forms.Button();
            this.lb_3 = new System.Windows.Forms.Button();
            this.lb_4 = new System.Windows.Forms.Button();
            this.lb_5 = new System.Windows.Forms.Button();
            this.lb_6 = new System.Windows.Forms.Button();
            this.lb_7 = new System.Windows.Forms.Button();
            this.lb_8 = new System.Windows.Forms.Button();
            this.lb_9 = new System.Windows.Forms.Button();
            this.lb_mais = new System.Windows.Forms.Button();
            this.lb_menos = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Button();
            this.lb_mult = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_caixa
            // 
            this.txt_caixa.Location = new System.Drawing.Point(7, 15);
            this.txt_caixa.Name = "txt_caixa";
            this.txt_caixa.Size = new System.Drawing.Size(178, 20);
            this.txt_caixa.TabIndex = 0;
            this.txt_caixa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_1
            // 
            this.lb_1.Location = new System.Drawing.Point(7, 133);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(40, 40);
            this.lb_1.TabIndex = 1;
            this.lb_1.Text = "1";
            this.lb_1.UseVisualStyleBackColor = true;
            this.lb_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_2
            // 
            this.lb_2.Location = new System.Drawing.Point(53, 133);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(40, 40);
            this.lb_2.TabIndex = 2;
            this.lb_2.Text = "2";
            this.lb_2.UseVisualStyleBackColor = true;
            this.lb_2.Click += new System.EventHandler(this.lb_2_Click);
            // 
            // lb_3
            // 
            this.lb_3.Location = new System.Drawing.Point(99, 133);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(40, 40);
            this.lb_3.TabIndex = 3;
            this.lb_3.Text = "3";
            this.lb_3.UseVisualStyleBackColor = true;
            this.lb_3.Click += new System.EventHandler(this.lb_3_Click);
            // 
            // lb_4
            // 
            this.lb_4.Location = new System.Drawing.Point(7, 87);
            this.lb_4.Name = "lb_4";
            this.lb_4.Size = new System.Drawing.Size(40, 40);
            this.lb_4.TabIndex = 4;
            this.lb_4.Text = "4";
            this.lb_4.UseVisualStyleBackColor = true;
            this.lb_4.Click += new System.EventHandler(this.lb_4_Click);
            // 
            // lb_5
            // 
            this.lb_5.Location = new System.Drawing.Point(53, 87);
            this.lb_5.Name = "lb_5";
            this.lb_5.Size = new System.Drawing.Size(40, 40);
            this.lb_5.TabIndex = 5;
            this.lb_5.Text = "5";
            this.lb_5.UseVisualStyleBackColor = true;
            this.lb_5.Click += new System.EventHandler(this.lb_5_Click);
            // 
            // lb_6
            // 
            this.lb_6.Location = new System.Drawing.Point(99, 87);
            this.lb_6.Name = "lb_6";
            this.lb_6.Size = new System.Drawing.Size(40, 40);
            this.lb_6.TabIndex = 6;
            this.lb_6.Text = "6";
            this.lb_6.UseVisualStyleBackColor = true;
            this.lb_6.Click += new System.EventHandler(this.lb_6_Click);
            // 
            // lb_7
            // 
            this.lb_7.Location = new System.Drawing.Point(7, 41);
            this.lb_7.Name = "lb_7";
            this.lb_7.Size = new System.Drawing.Size(40, 40);
            this.lb_7.TabIndex = 7;
            this.lb_7.Text = "7";
            this.lb_7.UseVisualStyleBackColor = true;
            this.lb_7.Click += new System.EventHandler(this.lb_7_Click);
            // 
            // lb_8
            // 
            this.lb_8.Location = new System.Drawing.Point(53, 41);
            this.lb_8.Name = "lb_8";
            this.lb_8.Size = new System.Drawing.Size(40, 40);
            this.lb_8.TabIndex = 8;
            this.lb_8.Text = "8";
            this.lb_8.UseVisualStyleBackColor = true;
            this.lb_8.Click += new System.EventHandler(this.lb_8_Click);
            // 
            // lb_9
            // 
            this.lb_9.Location = new System.Drawing.Point(99, 41);
            this.lb_9.Name = "lb_9";
            this.lb_9.Size = new System.Drawing.Size(40, 40);
            this.lb_9.TabIndex = 9;
            this.lb_9.Text = "9";
            this.lb_9.UseVisualStyleBackColor = true;
            this.lb_9.Click += new System.EventHandler(this.lb_9_Click);
            // 
            // lb_mais
            // 
            this.lb_mais.Location = new System.Drawing.Point(145, 41);
            this.lb_mais.Name = "lb_mais";
            this.lb_mais.Size = new System.Drawing.Size(40, 40);
            this.lb_mais.TabIndex = 10;
            this.lb_mais.Text = "+";
            this.lb_mais.UseVisualStyleBackColor = true;
            this.lb_mais.Click += new System.EventHandler(this.lb_mais_Click);
            // 
            // lb_menos
            // 
            this.lb_menos.Location = new System.Drawing.Point(145, 87);
            this.lb_menos.Name = "lb_menos";
            this.lb_menos.Size = new System.Drawing.Size(40, 40);
            this.lb_menos.TabIndex = 11;
            this.lb_menos.Text = "-";
            this.lb_menos.UseVisualStyleBackColor = true;
            this.lb_menos.Click += new System.EventHandler(this.lb_menos_Click);
            // 
            // lb_result
            // 
            this.lb_result.Location = new System.Drawing.Point(7, 217);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(132, 33);
            this.lb_result.TabIndex = 12;
            this.lb_result.Text = "=";
            this.lb_result.UseVisualStyleBackColor = true;
            this.lb_result.Click += new System.EventHandler(this.lb_result_Click);
            // 
            // lb_mult
            // 
            this.lb_mult.Location = new System.Drawing.Point(145, 133);
            this.lb_mult.Name = "lb_mult";
            this.lb_mult.Size = new System.Drawing.Size(40, 40);
            this.lb_mult.TabIndex = 13;
            this.lb_mult.Text = "x";
            this.lb_mult.UseVisualStyleBackColor = true;
            this.lb_mult.Click += new System.EventHandler(this.lb_mult_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(6, 256);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(177, 20);
            this.result.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 32);
            this.button2.TabIndex = 16;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 33);
            this.button3.TabIndex = 17;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(99, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 33);
            this.button4.TabIndex = 18;
            this.button4.Text = ",";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 297);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.lb_mult);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.lb_menos);
            this.Controls.Add(this.lb_mais);
            this.Controls.Add(this.lb_9);
            this.Controls.Add(this.lb_8);
            this.Controls.Add(this.lb_7);
            this.Controls.Add(this.lb_6);
            this.Controls.Add(this.lb_5);
            this.Controls.Add(this.lb_4);
            this.Controls.Add(this.lb_3);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.txt_caixa);
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_caixa;
        private System.Windows.Forms.Button lb_1;
        private System.Windows.Forms.Button lb_2;
        private System.Windows.Forms.Button lb_3;
        private System.Windows.Forms.Button lb_4;
        private System.Windows.Forms.Button lb_5;
        private System.Windows.Forms.Button lb_6;
        private System.Windows.Forms.Button lb_7;
        private System.Windows.Forms.Button lb_8;
        private System.Windows.Forms.Button lb_9;
        private System.Windows.Forms.Button lb_mais;
        private System.Windows.Forms.Button lb_menos;
        private System.Windows.Forms.Button lb_result;
        private System.Windows.Forms.Button lb_mult;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

