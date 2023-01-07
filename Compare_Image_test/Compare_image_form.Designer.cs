namespace Compare_Image_test
{
    partial class Compare_image_form
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
            this.Left_pictureBox = new System.Windows.Forms.PictureBox();
            this.Right_pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Compare_process = new System.Windows.Forms.Button();
            this.Left_pictureButton = new System.Windows.Forms.Button();
            this.Right_picture_Button = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.hist_compare_res = new System.Windows.Forms.Label();
            this.hist_compare_value_res = new System.Windows.Forms.Label();
            this.Match_Shape_value_res = new System.Windows.Forms.Label();
            this.Match_Shape_res = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Left_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Left_pictureBox
            // 
            this.Left_pictureBox.Location = new System.Drawing.Point(12, 22);
            this.Left_pictureBox.Name = "Left_pictureBox";
            this.Left_pictureBox.Size = new System.Drawing.Size(305, 270);
            this.Left_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Left_pictureBox.TabIndex = 0;
            this.Left_pictureBox.TabStop = false;
            // 
            // Right_pictureBox
            // 
            this.Right_pictureBox.Location = new System.Drawing.Point(440, 22);
            this.Right_pictureBox.Name = "Right_pictureBox";
            this.Right_pictureBox.Size = new System.Drawing.Size(305, 270);
            this.Right_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Right_pictureBox.TabIndex = 1;
            this.Right_pictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Compare_process
            // 
            this.Compare_process.Location = new System.Drawing.Point(345, 356);
            this.Compare_process.Name = "Compare_process";
            this.Compare_process.Size = new System.Drawing.Size(75, 23);
            this.Compare_process.TabIndex = 2;
            this.Compare_process.Text = "Compare";
            this.Compare_process.UseVisualStyleBackColor = true;
            this.Compare_process.Click += new System.EventHandler(this.Compare_process_Click);
            // 
            // Left_pictureButton
            // 
            this.Left_pictureButton.Location = new System.Drawing.Point(92, 314);
            this.Left_pictureButton.Name = "Left_pictureButton";
            this.Left_pictureButton.Size = new System.Drawing.Size(130, 23);
            this.Left_pictureButton.TabIndex = 5;
            this.Left_pictureButton.Text = "Left_pictureButton";
            this.Left_pictureButton.UseVisualStyleBackColor = true;
            this.Left_pictureButton.Click += new System.EventHandler(this.Left_pictureButton_Click);
            // 
            // Right_picture_Button
            // 
            this.Right_picture_Button.Location = new System.Drawing.Point(521, 314);
            this.Right_picture_Button.Name = "Right_picture_Button";
            this.Right_picture_Button.Size = new System.Drawing.Size(158, 23);
            this.Right_picture_Button.TabIndex = 6;
            this.Right_picture_Button.Text = "Right_pictureButton";
            this.Right_picture_Button.UseVisualStyleBackColor = true;
            this.Right_picture_Button.Click += new System.EventHandler(this.Right_picture_Button_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // hist_compare_res
            // 
            this.hist_compare_res.AutoSize = true;
            this.hist_compare_res.Location = new System.Drawing.Point(228, 386);
            this.hist_compare_res.Name = "hist_compare_res";
            this.hist_compare_res.Size = new System.Drawing.Size(101, 12);
            this.hist_compare_res.TabIndex = 7;
            this.hist_compare_res.Text = "hist_compare_res : ";
            // 
            // hist_compare_value_res
            // 
            this.hist_compare_value_res.AutoSize = true;
            this.hist_compare_value_res.Location = new System.Drawing.Point(335, 386);
            this.hist_compare_value_res.Name = "hist_compare_value_res";
            this.hist_compare_value_res.Size = new System.Drawing.Size(35, 12);
            this.hist_compare_value_res.TabIndex = 8;
            this.hist_compare_value_res.Text = "label2";
            // 
            // Match_Shape_value_res
            // 
            this.Match_Shape_value_res.AutoSize = true;
            this.Match_Shape_value_res.Location = new System.Drawing.Point(335, 418);
            this.Match_Shape_value_res.Name = "Match_Shape_value_res";
            this.Match_Shape_value_res.Size = new System.Drawing.Size(35, 12);
            this.Match_Shape_value_res.TabIndex = 10;
            this.Match_Shape_value_res.Text = "label3";
            // 
            // Match_Shape_res
            // 
            this.Match_Shape_res.AutoSize = true;
            this.Match_Shape_res.Location = new System.Drawing.Point(228, 418);
            this.Match_Shape_res.Name = "Match_Shape_res";
            this.Match_Shape_res.Size = new System.Drawing.Size(101, 12);
            this.Match_Shape_res.TabIndex = 9;
            this.Match_Shape_res.Text = "Match_Shape_res : ";
            // 
            // Compare_image_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Match_Shape_value_res);
            this.Controls.Add(this.Match_Shape_res);
            this.Controls.Add(this.hist_compare_value_res);
            this.Controls.Add(this.hist_compare_res);
            this.Controls.Add(this.Right_picture_Button);
            this.Controls.Add(this.Left_pictureButton);
            this.Controls.Add(this.Compare_process);
            this.Controls.Add(this.Right_pictureBox);
            this.Controls.Add(this.Left_pictureBox);
            this.Name = "Compare_image_form";
            this.Text = "Compare_image_form";
            ((System.ComponentModel.ISupportInitialize)(this.Left_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Left_pictureBox;
        private System.Windows.Forms.PictureBox Right_pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Compare_process;
        private System.Windows.Forms.Button Left_pictureButton;
        private System.Windows.Forms.Button Right_picture_Button;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label hist_compare_res;
        private System.Windows.Forms.Label hist_compare_value_res;
        private System.Windows.Forms.Label Match_Shape_value_res;
        private System.Windows.Forms.Label Match_Shape_res;
    }
}

