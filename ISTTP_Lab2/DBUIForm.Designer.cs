namespace ISTTP_Lab2
{
    partial class DBUIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBUIForm));
            this.tabTitles = new System.Windows.Forms.TabPage();
            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.tabClubs = new System.Windows.Forms.TabPage();
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTabControl = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTitles
            // 
            resources.ApplyResources(this.tabTitles, "tabTitles");
            this.tabTitles.Name = "tabTitles";
            this.tabTitles.UseVisualStyleBackColor = true;
            // 
            // tabPlayers
            // 
            resources.ApplyResources(this.tabPlayers, "tabPlayers");
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.UseVisualStyleBackColor = true;
            // 
            // tabClubs
            // 
            resources.ApplyResources(this.tabClubs, "tabClubs");
            this.tabClubs.Name = "tabClubs";
            this.tabClubs.UseVisualStyleBackColor = true;
            // 
            // clubBindingSource
            // 
            this.clubBindingSource.DataSource = typeof(FCDataEF.Club);
            // 
            // mainTabControl
            // 
            resources.ApplyResources(this.mainTabControl, "mainTabControl");
            this.mainTabControl.Controls.Add(this.tabClubs);
            this.mainTabControl.Controls.Add(this.tabPlayers);
            this.mainTabControl.Controls.Add(this.tabTitles);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            // 
            // DBUIForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTabControl);
            this.Name = "DBUIForm";
            this.Load += new System.EventHandler(this.DBUIForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabTitles;
        private System.Windows.Forms.TabPage tabPlayers;
        private System.Windows.Forms.TabPage tabClubs;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.BindingSource clubBindingSource;
    }
}

