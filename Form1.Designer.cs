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
            this.scanIntLabel = new System.Windows.Forms.Label();
            this.scanInt = new System.Windows.Forms.TextBox();
            this.pName = new System.Windows.Forms.TextBox();
            this.pHook = new System.Windows.Forms.CheckBox();
            this.StatesTab = new System.Windows.Forms.TabPage();
            this.TestTab = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.testButton = new System.Windows.Forms.Button();
            this.ComputersTab = new System.Windows.Forms.TabPage();
            this.addPC = new System.Windows.Forms.Button();
            this.char1 = new System.Windows.Forms.TextBox();
            this.webHook = new System.Windows.Forms.TextBox();
            this.char3 = new System.Windows.Forms.TextBox();
            this.char2 = new System.Windows.Forms.TextBox();
            this.pcName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.HomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.TestTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ComputersTab.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.StatesTab);
            this.tabControl1.Controls.Add(this.TestTab);
            this.tabControl1.Controls.Add(this.ComputersTab);
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
            this.HomeTab.Controls.Add(this.scanIntLabel);
            this.HomeTab.Controls.Add(this.scanInt);
            this.HomeTab.Controls.Add(this.pName);
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
            this.loadDb.Location = new System.Drawing.Point(146, 3);
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
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // scanIntLabel
            // 
            this.scanIntLabel.AutoSize = true;
            this.scanIntLabel.Location = new System.Drawing.Point(484, 6);
            this.scanIntLabel.Name = "scanIntLabel";
            this.scanIntLabel.Size = new System.Drawing.Size(119, 13);
            this.scanIntLabel.TabIndex = 5;
            this.scanIntLabel.Text = "Scan Interval (seconds)";
            // 
            // scanInt
            // 
            this.scanInt.Location = new System.Drawing.Point(393, 4);
            this.scanInt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scanInt.Name = "scanInt";
            this.scanInt.Size = new System.Drawing.Size(86, 20);
            this.scanInt.TabIndex = 4;
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(227, 4);
            this.pName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(86, 20);
            this.pName.TabIndex = 2;
            // 
            // pHook
            // 
            this.pHook.AutoSize = true;
            this.pHook.Location = new System.Drawing.Point(317, 6);
            this.pHook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pHook.Name = "pHook";
            this.pHook.Size = new System.Drawing.Size(80, 17);
            this.pHook.TabIndex = 1;
            this.pHook.Text = "checkBox1";
            this.pHook.UseVisualStyleBackColor = true;
            this.pHook.CheckedChanged += new System.EventHandler(this.pHook_CheckedChanged);
            // 
            // StatesTab
            // 
            this.StatesTab.Location = new System.Drawing.Point(4, 22);
            this.StatesTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatesTab.Name = "StatesTab";
            this.StatesTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatesTab.Size = new System.Drawing.Size(612, 285);
            this.StatesTab.TabIndex = 1;
            this.StatesTab.Text = "States";
            this.StatesTab.UseVisualStyleBackColor = true;
            // 
            // TestTab
            // 
            this.TestTab.Controls.Add(this.pictureBox2);
            this.TestTab.Controls.Add(this.pictureBox1);
            this.TestTab.Controls.Add(this.testButton);
            this.TestTab.Location = new System.Drawing.Point(4, 22);
            this.TestTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TestTab.Name = "TestTab";
            this.TestTab.Size = new System.Drawing.Size(612, 285);
            this.TestTab.TabIndex = 2;
            this.TestTab.Text = "tabPage3";
            this.TestTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(189, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(415, 256);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 87);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(537, 262);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // ComputersTab
            // 
            this.ComputersTab.Controls.Add(this.addPC);
            this.ComputersTab.Controls.Add(this.char1);
            this.ComputersTab.Controls.Add(this.webHook);
            this.ComputersTab.Controls.Add(this.char3);
            this.ComputersTab.Controls.Add(this.char2);
            this.ComputersTab.Controls.Add(this.pcName);
            this.ComputersTab.Controls.Add(this.label7);
            this.ComputersTab.Controls.Add(this.label6);
            this.ComputersTab.Controls.Add(this.label5);
            this.ComputersTab.Controls.Add(this.label4);
            this.ComputersTab.Controls.Add(this.label3);
            this.ComputersTab.Location = new System.Drawing.Point(4, 22);
            this.ComputersTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComputersTab.Name = "ComputersTab";
            this.ComputersTab.Size = new System.Drawing.Size(612, 285);
            this.ComputersTab.TabIndex = 3;
            this.ComputersTab.Text = "PC";
            this.ComputersTab.UseVisualStyleBackColor = true;
            // 
            // addPC
            // 
            this.addPC.Location = new System.Drawing.Point(11, 218);
            this.addPC.Name = "addPC";
            this.addPC.Size = new System.Drawing.Size(75, 23);
            this.addPC.TabIndex = 2;
            this.addPC.Text = "AddPC";
            this.addPC.UseVisualStyleBackColor = true;
            this.addPC.Click += new System.EventHandler(this.addPC_Click_1);
            // 
            // char1
            // 
            this.char1.Location = new System.Drawing.Point(70, 79);
            this.char1.Name = "char1";
            this.char1.Size = new System.Drawing.Size(100, 20);
            this.char1.TabIndex = 1;
            // 
            // webHook
            // 
            this.webHook.Location = new System.Drawing.Point(70, 179);
            this.webHook.Name = "webHook";
            this.webHook.Size = new System.Drawing.Size(100, 20);
            this.webHook.TabIndex = 1;
            // 
            // char3
            // 
            this.char3.Location = new System.Drawing.Point(70, 148);
            this.char3.Name = "char3";
            this.char3.Size = new System.Drawing.Size(100, 20);
            this.char3.TabIndex = 1;
            // 
            // char2
            // 
            this.char2.Location = new System.Drawing.Point(70, 115);
            this.char2.Name = "char2";
            this.char2.Size = new System.Drawing.Size(100, 20);
            this.char2.TabIndex = 1;
            // 
            // pcName
            // 
            this.pcName.Location = new System.Drawing.Point(70, 45);
            this.pcName.Name = "pcName";
            this.pcName.Size = new System.Drawing.Size(100, 20);
            this.pcName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "WebHook";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Char3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Char2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Char1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
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
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.TestTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ComputersTab.ResumeLayout(false);
            this.ComputersTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        public ListBox logBox;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage HomeTab;
        private TabPage StatesTab;
        private TabPage TestTab;
        private TabPage ComputersTab;
        private TextBox pName;
        private CheckBox pHook;
        private System.Windows.Forms.Timer timer1;
        private Label scanIntLabel;
        private TextBox scanInt;
        private Button testButton;
        public PictureBox pictureBox1;
        public PictureBox pictureBox2;
        private TextBox char1;
        private TextBox webHook;
        private TextBox char3;
        private TextBox char2;
        private TextBox pcName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button addPC;
        public DataGridView dgv;
        private Button loadDb;
    }
}