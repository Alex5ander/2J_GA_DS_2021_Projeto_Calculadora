﻿namespace ProjetoCalculadora
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
            this.pnFunc = new System.Windows.Forms.Panel();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.pnCentral = new System.Windows.Forms.Panel();
            this.pnOperadores = new System.Windows.Forms.Panel();
            this.pnTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTopo
            // 
            this.pnTopo.BackColor = System.Drawing.Color.Silver;
            this.pnTopo.Controls.Add(this.pnFunc);
            this.pnTopo.Controls.Add(this.lbDisplay);
            this.pnTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopo.Location = new System.Drawing.Point(0, 0);
            this.pnTopo.Margin = new System.Windows.Forms.Padding(0);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(434, 111);
            this.pnTopo.TabIndex = 0;
            // 
            // pnFunc
            // 
            this.pnFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFunc.Location = new System.Drawing.Point(0, 47);
            this.pnFunc.Name = "pnFunc";
            this.pnFunc.Size = new System.Drawing.Size(434, 64);
            this.pnFunc.TabIndex = 1;
            // 
            // lbDisplay
            // 
            this.lbDisplay.BackColor = System.Drawing.Color.Gainsboro;
            this.lbDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDisplay.Font = new System.Drawing.Font("Quartz MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay.Location = new System.Drawing.Point(0, 0);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(434, 47);
            this.lbDisplay.TabIndex = 0;
            this.lbDisplay.Text = "0";
            this.lbDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnCentral
            // 
            this.pnCentral.BackColor = System.Drawing.Color.Silver;
            this.pnCentral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCentral.Location = new System.Drawing.Point(0, 111);
            this.pnCentral.Name = "pnCentral";
            this.pnCentral.Size = new System.Drawing.Size(324, 650);
            this.pnCentral.TabIndex = 1;
            // 
            // pnOperadores
            // 
            this.pnOperadores.BackColor = System.Drawing.Color.Silver;
            this.pnOperadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnOperadores.Location = new System.Drawing.Point(324, 111);
            this.pnOperadores.Name = "pnOperadores";
            this.pnOperadores.Size = new System.Drawing.Size(110, 650);
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
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.Panel pnFunc;
    }
}

