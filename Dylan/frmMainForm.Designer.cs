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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_startbutton
            // 
            this.btn_startbutton.Location = new System.Drawing.Point(355, 500);
            this.btn_startbutton.Margin = new System.Windows.Forms.Padding(4);
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
            this.pnlGridPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGridPanel.Name = "pnlGridPanel";
            this.pnlGridPanel.Size = new System.Drawing.Size(800, 492);
            this.pnlGridPanel.TabIndex = 1;
            // 
            // btn_startingpoint
            // 
            this.btn_startingpoint.Location = new System.Drawing.Point(29, 500);
            this.btn_startingpoint.Margin = new System.Windows.Forms.Padding(4);
            this.btn_startingpoint.Name = "btn_startingpoint";
            this.btn_startingpoint.Size = new System.Drawing.Size(120, 28);
            this.btn_startingpoint.TabIndex = 2;
            this.btn_startingpoint.Text = "Starting point";
            this.btn_startingpoint.UseVisualStyleBackColor = true;
            this.btn_startingpoint.Click += new System.EventHandler(this.btn_startingpoint_Click);
            // 
            // btn_endingpoint
            // 
            this.btn_endingpoint.Location = new System.Drawing.Point(193, 500);
            this.btn_endingpoint.Margin = new System.Windows.Forms.Padding(4);
            this.btn_endingpoint.Name = "btn_endingpoint";
            this.btn_endingpoint.Size = new System.Drawing.Size(125, 28);
            this.btn_endingpoint.TabIndex = 3;
            this.btn_endingpoint.Text = "Ending point";
            this.btn_endingpoint.UseVisualStyleBackColor = true;
            this.btn_endingpoint.Click += new System.EventHandler(this.btn_endingpoint_Click);
            // 
            // btn_shortestpath
            // 
            this.btn_shortestpath.Location = new System.Drawing.Point(568, 500);
            this.btn_shortestpath.Margin = new System.Windows.Forms.Padding(4);
            this.btn_shortestpath.Name = "btn_shortestpath";
            this.btn_shortestpath.Size = new System.Drawing.Size(232, 28);
            this.btn_shortestpath.TabIndex = 5;
            this.btn_shortestpath.Text = "Find the shortest path!";
            this.btn_shortestpath.UseVisualStyleBackColor = true;
            this.btn_shortestpath.Click += new System.EventHandler(this.btn_shortestpath_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(816, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 24);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save cave layout!";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(816, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Load cave layout";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(816, 500);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 28);
            this.button4.TabIndex = 9;
            this.button4.Text = "Generate random cave!";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 549);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_shortestpath);
            this.Controls.Add(this.btn_endingpoint);
            this.Controls.Add(this.btn_startingpoint);
            this.Controls.Add(this.pnlGridPanel);
            this.Controls.Add(this.btn_startbutton);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

