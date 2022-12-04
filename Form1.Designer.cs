using System.Windows.Forms;

namespace ImgOps
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.loadDb = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pHook = new System.Windows.Forms.CheckBox();
            this.TestTab = new System.Windows.Forms.TabPage();
            this.testButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.HomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.TestTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 311);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 123);
            this.panel1.TabIndex = 0;
            // 
            // logBox
            // 
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.FormattingEnabled = true;
            this.logBox.Items.AddRange(new object[] {
            "Hey!"});
            this.logBox.Location = new System.Drawing.Point(0, 0);
            this.logBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(620, 123);
            this.logBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 311);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HomeTab);
            this.tabControl1.Controls.Add(this.TestTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 311);
            this.tabControl1.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.loadDb);
            this.HomeTab.Controls.Add(this.dgv);
            this.HomeTab.Controls.Add(this.pHook);
            this.HomeTab.Location = new System.Drawing.Point(4, 22);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeTab.Size = new System.Drawing.Size(612, 285);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // loadDb
            // 
            this.loadDb.Location = new System.Drawing.Point(0, 3);
            this.loadDb.Name = "loadDb";
            this.loadDb.Size = new System.Drawing.Size(75, 23);
            this.loadDb.TabIndex = 7;
            this.loadDb.Text = "Load DB";
            this.loadDb.UseVisualStyleBackColor = true;
            this.loadDb.Click += new System.EventHandler(this.loadDb_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(0, 29);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(612, 257);
            this.dgv.TabIndex = 6;
            // 
            // pHook
            // 
            this.pHook.AutoSize = true;
            this.pHook.Location = new System.Drawing.Point(81, 7);
            this.pHook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pHook.Name = "pHook";
            this.pHook.Size = new System.Drawing.Size(40, 17);
            this.pHook.TabIndex = 1;
            this.pHook.Text = "Go";
            this.pHook.UseVisualStyleBackColor = true;
            this.pHook.CheckedChanged += new System.EventHandler(this.pHook_CheckedChanged);
            // 
            // TestTab
            // 
            this.TestTab.Controls.Add(this.button1);
            this.TestTab.Controls.Add(this.testButton);
            this.TestTab.Location = new System.Drawing.Point(4, 22);
            this.TestTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TestTab.Name = "TestTab";
            this.TestTab.Size = new System.Drawing.Size(612, 285);
            this.TestTab.TabIndex = 2;
            this.TestTab.Text = "TestTab";
            this.TestTab.UseVisualStyleBackColor = true;
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.testButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.testButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.testButton.Location = new System.Drawing.Point(0, 0);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(612, 45);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(0, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(612, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Test_Disable";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "cigiHelper";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.TestTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        public ListBox logBox;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage HomeTab;
        private TabPage TestTab;
        private CheckBox pHook;
        private System.Windows.Forms.Timer timer1;
        public Button testButton;
        public DataGridView dgv;
        private Button loadDb;
        public Button button1;
    }
}