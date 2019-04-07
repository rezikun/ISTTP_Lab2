namespace ISTTP_Lab2
{
    partial class SearchDialog
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
            this.ClubNameTB = new System.Windows.Forms.TextBox();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.minTrackBar = new System.Windows.Forms.TrackBar();
            this.maxTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ClubNameTB
            // 
            this.ClubNameTB.Location = new System.Drawing.Point(34, 45);
            this.ClubNameTB.Name = "ClubNameTB";
            this.ClubNameTB.Size = new System.Drawing.Size(263, 31);
            this.ClubNameTB.TabIndex = 0;
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(34, 297);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(263, 31);
            this.DescriptionTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Club Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Min Date Of Foundation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(220, 343);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(168, 58);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // minTrackBar
            // 
            this.minTrackBar.Location = new System.Drawing.Point(22, 103);
            this.minTrackBar.Maximum = 2019;
            this.minTrackBar.Minimum = 1800;
            this.minTrackBar.Name = "minTrackBar";
            this.minTrackBar.Size = new System.Drawing.Size(260, 90);
            this.minTrackBar.TabIndex = 7;
            this.minTrackBar.Value = 1800;
            // 
            // maxTrackBar
            // 
            this.maxTrackBar.Location = new System.Drawing.Point(22, 188);
            this.maxTrackBar.Maximum = 2019;
            this.maxTrackBar.Minimum = 1800;
            this.maxTrackBar.Name = "maxTrackBar";
            this.maxTrackBar.Size = new System.Drawing.Size(260, 90);
            this.maxTrackBar.TabIndex = 8;
            this.maxTrackBar.Value = 1800;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Max Date Of Foundation";
            // 
            // SearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 472);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxTrackBar);
            this.Controls.Add(this.minTrackBar);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.ClubNameTB);
            this.Name = "SearchDialog";
            this.Text = "SearchDialog";
            ((System.ComponentModel.ISupportInitialize)(this.minTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClubNameTB;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TrackBar minTrackBar;
        private System.Windows.Forms.TrackBar maxTrackBar;
        private System.Windows.Forms.Label label4;
    }
}