using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;
namespace LayNhanVienNgauNhien
{

    public partial class Toolvanphong : Form
    {
        List<User> listUser = new List<User>();

        public Toolvanphong()
        {
            InitializeComponent();
            

        }
      

        public void LoadPhongBan()
        {


            comboBox1.Items.Clear();
            comboBox1.Items.Add("Xem Tất Cả");
            if (listUser.Count > 0)
            {
                List<String> listPhongBan = LayDanhSachPhongBan();
                foreach (var item in listPhongBan)
                {
                    comboBox1.Items.Add(item);
                }
            }
        }
        private void ShowProgressBarForThreeSeconds(int thoigian)
        {
            // Hiển thị ProgressBar
            progressBar1.Visible = true;

            // Tạo một Timer với thời gian là 3 giây
            Timer timer = new Timer();
            timer.Interval = 100; // Cập nhật giá trị mỗi 100ms
            int progressValue = 0; // Giá trị ban đầu của ProgressBar
            timer.Tick += (sender, e) =>
            {
                if (progressValue < 100)
                {
                    progressValue+= thoigian; // Tăng giá trị của ProgressBar
                    progressBar1.Value = progressValue; // Cập nhật giá trị mới cho ProgressBar
                }
                else
                {
                    // Đạt giá trị tối đa, dừng Timer và ẩn ProgressBar
                    timer.Stop();
                    progressBar1.Visible = false;
                }
            };

            // Bắt đầu đếm thời gian
            timer.Start();
        }


        private void Toolvanphong_Load(object sender, EventArgs e)
        {
            numberich_Tongnhanvien.Value = 30;
            numeric_nhanvienmoidonvi.Value = 1;
            
            lsv_ketqua.ItemChecked += lsv_ketqua_ItemChecked;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
        }
        public void lsv_ketqua_ItemChecked(object sender, EventArgs e)
        {
            int tongSoDong = lsv_ketqua.Items.Count;
            lb_ketqua.Text = tongSoDong.ToString();
        }


        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void HienThiDanhSach(ref System.Windows.Forms.ListView lsv_c, List<User> listUserTmp)
        {
            lsv_c.Items.Clear();
            int stt = 1;
            foreach (var item in listUserTmp)
            {
                ListViewItem lsv = new ListViewItem(stt.ToString());
                lsv.SubItems.Add(item.maNV.ToString());
                lsv.SubItems.Add(item.hoTen.ToString());
                lsv.SubItems.Add(item.phongBan.ToString());
                lsv.SubItems.Add(item.chucDanh.ToString());

                lsv_c.Items.Add(lsv);
                stt += 1;


            }

        }
        public List<String> LayDanhSachPhongBan()
        {
            HashSet<string> departments = new HashSet<string>();
            foreach (var employee in listUser)
            {
                departments.Add(employee.phongBan);
            }


            return departments.ToList();
        }

        public List<User> LocUserTheoPhongBan(String tenPhongBan)
        {
            if (listUser.Count > 0)
            {
                List<User> userLoc = new List<User>();
                userLoc.Clear();
                foreach (var item in listUser)
                {
                    if (item.phongBan == tenPhongBan)
                    {
                        userLoc.Add(item);
                    }
                }

                return userLoc;


            }
            else
            {
                return null;
            }
        }
        public void HienThiNhanVienTheoPhongBan(String phongBanCanLoc, bool Base = false)
        {
            if (Base)
            {
                HienThiDanhSach(ref lsv_danhsach, listUser);

                return;
            }
            List<User> userLoc = new List<User>();
            userLoc.Clear();
            if (listUser.Count > 0)
            {
                foreach (var item in listUser)
                {
                    if (item.phongBan == phongBanCanLoc)
                    {
                        userLoc.Add(item);
                    }
                }

                HienThiDanhSach(ref lsv_danhsach, userLoc);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            // HienThiDanhSach(userLoc);
        }

        private void lsv_danhsach_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void lsv_danhsach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Lấy dữ liệu từ Clipboard
                string clipboardText = Clipboard.GetText();

                // Phân tích dữ liệu thành từng dòng
                string[] rows = clipboardText.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                // Hiển thị dữ liệu từng dòng và cột trong ListView
                lsv_danhsach.Items.Clear(); // Xóa dữ liệu cũ
                listUser.Clear();

                foreach (string row in rows)
                {
                    string[] columns = row.Split('\t'); // Phân tách cột bằng tab

                    ListViewItem item = new ListViewItem(columns[0]); // Thêm dữ liệu cho cột đầu tiên

                    // Thêm các dữ liệu cho các cột tiếp theo (nếu có)
                    String maNhanVienTmp = "";
                    String hoTenTmp = "";
                    String phongBanTmp = "";
                    String chucDanhTmp = "";
                    for (int i = 1; i < columns.Length; i++)
                    {
                        item.SubItems.Add(columns[i].Trim());
                        if (i == 1)
                        {
                            maNhanVienTmp = columns[i].Trim();
                        }
                        else if (i == 2)
                        {
                            hoTenTmp = columns[i].Trim();
                        }
                        else if (i == 3)
                        {
                            phongBanTmp = columns[i].Trim();
                        }
                        else if (i == 4)
                        {
                            chucDanhTmp = columns[i].Trim();
                        }


                    }

                    User userTmp = new User(maNhanVienTmp, hoTenTmp, phongBanTmp, chucDanhTmp);
                    listUser.Add(userTmp);
                    lsv_danhsach.Items.Add(item); // Thêm ListViewItem vào ListView

                }
                LoadPhongBan();
                lb_tongsodong.Text = lsv_danhsach.Items.Count.ToString();
            }
        }

        

        // Xử lý sự kiện thay đổi số lượng dòng trong ListView
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click_1(object sender, EventArgs e)
        {
            comboBox1.DropDownWidth = 260;


        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String phongBanDangChon = comboBox1.SelectedItem.ToString();
            if (comboBox1.SelectedIndex == 0)
            {

                HienThiNhanVienTheoPhongBan(phongBanDangChon, true);
            }
            else
            {
                HienThiNhanVienTheoPhongBan(phongBanDangChon);

            }


        }

        public Dictionary<string, int> KhoiTaoDictQuanLyPhongBan()
        {
            List<String> listPhongBan = LayDanhSachPhongBan();
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            foreach (var item in listPhongBan)
            {
                myDictionary[item] = 0;

            }

            return myDictionary;
        }

        private void btn_layngaunhien_Click(object sender, EventArgs e)
        {
            
            if(listUser.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (listUser.Count > 0 && numberich_Tongnhanvien.Value > listUser.Count)
            {
                MessageBox.Show("Tổng số lượng nhân viên muốn lấy lớn hơn tổng số nhân viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (listUser.Count > 0 && numeric_nhanvienmoidonvi.Value > listUser.Count)
            {
                MessageBox.Show("Số lượng nhân viên muốn lấy ở mỗi đơn vị lớn hơn tổng số nhân viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<User> userLoc = new List<User>();
            List<String> listPhongBan = LayDanhSachPhongBan();
            Dictionary<string, int> myDictPB = KhoiTaoDictQuanLyPhongBan();
            List<User> selectedUserRamdoms = new List<User>();

            // Sử dụng Random để tạo số ngẫu nhiên
            Random random = new Random();

            decimal tongSoLuongCanLay = numberich_Tongnhanvien.Value;
            decimal soLuongCanLayMoiDonVi = numeric_nhanvienmoidonvi.Value;

            foreach (var item in listPhongBan)
            {
                List<User> listUserTmpPhongBanUsed = new List<User>();
                List<User> listUserTmpPhongBan = LocUserTheoPhongBan(item);

                if (listUser.Count > 0 && numeric_nhanvienmoidonvi.Value > listUserTmpPhongBan.Count)
                {
                    MessageBox.Show($"Số lượng nhân viên muốn lấy ở Phòng ban / Phòng giao dịch {item} lớn hơn tổng số nhân viên của đơn vị {item}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                while (myDictPB[item] < soLuongCanLayMoiDonVi)
                {
                    // Lấy một số ngẫu nhiên từ mảng a
                    User randomUser = listUserTmpPhongBan[random.Next(listUserTmpPhongBan.Count)];

                    // Kiểm tra xem số đã được chọn chưa
                    if (!listUserTmpPhongBanUsed.Contains(randomUser))
                    {
                        // Nếu chưa được chọn thì thêm vào danh sách các số đã được chọn
                        listUserTmpPhongBanUsed.Add(randomUser);
                        selectedUserRamdoms.Add(randomUser);
                        myDictPB[item] += 1;


                    }
                }
            }

            ShowProgressBarForThreeSeconds(25);
            HienThiDanhSach(ref lsv_ketqua, selectedUserRamdoms);
            int tongSoDong = lsv_ketqua.Items.Count;
            lb_ketqua.Text = tongSoDong.ToString();
            btnXuatFileExcel.Enabled = true;
            




        }

        private void numberich_Tongnhanvien_ValueChanged(object sender, EventArgs e)
        {
            if (listUser.Count > 0 && numberich_Tongnhanvien.Value > listUser.Count)
            {
                MessageBox.Show("Tổng số lượng nhân viên muốn lấy lớn hơn tổng số nhân viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void numeric_nhanvienmoidonvi_ValueChanged(object sender, EventArgs e)
        {
            if (listUser.Count > 0 && numberich_Tongnhanvien.Value > listUser.Count)
            {
                MessageBox.Show("Số lượng nhân viên muốn lấy ở mỗi đơn vị lớn hơn tổng số nhân viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lsv_ketqua_ItemActivate(object sender, EventArgs e)
        {
            
        }

        private void lsv_ketqua_BindingContextChanged(object sender, EventArgs e)
        {
            lb_ketqua.Text = lsv_ketqua.Items.Count.ToString();
        }

        private void lsv_ketqua_Resize(object sender, EventArgs e)
        {

        }

        private void lsv_ketqua_SizeChanged(object sender, EventArgs e)
        {
           
        }

        private void lsv_ketqua_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
           
        }
        private void ExportListViewToExcel(System.Windows.Forms. ListView listView)
        {
           
            // Lấy đường dẫn tới thư mục Download
            string downloadFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\";

            // Tạo một ứng dụng Excel mới
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Add();
            Excel.Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Sheets[1];

            try
            {
                // Ghi tên cột vào hàng đầu tiên của Worksheet
                for (int i = 0; i < listView.Columns.Count; i++)
                {
                    xlWorksheet.Cells[1, i + 1] = listView.Columns[i].Text;
                }

                // Ghi dữ liệu từ ListView vào Worksheet
                for (int i = 0; i < listView.Items.Count; i++)
                {
                    for (int j = 0; j < listView.Columns.Count; j++)
                    {
                        xlWorksheet.Cells[i + 2, j + 1] = listView.Items[i].SubItems[j].Text;
                    }
                }

                // Tạo tên file với ngày xuất
                string fileName = "Ketqualaynhanvien" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".xlsx";

                // Lưu Workbook
                xlWorkbook.SaveAs(downloadFolder + fileName);

                MessageBox.Show("Xuất file Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xuất file Excel: " + ex.Message);
            }
            finally
            {
                // Đóng Workbook và ứng dụng Excel
                xlWorkbook.Close(true);
                xlApp.Quit();

                ReleaseObject(xlWorksheet);
                ReleaseObject(xlWorkbook);
                ReleaseObject(xlApp);
            }
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Error releasing object: " + ex.Message);
            }
            finally
            {
                GC.Collect();
            }
        }

        
        private async void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
           
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Close();
        }

        private void btnXuatFileExcel_Click_1(object sender, EventArgs e)
        {
            ShowProgressBarForThreeSeconds(10);
            ExportListViewToExcel(lsv_ketqua);
        }
    }
}
