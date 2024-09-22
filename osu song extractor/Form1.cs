using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_song_extractor
{
    public partial class f1 : Form
    {
        #region Form dragging
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        private void f1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }
        private void f1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                // Unterschied zur Cursorposition berechnen
                int deltaX = Cursor.Position.X - dragCursorPoint.X;
                int deltaY = Cursor.Position.Y - dragCursorPoint.Y;

                // Neue Position berechnen
                this.Location = new Point(dragFormPoint.X + deltaX, dragFormPoint.Y + deltaY);
            }
        }
        private void f1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion
        int counter;
        string outputfolder;
        string Osufolder;
        string[] folderlist;
        List<string> forbidden = new List<string>() {"easy1.mp3","easy2.mp3","easy3.mp","easy4.mp3", "easy5.mp3", "sectionfail.mp3", "sectionpass.mp3" };
        public f1()
        {
            InitializeComponent();
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\osu!"))
            {
                Osufolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\osu!";
            }
            else
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Toxic1594");
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog Folddiag = new FolderBrowserDialog())
            {
                Folddiag.SelectedPath = Osufolder;
                if (Folddiag.ShowDialog() == DialogResult.OK)
                {
                    if (Folddiag.SelectedPath.ToLower().Contains("osu"))
                    {
                        if (cbexfolder.Checked)
                        {
                            MessageBox.Show("Now select the output folder");
                            FolderBrowserDialog fs = new FolderBrowserDialog();
                            if (fs.ShowDialog() == DialogResult.OK)
                            {
                                outputfolder = fs.SelectedPath;
                            }
                            else
                            {
                                return;
                            }
                        }
                        if (cbexfile.Checked)
                        {
                            MessageBox.Show("Now select the output folder");
                            FolderBrowserDialog fs2 = new FolderBrowserDialog();
                            if (fs2.ShowDialog() == DialogResult.OK)
                            {
                                outputfolder = fs2.SelectedPath;
                            }
                            else
                            {
                                return;
                            }
                        }
                        btnSelectFolder.Text = "Extract";
                        string Folderpath;
                        Folderpath = Folddiag.SelectedPath+"\\Songs";
                        folderlist = Directory.GetDirectories(Folderpath);
                        foreach (var x in folderlist)
                        {
                            string[] files = Directory.GetFiles(x, "*.mp3");
                            
                            foreach(var y in files)
                            {
                                if (forbidden.Any(word => y.Contains(word)))
                                {
                                    continue;
                                }
                                else
                                {
                                    counter++;
                                    string[] parts = y.Split('\\');

                                    if (parts.Length >= 2) // Überprüfen, ob genug Teile vorhanden sind
                                    {

                                        string filename = parts[parts.Length - 1];
                                        string newfolder = parts[parts.Length - 2];
                                        if (cbexfolder.Checked)
                                        {
                                            if (!Directory.Exists(outputfolder+"\\"+ newfolder))
                                            {
                                                Directory.CreateDirectory(outputfolder + "\\" + newfolder);
                                            }
                                            
                                            File.Copy(y, outputfolder + "\\" + newfolder);
                                        }
                                        if (cbexfile.Checked)
                                        {
                                            File.Copy(y, outputfolder + "\\" + newfolder + ".mp3");
                                        }

                                    }
                                }
                            }


                        }
                        MessageBox.Show(counter.ToString()+" Files extracted");
                    }
                    else
                    {
                        MessageBox.Show("You didnt selected Osu");
                        return;
                    }
                }
            }
        }

        private void f1_Load(object sender, EventArgs e)
        {

        }
    }
}
