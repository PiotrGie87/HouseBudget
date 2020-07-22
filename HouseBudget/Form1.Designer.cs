namespace HouseBudget
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
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lbCosts = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mojeKontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAllCosts = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.wydatkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojeWydatkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(145, 505);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(605, 20);
            this.tbCost.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa wydatku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wartość";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(145, 538);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(193, 20);
            this.tbAmount.TabIndex = 3;
            // 
            // lbCosts
            // 
            this.lbCosts.FormattingEnabled = true;
            this.lbCosts.Location = new System.Drawing.Point(45, 172);
            this.lbCosts.Name = "lbCosts";
            this.lbCosts.Size = new System.Drawing.Size(326, 277);
            this.lbCosts.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(448, 172);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(326, 277);
            this.listBox2.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(362, 538);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 47);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(62, 51);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(43, 13);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "SALDO";
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalanceValue.Location = new System.Drawing.Point(127, 50);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(100, 23);
            this.lblBalanceValue.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojeKontoToolStripMenuItem,
            this.wydatkiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mojeKontoToolStripMenuItem
            // 
            this.mojeKontoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2});
            this.mojeKontoToolStripMenuItem.Name = "mojeKontoToolStripMenuItem";
            this.mojeKontoToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.mojeKontoToolStripMenuItem.Text = "Moje Konto";
            this.mojeKontoToolStripMenuItem.Click += new System.EventHandler(this.mojeKontoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem1.Text = "Utwórz konto";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem3.Text = "Usuń konto";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem2.Text = "Zarządzaj kontem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "LICZBA WYDATKÓW";
            // 
            // lblAllCosts
            // 
            this.lblAllCosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAllCosts.Location = new System.Drawing.Point(402, 51);
            this.lblAllCosts.Name = "lblAllCosts";
            this.lblAllCosts.Size = new System.Drawing.Size(100, 23);
            this.lblAllCosts.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(528, 538);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 47);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // wydatkiToolStripMenuItem
            // 
            this.wydatkiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojeWydatkiToolStripMenuItem});
            this.wydatkiToolStripMenuItem.Name = "wydatkiToolStripMenuItem";
            this.wydatkiToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.wydatkiToolStripMenuItem.Text = "Wydatki";
            // 
            // mojeWydatkiToolStripMenuItem
            // 
            this.mojeWydatkiToolStripMenuItem.Name = "mojeWydatkiToolStripMenuItem";
            this.mojeWydatkiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mojeWydatkiToolStripMenuItem.Text = "Moje Wydatki";
            this.mojeWydatkiToolStripMenuItem.Click += new System.EventHandler(this.mojeWydatkiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 597);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblAllCosts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBalanceValue);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lbCosts);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.ListBox lbCosts;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mojeKontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        public System.Windows.Forms.Label lblBalanceValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAllCosts;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem wydatkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojeWydatkiToolStripMenuItem;
    }
}

