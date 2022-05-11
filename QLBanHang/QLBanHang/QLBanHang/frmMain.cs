namespace QLBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect(); //Mở kết nối
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMChatLieu frmChatLieu = new frmDMChatLieu(); //Khởi tạo đối tượng
            frmChatLieu.ShowDialog(); //Hiển thị
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frmNhanVien = new frmDMNhanVien(); //Khởi tạo đối tượng
            frmNhanVien.ShowDialog(); //Hiển thị
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frmKhachHang = new frmDMKhachHang();
            frmKhachHang.ShowDialog(); 
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMHangHoa frmHangHoa = new frmDMHangHoa();
            frmHangHoa.ShowDialog();    
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frmHoaDonBan = new frmHoaDonBan(); 
            frmHoaDonBan.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimHDBan frmTimHDBan = new frmTimHDBan();
            frmTimHDBan.ShowDialog();
        }

        private void hàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}