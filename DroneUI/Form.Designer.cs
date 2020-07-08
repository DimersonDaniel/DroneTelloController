namespace DroneUI
{
    partial class Form
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
            this.panel = new System.Windows.Forms.Panel();
            this.DText = new System.Windows.Forms.Label();
            this.WText = new System.Windows.Forms.Label();
            this.SText = new System.Windows.Forms.Label();
            this.AText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DimGray;
            this.panel.Controls.Add(this.button2);
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.DText);
            this.panel.Controls.Add(this.WText);
            this.panel.Controls.Add(this.SText);
            this.panel.Controls.Add(this.AText);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(817, 456);
            this.panel.TabIndex = 0;
            // 
            // DText
            // 
            this.DText.AutoSize = true;
            this.DText.BackColor = System.Drawing.Color.White;
            this.DText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DText.Location = new System.Drawing.Point(246, 195);
            this.DText.Name = "DText";
            this.DText.Size = new System.Drawing.Size(21, 20);
            this.DText.TabIndex = 8;
            this.DText.Text = "D";
            // 
            // WText
            // 
            this.WText.AutoSize = true;
            this.WText.BackColor = System.Drawing.Color.White;
            this.WText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WText.Location = new System.Drawing.Point(185, 142);
            this.WText.Name = "WText";
            this.WText.Size = new System.Drawing.Size(24, 20);
            this.WText.TabIndex = 7;
            this.WText.Text = "W";
            // 
            // SText
            // 
            this.SText.AutoSize = true;
            this.SText.BackColor = System.Drawing.Color.White;
            this.SText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SText.Location = new System.Drawing.Point(188, 243);
            this.SText.Name = "SText";
            this.SText.Size = new System.Drawing.Size(20, 20);
            this.SText.TabIndex = 6;
            this.SText.Text = "S";
            // 
            // AText
            // 
            this.AText.AutoSize = true;
            this.AText.BackColor = System.Drawing.Color.White;
            this.AText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AText.Location = new System.Drawing.Point(128, 195);
            this.AText.Name = "AText";
            this.AText.Size = new System.Drawing.Size(20, 20);
            this.AText.TabIndex = 5;
            this.AText.Text = "A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(110, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 456);
            this.Controls.Add(this.panel);
            this.Name = "Form";
            this.Text = "PanelControl";
            this.Load += new System.EventHandler(this.Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label DText;
        private System.Windows.Forms.Label WText;
        private System.Windows.Forms.Label SText;
        private System.Windows.Forms.Label AText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

