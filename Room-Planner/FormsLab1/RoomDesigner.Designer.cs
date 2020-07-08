namespace FormsLab1
{
    partial class RoomDesigner
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBlueprintF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBlueprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBlueprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.leftPanelFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.rightPanelTable = new System.Windows.Forms.TableLayoutPanel();
            this.createdElementsGroupBox = new System.Windows.Forms.GroupBox();
            this.createdElementsListView = new System.Windows.Forms.ListView();
            this.buttonsGroupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CoffeeTable = new System.Windows.Forms.Button();
            this.DoubleBed = new System.Windows.Forms.Button();
            this.Sofa = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.Button();
            this.Wall = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.rightPanelTable.SuspendLayout();
            this.createdElementsGroupBox.SuspendLayout();
            this.buttonsGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBlueprintF2ToolStripMenuItem,
            this.openBlueprintToolStripMenuItem,
            this.saveBlueprintToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newBlueprintF2ToolStripMenuItem
            // 
            this.newBlueprintF2ToolStripMenuItem.Name = "newBlueprintF2ToolStripMenuItem";
            this.newBlueprintF2ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.newBlueprintF2ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.newBlueprintF2ToolStripMenuItem.Text = "New blueprint";
            this.newBlueprintF2ToolStripMenuItem.Click += new System.EventHandler(this.NewBlueprintMenuHandler);
            // 
            // openBlueprintToolStripMenuItem
            // 
            this.openBlueprintToolStripMenuItem.Name = "openBlueprintToolStripMenuItem";
            this.openBlueprintToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openBlueprintToolStripMenuItem.Text = "Open blueprint";
            this.openBlueprintToolStripMenuItem.Click += new System.EventHandler(this.OpenBlueprintMenuHandler);
            // 
            // saveBlueprintToolStripMenuItem
            // 
            this.saveBlueprintToolStripMenuItem.Name = "saveBlueprintToolStripMenuItem";
            this.saveBlueprintToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveBlueprintToolStripMenuItem.Text = "Save blueprint";
            this.saveBlueprintToolStripMenuItem.Click += new System.EventHandler(this.SaveBlueprintMenuHandler);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polskiToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // polskiToolStripMenuItem
            // 
            this.polskiToolStripMenuItem.Name = "polskiToolStripMenuItem";
            this.polskiToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.polskiToolStripMenuItem.Text = "Polski";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.leftPanelFlow);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rightPanelTable);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 538;
            this.splitContainer1.TabIndex = 1;
            // 
            // leftPanelFlow
            // 
            this.leftPanelFlow.AutoSize = true;
            this.leftPanelFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanelFlow.Location = new System.Drawing.Point(0, 0);
            this.leftPanelFlow.Name = "leftPanelFlow";
            this.leftPanelFlow.Size = new System.Drawing.Size(538, 426);
            this.leftPanelFlow.TabIndex = 0;
            this.leftPanelFlow.Resize += new System.EventHandler(this.LeftFlowPanelResize);
            // 
            // rightPanelTable
            // 
            this.rightPanelTable.ColumnCount = 1;
            this.rightPanelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rightPanelTable.Controls.Add(this.createdElementsGroupBox, 0, 1);
            this.rightPanelTable.Controls.Add(this.buttonsGroupBox, 0, 0);
            this.rightPanelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanelTable.Location = new System.Drawing.Point(0, 0);
            this.rightPanelTable.Name = "rightPanelTable";
            this.rightPanelTable.RowCount = 2;
            this.rightPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rightPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rightPanelTable.Size = new System.Drawing.Size(258, 426);
            this.rightPanelTable.TabIndex = 0;
            // 
            // createdElementsGroupBox
            // 
            this.createdElementsGroupBox.Controls.Add(this.createdElementsListView);
            this.createdElementsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createdElementsGroupBox.Location = new System.Drawing.Point(3, 216);
            this.createdElementsGroupBox.Name = "createdElementsGroupBox";
            this.createdElementsGroupBox.Size = new System.Drawing.Size(252, 207);
            this.createdElementsGroupBox.TabIndex = 1;
            this.createdElementsGroupBox.TabStop = false;
            this.createdElementsGroupBox.Text = "Created Elements";
            // 
            // createdElementsListView
            // 
            this.createdElementsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createdElementsListView.FullRowSelect = true;
            this.createdElementsListView.HideSelection = false;
            this.createdElementsListView.Location = new System.Drawing.Point(3, 16);
            this.createdElementsListView.Name = "createdElementsListView";
            this.createdElementsListView.Size = new System.Drawing.Size(246, 188);
            this.createdElementsListView.TabIndex = 0;
            this.createdElementsListView.UseCompatibleStateImageBehavior = false;
            this.createdElementsListView.View = System.Windows.Forms.View.List;
            this.createdElementsListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewSelect);
            // 
            // buttonsGroupBox
            // 
            this.buttonsGroupBox.Controls.Add(this.flowLayoutPanel1);
            this.buttonsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.buttonsGroupBox.Name = "buttonsGroupBox";
            this.buttonsGroupBox.Size = new System.Drawing.Size(252, 207);
            this.buttonsGroupBox.TabIndex = 2;
            this.buttonsGroupBox.TabStop = false;
            this.buttonsGroupBox.Text = "Add Elements";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.CoffeeTable);
            this.flowLayoutPanel1.Controls.Add(this.DoubleBed);
            this.flowLayoutPanel1.Controls.Add(this.Sofa);
            this.flowLayoutPanel1.Controls.Add(this.Table);
            this.flowLayoutPanel1.Controls.Add(this.Wall);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(246, 188);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // CoffeeTable
            // 
            this.CoffeeTable.BackColor = System.Drawing.Color.White;
            this.CoffeeTable.BackgroundImage = global::FormsLab1.Properties.Resources.coffee_table;
            this.CoffeeTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CoffeeTable.Location = new System.Drawing.Point(3, 3);
            this.CoffeeTable.Name = "CoffeeTable";
            this.CoffeeTable.Size = new System.Drawing.Size(75, 75);
            this.CoffeeTable.TabIndex = 0;
            this.CoffeeTable.UseVisualStyleBackColor = false;
            this.CoffeeTable.MouseEnter += new System.EventHandler(this.Button_MouseHover);
            this.CoffeeTable.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // DoubleBed
            // 
            this.DoubleBed.BackColor = System.Drawing.Color.White;
            this.DoubleBed.BackgroundImage = global::FormsLab1.Properties.Resources.double_bed;
            this.DoubleBed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoubleBed.Location = new System.Drawing.Point(84, 3);
            this.DoubleBed.Name = "DoubleBed";
            this.DoubleBed.Size = new System.Drawing.Size(75, 75);
            this.DoubleBed.TabIndex = 0;
            this.DoubleBed.UseVisualStyleBackColor = false;
            this.DoubleBed.MouseEnter += new System.EventHandler(this.Button_MouseHover);
            this.DoubleBed.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // Sofa
            // 
            this.Sofa.BackColor = System.Drawing.Color.White;
            this.Sofa.BackgroundImage = global::FormsLab1.Properties.Resources.sofa;
            this.Sofa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sofa.Location = new System.Drawing.Point(165, 3);
            this.Sofa.Name = "Sofa";
            this.Sofa.Size = new System.Drawing.Size(75, 75);
            this.Sofa.TabIndex = 0;
            this.Sofa.UseVisualStyleBackColor = false;
            this.Sofa.MouseEnter += new System.EventHandler(this.Button_MouseHover);
            this.Sofa.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // Table
            // 
            this.Table.BackColor = System.Drawing.Color.White;
            this.Table.BackgroundImage = global::FormsLab1.Properties.Resources.table;
            this.Table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Table.Location = new System.Drawing.Point(3, 84);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(75, 75);
            this.Table.TabIndex = 0;
            this.Table.UseVisualStyleBackColor = false;
            this.Table.MouseEnter += new System.EventHandler(this.Button_MouseHover);
            this.Table.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // Wall
            // 
            this.Wall.BackColor = System.Drawing.Color.White;
            this.Wall.BackgroundImage = global::FormsLab1.Properties.Resources.wall;
            this.Wall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Wall.Location = new System.Drawing.Point(84, 84);
            this.Wall.Name = "Wall";
            this.Wall.Size = new System.Drawing.Size(75, 75);
            this.Wall.TabIndex = 0;
            this.Wall.UseVisualStyleBackColor = false;
            this.Wall.MouseEnter += new System.EventHandler(this.Button_MouseHover);
            this.Wall.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // RoomDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "RoomDesigner";
            this.Text = "RoomDesigner";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownForm);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.rightPanelTable.ResumeLayout(false);
            this.createdElementsGroupBox.ResumeLayout(false);
            this.buttonsGroupBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBlueprintF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBlueprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBlueprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel leftPanelFlow;
        private System.Windows.Forms.TableLayoutPanel rightPanelTable;
        private System.Windows.Forms.GroupBox createdElementsGroupBox;
        private System.Windows.Forms.ListView createdElementsListView;
        private System.Windows.Forms.GroupBox buttonsGroupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CoffeeTable;
        private System.Windows.Forms.Button DoubleBed;
        private System.Windows.Forms.Button Sofa;
        private System.Windows.Forms.Button Table;
        private System.Windows.Forms.Button Wall;
    }
}

