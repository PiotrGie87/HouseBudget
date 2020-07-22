namespace HouseBudget
{
    partial class MyCost
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
            this.lvCosts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvCosts
            // 
            this.lvCosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvCosts.HideSelection = false;
            this.lvCosts.Location = new System.Drawing.Point(12, 12);
            this.lvCosts.Name = "lvCosts";
            this.lvCosts.Size = new System.Drawing.Size(254, 407);
            this.lvCosts.TabIndex = 0;
            this.lvCosts.UseCompatibleStateImageBehavior = false;
            this.lvCosts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nr";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nazwa wydatku";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kwota";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Opłacony";
            // 
            // MyCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 431);
            this.Controls.Add(this.lvCosts);
            this.Name = "MyCost";
            this.Text = "MyCost";
            this.Load += new System.EventHandler(this.MyCost_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView lvCosts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader4;
    }
}