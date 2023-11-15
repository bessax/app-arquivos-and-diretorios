namespace app_arquivos_winforms
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cADASTROToolStripMenuItem = new ToolStripMenuItem();
            pETToolStripMenuItem = new ToolStripMenuItem();
            lISTAGEMToolStripMenuItem = new ToolStripMenuItem();
            sOBREToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cADASTROToolStripMenuItem, sOBREToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROToolStripMenuItem
            // 
            cADASTROToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pETToolStripMenuItem, lISTAGEMToolStripMenuItem });
            cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            cADASTROToolStripMenuItem.Size = new Size(79, 20);
            cADASTROToolStripMenuItem.Text = "CADASTRO";
            // 
            // pETToolStripMenuItem
            // 
            pETToolStripMenuItem.Name = "pETToolStripMenuItem";
            pETToolStripMenuItem.Size = new Size(180, 22);
            pETToolStripMenuItem.Text = "PET";
            pETToolStripMenuItem.Click += pETToolStripMenuItem_Click;
            // 
            // lISTAGEMToolStripMenuItem
            // 
            lISTAGEMToolStripMenuItem.Name = "lISTAGEMToolStripMenuItem";
            lISTAGEMToolStripMenuItem.Size = new Size(180, 22);
            lISTAGEMToolStripMenuItem.Text = "LISTAGEM";
            lISTAGEMToolStripMenuItem.Click += lISTAGEMToolStripMenuItem_Click;
            // 
            // sOBREToolStripMenuItem
            // 
            sOBREToolStripMenuItem.Name = "sOBREToolStripMenuItem";
            sOBREToolStripMenuItem.Size = new Size(54, 20);
            sOBREToolStripMenuItem.Text = "SOBRE";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            Text = "[SISTEMAS DE CADASTRO DE PET]";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cADASTROToolStripMenuItem;
        private ToolStripMenuItem sOBREToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem pETToolStripMenuItem;
        private ToolStripMenuItem lISTAGEMToolStripMenuItem;
    }
}