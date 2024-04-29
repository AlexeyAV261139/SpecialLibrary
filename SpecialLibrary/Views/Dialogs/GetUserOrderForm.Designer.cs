namespace SpecialLibrary.Views.Dialogs
{
    partial class GetUserOrderForm
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
            UsersLB = new ListBox();
            OrdersLB = new ListBox();
            label1 = new Label();
            label2 = new Label();
            ConfirmButton = new Button();
            SuspendLayout();
            // 
            // UsersLB
            // 
            UsersLB.FormattingEnabled = true;
            UsersLB.ItemHeight = 15;
            UsersLB.Location = new Point(12, 27);
            UsersLB.Name = "UsersLB";
            UsersLB.Size = new Size(196, 139);
            UsersLB.TabIndex = 0;
            // 
            // OrdersLB
            // 
            OrdersLB.FormattingEnabled = true;
            OrdersLB.ItemHeight = 15;
            OrdersLB.Location = new Point(214, 27);
            OrdersLB.Name = "OrdersLB";
            OrdersLB.Size = new Size(196, 139);
            OrdersLB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Кому";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 9);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 3;
            label2.Text = "Что";
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(335, 172);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(75, 23);
            ConfirmButton.TabIndex = 4;
            ConfirmButton.Text = "Выдать";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // GetUserOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 203);
            Controls.Add(ConfirmButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OrdersLB);
            Controls.Add(UsersLB);
            Name = "GetUserOrderForm";
            Text = "GetUserOrderForm";
            Load += GetUserOrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox UsersLB;
        private ListBox OrdersLB;
        private Label label1;
        private Label label2;
        private Button ConfirmButton;
    }
}