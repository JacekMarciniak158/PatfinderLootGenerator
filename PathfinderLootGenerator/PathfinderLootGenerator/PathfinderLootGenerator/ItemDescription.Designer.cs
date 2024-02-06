namespace PathfinderLootGenerator
{
    partial class ItemDescriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDescriptionForm));
            this.itemDescriptionRichBox = new System.Windows.Forms.RichTextBox();
            this.addItemToShop = new System.Windows.Forms.Button();
            this.shopTextBox = new System.Windows.Forms.RichTextBox();
            this.DeleteLastElement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemDescriptionRichBox
            // 
            resources.ApplyResources(this.itemDescriptionRichBox, "itemDescriptionRichBox");
            this.itemDescriptionRichBox.Name = "itemDescriptionRichBox";
            // 
            // addItemToShop
            // 
            resources.ApplyResources(this.addItemToShop, "addItemToShop");
            this.addItemToShop.Name = "addItemToShop";
            this.addItemToShop.UseVisualStyleBackColor = true;
            this.addItemToShop.Click += new System.EventHandler(this.AddItemToShop_Click);
            // 
            // shopTextBox
            // 
            resources.ApplyResources(this.shopTextBox, "shopTextBox");
            this.shopTextBox.Name = "shopTextBox";
            // 
            // DeleteLastElement
            // 
            resources.ApplyResources(this.DeleteLastElement, "DeleteLastElement");
            this.DeleteLastElement.Name = "DeleteLastElement";
            this.DeleteLastElement.UseVisualStyleBackColor = true;
            this.DeleteLastElement.Click += new System.EventHandler(this.DeleteLastElement_Click);
            // 
            // ItemDescriptionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteLastElement);
            this.Controls.Add(this.shopTextBox);
            this.Controls.Add(this.addItemToShop);
            this.Controls.Add(this.itemDescriptionRichBox);
            this.Name = "ItemDescriptionForm";
            this.Load += new System.EventHandler(this.ItemDescriptionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox itemDescriptionRichBox;
        private System.Windows.Forms.Button addItemToShop;
        private System.Windows.Forms.RichTextBox shopTextBox;
        private System.Windows.Forms.Button DeleteLastElement;
    }
}