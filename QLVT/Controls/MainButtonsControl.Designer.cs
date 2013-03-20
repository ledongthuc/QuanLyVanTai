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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainButtonsControl));
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
            resources.ApplyResources(this.radbuttonMaterial, "radbuttonMaterial");
            this.radbuttonMaterial.Name = "radbuttonMaterial";
            this.radbuttonMaterial.Tag = "1";
            this.radbuttonMaterial.TextWrap = true;
            this.radbuttonMaterial.Click += new System.EventHandler(this.radButton_Click);
            // 
            // radbuttonCars
            // 
            resources.ApplyResources(this.radbuttonCars, "radbuttonCars");
            this.radbuttonCars.Name = "radbuttonCars";
            this.radbuttonCars.Tag = "2";
            this.radbuttonCars.TextWrap = true;
            this.radbuttonCars.Click += new System.EventHandler(this.radButton_Click);
            // 
            // radbuttonEquipment
            // 
            resources.ApplyResources(this.radbuttonEquipment, "radbuttonEquipment");
            this.radbuttonEquipment.Name = "radbuttonEquipment";
            this.radbuttonEquipment.Tag = "3";
            this.radbuttonEquipment.TextWrap = true;
            this.radbuttonEquipment.Click += new System.EventHandler(this.radButton_Click);
            // 
            // MainButtonsControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.radbuttonCars);
            this.Controls.Add(this.radbuttonEquipment);
            this.Controls.Add(this.radbuttonMaterial);
            this.Name = "MainButtonsControl";
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
