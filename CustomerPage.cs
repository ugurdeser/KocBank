using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KocBank
{
    public partial class CustomerPage : Form
    {
        FileDialog fileDialog = new OpenFileDialog();

        public CustomerPage()
        {
            InitializeComponent();
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {

        }

        private void btn_PicturesAdder_Click(object sender, EventArgs e)
        {
            try
            {
                fileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_FileLocation.Text = fileDialog.FileName;
                    pb_Customer.Image = new Bitmap(fileDialog.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen geçerli bir resim dosyası seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_FileLocation_TextChanged(object sender, EventArgs e)
        {
            fileDialog.FileName = txt_FileLocation.Text;
            try
            {
                if (txt_FileLocation.Text == "")
                {
                    pb_Customer.Image = null;
                }
                else
                {
                    pb_Customer.Image = new Bitmap(txt_FileLocation.Text);
                }
            }
            catch (Exception)
            {
                if ((char)txt_FileLocation.Text.Count() < 50)
                {

                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir resim dosyası seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
    }
}
