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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.matrixCheck = new System.Windows.Forms.Label();
            this.scanIntLabel = new System.Windows.Forms.Label();
            this.scanInt = new System.Windows.Forms.TextBox();
            this.capturedView = new System.Windows.Forms.PictureBox();
            this.pName = new System.Windows.Forms.TextBox();
            this.pHook = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.importPicView = new System.Windows.Forms.PictureBox();
            this.importPicButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.addStateName = new System.Windows.Forms.TextBox();
            this.addStateButton = new System.Windows.Forms.Button();
            this.removeStateButton = new System.Windows.Forms.Button();
            this.statesList = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.importDialog = new System.Windows.Forms.OpenFileDialog();
            this.resultBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capturedView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importPicView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 142);
            this.panel1.TabIndex = 0;
            // 
            // logBox
            // 
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.FormattingEnabled = true;
            this.logBox.ItemHeight = 15;
            this.logBox.Location = new System.Drawing.Point(0, 0);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(723, 142);
            this.logBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 359);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 359);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.resultBox);
            this.tabPage1.Controls.Add(this.matrixCheck);
            this.tabPage1.Controls.Add(this.scanIntLabel);
            this.tabPage1.Controls.Add(this.scanInt);
            this.tabPage1.Controls.Add(this.capturedView);
            this.tabPage1.Controls.Add(this.pName);
            this.tabPage1.Controls.Add(this.pHook);
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(715, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // matrixCheck
            // 
            this.matrixCheck.AutoSize = true;
            this.matrixCheck.Location = new System.Drawing.Point(669, 8);
            this.matrixCheck.Name = "matrixCheck";
            this.matrixCheck.Size = new System.Drawing.Size(38, 15);
            this.matrixCheck.TabIndex = 6;
            this.matrixCheck.Text = "label2";
            // 
            // scanIntLabel
            // 
            this.scanIntLabel.AutoSize = true;
            this.scanIntLabel.Location = new System.Drawing.Point(429, 8);
            this.scanIntLabel.Name = "scanIntLabel";
            this.scanIntLabel.Size = new System.Drawing.Size(128, 15);
            this.scanIntLabel.TabIndex = 5;
            this.scanIntLabel.Text = "Scan Interval (seconds)";
            // 
            // scanInt
            // 
            this.scanInt.Location = new System.Drawing.Point(323, 6);
            this.scanInt.Name = "scanInt";
            this.scanInt.Size = new System.Drawing.Size(100, 23);
            this.scanInt.TabIndex = 4;
            // 
            // capturedView
            // 
            this.capturedView.Location = new System.Drawing.Point(418, 33);
            this.capturedView.Name = "capturedView";
            this.capturedView.Size = new System.Drawing.Size(289, 144);
            this.capturedView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.capturedView.TabIndex = 3;
            this.capturedView.TabStop = false;
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(129, 6);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(100, 23);
            this.pName.TabIndex = 2;
            // 
            // pHook
            // 
            this.pHook.AutoSize = true;
            this.pHook.Location = new System.Drawing.Point(235, 8);
            this.pHook.Name = "pHook";
            this.pHook.Size = new System.Drawing.Size(83, 19);
            this.pHook.TabIndex = 1;
            this.pHook.Text = "checkBox1";
            this.pHook.UseVisualStyleBackColor = true;
            this.pHook.CheckedChanged += new System.EventHandler(this.pHook_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "PC1",
            "PC2",
            "PC3",
            "PC4",
            "PC5",
            "PC6",
            "PC7",
            "PC8",
            "PC9",
            "PC10",
            "PC11",
            "PC12"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 325);
            this.checkedListBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(715, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "States";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.importPicView);
            this.panel4.Controls.Add(this.importPicButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(203, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(509, 325);
            this.panel4.TabIndex = 1;
            // 
            // importPicView
            // 
            this.importPicView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importPicView.Location = new System.Drawing.Point(0, 0);
            this.importPicView.Name = "importPicView";
            this.importPicView.Size = new System.Drawing.Size(509, 303);
            this.importPicView.TabIndex = 1;
            this.importPicView.TabStop = false;
            // 
            // importPicButton
            // 
            this.importPicButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.importPicButton.Location = new System.Drawing.Point(0, 303);
            this.importPicButton.Name = "importPicButton";
            this.importPicButton.Size = new System.Drawing.Size(509, 22);
            this.importPicButton.TabIndex = 0;
            this.importPicButton.Text = "Import";
            this.importPicButton.UseVisualStyleBackColor = true;
            this.importPicButton.Click += new System.EventHandler(this.importPicButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.addStateName);
            this.panel3.Controls.Add(this.addStateButton);
            this.panel3.Controls.Add(this.removeStateButton);
            this.panel3.Controls.Add(this.statesList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 325);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "State Name:";
            // 
            // addStateName
            // 
            this.addStateName.Location = new System.Drawing.Point(80, 261);
            this.addStateName.Name = "addStateName";
            this.addStateName.Size = new System.Drawing.Size(120, 23);
            this.addStateName.TabIndex = 5;
            // 
            // addStateButton
            // 
            this.addStateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addStateButton.Location = new System.Drawing.Point(0, 281);
            this.addStateButton.Name = "addStateButton";
            this.addStateButton.Size = new System.Drawing.Size(200, 22);
            this.addStateButton.TabIndex = 2;
            this.addStateButton.Text = "Add State";
            this.addStateButton.UseVisualStyleBackColor = true;
            this.addStateButton.Click += new System.EventHandler(this.addStateButton_Click);
            // 
            // removeStateButton
            // 
            this.removeStateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.removeStateButton.Location = new System.Drawing.Point(0, 303);
            this.removeStateButton.Name = "removeStateButton";
            this.removeStateButton.Size = new System.Drawing.Size(200, 22);
            this.removeStateButton.TabIndex = 2;
            this.removeStateButton.Text = "Remove State";
            this.removeStateButton.UseVisualStyleBackColor = true;
            this.removeStateButton.Click += new System.EventHandler(this.removeStateButton_Click);
            // 
            // statesList
            // 
            this.statesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statesList.FormattingEnabled = true;
            this.statesList.Items.AddRange(new object[] {
            "ChannelPick",
            "CharacterPick",
            "Disconnected",
            "Login",
            "RunBot",
            "ServerPick",
            "SubPassword"});
            this.statesList.Location = new System.Drawing.Point(0, 0);
            this.statesList.Name = "statesList";
            this.statesList.Size = new System.Drawing.Size(200, 325);
            this.statesList.Sorted = true;
            this.statesList.TabIndex = 1;
            this.statesList.SelectedIndexChanged += new System.EventHandler(this.statesList_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(715, 331);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(715, 331);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // importDialog
            // 
            this.importDialog.FileName = "openFileDialog1";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(129, 146);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(273, 179);
            this.resultBox.TabIndex = 7;
            this.resultBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capturedView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.importPicView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ListBox logBox;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private CheckedListBox checkedListBox1;
        private TabPage tabPage2;
        private Panel panel4;
        private PictureBox importPicView;
        private Button importPicButton;
        private Panel panel3;
        private Button addStateButton;
        private Button removeStateButton;
        private CheckedListBox statesList;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox pName;
        private CheckBox pHook;
        private System.Windows.Forms.Timer timer1;
        private OpenFileDialog importDialog;
        private TextBox addStateName;
        private PictureBox capturedView;
        private Label scanIntLabel;
        private TextBox scanInt;
        private Label label1;
        private Label matrixCheck;
        private PictureBox resultBox;
    }
}