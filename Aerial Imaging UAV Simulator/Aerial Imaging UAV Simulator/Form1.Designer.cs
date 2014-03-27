namespace Aerial_Imaging_UAV_Simulator
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
            this.button1 = new System.Windows.Forms.Button();
            this.longTxtBox = new System.Windows.Forms.TextBox();
            this.latTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.takeImage = new System.Windows.Forms.Button();
            this.searchAdd = new System.Windows.Forms.Button();
            this.addText = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mapTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ariealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ariealWithLabelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUAVImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl11 = new Aerial_Imaging_UAV_Simulator.UserControl1();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // longTxtBox
            // 
            this.longTxtBox.Location = new System.Drawing.Point(12, 168);
            this.longTxtBox.Name = "longTxtBox";
            this.longTxtBox.Size = new System.Drawing.Size(100, 20);
            this.longTxtBox.TabIndex = 3;
            this.longTxtBox.TextChanged += new System.EventHandler(this.longTxtBox_TextChanged);
            // 
            // latTxtBox
            // 
            this.latTxtBox.Location = new System.Drawing.Point(12, 131);
            this.latTxtBox.Name = "latTxtBox";
            this.latTxtBox.Size = new System.Drawing.Size(100, 20);
            this.latTxtBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Longitude";
            // 
            // takeImage
            // 
            this.takeImage.Location = new System.Drawing.Point(13, 287);
            this.takeImage.Name = "takeImage";
            this.takeImage.Size = new System.Drawing.Size(75, 23);
            this.takeImage.TabIndex = 7;
            this.takeImage.Text = "Take Image";
            this.takeImage.UseVisualStyleBackColor = true;
            this.takeImage.Click += new System.EventHandler(this.takeImage_Click);
            // 
            // searchAdd
            // 
            this.searchAdd.Location = new System.Drawing.Point(13, 94);
            this.searchAdd.Name = "searchAdd";
            this.searchAdd.Size = new System.Drawing.Size(100, 23);
            this.searchAdd.TabIndex = 8;
            this.searchAdd.Text = "Search Address";
            this.searchAdd.UseVisualStyleBackColor = true;
            this.searchAdd.Click += new System.EventHandler(this.searchAdd_Click_1);
            // 
            // addText
            // 
            this.addText.Location = new System.Drawing.Point(13, 60);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(100, 20);
            this.addText.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click_1);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.mapTypeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomOutToolStripMenuItem,
            this.zoomToolStripMenuItem1,
            this.zoomToolStripMenuItem2});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem1
            // 
            this.zoomToolStripMenuItem1.Name = "zoomToolStripMenuItem1";
            this.zoomToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.zoomToolStripMenuItem1.Text = "Zoom+";
            this.zoomToolStripMenuItem1.Click += new System.EventHandler(this.zoomToolStripMenuItem1_Click);
            // 
            // zoomToolStripMenuItem2
            // 
            this.zoomToolStripMenuItem2.Name = "zoomToolStripMenuItem2";
            this.zoomToolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.zoomToolStripMenuItem2.Text = "Zoom++";
            this.zoomToolStripMenuItem2.Click += new System.EventHandler(this.zoomToolStripMenuItem2_Click);
            // 
            // mapTypeToolStripMenuItem
            // 
            this.mapTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roadToolStripMenuItem,
            this.ariealToolStripMenuItem,
            this.ariealWithLabelsToolStripMenuItem});
            this.mapTypeToolStripMenuItem.Name = "mapTypeToolStripMenuItem";
            this.mapTypeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.mapTypeToolStripMenuItem.Text = "Map Type";
            // 
            // roadToolStripMenuItem
            // 
            this.roadToolStripMenuItem.Name = "roadToolStripMenuItem";
            this.roadToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.roadToolStripMenuItem.Text = "Road";
            // 
            // ariealToolStripMenuItem
            // 
            this.ariealToolStripMenuItem.Name = "ariealToolStripMenuItem";
            this.ariealToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ariealToolStripMenuItem.Text = "Arieal ";
            // 
            // ariealWithLabelsToolStripMenuItem
            // 
            this.ariealWithLabelsToolStripMenuItem.Name = "ariealWithLabelsToolStripMenuItem";
            this.ariealWithLabelsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ariealWithLabelsToolStripMenuItem.Text = "Arieal with Labels";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUAVImagesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewUAVImagesToolStripMenuItem
            // 
            this.viewUAVImagesToolStripMenuItem.Name = "viewUAVImagesToolStripMenuItem";
            this.viewUAVImagesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.viewUAVImagesToolStripMenuItem.Text = "View UAV Images";
            this.viewUAVImagesToolStripMenuItem.Click += new System.EventHandler(this.viewUAVImagesToolStripMenuItem_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(254, 12);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(786, 557);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
            this.elementHost1.Child = this.userControl11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Start Simulation ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 615);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addText);
            this.Controls.Add(this.searchAdd);
            this.Controls.Add(this.takeImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.latTxtBox);
            this.Controls.Add(this.longTxtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "w";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private UserControl1 userControl11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox longTxtBox;
        private System.Windows.Forms.TextBox latTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button takeImage;
        private System.Windows.Forms.Button searchAdd;
        private System.Windows.Forms.TextBox addText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mapTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ariealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ariealWithLabelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUAVImagesToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button3;
      //  private System.Windows.Forms.Button takePhoto;

    }
}

