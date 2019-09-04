namespace RenkKarsilastir
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
            this.button1 = new System.Windows.Forms.Button();
            this.f1 = new System.Windows.Forms.OpenFileDialog();
            this.f2 = new System.Windows.Forms.OpenFileDialog();
            this.r2 = new System.Windows.Forms.PictureBox();
            this.r1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.k = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.r2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "START COMPARING";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // f1
            // 
            this.f1.FileName = "f1";
            // 
            // f2
            // 
            this.f2.FileName = "openFileDialog2";
            // 
            // r2
            // 
            this.r2.Image = global::RenkKarsilastir.Properties.Resources.ResimYok;
            this.r2.Location = new System.Drawing.Point(393, 12);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(375, 340);
            this.r2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.r2.TabIndex = 6;
            this.r2.TabStop = false;
            this.r2.Click += new System.EventHandler(this.r2_Click);
            // 
            // r1
            // 
            this.r1.Image = global::RenkKarsilastir.Properties.Resources.ResimYok;
            this.r1.Location = new System.Drawing.Point(12, 12);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(375, 340);
            this.r1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.r1.TabIndex = 0;
            this.r1.TabStop = false;
            this.r1.Click += new System.EventHandler(this.r1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 358);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(618, 23);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseDown);
            // 
            // k
            // 
            this.k.Description = "ÇIKTI ALINACAK KLASORU SEÇİNİZ";
            this.k.SelectedPath = "C:\\Users\\3NB\\Desktop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "CURRENT PROCESS : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.r1);
            this.Name = "Form1";
            this.Text = "RESİM KARŞILAŞTIRICI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.r2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox r1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox r2;
        private System.Windows.Forms.OpenFileDialog f1;
        private System.Windows.Forms.OpenFileDialog f2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog k;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

