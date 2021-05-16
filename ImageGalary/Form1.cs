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
        C1.C1Pdf.C1PdfDocument imagePdfDocument = new C1.C1Pdf.C1PdfDocument();
        DataFetcher datafetch = new DataFetcher();
        List<Imageitem> imagesList;
        int checkedItems = 0;
        List<Image> images = new List<Image>();



        private void AddTiles(List<Imageitem> imageList)
        {
            
                _imageTileControl.Groups[0].Tiles.Clear();
                foreach (var imageitem in imageList)
                {
                Tile tile = new Tile();
                tile.HorizontalSize = 2;
                tile.VerticalSize = 2;
                _imageTileControl.Groups[0].Tiles.Add(tile);
                _imageTileControl.Orientation = LayoutOrientation.Vertical;
                Image img = Image.FromStream(new MemoryStream(imageitem.Base64));
                Template tl = new Template();
                ImageElement ie = new ImageElement();
                ie.ImageLayout = ForeImageLayout.Stretch;
                tl.Elements.Add(ie);
                tile.Template = tl;
                tile.Image = img;
                tile.Visible = true;
                }
            
        }
        
           
        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
            statusStrip.Visible = true;
            imagesList = await datafetch.GetImageData((_searchBox.Text.Trim()));
            AddTiles(imagesList);
            statusStrip.Visible = false;
            statusStrip1.Visible = false;
        }
        
        
        

        private void _exportImage_Click(object sender, EventArgs e)
        {
            
            foreach (Tile tile in _imageTileControl.Groups[0].Tiles)
            {
                if(tile.Checked)
                    images.Add(tile.Image);
            }
            ConvertToPdf(images);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "pdf";
            saveFile.Filter = "PDF files (*.pdf)|*.pdf*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {

                imagePdfDocument.Save(saveFile.FileName);
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
                    rect.Inflate(-72, -72);
                    imagePdfDocument.DrawImage(selectedimg, rect);
                }
        }

        private void OnTileControlPaint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawLine(p, 0, 0, 810, 0);
        }
        private void OnExportImagePaint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(panel3.Location.X, panel3.Location.Y, panel3.Width, panel3.Height);
                r.X -= 29;
                r.Y -= 4;
                r.Width--;
                r.Height--;
                Pen p = new Pen(Color.LightGray);
                e.Graphics.DrawRectangle(p, r);
                e.Graphics.DrawLine(p, new Point(0, 43), new Point(this.Width, 43));
        }

        private void OnSearchPanelPaint(object sender, PaintEventArgs e)
        {
            Rectangle r = _searchBox.Bounds;
            r.Inflate(3, 3);
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawRectangle(p, r);
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

        private void OnClickSave(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            try
            {
                foreach (Tile tile in _imageTileControl.Groups[0].Tiles)
                { // check for marked tiles in group
                    if (tile.Checked)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        { 
                        tile.Image.Save(saveFileDialog1.FileName);
                        }
                        else
                        {
                            return;
                        }
                    }}
                MessageBox.Show("Saved Image");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        Boolean mark = true;

        private void unmark(object sender, EventArgs e)
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
    }
}
