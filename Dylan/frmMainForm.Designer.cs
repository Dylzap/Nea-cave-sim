namespace NEA__cave_rescue_simulator
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
            this.btn_startbutton = new System.Windows.Forms.Button();
            this.pnlGridPanel = new System.Windows.Forms.Panel();
            this.btn_startingpoint = new System.Windows.Forms.Button();
            this.btn_endingpoint = new System.Windows.Forms.Button();
            this.btn_shortestpath = new System.Windows.Forms.Button();
            this.btn_Loadmaze = new System.Windows.Forms.Button();
            this.btn_Savecave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_startbutton
            // 
            this.btn_startbutton.Location = new System.Drawing.Point(459, 498);
            this.btn_startbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_startbutton.Name = "btn_startbutton";
            this.btn_startbutton.Size = new System.Drawing.Size(177, 28);
            this.btn_startbutton.TabIndex = 0;
            this.btn_startbutton.Text = "Start!";
            this.btn_startbutton.UseVisualStyleBackColor = true;
            this.btn_startbutton.Click += new System.EventHandler(this.btn_startbutton_Click_1);
            // 
            // pnlGridPanel
            // 
            this.pnlGridPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlGridPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGridPanel.Name = "pnlGridPanel";
            this.pnlGridPanel.Size = new System.Drawing.Size(800, 492);
            this.pnlGridPanel.TabIndex = 1;
            // 
            // btn_startingpoint
            // 
            this.btn_startingpoint.Location = new System.Drawing.Point(29, 500);
            this.btn_startingpoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_startingpoint.Name = "btn_startingpoint";
            this.btn_startingpoint.Size = new System.Drawing.Size(159, 28);
            this.btn_startingpoint.TabIndex = 2;
            this.btn_startingpoint.Text = "Starting point";
            this.btn_startingpoint.UseVisualStyleBackColor = true;
            this.btn_startingpoint.Click += new System.EventHandler(this.btn_startingpoint_Click);
            // 
            // btn_endingpoint
            // 
            this.btn_endingpoint.Location = new System.Drawing.Point(248, 500);
            this.btn_endingpoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_endingpoint.Name = "btn_endingpoint";
            this.btn_endingpoint.Size = new System.Drawing.Size(163, 28);
            this.btn_endingpoint.TabIndex = 3;
            this.btn_endingpoint.Text = "Ending point";
            this.btn_endingpoint.UseVisualStyleBackColor = true;
            this.btn_endingpoint.Click += new System.EventHandler(this.btn_endingpoint_Click);
            // 
            // btn_shortestpath
            // 
            this.btn_shortestpath.Location = new System.Drawing.Point(811, 498);
            this.btn_shortestpath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_shortestpath.Name = "btn_shortestpath";
            this.btn_shortestpath.Size = new System.Drawing.Size(232, 28);
            this.btn_shortestpath.TabIndex = 5;
            this.btn_shortestpath.Text = "Find the shortest path!";
            this.btn_shortestpath.UseVisualStyleBackColor = true;
            this.btn_shortestpath.Click += new System.EventHandler(this.btn_shortestpath_Click);
            // 
            // btn_Loadmaze
            // 
            this.btn_Loadmaze.Location = new System.Drawing.Point(811, 418);
            this.btn_Loadmaze.Name = "btn_Loadmaze";
            this.btn_Loadmaze.Size = new System.Drawing.Size(232, 23);
            this.btn_Loadmaze.TabIndex = 6;
            this.btn_Loadmaze.Text = "Load Maze ";
            this.btn_Loadmaze.UseVisualStyleBackColor = true;
            // 
            // btn_Savecave
            // 
            this.btn_Savecave.Location = new System.Drawing.Point(811, 341);
            this.btn_Savecave.Name = "btn_Savecave";
            this.btn_Savecave.Size = new System.Drawing.Size(232, 23);
            this.btn_Savecave.TabIndex = 7;
            this.btn_Savecave.Text = "Save maze";
            this.btn_Savecave.UseVisualStyleBackColor = true;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 549);
            this.Controls.Add(this.btn_Savecave);
            this.Controls.Add(this.btn_Loadmaze);
            this.Controls.Add(this.btn_shortestpath);
            this.Controls.Add(this.btn_endingpoint);
            this.Controls.Add(this.btn_startingpoint);
            this.Controls.Add(this.pnlGridPanel);
            this.Controls.Add(this.btn_startbutton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_startbutton;
        private System.Windows.Forms.Panel pnlGridPanel;
        private System.Windows.Forms.Button btn_startingpoint;
        private System.Windows.Forms.Button btn_endingpoint;
        private System.Windows.Forms.Button btn_shortestpath;
        private System.Windows.Forms.Button btn_Loadmaze;
        private System.Windows.Forms.Button btn_Savecave;
    }
}

