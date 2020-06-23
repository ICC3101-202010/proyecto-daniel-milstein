namespace AboControls
{
    partial class TestingForm
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
            this.starRatingStrip1 = new AboControls.ExtendedControls.StarRatingStrip();
            this.SuspendLayout();
            // 
            // starRatingStrip1
            // 
            this.starRatingStrip1.Location = new System.Drawing.Point(160, 107);
            this.starRatingStrip1.Name = "starRatingStrip1";
            this.starRatingStrip1.Size = new System.Drawing.Size(144, 28);
            this.starRatingStrip1.TabIndex = 0;
            this.starRatingStrip1.Text = "starRatingStrip1";
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1088, 538);
            this.Controls.Add(this.starRatingStrip1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TestingForm";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.ResumeLayout(false);

        }
















































































































        #endregion

        private ExtendedControls.StarRatingStrip starRatingStrip1;
    }
}