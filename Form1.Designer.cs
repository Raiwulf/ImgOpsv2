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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "kkek",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("kek2");
            this.panel1 = new System.Windows.Forms.Panel();
            this.logBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.matrixCheck = new System.Windows.Forms.Label();
            this.scanIntLabel = new System.Windows.Forms.Label();
            this.scanInt = new System.Windows.Forms.TextBox();
            this.processBox = new System.Windows.Forms.PictureBox();
            this.capturedView = new System.Windows.Forms.PictureBox();
            this.pName = new System.Windows.Forms.TextBox();
            this.pHook = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.importPicView = new System.Windows.Forms.PictureBox();
            this.importPicButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.addStateName = new System.Windows.Forms.TextBox();
            this.addStateButton = new System.Windows.Forms.Button();
            this.removeStateButton = new System.Windows.Forms.Button();
            this.statesList = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.testButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.importDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capturedView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importPicView)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 311);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.matrixCheck);
            this.tabPage1.Controls.Add(this.scanIntLabel);
            this.tabPage1.Controls.Add(this.scanInt);
            this.tabPage1.Controls.Add(this.processBox);
            this.tabPage1.Controls.Add(this.capturedView);
            this.tabPage1.Controls.Add(this.pName);
            this.tabPage1.Controls.Add(this.pHook);
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(612, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // matrixCheck
            // 
            this.matrixCheck.AutoSize = true;
            this.matrixCheck.Location = new System.Drawing.Point(573, 7);
            this.matrixCheck.Name = "matrixCheck";
            this.matrixCheck.Size = new System.Drawing.Size(35, 13);
            this.matrixCheck.TabIndex = 6;
            this.matrixCheck.Text = "label2";
            // 
            // scanIntLabel
            // 
            this.scanIntLabel.AutoSize = true;
            this.scanIntLabel.Location = new System.Drawing.Point(368, 7);
            this.scanIntLabel.Name = "scanIntLabel";
            this.scanIntLabel.Size = new System.Drawing.Size(119, 13);
            this.scanIntLabel.TabIndex = 5;
            this.scanIntLabel.Text = "Scan Interval (seconds)";
            // 
            // scanInt
            // 
            this.scanInt.Location = new System.Drawing.Point(277, 5);
            this.scanInt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scanInt.Name = "scanInt";
            this.scanInt.Size = new System.Drawing.Size(86, 20);
            this.scanInt.TabIndex = 4;
            // 
            // processBox
            // 
            this.processBox.Location = new System.Drawing.Point(362, 30);
            this.processBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processBox.Name = "processBox";
            this.processBox.Size = new System.Drawing.Size(252, 251);
            this.processBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.processBox.TabIndex = 3;
            this.processBox.TabStop = false;
            // 
            // capturedView
            // 
            this.capturedView.Location = new System.Drawing.Point(111, 30);
            this.capturedView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.capturedView.Name = "capturedView";
            this.capturedView.Size = new System.Drawing.Size(252, 251);
            this.capturedView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.capturedView.TabIndex = 3;
            this.capturedView.TabStop = false;
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(111, 5);
            this.pName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(86, 20);
            this.pName.TabIndex = 2;
            // 
            // pHook
            // 
            this.pHook.AutoSize = true;
            this.pHook.Location = new System.Drawing.Point(201, 7);
            this.pHook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pHook.Name = "pHook";
            this.pHook.Size = new System.Drawing.Size(80, 17);
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
            this.checkedListBox1.Location = new System.Drawing.Point(3, 2);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(103, 281);
            this.checkedListBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(612, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "States";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listView1);
            this.panel4.Controls.Add(this.importPicView);
            this.panel4.Controls.Add(this.importPicButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(174, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 281);
            this.panel4.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // importPicView
            // 
            this.importPicView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importPicView.Location = new System.Drawing.Point(0, 0);
            this.importPicView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.importPicView.Name = "importPicView";
            this.importPicView.Size = new System.Drawing.Size(435, 262);
            this.importPicView.TabIndex = 1;
            this.importPicView.TabStop = false;
            // 
            // importPicButton
            // 
            this.importPicButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.importPicButton.Location = new System.Drawing.Point(0, 262);
            this.importPicButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.importPicButton.Name = "importPicButton";
            this.importPicButton.Size = new System.Drawing.Size(435, 19);
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
            this.panel3.Location = new System.Drawing.Point(3, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 281);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "State Name:";
            // 
            // addStateName
            // 
            this.addStateName.Location = new System.Drawing.Point(69, 226);
            this.addStateName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addStateName.Name = "addStateName";
            this.addStateName.Size = new System.Drawing.Size(103, 20);
            this.addStateName.TabIndex = 5;
            // 
            // addStateButton
            // 
            this.addStateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addStateButton.Location = new System.Drawing.Point(0, 243);
            this.addStateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addStateButton.Name = "addStateButton";
            this.addStateButton.Size = new System.Drawing.Size(171, 19);
            this.addStateButton.TabIndex = 2;
            this.addStateButton.Text = "Add State";
            this.addStateButton.UseVisualStyleBackColor = true;
            this.addStateButton.Click += new System.EventHandler(this.addStateButton_Click);
            // 
            // removeStateButton
            // 
            this.removeStateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.removeStateButton.Location = new System.Drawing.Point(0, 262);
            this.removeStateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeStateButton.Name = "removeStateButton";
            this.removeStateButton.Size = new System.Drawing.Size(171, 19);
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
            "1_Login",
            "2_ServerPick",
            "3_CharacterPick",
            "4_SubPassword",
            "5_RunBot",
            "6_ListenBot"});
            this.statesList.Location = new System.Drawing.Point(0, 0);
            this.statesList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statesList.Name = "statesList";
            this.statesList.Size = new System.Drawing.Size(171, 281);
            this.statesList.Sorted = true;
            this.statesList.TabIndex = 1;
            this.statesList.SelectedIndexChanged += new System.EventHandler(this.statesList_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.testButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(612, 285);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(612, 285);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // importDialog
            // 
            this.importDialog.FileName = "openFileDialog1";
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capturedView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.importPicView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        public ListBox logBox;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel4;
        private PictureBox importPicView;
        private Button importPicButton;
        private Panel panel3;
        private Button addStateButton;
        private Button removeStateButton;
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
        private PictureBox processBox;
        private CheckedListBox statesList;
        private Button testButton;
        private CheckedListBox checkedListBox1;
        private ListView listView1;
    }
}