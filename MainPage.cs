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
    public partial class MainPage : Form
    {
        private int childFormNumber = 0;
        LoginPage loginPage = new LoginPage();
        public MainPage()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }





        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {


            loginPage.ShowDialog();

            if (loginPage.ControlBox == false) // true yaparsan program acilmaz login olmayi bekler
            {
                this.Close();
            }


        }

        public void CloseShowDialog()
        {
            loginPage.Close();
        }


        #region MenuItems


        private void CustomerPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerPage customerPage = new CustomerPage();


            if (Application.OpenForms.OfType<CustomerPage>().Count() == 1)
            {
                Application.OpenForms.OfType<CustomerPage>().First().Focus();
            }
            else
            {
                customerPage.MdiParent = this;
                customerPage.Show();
            }

            customerPage.StartPosition = FormStartPosition.CenterScreen;
            customerPage.WindowState = FormWindowState.Maximized;
            customerPage.ControlBox = false;
            customerPage.MinimizeBox = false;
            customerPage.ShowIcon = false;

        }

        private void vadeliİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountOpeningOperations depositAccount = new AccountOpeningOperations();

            if (Application.OpenForms.OfType<AccountOpeningOperations>().Count() == 1)
            {
                Application.OpenForms.OfType<AccountOpeningOperations>().First().Focus();
            }
            else
            {
                depositAccount.MdiParent = this;
                depositAccount.Show();
            }

            depositAccount.StartPosition = FormStartPosition.CenterScreen;
            depositAccount.WindowState = FormWindowState.Maximized;
            depositAccount.ControlBox = false;
            depositAccount.MinimizeBox = false;
            depositAccount.ShowIcon = false;
        }

        private void turuncuListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrangeList orangeList = new OrangeList();


            if (Application.OpenForms.OfType<OrangeList>().Count() == 1)
            {
                Application.OpenForms.OfType<OrangeList>().First().Focus();
            }
            else
            {
                orangeList.MdiParent = this;
                orangeList.Show();
            }

            orangeList.StartPosition = FormStartPosition.CenterScreen;
            orangeList.WindowState = FormWindowState.Maximized;
            orangeList.ControlBox = false;
            orangeList.MinimizeBox = false;
            orangeList.ShowIcon = false;
        }

        private void vadesizİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CheckingAccount checkingAccount = new CheckingAccount();

            if (Application.OpenForms.OfType<CheckingAccount>().Count() == 1)
            {
                Application.OpenForms.OfType<CheckingAccount>().First().Focus();
            }
            else
            {
                checkingAccount.MdiParent = this;
                checkingAccount.Show();
            }

            checkingAccount.StartPosition = FormStartPosition.CenterScreen;
            checkingAccount.WindowState = FormWindowState.Maximized;
            checkingAccount.ControlBox = false;
            checkingAccount.MinimizeBox = false;
            checkingAccount.ShowIcon = false;
        }

        private void paraYatırmaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposit_Withdrawal deposit = new Deposit_Withdrawal();

            if (Application.OpenForms.OfType<Deposit_Withdrawal>().Count() == 1)
            {
                Application.OpenForms.OfType<Deposit_Withdrawal>().First().Focus();
            }
            else
            {
                deposit.MdiParent = this;
                deposit.Show();
            }

            deposit.StartPosition = FormStartPosition.CenterScreen;
            deposit.WindowState = FormWindowState.Maximized;
            deposit.ControlBox = false;
            deposit.MinimizeBox = false;
            deposit.ShowIcon = false;

        }


        private void krediKartıAçılıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditCardAdd creditCardAdd = new CreditCardAdd();
            if (Application.OpenForms.OfType<CreditCardAdd>().Count() == 1)
            {
                Application.OpenForms.OfType<CreditCardAdd>().First().Focus();
            }
            else
            {
                creditCardAdd.MdiParent = this;
                creditCardAdd.Show();
            }
            creditCardAdd.StartPosition = FormStartPosition.CenterScreen;
            creditCardAdd.WindowState = FormWindowState.Maximized;
            creditCardAdd.ControlBox = false;
            creditCardAdd.MinimizeBox = false;
            creditCardAdd.ShowIcon = false;
        }

        private void krediKartıSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditCardRemove creditCardRemove = new CreditCardRemove();

            if (Application.OpenForms.OfType<CreditCardRemove>().Count() == 1)
            {
                Application.OpenForms.OfType<CreditCardRemove>().First().Focus();
            }
            else
            {
                creditCardRemove.MdiParent = this;
                creditCardRemove.Show();
            }

            creditCardRemove.StartPosition = FormStartPosition.CenterScreen;
            creditCardRemove.WindowState = FormWindowState.Maximized;
            creditCardRemove.ControlBox = false;
            creditCardRemove.MinimizeBox = false;
            creditCardRemove.ShowIcon = false;

        }

        private void otomatikÖdemeTalimatlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentTransactions paymentTransactions = new PaymentTransactions();

            if (Application.OpenForms.OfType<PaymentTransactions>().Count() == 1)
            {
                Application.OpenForms.OfType<PaymentTransactions>().First().Focus();
            }
            else
            {
                paymentTransactions.MdiParent = this;
                paymentTransactions.Show();
            }

            paymentTransactions.StartPosition = FormStartPosition.CenterScreen;
            paymentTransactions.WindowState = FormWindowState.Maximized;
            paymentTransactions.ControlBox = false;
            paymentTransactions.MinimizeBox = false;
            paymentTransactions.ShowIcon = false;
        }

        private void paraGöndermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoneyTransfer moneyTransfer = new MoneyTransfer();

            if (Application.OpenForms.OfType<MoneyTransfer>().Count() == 1)
            {
                Application.OpenForms.OfType<MoneyTransfer>().First().Focus();
            }
            else
            {
                moneyTransfer.MdiParent = this;
                moneyTransfer.Show();
            }

            moneyTransfer.StartPosition = FormStartPosition.CenterScreen;
            moneyTransfer.WindowState = FormWindowState.Maximized;
            moneyTransfer.ControlBox = false;
            moneyTransfer.MinimizeBox = false;
            moneyTransfer.ShowIcon = false;
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report reports = new Report();

            if (Application.OpenForms.OfType<Report>().Count() == 1)
            {
                Application.OpenForms.OfType<Report>().First().Focus();
            }
            else
            {
                reports.MdiParent = this;
                reports.Show();
            }

            reports.StartPosition = FormStartPosition.CenterScreen;
            reports.WindowState = FormWindowState.Maximized;
            reports.ControlBox = false;
            reports.MinimizeBox = false;
            reports.ShowIcon = false;
        }

        private void hesapİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AccountClosingOperation accountOperation = new AccountClosingOperation();

            if (Application.OpenForms.OfType<AccountClosingOperation>().Count() == 1)
            {
                Application.OpenForms.OfType<AccountClosingOperation>().First().Focus();
            }
            else
            {
                accountOperation.MdiParent = this;
                accountOperation.Show();
            }

            accountOperation.StartPosition = FormStartPosition.CenterScreen;
            accountOperation.WindowState = FormWindowState.Maximized;
            accountOperation.ControlBox = false;
            accountOperation.MinimizeBox = false;
            accountOperation.ShowIcon = false;

        }

        #endregion



    }
}
