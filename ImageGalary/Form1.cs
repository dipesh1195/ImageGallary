using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using C1.Win.C1Tile;



namespace ImageGalary
{
    public partial class Form1 : Form 
    {
        
        public Form1()
        {
            InitializeComponent();

        }
         C1.C1Pdf.C1PdfDocument imagePdfDocument = new();
         DataFetcher datafetch = new ();
         List<Imageitem> imagesList;
         int checkedItems = 0;
         List<Image> images = new();





        private void AddTiles(List<Imageitem> imageList)
        {
            _imageTileControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left |  AnchorStyles.Right;
            _imageTileControl.Groups[0].Tiles.Clear();
            _imageTileControl.AllowChecking = true;
            _imageTileControl.AllowRearranging = true;
            _imageTileControl.BackColor = SystemColors.GradientInactiveCaption;
            foreach (var imageitem in imageList)
                {
                Tile tile = new();
                tile.HorizontalSize = 2;
                tile.VerticalSize = 2;
                _imageTileControl.Groups[0].Tiles.Add(tile);
                _imageTileControl.Orientation = LayoutOrientation.Vertical;
                Image img = Image.FromStream(new MemoryStream(imageitem.Base64));
                Template tl = new();
                ImageElement ie = new();
                ie.ImageLayout = ForeImageLayout.Stretch;
                tl.Elements.Add(ie);
                tile.Template = tl;
                tile.Image = img;
                tile.Visible = true;
                }
            
        }
        
           
        private async void PictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                statusStrip1.Visible = true;
                statusStrip.Visible = true;
                imagesList = await datafetch.GetImageData((_searchBox.Text.Trim()));
                if (imagesList.Count != 0)
                    AddTiles(imagesList);
                else
                    MessageBox.Show("No Image Found");

                statusStrip.Visible = false;
                statusStrip1.Visible = false;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            
        }
        
        
        
        //this method save selected images as pdf 
        private void ExportImage_Click(object sender, EventArgs e)
        {
            
            foreach (Tile tile in _imageTileControl.Groups[0].Tiles)
            {
                if(tile.Checked)//if tile is selected 
                    images.Add(tile.Image);//add selected images to List of images
            }
            ConvertToPdf(images); //calling ConvertToPdf mehod by passing List<Image> images as parameter
            SaveFileDialog saveFile = new(); 
            saveFile.DefaultExt = "pdf";
            saveFile.Filter = "PDF files (*.pdf)|*.pdf*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                imagePdfDocument.Save(saveFile.FileName); //saves created PDF file to user specified destination.
                MessageBox.Show("Saved PDF");
            }
            else
            {
                return;
            }

        }

        private void ConvertToPdf(List<Image> images)
        {
                RectangleF rect = imagePdfDocument.PageRectangle;
                bool firstPage = true;
                foreach (var selectedimg in images)
                {
                    if (!firstPage)
                    {
                        imagePdfDocument.NewPage();
                    }
                    firstPage = false;
                    rect.Inflate(-72,-72);
                    imagePdfDocument.DrawImage(selectedimg, rect);
                }
        }



        private void OnTileChecked(object sender, TileEventArgs e)
        {
            checkedItems++;  
            panel4.Visible = true;
            _exportImage.Visible = true;
            Unmark.Visible = true;
        }

        private void OnTileUnchecked(object sender, TileEventArgs e)
        {
            checkedItems--;
            panel4.Visible = checkedItems > 0;
            _exportImage.Visible = checkedItems > 0;
            Unmark.Visible = checkedItems > 0;
        }


        //this method saves selected images in user specified directory one by one
        private void OnClickSave(object sender, EventArgs e)
        {
            int i = 0;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.FileName = Convert.ToString(++i);
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.OverwritePrompt = false; 

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (Tile tile in _imageTileControl.Groups[0].Tiles)
                    { // check for marked tiles in group
                        if (tile.Checked)
                        {
                        
                            if (File.Exists(saveFileDialog1.FileName))
                            {
                                saveFileDialog1.FileName = Convert.ToString(++i);
                                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                                {    
                                    tile.Image.Save(saveFileDialog1.FileName);
                                }
                            }else
                                tile.Image.Save(saveFileDialog1.FileName);
                        }
                    }
                    MessageBox.Show("Image Saved");
                }
                
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }


        //Method for marking/unmarking all the images shown.
        Boolean mark = true;
        private void Unmark_click(object sender, EventArgs e)
        {
            if (mark == true){
                foreach (Tile tile in _imageTileControl.Groups[0].Tiles){
                    tile.Checked = true;
                }
                Unmark.Text = "UnMark";
            }
           if (mark == false)
            {
                checkedItems = 0;
                panel4.Visible = checkedItems > 0;
                _exportImage.Visible = checkedItems > 0;
                images.Clear();
                foreach (Tile tile in _imageTileControl.Groups[0].Tiles)
                {
                    tile.Checked = false;
                }
                Unmark.Text = "Mark All";
            }
            mark = !mark;
        }




        private void OnTileControlPaint(object sender, PaintEventArgs e)
        {
            Pen p = new(Color.LightGray);
            e.Graphics.DrawLine(p, 0, 0, 810, 0);
        }
        private void OnExportImagePaint(object sender, PaintEventArgs e)
        {
            Rectangle r = new(panel3.Location.X, panel3.Location.Y, panel3.Width, panel3.Height);
            r.X -= 29;
            r.Y -= 4;
            r.Width--;
            r.Height--;
            Pen p = new (Color.LightGray);
            e.Graphics.DrawRectangle(p, r);
            e.Graphics.DrawLine(p, new Point(0, 43), new Point(this.Width, 43));
        }

        private void OnSearchPanelPaint(object sender, PaintEventArgs e)
        {
            Rectangle r = _searchBox.Bounds;
            r.Inflate(3, 3);
            Pen p = new (Color.LightGray);
            e.Graphics.DrawRectangle(p, r);
        }

    }
}
