
namespace WFA_AtYarisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.pbGunBatimi = new System.Windows.Forms.PictureBox();
            this.pbGolge = new System.Windows.Forms.PictureBox();
            this.pbRuzgar = new System.Windows.Forms.PictureBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGunBatimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGolge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRuzgar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(984, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(984, 23);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(984, 23);
            this.label3.TabIndex = 2;
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBaslat.Location = new System.Drawing.Point(869, 424);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(94, 31);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // pbGunBatimi
            // 
            this.pbGunBatimi.Image = global::WFA_AtYarisi.Properties.Resources.at3;
            this.pbGunBatimi.Location = new System.Drawing.Point(4, 306);
            this.pbGunBatimi.Name = "pbGunBatimi";
            this.pbGunBatimi.Size = new System.Drawing.Size(99, 68);
            this.pbGunBatimi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGunBatimi.TabIndex = 6;
            this.pbGunBatimi.TabStop = false;
            // 
            // pbGolge
            // 
            this.pbGolge.Image = global::WFA_AtYarisi.Properties.Resources.at2;
            this.pbGolge.Location = new System.Drawing.Point(4, 175);
            this.pbGolge.Name = "pbGolge";
            this.pbGolge.Size = new System.Drawing.Size(99, 68);
            this.pbGolge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGolge.TabIndex = 5;
            this.pbGolge.TabStop = false;
            // 
            // pbRuzgar
            // 
            this.pbRuzgar.Image = global::WFA_AtYarisi.Properties.Resources.at12;
            this.pbRuzgar.Location = new System.Drawing.Point(4, 38);
            this.pbRuzgar.Name = "pbRuzgar";
            this.pbRuzgar.Size = new System.Drawing.Size(99, 68);
            this.pbRuzgar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRuzgar.TabIndex = 4;
            this.pbRuzgar.TabStop = false;
            this.pbRuzgar.Tag = "";
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.Cyan;
            this.lblFinish.Location = new System.Drawing.Point(981, -1);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(21, 401);
            this.lblFinish.TabIndex = 7;
            this.lblFinish.Text = "F\r\nI\r\nN\r\nI\r\nS\r\nH";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(984, 23);
            this.label5.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1002, 467);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbGunBatimi);
            this.Controls.Add(this.pbGolge);
            this.Controls.Add(this.pbRuzgar);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbGunBatimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGolge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRuzgar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.PictureBox pbRuzgar;
        private System.Windows.Forms.PictureBox pbGolge;
        private System.Windows.Forms.PictureBox pbGunBatimi;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}

