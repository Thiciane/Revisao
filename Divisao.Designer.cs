namespace POO_apresentacoes
{
    partial class Divisao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txB_valor2 = new System.Windows.Forms.TextBox();
            this.txB_valor1 = new System.Windows.Forms.TextBox();
            this.bt_resDivisao = new System.Windows.Forms.Button();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txB_valor2
            // 
            this.txB_valor2.Location = new System.Drawing.Point(129, 198);
            this.txB_valor2.Name = "txB_valor2";
            this.txB_valor2.Size = new System.Drawing.Size(142, 20);
            this.txB_valor2.TabIndex = 0;
            // 
            // txB_valor1
            // 
            this.txB_valor1.Location = new System.Drawing.Point(129, 122);
            this.txB_valor1.Name = "txB_valor1";
            this.txB_valor1.Size = new System.Drawing.Size(142, 20);
            this.txB_valor1.TabIndex = 1;
            // 
            // bt_resDivisao
            // 
            this.bt_resDivisao.Location = new System.Drawing.Point(129, 274);
            this.bt_resDivisao.Name = "bt_resDivisao";
            this.bt_resDivisao.Size = new System.Drawing.Size(142, 49);
            this.bt_resDivisao.TabIndex = 2;
            this.bt_resDivisao.Text = "Calcular";
            this.bt_resDivisao.UseVisualStyleBackColor = true;
            this.bt_resDivisao.Click += new System.EventHandler(this.bt_resDivisao_Click);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(185, 238);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(35, 13);
            this.lb_resultado.TabIndex = 3;
            this.lb_resultado.Text = "label1";
            // 
            // Divisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.bt_resDivisao);
            this.Controls.Add(this.txB_valor1);
            this.Controls.Add(this.txB_valor2);
            this.DoubleBuffered = true;
            this.Name = "Divisao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Divisao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txB_valor2;
        private System.Windows.Forms.TextBox txB_valor1;
        private System.Windows.Forms.Button bt_resDivisao;
        private System.Windows.Forms.Label lb_resultado;
    }
}