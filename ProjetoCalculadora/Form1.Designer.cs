namespace ProjetoCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnTopo = new System.Windows.Forms.Panel();
            this.pnCentral = new System.Windows.Forms.Panel();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.pnOperadores = new System.Windows.Forms.Panel();
            this.pnTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTopo
            // 
            this.pnTopo.BackColor = System.Drawing.Color.Silver;
            this.pnTopo.Controls.Add(this.lbDisplay);
            this.pnTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopo.Location = new System.Drawing.Point(0, 0);
            this.pnTopo.Margin = new System.Windows.Forms.Padding(0);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Padding = new System.Windows.Forms.Padding(8);
            this.pnTopo.Size = new System.Drawing.Size(434, 84);
            this.pnTopo.TabIndex = 0;
            // 
            // pnCentral
            // 
            this.pnCentral.BackColor = System.Drawing.Color.Silver;
            this.pnCentral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCentral.Location = new System.Drawing.Point(0, 84);
            this.pnCentral.Name = "pnCentral";
            this.pnCentral.Size = new System.Drawing.Size(321, 677);
            this.pnCentral.TabIndex = 1;
            // 
            // lbDisplay
            // 
            this.lbDisplay.BackColor = System.Drawing.Color.Gainsboro;
            this.lbDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDisplay.Font = new System.Drawing.Font("Quartz MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay.Location = new System.Drawing.Point(8, 8);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(418, 68);
            this.lbDisplay.TabIndex = 0;
            this.lbDisplay.Text = "0";
            this.lbDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnOperadores
            // 
            this.pnOperadores.BackColor = System.Drawing.Color.Silver;
            this.pnOperadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnOperadores.Location = new System.Drawing.Point(321, 84);
            this.pnOperadores.Name = "pnOperadores";
            this.pnOperadores.Size = new System.Drawing.Size(113, 677);
            this.pnOperadores.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 761);
            this.Controls.Add(this.pnOperadores);
            this.Controls.Add(this.pnCentral);
            this.Controls.Add(this.pnTopo);
            this.Font = new System.Drawing.Font("Quartz MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnTopo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTopo;
        private System.Windows.Forms.Label lbDisplay;
        private System.Windows.Forms.Panel pnCentral;
        private System.Windows.Forms.Panel pnOperadores;
    }
}

