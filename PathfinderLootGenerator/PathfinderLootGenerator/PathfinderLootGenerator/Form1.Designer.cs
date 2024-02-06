namespace PathfinderLootGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tierOneButton = new System.Windows.Forms.Button();
            this.tierTwoButton = new System.Windows.Forms.Button();
            this.tierThreeButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ComboBox();
            this.backToTiersButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tierOneButton
            // 
            this.tierOneButton.Enabled = false;
            this.tierOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tierOneButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.tierOneButton.Location = new System.Drawing.Point(190, 185);
            this.tierOneButton.Name = "tierOneButton";
            this.tierOneButton.Size = new System.Drawing.Size(165, 120);
            this.tierOneButton.TabIndex = 2;
            this.tierOneButton.Text = "Tier 1";
            this.tierOneButton.UseVisualStyleBackColor = true;
            this.tierOneButton.Click += new System.EventHandler(this.tierOneButton_Click);
            // 
            // tierTwoButton
            // 
            this.tierTwoButton.Enabled = false;
            this.tierTwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tierTwoButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tierTwoButton.Location = new System.Drawing.Point(407, 185);
            this.tierTwoButton.Name = "tierTwoButton";
            this.tierTwoButton.Size = new System.Drawing.Size(165, 120);
            this.tierTwoButton.TabIndex = 3;
            this.tierTwoButton.Text = "Tier 2";
            this.tierTwoButton.UseVisualStyleBackColor = true;
            this.tierTwoButton.Click += new System.EventHandler(this.tierTwoButton_Click);
            // 
            // tierThreeButton
            // 
            this.tierThreeButton.Enabled = false;
            this.tierThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tierThreeButton.ForeColor = System.Drawing.Color.Crimson;
            this.tierThreeButton.Location = new System.Drawing.Point(621, 185);
            this.tierThreeButton.Name = "tierThreeButton";
            this.tierThreeButton.Size = new System.Drawing.Size(165, 120);
            this.tierThreeButton.TabIndex = 4;
            this.tierThreeButton.Text = "Tier 3";
            this.tierThreeButton.UseVisualStyleBackColor = true;
            this.tierThreeButton.Click += new System.EventHandler(this.tierThreeButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoLabel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(0, 24);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(984, 37);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "Load Excel file with items";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemsListBox
            // 
            this.itemsListBox.DropDownHeight = 200;
            this.itemsListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.IntegralHeight = false;
            this.itemsListBox.ItemHeight = 25;
            this.itemsListBox.Location = new System.Drawing.Point(221, 92);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(535, 33);
            this.itemsListBox.TabIndex = 7;
            this.itemsListBox.Visible = false;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.itemsListBox_SelectedIndexChanged);
            // 
            // backToTiersButton
            // 
            this.backToTiersButton.Location = new System.Drawing.Point(882, 27);
            this.backToTiersButton.Name = "backToTiersButton";
            this.backToTiersButton.Size = new System.Drawing.Size(90, 23);
            this.backToTiersButton.TabIndex = 8;
            this.backToTiersButton.Text = "Back to Tiers";
            this.backToTiersButton.UseVisualStyleBackColor = true;
            this.backToTiersButton.Click += new System.EventHandler(this.backToTiersButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.backToTiersButton);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.tierThreeButton);
            this.Controls.Add(this.tierTwoButton);
            this.Controls.Add(this.tierOneButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Pathfinder Loot Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button tierOneButton;
        private System.Windows.Forms.Button tierTwoButton;
        private System.Windows.Forms.Button tierThreeButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ComboBox itemsListBox;
        private System.Windows.Forms.Button backToTiersButton;
    }
}

