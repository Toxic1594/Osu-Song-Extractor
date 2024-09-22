namespace osu_song_extractor
{
    partial class f1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbexfolder = new System.Windows.Forms.CheckBox();
            this.cbexfile = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(170)))));
            this.btnSelectFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(119)))));
            this.btnSelectFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnSelectFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(187)))));
            this.btnSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFolder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectFolder.Location = new System.Drawing.Point(3, 25);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(233, 27);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Select Osu Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = false;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Help;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(-1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Osu Song Extractor by Toxic1594";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbexfolder
            // 
            this.cbexfolder.AutoSize = true;
            this.cbexfolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cbexfolder.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(187)))));
            this.cbexfolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.cbexfolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(187)))));
            this.cbexfolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(170)))));
            this.cbexfolder.Location = new System.Drawing.Point(3, 83);
            this.cbexfolder.Name = "cbexfolder";
            this.cbexfolder.Size = new System.Drawing.Size(112, 19);
            this.cbexfolder.TabIndex = 3;
            this.cbexfolder.Text = "Extract as Folder";
            this.cbexfolder.UseVisualStyleBackColor = false;
            // 
            // cbexfile
            // 
            this.cbexfile.AutoSize = true;
            this.cbexfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cbexfile.Checked = true;
            this.cbexfile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbexfile.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(187)))));
            this.cbexfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.cbexfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(187)))));
            this.cbexfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(170)))));
            this.cbexfile.Location = new System.Drawing.Point(3, 68);
            this.cbexfile.Name = "cbexfile";
            this.cbexfile.Size = new System.Drawing.Size(103, 19);
            this.cbexfile.TabIndex = 4;
            this.cbexfile.Text = "Extract as Mp3";
            this.cbexfile.UseVisualStyleBackColor = false;
            // 
            // f1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(240, 114);
            this.Controls.Add(this.cbexfile);
            this.Controls.Add(this.cbexfolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectFolder);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f1";
            this.ShowIcon = false;
            this.Text = "Osu Song extractor";
            this.Load += new System.EventHandler(this.f1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.f1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.f1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbexfolder;
        private System.Windows.Forms.CheckBox cbexfile;
    }
}

