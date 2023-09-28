namespace NEA__cave_rescue_simulator
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
            this.btn_startbutton = new System.Windows.Forms.Button();
            this.pnlGridPanel = new System.Windows.Forms.Panel();
            this.btn_startingpoint = new System.Windows.Forms.Button();
            this.btn_endingpoint = new System.Windows.Forms.Button();
            this.btn_shortestpath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_startbutton
            // 
            this.btn_startbutton.Location = new System.Drawing.Point(344, 405);
            this.btn_startbutton.Name = "btn_startbutton";
            this.btn_startbutton.Size = new System.Drawing.Size(133, 23);
            this.btn_startbutton.TabIndex = 0;
            this.btn_startbutton.Text = "Start!";
            this.btn_startbutton.UseVisualStyleBackColor = true;
            this.btn_startbutton.Click += new System.EventHandler(this.btn_startbutton_Click_1);
            // 
            // pnlGridPanel
            // 
            this.pnlGridPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlGridPanel.Name = "pnlGridPanel";
            this.pnlGridPanel.Size = new System.Drawing.Size(600, 400);
            this.pnlGridPanel.TabIndex = 1;
            // 
            // btn_startingpoint
            // 
            this.btn_startingpoint.Location = new System.Drawing.Point(22, 406);
            this.btn_startingpoint.Name = "btn_startingpoint";
            this.btn_startingpoint.Size = new System.Drawing.Size(119, 23);
            this.btn_startingpoint.TabIndex = 2;
            this.btn_startingpoint.Text = "Starting point";
            this.btn_startingpoint.UseVisualStyleBackColor = true;
            this.btn_startingpoint.Click += new System.EventHandler(this.btn_startingpoint_Click);
            // 
            // btn_endingpoint
            // 
            this.btn_endingpoint.Location = new System.Drawing.Point(186, 406);
            this.btn_endingpoint.Name = "btn_endingpoint";
            this.btn_endingpoint.Size = new System.Drawing.Size(122, 23);
            this.btn_endingpoint.TabIndex = 3;
            this.btn_endingpoint.Text = "Ending point";
            this.btn_endingpoint.UseVisualStyleBackColor = true;
            this.btn_endingpoint.Click += new System.EventHandler(this.btn_endingpoint_Click);
            // 
            // btn_shortestpath
            // 
            this.btn_shortestpath.Location = new System.Drawing.Point(608, 405);
            this.btn_shortestpath.Name = "btn_shortestpath";
            this.btn_shortestpath.Size = new System.Drawing.Size(174, 23);
            this.btn_shortestpath.TabIndex = 5;
            this.btn_shortestpath.Text = "Find the shortest path!";
            this.btn_shortestpath.UseVisualStyleBackColor = true;
            this.btn_shortestpath.Click += new System.EventHandler(this.btn_shortestpath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 446);
            this.Controls.Add(this.btn_shortestpath);
            this.Controls.Add(this.btn_endingpoint);
            this.Controls.Add(this.btn_startingpoint);
            this.Controls.Add(this.pnlGridPanel);
            this.Controls.Add(this.btn_startbutton);
            this.Name = "Form1";
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
    }
}

