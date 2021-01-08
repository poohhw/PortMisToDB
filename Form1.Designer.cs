
namespace PortMisDataToDB
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gC_Form1 = new GCControls.GC_Form();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx_VHF_DETAIL = new System.Windows.Forms.ListBox();
            this.lbx_VHF = new System.Windows.Forms.ListBox();
            this.lbx_FU = new System.Windows.Forms.ListBox();
            this.lbx_DC = new System.Windows.Forms.ListBox();
            this.lbx_PIO = new System.Windows.Forms.ListBox();
            this.lbx_SI = new System.Windows.Forms.ListBox();
            this.lbl_RootFolder = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFLCount = new System.Windows.Forms.Label();
            this.lblFIOCount = new System.Windows.Forms.Label();
            this.lblDCCount = new System.Windows.Forms.Label();
            this.lblFUCount = new System.Windows.Forms.Label();
            this.lblVHFCount = new System.Windows.Forms.Label();
            this.lblVHFDetailCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gC_Form1
            // 
            this.gC_Form1.Description = "Portmis To DB";
            this.gC_Form1.FormTitle = "GC";
            this.gC_Form1.Location = new System.Drawing.Point(-1, -4);
            this.gC_Form1.MaxButtonVisible = false;
            this.gC_Form1.Name = "gC_Form1";
            this.gC_Form1.Size = new System.Drawing.Size(1094, 602);
            this.gC_Form1.TabIndex = 0;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.txtLog, 6);
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(8, 365);
            this.txtLog.Margin = new System.Windows.Forms.Padding(8);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.txtLog, 2);
            this.txtLog.Size = new System.Drawing.Size(1066, 187);
            this.txtLog.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(363, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "CSV File To DB";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(153)))));
            this.label6.Location = new System.Drawing.Point(900, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "교신상세정보";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(153)))));
            this.label5.Location = new System.Drawing.Point(720, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "교신현황";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(540, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "시설사용현황";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(360, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "위험물반입신고현황";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(180, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "선박 입출항 정보";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(136)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(0, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "선박제원정보";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbx_VHF_DETAIL
            // 
            this.lbx_VHF_DETAIL.BackColor = System.Drawing.Color.White;
            this.lbx_VHF_DETAIL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_VHF_DETAIL.ForeColor = System.Drawing.Color.Black;
            this.lbx_VHF_DETAIL.FormattingEnabled = true;
            this.lbx_VHF_DETAIL.ItemHeight = 12;
            this.lbx_VHF_DETAIL.Location = new System.Drawing.Point(903, 68);
            this.lbx_VHF_DETAIL.Name = "lbx_VHF_DETAIL";
            this.lbx_VHF_DETAIL.ScrollAlwaysVisible = true;
            this.lbx_VHF_DETAIL.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbx_VHF_DETAIL.Size = new System.Drawing.Size(176, 176);
            this.lbx_VHF_DETAIL.TabIndex = 13;
            // 
            // lbx_VHF
            // 
            this.lbx_VHF.BackColor = System.Drawing.Color.White;
            this.lbx_VHF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_VHF.ForeColor = System.Drawing.Color.Black;
            this.lbx_VHF.FormattingEnabled = true;
            this.lbx_VHF.ItemHeight = 12;
            this.lbx_VHF.Location = new System.Drawing.Point(723, 68);
            this.lbx_VHF.Name = "lbx_VHF";
            this.lbx_VHF.ScrollAlwaysVisible = true;
            this.lbx_VHF.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbx_VHF.Size = new System.Drawing.Size(174, 176);
            this.lbx_VHF.TabIndex = 12;
            // 
            // lbx_FU
            // 
            this.lbx_FU.BackColor = System.Drawing.Color.White;
            this.lbx_FU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_FU.ForeColor = System.Drawing.Color.Black;
            this.lbx_FU.FormattingEnabled = true;
            this.lbx_FU.ItemHeight = 12;
            this.lbx_FU.Location = new System.Drawing.Point(543, 68);
            this.lbx_FU.Name = "lbx_FU";
            this.lbx_FU.ScrollAlwaysVisible = true;
            this.lbx_FU.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbx_FU.Size = new System.Drawing.Size(174, 176);
            this.lbx_FU.TabIndex = 11;
            // 
            // lbx_DC
            // 
            this.lbx_DC.BackColor = System.Drawing.Color.White;
            this.lbx_DC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_DC.ForeColor = System.Drawing.Color.Black;
            this.lbx_DC.FormattingEnabled = true;
            this.lbx_DC.ItemHeight = 12;
            this.lbx_DC.Location = new System.Drawing.Point(363, 68);
            this.lbx_DC.Name = "lbx_DC";
            this.lbx_DC.ScrollAlwaysVisible = true;
            this.lbx_DC.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbx_DC.Size = new System.Drawing.Size(174, 176);
            this.lbx_DC.TabIndex = 10;
            // 
            // lbx_PIO
            // 
            this.lbx_PIO.BackColor = System.Drawing.Color.White;
            this.lbx_PIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_PIO.ForeColor = System.Drawing.Color.Black;
            this.lbx_PIO.FormattingEnabled = true;
            this.lbx_PIO.ItemHeight = 12;
            this.lbx_PIO.Location = new System.Drawing.Point(183, 68);
            this.lbx_PIO.Name = "lbx_PIO";
            this.lbx_PIO.ScrollAlwaysVisible = true;
            this.lbx_PIO.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbx_PIO.Size = new System.Drawing.Size(174, 176);
            this.lbx_PIO.TabIndex = 9;
            // 
            // lbx_SI
            // 
            this.lbx_SI.BackColor = System.Drawing.Color.White;
            this.lbx_SI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_SI.ForeColor = System.Drawing.Color.Black;
            this.lbx_SI.FormattingEnabled = true;
            this.lbx_SI.ItemHeight = 12;
            this.lbx_SI.Location = new System.Drawing.Point(3, 68);
            this.lbx_SI.Name = "lbx_SI";
            this.lbx_SI.ScrollAlwaysVisible = true;
            this.lbx_SI.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbx_SI.Size = new System.Drawing.Size(174, 176);
            this.lbx_SI.TabIndex = 8;
            // 
            // lbl_RootFolder
            // 
            this.lbl_RootFolder.AutoSize = true;
            this.lbl_RootFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_RootFolder, 4);
            this.lbl_RootFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_RootFolder.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RootFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(117)))), ((int)(((byte)(139)))));
            this.lbl_RootFolder.Location = new System.Drawing.Point(180, 0);
            this.lbl_RootFolder.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_RootFolder.Name = "lbl_RootFolder";
            this.lbl_RootFolder.Size = new System.Drawing.Size(720, 35);
            this.lbl_RootFolder.TabIndex = 7;
            this.lbl_RootFolder.Text = "경로";
            this.lbl_RootFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(235)))), ((int)(((byte)(204)))));
            this.btnSelectFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFolder.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSelectFolder.ForeColor = System.Drawing.Color.White;
            this.btnSelectFolder.Location = new System.Drawing.Point(900, 0);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(182, 35);
            this.btnSelectFolder.TabIndex = 6;
            this.btnSelectFolder.Text = "Setting";
            this.btnSelectFolder.UseVisualStyleBackColor = false;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_RootFolder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbx_FU, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbx_DC, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbx_PIO, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbx_SI, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbx_VHF, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbx_VHF_DETAIL, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtLog, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFLCount, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFIOCount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDCCount, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFUCount, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblVHFCount, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblVHFDetailCount, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectFolder, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 560);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.tableLayoutPanel1.SetColumnSpan(this.label7, 6);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(27)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(0, 327);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1082, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "System Log";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFLCount
            // 
            this.lblFLCount.AutoSize = true;
            this.lblFLCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFLCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(181)))), ((int)(((byte)(243)))));
            this.lblFLCount.Location = new System.Drawing.Point(3, 247);
            this.lblFLCount.Name = "lblFLCount";
            this.lblFLCount.Size = new System.Drawing.Size(174, 30);
            this.lblFLCount.TabIndex = 14;
            this.lblFLCount.Text = "0 건";
            this.lblFLCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFIOCount
            // 
            this.lblFIOCount.AutoSize = true;
            this.lblFIOCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFIOCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(181)))), ((int)(((byte)(243)))));
            this.lblFIOCount.Location = new System.Drawing.Point(183, 247);
            this.lblFIOCount.Name = "lblFIOCount";
            this.lblFIOCount.Size = new System.Drawing.Size(174, 30);
            this.lblFIOCount.TabIndex = 14;
            this.lblFIOCount.Text = "0 건";
            this.lblFIOCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDCCount
            // 
            this.lblDCCount.AutoSize = true;
            this.lblDCCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDCCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(181)))), ((int)(((byte)(243)))));
            this.lblDCCount.Location = new System.Drawing.Point(363, 247);
            this.lblDCCount.Name = "lblDCCount";
            this.lblDCCount.Size = new System.Drawing.Size(174, 30);
            this.lblDCCount.TabIndex = 14;
            this.lblDCCount.Text = "0 건";
            this.lblDCCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFUCount
            // 
            this.lblFUCount.AutoSize = true;
            this.lblFUCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFUCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(181)))), ((int)(((byte)(243)))));
            this.lblFUCount.Location = new System.Drawing.Point(543, 247);
            this.lblFUCount.Name = "lblFUCount";
            this.lblFUCount.Size = new System.Drawing.Size(174, 30);
            this.lblFUCount.TabIndex = 14;
            this.lblFUCount.Text = "0 건";
            this.lblFUCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVHFCount
            // 
            this.lblVHFCount.AutoSize = true;
            this.lblVHFCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVHFCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(181)))), ((int)(((byte)(243)))));
            this.lblVHFCount.Location = new System.Drawing.Point(723, 247);
            this.lblVHFCount.Name = "lblVHFCount";
            this.lblVHFCount.Size = new System.Drawing.Size(174, 30);
            this.lblVHFCount.TabIndex = 14;
            this.lblVHFCount.Text = "0 건";
            this.lblVHFCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVHFDetailCount
            // 
            this.lblVHFDetailCount.AutoSize = true;
            this.lblVHFDetailCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVHFDetailCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(181)))), ((int)(((byte)(243)))));
            this.lblVHFDetailCount.Location = new System.Drawing.Point(903, 247);
            this.lblVHFDetailCount.Name = "lblVHFDetailCount";
            this.lblVHFDetailCount.Size = new System.Drawing.Size(176, 30);
            this.lblVHFDetailCount.TabIndex = 14;
            this.lblVHFDetailCount.Text = "0 건";
            this.lblVHFDetailCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(27)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 35);
            this.label8.TabIndex = 14;
            this.label8.Text = "Root Folder";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 597);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gC_Form1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "포트미스 데이터 DB 동기화";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private GCControls.GC_Form gC_Form1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label lbl_RootFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbx_FU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbx_DC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbx_PIO;
        private System.Windows.Forms.ListBox lbx_SI;
        private System.Windows.Forms.ListBox lbx_VHF;
        private System.Windows.Forms.ListBox lbx_VHF_DETAIL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFLCount;
        private System.Windows.Forms.Label lblFIOCount;
        private System.Windows.Forms.Label lblDCCount;
        private System.Windows.Forms.Label lblFUCount;
        private System.Windows.Forms.Label lblVHFCount;
        private System.Windows.Forms.Label lblVHFDetailCount;
        private System.Windows.Forms.Label label8;
    }
}

