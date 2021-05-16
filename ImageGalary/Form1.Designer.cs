using System.Drawing;
using System.Windows.Forms;

namespace ImageGalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new  SplitContainer();
            this.tableLayoutPanel1 = new  TableLayoutPanel();
            this.panel1 = new  Panel();
            this._searchBox = new  TextBox();
            this.panel2 = new Panel();
            this.pictureBox1 = new PictureBox();
            this.panel5 = new  Panel();
            this.Unmark = new  Button();
            this.panel4 = new  Panel();
            this.Save_Button = new  PictureBox();
            this._imageTileControl = new C1.Win.C1Tile.C1TileControl();
            this.statusStrip1 = new  StatusStrip();
            this.statusStrip = new  ToolStripProgressBar();
            this.group1 = new C1.Win.C1Tile.Group();
            this.tile1 = new C1.Win.C1Tile.Tile();
            this.panel3 = new  Panel();
            this._exportImage = new  PictureBox();
            this.c1PdfDocument1 = new C1.C1Pdf.C1PdfDocument();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Save_Button)).BeginInit();
            this._imageTileControl.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._exportImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock =  DockStyle.Fill;
            this.splitContainer1.FixedPanel =  FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new  Point(0, 0);
            this.splitContainer1.Margin = new  Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation =  Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Margin = new  Padding(2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor =  SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this._imageTileControl);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Margin = new  Padding(0, 3, 0, 0);
            this.splitContainer1.Size = new  Size(792, 763);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode =  AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new  ColumnStyle( SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new  ColumnStyle( SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new  ColumnStyle( SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Dock =  DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle =  TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new  Point(0, 0);
            this.tableLayoutPanel1.Margin = new  Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new  Padding(2);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new  RowStyle( SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new  Size(792, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._searchBox);
            this.panel1.Location = new  Point(199, 2);
            this.panel1.Margin = new  Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new  Size(295, 36);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new  PaintEventHandler(this.OnSearchPanelPaint);
            // 
            // _searchBox
            // 
            this._searchBox.BackColor =  SystemColors.Info;
            this._searchBox.Dock =  DockStyle.Bottom;
            this._searchBox.Font = new  Font("Segoe UI", 11F,  FontStyle.Regular,  GraphicsUnit.Point);
            this._searchBox.ForeColor =  SystemColors.ActiveCaptionText;
            this._searchBox.Location = new  Point(0, 0);
            this._searchBox.Margin = new  Padding(2);
            this._searchBox.Multiline = true;
            this._searchBox.Name = "_searchBox";
            this._searchBox.PlaceholderText = "Search Image";
            this._searchBox.Size = new  Size(295, 36);
            this._searchBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new  Point(494, 2);
            this.panel2.Margin = new  Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new  Size(40, 36);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle =  BorderStyle.FixedSingle;
            this.pictureBox1.Cursor =  Cursors.Hand;
            this.pictureBox1.Image = (( Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new  Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new  Size(40, 36);
            this.pictureBox1.SizeMode =  PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = (( AnchorStyles)(((( AnchorStyles.Top |  AnchorStyles.Bottom) 
            |  AnchorStyles.Left) 
            |  AnchorStyles.Right)));
            this.panel5.AutoSizeMode =  AutoSizeMode.GrowAndShrink;
            this.panel5.Controls.Add(this.Unmark);
            this.panel5.Location = new  Point(645, 4);
            this.panel5.Margin = new  Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new  Size(135, 30);
            this.panel5.TabIndex = 6;
            // 
            // Unmark
            // 
            this.Unmark.Anchor = AnchorStyles.Top |  AnchorStyles.Bottom |  AnchorStyles.Left|  AnchorStyles.Right;
            this.Unmark.BackColor =  SystemColors.ActiveCaptionText;
            this.Unmark.Font = new  Font("Segoe UI", 9F,  FontStyle.Bold,  GraphicsUnit.Point);
            this.Unmark.ForeColor =  SystemColors.ControlLightLight;
            this.Unmark.Location = new  Point(0, 0);
            this.Unmark.Name = "Unmark";
            this.Unmark.Size = new  Size(135, 30);
            this.Unmark.TabIndex = 5;
            this.Unmark.Text = "Mark All";
            this.Unmark.UseVisualStyleBackColor = false;
            this.Unmark.Visible = false;
            this.Unmark.Click += new System.EventHandler(this.Unmark_click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Save_Button);
            this.panel4.Location = new  Point(185, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new  Size(34, 28);
            this.panel4.TabIndex = 4;
            this.panel4.Visible = false;
            this.panel4.Click += new System.EventHandler(this.OnClickSave);
            // 
            // Save_Button
            // 
            this.Save_Button.BackColor =  SystemColors.Control;
            this.Save_Button.Dock =  DockStyle.Left;
            this.Save_Button.Image = (( Image)(resources.GetObject("Save_Button.Image")));
            this.Save_Button.Location = new  Point(0, 0);
            this.Save_Button.Margin = new  Padding(0);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new  Size(34, 28);
            this.Save_Button.SizeMode =  PictureBoxSizeMode.Zoom;
            this.Save_Button.TabIndex = 0;
            this.Save_Button.TabStop = false;
            this.Save_Button.Click += new System.EventHandler(this.OnClickSave);
            // 
            // _imageTileControl
            // 
            this._imageTileControl.CellHeight = 78;
            this._imageTileControl.CellSpacing = 11;
            this._imageTileControl.CellWidth = 78;
            this._imageTileControl.CheckBackColor =  Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this._imageTileControl.CheckBorderColor =  Color.Yellow;
            this._imageTileControl.CheckMarkColor =  Color.Brown;
            this._imageTileControl.Controls.Add(this.statusStrip1);
            this._imageTileControl.GroupForeColor =  Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._imageTileControl.Groups.Add(this.group1);
            this._imageTileControl.GroupSpacing = 1;
            this._imageTileControl.Location = new  Point(0, 44);
            this._imageTileControl.Margin = new  Padding(2);
            this._imageTileControl.MaximumRowsOrColumns = 20;
            this._imageTileControl.Name = "_imageTileControl";
            this._imageTileControl.Padding = new  Padding(2);
            this._imageTileControl.Size = new  Size(792, 675);
            this._imageTileControl.SurfacePadding = new  Padding(12, 4, 12, 4);
            this._imageTileControl.SwipeDistance = 10;
            this._imageTileControl.SwipeRearrangeDistance = 98;
            this._imageTileControl.TabIndex = 3;
            this._imageTileControl.TileChecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this.OnTileChecked);
            this._imageTileControl.TileUnchecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this.OnTileUnchecked);
            this._imageTileControl.Paint += new  PaintEventHandler(this.OnTileControlPaint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripMargin = new  Padding(0);
            this.statusStrip1.ImageScalingSize = new  Size(20, 20);
            this.statusStrip1.Items.AddRange(new  ToolStripItem[] {
            this.statusStrip});
            this.statusStrip1.Location = new  Point(0, 643);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new  Size(738, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new  Size(100, 14);
            this.statusStrip.Style =  ProgressBarStyle.Marquee;
            this.statusStrip.Visible = false;
            // 
            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Tiles.Add(this.tile1);
            // 
            // tile1
            // 
            this.tile1.Name = "tile1";
            this.tile1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._exportImage);
            this.panel3.Location = new  Point(29, 4);
            this.panel3.Margin = new  Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new  Size(135, 28);
            this.panel3.TabIndex = 2;
            // 
            // _exportImage
            // 
            this._exportImage.Anchor =  AnchorStyles.Top |  AnchorStyles.Bottom |  AnchorStyles.Left |  AnchorStyles.Right;
            this._exportImage.Image = (( Image)(resources.GetObject("_exportImage.Image")));
            this._exportImage.Location = new  Point(0, 0);
            this._exportImage.Margin = new  Padding(0);
            this._exportImage.Name = "_exportImage";
            this._exportImage.Size = new  Size(135, 28);
            this._exportImage.SizeMode =  PictureBoxSizeMode.StretchImage;
            this._exportImage.TabIndex = 0;
            this._exportImage.TabStop = false;
            this._exportImage.Visible = false;
            this._exportImage.Click += new System.EventHandler(this.ExportImage_Click);
            this._exportImage.Paint += new  PaintEventHandler(this.OnExportImagePaint);
            // 
            // c1PdfDocument1
            // 
            this.c1PdfDocument1.DocumentInfo.Author = "";
            this.c1PdfDocument1.DocumentInfo.CreationDate = new System.DateTime(((long)(0)));
            this.c1PdfDocument1.DocumentInfo.Creator = "";
            this.c1PdfDocument1.DocumentInfo.Keywords = "";
            this.c1PdfDocument1.DocumentInfo.Producer = "ComponentOne C1Pdf";
            this.c1PdfDocument1.DocumentInfo.Subject = "";
            this.c1PdfDocument1.DocumentInfo.Title = "";
            this.c1PdfDocument1.MaxHeaderBookmarkLevel = 0;
            this.c1PdfDocument1.PdfVersion = "1.3";
            this.c1PdfDocument1.RefDC = null;
            this.c1PdfDocument1.RotateAngle = 0F;
            this.c1PdfDocument1.UseFastTextOut = true;
            this.c1PdfDocument1.UseFontShaping = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new  SizeF(8F, 20F);
            this.AutoScaleMode =  AutoScaleMode.Font;
            this.BackColor =  SystemColors.ControlLightLight;
            this.ClientSize = new  Size(792, 763);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new  Size(810, 810);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition =  FormStartPosition.CenterParent;
            this.Text = "Image Galary";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Save_Button)).EndInit();
            this._imageTileControl.ResumeLayout(false);
            this._imageTileControl.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._exportImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private  SplitContainer splitContainer1;
        private  TableLayoutPanel tableLayoutPanel1;
        private  Panel panel1;
        private  TextBox _searchBox;
        private  Panel panel2;
        private  PictureBox pictureBox1;
        private  Panel panel3;
        private  PictureBox _exportImage;
        private  C1.Win.C1Tile.C1TileControl _imageTileControl;
        private  StatusStrip statusStrip1;
        private  ToolStripProgressBar statusStrip;
        private  C1.C1Pdf.C1PdfDocument c1PdfDocument1;
        private C1.Win.C1Tile.Group group1;
        private C1.Win.C1Tile.Tile tile1;
        private  Panel panel4;
        private  PictureBox Save_Button;
        private  Button Unmark;
        private  Panel panel5;
        
    }
}

