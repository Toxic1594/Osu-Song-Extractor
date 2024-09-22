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
                int deltaX = Cursor.Position.X - dragCursorPoint.X;
                int deltaY = Cursor.Position.Y - dragCursorPoint.Y;

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
        List<string> forbidden = new List<string>()
        {
            "easy1.mp3", "easy2.mp3", "easy3.mp3", "easy4.mp3", "easy5.mp3",
            "sectionfail.mp3", "sectionpass.mp3"
        };

        public f1()
        {
            InitializeComponent();
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\osu!"))
            {
                Osufolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\osu!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Toxic1594");
        }


        private void CopyDirectory(string sourceDir, string destDir)
        {
            Directory.CreateDirectory(destDir); // Create the destination directory if it doesn't exist

            // Copy files
            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string destFile = Path.Combine(destDir, Path.GetFileName(file));
                if (file.Contains(".mp3") && (!forbidden.Any(word => destFile.Contains(word))))
                {
                    if (!File.Exists(destFile)) 
                    {
                        File.Copy(file, destFile); // Overwrite if the file exists
                    }
                    else
                    {
                        File.AppendAllText("log.txt", "Duplicated File detected, skipping: " + destFile);
                    }

                    
                }

            }

            // Copy subdirectories
            foreach (string subDir in Directory.GetDirectories(sourceDir))
            {
                string destSubDir = Path.Combine(destDir, Path.GetFileName(subDir));
                if (destSubDir.Contains(".mp3") && (!forbidden.Any(word => destSubDir.Contains(word))))
                {
                    CopyDirectory(subDir, destSubDir); // Recursive call
                }

            }
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
                        string Folderpath = Folddiag.SelectedPath + "\\Songs";
                        folderlist = Directory.GetDirectories(Folderpath);
                        foreach (var x in folderlist)
                        {
                            string[] files = Directory.GetFiles(x, "*.mp3");

                            foreach (var y in files)
                            {
                                if (forbidden.Any(word => y.Contains(word)))
                                {
                                    continue;
                                }
                                else
                                {
                                    counter++;
                                    string[] parts = y.Split('\\');

                                    if (parts.Length >= 2) // Check if enough parts are present
                                    {
                                        string filename = parts[parts.Length - 1];
                                        string newfolder = parts[parts.Length - 2];

                                        if (cbexfolder.Checked)
                                        {
                                            // Copy the entire folder
                                            string sourceFolder = Path.GetDirectoryName(y);
                                            string destinationFolder = Path.Combine(outputfolder, newfolder);
                                            CopyDirectory(sourceFolder, destinationFolder);
                                        }

                                        if (cbexfile.Checked)
                                        {
                                            if (!File.Exists(Path.Combine(outputfolder, newfolder + ".mp3")))
                                            {
                                                File.Copy(y, Path.Combine(outputfolder, newfolder + ".mp3"));
                                            }
                                            else
                                            {
                                                File.AppendAllText("log.txt", "Duplicated File detected, skipping: " + Path.Combine(outputfolder, newfolder + ".mp3") + "\n");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        MessageBox.Show(counter.ToString() + " Files extracted");
                    }
                    else
                    {
                        MessageBox.Show("You didn't select Osu");
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
