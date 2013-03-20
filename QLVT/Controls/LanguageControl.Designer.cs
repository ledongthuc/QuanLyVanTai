namespace PGS.Controls
{
    partial class LanguageControl
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
            this.btnVN = new System.Windows.Forms.Button();
            this.btnEN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVN
            // 
            this.btnVN.Location = new System.Drawing.Point(3, 3);
            this.btnVN.Name = "btnVN";
            this.btnVN.Size = new System.Drawing.Size(34, 29);
            this.btnVN.TabIndex = 0;
            this.btnVN.Text = "VN";
            this.btnVN.UseVisualStyleBackColor = true;
            this.btnVN.Click += new System.EventHandler(this.btnVN_Click);
            // 
            // btnEN
            // 
            this.btnEN.Location = new System.Drawing.Point(43, 3);
            this.btnEN.Name = "btnEN";
            this.btnEN.Size = new System.Drawing.Size(34, 29);
            this.btnEN.TabIndex = 1;
            this.btnEN.Text = "EN";
            this.btnEN.UseVisualStyleBackColor = true;
            this.btnEN.Click += new System.EventHandler(this.btnEN_Click);
            // 
            // LanguageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEN);
            this.Controls.Add(this.btnVN);
            this.Name = "LanguageControl";
            this.Size = new System.Drawing.Size(80, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVN;
        private System.Windows.Forms.Button btnEN;
    }
}
