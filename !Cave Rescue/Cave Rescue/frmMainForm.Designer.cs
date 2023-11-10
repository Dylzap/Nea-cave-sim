namespace CaveRescue
{
    partial class frmMainForm
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pnlCaveLocations = new System.Windows.Forms.Panel();
            this.btnSetLocation1 = new System.Windows.Forms.Button();
            this.btnSetLocation2 = new System.Windows.Forms.Button();
            this.cbxCavern = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblLocations = new System.Windows.Forms.Label();
            this.lblRescueTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSelectedType = new System.Windows.Forms.Label();
            this.lblSelectedTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(173, 494);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(98, 76);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "FASTEST ROUTE";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnFindFastestRoute);
            // 
            // pnlCaveLocations
            // 
            this.pnlCaveLocations.Location = new System.Drawing.Point(12, 39);
            this.pnlCaveLocations.Name = "pnlCaveLocations";
            this.pnlCaveLocations.Size = new System.Drawing.Size(750, 450);
            this.pnlCaveLocations.TabIndex = 6;
            // 
            // btnSetLocation1
            // 
            this.btnSetLocation1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSetLocation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetLocation1.Location = new System.Drawing.Point(15, 493);
            this.btnSetLocation1.Name = "btnSetLocation1";
            this.btnSetLocation1.Size = new System.Drawing.Size(152, 34);
            this.btnSetLocation1.TabIndex = 10;
            this.btnSetLocation1.Text = "RESCUE PARTY";
            this.btnSetLocation1.UseVisualStyleBackColor = false;
            this.btnSetLocation1.Click += new System.EventHandler(this.btnSetRescueParty);
            // 
            // btnSetLocation2
            // 
            this.btnSetLocation2.BackColor = System.Drawing.Color.Red;
            this.btnSetLocation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetLocation2.Location = new System.Drawing.Point(15, 533);
            this.btnSetLocation2.Name = "btnSetLocation2";
            this.btnSetLocation2.Size = new System.Drawing.Size(152, 37);
            this.btnSetLocation2.TabIndex = 11;
            this.btnSetLocation2.Text = "EMERGANCY";
            this.btnSetLocation2.UseVisualStyleBackColor = false;
            this.btnSetLocation2.Click += new System.EventHandler(this.btnSetEmergancy);
            // 
            // cbxCavern
            // 
            this.cbxCavern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCavern.FormattingEnabled = true;
            this.cbxCavern.Location = new System.Drawing.Point(545, 10);
            this.cbxCavern.Name = "cbxCavern";
            this.cbxCavern.Size = new System.Drawing.Size(156, 21);
            this.cbxCavern.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cavern System:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(707, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(55, 23);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblLocations
            // 
            this.lblLocations.AutoSize = true;
            this.lblLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocations.Location = new System.Drawing.Point(311, 514);
            this.lblLocations.Name = "lblLocations";
            this.lblLocations.Size = new System.Drawing.Size(95, 13);
            this.lblLocations.TabIndex = 15;
            this.lblLocations.Text = "Total Locations";
            // 
            // lblRescueTime
            // 
            this.lblRescueTime.AutoSize = true;
            this.lblRescueTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRescueTime.Location = new System.Drawing.Point(311, 546);
            this.lblRescueTime.Name = "lblRescueTime";
            this.lblRescueTime.Size = new System.Drawing.Size(144, 13);
            this.lblRescueTime.TabIndex = 16;
            this.lblRescueTime.Text = "Estimated Rescue Time:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSelectedTime);
            this.groupBox1.Controls.Add(this.lblSelectedType);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(557, 495);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 75);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Location Information";
            // 
            // lblSelectedType
            // 
            this.lblSelectedType.AutoSize = true;
            this.lblSelectedType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedType.Location = new System.Drawing.Point(7, 20);
            this.lblSelectedType.Name = "lblSelectedType";
            this.lblSelectedType.Size = new System.Drawing.Size(37, 13);
            this.lblSelectedType.TabIndex = 0;
            this.lblSelectedType.Text = "Type: ";
            // 
            // lblSelectedTime
            // 
            this.lblSelectedTime.AutoSize = true;
            this.lblSelectedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTime.Location = new System.Drawing.Point(7, 51);
            this.lblSelectedTime.Name = "lblSelectedTime";
            this.lblSelectedTime.Size = new System.Drawing.Size(54, 13);
            this.lblSelectedTime.TabIndex = 1;
            this.lblSelectedTime.Text = "Est Time: ";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRescueTime);
            this.Controls.Add(this.lblLocations);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCavern);
            this.Controls.Add(this.btnSetLocation2);
            this.Controls.Add(this.btnSetLocation1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.pnlCaveLocations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cave Rescue Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel pnlCaveLocations;
        private System.Windows.Forms.Button btnSetLocation1;
        private System.Windows.Forms.Button btnSetLocation2;
        private System.Windows.Forms.ComboBox cbxCavern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblLocations;
        private System.Windows.Forms.Label lblRescueTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSelectedTime;
        private System.Windows.Forms.Label lblSelectedType;
    }
}

