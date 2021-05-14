﻿using System;
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
            imagesList = await datafetch.GetImageData(_searchBox.Text);
            AddTiles(imagesList);
            _exportImage.Visible = true;
            statusStrip.Visible = false;
            statusStrip1.Visible = false;



        }
        
        
        

        private void _exportImage_Click(object sender, EventArgs e)
        {
            List<Image> images = new List<Image>();
            foreach (Tile tile in _imageTileControl.Groups[0].Tiles)
            {
                    images.Add(tile.Image);
            }
            ConvertToPdf(images);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "pdf";
            saveFile.Filter = "PDF files (*.pdf)|*.pdf*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {

                imagePdfDocument.Save(@"C:\image_export.pdf");

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
            e.Graphics.DrawLine(p, 0, 43, 800, 43);
        }

        private void OnExportImagePaint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(_exportImage.Location.X, _exportImage.Location.Y, _exportImage.Width, _exportImage.Height);
                r.X -= 29;
                r.Y -= 3;
                r.Width--;
                r.Height--;
                Pen p = new Pen(Color.LightGray);
                e.Graphics.DrawRectangle(p, r);
                e.Graphics.DrawLine(p, new Point(0, 43), new
                Point(this.Width, 43));
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
        }

        private void OnTileUnchecked(object sender, TileEventArgs e)
        {
             checkedItems--;
            //_exportImage.Visible = checkedItems > 0;
            panel4.Visible = checkedItems > 0;
        }

        private void OnClickSave(object sender, EventArgs e)
        {
            List<Image> images = new List<Image>();
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFile.Title = "Save an Image File";
            saveFile.ShowDialog();


            foreach (Tile tile in _imageTileControl.Groups[0].Tiles)
            {
                if (tile.Checked)
                {
                   
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        //imagePdfDocument.Save(@"C:\Imagetile.jpg");
                        if (saveFile.FileName != "")
                        {
                            // Saves the Image via a FileStream created by the OpenFile method.
                            System.IO.FileStream fs = (System.IO.FileStream)saveFile.OpenFile();
                            // Saves the Image in the appropriate ImageFormat based upon the
                            // File type selected in the dialog box.
                            // NOTE that the FilterIndex property is one-based.
                            switch (saveFile.FilterIndex)
                            {
                                case 1:
                                    this.tile.Image.Save(fs,System.Drawing.Imaging.ImageFormat.Jpeg);
                                    break;

                                case 2:
                                    this.button2.Image.Save(fs,System.Drawing.Imaging.ImageFormat.Bmp);
                                    break;

                                case 3:
                                    this.button2.Image.Save(fs,System.Drawing.Imaging.ImageFormat.Gif);
                                    break;
                            }

                            fs.Close();
                        }
                    }
                }
            }
            

            
        }




        }
}