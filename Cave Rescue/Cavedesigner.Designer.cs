namespace CaveRescue
{
    partial class btn
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
            this.pnl_Cavern = new System.Windows.Forms.Panel();
            this.cmb_objects = new System.Windows.Forms.ComboBox();
            this.btn_addobject = new System.Windows.Forms.Button();
            this.btn_savecave = new System.Windows.Forms.Button();
            this.btn_makegrid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnl_Cavern
            // 
            this.pnl_Cavern.Location = new System.Drawing.Point(12, 13);
            this.pnl_Cavern.Name = "pnl_Cavern";
            this.pnl_Cavern.Size = new System.Drawing.Size(611, 412);
            this.pnl_Cavern.TabIndex = 0;
        
            // 
            // cmb_objects
            // 
            this.cmb_objects.FormattingEnabled = true;
            this.cmb_objects.Location = new System.Drawing.Point(653, 13);
            this.cmb_objects.Name = "cmb_objects";
            this.cmb_objects.Size = new System.Drawing.Size(121, 21);
            this.cmb_objects.TabIndex = 1;
            // 
            // btn_addobject
            // 
            this.btn_addobject.Location = new System.Drawing.Point(653, 309);
            this.btn_addobject.Name = "btn_addobject";
            this.btn_addobject.Size = new System.Drawing.Size(121, 23);
            this.btn_addobject.TabIndex = 2;
            this.btn_addobject.Text = "Add object";
            this.btn_addobject.UseVisualStyleBackColor = true;
            this.btn_addobject.Click += new System.EventHandler(this.btn_addobject_Click);
            // 
            // btn_savecave
            // 
            this.btn_savecave.Location = new System.Drawing.Point(653, 353);
            this.btn_savecave.Name = "btn_savecave";
            this.btn_savecave.Size = new System.Drawing.Size(121, 23);
            this.btn_savecave.TabIndex = 3;
            this.btn_savecave.Text = "Save cave layout";
            this.btn_savecave.UseVisualStyleBackColor = true;
            // 
            // btn_makegrid
            // 
            this.btn_makegrid.Location = new System.Drawing.Point(653, 401);
            this.btn_makegrid.Name = "btn_makegrid";
            this.btn_makegrid.Size = new System.Drawing.Size(121, 23);
            this.btn_makegrid.TabIndex = 4;
            this.btn_makegrid.Text = "Generate grid";
            this.btn_makegrid.UseVisualStyleBackColor = true;
            this.btn_makegrid.Click += new System.EventHandler(this.btn_makegrid_Click);
            // 
            // btn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_makegrid);
            this.Controls.Add(this.btn_savecave);
            this.Controls.Add(this.btn_addobject);
            this.Controls.Add(this.cmb_objects);
            this.Controls.Add(this.pnl_Cavern);
            this.Name = "btn";
            this.Text = "Cave designer ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Cavern;
        private System.Windows.Forms.ComboBox cmb_objects;
        private System.Windows.Forms.Button btn_addobject;
        private System.Windows.Forms.Button btn_savecave;
        private System.Windows.Forms.Button btn_Generategrid;
        private System.Windows.Forms.Button btn_makegrid;
    }
}