using System;
using System.Drawing;
using System.Windows.Forms;

namespace Image_Match
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void find_Click(object sender, EventArgs e)
        {
            SearchImageClass.SearchImage((Bitmap)sample_pic.Image, (Bitmap)template_pic.Image, 0.9);
            output_pic.Image = SearchImageClass.outputImage;
        }

        private void change_sample_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = image_select.ShowDialog();
            image_select.Title = "Browse Sample Image Files";
            image_select.Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp|All files|*.*";

            if (result == DialogResult.OK)
            {
                sample_pic.Image = Image.FromFile(image_select.FileName);
            }
            else if (result == DialogResult.Cancel)
            {

            }

        }

        private void change_template_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = image_select.ShowDialog();
            image_select.Title = "Browse Template Image Files";
            image_select.Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp|All files|*.*";

            if (result == DialogResult.OK)
            {
                template_pic.Image = Image.FromFile(image_select.FileName);
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }
    }
}
