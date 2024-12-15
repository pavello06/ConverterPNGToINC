using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterPNGToINC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void OpenPngButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            CreateInc(openFileDialog1.FileName);
        }

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            
            string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".png")
                {
                    CreateInc(file);
                }
            }
        }
        
        private void CreateInc(string pngPath)
        {
            string pngName = Path.GetFileNameWithoutExtension(pngPath);
            string incPath = Path.GetDirectoryName(pngPath) + "\\" + pngName + ".inc";
            StreamWriter streamWriter = new StreamWriter(incPath);
            Bitmap bitmap = new Bitmap(pngPath);
            
            if (!"123456789".Contains(pngName[pngName.Length - 1]))
            {
                streamWriter.WriteLine($"{Regex.Replace(pngName, "([a-z0-9])([A-Z])", "$1_$2").ToUpper()}_WIDTH  = {bitmap.Width}");
                streamWriter.WriteLine($"{Regex.Replace(pngName, "([a-z0-9])([A-Z])", "$1_$2").ToUpper()}_HEIGHT = {bitmap.Height}");
            }
            streamWriter.WriteLine($"{pngName}Texture dd {bitmap.Width}, {bitmap.Height}");
            streamWriter.WriteLine("db\\");
            
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    if (color.R == 100 && color.G == 100 && color.B == 100)
                    {
                        streamWriter.Write("{0, 3},{1, 3},{2, 3}", -1, -1, -1);
                    }
                    else if (color.R == 255)
                    {
                        streamWriter.Write("{0, 3},{1, 3},{2, 3}", 254, color.G, color.B);
                    }
                    else
                    {
                        streamWriter.Write("{0, 3},{1, 3},{2, 3}", color.R, color.G, color.B);
                    }

                    if (x != bitmap.Width - 1 || y != bitmap.Height - 1)
                    {
                        streamWriter.Write(",  ");
                    }
                }
                if (y != bitmap.Height - 1)
                {
                    streamWriter.WriteLine("\\");
                }
            }
            streamWriter.Close();
        }
    }
}