namespace DemirbasZimmet
{
    partial class BölümListesi
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
            this.dgvBolum = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolum)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBolum
            // 
            this.dgvBolum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBolum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBolum.Location = new System.Drawing.Point(0, 0);
            this.dgvBolum.Name = "dgvBolum";
            this.dgvBolum.Size = new System.Drawing.Size(598, 401);
            this.dgvBolum.TabIndex = 0;
            this.dgvBolum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBolum_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(419, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Seç";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BölümListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvBolum);
            this.Name = "BölümListesi";
            this.Text = "BölümListesi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBolum;
        private System.Windows.Forms.Button button1;
    }
}