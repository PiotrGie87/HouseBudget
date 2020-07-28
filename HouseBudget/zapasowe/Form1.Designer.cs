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
            this.lbPayedCost = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojeKontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.wydatkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojeWydatkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagramyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAllCosts = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.showC = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panDetails = new System.Windows.Forms.Panel();
            this.lblPayed = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNotPayed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLbCosts = new System.Windows.Forms.Label();
            this.lblLbPayedCosts = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.cbTag = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEveryMonth = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.panDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(145, 429);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(227, 20);
            this.tbCost.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa wydatku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wartość";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(145, 455);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(111, 20);
            this.tbAmount.TabIndex = 3;
            // 
            // lbCosts
            // 
            this.lbCosts.FormattingEnabled = true;
            this.lbCosts.Location = new System.Drawing.Point(46, 165);
            this.lbCosts.Name = "lbCosts";
            this.lbCosts.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbCosts.Size = new System.Drawing.Size(326, 238);
            this.lbCosts.TabIndex = 4;
            // 
            // lbPayedCost
            // 
            this.lbPayedCost.FormattingEnabled = true;
            this.lbPayedCost.Location = new System.Drawing.Point(464, 165);
            this.lbPayedCost.Name = "lbPayedCost";
            this.lbPayedCost.Size = new System.Drawing.Size(326, 238);
            this.lbPayedCost.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(464, 429);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 99);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(54, 55);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(43, 13);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "SALDO";
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalanceValue.Location = new System.Drawing.Point(111, 50);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(100, 23);
            this.lblBalanceValue.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.mojeKontoToolStripMenuItem,
            this.wydatkiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
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
            // wydatkiToolStripMenuItem
            // 
            this.wydatkiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojeWydatkiToolStripMenuItem,
            this.diagramyToolStripMenuItem});
            this.wydatkiToolStripMenuItem.Name = "wydatkiToolStripMenuItem";
            this.wydatkiToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.wydatkiToolStripMenuItem.Text = "Wydatki";
            // 
            // mojeWydatkiToolStripMenuItem
            // 
            this.mojeWydatkiToolStripMenuItem.Name = "mojeWydatkiToolStripMenuItem";
            this.mojeWydatkiToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.mojeWydatkiToolStripMenuItem.Text = "Moje Wydatki";
            this.mojeWydatkiToolStripMenuItem.Click += new System.EventHandler(this.mojeWydatkiToolStripMenuItem_Click);
            // 
            // diagramyToolStripMenuItem
            // 
            this.diagramyToolStripMenuItem.Name = "diagramyToolStripMenuItem";
            this.diagramyToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.diagramyToolStripMenuItem.Text = "Diagramy";
            this.diagramyToolStripMenuItem.Click += new System.EventHandler(this.diagramyToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "LICZBA WYDATKÓW";
            // 
            // lblAllCosts
            // 
            this.lblAllCosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAllCosts.Location = new System.Drawing.Point(185, 9);
            this.lblAllCosts.Name = "lblAllCosts";
            this.lblAllCosts.Size = new System.Drawing.Size(45, 12);
            this.lblAllCosts.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(646, 429);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 98);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // showC
            // 
            this.showC.Location = new System.Drawing.Point(251, 50);
            this.showC.Name = "showC";
            this.showC.Size = new System.Drawing.Size(121, 23);
            this.showC.TabIndex = 13;
            this.showC.Text = "pokaż szczegóły";
            this.showC.UseVisualStyleBackColor = true;
            this.showC.Click += new System.EventHandler(this.showC_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(389, 207);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(60, 171);
            this.btnPay.TabIndex = 14;
            this.btnPay.Text = "Zapłać";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.txt";
            this.saveFileDialog1.Filter = "Plik tekstowy |*.txt|Wszystkie pliki|*.*";
            this.saveFileDialog1.FilterIndex = 2;
            this.saveFileDialog1.Title = "Wybierz plik do zapisu";
            // 
            // panDetails
            // 
            this.panDetails.Controls.Add(this.lblPayed);
            this.panDetails.Controls.Add(this.label8);
            this.panDetails.Controls.Add(this.lblNotPayed);
            this.panDetails.Controls.Add(this.label6);
            this.panDetails.Controls.Add(this.label3);
            this.panDetails.Controls.Add(this.lblAllCosts);
            this.panDetails.Location = new System.Drawing.Point(389, 27);
            this.panDetails.Name = "panDetails";
            this.panDetails.Size = new System.Drawing.Size(401, 72);
            this.panDetails.TabIndex = 15;
            this.panDetails.Visible = false;
            // 
            // lblPayed
            // 
            this.lblPayed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPayed.Location = new System.Drawing.Point(185, 45);
            this.lblPayed.Name = "lblPayed";
            this.lblPayed.Size = new System.Drawing.Size(45, 13);
            this.lblPayed.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "LICZBA WYD. OPŁACONYCH";
            // 
            // lblNotPayed
            // 
            this.lblNotPayed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNotPayed.Location = new System.Drawing.Point(185, 28);
            this.lblNotPayed.Name = "lblNotPayed";
            this.lblNotPayed.Size = new System.Drawing.Size(45, 13);
            this.lblNotPayed.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "LICZBA WYD. NIEOPŁACONYCH";
            // 
            // lblLbCosts
            // 
            this.lblLbCosts.AutoSize = true;
            this.lblLbCosts.Location = new System.Drawing.Point(145, 126);
            this.lblLbCosts.Name = "lblLbCosts";
            this.lblLbCosts.Size = new System.Drawing.Size(111, 13);
            this.lblLbCosts.TabIndex = 16;
            this.lblLbCosts.Text = "Wydatki Nieopłacone";
            // 
            // lblLbPayedCosts
            // 
            this.lblLbPayedCosts.AutoSize = true;
            this.lblLbPayedCosts.Location = new System.Drawing.Point(571, 126);
            this.lblLbPayedCosts.Name = "lblLbPayedCosts";
            this.lblLbPayedCosts.Size = new System.Drawing.Size(97, 13);
            this.lblLbPayedCosts.TabIndex = 17;
            this.lblLbPayedCosts.Text = "Wydatki Opłacone";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // cbTag
            // 
            this.cbTag.FormattingEnabled = true;
            this.cbTag.Items.AddRange(new object[] {
            "Dom/Mieszkanie",
            "Żywność",
            "Media",
            "Raty",
            "Samochód",
            "Hobby/Rozrywka",
            "Edukacja",
            "Inne"});
            this.cbTag.Location = new System.Drawing.Point(145, 481);
            this.cbTag.Name = "cbTag";
            this.cbTag.Size = new System.Drawing.Size(227, 21);
            this.cbTag.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Rodzaj";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(145, 508);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker.TabIndex = 20;
            this.dateTimePicker.Value = new System.DateTime(2020, 7, 27, 18, 11, 43, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Data płatności";
            // 
            // cbEveryMonth
            // 
            this.cbEveryMonth.AutoSize = true;
            this.cbEveryMonth.Location = new System.Drawing.Point(262, 457);
            this.cbEveryMonth.Name = "cbEveryMonth";
            this.cbEveryMonth.Size = new System.Drawing.Size(115, 17);
            this.cbEveryMonth.TabIndex = 22;
            this.cbEveryMonth.Text = "Wydatek cykliczny";
            this.cbEveryMonth.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 561);
            this.Controls.Add(this.cbEveryMonth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTag);
            this.Controls.Add(this.lblLbPayedCosts);
            this.Controls.Add(this.lblLbCosts);
            this.Controls.Add(this.panDetails);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.showC);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblBalanceValue);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbPayedCost);
            this.Controls.Add(this.lbCosts);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HouseBudget";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panDetails.ResumeLayout(false);
            this.panDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.ListBox lbCosts;
        private System.Windows.Forms.ListBox lbPayedCost;
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
        private System.Windows.Forms.Button showC;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.Panel panDetails;
        private System.Windows.Forms.Label lblLbCosts;
        private System.Windows.Forms.Label lblLbPayedCosts;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ComboBox cbTag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPayed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNotPayed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem diagramyToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbEveryMonth;
    }
}

