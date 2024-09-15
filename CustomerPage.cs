using KocBank.Context;
using KocBank.Model;
using KocBank.Services;
using Microsoft.EntityFrameworkCore;
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
        KocBankContext kocBankContext = new KocBankContext();
        Customer customermodel = new Customer();
        City citymodel = new City();
        Helper helper = new Helper();

        public CustomerPage()
        {
            InitializeComponent();
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            CbxLoader();
        }

        //Generic ComboBox Loader Method Yazılacak
        private void CbxLoader()
        {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Rows.Add(0, "Şehir Seçiniz!");
            foreach (var item in kocBankContext.Cities)
            {
                dataTable.Rows.Add(item.ID, item.Name);
            }
            cbx_Cities.ValueMember = "ID";
            cbx_Cities.DisplayMember = "Name";
            cbx_Cities.DataSource = dataTable;
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var updateCustomer = kocBankContext.Customers.Where(x => x.GovernmentID == txt_SearchGovermentID.Text).FirstOrDefault();


            if (txt_GovermentID.Enabled == true)
            {


                if (kocBankContext.Customers.Where(x => x.GovernmentID == txt_GovermentID.Text).Any() == true)
                {
                    MessageBox.Show("Bu T.C. Kimlik numarası ile kayıtlı bir müşteri bulunmaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (updateCustomer != null)
            {
                updateCustomer.Name = txt_FirstName.Text;
                updateCustomer.Surname = txt_LastName.Text;
                updateCustomer.PhoneNumber = txt_Phone.Text;
                updateCustomer.Email = txt_Email.Text;
                updateCustomer.Address = txt_Address.Text;
                updateCustomer.CityID = Convert.ToInt32(cbx_Cities.SelectedValue);
                updateCustomer.BirthDate = dtp_BirthDay.Value;
                updateCustomer.CustomerPicture = helper.ImageToByteArray(pb_Customer.Image);
                updateCustomer.CreatedDate = DateTime.Now;
                if (Validation())
                {
                    kocBankContext.SaveChanges();
                    MessageBox.Show("Müşteri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_FirstName.Text = "";
                    txt_LastName.Text = "";
                    txt_GovermentID.Text = "";
                    txt_GovermentID.Enabled = true;
                    txt_Phone.Text = "";
                    txt_Email.Text = "";
                    txt_Address.Text = "";
                    cbx_Cities.SelectedIndex = -1;
                    dtp_BirthDay.Value = DateTime.Now;
                    pb_Customer.Image = null;
                }
            }
            else
            {
                customermodel.Name = txt_FirstName.Text;
                customermodel.Surname = txt_LastName.Text;
                customermodel.GovernmentID = txt_GovermentID.Text;
                customermodel.PhoneNumber = txt_Phone.Text;
                customermodel.Email = txt_Email.Text;
                customermodel.Address = txt_Address.Text;
                customermodel.CityID = Convert.ToInt32(cbx_Cities.SelectedValue);
                customermodel.BirthDate = dtp_BirthDay.Value;
                customermodel.CustomerPicture = helper.ImageToByteArray(pb_Customer.Image);
                customermodel.CreatedDate = DateTime.Now;
                if (Validation())
                {
                    kocBankContext.Add(customermodel);
                    kocBankContext.SaveChanges();
                    MessageBox.Show("Müşteri başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_FirstName.Text = "";
                    txt_LastName.Text = "";
                    txt_GovermentID.Text = "";
                    txt_GovermentID.Enabled = true;
                    txt_Phone.Text = "";
                    txt_Email.Text = "";
                    txt_Address.Text = "";
                    cbx_Cities.SelectedIndex = -1;
                    dtp_BirthDay.Value = DateTime.Now;
                    pb_Customer.Image = null;


                }
            }
        }




        public bool Validation()
        {
            if (txt_FirstName.Text == "" || txt_LastName.Text == "" || txt_GovermentID.Text == "" || txt_Phone.Text == "" || txt_Email.Text == "" || txt_Address.Text == "" || cbx_Cities.SelectedIndex == -1 || pb_Customer.Image == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_GovermentID.Text.Length != 11)
            {
                MessageBox.Show("T.C. Kimlik numarası 11 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_Phone.Text.Length != 10)
            {
                MessageBox.Show("Telefon numarası 10 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!txt_Email.Text.Contains("@") || !txt_Email.Text.Contains(".") || !txt_Email.Text.Contains(".com"))
            {
                MessageBox.Show("Geçerli bir e-posta adresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_Address.Text.Length < 10)
            {
                MessageBox.Show("Adres en az 10 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var customerGovernmentID = txt_GovermentID.Text;
            var deleteCustomer = kocBankContext.Set<Customer>().Where(x => x.GovernmentID == customerGovernmentID).FirstOrDefault();

            if (deleteCustomer != null)
            {
                kocBankContext.Set<Customer>().Remove(deleteCustomer);
                kocBankContext.SaveChanges();
                MessageBox.Show("Müşteri başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Müşteri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btn_Take_Click(object sender, EventArgs e)
        {
            var takeCustomer = kocBankContext.Set<Customer>().Where(x => x.GovernmentID == txt_SearchGovermentID.Text).FirstOrDefault();
            if (takeCustomer != null)
            {
                txt_FirstName.Text = takeCustomer.Name;
                txt_LastName.Text = takeCustomer.Surname;
                txt_GovermentID.Text = takeCustomer.GovernmentID;
                txt_GovermentID.Enabled = false;
                txt_Phone.Text = takeCustomer.PhoneNumber;
                txt_Email.Text = takeCustomer.Email;
                txt_Address.Text = takeCustomer.Address;
                cbx_Cities.SelectedValue = takeCustomer.CityID;
                dtp_BirthDay.Value = takeCustomer.BirthDate;
                pb_Customer.Image = helper.ByteArrayToImage(takeCustomer.CustomerPicture);
            }
            else
            {
                MessageBox.Show("Müşteri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Müşteri uyarı mesajı dolacak

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_GovermentID.Text = "";
            txt_GovermentID.Enabled = true;
            txt_Phone.Text = "";
            txt_Email.Text = "";
            txt_Address.Text = "";
            cbx_Cities.SelectedIndex = 0;
            dtp_BirthDay.Value = DateTime.Now;
            pb_Customer.Image = null;

        }
    }
}
