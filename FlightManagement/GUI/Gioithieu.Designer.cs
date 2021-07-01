namespace FlightManagement
{
    partial class Gioithieu
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
            this.btnClose_support = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose_support
            // 
            this.btnClose_support.BackColor = System.Drawing.SystemColors.Window;
            this.btnClose_support.FlatAppearance.BorderSize = 0;
            this.btnClose_support.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose_support.Image = global::FlightManagement.Properties.Resources.icons8_close_window_1002;
            this.btnClose_support.Location = new System.Drawing.Point(0, 0);
            this.btnClose_support.Name = "btnClose_support";
            this.btnClose_support.Size = new System.Drawing.Size(37, 37);
            this.btnClose_support.TabIndex = 25;
            this.btnClose_support.UseVisualStyleBackColor = false;
            this.btnClose_support.Click += new System.EventHandler(this.btnClose_support_Click);
            // 
            // Gioithieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlightManagement.Properties.Resources.backround_gt3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1543, 799);
            this.Controls.Add(this.btnClose_support);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gioithieu";
            this.Text = "Support";
            this.Load += new System.EventHandler(this.Support_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose_support;
    }
}