namespace eProdavnica
{
    partial class FormMain
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
            TreeNode treeNode1 = new TreeNode("Kasa");
            TreeNode treeNode2 = new TreeNode("Sifarnik Artikla");
            TreeNode treeNode3 = new TreeNode("Sifarnik Partnera");
            TreeNode treeNode4 = new TreeNode("Sifarnik", new TreeNode[] { treeNode2, treeNode3 });
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelBaza = new Label();
            treeViewMeni = new TreeView();
            labelKorisnik = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1384, 761);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(labelBaza, 0, 1);
            tableLayoutPanel2.Controls.Add(treeViewMeni, 0, 2);
            tableLayoutPanel2.Controls.Add(labelKorisnik, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(232, 761);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelBaza
            // 
            labelBaza.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelBaza.BackColor = Color.Transparent;
            labelBaza.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelBaza.ForeColor = Color.Crimson;
            labelBaza.Location = new Point(0, 30);
            labelBaza.Margin = new Padding(0);
            labelBaza.Name = "labelBaza";
            labelBaza.Size = new Size(232, 25);
            labelBaza.TabIndex = 3;
            labelBaza.Text = "Baza";
            labelBaza.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // treeViewMeni
            // 
            treeViewMeni.BorderStyle = BorderStyle.None;
            treeViewMeni.Dock = DockStyle.Fill;
            treeViewMeni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            treeViewMeni.Location = new Point(0, 65);
            treeViewMeni.Margin = new Padding(0, 10, 0, 0);
            treeViewMeni.Name = "treeViewMeni";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Kasa";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Sifarnik Artikla";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Sifarnik Partnera";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Sifarnik";
            treeViewMeni.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode4 });
            treeViewMeni.Size = new Size(232, 715);
            treeViewMeni.TabIndex = 2;
            // 
            // labelKorisnik
            // 
            labelKorisnik.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelKorisnik.BackColor = Color.Transparent;
            labelKorisnik.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelKorisnik.ForeColor = Color.CornflowerBlue;
            labelKorisnik.Location = new Point(0, 0);
            labelKorisnik.Margin = new Padding(0);
            labelKorisnik.Name = "labelKorisnik";
            labelKorisnik.Size = new Size(232, 30);
            labelKorisnik.TabIndex = 1;
            labelKorisnik.Text = "Korisnik";
            labelKorisnik.TextAlign = ContentAlignment.BottomLeft;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1384, 761);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1400, 800);
            Name = "FormMain";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "eProdavnica - Main";
            Load += FormMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelBaza;
        private Label labelKorisnik;
        private TreeView treeViewMeni;
    }
}