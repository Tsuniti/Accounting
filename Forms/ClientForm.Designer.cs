namespace Accounting.Forms
{
    partial class ClientForm
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
            surnameLabel = new Label();
            surnameTextBox = new TextBox();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            balanceTextBox = new TextBox();
            balanceLabel = new Label();
            isAdultCheckBox = new CheckBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(12, 9);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(70, 20);
            surnameLabel.TabIndex = 0;
            surnameLabel.Text = "Surname:";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(12, 32);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(355, 27);
            surnameTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 105);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(355, 27);
            nameTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 82);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // balanceTextBox
            // 
            balanceTextBox.Location = new Point(12, 184);
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.Size = new Size(355, 27);
            balanceTextBox.TabIndex = 5;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new Point(12, 161);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(64, 20);
            balanceLabel.TabIndex = 4;
            balanceLabel.Text = "Balance:";
            // 
            // isAdultCheckBox
            // 
            isAdultCheckBox.AutoSize = true;
            isAdultCheckBox.Location = new Point(12, 238);
            isAdultCheckBox.Name = "isAdultCheckBox";
            isAdultCheckBox.Size = new Size(79, 24);
            isAdultCheckBox.TabIndex = 6;
            isAdultCheckBox.Text = "Is adult";
            isAdultCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 301);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(355, 29);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 347);
            Controls.Add(saveButton);
            Controls.Add(isAdultCheckBox);
            Controls.Add(balanceTextBox);
            Controls.Add(balanceLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(surnameTextBox);
            Controls.Add(surnameLabel);
            Name = "ClientForm";
            Text = "ClientForm";
            Load += OnFormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label surnameLabel;
        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private Label nameLabel;
        private TextBox balanceTextBox;
        private Label balanceLabel;
        private CheckBox isAdultCheckBox;
        private Button saveButton;
    }
}