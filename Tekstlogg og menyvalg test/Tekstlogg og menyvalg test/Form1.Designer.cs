namespace Tekstlogg_og_menyvalg_test
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonNW = new System.Windows.Forms.Button();
            this.buttonNE = new System.Windows.Forms.Button();
            this.buttonSW = new System.Windows.Forms.Button();
            this.buttonSE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Tekstlogg_og_menyvalg_test.Properties.Resources.BakgrunnRødStor;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1366, 768);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonNW
            // 
            this.buttonNW.Location = new System.Drawing.Point(393, 622);
            this.buttonNW.Name = "buttonNW";
            this.buttonNW.Size = new System.Drawing.Size(473, 58);
            this.buttonNW.TabIndex = 1;
            this.buttonNW.Text = "Ja";
            this.buttonNW.UseVisualStyleBackColor = true;
            this.buttonNW.Click += new System.EventHandler(this.buttonNW_Click);
            // 
            // buttonNE
            // 
            this.buttonNE.Location = new System.Drawing.Point(867, 622);
            this.buttonNE.Name = "buttonNE";
            this.buttonNE.Size = new System.Drawing.Size(473, 58);
            this.buttonNE.TabIndex = 2;
            this.buttonNE.Text = "Nei";
            this.buttonNE.UseVisualStyleBackColor = true;
            this.buttonNE.Click += new System.EventHandler(this.buttonNE_Click);
            // 
            // buttonSW
            // 
            this.buttonSW.Location = new System.Drawing.Point(393, 681);
            this.buttonSW.Name = "buttonSW";
            this.buttonSW.Size = new System.Drawing.Size(473, 58);
            this.buttonSW.TabIndex = 3;
            this.buttonSW.Text = "Handle";
            this.buttonSW.UseVisualStyleBackColor = true;
            this.buttonSW.Click += new System.EventHandler(this.buttonSW_Click);
            // 
            // buttonSE
            // 
            this.buttonSE.Location = new System.Drawing.Point(867, 681);
            this.buttonSE.Name = "buttonSE";
            this.buttonSE.Size = new System.Drawing.Size(473, 58);
            this.buttonSE.TabIndex = 4;
            this.buttonSE.Text = "plyndre";
            this.buttonSE.UseVisualStyleBackColor = true;
            this.buttonSE.Click += new System.EventHandler(this.buttonSE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.buttonSE);
            this.Controls.Add(this.buttonSW);
            this.Controls.Add(this.buttonNE);
            this.Controls.Add(this.buttonNW);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonNW;
        private System.Windows.Forms.Button buttonNE;
        private System.Windows.Forms.Button buttonSW;
        private System.Windows.Forms.Button buttonSE;
    }
}

