namespace TBDSchool
{
    partial class AnsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnsForm));
            this.ResBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.School_logo_PicBox = new System.Windows.Forms.PictureBox();
            this.LblFact = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.School_logo_PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ResBox
            // 
            this.ResBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ResBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResBox.DetectUrls = false;
            this.ResBox.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ResBox.Location = new System.Drawing.Point(12, 346);
            this.ResBox.Margin = new System.Windows.Forms.Padding(20, 75, 20, 75);
            this.ResBox.MaxLength = 186;
            this.ResBox.Name = "ResBox";
            this.ResBox.Size = new System.Drawing.Size(1879, 420);
            this.ResBox.TabIndex = 3;
            this.ResBox.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 904);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hilfe";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button2.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 806);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(769, 92);
            this.button2.TabIndex = 2;
            this.button2.Text = "Möchten Sie noch etwas fragen?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(936, 81);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hier kommt die Antwort!";
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // School_logo_PicBox
            // 
            this.School_logo_PicBox.Image = global::TBDSchool.Properties.Resources.edit_logo_school;
            this.School_logo_PicBox.Location = new System.Drawing.Point(1539, 12);
            this.School_logo_PicBox.Name = "School_logo_PicBox";
            this.School_logo_PicBox.Size = new System.Drawing.Size(342, 256);
            this.School_logo_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.School_logo_PicBox.TabIndex = 5;
            this.School_logo_PicBox.TabStop = false;
            // 
            // LblFact
            // 
            this.LblFact.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFact.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblFact.Location = new System.Drawing.Point(970, 12);
            this.LblFact.Margin = new System.Windows.Forms.Padding(3);
            this.LblFact.Name = "LblFact";
            this.LblFact.Size = new System.Drawing.Size(563, 256);
            this.LblFact.TabIndex = 4;
            this.LblFact.Text = resources.GetString("LblFact.Text");
            // 
            // AnsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.School_logo_PicBox);
            this.Controls.Add(this.LblFact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnsForm";
            this.Load += new System.EventHandler(this.AnsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.School_logo_PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ResBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox School_logo_PicBox;
        private System.Windows.Forms.Label LblFact;
    }
}