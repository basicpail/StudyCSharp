using System;
using System.Windows.Forms;
using BookRentalShopApp.NewFolder1;
using BookRentalShopApp.SubItems;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShopApp
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            var result = MetroMessageBox.Show(this, "종료하시겠습니까?", "종료",
                System.Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(0); //프로그램 완전 종료
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MnuItemExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MnuItemCodeMng_Click(object sender, EventArgs e)
        {
            DivMngForm form = new DivMngForm();
            ShowFormControl(form,"구분코드 관리");
        }

        private void MnuItemBooksMng_Click(object sender, EventArgs e)
        {
            BooksMngForm form = new BooksMngForm();
            ShowFormControl(form,"도서 관리");
        }

        private void ShowFormControl(Form form, string title)
        {
            form.MdiParent = this;
            form.Text = title;
            form.Dock = DockStyle.Fill;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void MnuItemMemberMng_Click(object sender, EventArgs e)
        {
            MemberMngForm form = new MemberMngForm();
            ShowFormControl(form, "멤버 관리");
        }
    }
}
