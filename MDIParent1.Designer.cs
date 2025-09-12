namespace PG02_LAB09_MOSQUITO_LUIS
{
    partial class MDIParent1
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSTUDIANTESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dOCENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURSOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eSTUDIANTESToolStripMenuItem1,
            this.dOCENTEToolStripMenuItem,
            this.cURSOToolStripMenuItem,
            this.nOTASToolStripMenuItem});
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estudiantesToolStripMenuItem.Text = "EJERCICIOS";
            // 
            // eSTUDIANTESToolStripMenuItem1
            // 
            this.eSTUDIANTESToolStripMenuItem1.Name = "eSTUDIANTESToolStripMenuItem1";
            this.eSTUDIANTESToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.eSTUDIANTESToolStripMenuItem1.Text = "ESTUDIANTES";
            this.eSTUDIANTESToolStripMenuItem1.Click += new System.EventHandler(this.eSTUDIANTESToolStripMenuItem1_Click);
            // 
            // dOCENTEToolStripMenuItem
            // 
            this.dOCENTEToolStripMenuItem.Name = "dOCENTEToolStripMenuItem";
            this.dOCENTEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dOCENTEToolStripMenuItem.Text = "DOCENTE";
            this.dOCENTEToolStripMenuItem.Click += new System.EventHandler(this.dOCENTEToolStripMenuItem_Click);
            // 
            // cURSOToolStripMenuItem
            // 
            this.cURSOToolStripMenuItem.Name = "cURSOToolStripMenuItem";
            this.cURSOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cURSOToolStripMenuItem.Text = "CURSO";
            this.cURSOToolStripMenuItem.Click += new System.EventHandler(this.cURSOToolStripMenuItem_Click);
            // 
            // nOTASToolStripMenuItem
            // 
            this.nOTASToolStripMenuItem.Name = "nOTASToolStripMenuItem";
            this.nOTASToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nOTASToolStripMenuItem.Text = "NOTAS";
            this.nOTASToolStripMenuItem.Click += new System.EventHandler(this.nOTASToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eSTUDIANTESToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dOCENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURSOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTASToolStripMenuItem;
    }
}



