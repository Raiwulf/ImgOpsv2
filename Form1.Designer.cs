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
            this.scanIntLabel = new System.Windows.Forms.Label();
            this.scanInt = new System.Windows.Forms.TextBox();
            this.pName = new System.Windows.Forms.TextBox();
            this.pHook = new System.Windows.Forms.CheckBox();
            this.StatesTab = new System.Windows.Forms.TabPage();
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
            this.pcId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.importDialog = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.char1pw = new System.Windows.Forms.TextBox();
            this.char2pw = new System.Windows.Forms.TextBox();
            this.char3pw = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.StatesTab.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importPicView)).BeginInit();
            this.panel3.SuspendLayout();
            this.TestTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ComputersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.HomeTab.Controls.Add(this.dataGridView1);
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
            this.StatesTab.Controls.Add(this.panel4);
            this.StatesTab.Controls.Add(this.panel3);
            this.StatesTab.Location = new System.Drawing.Point(4, 22);
            this.StatesTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatesTab.Name = "StatesTab";
            this.StatesTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatesTab.Size = new System.Drawing.Size(612, 285);
            this.StatesTab.TabIndex = 1;
            this.StatesTab.Text = "States";
            this.StatesTab.UseVisualStyleBackColor = true;
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
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.ComputersTab.Controls.Add(this.label10);
            this.ComputersTab.Controls.Add(this.label9);
            this.ComputersTab.Controls.Add(this.label8);
            this.ComputersTab.Controls.Add(this.addPC);
            this.ComputersTab.Controls.Add(this.char3pw);
            this.ComputersTab.Controls.Add(this.char2pw);
            this.ComputersTab.Controls.Add(this.char1pw);
            this.ComputersTab.Controls.Add(this.char1);
            this.ComputersTab.Controls.Add(this.webHook);
            this.ComputersTab.Controls.Add(this.char3);
            this.ComputersTab.Controls.Add(this.char2);
            this.ComputersTab.Controls.Add(this.pcName);
            this.ComputersTab.Controls.Add(this.pcId);
            this.ComputersTab.Controls.Add(this.label7);
            this.ComputersTab.Controls.Add(this.label6);
            this.ComputersTab.Controls.Add(this.label5);
            this.ComputersTab.Controls.Add(this.label4);
            this.ComputersTab.Controls.Add(this.label3);
            this.ComputersTab.Controls.Add(this.label2);
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
            // pcId
            // 
            this.pcId.Location = new System.Drawing.Point(70, 13);
            this.pcId.Name = "pcId";
            this.pcId.Size = new System.Drawing.Size(100, 20);
            this.pcId.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // importDialog
            // 
            this.importDialog.FileName = "openFileDialog1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Password: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Password: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Password: ";
            // 
            // char1pw
            // 
            this.char1pw.Location = new System.Drawing.Point(241, 79);
            this.char1pw.Name = "char1pw";
            this.char1pw.Size = new System.Drawing.Size(100, 20);
            this.char1pw.TabIndex = 1;
            // 
            // char2pw
            // 
            this.char2pw.Location = new System.Drawing.Point(241, 115);
            this.char2pw.Name = "char2pw";
            this.char2pw.Size = new System.Drawing.Size(100, 20);
            this.char2pw.TabIndex = 1;
            // 
            // char3pw
            // 
            this.char3pw.Location = new System.Drawing.Point(241, 148);
            this.char3pw.Name = "char3pw";
            this.char3pw.Size = new System.Drawing.Size(100, 20);
            this.char3pw.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 257);
            this.dataGridView1.TabIndex = 6;
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
            this.StatesTab.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.importPicView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.TestTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ComputersTab.ResumeLayout(false);
            this.ComputersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        public ListBox logBox;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage HomeTab;
        private TabPage StatesTab;
        private Panel panel4;
        private PictureBox importPicView;
        private Button importPicButton;
        private Panel panel3;
        private Button addStateButton;
        private Button removeStateButton;
        private TabPage TestTab;
        private TabPage ComputersTab;
        private TextBox pName;
        private CheckBox pHook;
        private System.Windows.Forms.Timer timer1;
        private OpenFileDialog importDialog;
        private TextBox addStateName;
        private Label scanIntLabel;
        private TextBox scanInt;
        private Label label1;
        private CheckedListBox statesList;
        private Button testButton;
        private ListView listView1;
        public PictureBox pictureBox1;
        public PictureBox pictureBox2;
        private Label label2;
        private TextBox char1;
        private TextBox webHook;
        private TextBox char3;
        private TextBox char2;
        private TextBox pcName;
        private TextBox pcId;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button addPC;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox char3pw;
        private TextBox char2pw;
        private TextBox char1pw;
        private DataGridView dataGridView1;
    }
}