
namespace Image_Match
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
            this.find_btn = new System.Windows.Forms.Button();
            this.sample_pic = new System.Windows.Forms.PictureBox();
            this.sample_group = new System.Windows.Forms.GroupBox();
            this.template_group = new System.Windows.Forms.GroupBox();
            this.template_pic = new System.Windows.Forms.PictureBox();
            this.output_group = new System.Windows.Forms.GroupBox();
            this.output_pic = new System.Windows.Forms.PictureBox();
            this.change_template_btn = new System.Windows.Forms.Button();
            this.change_sample_btn = new System.Windows.Forms.Button();
            this.image_select = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.sample_pic)).BeginInit();
            this.sample_group.SuspendLayout();
            this.template_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.template_pic)).BeginInit();
            this.output_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.output_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // find_btn
            // 
            this.find_btn.Location = new System.Drawing.Point(14, 12);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(96, 25);
            this.find_btn.TabIndex = 0;
            this.find_btn.Text = "Find";
            this.find_btn.UseVisualStyleBackColor = true;
            this.find_btn.Click += new System.EventHandler(this.find_Click);
            // 
            // sample_pic
            // 
            this.sample_pic.Location = new System.Drawing.Point(6, 19);
            this.sample_pic.Name = "sample_pic";
            this.sample_pic.Size = new System.Drawing.Size(667, 359);
            this.sample_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sample_pic.TabIndex = 1;
            this.sample_pic.TabStop = false;
            // 
            // sample_group
            // 
            this.sample_group.Controls.Add(this.sample_pic);
            this.sample_group.Location = new System.Drawing.Point(8, 43);
            this.sample_group.Name = "sample_group";
            this.sample_group.Size = new System.Drawing.Size(679, 384);
            this.sample_group.TabIndex = 3;
            this.sample_group.TabStop = false;
            this.sample_group.Text = "Sample Image";
            // 
            // template_group
            // 
            this.template_group.Controls.Add(this.template_pic);
            this.template_group.Location = new System.Drawing.Point(693, 43);
            this.template_group.Name = "template_group";
            this.template_group.Size = new System.Drawing.Size(226, 154);
            this.template_group.TabIndex = 4;
            this.template_group.TabStop = false;
            this.template_group.Text = "Template Image";
            // 
            // template_pic
            // 
            this.template_pic.Location = new System.Drawing.Point(6, 19);
            this.template_pic.Name = "template_pic";
            this.template_pic.Size = new System.Drawing.Size(214, 129);
            this.template_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.template_pic.TabIndex = 0;
            this.template_pic.TabStop = false;
            // 
            // output_group
            // 
            this.output_group.Controls.Add(this.output_pic);
            this.output_group.Location = new System.Drawing.Point(8, 433);
            this.output_group.Name = "output_group";
            this.output_group.Size = new System.Drawing.Size(679, 384);
            this.output_group.TabIndex = 4;
            this.output_group.TabStop = false;
            this.output_group.Text = "Output Image";
            // 
            // output_pic
            // 
            this.output_pic.Location = new System.Drawing.Point(6, 19);
            this.output_pic.Name = "output_pic";
            this.output_pic.Size = new System.Drawing.Size(667, 359);
            this.output_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.output_pic.TabIndex = 1;
            this.output_pic.TabStop = false;
            // 
            // change_template_btn
            // 
            this.change_template_btn.Location = new System.Drawing.Point(812, 203);
            this.change_template_btn.Name = "change_template_btn";
            this.change_template_btn.Size = new System.Drawing.Size(104, 23);
            this.change_template_btn.TabIndex = 5;
            this.change_template_btn.Text = "Change Template";
            this.change_template_btn.UseVisualStyleBackColor = true;
            this.change_template_btn.Click += new System.EventHandler(this.change_template_btn_Click);
            // 
            // change_sample_btn
            // 
            this.change_sample_btn.Location = new System.Drawing.Point(583, 14);
            this.change_sample_btn.Name = "change_sample_btn";
            this.change_sample_btn.Size = new System.Drawing.Size(104, 23);
            this.change_sample_btn.TabIndex = 6;
            this.change_sample_btn.Text = "Change Sample";
            this.change_sample_btn.UseVisualStyleBackColor = true;
            this.change_sample_btn.Click += new System.EventHandler(this.change_sample_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 829);
            this.Controls.Add(this.change_sample_btn);
            this.Controls.Add(this.change_template_btn);
            this.Controls.Add(this.output_group);
            this.Controls.Add(this.template_group);
            this.Controls.Add(this.sample_group);
            this.Controls.Add(this.find_btn);
            this.Name = "Form1";
            this.Text = "Image Match";
            ((System.ComponentModel.ISupportInitialize)(this.sample_pic)).EndInit();
            this.sample_group.ResumeLayout(false);
            this.template_group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.template_pic)).EndInit();
            this.output_group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.output_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.PictureBox sample_pic;
        private System.Windows.Forms.GroupBox sample_group;
        private System.Windows.Forms.GroupBox template_group;
        private System.Windows.Forms.PictureBox template_pic;
        private System.Windows.Forms.GroupBox output_group;
        private System.Windows.Forms.PictureBox output_pic;
        private System.Windows.Forms.Button change_template_btn;
        private System.Windows.Forms.Button change_sample_btn;
        private System.Windows.Forms.OpenFileDialog image_select;
    }
}

