namespace SpecialLibrary.Views.Dialogs
{
    partial class AddNewUserForm
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
            AddUserButton = new Button();
            label1 = new Label();
            FioTB = new TextBox();
            SuspendLayout();
            // 
            // AddUserButton
            // 
            AddUserButton.Location = new Point(115, 60);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new Size(75, 23);
            AddUserButton.TabIndex = 0;
            AddUserButton.Text = "Добавить";
            AddUserButton.UseVisualStyleBackColor = true;
            AddUserButton.Click += AddUserButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "ФИО";
            // 
            // FioTB
            // 
            FioTB.Location = new Point(52, 29);
            FioTB.Name = "FioTB";
            FioTB.Size = new Size(232, 23);
            FioTB.TabIndex = 2;
            // 
            // AddNewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 95);
            Controls.Add(FioTB);
            Controls.Add(label1);
            Controls.Add(AddUserButton);
            Name = "AddNewUserForm";
            Text = "AddNewUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddUserButton;
        private Label label1;
        private TextBox FioTB;
    }
}