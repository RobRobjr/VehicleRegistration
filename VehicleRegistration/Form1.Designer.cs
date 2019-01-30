namespace VehicleRegistration
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
            this.BtnRegister = new System.Windows.Forms.Button();
            this.LblVIN = new System.Windows.Forms.Label();
            this.LblMake = new System.Windows.Forms.Label();
            this.LblModel = new System.Windows.Forms.Label();
            this.LblYear = new System.Windows.Forms.Label();
            this.TxtBoxVIN = new System.Windows.Forms.TextBox();
            this.TxtBoxMake = new System.Windows.Forms.TextBox();
            this.TxtBoxModel = new System.Windows.Forms.TextBox();
            this.TxtBoxYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(44, 171);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(137, 48);
            this.BtnRegister.TabIndex = 0;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // LblVIN
            // 
            this.LblVIN.AutoSize = true;
            this.LblVIN.Location = new System.Drawing.Point(41, 43);
            this.LblVIN.Name = "LblVIN";
            this.LblVIN.Size = new System.Drawing.Size(28, 13);
            this.LblVIN.TabIndex = 1;
            this.LblVIN.Text = "VIN:";
            this.LblVIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblMake
            // 
            this.LblMake.AutoSize = true;
            this.LblMake.Location = new System.Drawing.Point(32, 69);
            this.LblMake.Name = "LblMake";
            this.LblMake.Size = new System.Drawing.Size(37, 13);
            this.LblMake.TabIndex = 2;
            this.LblMake.Text = "Make:";
            this.LblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblModel
            // 
            this.LblModel.AutoSize = true;
            this.LblModel.Location = new System.Drawing.Point(30, 97);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(39, 13);
            this.LblModel.TabIndex = 3;
            this.LblModel.Text = "Model:";
            this.LblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Location = new System.Drawing.Point(37, 121);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(32, 13);
            this.LblYear.TabIndex = 4;
            this.LblYear.Text = "Year:";
            this.LblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBoxVIN
            // 
            this.TxtBoxVIN.Location = new System.Drawing.Point(123, 43);
            this.TxtBoxVIN.Name = "TxtBoxVIN";
            this.TxtBoxVIN.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxVIN.TabIndex = 5;
            // 
            // TxtBoxMake
            // 
            this.TxtBoxMake.Location = new System.Drawing.Point(123, 69);
            this.TxtBoxMake.Name = "TxtBoxMake";
            this.TxtBoxMake.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxMake.TabIndex = 6;
            // 
            // TxtBoxModel
            // 
            this.TxtBoxModel.Location = new System.Drawing.Point(123, 97);
            this.TxtBoxModel.Name = "TxtBoxModel";
            this.TxtBoxModel.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxModel.TabIndex = 7;
            // 
            // TxtBoxYear
            // 
            this.TxtBoxYear.Location = new System.Drawing.Point(123, 123);
            this.TxtBoxYear.Name = "TxtBoxYear";
            this.TxtBoxYear.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxYear.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 262);
            this.Controls.Add(this.TxtBoxYear);
            this.Controls.Add(this.TxtBoxModel);
            this.Controls.Add(this.TxtBoxMake);
            this.Controls.Add(this.TxtBoxVIN);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.LblModel);
            this.Controls.Add(this.LblMake);
            this.Controls.Add(this.LblVIN);
            this.Controls.Add(this.BtnRegister);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label LblVIN;
        private System.Windows.Forms.Label LblMake;
        private System.Windows.Forms.Label LblModel;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.TextBox TxtBoxVIN;
        private System.Windows.Forms.TextBox TxtBoxMake;
        private System.Windows.Forms.TextBox TxtBoxModel;
        private System.Windows.Forms.TextBox TxtBoxYear;
    }
}

