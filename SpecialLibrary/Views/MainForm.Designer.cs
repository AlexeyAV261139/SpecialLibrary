namespace SpecialLibrary.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OrdersDGV = new DataGridView();
            SearchOrderButton = new Button();
            SearchTB = new TextBox();
            TargetPropertyCB = new ComboBox();
            LibraryWorkersDGV = new DataGridView();
            GetOrderInfoDocButton = new Button();
            GetUsersDocButton = new Button();
            AddNewUserButton = new Button();
            GetUserOrderButton = new Button();
            GetOrderBackButton = new Button();
            ResetOrdersDGVButton = new Button();
            ((System.ComponentModel.ISupportInitialize)OrdersDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LibraryWorkersDGV).BeginInit();
            SuspendLayout();
            // 
            // OrdersDGV
            // 
            OrdersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDGV.Location = new Point(12, 41);
            OrdersDGV.Name = "OrdersDGV";
            OrdersDGV.RowTemplate.Height = 25;
            OrdersDGV.Size = new Size(776, 150);
            OrdersDGV.TabIndex = 0;
            // 
            // SearchOrderButton
            // 
            SearchOrderButton.Location = new Point(632, 12);
            SearchOrderButton.Name = "SearchOrderButton";
            SearchOrderButton.Size = new Size(75, 23);
            SearchOrderButton.TabIndex = 1;
            SearchOrderButton.Text = "Поиск";
            SearchOrderButton.UseVisualStyleBackColor = true;
            SearchOrderButton.Click += SearchOrderButton_Click;
            // 
            // SearchTB
            // 
            SearchTB.Location = new Point(12, 12);
            SearchTB.Name = "SearchTB";
            SearchTB.Size = new Size(495, 23);
            SearchTB.TabIndex = 2;
            // 
            // TargetPropertyCB
            // 
            TargetPropertyCB.FormattingEnabled = true;
            TargetPropertyCB.Location = new Point(513, 12);
            TargetPropertyCB.Name = "TargetPropertyCB";
            TargetPropertyCB.Size = new Size(113, 23);
            TargetPropertyCB.TabIndex = 3;
            // 
            // LibraryWorkersDGV
            // 
            LibraryWorkersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LibraryWorkersDGV.Location = new Point(12, 197);
            LibraryWorkersDGV.Name = "LibraryWorkersDGV";
            LibraryWorkersDGV.RowTemplate.Height = 25;
            LibraryWorkersDGV.Size = new Size(668, 197);
            LibraryWorkersDGV.TabIndex = 4;
            // 
            // GetOrderInfoDocButton
            // 
            GetOrderInfoDocButton.Location = new Point(686, 197);
            GetOrderInfoDocButton.Name = "GetOrderInfoDocButton";
            GetOrderInfoDocButton.Size = new Size(102, 38);
            GetOrderInfoDocButton.TabIndex = 5;
            GetOrderInfoDocButton.Text = "Получить отчёт о приказе";
            GetOrderInfoDocButton.UseVisualStyleBackColor = true;
            GetOrderInfoDocButton.Click += GetOrderInfoDocButton_Click;
            // 
            // GetUsersDocButton
            // 
            GetUsersDocButton.Location = new Point(686, 241);
            GetUsersDocButton.Name = "GetUsersDocButton";
            GetUsersDocButton.Size = new Size(102, 38);
            GetUsersDocButton.TabIndex = 6;
            GetUsersDocButton.Text = "Получить отчёт о должниках";
            GetUsersDocButton.UseVisualStyleBackColor = true;
            GetUsersDocButton.Click += GetUsersDocButton_Click;
            // 
            // AddNewUserButton
            // 
            AddNewUserButton.Location = new Point(686, 285);
            AddNewUserButton.Name = "AddNewUserButton";
            AddNewUserButton.Size = new Size(102, 41);
            AddNewUserButton.TabIndex = 7;
            AddNewUserButton.Text = "Новый пользователь";
            AddNewUserButton.UseVisualStyleBackColor = true;
            AddNewUserButton.Click += AddNewUserButton_Click;
            // 
            // GetUserOrderButton
            // 
            GetUserOrderButton.Location = new Point(686, 332);
            GetUserOrderButton.Name = "GetUserOrderButton";
            GetUserOrderButton.Size = new Size(102, 28);
            GetUserOrderButton.TabIndex = 8;
            GetUserOrderButton.Text = "Выдать приказ";
            GetUserOrderButton.UseVisualStyleBackColor = true;
            GetUserOrderButton.Click += GetUserOrderButton_Click;
            // 
            // GetOrderBackButton
            // 
            GetOrderBackButton.Location = new Point(686, 366);
            GetOrderBackButton.Name = "GetOrderBackButton";
            GetOrderBackButton.Size = new Size(102, 28);
            GetOrderBackButton.TabIndex = 9;
            GetOrderBackButton.Text = "Вернуть приказ";
            GetOrderBackButton.UseVisualStyleBackColor = true;
            GetOrderBackButton.Click += GetOrderBackButton_Click;
            // 
            // ResetOrdersDGVButton
            // 
            ResetOrdersDGVButton.Location = new Point(713, 12);
            ResetOrdersDGVButton.Name = "ResetOrdersDGVButton";
            ResetOrdersDGVButton.Size = new Size(75, 23);
            ResetOrdersDGVButton.TabIndex = 10;
            ResetOrdersDGVButton.Text = "Очистить";
            ResetOrdersDGVButton.UseVisualStyleBackColor = true;
            ResetOrdersDGVButton.Click += ResetOrdersDGVButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 405);
            Controls.Add(ResetOrdersDGVButton);
            Controls.Add(GetOrderBackButton);
            Controls.Add(GetUserOrderButton);
            Controls.Add(AddNewUserButton);
            Controls.Add(GetUsersDocButton);
            Controls.Add(GetOrderInfoDocButton);
            Controls.Add(LibraryWorkersDGV);
            Controls.Add(TargetPropertyCB);
            Controls.Add(SearchTB);
            Controls.Add(SearchOrderButton);
            Controls.Add(OrdersDGV);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)OrdersDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)LibraryWorkersDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView OrdersDGV;
        private Button SearchOrderButton;
        private TextBox SearchTB;
        private ComboBox TargetPropertyCB;
        private DataGridView LibraryWorkersDGV;
        private Button GetOrderInfoDocButton;
        private Button GetUsersDocButton;
        private Button AddNewUserButton;
        private Button GetUserOrderButton;
        private Button GetOrderBackButton;
        private Button ResetOrdersDGVButton;
    }
}