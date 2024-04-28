using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svg;


namespace dotNET_risk
{
	public partial class Form1 : Form
	{

		Bitmap bitmap = null;

		public Form1()
		{
			InitializeComponent();
			string svgFilePath = "C:/Users/Laurenz Haase/Meine_Projekte/RISK/RISK/dotNET_risk/ressources/Risk_board.svg"; // Passe den Pfad zur SVG-Datei entsprechend deinem Projekt an

			SvgDocument svgDocument = SvgDocument.Open(svgFilePath);

			if (svgDocument != null)
			{
				Bitmap originalBitmap = svgDocument.Draw();

				// Neue Breite und Höhe für das skalierte Bild
				int newWidth = 1000; // Neue Breite in Pixel
				int newHeight = (int)((double)newWidth / originalBitmap.Width * originalBitmap.Height); // Berechnung der Höhe basierend auf dem Seitenverhältnis

				// Erstelle ein neues Bitmap mit der skalierten Größe
				Bitmap resizedBitmap = new Bitmap(originalBitmap, newWidth, newHeight);

				// Verwende das skalierte Bitmap
				this.bitmap = resizedBitmap;

			}
		}

		private void pictureBox1_Load(object sender, EventArgs e)
		{
			
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			pictureBox1.Image = bitmap;
		}
	}

	

}
