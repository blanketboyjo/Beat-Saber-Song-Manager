namespace Beat_Saber_Song_Manager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FlowLayout_DetectedLibrary = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_PopulateListing = new System.Windows.Forms.Button();
            this.Btn_ToXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlowLayout_DetectedLibrary
            // 
            this.FlowLayout_DetectedLibrary.AutoScroll = true;
            this.FlowLayout_DetectedLibrary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlowLayout_DetectedLibrary.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayout_DetectedLibrary.Location = new System.Drawing.Point(12, 12);
            this.FlowLayout_DetectedLibrary.MinimumSize = new System.Drawing.Size(10, 10);
            this.FlowLayout_DetectedLibrary.Name = "FlowLayout_DetectedLibrary";
            this.FlowLayout_DetectedLibrary.Size = new System.Drawing.Size(263, 343);
            this.FlowLayout_DetectedLibrary.TabIndex = 0;
            this.FlowLayout_DetectedLibrary.WrapContents = false;
            // 
            // Btn_PopulateListing
            // 
            this.Btn_PopulateListing.Location = new System.Drawing.Point(306, 38);
            this.Btn_PopulateListing.Name = "Btn_PopulateListing";
            this.Btn_PopulateListing.Size = new System.Drawing.Size(110, 23);
            this.Btn_PopulateListing.TabIndex = 1;
            this.Btn_PopulateListing.Text = "Sus button";
            this.Btn_PopulateListing.UseVisualStyleBackColor = true;
            this.Btn_PopulateListing.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_ToXML
            // 
            this.Btn_ToXML.Location = new System.Drawing.Point(306, 67);
            this.Btn_ToXML.Name = "Btn_ToXML";
            this.Btn_ToXML.Size = new System.Drawing.Size(110, 23);
            this.Btn_ToXML.TabIndex = 2;
            this.Btn_ToXML.Text = "Generate XML";
            this.Btn_ToXML.UseVisualStyleBackColor = true;
            this.Btn_ToXML.Click += new System.EventHandler(this.Btn_ToXML_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_ToXML);
            this.Controls.Add(this.Btn_PopulateListing);
            this.Controls.Add(this.FlowLayout_DetectedLibrary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Beat Saber Song Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel FlowLayout_DetectedLibrary;
        private Button Btn_PopulateListing;
        private Button Btn_ToXML;
    }
}