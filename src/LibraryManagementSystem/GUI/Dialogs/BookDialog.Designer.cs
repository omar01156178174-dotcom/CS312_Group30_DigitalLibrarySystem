using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI.Dialogs;

partial class BookDialog
{
    private System.ComponentModel.IContainer? components;
    private System.Windows.Forms.TableLayoutPanel rootLayout = null!;
    private System.Windows.Forms.TableLayoutPanel formLayout = null!;
    private System.Windows.Forms.Panel headerPanel = null!;
    private System.Windows.Forms.Label headerTitle = null!;
    private System.Windows.Forms.Label headerSubtitle = null!;
    private System.Windows.Forms.Panel contentPanel = null!;
    private System.Windows.Forms.Panel footerPanel = null!;
    private System.Windows.Forms.Label lblTitle = null!;
    private System.Windows.Forms.Label lblAuthor = null!;
    private System.Windows.Forms.Label lblISBN = null!;
    private System.Windows.Forms.Label lblCategory = null!;
    private System.Windows.Forms.Label lblYear = null!;
    private System.Windows.Forms.Label lblTotal = null!;
    private System.Windows.Forms.Label lblAvailable = null!;
    private System.Windows.Forms.Label lblRack = null!;
    private System.Windows.Forms.Label lblDescription = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        errorProvider = new ErrorProvider(components);
        rootLayout = new TableLayoutPanel();
        headerPanel = new Panel();
        headerTitle = new Label();
        headerSubtitle = new Label();
        contentPanel = new Panel();
        formLayout = new TableLayoutPanel();
        lblTitle = new Label();
        lblAuthor = new Label();
        lblISBN = new Label();
        lblCategory = new Label();
        lblYear = new Label();
        lblTotal = new Label();
        lblAvailable = new Label();
        lblRack = new Label();
        lblDescription = new Label();
        txtTitle = new TextBox();
        txtAuthor = new TextBox();
        txtISBN = new TextBox();
        cmbCategory = new ComboBox();
        numYear = new NumericUpDown();
        numTotalCopies = new NumericUpDown();
        numAvailableCopies = new NumericUpDown();
        txtLocation = new TextBox();
        txtDescription = new TextBox();
        footerPanel = new Panel();
        actionButtons = new FlowLayoutPanel();
        btnCancel = new Button();
        btnSave = new Button();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        rootLayout.SuspendLayout();
        headerPanel.SuspendLayout();
        contentPanel.SuspendLayout();
        formLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numTotalCopies).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numAvailableCopies).BeginInit();
        footerPanel.SuspendLayout();
        actionButtons.SuspendLayout();
        SuspendLayout();
        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;
        // 
        // rootLayout
        // 
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(headerPanel, 0, 0);
        rootLayout.Controls.Add(contentPanel, 0, 1);
        rootLayout.Controls.Add(footerPanel, 0, 2);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.Location = new Point(0, 0);
        rootLayout.Name = "rootLayout";
        rootLayout.RowCount = 3;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
        rootLayout.Size = new Size(704, 641);
        rootLayout.TabIndex = 0;
        // 
        // headerPanel
        // 
        headerPanel.BackColor = Color.White;
        headerPanel.Controls.Add(headerTitle);
        headerPanel.Controls.Add(headerSubtitle);
        headerPanel.Dock = DockStyle.Fill;
        headerPanel.Location = new Point(3, 3);
        headerPanel.Name = "headerPanel";
        headerPanel.Padding = new Padding(22, 12, 22, 8);
        headerPanel.Size = new Size(698, 104);
        headerPanel.TabIndex = 0;
        // 
        // headerTitle
        // 
        headerTitle.AutoSize = true;
        headerTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        headerTitle.ForeColor = Color.FromArgb(15, 23, 42);
        headerTitle.Location = new Point(23, 19);
        headerTitle.Name = "headerTitle";
        headerTitle.Size = new Size(266, 38);
        headerTitle.TabIndex = 0;
        headerTitle.Text = "Register New Book";
        // 
        // headerSubtitle
        // 
        headerSubtitle.AutoSize = true;
        headerSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
        headerSubtitle.Location = new Point(23, 61);
        headerSubtitle.Name = "headerSubtitle";
        headerSubtitle.Size = new Size(356, 25);
        headerSubtitle.TabIndex = 1;
        headerSubtitle.Text = "Enter book information and stock details.";
        // 
        // contentPanel
        // 
        contentPanel.AutoScroll = true;
        contentPanel.Controls.Add(formLayout);
        contentPanel.Dock = DockStyle.Fill;
        contentPanel.Location = new Point(3, 113);
        contentPanel.Name = "contentPanel";
        contentPanel.Padding = new Padding(24, 12, 24, 12);
        contentPanel.Size = new Size(698, 450);
        contentPanel.TabIndex = 1;
        // 
        // formLayout
        // 
        formLayout.AutoSize = true;
        formLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        formLayout.ColumnCount = 2;
        formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 168F));
        formLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        formLayout.Controls.Add(lblTitle, 0, 0);
        formLayout.Controls.Add(lblAuthor, 0, 1);
        formLayout.Controls.Add(lblISBN, 0, 2);
        formLayout.Controls.Add(lblCategory, 0, 3);
        formLayout.Controls.Add(lblYear, 0, 4);
        formLayout.Controls.Add(lblTotal, 0, 5);
        formLayout.Controls.Add(lblAvailable, 0, 6);
        formLayout.Controls.Add(lblRack, 0, 7);
        formLayout.Controls.Add(lblDescription, 0, 8);
        formLayout.Controls.Add(txtTitle, 1, 0);
        formLayout.Controls.Add(txtAuthor, 1, 1);
        formLayout.Controls.Add(txtISBN, 1, 2);
        formLayout.Controls.Add(cmbCategory, 1, 3);
        formLayout.Controls.Add(numYear, 1, 4);
        formLayout.Controls.Add(numTotalCopies, 1, 5);
        formLayout.Controls.Add(numAvailableCopies, 1, 6);
        formLayout.Controls.Add(txtLocation, 1, 7);
        formLayout.Controls.Add(txtDescription, 1, 8);
        formLayout.Dock = DockStyle.Top;
        formLayout.Location = new Point(24, 12);
        formLayout.Name = "formLayout";
        formLayout.RowCount = 9;
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        formLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
        formLayout.Size = new Size(650, 405);
        formLayout.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Location = new Point(0, 10);
        lblTitle.Margin = new Padding(0, 10, 8, 10);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(65, 25);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Title *:";
        // 
        // lblAuthor
        // 
        lblAuthor.AutoSize = true;
        lblAuthor.Location = new Point(0, 55);
        lblAuthor.Margin = new Padding(0, 10, 8, 10);
        lblAuthor.Name = "lblAuthor";
        lblAuthor.Size = new Size(87, 25);
        lblAuthor.TabIndex = 1;
        lblAuthor.Text = "Author *:";
        // 
        // lblISBN
        // 
        lblISBN.AutoSize = true;
        lblISBN.Location = new Point(0, 100);
        lblISBN.Margin = new Padding(0, 10, 8, 10);
        lblISBN.Name = "lblISBN";
        lblISBN.Size = new Size(146, 25);
        lblISBN.TabIndex = 2;
        lblISBN.Text = "ISBN (Optional):";
        // 
        // lblCategory
        // 
        lblCategory.AutoSize = true;
        lblCategory.Location = new Point(0, 145);
        lblCategory.Margin = new Padding(0, 10, 8, 10);
        lblCategory.Name = "lblCategory";
        lblCategory.Size = new Size(105, 25);
        lblCategory.TabIndex = 3;
        lblCategory.Text = "Category *:";
        // 
        // lblYear
        // 
        lblYear.AutoSize = true;
        lblYear.Location = new Point(0, 190);
        lblYear.Margin = new Padding(0, 10, 8, 10);
        lblYear.Name = "lblYear";
        lblYear.Size = new Size(94, 25);
        lblYear.TabIndex = 4;
        lblYear.Text = "Pub. Year:";
        // 
        // lblTotal
        // 
        lblTotal.AutoSize = true;
        lblTotal.Location = new Point(0, 235);
        lblTotal.Margin = new Padding(0, 10, 8, 10);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(131, 25);
        lblTotal.TabIndex = 5;
        lblTotal.Text = "Total Copies *:";
        // 
        // lblAvailable
        // 
        lblAvailable.AutoSize = true;
        lblAvailable.Location = new Point(0, 280);
        lblAvailable.Margin = new Padding(0, 10, 8, 10);
        lblAvailable.Name = "lblAvailable";
        lblAvailable.Size = new Size(93, 25);
        lblAvailable.TabIndex = 6;
        lblAvailable.Text = "Available:";
        // 
        // lblRack
        // 
        lblRack.AutoSize = true;
        lblRack.Location = new Point(0, 325);
        lblRack.Margin = new Padding(0, 10, 8, 10);
        lblRack.Name = "lblRack";
        lblRack.Size = new Size(114, 25);
        lblRack.TabIndex = 7;
        lblRack.Text = "Shelf / Rack:";
        // 
        // lblDescription
        // 
        lblDescription.AutoSize = true;
        lblDescription.Location = new Point(0, 370);
        lblDescription.Margin = new Padding(0, 10, 8, 10);
        lblDescription.Name = "lblDescription";
        lblDescription.Size = new Size(112, 25);
        lblDescription.TabIndex = 8;
        lblDescription.Text = "Description:";
        // 
        // txtTitle
        // 
        txtTitle.Dock = DockStyle.Fill;
        txtTitle.Location = new Point(168, 5);
        txtTitle.Margin = new Padding(0, 5, 5, 9);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(477, 32);
        txtTitle.TabIndex = 9;
        // 
        // txtAuthor
        // 
        txtAuthor.Dock = DockStyle.Fill;
        txtAuthor.Location = new Point(168, 50);
        txtAuthor.Margin = new Padding(0, 5, 5, 9);
        txtAuthor.Name = "txtAuthor";
        txtAuthor.Size = new Size(477, 32);
        txtAuthor.TabIndex = 10;
        // 
        // txtISBN
        // 
        txtISBN.Dock = DockStyle.Fill;
        txtISBN.Location = new Point(168, 95);
        txtISBN.Margin = new Padding(0, 5, 5, 9);
        txtISBN.Name = "txtISBN";
        txtISBN.Size = new Size(477, 32);
        txtISBN.TabIndex = 11;
        // 
        // cmbCategory
        // 
        cmbCategory.Dock = DockStyle.Fill;
        cmbCategory.Items.AddRange(new object[] { "Computer Science", "Artificial Intelligence", "Software Engineering", "Programming", "Mathematics", "Science", "Literature", "History", "Philosophy", "General" });
        cmbCategory.Location = new Point(168, 140);
        cmbCategory.Margin = new Padding(0, 5, 5, 9);
        cmbCategory.Name = "cmbCategory";
        cmbCategory.Size = new Size(477, 33);
        cmbCategory.TabIndex = 12;
        // 
        // numYear
        // 
        numYear.Location = new Point(168, 185);
        numYear.Margin = new Padding(0, 5, 5, 9);
        numYear.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
        numYear.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
        numYear.Name = "numYear";
        numYear.Size = new Size(125, 32);
        numYear.TabIndex = 13;
        numYear.Value = new decimal(new int[] { 2026, 0, 0, 0 });
        // 
        // numTotalCopies
        // 
        numTotalCopies.Location = new Point(168, 230);
        numTotalCopies.Margin = new Padding(0, 5, 5, 9);
        numTotalCopies.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        numTotalCopies.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numTotalCopies.Name = "numTotalCopies";
        numTotalCopies.Size = new Size(125, 32);
        numTotalCopies.TabIndex = 14;
        numTotalCopies.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // numAvailableCopies
        // 
        numAvailableCopies.Location = new Point(168, 275);
        numAvailableCopies.Margin = new Padding(0, 5, 5, 9);
        numAvailableCopies.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        numAvailableCopies.Name = "numAvailableCopies";
        numAvailableCopies.Size = new Size(125, 32);
        numAvailableCopies.TabIndex = 15;
        numAvailableCopies.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // txtLocation
        // 
        txtLocation.Dock = DockStyle.Fill;
        txtLocation.Location = new Point(168, 320);
        txtLocation.Margin = new Padding(0, 5, 5, 9);
        txtLocation.Name = "txtLocation";
        txtLocation.Size = new Size(477, 32);
        txtLocation.TabIndex = 16;
        // 
        // txtDescription
        // 
        txtDescription.Dock = DockStyle.Fill;
        txtDescription.Location = new Point(168, 365);
        txtDescription.Margin = new Padding(0, 5, 5, 9);
        txtDescription.MinimumSize = new Size(0, 80);
        txtDescription.Multiline = true;
        txtDescription.Name = "txtDescription";
        txtDescription.ScrollBars = ScrollBars.Vertical;
        txtDescription.Size = new Size(477, 80);
        txtDescription.TabIndex = 17;
        // 
        // footerPanel
        // 
        footerPanel.BackColor = Color.White;
        footerPanel.Controls.Add(actionButtons);
        footerPanel.Dock = DockStyle.Fill;
        footerPanel.Location = new Point(3, 569);
        footerPanel.Name = "footerPanel";
        footerPanel.Padding = new Padding(16, 12, 24, 10);
        footerPanel.Size = new Size(698, 69);
        footerPanel.TabIndex = 2;
        // 
        // actionButtons
        // 
        actionButtons.Controls.Add(btnCancel);
        actionButtons.Controls.Add(btnSave);
        actionButtons.Location = new Point(0, 0);
        actionButtons.Name = "actionButtons";
        actionButtons.Size = new Size(200, 100);
        actionButtons.TabIndex = 0;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCancel.BackColor = Color.FromArgb(241, 245, 249);
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.Location = new Point(0, 0);
        btnCancel.Margin = new Padding(0);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(110, 40);
        btnCancel.TabIndex = 0;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = false;
        // 
        // btnSave
        // 
        btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnSave.BackColor = Color.FromArgb(99, 102, 241);
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(4, 40);
        btnSave.Margin = new Padding(4, 0, 0, 0);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(135, 40);
        btnSave.TabIndex = 1;
        btnSave.Text = "Add Book";
        btnSave.UseVisualStyleBackColor = false;
        // 
        // BookDialog
        // 
        AcceptButton = btnSave;
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(248, 250, 252);
        CancelButton = btnCancel;
        ClientSize = new Size(704, 641);
        Controls.Add(rootLayout);
        Font = new Font("Segoe UI", 9.25F);
        MaximizeBox = false;
        MinimizeBox = false;
        MinimumSize = new Size(640, 580);
        Name = "BookDialog";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Book Details";
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        rootLayout.ResumeLayout(false);
        headerPanel.ResumeLayout(false);
        headerPanel.PerformLayout();
        contentPanel.ResumeLayout(false);
        contentPanel.PerformLayout();
        formLayout.ResumeLayout(false);
        formLayout.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
        ((System.ComponentModel.ISupportInitialize)numTotalCopies).EndInit();
        ((System.ComponentModel.ISupportInitialize)numAvailableCopies).EndInit();
        footerPanel.ResumeLayout(false);
        actionButtons.ResumeLayout(false);
        ResumeLayout(false);
    }

    private FlowLayoutPanel actionButtons;
}
