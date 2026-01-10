namespace Vsql
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            DataTableGrid = new DataGridView();
            ConnectionStringBox = new TextBox();
            GetTableBtn = new Button();
            ConnectInit = new Button();
            QueryInputBox = new TextBox();
            InitDisconnect = new Button();
            tabPage2 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            PgHost = new TextBox();
            PgDb = new TextBox();
            PgUser = new TextBox();
            PgPassword = new TextBox();
            PgPort = new TextBox();
            ConnectToPg = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataTableGrid).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1034, 641);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DataTableGrid);
            tabPage1.Controls.Add(ConnectionStringBox);
            tabPage1.Controls.Add(GetTableBtn);
            tabPage1.Controls.Add(ConnectInit);
            tabPage1.Controls.Add(QueryInputBox);
            tabPage1.Controls.Add(InitDisconnect);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1026, 613);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DataTableGrid
            // 
            DataTableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTableGrid.Location = new Point(22, 138);
            DataTableGrid.Name = "DataTableGrid";
            DataTableGrid.Size = new Size(390, 242);
            DataTableGrid.TabIndex = 9;
            // 
            // ConnectionStringBox
            // 
            ConnectionStringBox.Location = new Point(22, 37);
            ConnectionStringBox.Name = "ConnectionStringBox";
            ConnectionStringBox.Size = new Size(881, 23);
            ConnectionStringBox.TabIndex = 6;
            // 
            // GetTableBtn
            // 
            GetTableBtn.Location = new Point(411, 109);
            GetTableBtn.Name = "GetTableBtn";
            GetTableBtn.Size = new Size(75, 23);
            GetTableBtn.TabIndex = 10;
            GetTableBtn.Text = "get table";
            GetTableBtn.UseVisualStyleBackColor = true;
            // 
            // ConnectInit
            // 
            ConnectInit.Location = new Point(926, 37);
            ConnectInit.Name = "ConnectInit";
            ConnectInit.Size = new Size(75, 23);
            ConnectInit.TabIndex = 7;
            ConnectInit.Text = "Connect";
            ConnectInit.TextAlign = ContentAlignment.BottomCenter;
            ConnectInit.UseVisualStyleBackColor = true;
            // 
            // QueryInputBox
            // 
            QueryInputBox.Location = new Point(22, 109);
            QueryInputBox.Name = "QueryInputBox";
            QueryInputBox.Size = new Size(383, 23);
            QueryInputBox.TabIndex = 11;
            // 
            // InitDisconnect
            // 
            InitDisconnect.Location = new Point(926, 66);
            InitDisconnect.Name = "InitDisconnect";
            InitDisconnect.Size = new Size(75, 23);
            InitDisconnect.TabIndex = 8;
            InitDisconnect.Text = "Disconnect";
            InitDisconnect.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ConnectToPg);
            tabPage2.Controls.Add(PgPort);
            tabPage2.Controls.Add(PgPassword);
            tabPage2.Controls.Add(PgUser);
            tabPage2.Controls.Add(PgDb);
            tabPage2.Controls.Add(PgHost);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1026, 613);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 28);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Host:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 62);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Database:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 96);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "User: ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 135);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 172);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "Port:";
            // 
            // PgHost
            // 
            PgHost.Location = new Point(67, 28);
            PgHost.Name = "PgHost";
            PgHost.Size = new Size(145, 23);
            PgHost.TabIndex = 5;
            // 
            // PgDb
            // 
            PgDb.Location = new Point(67, 62);
            PgDb.Name = "PgDb";
            PgDb.Size = new Size(145, 23);
            PgDb.TabIndex = 6;
            // 
            // PgUser
            // 
            PgUser.Location = new Point(67, 96);
            PgUser.Name = "PgUser";
            PgUser.Size = new Size(145, 23);
            PgUser.TabIndex = 7;
            // 
            // PgPassword
            // 
            PgPassword.Location = new Point(67, 132);
            PgPassword.Name = "PgPassword";
            PgPassword.Size = new Size(145, 23);
            PgPassword.TabIndex = 8;
            // 
            // PgPort
            // 
            PgPort.Location = new Point(67, 172);
            PgPort.Name = "PgPort";
            PgPort.Size = new Size(145, 23);
            PgPort.TabIndex = 9;
            // 
            // ConnectToPg
            // 
            ConnectToPg.Location = new Point(251, 28);
            ConnectToPg.Name = "ConnectToPg";
            ConnectToPg.Size = new Size(88, 23);
            ConnectToPg.TabIndex = 10;
            ConnectToPg.Text = "Connect";
            ConnectToPg.UseVisualStyleBackColor = true;
            ConnectToPg.Click += ConnectToPg_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 641);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataTableGrid).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView DataTableGrid;
        private TextBox ConnectionStringBox;
        private Button GetTableBtn;
        private Button ConnectInit;
        private TextBox QueryInputBox;
        private Button InitDisconnect;
        private TabPage tabPage2;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox PgPort;
        private TextBox PgPassword;
        private TextBox PgUser;
        private TextBox PgDb;
        private TextBox PgHost;
        private Label label5;
        private Label label4;
        private Button ConnectToPg;
    }
}
