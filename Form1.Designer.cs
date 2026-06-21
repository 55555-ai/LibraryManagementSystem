namespace 圖書管理系統
{
    partial class frmBooks
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooks));
            this.imgL = new System.Windows.Forms.ImageList(this.components);
            this.lvwBooks = new System.Windows.Forms.ListView();
            this.imgS = new System.Windows.Forms.ImageList(this.components);
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.lstBorrow = new System.Windows.Forms.ListBox();
            this.grpView = new System.Windows.Forms.GroupBox();
            this.grpBorrow = new System.Windows.Forms.GroupBox();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.grpVip = new System.Windows.Forms.GroupBox();
            this.lvwReturnRecords = new System.Windows.Forms.ListView();
            this.lblReturnRecords = new System.Windows.Forms.Label();
            this.btnShowRecord = new System.Windows.Forms.Button();
            this.lblLvwBorrowRecords = new System.Windows.Forms.Label();
            this.lvwBorrowRecords = new System.Windows.Forms.ListView();
            this.lblCmbMember = new System.Windows.Forms.Label();
            this.cmbMember = new System.Windows.Forms.ComboBox();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.grpTxtSystem = new System.Windows.Forms.GroupBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTxtNote = new System.Windows.Forms.Label();
            this.lbltxtLocation = new System.Windows.Forms.Label();
            this.lblTxtKind = new System.Windows.Forms.Label();
            this.lblTxtAuthor = new System.Windows.Forms.Label();
            this.lblTxtBookName = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtKind = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.grpView.SuspendLayout();
            this.grpBorrow.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.grpVip.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.grpTxtSystem.SuspendLayout();
            this.grpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgL
            // 
            this.imgL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgL.ImageStream")));
            this.imgL.TransparentColor = System.Drawing.Color.Transparent;
            this.imgL.Images.SetKeyName(0, "三國演義.jpg");
            this.imgL.Images.SetKeyName(1, "西遊記.jpg");
            this.imgL.Images.SetKeyName(2, "唐詩三百首.jpg");
            this.imgL.Images.SetKeyName(3, "楚辭.jpg");
            this.imgL.Images.SetKeyName(4, "西廂記.jpg");
            this.imgL.Images.SetKeyName(5, "水滸傳.jpg");
            this.imgL.Images.SetKeyName(6, "紅樓夢.jpg");
            this.imgL.Images.SetKeyName(7, "牡丹亭.jpg");
            // 
            // lvwBooks
            // 
            this.lvwBooks.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvwBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwBooks.HideSelection = false;
            this.lvwBooks.LargeImageList = this.imgL;
            this.lvwBooks.Location = new System.Drawing.Point(0, 0);
            this.lvwBooks.Name = "lvwBooks";
            this.lvwBooks.Size = new System.Drawing.Size(1117, 985);
            this.lvwBooks.SmallImageList = this.imgS;
            this.lvwBooks.TabIndex = 0;
            this.lvwBooks.UseCompatibleStateImageBehavior = false;
            this.lvwBooks.Click += new System.EventHandler(this.lvwBooks_SelectedIndexChanged);
            // 
            // imgS
            // 
            this.imgS.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgS.ImageStream")));
            this.imgS.TransparentColor = System.Drawing.Color.Transparent;
            this.imgS.Images.SetKeyName(0, "三國演義.jpg");
            this.imgS.Images.SetKeyName(1, "西遊記.jpg");
            this.imgS.Images.SetKeyName(2, "唐詩三百首.jpg");
            this.imgS.Images.SetKeyName(3, "楚辭.jpg");
            this.imgS.Images.SetKeyName(4, "西廂記.jpg");
            this.imgS.Images.SetKeyName(5, "水滸傳.jpg");
            this.imgS.Images.SetKeyName(6, "紅樓夢.jpg");
            this.imgS.Images.SetKeyName(7, "牡丹亭.jpg");
            // 
            // cmbView
            // 
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Location = new System.Drawing.Point(23, 44);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(278, 32);
            this.cmbView.TabIndex = 1;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // lstBorrow
            // 
            this.lstBorrow.FormattingEnabled = true;
            this.lstBorrow.ItemHeight = 24;
            this.lstBorrow.Location = new System.Drawing.Point(20, 35);
            this.lstBorrow.Name = "lstBorrow";
            this.lstBorrow.Size = new System.Drawing.Size(278, 76);
            this.lstBorrow.TabIndex = 2;
            // 
            // grpView
            // 
            this.grpView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpView.Controls.Add(this.cmbView);
            this.grpView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpView.Location = new System.Drawing.Point(0, 0);
            this.grpView.Name = "grpView";
            this.grpView.Size = new System.Drawing.Size(324, 100);
            this.grpView.TabIndex = 3;
            this.grpView.TabStop = false;
            this.grpView.Text = "檢視方式";
            // 
            // grpBorrow
            // 
            this.grpBorrow.Controls.Add(this.lstBorrow);
            this.grpBorrow.Location = new System.Drawing.Point(3, 106);
            this.grpBorrow.Name = "grpBorrow";
            this.grpBorrow.Size = new System.Drawing.Size(321, 139);
            this.grpBorrow.TabIndex = 4;
            this.grpBorrow.TabStop = false;
            this.grpBorrow.Text = "借書清單";
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTools.Controls.Add(this.grpVip);
            this.pnlTools.Controls.Add(this.grpView);
            this.pnlTools.Controls.Add(this.grpBorrow);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTools.Location = new System.Drawing.Point(790, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(327, 985);
            this.pnlTools.TabIndex = 5;
            // 
            // grpVip
            // 
            this.grpVip.Controls.Add(this.lvwReturnRecords);
            this.grpVip.Controls.Add(this.lblReturnRecords);
            this.grpVip.Controls.Add(this.btnShowRecord);
            this.grpVip.Controls.Add(this.lblLvwBorrowRecords);
            this.grpVip.Controls.Add(this.lvwBorrowRecords);
            this.grpVip.Controls.Add(this.lblCmbMember);
            this.grpVip.Controls.Add(this.cmbMember);
            this.grpVip.Location = new System.Drawing.Point(3, 259);
            this.grpVip.Name = "grpVip";
            this.grpVip.Size = new System.Drawing.Size(321, 723);
            this.grpVip.TabIndex = 6;
            this.grpVip.TabStop = false;
            this.grpVip.Text = " 9=";
            // 
            // lvwReturnRecords
            // 
            this.lvwReturnRecords.HideSelection = false;
            this.lvwReturnRecords.Location = new System.Drawing.Point(23, 407);
            this.lvwReturnRecords.Name = "lvwReturnRecords";
            this.lvwReturnRecords.Size = new System.Drawing.Size(275, 132);
            this.lvwReturnRecords.TabIndex = 16;
            this.lvwReturnRecords.UseCompatibleStateImageBehavior = false;
            // 
            // lblReturnRecords
            // 
            this.lblReturnRecords.AutoSize = true;
            this.lblReturnRecords.Location = new System.Drawing.Point(3, 364);
            this.lblReturnRecords.Name = "lblReturnRecords";
            this.lblReturnRecords.Size = new System.Drawing.Size(130, 24);
            this.lblReturnRecords.TabIndex = 15;
            this.lblReturnRecords.Text = "會員還書單";
            // 
            // btnShowRecord
            // 
            this.btnShowRecord.Location = new System.Drawing.Point(23, 287);
            this.btnShowRecord.Name = "btnShowRecord";
            this.btnShowRecord.Size = new System.Drawing.Size(275, 58);
            this.btnShowRecord.TabIndex = 11;
            this.btnShowRecord.Text = "查詢會員借閱紀錄";
            this.btnShowRecord.UseVisualStyleBackColor = true;
            this.btnShowRecord.Click += new System.EventHandler(this.btnShowRecord_Click);
            // 
            // lblLvwBorrowRecords
            // 
            this.lblLvwBorrowRecords.AutoSize = true;
            this.lblLvwBorrowRecords.Location = new System.Drawing.Point(3, 124);
            this.lblLvwBorrowRecords.Name = "lblLvwBorrowRecords";
            this.lblLvwBorrowRecords.Size = new System.Drawing.Size(202, 24);
            this.lblLvwBorrowRecords.TabIndex = 10;
            this.lblLvwBorrowRecords.Text = "顯示會員借閱紀錄";
            // 
            // lvwBorrowRecords
            // 
            this.lvwBorrowRecords.HideSelection = false;
            this.lvwBorrowRecords.Location = new System.Drawing.Point(23, 151);
            this.lvwBorrowRecords.Name = "lvwBorrowRecords";
            this.lvwBorrowRecords.Size = new System.Drawing.Size(275, 118);
            this.lvwBorrowRecords.TabIndex = 9;
            this.lvwBorrowRecords.UseCompatibleStateImageBehavior = false;
            // 
            // lblCmbMember
            // 
            this.lblCmbMember.AutoSize = true;
            this.lblCmbMember.Location = new System.Drawing.Point(3, 45);
            this.lblCmbMember.Name = "lblCmbMember";
            this.lblCmbMember.Size = new System.Drawing.Size(106, 24);
            this.lblCmbMember.TabIndex = 8;
            this.lblCmbMember.Text = "選擇會員";
            // 
            // cmbMember
            // 
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Location = new System.Drawing.Point(23, 72);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(275, 32);
            this.cmbMember.TabIndex = 7;
            this.cmbMember.SelectedIndexChanged += new System.EventHandler(this.cmbMember_SelectedIndexChanged);
            this.cmbMember.Click += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.cmbStatus);
            this.grpStatus.Location = new System.Drawing.Point(0, 422);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(274, 109);
            this.grpStatus.TabIndex = 5;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "借閱狀況";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(26, 35);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(213, 32);
            this.cmbStatus.TabIndex = 0;
            // 
            // grpTxtSystem
            // 
            this.grpTxtSystem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpTxtSystem.Controls.Add(this.grpButton);
            this.grpTxtSystem.Controls.Add(this.grpStatus);
            this.grpTxtSystem.Controls.Add(this.lblTxtNote);
            this.grpTxtSystem.Controls.Add(this.lbltxtLocation);
            this.grpTxtSystem.Controls.Add(this.lblTxtKind);
            this.grpTxtSystem.Controls.Add(this.lblTxtAuthor);
            this.grpTxtSystem.Controls.Add(this.lblTxtBookName);
            this.grpTxtSystem.Controls.Add(this.txtNote);
            this.grpTxtSystem.Controls.Add(this.txtLocation);
            this.grpTxtSystem.Controls.Add(this.txtKind);
            this.grpTxtSystem.Controls.Add(this.txtAuthor);
            this.grpTxtSystem.Controls.Add(this.txtBookName);
            this.grpTxtSystem.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpTxtSystem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.grpTxtSystem.Location = new System.Drawing.Point(0, 0);
            this.grpTxtSystem.Name = "grpTxtSystem";
            this.grpTxtSystem.Size = new System.Drawing.Size(274, 985);
            this.grpTxtSystem.TabIndex = 5;
            this.grpTxtSystem.TabStop = false;
            this.grpTxtSystem.Text = "查詢系統";
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.btnReturn);
            this.grpButton.Controls.Add(this.btnBorrow);
            this.grpButton.Controls.Add(this.btnDelete);
            this.grpButton.Controls.Add(this.btnEdit);
            this.grpButton.Controls.Add(this.btnAdd);
            this.grpButton.Location = new System.Drawing.Point(0, 556);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(274, 349);
            this.grpButton.TabIndex = 10;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "按扭區";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(29, 227);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(213, 35);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "歸還";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(32, 183);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(213, 29);
            this.btnBorrow.TabIndex = 3;
            this.btnBorrow.Text = "借閱";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(29, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(213, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "刪除選取書籍";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(29, 86);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(213, 32);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "修改選取書籍";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(213, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增書籍";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTxtNote
            // 
            this.lblTxtNote.AutoSize = true;
            this.lblTxtNote.Location = new System.Drawing.Point(25, 334);
            this.lblTxtNote.Name = "lblTxtNote";
            this.lblTxtNote.Size = new System.Drawing.Size(58, 24);
            this.lblTxtNote.TabIndex = 9;
            this.lblTxtNote.Text = "備註";
            // 
            // lbltxtLocation
            // 
            this.lbltxtLocation.AutoSize = true;
            this.lbltxtLocation.Location = new System.Drawing.Point(25, 259);
            this.lbltxtLocation.Name = "lbltxtLocation";
            this.lbltxtLocation.Size = new System.Drawing.Size(106, 24);
            this.lbltxtLocation.TabIndex = 8;
            this.lbltxtLocation.Text = "存放位置";
            // 
            // lblTxtKind
            // 
            this.lblTxtKind.AutoSize = true;
            this.lblTxtKind.Location = new System.Drawing.Point(25, 182);
            this.lblTxtKind.Name = "lblTxtKind";
            this.lblTxtKind.Size = new System.Drawing.Size(58, 24);
            this.lblTxtKind.TabIndex = 7;
            this.lblTxtKind.Text = "類別";
            // 
            // lblTxtAuthor
            // 
            this.lblTxtAuthor.AutoSize = true;
            this.lblTxtAuthor.Location = new System.Drawing.Point(25, 106);
            this.lblTxtAuthor.Name = "lblTxtAuthor";
            this.lblTxtAuthor.Size = new System.Drawing.Size(58, 24);
            this.lblTxtAuthor.TabIndex = 6;
            this.lblTxtAuthor.Text = "作者";
            // 
            // lblTxtBookName
            // 
            this.lblTxtBookName.AutoSize = true;
            this.lblTxtBookName.Location = new System.Drawing.Point(22, 32);
            this.lblTxtBookName.Name = "lblTxtBookName";
            this.lblTxtBookName.Size = new System.Drawing.Size(58, 24);
            this.lblTxtBookName.TabIndex = 5;
            this.lblTxtBookName.Text = "書名";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(29, 361);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(213, 36);
            this.txtNote.TabIndex = 4;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(29, 286);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(213, 36);
            this.txtLocation.TabIndex = 3;
            // 
            // txtKind
            // 
            this.txtKind.Location = new System.Drawing.Point(29, 209);
            this.txtKind.Name = "txtKind";
            this.txtKind.Size = new System.Drawing.Size(216, 36);
            this.txtKind.TabIndex = 2;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(29, 133);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(213, 36);
            this.txtAuthor.TabIndex = 1;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(29, 59);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(213, 36);
            this.txtBookName.TabIndex = 0;
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 985);
            this.Controls.Add(this.grpTxtSystem);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.lvwBooks);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "frmBooks";
            this.Text = "圖書館理系統";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.grpView.ResumeLayout(false);
            this.grpBorrow.ResumeLayout(false);
            this.pnlTools.ResumeLayout(false);
            this.grpVip.ResumeLayout(false);
            this.grpVip.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.grpTxtSystem.ResumeLayout(false);
            this.grpTxtSystem.PerformLayout();
            this.grpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgL;
        private System.Windows.Forms.ListView lvwBooks;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.ListBox lstBorrow;
        private System.Windows.Forms.GroupBox grpView;
        private System.Windows.Forms.GroupBox grpBorrow;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.ImageList imgS;
        private System.Windows.Forms.GroupBox grpTxtSystem;
        private System.Windows.Forms.TextBox txtKind;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblTxtKind;
        private System.Windows.Forms.Label lblTxtAuthor;
        private System.Windows.Forms.Label lblTxtBookName;
        private System.Windows.Forms.Label lbltxtLocation;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpVip;
        private System.Windows.Forms.Button btnShowRecord;
        private System.Windows.Forms.Label lblLvwBorrowRecords;
        private System.Windows.Forms.ListView lvwBorrowRecords;
        private System.Windows.Forms.Label lblCmbMember;
        private System.Windows.Forms.ComboBox cmbMember;
        private System.Windows.Forms.Label lblTxtNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ListView lvwReturnRecords;
        private System.Windows.Forms.Label lblReturnRecords;
    }
}

