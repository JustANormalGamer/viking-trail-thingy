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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonNW = new System.Windows.Forms.Button();
            this.buttonNE = new System.Windows.Forms.Button();
            this.buttonSW = new System.Windows.Forms.Button();
            this.buttonSE = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pb_Reise = new System.Windows.Forms.PictureBox();
            this.Label_Panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pengerLabel = new System.Windows.Forms.Label();
            this.tidLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Reise)).BeginInit();
            this.Label_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNW
            // 
            this.buttonNW.Location = new System.Drawing.Point(393, 622);
            this.buttonNW.Name = "buttonNW";
            this.buttonNW.Size = new System.Drawing.Size(473, 58);
            this.buttonNW.TabIndex = 1;
            this.buttonNW.Text = "Ja";
            this.buttonNW.UseVisualStyleBackColor = true;
            this.buttonNW.Click += new System.EventHandler(this.Dialog_Click);
            // 
            // buttonNE
            // 
            this.buttonNE.Location = new System.Drawing.Point(867, 622);
            this.buttonNE.Name = "buttonNE";
            this.buttonNE.Size = new System.Drawing.Size(473, 58);
            this.buttonNE.TabIndex = 2;
            this.buttonNE.Text = "Nei";
            this.buttonNE.UseVisualStyleBackColor = true;
            this.buttonNE.Click += new System.EventHandler(this.Dialog_Click);
            // 
            // buttonSW
            // 
            this.buttonSW.Location = new System.Drawing.Point(393, 681);
            this.buttonSW.Name = "buttonSW";
            this.buttonSW.Size = new System.Drawing.Size(473, 58);
            this.buttonSW.TabIndex = 3;
            this.buttonSW.Text = "Handle";
            this.buttonSW.UseVisualStyleBackColor = true;
            this.buttonSW.Visible = false;
            this.buttonSW.Click += new System.EventHandler(this.Dialog_Click);
            // 
            // buttonSE
            // 
            this.buttonSE.Location = new System.Drawing.Point(867, 681);
            this.buttonSE.Name = "buttonSE";
            this.buttonSE.Size = new System.Drawing.Size(473, 58);
            this.buttonSE.TabIndex = 4;
            this.buttonSE.Text = "plyndre";
            this.buttonSE.UseVisualStyleBackColor = true;
            this.buttonSE.Visible = false;
            this.buttonSE.Click += new System.EventHandler(this.Dialog_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Red;
            this.pictureBox3.Location = new System.Drawing.Point(943, 252);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 10);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pb_Reise
            // 
            this.pb_Reise.BackgroundImage = global::Tekstlogg_og_menyvalg_test.Properties.Resources.under;
            this.pb_Reise.Location = new System.Drawing.Point(571, 23);
            this.pb_Reise.Name = "pb_Reise";
            this.pb_Reise.Size = new System.Drawing.Size(596, 568);
            this.pb_Reise.TabIndex = 8;
            this.pb_Reise.TabStop = false;
            this.pb_Reise.Visible = false;
            // 
            // Label_Panel
            // 
            this.Label_Panel.BackgroundImage = global::Tekstlogg_og_menyvalg_test.Properties.Resources.Label_Bakgrunn;
            this.Label_Panel.Controls.Add(this.label2);
            this.Label_Panel.Location = new System.Drawing.Point(25, 23);
            this.Label_Panel.Name = "Label_Panel";
            this.Label_Panel.Size = new System.Drawing.Size(337, 568);
            this.Label_Panel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Viking: Er du klar for å plyndre?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Tekstlogg_og_menyvalg_test.Properties.Resources.BakgrunnRødStor;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1367, 768);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pengerLabel
            // 
            this.pengerLabel.AutoSize = true;
            this.pengerLabel.BackColor = System.Drawing.Color.Transparent;
            this.pengerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengerLabel.Location = new System.Drawing.Point(58, 630);
            this.pengerLabel.Name = "pengerLabel";
            this.pengerLabel.Size = new System.Drawing.Size(29, 31);
            this.pengerLabel.TabIndex = 10;
            this.pengerLabel.Text = "0";
            // 
            // tidLabel
            // 
            this.tidLabel.AutoSize = true;
            this.tidLabel.BackColor = System.Drawing.Color.Transparent;
            this.tidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tidLabel.Location = new System.Drawing.Point(58, 689);
            this.tidLabel.Name = "tidLabel";
            this.tidLabel.Size = new System.Drawing.Size(86, 31);
            this.tidLabel.TabIndex = 12;
            this.tidLabel.Text = "Dag 1";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 768);
            this.panel1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(489, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 180);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Spill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tidLabel);
            this.Controls.Add(this.pengerLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pb_Reise);
            this.Controls.Add(this.Label_Panel);
            this.Controls.Add(this.buttonSE);
            this.Controls.Add(this.buttonSW);
            this.Controls.Add(this.buttonNE);
            this.Controls.Add(this.buttonNW);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Reise)).EndInit();
            this.Label_Panel.ResumeLayout(false);
            this.Label_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonNW;
        private System.Windows.Forms.Button buttonNE;
        private System.Windows.Forms.Button buttonSW;
        private System.Windows.Forms.Button buttonSE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Label_Panel;
        private System.Windows.Forms.PictureBox pb_Reise;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label pengerLabel;
        private System.Windows.Forms.Label tidLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

