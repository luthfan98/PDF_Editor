namespace PDF_Editor
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnZoomFitWidth = new System.Windows.Forms.Button();
            this.btnZoomFitHeight = new System.Windows.Forms.Button();
            this.btnZoomActualSize = new System.Windows.Forms.Button();
            this.btnDeletePage = new System.Windows.Forms.Button();
            this.btnSearchText = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 356);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnZoomFitWidth
            // 
            this.btnZoomFitWidth.Location = new System.Drawing.Point(545, 12);
            this.btnZoomFitWidth.Name = "btnZoomFitWidth";
            this.btnZoomFitWidth.Size = new System.Drawing.Size(97, 47);
            this.btnZoomFitWidth.TabIndex = 5;
            this.btnZoomFitWidth.Text = "Zoom Fit Width";
            this.btnZoomFitWidth.UseVisualStyleBackColor = true;
            this.btnZoomFitWidth.Click += new System.EventHandler(this.btnZoomFitWidth_Click);
            // 
            // btnZoomFitHeight
            // 
            this.btnZoomFitHeight.Location = new System.Drawing.Point(648, 12);
            this.btnZoomFitHeight.Name = "btnZoomFitHeight";
            this.btnZoomFitHeight.Size = new System.Drawing.Size(97, 47);
            this.btnZoomFitHeight.TabIndex = 6;
            this.btnZoomFitHeight.Text = "Zoom Fit Height";
            this.btnZoomFitHeight.UseVisualStyleBackColor = true;
            // 
            // btnZoomActualSize
            // 
            this.btnZoomActualSize.Location = new System.Drawing.Point(751, 12);
            this.btnZoomActualSize.Name = "btnZoomActualSize";
            this.btnZoomActualSize.Size = new System.Drawing.Size(97, 47);
            this.btnZoomActualSize.TabIndex = 9;
            this.btnZoomActualSize.Text = "Zoom Actual Size";
            this.btnZoomActualSize.UseVisualStyleBackColor = true;
            // 
            // btnDeletePage
            // 
            this.btnDeletePage.Image = global::PDF_Editor.Properties.Resources.delete_32;
            this.btnDeletePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePage.Location = new System.Drawing.Point(424, 12);
            this.btnDeletePage.Name = "btnDeletePage";
            this.btnDeletePage.Size = new System.Drawing.Size(115, 47);
            this.btnDeletePage.TabIndex = 8;
            this.btnDeletePage.Text = "Delete Page";
            this.btnDeletePage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletePage.UseVisualStyleBackColor = true;
            this.btnDeletePage.Click += new System.EventHandler(this.btnDeletePage_Click);
            // 
            // btnSearchText
            // 
            this.btnSearchText.Image = global::PDF_Editor.Properties.Resources.magnifier32;
            this.btnSearchText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchText.Location = new System.Drawing.Point(854, 12);
            this.btnSearchText.Name = "btnSearchText";
            this.btnSearchText.Size = new System.Drawing.Size(105, 47);
            this.btnSearchText.TabIndex = 7;
            this.btnSearchText.Text = "Search Text";
            this.btnSearchText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchText.UseVisualStyleBackColor = true;
            this.btnSearchText.Click += new System.EventHandler(this.btnSearchText_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Image = global::PDF_Editor.Properties.Resources.rotate32;
            this.btnRotate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRotate.Location = new System.Drawing.Point(321, 12);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(97, 47);
            this.btnRotate.TabIndex = 4;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Image = global::PDF_Editor.Properties.Resources.file32;
            this.btnMerge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMerge.Location = new System.Drawing.Point(218, 12);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(97, 47);
            this.btnMerge.TabIndex = 3;
            this.btnMerge.Text = "Merge";
            this.btnMerge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Image = global::PDF_Editor.Properties.Resources.save32;
            this.btnSaveAs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAs.Location = new System.Drawing.Point(115, 12);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(97, 47);
            this.btnSaveAs.TabIndex = 2;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::PDF_Editor.Properties.Resources.open;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(97, 47);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 433);
            this.Controls.Add(this.btnZoomActualSize);
            this.Controls.Add(this.btnDeletePage);
            this.Controls.Add(this.btnSearchText);
            this.Controls.Add(this.btnZoomFitHeight);
            this.Controls.Add(this.btnZoomFitWidth);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "PDF Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnZoomFitWidth;
        private System.Windows.Forms.Button btnZoomFitHeight;
        private System.Windows.Forms.Button btnSearchText;
        private System.Windows.Forms.Button btnDeletePage;
        private System.Windows.Forms.Button btnZoomActualSize;
    }
}

