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
            ConnectionStringBox = new TextBox();
            ConnectInit = new Button();
            InitDisconnect = new Button();
            DataTableGrid = new DataGridView();
            GetTableBtn = new Button();
            QueryInputBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataTableGrid).BeginInit();
            SuspendLayout();
            // 
            // ConnectionStringBox
            // 
            ConnectionStringBox.Location = new Point(39, 52);
            ConnectionStringBox.Name = "ConnectionStringBox";
            ConnectionStringBox.Size = new Size(881, 23);
            ConnectionStringBox.TabIndex = 0;
            // 
            // ConnectInit
            // 
            ConnectInit.Location = new Point(941, 53);
            ConnectInit.Name = "ConnectInit";
            ConnectInit.Size = new Size(75, 23);
            ConnectInit.TabIndex = 1;
            ConnectInit.Text = "Connect";
            ConnectInit.TextAlign = ContentAlignment.BottomCenter;
            ConnectInit.UseVisualStyleBackColor = true;
            ConnectInit.Click += ConnectInit_Click;
            // 
            // InitDisconnect
            // 
            InitDisconnect.Location = new Point(943, 85);
            InitDisconnect.Name = "InitDisconnect";
            InitDisconnect.Size = new Size(75, 23);
            InitDisconnect.TabIndex = 2;
            InitDisconnect.Text = "Disconnect";
            InitDisconnect.UseVisualStyleBackColor = true;
            InitDisconnect.Click += InitDisconnect_Click;
            // 
            // DataTableGrid
            // 
            DataTableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTableGrid.Location = new Point(39, 144);
            DataTableGrid.Name = "DataTableGrid";
            DataTableGrid.Size = new Size(390, 242);
            DataTableGrid.TabIndex = 3;
            // 
            // GetTableBtn
            // 
            GetTableBtn.Location = new Point(428, 115);
            GetTableBtn.Name = "GetTableBtn";
            GetTableBtn.Size = new Size(75, 23);
            GetTableBtn.TabIndex = 4;
            GetTableBtn.Text = "get table";
            GetTableBtn.UseVisualStyleBackColor = true;
            GetTableBtn.Click += GetTableBtn_Click;
            // 
            // QueryInputBox
            // 
            QueryInputBox.Location = new Point(39, 115);
            QueryInputBox.Name = "QueryInputBox";
            QueryInputBox.Size = new Size(383, 23);
            QueryInputBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 641);
            Controls.Add(QueryInputBox);
            Controls.Add(GetTableBtn);
            Controls.Add(DataTableGrid);
            Controls.Add(InitDisconnect);
            Controls.Add(ConnectInit);
            Controls.Add(ConnectionStringBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataTableGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ConnectionStringBox;
        private Button ConnectInit;
        private Button InitDisconnect;
        private DataGridView DataTableGrid;
        private Button GetTableBtn;
        private TextBox QueryInputBox;
    }
}
