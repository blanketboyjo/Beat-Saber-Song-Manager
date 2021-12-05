namespace Beat_Saber_Song_Manager
{
    partial class SongBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_SongTitle = new System.Windows.Forms.Label();
            this.Label_ArtistName = new System.Windows.Forms.Label();
            this.Label_Mapper = new System.Windows.Forms.Label();
            this.Thumbnail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_SongTitle
            // 
            this.Label_SongTitle.AutoSize = true;
            this.Label_SongTitle.Location = new System.Drawing.Point(55, 0);
            this.Label_SongTitle.Name = "Label_SongTitle";
            this.Label_SongTitle.Size = new System.Drawing.Size(59, 15);
            this.Label_SongTitle.TabIndex = 1;
            this.Label_SongTitle.Text = "Song Title";
            this.Label_SongTitle.Click += new System.EventHandler(this.SongBox_Click);
            // 
            // Label_ArtistName
            // 
            this.Label_ArtistName.Location = new System.Drawing.Point(58, 16);
            this.Label_ArtistName.Name = "Label_ArtistName";
            this.Label_ArtistName.Size = new System.Drawing.Size(35, 15);
            this.Label_ArtistName.TabIndex = 2;
            this.Label_ArtistName.Text = "Artist";
            this.Label_ArtistName.Click += new System.EventHandler(this.SongBox_Click);
            // 
            // Label_Mapper
            // 
            this.Label_Mapper.AutoSize = true;
            this.Label_Mapper.Location = new System.Drawing.Point(58, 32);
            this.Label_Mapper.Name = "Label_Mapper";
            this.Label_Mapper.Size = new System.Drawing.Size(48, 15);
            this.Label_Mapper.TabIndex = 3;
            this.Label_Mapper.Text = "Mapper";
            this.Label_Mapper.Click += new System.EventHandler(this.SongBox_Click);
            // 
            // Thumbnail
            // 
            this.Thumbnail.Location = new System.Drawing.Point(1, 1);
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.Size = new System.Drawing.Size(48, 48);
            this.Thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Thumbnail.TabIndex = 4;
            this.Thumbnail.TabStop = false;
            this.Thumbnail.Click += new System.EventHandler(this.SongBox_Click);
            // 
            // SongBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Thumbnail);
            this.Controls.Add(this.Label_Mapper);
            this.Controls.Add(this.Label_ArtistName);
            this.Controls.Add(this.Label_SongTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SongBox";
            this.Size = new System.Drawing.Size(244, 50);
            this.Click += new System.EventHandler(this.SongBox_Click);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.SongBox_DragOver);
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Label_SongTitle;
        private Label Label_ArtistName;
        private Label Label_Mapper;
        private PictureBox Thumbnail;
    }
}
