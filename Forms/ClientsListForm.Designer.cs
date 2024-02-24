namespace Accounting.Forms;
using Accounting;
partial class ClientsListForm
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
        clientsListBox = new ListBox();
        addClientButton = new Button();
        SuspendLayout();
        // 
        // clientsListBox
        // 
        clientsListBox.FormattingEnabled = true;
        clientsListBox.Location = new Point(12, 12);
        clientsListBox.Name = "clientsListBox";
        clientsListBox.Size = new Size(265, 324);
        clientsListBox.TabIndex = 0;
        clientsListBox.DoubleClick += OnListBoxDoubleClick;
        // 
        // addClientButton
        // 
        addClientButton.Location = new Point(12, 347);
        addClientButton.Name = "addClientButton";
        addClientButton.Size = new Size(265, 29);
        addClientButton.TabIndex = 1;
        addClientButton.Text = "Add client";
        addClientButton.UseVisualStyleBackColor = true;
        addClientButton.Click += addClientButton_Click;
        // 
        // ClientsListForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(289, 388);
        Controls.Add(addClientButton);
        Controls.Add(clientsListBox);
        Name = "ClientsListForm";
        Text = "Clients";
        Load += OnFormLoaded;
        ResumeLayout(false);
    }

    #endregion

    private ListBox clientsListBox;
    private Button addClientButton;
}
