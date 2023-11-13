namespace CaveRescue
{
    partial class Addobjectfrm
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
            this.lbl_nameofobject = new System.Windows.Forms.Label();
            this.lbl_weightofobject = new System.Windows.Forms.Label();
            this.txt_nameofobject = new System.Windows.Forms.TextBox();
            this.txt_weightofobject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addnameofobject = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_makenewobject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nameofobject
            // 
            this.lbl_nameofobject.AutoSize = true;
            this.lbl_nameofobject.Location = new System.Drawing.Point(95, 97);
            this.lbl_nameofobject.Name = "lbl_nameofobject";
            this.lbl_nameofobject.Size = new System.Drawing.Size(82, 13);
            this.lbl_nameofobject.TabIndex = 0;
            this.lbl_nameofobject.Text = "Name of object:";
            // 
            // lbl_weightofobject
            // 
            this.lbl_weightofobject.AutoSize = true;
            this.lbl_weightofobject.Location = new System.Drawing.Point(95, 221);
            this.lbl_weightofobject.Name = "lbl_weightofobject";
            this.lbl_weightofobject.Size = new System.Drawing.Size(88, 13);
            this.lbl_weightofobject.TabIndex = 1;
            this.lbl_weightofobject.Text = "Weight of object:";
            // 
            // txt_nameofobject
            // 
            this.txt_nameofobject.Location = new System.Drawing.Point(98, 143);
            this.txt_nameofobject.Name = "txt_nameofobject";
            this.txt_nameofobject.Size = new System.Drawing.Size(161, 20);
            this.txt_nameofobject.TabIndex = 2;
            // 
            // txt_weightofobject
            // 
            this.txt_weightofobject.Location = new System.Drawing.Point(98, 269);
            this.txt_weightofobject.Name = "txt_weightofobject";
            this.txt_weightofobject.Size = new System.Drawing.Size(161, 20);
            this.txt_weightofobject.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Make your own object";
            // 
            // btn_addnameofobject
            // 
            this.btn_addnameofobject.Location = new System.Drawing.Point(498, 140);
            this.btn_addnameofobject.Name = "btn_addnameofobject";
            this.btn_addnameofobject.Size = new System.Drawing.Size(152, 23);
            this.btn_addnameofobject.TabIndex = 5;
            this.btn_addnameofobject.Text = "Add the objects name";
            this.btn_addnameofobject.UseVisualStyleBackColor = true;
            this.btn_addnameofobject.Click += new System.EventHandler(this.btn_addnameofobject_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add the objects weight";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_makenewobject
            // 
            this.btn_makenewobject.Location = new System.Drawing.Point(313, 369);
            this.btn_makenewobject.Name = "btn_makenewobject";
            this.btn_makenewobject.Size = new System.Drawing.Size(147, 23);
            this.btn_makenewobject.TabIndex = 7;
            this.btn_makenewobject.Text = "Make the new object";
            this.btn_makenewobject.UseVisualStyleBackColor = true;
            this.btn_makenewobject.Click += new System.EventHandler(this.btn_makenewobject_Click);
            // 
            // Addobjectfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_makenewobject);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_addnameofobject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_weightofobject);
            this.Controls.Add(this.txt_nameofobject);
            this.Controls.Add(this.lbl_weightofobject);
            this.Controls.Add(this.lbl_nameofobject);
            this.Name = "Addobjectfrm";
            this.Text = "Add the weight of the object";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nameofobject;
        private System.Windows.Forms.Label lbl_weightofobject;
        private System.Windows.Forms.TextBox txt_nameofobject;
        private System.Windows.Forms.TextBox txt_weightofobject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addnameofobject;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_makenewobject;
    }
}