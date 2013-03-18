namespace PGS.Controls
{
    partial class MainButtonsControl
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
            this.radbuttonMaterial = new Telerik.WinControls.UI.RadButton();
            this.radbuttonCars = new Telerik.WinControls.UI.RadButton();
            this.radbuttonEquipment = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radbuttonMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbuttonCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbuttonEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // radbuttonMaterial
            // 
            this.radbuttonMaterial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.radbuttonMaterial.Location = new System.Drawing.Point(91, 25);
            this.radbuttonMaterial.Name = "radbuttonMaterial";
            this.radbuttonMaterial.Size = new System.Drawing.Size(120, 70);
            this.radbuttonMaterial.TabIndex = 0;
            this.radbuttonMaterial.Tag = "1";
            this.radbuttonMaterial.Text = "OFFICE MATERIALS MANAGEMENT";
            this.radbuttonMaterial.TextWrap = true;
            this.radbuttonMaterial.Visible = false;
            this.radbuttonMaterial.Click += new System.EventHandler(this.radButton_Click);
            // 
            // radbuttonCars
            // 
            this.radbuttonCars.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.radbuttonCars.Location = new System.Drawing.Point(279, 25);
            this.radbuttonCars.Name = "radbuttonCars";
            this.radbuttonCars.Size = new System.Drawing.Size(120, 70);
            this.radbuttonCars.TabIndex = 1;
            this.radbuttonCars.Tag = "2";
            this.radbuttonCars.Text = "CAR MANAGEMENT";
            this.radbuttonCars.TextWrap = true;
            this.radbuttonCars.Visible = false;
            this.radbuttonCars.Click += new System.EventHandler(this.radButton_Click);
            // 
            // radbuttonEquipment
            // 
            this.radbuttonEquipment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.radbuttonEquipment.Location = new System.Drawing.Point(160, 25);
            this.radbuttonEquipment.Name = "radbuttonEquipment";
            this.radbuttonEquipment.Size = new System.Drawing.Size(150, 70);
            this.radbuttonEquipment.TabIndex = 2;
            this.radbuttonEquipment.Tag = "3";
            this.radbuttonEquipment.Text = "EQUIPMENT / TOOLS / CONSUMABLES MANAGEMENT";
            this.radbuttonEquipment.TextWrap = true;
            this.radbuttonEquipment.Click += new System.EventHandler(this.radButton_Click);
            // 
            // MainButtonsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.radbuttonCars);
            this.Controls.Add(this.radbuttonEquipment);
            this.Controls.Add(this.radbuttonMaterial);
            this.Name = "MainButtonsControl";
            this.Size = new System.Drawing.Size(490, 120);
            ((System.ComponentModel.ISupportInitialize)(this.radbuttonMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbuttonCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radbuttonEquipment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radbuttonMaterial;
        private Telerik.WinControls.UI.RadButton radbuttonCars;
        private Telerik.WinControls.UI.RadButton radbuttonEquipment;
    }
}
