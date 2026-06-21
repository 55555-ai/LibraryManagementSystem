using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace 圖書管理系統
{
    public partial class frmBooks : Form
    {
        class Book
        {
            public string Name { get; set; }
            public string Author { get; set; }
            public string Kind { get; set; }
            public string Status { get; set; }
            public string Location { get; set; }
            public string Note { get; set; }
        }

        class BorrowRecord
        {
            public string MemberName { get; set; }
            public string BookName { get; set; }
            public DateTime BorrowDate { get; set; }
            public DateTime DueDate { get; set; }
            public DateTime? ReturnDate { get; set; }
            public string Status { get; set; }
        }

        List<Book> books = new List<Book>();
        List<BorrowRecord> borrowRecords = new List<BorrowRecord>();

        const int BorrowDays = 7;
        const int FinePerDay = 5;
        const int StopDaysPerOverdueDay = 2;

        public frmBooks()
        {
            InitializeComponent();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            this.Width = 1300;
            this.Height = 850;

            grpTxtSystem.Dock = DockStyle.Left;
            grpTxtSystem.Width = 270;

            pnlTools.Dock = DockStyle.Right;
            pnlTools.Width = 360;

            lvwBooks.Dock = DockStyle.Fill;
            lvwBooks.BringToFront();

            cmbMember.Items.Clear();
            cmbMember.Items.Add("王小明");
            cmbMember.Items.Add("李小華");
            cmbMember.Items.Add("陳美玲");
            cmbMember.Items.Add("林志強");
            cmbMember.SelectedIndex = 0;

            cmbView.Items.Clear();
            cmbView.Items.Add("大圖示");
            cmbView.Items.Add("詳細資料");
            cmbView.Items.Add("小圖示");
            cmbView.Items.Add("清單");
            cmbView.Items.Add("大圖示加詳細資料");
            cmbView.SelectedIndex = 1;

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("可借閱");
            cmbStatus.Items.Add("已借出");
            cmbStatus.SelectedIndex = 0;

            lvwBooks.Columns.Clear();
            lvwBooks.Columns.Add("書名", 100);
            lvwBooks.Columns.Add("作者", 80);
            lvwBooks.Columns.Add("類別", 80);
            lvwBooks.Columns.Add("借閱狀況", 80);
            lvwBooks.Columns.Add("存放位置", 100);
            lvwBooks.Columns.Add("備註", 150);
            lvwBooks.FullRowSelect = true;
            lvwBooks.GridLines = true;
            lvwBooks.View = View.Details;

            lvwBorrowRecords.Columns.Clear();
            lvwBorrowRecords.Columns.Add("會員", 60);
            lvwBorrowRecords.Columns.Add("書名", 80);
            lvwBorrowRecords.Columns.Add("借閱日期", 80);
            lvwBorrowRecords.Columns.Add("應還日期", 80);
            lvwBorrowRecords.Columns.Add("歸還日期", 80);
            lvwBorrowRecords.Columns.Add("狀態", 70);
            lvwBorrowRecords.Columns.Add("逾期天數", 70);
            lvwBorrowRecords.Columns.Add("罰金", 70);
            lvwBorrowRecords.View = View.Details;
            lvwBorrowRecords.FullRowSelect = true;
            lvwBorrowRecords.GridLines = true;

            lvwReturnRecords.Columns.Clear();
            lvwReturnRecords.Columns.Add("會員", 60);
            lvwReturnRecords.Columns.Add("書名", 80);
            lvwReturnRecords.Columns.Add("借出日期", 80);
            lvwReturnRecords.Columns.Add("到期日", 80);
            lvwReturnRecords.Columns.Add("還書日期", 80);
            lvwReturnRecords.Columns.Add("是否逾期", 70);
            lvwReturnRecords.Columns.Add("逾期天數", 70);
            lvwReturnRecords.Columns.Add("逾期罰金", 70);
            lvwReturnRecords.Columns.Add("停借天數", 70);
            lvwReturnRecords.View = View.Details;
            lvwReturnRecords.FullRowSelect = true;
            lvwReturnRecords.GridLines = true;

            books.Add(new Book { Name = "三國演義", Author = "羅貫中", Kind = "章回小說", Status = "可借閱", Location = "A1-01", Note = "" });
            books.Add(new Book { Name = "西遊記", Author = "吳承恩", Kind = "章回小說", Status = "可借閱", Location = "A1-02", Note = "" });
            books.Add(new Book { Name = "唐詩三百首", Author = "孫洙", Kind = "詩選", Status = "可借閱", Location = "B1-01", Note = "" });
            books.Add(new Book { Name = "楚辭", Author = "劉向", Kind = "詩歌", Status = "可借閱", Location = "B1-02", Note = "" });
            books.Add(new Book { Name = "西廂記", Author = "王實甫", Kind = "戲曲", Status = "可借閱", Location = "C1-01", Note = "" });
            books.Add(new Book { Name = "水滸傳", Author = "施耐庵", Kind = "章回小說", Status = "可借閱", Location = "A1-03", Note = "" });
            books.Add(new Book { Name = "紅樓夢", Author = "曹雪芹", Kind = "章回小說", Status = "可借閱", Location = "A1-04", Note = "" });
            books.Add(new Book { Name = "牡丹亭", Author = "湯顯祖", Kind = "戲曲", Status = "可借閱", Location = "C1-02", Note = "" });

            ShowBooks();
            ShowCurrentMemberBorrowList();
            ShowMemberBorrowRecords();
            ShowMemberReturnRecords();
        }

        private void ShowBooks()
        {
            lvwBooks.Items.Clear();

            for (int i = 0; i < books.Count; i++)
            {
                Book book = books[i];

                ListViewItem item = new ListViewItem(book.Name);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.Kind);
                item.SubItems.Add(book.Status);
                item.SubItems.Add(book.Location);
                item.SubItems.Add(book.Note);

                if (i < imgL.Images.Count)
                {
                    item.ImageIndex = i;
                }

                lvwBooks.Items.Add(item);
            }
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbView.SelectedIndex)
            {
                case 0:
                    lvwBooks.View = View.LargeIcon;
                    break;
                case 1:
                    lvwBooks.View = View.Details;
                    break;
                case 2:
                    lvwBooks.View = View.SmallIcon;
                    break;
                case 3:
                    lvwBooks.View = View.List;
                    break;
                case 4:
                    lvwBooks.View = View.Tile;
                    break;
            }
        }

        private void lvwBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwBooks.SelectedIndices.Count == 0) return;

            int index = lvwBooks.SelectedIndices[0];
            Book book = books[index];

            txtBookName.Text = book.Name;
            txtAuthor.Text = book.Author;
            txtKind.Text = book.Kind;
            cmbStatus.Text = book.Status;
            txtLocation.Text = book.Location;
            txtNote.Text = book.Note;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book
            {
                Name = txtBookName.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                Kind = txtKind.Text.Trim(),
                Status = cmbStatus.Text,
                Location = txtLocation.Text.Trim(),
                Note = txtNote.Text.Trim()
            };

            books.Add(book);
            ShowBooks();
            ClearInput();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwBooks.SelectedIndices.Count == 0)
            {
                MessageBox.Show("請先選擇要修改的書籍。");
                return;
            }

            int index = lvwBooks.SelectedIndices[0];

            books[index].Name = txtBookName.Text.Trim();
            books[index].Author = txtAuthor.Text.Trim();
            books[index].Kind = txtKind.Text.Trim();
            books[index].Status = cmbStatus.Text;
            books[index].Location = txtLocation.Text.Trim();
            books[index].Note = txtNote.Text.Trim();

            ShowBooks();
            ClearInput();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwBooks.SelectedIndices.Count == 0)
            {
                MessageBox.Show("請先選擇要刪除的書籍。");
                return;
            }

            int index = lvwBooks.SelectedIndices[0];

            DialogResult result = MessageBox.Show(
                "確定要刪除這本書嗎？",
                "刪除確認",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                books.RemoveAt(index);
                ShowBooks();
                ClearInput();
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (cmbMember.SelectedIndex == -1)
            {
                MessageBox.Show("請先選擇會員。");
                return;
            }

            Book book = GetSelectedOrInputBook();
            if (book == null) return;

            if (book.Status == "已借出")
            {
                MessageBox.Show("這本書已經被借出了。");
                return;
            }

            book.Status = "已借出";

            BorrowRecord record = new BorrowRecord
            {
                MemberName = cmbMember.Text,
                BookName = book.Name,
                BorrowDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(BorrowDays),
                ReturnDate = null,
                Status = "借閱中"
            };

            borrowRecords.Add(record);

            ShowBooks();
            ShowCurrentMemberBorrowList();
            ShowMemberBorrowRecords();
            ShowMemberReturnRecords();

            MessageBox.Show("借閱成功。");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (cmbMember.SelectedIndex == -1)
            {
                MessageBox.Show("請先選擇會員。");
                return;
            }

            Book book = GetSelectedOrInputBook();
            if (book == null) return;

            if (book.Status == "可借閱")
            {
                MessageBox.Show("這本書目前沒有被借出。");
                return;
            }

            BorrowRecord record = borrowRecords.LastOrDefault(r =>
                r.MemberName == cmbMember.Text &&
                r.BookName == book.Name &&
                !r.ReturnDate.HasValue
            );

            if (record == null)
            {
                MessageBox.Show("找不到這位會員的借閱中紀錄。");
                return;
            }

            book.Status = "可借閱";
            record.ReturnDate = DateTime.Now;
            record.Status = GetRecordStatus(record);

            ShowBooks();
            ShowCurrentMemberBorrowList();
            ShowMemberBorrowRecords();
            ShowMemberReturnRecords();

            MessageBox.Show("歸還成功。");
        }

        private Book GetSelectedOrInputBook()
        {
            if (lvwBooks.SelectedIndices.Count > 0)
            {
                int index = lvwBooks.SelectedIndices[0];
                return books[index];
            }

            string bookName = txtBookName.Text.Trim();

            if (bookName == "")
            {
                MessageBox.Show("請先選擇一本書或輸入書名。");
                return null;
            }

            Book book = books.FirstOrDefault(b => b.Name == bookName);

            if (book == null)
            {
                MessageBox.Show("查無此書。");
                return null;
            }

            return book;
        }

        private void ShowCurrentMemberBorrowList()
        {
            lstBorrow.Items.Clear();

            string memberName = cmbMember.Text;

            var records = borrowRecords
                .Where(r => r.MemberName == memberName && !r.ReturnDate.HasValue)
                .ToList();

            foreach (BorrowRecord record in records)
            {
                string status = GetRecordStatus(record);

                if (status == "已逾期")
                {
                    lstBorrow.Items.Add(record.BookName + "（已逾期 " + GetOverdueDays(record) + " 天）");
                }
                else
                {
                    lstBorrow.Items.Add(record.BookName);
                }
            }
        }

        private void ShowMemberBorrowRecords()
        {
            lvwBorrowRecords.Items.Clear();

            string memberName = cmbMember.Text;

            var records = borrowRecords
                .Where(r => r.MemberName == memberName)
                .ToList();

            foreach (BorrowRecord record in records)
            {
                int overdueDays = GetOverdueDays(record);
                int fine = GetFine(record);
                string status = GetRecordStatus(record);

                ListViewItem item = new ListViewItem(record.MemberName);
                item.SubItems.Add(record.BookName);
                item.SubItems.Add(record.BorrowDate.ToString("yyyy/MM/dd"));
                item.SubItems.Add(record.DueDate.ToString("yyyy/MM/dd"));
                item.SubItems.Add(record.ReturnDate.HasValue ? record.ReturnDate.Value.ToString("yyyy/MM/dd") : "尚未歸還");
                item.SubItems.Add(status);
                item.SubItems.Add(overdueDays.ToString());
                item.SubItems.Add(fine.ToString() + " 元");

                if (status == "已逾期" || status == "逾期歸還")
                {
                    item.ForeColor = Color.Red;
                }

                lvwBorrowRecords.Items.Add(item);
            }
        }

        private void ShowMemberReturnRecords()
        {
            lvwReturnRecords.Items.Clear();

            string memberName = cmbMember.Text;

            var records = borrowRecords
                .Where(r => r.MemberName == memberName && r.ReturnDate.HasValue)
                .ToList();

            foreach (BorrowRecord record in records)
            {
                int overdueDays = GetOverdueDays(record);
                int fine = GetFine(record);
                int stopBorrowDays = GetStopBorrowDays(record);
                bool isOverdue = overdueDays > 0;

                ListViewItem item = new ListViewItem(record.MemberName);
                item.SubItems.Add(record.BookName);
                item.SubItems.Add(record.BorrowDate.ToString("yyyy/MM/dd"));
                item.SubItems.Add(record.DueDate.ToString("yyyy/MM/dd"));
                item.SubItems.Add(record.ReturnDate.Value.ToString("yyyy/MM/dd"));
                item.SubItems.Add(isOverdue ? "是" : "否");
                item.SubItems.Add(overdueDays.ToString());
                item.SubItems.Add(fine.ToString() + " 元");
                item.SubItems.Add(stopBorrowDays.ToString() + " 天");

                if (isOverdue)
                {
                    item.ForeColor = Color.Red;
                }

                lvwReturnRecords.Items.Add(item);
            }
        }

        private int GetOverdueDays(BorrowRecord record)
        {
            DateTime checkDate;

            if (record.ReturnDate.HasValue)
            {
                checkDate = record.ReturnDate.Value.Date;
            }
            else
            {
                checkDate = DateTime.Now.Date;
            }

            int overdueDays = (checkDate - record.DueDate.Date).Days;

            if (overdueDays < 0)
            {
                return 0;
            }

            return overdueDays;
        }

        private int GetFine(BorrowRecord record)
        {
            int overdueDays = GetOverdueDays(record);
            return overdueDays * FinePerDay;
        }

        private int GetStopBorrowDays(BorrowRecord record)
        {
            int overdueDays = GetOverdueDays(record);
            return overdueDays * StopDaysPerOverdueDay;
        }

        private string GetRecordStatus(BorrowRecord record)
        {
            if (record.ReturnDate.HasValue)
            {
                if (GetOverdueDays(record) > 0)
                {
                    return "逾期歸還";
                }

                return "已歸還";
            }

            if (DateTime.Now.Date > record.DueDate.Date)
            {
                return "已逾期";
            }

            return "借閱中";
        }

        private void ClearInput()
        {
            txtBookName.Clear();
            txtAuthor.Clear();
            txtKind.Clear();
            txtLocation.Clear();
            txtNote.Clear();
            cmbStatus.SelectedIndex = 0;
        }

        private void btnShowRecord_Click(object sender, EventArgs e)
        {
            ShowMemberBorrowRecords();
            ShowMemberReturnRecords();
        }

        private void cmbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCurrentMemberBorrowList();
            ShowMemberBorrowRecords();
            ShowMemberReturnRecords();
        }
    }
}