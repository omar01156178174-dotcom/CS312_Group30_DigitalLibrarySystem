using LibraryManagementSystem.UI.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI;

public partial class MainForm
{
    // Circulation & Loans - WinForms Designer editable controls
    private TableLayoutPanel loansPageLayout = null!;
    private Panel loansHeader = null!;
    private TableLayoutPanel loansHeaderLayout = null!;
    private TableLayoutPanel loansTopRow = null!;
    private FlowLayoutPanel loansTitleRow = null!;
    private FlowLayoutPanel loansActionRow = null!;
    private FlowLayoutPanel loansFilterRow = null!;
    private Panel loansGridPanel = null!;
    private Label lblLoansHeading = null!;
    private Label lblLoanCountBadge = null!;
    private Label lblLoansSearch = null!;
    private Label lblLoansStatus = null!;
    private DataGridView dgvLoans = null!;
    private TextBox txtLoanSearch = null!;
    private ComboBox cmbLoanStatusFilter = null!;
    private Button btnIssueLoan = null!;
    private Button btnReturnBook = null!;
    private Button btnRecalcFines = null!;
    private Button btnLoanRefresh = null!;
    private Button btnLoanExportCsv = null!;
    private Button btnLoanResetFilters = null!;

    // Reports & Analytics - Designer editable layout
    private TableLayoutPanel reportsPageLayout = null!;
    private FlowLayoutPanel reportsToolbar = null!;
    private TableLayoutPanel reportsContentLayout = null!;
    private GroupBox reportsSummaryGroup = null!;
    private GroupBox reportsTopBooksGroup = null!;
    private Button btnReportRefresh = null!;
    private Button btnReportExportTxt = null!;
    private Button btnReportViewFull = null!;
    private TextBox txtReportOutput = null!;
    private DataGridView dgvTopBooks = null!;


    // Dashboard components (design-time editable)
    private FlowLayoutPanel dashboardOverdueHeader = null!;
    private TableLayoutPanel membersTopRow = null!;
    private Panel dashboardScroll = null!;
    private TableLayoutPanel dashboardLayout = null!;
    private TableLayoutPanel dashboardCards = null!;
    private TableLayoutPanel dashboardCharts = null!;
    private TableLayoutPanel dashboardOverduePanel = null!;
    private Label lblDashboardOverdueTitle = null!;
    private StatCardControl cardBooks = null!;
    private StatCardControl cardCopies = null!;
    private StatCardControl cardMembers = null!;
    private StatCardControl cardActiveLoans = null!;
    private StatCardControl cardOverdue = null!;
    private StatCardControl cardFines = null!;
    private GdiChartControl chartCategories = null!;
    private GdiChartControl chartTrends = null!;
    private DataGridView dgvOverdueSummary = null!;
    private Label lblOverdueHeaderBadge = null!;
    private Label lblServerStatus = null!;
    private Button btnToggleServer = null!;
    private TextBox txtServerLogs = null!;
    private TextBox txtClientCommand = null!;
    private TextBox txtClientResponse = null!;
    private Button btnSendClientCommand = null!;
    private SplitContainer networkSplit = null!;
    private GroupBox networkServerGroup = null!;
    private GroupBox networkClientGroup = null!;
    private FlowLayoutPanel networkServerActions = null!;
    private TableLayoutPanel networkClientInput = null!;
    private Label lblNetworkHelp = null!;
    private Button btnClearServerLogs = null!;

    private System.ComponentModel.IContainer? components;
    // Members - editable within Windows Forms Designer
    private TableLayoutPanel membersPageLayout = null!;
    private Panel membersHeader = null!;
    private TableLayoutPanel membersHeaderLayout = null!;
    private FlowLayoutPanel membersTitleRow = null!;
    private FlowLayoutPanel membersActionRow = null!;
    private FlowLayoutPanel membersFilterRow = null!;
    private Panel membersGridPanel = null!;
    private Label lblMembersHeading = null!;
    private Label lblMemberCountBadge = null!;
    private Label lblMembersSearch = null!;
    private Label lblMembersType = null!;
    private DataGridView dgvMembers = null!;
    private TextBox txtMemberSearch = null!;
    private ComboBox cmbMemberTypeFilter = null!;
    private CheckBox chkMemberActiveOnly = null!;
    private Button btnAddMember = null!;
    private Button btnEditMember = null!;
    private Button btnDeleteMember = null!;
    private Button btnToggleMemberStatus = null!;
    private Button btnMemberRefresh = null!;
    private Button btnMemberResetFilters = null!;

    // Books Catalog - Designer-editable controls
    private TableLayoutPanel booksPageLayout = null!;
    private Panel booksHeader = null!;
    private TableLayoutPanel booksHeaderLayout = null!;
    private FlowLayoutPanel booksTitleRow = null!;
    private FlowLayoutPanel booksActionRow = null!;
    private FlowLayoutPanel booksFilterRow = null!;
    private Panel booksGridPanel = null!;
    private Label lblBooksHeading = null!;
    private Label lblBooksSearch = null!;
    private Label lblBooksCategory = null!;
    private DataGridView dgvBooks = null!;
    private TextBox txtBookSearch = null!;
    private ComboBox cmbBookCategoryFilter = null!;
    private CheckBox chkBookAvailableOnly = null!;
    private Button btnAddBook = null!;
    private Button btnEditBook = null!;
    private Button btnDeleteBook = null!;
    private Button btnBookRefresh = null!;
    private Button btnBookExportCsv = null!;
    private Button btnBookResetFilters = null!;
    private Label lblBookCountBadge = null!;

    private TableLayoutPanel rootLayout = null!;
    private TableLayoutPanel headerLayout = null!;
    private TableLayoutPanel headerTitles = null!;
    private FlowLayoutPanel quickActions = null!;
    private Panel headerPanel = null!;
    private Label lblAppTitle = null!;
    private Label lblAppSubtitle = null!;
    private Label lblUserInfo = null!;
    private Button btnQuickLogout = null!;
    private Button btnQuickAddBook = null!;
    private Button btnQuickBorrow = null!;
    private TabControl tabMain = null!;
    private TabPage pageDashboard = null!;
    private TabPage pageBooks = null!;
    private TabPage pageMembers = null!;
    private TabPage pageCirculation = null!;
    private TabPage pageReports = null!;
    private TabPage pageNetwork = null!;
    private StatusStrip statusStrip = null!;
    private ToolStripStatusLabel lblStatusText = null!;
    private ToolStripStatusLabel lblDbStatus = null!;
    private ToolStripStatusLabel lblServerIndicator = null!;

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
        rootLayout = new TableLayoutPanel();
        headerPanel = new Panel();
        headerLayout = new TableLayoutPanel();
        headerTitles = new TableLayoutPanel();
        lblAppTitle = new Label();
        lblAppSubtitle = new Label();
        quickActions = new FlowLayoutPanel();
        btnQuickLogout = new Button();
        lblUserInfo = new Label();
        btnQuickAddBook = new Button();
        btnQuickBorrow = new Button();
        tabMain = new TabControl();
        pageDashboard = new TabPage();
        dashboardScroll = new Panel();
        dashboardLayout = new TableLayoutPanel();
        dashboardCards = new TableLayoutPanel();
        cardBooks = new StatCardControl();
        cardCopies = new StatCardControl();
        cardMembers = new StatCardControl();
        cardActiveLoans = new StatCardControl();
        cardOverdue = new StatCardControl();
        cardFines = new StatCardControl();
        dashboardCharts = new TableLayoutPanel();
        chartCategories = new GdiChartControl();
        chartTrends = new GdiChartControl();
        dashboardOverduePanel = new TableLayoutPanel();
        dashboardOverdueHeader = new FlowLayoutPanel();
        lblDashboardOverdueTitle = new Label();
        lblOverdueHeaderBadge = new Label();
        dgvOverdueSummary = new DataGridView();
        pageBooks = new TabPage();
        booksPageLayout = new TableLayoutPanel();
        booksHeader = new Panel();
        booksHeaderLayout = new TableLayoutPanel();
        booksTitleRow = new FlowLayoutPanel();
        lblBooksHeading = new Label();
        lblBookCountBadge = new Label();
        booksActionRow = new FlowLayoutPanel();
        btnBookRefresh = new Button();
        btnBookExportCsv = new Button();
        btnDeleteBook = new Button();
        btnEditBook = new Button();
        btnAddBook = new Button();
        booksFilterRow = new FlowLayoutPanel();
        lblBooksSearch = new Label();
        txtBookSearch = new TextBox();
        lblBooksCategory = new Label();
        cmbBookCategoryFilter = new ComboBox();
        chkBookAvailableOnly = new CheckBox();
        btnBookResetFilters = new Button();
        booksGridPanel = new Panel();
        dgvBooks = new DataGridView();
        pageMembers = new TabPage();
        membersPageLayout = new TableLayoutPanel();
        membersHeader = new Panel();
        membersHeaderLayout = new TableLayoutPanel();
        membersFilterRow = new FlowLayoutPanel();
        lblMembersSearch = new Label();
        txtMemberSearch = new TextBox();
        lblMembersType = new Label();
        cmbMemberTypeFilter = new ComboBox();
        chkMemberActiveOnly = new CheckBox();
        btnMemberResetFilters = new Button();
        membersTopRow = new TableLayoutPanel();
        membersTitleRow = new FlowLayoutPanel();
        lblMembersHeading = new Label();
        lblMemberCountBadge = new Label();
        membersActionRow = new FlowLayoutPanel();
        btnMemberRefresh = new Button();
        btnDeleteMember = new Button();
        btnToggleMemberStatus = new Button();
        btnEditMember = new Button();
        btnAddMember = new Button();
        membersGridPanel = new Panel();
        dgvMembers = new DataGridView();
        pageCirculation = new TabPage();
        loansPageLayout = new TableLayoutPanel();
        loansHeader = new Panel();
        loansHeaderLayout = new TableLayoutPanel();
        loansTopRow = new TableLayoutPanel();
        loansTitleRow = new FlowLayoutPanel();
        lblLoansHeading = new Label();
        lblLoanCountBadge = new Label();
        loansActionRow = new FlowLayoutPanel();
        btnLoanRefresh = new Button();
        btnLoanExportCsv = new Button();
        btnRecalcFines = new Button();
        btnReturnBook = new Button();
        btnIssueLoan = new Button();
        loansFilterRow = new FlowLayoutPanel();
        lblLoansSearch = new Label();
        txtLoanSearch = new TextBox();
        lblLoansStatus = new Label();
        cmbLoanStatusFilter = new ComboBox();
        btnLoanResetFilters = new Button();
        loansGridPanel = new Panel();
        dgvLoans = new DataGridView();
        pageReports = new TabPage();
        reportsPageLayout = new TableLayoutPanel();
        reportsToolbar = new FlowLayoutPanel();
        btnReportRefresh = new Button();
        btnReportExportTxt = new Button();
        btnReportViewFull = new Button();
        reportsContentLayout = new TableLayoutPanel();
        reportsSummaryGroup = new GroupBox();
        txtReportOutput = new TextBox();
        reportsTopBooksGroup = new GroupBox();
        dgvTopBooks = new DataGridView();
        pageNetwork = new TabPage();
        networkSplit = new SplitContainer();
        networkServerGroup = new GroupBox();
        txtServerLogs = new TextBox();
        networkServerActions = new FlowLayoutPanel();
        lblServerStatus = new Label();
        btnToggleServer = new Button();
        btnClearServerLogs = new Button();
        networkClientGroup = new GroupBox();
        txtClientResponse = new TextBox();
        networkClientInput = new TableLayoutPanel();
        txtClientCommand = new TextBox();
        btnSendClientCommand = new Button();
        lblNetworkHelp = new Label();
        statusStrip = new StatusStrip();
        lblStatusText = new ToolStripStatusLabel();
        lblDbStatus = new ToolStripStatusLabel();
        lblServerIndicator = new ToolStripStatusLabel();
        rootLayout.SuspendLayout();
        headerPanel.SuspendLayout();
        headerLayout.SuspendLayout();
        headerTitles.SuspendLayout();
        quickActions.SuspendLayout();
        tabMain.SuspendLayout();
        pageDashboard.SuspendLayout();
        dashboardScroll.SuspendLayout();
        dashboardLayout.SuspendLayout();
        dashboardCards.SuspendLayout();
        dashboardCharts.SuspendLayout();
        dashboardOverduePanel.SuspendLayout();
        dashboardOverdueHeader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOverdueSummary).BeginInit();
        pageBooks.SuspendLayout();
        booksPageLayout.SuspendLayout();
        booksHeader.SuspendLayout();
        booksHeaderLayout.SuspendLayout();
        booksTitleRow.SuspendLayout();
        booksActionRow.SuspendLayout();
        booksFilterRow.SuspendLayout();
        booksGridPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
        pageMembers.SuspendLayout();
        membersPageLayout.SuspendLayout();
        membersHeader.SuspendLayout();
        membersHeaderLayout.SuspendLayout();
        membersFilterRow.SuspendLayout();
        membersTopRow.SuspendLayout();
        membersTitleRow.SuspendLayout();
        membersActionRow.SuspendLayout();
        membersGridPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
        pageCirculation.SuspendLayout();
        loansPageLayout.SuspendLayout();
        loansHeader.SuspendLayout();
        loansHeaderLayout.SuspendLayout();
        loansTopRow.SuspendLayout();
        loansTitleRow.SuspendLayout();
        loansActionRow.SuspendLayout();
        loansFilterRow.SuspendLayout();
        loansGridPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLoans).BeginInit();
        pageReports.SuspendLayout();
        reportsPageLayout.SuspendLayout();
        reportsToolbar.SuspendLayout();
        reportsContentLayout.SuspendLayout();
        reportsSummaryGroup.SuspendLayout();
        reportsTopBooksGroup.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTopBooks).BeginInit();
        pageNetwork.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)networkSplit).BeginInit();
        networkSplit.Panel1.SuspendLayout();
        networkSplit.Panel2.SuspendLayout();
        networkSplit.SuspendLayout();
        networkServerGroup.SuspendLayout();
        networkServerActions.SuspendLayout();
        networkClientGroup.SuspendLayout();
        networkClientInput.SuspendLayout();
        statusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // rootLayout
        // 
        rootLayout.ColumnCount = 1;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(headerPanel, 0, 0);
        rootLayout.Controls.Add(tabMain, 0, 1);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.Location = new Point(0, 0);
        rootLayout.Margin = new Padding(0);
        rootLayout.Name = "rootLayout";
        rootLayout.RowCount = 2;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.Size = new Size(1220, 748);
        rootLayout.TabIndex = 0;
        // 
        // headerPanel
        // 
        headerPanel.BackColor = Color.FromArgb(15, 23, 42);
        headerPanel.Controls.Add(headerLayout);
        headerPanel.Dock = DockStyle.Fill;
        headerPanel.Location = new Point(0, 0);
        headerPanel.Margin = new Padding(0);
        headerPanel.Name = "headerPanel";
        headerPanel.Padding = new Padding(24, 16, 24, 16);
        headerPanel.Size = new Size(1220, 130);
        headerPanel.TabIndex = 0;
        // 
        // headerLayout
        // 
        headerLayout.ColumnCount = 2;
        headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
        headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
        headerLayout.Controls.Add(headerTitles, 0, 0);
        headerLayout.Controls.Add(quickActions, 1, 0);
        headerLayout.Dock = DockStyle.Fill;
        headerLayout.Location = new Point(24, 16);
        headerLayout.Name = "headerLayout";
        headerLayout.RowCount = 1;
        headerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        headerLayout.Size = new Size(1172, 98);
        headerLayout.TabIndex = 0;
        // 
        // headerTitles
        // 
        headerTitles.ColumnCount = 1;
        headerTitles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        headerTitles.Controls.Add(lblAppTitle, 0, 0);
        headerTitles.Controls.Add(lblAppSubtitle, 0, 1);
        headerTitles.Dock = DockStyle.Fill;
        headerTitles.Location = new Point(3, 3);
        headerTitles.Name = "headerTitles";
        headerTitles.RowCount = 2;
        headerTitles.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        headerTitles.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        headerTitles.Size = new Size(521, 92);
        headerTitles.TabIndex = 0;
        // 
        // lblAppTitle
        // 
        lblAppTitle.Dock = DockStyle.Fill;
        lblAppTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblAppTitle.ForeColor = Color.White;
        lblAppTitle.Location = new Point(3, 0);
        lblAppTitle.Name = "lblAppTitle";
        lblAppTitle.Size = new Size(515, 38);
        lblAppTitle.TabIndex = 0;
        lblAppTitle.Text = "DIGITAL LIBRARY SYSTEM";
        lblAppTitle.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblAppSubtitle
        // 
        lblAppSubtitle.Dock = DockStyle.Fill;
        lblAppSubtitle.ForeColor = Color.FromArgb(203, 213, 225);
        lblAppSubtitle.Location = new Point(3, 38);
        lblAppSubtitle.Name = "lblAppSubtitle";
        lblAppSubtitle.Size = new Size(515, 54);
        lblAppSubtitle.TabIndex = 1;
        lblAppSubtitle.Text = "Catalog  •  Members  •  Loans  •  Reports  •  Network";
        lblAppSubtitle.TextAlign = ContentAlignment.MiddleLeft;
        lblAppSubtitle.UseMnemonic = false;
        // 
        // quickActions
        // 
        quickActions.Controls.Add(btnQuickLogout);
        quickActions.Controls.Add(lblUserInfo);
        quickActions.Controls.Add(btnQuickAddBook);
        quickActions.Controls.Add(btnQuickBorrow);
        quickActions.Dock = DockStyle.Fill;
        quickActions.FlowDirection = FlowDirection.RightToLeft;
        quickActions.Location = new Point(530, 3);
        quickActions.Name = "quickActions";
        quickActions.Padding = new Padding(0, 8, 0, 0);
        quickActions.Size = new Size(639, 92);
        quickActions.TabIndex = 1;
        quickActions.WrapContents = false;
        // 
        // btnQuickLogout
        // 
        btnQuickLogout.BackColor = Color.FromArgb(220, 38, 38);
        btnQuickLogout.Cursor = Cursors.Hand;
        btnQuickLogout.FlatAppearance.BorderSize = 0;
        btnQuickLogout.FlatStyle = FlatStyle.Flat;
        btnQuickLogout.ForeColor = Color.White;
        btnQuickLogout.Location = new Point(544, 8);
        btnQuickLogout.Margin = new Padding(0);
        btnQuickLogout.Name = "btnQuickLogout";
        btnQuickLogout.Size = new Size(95, 38);
        btnQuickLogout.TabIndex = 0;
        btnQuickLogout.Text = "Logout";
        btnQuickLogout.UseVisualStyleBackColor = false;
        // 
        // lblUserInfo
        // 
        lblUserInfo.AutoSize = true;
        lblUserInfo.Font = new Font("Segoe UI", 9.25F, FontStyle.Bold);
        lblUserInfo.ForeColor = Color.FromArgb(147, 197, 253);
        lblUserInfo.Location = new Point(387, 18);
        lblUserInfo.Margin = new Padding(12, 10, 8, 0);
        lblUserInfo.Name = "lblUserInfo";
        lblUserInfo.Size = new Size(149, 25);
        lblUserInfo.TabIndex = 1;
        lblUserInfo.Text = "Admin (Admin)";
        // 
        // btnQuickAddBook
        // 
        btnQuickAddBook.BackColor = Color.FromArgb(99, 102, 241);
        btnQuickAddBook.Cursor = Cursors.Hand;
        btnQuickAddBook.FlatAppearance.BorderSize = 0;
        btnQuickAddBook.FlatStyle = FlatStyle.Flat;
        btnQuickAddBook.ForeColor = Color.White;
        btnQuickAddBook.Location = new Point(260, 8);
        btnQuickAddBook.Margin = new Padding(8, 0, 0, 0);
        btnQuickAddBook.Name = "btnQuickAddBook";
        btnQuickAddBook.Size = new Size(115, 38);
        btnQuickAddBook.TabIndex = 2;
        btnQuickAddBook.Text = "+ Add Book";
        btnQuickAddBook.UseVisualStyleBackColor = false;
        // 
        // btnQuickBorrow
        // 
        btnQuickBorrow.BackColor = Color.FromArgb(16, 185, 129);
        btnQuickBorrow.Cursor = Cursors.Hand;
        btnQuickBorrow.FlatAppearance.BorderSize = 0;
        btnQuickBorrow.FlatStyle = FlatStyle.Flat;
        btnQuickBorrow.ForeColor = Color.White;
        btnQuickBorrow.Location = new Point(132, 8);
        btnQuickBorrow.Margin = new Padding(0);
        btnQuickBorrow.Name = "btnQuickBorrow";
        btnQuickBorrow.Size = new Size(120, 38);
        btnQuickBorrow.TabIndex = 3;
        btnQuickBorrow.Text = "+ Borrow Book";
        btnQuickBorrow.UseVisualStyleBackColor = false;
        // 
        // tabMain
        // 
        tabMain.Controls.Add(pageDashboard);
        tabMain.Controls.Add(pageBooks);
        tabMain.Controls.Add(pageMembers);
        tabMain.Controls.Add(pageCirculation);
        tabMain.Controls.Add(pageReports);
        tabMain.Controls.Add(pageNetwork);
        tabMain.Dock = DockStyle.Fill;
        tabMain.Font = new Font("Segoe UI", 9.5F);
        tabMain.Location = new Point(0, 130);
        tabMain.Margin = new Padding(0);
        tabMain.Name = "tabMain";
        tabMain.Padding = new Point(14, 8);
        tabMain.SelectedIndex = 0;
        tabMain.Size = new Size(1220, 618);
        tabMain.TabIndex = 1;
        // 
        // pageDashboard
        // 
        pageDashboard.BackColor = Color.FromArgb(248, 250, 252);
        pageDashboard.Controls.Add(dashboardScroll);
        pageDashboard.Location = new Point(4, 44);
        pageDashboard.Name = "pageDashboard";
        pageDashboard.Size = new Size(1212, 570);
        pageDashboard.TabIndex = 0;
        pageDashboard.Text = "Dashboard";
        // 
        // dashboardScroll
        // 
        dashboardScroll.AutoScroll = true;
        dashboardScroll.Controls.Add(dashboardLayout);
        dashboardScroll.Dock = DockStyle.Fill;
        dashboardScroll.Location = new Point(0, 0);
        dashboardScroll.Name = "dashboardScroll";
        dashboardScroll.Padding = new Padding(12);
        dashboardScroll.Size = new Size(1212, 570);
        dashboardScroll.TabIndex = 0;
        // 
        // dashboardLayout
        // 
        dashboardLayout.ColumnCount = 1;
        dashboardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        dashboardLayout.Controls.Add(dashboardCards, 0, 0);
        dashboardLayout.Controls.Add(dashboardCharts, 0, 1);
        dashboardLayout.Controls.Add(dashboardOverduePanel, 0, 2);
        dashboardLayout.Dock = DockStyle.Top;
        dashboardLayout.Location = new Point(12, 12);
        dashboardLayout.Name = "dashboardLayout";
        dashboardLayout.RowCount = 3;
        dashboardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 270F));
        dashboardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 340F));
        dashboardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 290F));
        dashboardLayout.Size = new Size(1162, 900);
        dashboardLayout.TabIndex = 0;
        // 
        // dashboardCards
        // 
        dashboardCards.ColumnCount = 3;
        dashboardCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        dashboardCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        dashboardCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
        dashboardCards.Controls.Add(cardBooks, 0, 0);
        dashboardCards.Controls.Add(cardCopies, 1, 0);
        dashboardCards.Controls.Add(cardMembers, 2, 0);
        dashboardCards.Controls.Add(cardActiveLoans, 0, 1);
        dashboardCards.Controls.Add(cardOverdue, 1, 1);
        dashboardCards.Controls.Add(cardFines, 2, 1);
        dashboardCards.Dock = DockStyle.Fill;
        dashboardCards.Location = new Point(3, 3);
        dashboardCards.Name = "dashboardCards";
        dashboardCards.RowCount = 2;
        dashboardCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        dashboardCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        dashboardCards.Size = new Size(1156, 264);
        dashboardCards.TabIndex = 0;
        // 
        // cardBooks
        // 
        cardBooks.AccentColor = Color.FromArgb(99, 102, 241);
        cardBooks.BackColor = Color.White;
        cardBooks.Dock = DockStyle.Fill;
        cardBooks.Location = new Point(5, 5);
        cardBooks.Margin = new Padding(5);
        cardBooks.MinimumSize = new Size(150, 108);
        cardBooks.Name = "cardBooks";
        cardBooks.Size = new Size(375, 122);
        cardBooks.Subtitle = "In Library";
        cardBooks.TabIndex = 0;
        cardBooks.Title = "Total Titles";
        cardBooks.Value = "0";
        // 
        // cardCopies
        // 
        cardCopies.AccentColor = Color.FromArgb(14, 165, 233);
        cardCopies.BackColor = Color.White;
        cardCopies.Dock = DockStyle.Fill;
        cardCopies.Location = new Point(390, 5);
        cardCopies.Margin = new Padding(5);
        cardCopies.MinimumSize = new Size(150, 108);
        cardCopies.Name = "cardCopies";
        cardCopies.Size = new Size(375, 122);
        cardCopies.Subtitle = "Ready to borrow";
        cardCopies.TabIndex = 1;
        cardCopies.Title = "Available Copies";
        cardCopies.Value = "0";
        // 
        // cardMembers
        // 
        cardMembers.AccentColor = Color.FromArgb(16, 185, 129);
        cardMembers.BackColor = Color.White;
        cardMembers.Dock = DockStyle.Fill;
        cardMembers.Location = new Point(775, 5);
        cardMembers.Margin = new Padding(5);
        cardMembers.MinimumSize = new Size(150, 108);
        cardMembers.Name = "cardMembers";
        cardMembers.Size = new Size(376, 122);
        cardMembers.Subtitle = "Registered readers";
        cardMembers.TabIndex = 2;
        cardMembers.Title = "Active Members";
        cardMembers.Value = "0";
        // 
        // cardActiveLoans
        // 
        cardActiveLoans.AccentColor = Color.FromArgb(245, 158, 11);
        cardActiveLoans.BackColor = Color.White;
        cardActiveLoans.Dock = DockStyle.Fill;
        cardActiveLoans.Location = new Point(5, 137);
        cardActiveLoans.Margin = new Padding(5);
        cardActiveLoans.MinimumSize = new Size(150, 108);
        cardActiveLoans.Name = "cardActiveLoans";
        cardActiveLoans.Size = new Size(375, 122);
        cardActiveLoans.Subtitle = "Currently out";
        cardActiveLoans.TabIndex = 3;
        cardActiveLoans.Title = "Active Loans";
        cardActiveLoans.Value = "0";
        // 
        // cardOverdue
        // 
        cardOverdue.AccentColor = Color.FromArgb(239, 68, 68);
        cardOverdue.BackColor = Color.White;
        cardOverdue.Dock = DockStyle.Fill;
        cardOverdue.Location = new Point(390, 137);
        cardOverdue.Margin = new Padding(5);
        cardOverdue.MinimumSize = new Size(150, 108);
        cardOverdue.Name = "cardOverdue";
        cardOverdue.Size = new Size(375, 122);
        cardOverdue.Subtitle = "Require attention";
        cardOverdue.TabIndex = 4;
        cardOverdue.Title = "Overdue Books";
        cardOverdue.Value = "0";
        // 
        // cardFines
        // 
        cardFines.AccentColor = Color.FromArgb(168, 85, 247);
        cardFines.BackColor = Color.White;
        cardFines.Dock = DockStyle.Fill;
        cardFines.Location = new Point(775, 137);
        cardFines.Margin = new Padding(5);
        cardFines.MinimumSize = new Size(150, 108);
        cardFines.Name = "cardFines";
        cardFines.Size = new Size(376, 122);
        cardFines.Subtitle = "Collected / Accrued";
        cardFines.TabIndex = 5;
        cardFines.Title = "Total Fines";
        cardFines.Value = "0";
        // 
        // dashboardCharts
        // 
        dashboardCharts.ColumnCount = 2;
        dashboardCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        dashboardCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        dashboardCharts.Controls.Add(chartCategories, 0, 0);
        dashboardCharts.Controls.Add(chartTrends, 1, 0);
        dashboardCharts.Dock = DockStyle.Fill;
        dashboardCharts.Location = new Point(3, 273);
        dashboardCharts.Name = "dashboardCharts";
        dashboardCharts.RowCount = 1;
        dashboardCharts.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        dashboardCharts.Size = new Size(1156, 334);
        dashboardCharts.TabIndex = 1;
        // 
        // chartCategories
        // 
        chartCategories.BackColor = Color.White;
        chartCategories.ChartTitle = "Book Collection by Category";
        chartCategories.ChartType = ChartType.Pie;
        chartCategories.Dock = DockStyle.Fill;
        chartCategories.Location = new Point(5, 5);
        chartCategories.Margin = new Padding(5);
        chartCategories.Name = "chartCategories";
        chartCategories.Size = new Size(568, 324);
        chartCategories.TabIndex = 0;
        // 
        // chartTrends
        // 
        chartTrends.BackColor = Color.White;
        chartTrends.ChartTitle = "Monthly Loan Trends";
        chartTrends.ChartType = ChartType.Bar;
        chartTrends.Dock = DockStyle.Fill;
        chartTrends.Location = new Point(583, 5);
        chartTrends.Margin = new Padding(5);
        chartTrends.Name = "chartTrends";
        chartTrends.Size = new Size(568, 324);
        chartTrends.TabIndex = 1;
        // 
        // dashboardOverduePanel
        // 
        dashboardOverduePanel.BackColor = Color.White;
        dashboardOverduePanel.ColumnCount = 1;
        dashboardOverduePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        dashboardOverduePanel.Controls.Add(dashboardOverdueHeader, 0, 0);
        dashboardOverduePanel.Controls.Add(dgvOverdueSummary, 0, 1);
        dashboardOverduePanel.Dock = DockStyle.Fill;
        dashboardOverduePanel.Location = new Point(5, 615);
        dashboardOverduePanel.Margin = new Padding(5);
        dashboardOverduePanel.Name = "dashboardOverduePanel";
        dashboardOverduePanel.RowCount = 2;
        dashboardOverduePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        dashboardOverduePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        dashboardOverduePanel.Size = new Size(1152, 280);
        dashboardOverduePanel.TabIndex = 2;
        // 
        // dashboardOverdueHeader
        // 
        dashboardOverdueHeader.BackColor = Color.FromArgb(254, 242, 242);
        dashboardOverdueHeader.Controls.Add(lblDashboardOverdueTitle);
        dashboardOverdueHeader.Controls.Add(lblOverdueHeaderBadge);
        dashboardOverdueHeader.Dock = DockStyle.Fill;
        dashboardOverdueHeader.Location = new Point(3, 3);
        dashboardOverdueHeader.Name = "dashboardOverdueHeader";
        dashboardOverdueHeader.Padding = new Padding(10, 12, 10, 2);
        dashboardOverdueHeader.Size = new Size(1146, 44);
        dashboardOverdueHeader.TabIndex = 0;
        dashboardOverdueHeader.WrapContents = false;
        // 
        // lblDashboardOverdueTitle
        // 
        lblDashboardOverdueTitle.AutoSize = true;
        lblDashboardOverdueTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblDashboardOverdueTitle.ForeColor = Color.FromArgb(185, 28, 28);
        lblDashboardOverdueTitle.Location = new Point(13, 12);
        lblDashboardOverdueTitle.Name = "lblDashboardOverdueTitle";
        lblDashboardOverdueTitle.Size = new Size(223, 28);
        lblDashboardOverdueTitle.TabIndex = 0;
        lblDashboardOverdueTitle.Text = "Urgent Overdue Loans";
        // 
        // lblOverdueHeaderBadge
        // 
        lblOverdueHeaderBadge.AutoSize = true;
        lblOverdueHeaderBadge.ForeColor = Color.FromArgb(185, 28, 28);
        lblOverdueHeaderBadge.Location = new Point(259, 15);
        lblOverdueHeaderBadge.Margin = new Padding(20, 3, 0, 0);
        lblOverdueHeaderBadge.Name = "lblOverdueHeaderBadge";
        lblOverdueHeaderBadge.Size = new Size(237, 25);
        lblOverdueHeaderBadge.TabIndex = 1;
        lblOverdueHeaderBadge.Text = "Loans past return due date";
        // 
        // dgvOverdueSummary
        // 
        dgvOverdueSummary.AllowUserToAddRows = false;
        dgvOverdueSummary.AllowUserToDeleteRows = false;
        dgvOverdueSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvOverdueSummary.BackgroundColor = Color.White;
        dgvOverdueSummary.ColumnHeadersHeight = 44;
        dgvOverdueSummary.Dock = DockStyle.Fill;
        dgvOverdueSummary.Location = new Point(3, 53);
        dgvOverdueSummary.Name = "dgvOverdueSummary";
        dgvOverdueSummary.ReadOnly = true;
        dgvOverdueSummary.RowHeadersVisible = false;
        dgvOverdueSummary.RowHeadersWidth = 62;
        dgvOverdueSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvOverdueSummary.Size = new Size(1146, 224);
        dgvOverdueSummary.TabIndex = 1;
        // 
        // pageBooks
        // 
        pageBooks.BackColor = Color.FromArgb(248, 250, 252);
        pageBooks.Controls.Add(booksPageLayout);
        pageBooks.Location = new Point(4, 44);
        pageBooks.Name = "pageBooks";
        pageBooks.Size = new Size(1212, 570);
        pageBooks.TabIndex = 1;
        pageBooks.Text = "Books Catalog";
        // 
        // booksPageLayout
        // 
        booksPageLayout.ColumnCount = 1;
        booksPageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        booksPageLayout.Controls.Add(booksHeader, 0, 0);
        booksPageLayout.Controls.Add(booksGridPanel, 0, 1);
        booksPageLayout.Dock = DockStyle.Fill;
        booksPageLayout.Location = new Point(0, 0);
        booksPageLayout.Margin = new Padding(0);
        booksPageLayout.Name = "booksPageLayout";
        booksPageLayout.RowCount = 2;
        booksPageLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
        booksPageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        booksPageLayout.Size = new Size(1212, 570);
        booksPageLayout.TabIndex = 0;
        // 
        // booksHeader
        // 
        booksHeader.BackColor = Color.White;
        booksHeader.Controls.Add(booksHeaderLayout);
        booksHeader.Dock = DockStyle.Fill;
        booksHeader.Location = new Point(0, 0);
        booksHeader.Margin = new Padding(0);
        booksHeader.Name = "booksHeader";
        booksHeader.Padding = new Padding(15, 8, 15, 8);
        booksHeader.Size = new Size(1212, 126);
        booksHeader.TabIndex = 0;
        // 
        // booksHeaderLayout
        // 
        booksHeaderLayout.ColumnCount = 2;
        booksHeaderLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
        booksHeaderLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
        booksHeaderLayout.Controls.Add(booksTitleRow, 0, 0);
        booksHeaderLayout.Controls.Add(booksActionRow, 1, 0);
        booksHeaderLayout.Controls.Add(booksFilterRow, 0, 1);
        booksHeaderLayout.Dock = DockStyle.Fill;
        booksHeaderLayout.Location = new Point(15, 8);
        booksHeaderLayout.Name = "booksHeaderLayout";
        booksHeaderLayout.RowCount = 2;
        booksHeaderLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
        booksHeaderLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        booksHeaderLayout.Size = new Size(1182, 110);
        booksHeaderLayout.TabIndex = 0;
        // 
        // booksTitleRow
        // 
        booksTitleRow.Controls.Add(lblBooksHeading);
        booksTitleRow.Controls.Add(lblBookCountBadge);
        booksTitleRow.Dock = DockStyle.Fill;
        booksTitleRow.Location = new Point(3, 3);
        booksTitleRow.Name = "booksTitleRow";
        booksTitleRow.Size = new Size(490, 43);
        booksTitleRow.TabIndex = 0;
        booksTitleRow.WrapContents = false;
        // 
        // lblBooksHeading
        // 
        lblBooksHeading.AutoSize = true;
        lblBooksHeading.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
        lblBooksHeading.ForeColor = Color.FromArgb(15, 23, 42);
        lblBooksHeading.Location = new Point(0, 8);
        lblBooksHeading.Margin = new Padding(0, 8, 8, 0);
        lblBooksHeading.Name = "lblBooksHeading";
        lblBooksHeading.Size = new Size(313, 31);
        lblBooksHeading.TabIndex = 0;
        lblBooksHeading.Text = "📚 Book Inventory & Catalog";
        // 
        // lblBookCountBadge
        // 
        lblBookCountBadge.AutoSize = true;
        lblBookCountBadge.ForeColor = Color.FromArgb(100, 116, 139);
        lblBookCountBadge.Location = new Point(321, 11);
        lblBookCountBadge.Margin = new Padding(0, 11, 0, 0);
        lblBookCountBadge.Name = "lblBookCountBadge";
        lblBookCountBadge.Size = new Size(92, 25);
        lblBookCountBadge.TabIndex = 1;
        lblBookCountBadge.Text = "Loading...";
        // 
        // booksActionRow
        // 
        booksActionRow.Controls.Add(btnBookRefresh);
        booksActionRow.Controls.Add(btnBookExportCsv);
        booksActionRow.Controls.Add(btnDeleteBook);
        booksActionRow.Controls.Add(btnEditBook);
        booksActionRow.Controls.Add(btnAddBook);
        booksActionRow.Dock = DockStyle.Fill;
        booksActionRow.FlowDirection = FlowDirection.RightToLeft;
        booksActionRow.Location = new Point(499, 3);
        booksActionRow.Name = "booksActionRow";
        booksActionRow.Size = new Size(680, 43);
        booksActionRow.TabIndex = 1;
        booksActionRow.WrapContents = false;
        // 
        // btnBookRefresh
        // 
        btnBookRefresh.BackColor = Color.FromArgb(59, 130, 246);
        btnBookRefresh.Cursor = Cursors.Hand;
        btnBookRefresh.FlatAppearance.BorderSize = 0;
        btnBookRefresh.FlatStyle = FlatStyle.Flat;
        btnBookRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnBookRefresh.ForeColor = Color.White;
        btnBookRefresh.Location = new Point(602, 2);
        btnBookRefresh.Margin = new Padding(2);
        btnBookRefresh.Name = "btnBookRefresh";
        btnBookRefresh.Size = new Size(76, 34);
        btnBookRefresh.TabIndex = 0;
        btnBookRefresh.Text = "Refresh";
        btnBookRefresh.UseVisualStyleBackColor = false;
        // 
        // btnBookExportCsv
        // 
        btnBookExportCsv.BackColor = Color.FromArgb(16, 185, 129);
        btnBookExportCsv.Cursor = Cursors.Hand;
        btnBookExportCsv.FlatAppearance.BorderSize = 0;
        btnBookExportCsv.FlatStyle = FlatStyle.Flat;
        btnBookExportCsv.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnBookExportCsv.ForeColor = Color.White;
        btnBookExportCsv.Location = new Point(533, 2);
        btnBookExportCsv.Margin = new Padding(2);
        btnBookExportCsv.Name = "btnBookExportCsv";
        btnBookExportCsv.Size = new Size(65, 34);
        btnBookExportCsv.TabIndex = 1;
        btnBookExportCsv.Text = "Save";
        btnBookExportCsv.UseVisualStyleBackColor = false;
        // 
        // btnDeleteBook
        // 
        btnDeleteBook.BackColor = Color.FromArgb(239, 68, 68);
        btnDeleteBook.Cursor = Cursors.Hand;
        btnDeleteBook.Enabled = false;
        btnDeleteBook.FlatAppearance.BorderSize = 0;
        btnDeleteBook.FlatStyle = FlatStyle.Flat;
        btnDeleteBook.ForeColor = Color.White;
        btnDeleteBook.Location = new Point(444, 2);
        btnDeleteBook.Margin = new Padding(2);
        btnDeleteBook.Name = "btnDeleteBook";
        btnDeleteBook.Size = new Size(85, 34);
        btnDeleteBook.TabIndex = 2;
        btnDeleteBook.Text = "Delete";
        btnDeleteBook.UseVisualStyleBackColor = false;
        // 
        // btnEditBook
        // 
        btnEditBook.BackColor = Color.FromArgb(245, 158, 11);
        btnEditBook.Cursor = Cursors.Hand;
        btnEditBook.Enabled = false;
        btnEditBook.FlatAppearance.BorderSize = 0;
        btnEditBook.FlatStyle = FlatStyle.Flat;
        btnEditBook.ForeColor = Color.White;
        btnEditBook.Location = new Point(360, 2);
        btnEditBook.Margin = new Padding(2);
        btnEditBook.Name = "btnEditBook";
        btnEditBook.Size = new Size(80, 34);
        btnEditBook.TabIndex = 3;
        btnEditBook.Text = "Edit";
        btnEditBook.UseVisualStyleBackColor = false;
        // 
        // btnAddBook
        // 
        btnAddBook.BackColor = Color.FromArgb(79, 70, 229);
        btnAddBook.Cursor = Cursors.Hand;
        btnAddBook.FlatAppearance.BorderSize = 0;
        btnAddBook.FlatStyle = FlatStyle.Flat;
        btnAddBook.ForeColor = Color.White;
        btnAddBook.Location = new Point(250, 2);
        btnAddBook.Margin = new Padding(2);
        btnAddBook.Name = "btnAddBook";
        btnAddBook.Size = new Size(106, 34);
        btnAddBook.TabIndex = 4;
        btnAddBook.Text = "+ Add Book";
        btnAddBook.UseVisualStyleBackColor = false;
        // 
        // booksFilterRow
        // 
        booksFilterRow.AutoScroll = true;
        booksHeaderLayout.SetColumnSpan(booksFilterRow, 2);
        booksFilterRow.Controls.Add(lblBooksSearch);
        booksFilterRow.Controls.Add(txtBookSearch);
        booksFilterRow.Controls.Add(lblBooksCategory);
        booksFilterRow.Controls.Add(cmbBookCategoryFilter);
        booksFilterRow.Controls.Add(chkBookAvailableOnly);
        booksFilterRow.Controls.Add(btnBookResetFilters);
        booksFilterRow.Dock = DockStyle.Fill;
        booksFilterRow.Location = new Point(3, 52);
        booksFilterRow.Name = "booksFilterRow";
        booksFilterRow.Size = new Size(1176, 55);
        booksFilterRow.TabIndex = 2;
        booksFilterRow.WrapContents = false;
        // 
        // lblBooksSearch
        // 
        lblBooksSearch.AutoSize = true;
        lblBooksSearch.Location = new Point(0, 9);
        lblBooksSearch.Margin = new Padding(0, 9, 7, 0);
        lblBooksSearch.Name = "lblBooksSearch";
        lblBooksSearch.Size = new Size(73, 25);
        lblBooksSearch.TabIndex = 0;
        lblBooksSearch.Text = "Search:";
        // 
        // txtBookSearch
        // 
        txtBookSearch.Location = new Point(80, 5);
        txtBookSearch.Margin = new Padding(0, 5, 16, 0);
        txtBookSearch.Name = "txtBookSearch";
        txtBookSearch.Size = new Size(230, 33);
        txtBookSearch.TabIndex = 1;
        // 
        // lblBooksCategory
        // 
        lblBooksCategory.AutoSize = true;
        lblBooksCategory.Location = new Point(326, 9);
        lblBooksCategory.Margin = new Padding(0, 9, 7, 0);
        lblBooksCategory.Name = "lblBooksCategory";
        lblBooksCategory.Size = new Size(92, 25);
        lblBooksCategory.TabIndex = 2;
        lblBooksCategory.Text = "Category:";
        // 
        // cmbBookCategoryFilter
        // 
        cmbBookCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbBookCategoryFilter.Items.AddRange(new object[] { "All Categories" });
        cmbBookCategoryFilter.Location = new Point(425, 5);
        cmbBookCategoryFilter.Margin = new Padding(0, 5, 14, 0);
        cmbBookCategoryFilter.Name = "cmbBookCategoryFilter";
        cmbBookCategoryFilter.Size = new Size(175, 33);
        cmbBookCategoryFilter.TabIndex = 3;
        // 
        // chkBookAvailableOnly
        // 
        chkBookAvailableOnly.AutoSize = true;
        chkBookAvailableOnly.Location = new Point(614, 9);
        chkBookAvailableOnly.Margin = new Padding(0, 9, 16, 0);
        chkBookAvailableOnly.Name = "chkBookAvailableOnly";
        chkBookAvailableOnly.Size = new Size(221, 29);
        chkBookAvailableOnly.TabIndex = 4;
        chkBookAvailableOnly.Text = "Available Copies Only";
        // 
        // btnBookResetFilters
        // 
        btnBookResetFilters.Location = new Point(851, 3);
        btnBookResetFilters.Margin = new Padding(0, 3, 0, 0);
        btnBookResetFilters.Name = "btnBookResetFilters";
        btnBookResetFilters.Size = new Size(100, 30);
        btnBookResetFilters.TabIndex = 5;
        btnBookResetFilters.Text = "Reset Filters";
        // 
        // booksGridPanel
        // 
        booksGridPanel.Controls.Add(dgvBooks);
        booksGridPanel.Dock = DockStyle.Fill;
        booksGridPanel.Location = new Point(0, 126);
        booksGridPanel.Margin = new Padding(0);
        booksGridPanel.Name = "booksGridPanel";
        booksGridPanel.Padding = new Padding(15, 10, 15, 10);
        booksGridPanel.Size = new Size(1212, 444);
        booksGridPanel.TabIndex = 1;
        // 
        // dgvBooks
        // 
        dgvBooks.AllowUserToAddRows = false;
        dgvBooks.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
        dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvBooks.BackgroundColor = Color.White;
        dgvBooks.BorderStyle = BorderStyle.None;
        dgvBooks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.25F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvBooks.ColumnHeadersHeight = 44;
        dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = SystemColors.Window;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.25F);
        dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(199, 210, 254);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvBooks.DefaultCellStyle = dataGridViewCellStyle3;
        dgvBooks.Dock = DockStyle.Fill;
        dgvBooks.EnableHeadersVisualStyles = false;
        dgvBooks.GridColor = Color.FromArgb(241, 245, 249);
        dgvBooks.Location = new Point(15, 10);
        dgvBooks.MultiSelect = false;
        dgvBooks.Name = "dgvBooks";
        dgvBooks.ReadOnly = true;
        dgvBooks.RowHeadersVisible = false;
        dgvBooks.RowHeadersWidth = 62;
        dgvBooks.RowTemplate.Height = 36;
        dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvBooks.Size = new Size(1182, 424);
        dgvBooks.TabIndex = 0;
        // 
        // pageMembers
        // 
        pageMembers.BackColor = Color.FromArgb(248, 250, 252);
        pageMembers.Controls.Add(membersPageLayout);
        pageMembers.Location = new Point(4, 44);
        pageMembers.Name = "pageMembers";
        pageMembers.Size = new Size(1212, 570);
        pageMembers.TabIndex = 2;
        pageMembers.Text = "Members";
        // 
        // membersPageLayout
        // 
        membersPageLayout.ColumnCount = 1;
        membersPageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        membersPageLayout.Controls.Add(membersHeader, 0, 0);
        membersPageLayout.Controls.Add(membersGridPanel, 0, 1);
        membersPageLayout.Dock = DockStyle.Fill;
        membersPageLayout.Location = new Point(0, 0);
        membersPageLayout.Margin = new Padding(0);
        membersPageLayout.Name = "membersPageLayout";
        membersPageLayout.RowCount = 2;
        membersPageLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
        membersPageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        membersPageLayout.Size = new Size(1212, 570);
        membersPageLayout.TabIndex = 0;
        // 
        // membersHeader
        // 
        membersHeader.BackColor = Color.White;
        membersHeader.Controls.Add(membersHeaderLayout);
        membersHeader.Dock = DockStyle.Fill;
        membersHeader.Location = new Point(0, 0);
        membersHeader.Margin = new Padding(0);
        membersHeader.Name = "membersHeader";
        membersHeader.Padding = new Padding(15, 10, 15, 10);
        membersHeader.Size = new Size(1212, 160);
        membersHeader.TabIndex = 0;
        // 
        // membersHeaderLayout
        // 
        membersHeaderLayout.ColumnCount = 1;
        membersHeaderLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        membersHeaderLayout.Controls.Add(membersFilterRow, 0, 1);
        membersHeaderLayout.Controls.Add(membersTopRow, 0, 0);
        membersHeaderLayout.Dock = DockStyle.Fill;
        membersHeaderLayout.Location = new Point(15, 10);
        membersHeaderLayout.Name = "membersHeaderLayout";
        membersHeaderLayout.RowCount = 2;
        membersHeaderLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
        membersHeaderLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
        membersHeaderLayout.Size = new Size(1182, 140);
        membersHeaderLayout.TabIndex = 0;
        // 
        // membersFilterRow
        // 
        membersFilterRow.AutoScroll = true;
        membersFilterRow.Controls.Add(lblMembersSearch);
        membersFilterRow.Controls.Add(txtMemberSearch);
        membersFilterRow.Controls.Add(lblMembersType);
        membersFilterRow.Controls.Add(cmbMemberTypeFilter);
        membersFilterRow.Controls.Add(chkMemberActiveOnly);
        membersFilterRow.Controls.Add(btnMemberResetFilters);
        membersFilterRow.Dock = DockStyle.Fill;
        membersFilterRow.Location = new Point(3, 68);
        membersFilterRow.Name = "membersFilterRow";
        membersFilterRow.Padding = new Padding(0, 4, 0, 0);
        membersFilterRow.Size = new Size(1176, 69);
        membersFilterRow.TabIndex = 0;
        membersFilterRow.WrapContents = false;
        // 
        // lblMembersSearch
        // 
        lblMembersSearch.AutoSize = true;
        lblMembersSearch.Location = new Point(0, 11);
        lblMembersSearch.Margin = new Padding(0, 7, 8, 0);
        lblMembersSearch.Name = "lblMembersSearch";
        lblMembersSearch.Size = new Size(73, 25);
        lblMembersSearch.TabIndex = 0;
        lblMembersSearch.Text = "Search:";
        // 
        // txtMemberSearch
        // 
        txtMemberSearch.Location = new Point(85, 7);
        txtMemberSearch.Margin = new Padding(4, 3, 15, 0);
        txtMemberSearch.Name = "txtMemberSearch";
        txtMemberSearch.Size = new Size(230, 33);
        txtMemberSearch.TabIndex = 1;
        // 
        // lblMembersType
        // 
        lblMembersType.AutoSize = true;
        lblMembersType.Location = new Point(334, 11);
        lblMembersType.Margin = new Padding(4, 7, 8, 0);
        lblMembersType.Name = "lblMembersType";
        lblMembersType.Size = new Size(55, 25);
        lblMembersType.TabIndex = 2;
        lblMembersType.Text = "Type:";
        // 
        // cmbMemberTypeFilter
        // 
        cmbMemberTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbMemberTypeFilter.Items.AddRange(new object[] { "All Types", "Student", "Regular", "Faculty", "Premium" });
        cmbMemberTypeFilter.Location = new Point(401, 7);
        cmbMemberTypeFilter.Margin = new Padding(4, 3, 15, 0);
        cmbMemberTypeFilter.Name = "cmbMemberTypeFilter";
        cmbMemberTypeFilter.Size = new Size(165, 33);
        cmbMemberTypeFilter.TabIndex = 3;
        // 
        // chkMemberActiveOnly
        // 
        chkMemberActiveOnly.AutoSize = true;
        chkMemberActiveOnly.Location = new Point(585, 11);
        chkMemberActiveOnly.Margin = new Padding(4, 7, 15, 0);
        chkMemberActiveOnly.Name = "chkMemberActiveOnly";
        chkMemberActiveOnly.Size = new Size(133, 29);
        chkMemberActiveOnly.TabIndex = 4;
        chkMemberActiveOnly.Text = "Active Only";
        // 
        // btnMemberResetFilters
        // 
        btnMemberResetFilters.BackColor = Color.FromArgb(241, 245, 249);
        btnMemberResetFilters.FlatStyle = FlatStyle.Flat;
        btnMemberResetFilters.Location = new Point(737, 7);
        btnMemberResetFilters.Margin = new Padding(4, 3, 0, 0);
        btnMemberResetFilters.Name = "btnMemberResetFilters";
        btnMemberResetFilters.Size = new Size(110, 30);
        btnMemberResetFilters.TabIndex = 5;
        btnMemberResetFilters.Text = "Reset Filters";
        btnMemberResetFilters.UseVisualStyleBackColor = false;
        // 
        // membersTopRow
        // 
        membersTopRow.ColumnCount = 2;
        membersTopRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
        membersTopRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
        membersTopRow.Controls.Add(membersTitleRow, 0, 0);
        membersTopRow.Controls.Add(membersActionRow, 1, 0);
        membersTopRow.Dock = DockStyle.Fill;
        membersTopRow.Location = new Point(0, 0);
        membersTopRow.Margin = new Padding(0);
        membersTopRow.Name = "membersTopRow";
        membersTopRow.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        membersTopRow.Size = new Size(1182, 65);
        membersTopRow.TabIndex = 1;
        // 
        // membersTitleRow
        // 
        membersTitleRow.Controls.Add(lblMembersHeading);
        membersTitleRow.Controls.Add(lblMemberCountBadge);
        membersTitleRow.Dock = DockStyle.Fill;
        membersTitleRow.Location = new Point(3, 3);
        membersTitleRow.Name = "membersTitleRow";
        membersTitleRow.Size = new Size(525, 59);
        membersTitleRow.TabIndex = 0;
        membersTitleRow.WrapContents = false;
        // 
        // lblMembersHeading
        // 
        lblMembersHeading.AutoSize = true;
        lblMembersHeading.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblMembersHeading.ForeColor = Color.FromArgb(15, 23, 42);
        lblMembersHeading.Location = new Point(0, 7);
        lblMembersHeading.Margin = new Padding(0, 7, 8, 0);
        lblMembersHeading.Name = "lblMembersHeading";
        lblMembersHeading.Size = new Size(341, 30);
        lblMembersHeading.TabIndex = 0;
        lblMembersHeading.Text = "Registered Members & Privileges";
        // 
        // lblMemberCountBadge
        // 
        lblMemberCountBadge.AutoSize = true;
        lblMemberCountBadge.ForeColor = Color.FromArgb(100, 116, 139);
        lblMemberCountBadge.Location = new Point(349, 10);
        lblMemberCountBadge.Margin = new Padding(0, 10, 0, 0);
        lblMemberCountBadge.Name = "lblMemberCountBadge";
        lblMemberCountBadge.Size = new Size(92, 25);
        lblMemberCountBadge.TabIndex = 1;
        lblMemberCountBadge.Text = "Loading...";
        // 
        // membersActionRow
        // 
        membersActionRow.AutoScroll = true;
        membersActionRow.Controls.Add(btnMemberRefresh);
        membersActionRow.Controls.Add(btnDeleteMember);
        membersActionRow.Controls.Add(btnToggleMemberStatus);
        membersActionRow.Controls.Add(btnEditMember);
        membersActionRow.Controls.Add(btnAddMember);
        membersActionRow.Dock = DockStyle.Fill;
        membersActionRow.FlowDirection = FlowDirection.RightToLeft;
        membersActionRow.Location = new Point(534, 3);
        membersActionRow.Name = "membersActionRow";
        membersActionRow.Size = new Size(645, 59);
        membersActionRow.TabIndex = 1;
        membersActionRow.WrapContents = false;
        // 
        // btnMemberRefresh
        // 
        btnMemberRefresh.BackColor = Color.FromArgb(241, 245, 249);
        btnMemberRefresh.FlatAppearance.BorderSize = 0;
        btnMemberRefresh.FlatStyle = FlatStyle.Flat;
        btnMemberRefresh.ForeColor = Color.FromArgb(51, 65, 85);
        btnMemberRefresh.Location = new Point(552, 2);
        btnMemberRefresh.Margin = new Padding(3, 2, 3, 2);
        btnMemberRefresh.Name = "btnMemberRefresh";
        btnMemberRefresh.Size = new Size(90, 34);
        btnMemberRefresh.TabIndex = 0;
        btnMemberRefresh.Text = "Refresh";
        btnMemberRefresh.UseVisualStyleBackColor = false;
        // 
        // btnDeleteMember
        // 
        btnDeleteMember.BackColor = Color.FromArgb(239, 68, 68);
        btnDeleteMember.Enabled = false;
        btnDeleteMember.FlatAppearance.BorderSize = 0;
        btnDeleteMember.FlatStyle = FlatStyle.Flat;
        btnDeleteMember.ForeColor = Color.White;
        btnDeleteMember.Location = new Point(456, 2);
        btnDeleteMember.Margin = new Padding(3, 2, 3, 2);
        btnDeleteMember.Name = "btnDeleteMember";
        btnDeleteMember.Size = new Size(90, 34);
        btnDeleteMember.TabIndex = 1;
        btnDeleteMember.Text = "Delete";
        btnDeleteMember.UseVisualStyleBackColor = false;
        // 
        // btnToggleMemberStatus
        // 
        btnToggleMemberStatus.BackColor = Color.FromArgb(71, 85, 105);
        btnToggleMemberStatus.Enabled = false;
        btnToggleMemberStatus.FlatAppearance.BorderSize = 0;
        btnToggleMemberStatus.FlatStyle = FlatStyle.Flat;
        btnToggleMemberStatus.ForeColor = Color.White;
        btnToggleMemberStatus.Location = new Point(355, 2);
        btnToggleMemberStatus.Margin = new Padding(3, 2, 3, 2);
        btnToggleMemberStatus.Name = "btnToggleMemberStatus";
        btnToggleMemberStatus.Size = new Size(95, 34);
        btnToggleMemberStatus.TabIndex = 2;
        btnToggleMemberStatus.Text = "Status";
        btnToggleMemberStatus.UseVisualStyleBackColor = false;
        // 
        // btnEditMember
        // 
        btnEditMember.BackColor = Color.FromArgb(245, 158, 11);
        btnEditMember.Enabled = false;
        btnEditMember.FlatAppearance.BorderSize = 0;
        btnEditMember.FlatStyle = FlatStyle.Flat;
        btnEditMember.ForeColor = Color.White;
        btnEditMember.Location = new Point(234, 2);
        btnEditMember.Margin = new Padding(3, 2, 3, 2);
        btnEditMember.Name = "btnEditMember";
        btnEditMember.Size = new Size(115, 34);
        btnEditMember.TabIndex = 3;
        btnEditMember.Text = "Edit Member";
        btnEditMember.UseVisualStyleBackColor = false;
        // 
        // btnAddMember
        // 
        btnAddMember.BackColor = Color.FromArgb(16, 185, 129);
        btnAddMember.FlatAppearance.BorderSize = 0;
        btnAddMember.FlatStyle = FlatStyle.Flat;
        btnAddMember.ForeColor = Color.White;
        btnAddMember.Location = new Point(83, 2);
        btnAddMember.Margin = new Padding(3, 2, 3, 2);
        btnAddMember.Name = "btnAddMember";
        btnAddMember.Size = new Size(145, 34);
        btnAddMember.TabIndex = 4;
        btnAddMember.Text = "Register Member";
        btnAddMember.UseVisualStyleBackColor = false;
        // 
        // membersGridPanel
        // 
        membersGridPanel.Controls.Add(dgvMembers);
        membersGridPanel.Dock = DockStyle.Fill;
        membersGridPanel.Location = new Point(0, 160);
        membersGridPanel.Margin = new Padding(0);
        membersGridPanel.Name = "membersGridPanel";
        membersGridPanel.Padding = new Padding(15, 10, 15, 10);
        membersGridPanel.Size = new Size(1212, 410);
        membersGridPanel.TabIndex = 1;
        // 
        // dgvMembers
        // 
        dgvMembers.AllowUserToAddRows = false;
        dgvMembers.AllowUserToDeleteRows = false;
        dataGridViewCellStyle4.BackColor = Color.FromArgb(241, 245, 249);
        dgvMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
        dgvMembers.BackgroundColor = Color.White;
        dgvMembers.BorderStyle = BorderStyle.None;
        dgvMembers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle5.BackColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.25F, FontStyle.Bold);
        dataGridViewCellStyle5.ForeColor = Color.White;
        dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
        dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
        dgvMembers.ColumnHeadersHeight = 48;
        dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = SystemColors.Window;
        dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.25F);
        dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(199, 210, 254);
        dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
        dgvMembers.DefaultCellStyle = dataGridViewCellStyle6;
        dgvMembers.Dock = DockStyle.Fill;
        dgvMembers.EnableHeadersVisualStyles = false;
        dgvMembers.GridColor = Color.FromArgb(241, 245, 249);
        dgvMembers.Location = new Point(15, 10);
        dgvMembers.MultiSelect = false;
        dgvMembers.Name = "dgvMembers";
        dgvMembers.ReadOnly = true;
        dgvMembers.RowHeadersVisible = false;
        dgvMembers.RowHeadersWidth = 62;
        dgvMembers.RowTemplate.Height = 42;
        dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvMembers.Size = new Size(1182, 390);
        dgvMembers.TabIndex = 0;
        // 
        // pageCirculation
        // 
        pageCirculation.BackColor = Color.FromArgb(248, 250, 252);
        pageCirculation.Controls.Add(loansPageLayout);
        pageCirculation.Location = new Point(4, 44);
        pageCirculation.Name = "pageCirculation";
        pageCirculation.Size = new Size(1212, 570);
        pageCirculation.TabIndex = 3;
        pageCirculation.Text = "Circulation & Loans";
        // 
        // loansPageLayout
        // 
        loansPageLayout.ColumnCount = 1;
        loansPageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        loansPageLayout.Controls.Add(loansHeader, 0, 0);
        loansPageLayout.Controls.Add(loansGridPanel, 0, 1);
        loansPageLayout.Dock = DockStyle.Fill;
        loansPageLayout.Location = new Point(0, 0);
        loansPageLayout.Margin = new Padding(0);
        loansPageLayout.Name = "loansPageLayout";
        loansPageLayout.RowCount = 2;
        loansPageLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
        loansPageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        loansPageLayout.Size = new Size(1212, 570);
        loansPageLayout.TabIndex = 0;
        // 
        // loansHeader
        // 
        loansHeader.BackColor = Color.White;
        loansHeader.Controls.Add(loansHeaderLayout);
        loansHeader.Dock = DockStyle.Fill;
        loansHeader.Location = new Point(0, 0);
        loansHeader.Margin = new Padding(0);
        loansHeader.Name = "loansHeader";
        loansHeader.Padding = new Padding(15, 10, 15, 10);
        loansHeader.Size = new Size(1212, 126);
        loansHeader.TabIndex = 0;
        // 
        // loansHeaderLayout
        // 
        loansHeaderLayout.ColumnCount = 1;
        loansHeaderLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        loansHeaderLayout.Controls.Add(loansTopRow, 0, 0);
        loansHeaderLayout.Controls.Add(loansFilterRow, 0, 1);
        loansHeaderLayout.Dock = DockStyle.Fill;
        loansHeaderLayout.Location = new Point(15, 10);
        loansHeaderLayout.Name = "loansHeaderLayout";
        loansHeaderLayout.RowCount = 2;
        loansHeaderLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        loansHeaderLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
        loansHeaderLayout.Size = new Size(1182, 106);
        loansHeaderLayout.TabIndex = 0;
        // 
        // loansTopRow
        // 
        loansTopRow.ColumnCount = 2;
        loansTopRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
        loansTopRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
        loansTopRow.Controls.Add(loansTitleRow, 0, 0);
        loansTopRow.Controls.Add(loansActionRow, 1, 0);
        loansTopRow.Dock = DockStyle.Fill;
        loansTopRow.Location = new Point(0, 0);
        loansTopRow.Margin = new Padding(0);
        loansTopRow.Name = "loansTopRow";
        loansTopRow.RowCount = 1;
        loansTopRow.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        loansTopRow.Size = new Size(1182, 48);
        loansTopRow.TabIndex = 0;
        // 
        // loansTitleRow
        // 
        loansTitleRow.AutoScroll = true;
        loansTitleRow.Controls.Add(lblLoansHeading);
        loansTitleRow.Controls.Add(lblLoanCountBadge);
        loansTitleRow.Dock = DockStyle.Fill;
        loansTitleRow.Location = new Point(3, 3);
        loansTitleRow.Name = "loansTitleRow";
        loansTitleRow.Size = new Size(407, 42);
        loansTitleRow.TabIndex = 0;
        loansTitleRow.WrapContents = false;
        // 
        // lblLoansHeading
        // 
        lblLoansHeading.AutoSize = true;
        lblLoansHeading.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblLoansHeading.ForeColor = Color.FromArgb(15, 23, 42);
        lblLoansHeading.Location = new Point(0, 7);
        lblLoansHeading.Margin = new Padding(0, 7, 8, 0);
        lblLoansHeading.Name = "lblLoansHeading";
        lblLoansHeading.Size = new Size(274, 30);
        lblLoansHeading.TabIndex = 0;
        lblLoansHeading.Text = "Circulation & Loan Records";
        // 
        // lblLoanCountBadge
        // 
        lblLoanCountBadge.AutoSize = true;
        lblLoanCountBadge.ForeColor = Color.FromArgb(100, 116, 139);
        lblLoanCountBadge.Location = new Point(282, 10);
        lblLoanCountBadge.Margin = new Padding(0, 10, 0, 0);
        lblLoanCountBadge.Name = "lblLoanCountBadge";
        lblLoanCountBadge.Size = new Size(92, 25);
        lblLoanCountBadge.TabIndex = 1;
        lblLoanCountBadge.Text = "Loading...";
        // 
        // loansActionRow
        // 
        loansActionRow.AutoScroll = true;
        loansActionRow.Controls.Add(btnLoanRefresh);
        loansActionRow.Controls.Add(btnLoanExportCsv);
        loansActionRow.Controls.Add(btnRecalcFines);
        loansActionRow.Controls.Add(btnReturnBook);
        loansActionRow.Controls.Add(btnIssueLoan);
        loansActionRow.Dock = DockStyle.Fill;
        loansActionRow.FlowDirection = FlowDirection.RightToLeft;
        loansActionRow.Location = new Point(416, 3);
        loansActionRow.Name = "loansActionRow";
        loansActionRow.Size = new Size(763, 42);
        loansActionRow.TabIndex = 1;
        loansActionRow.WrapContents = false;
        // 
        // btnLoanRefresh
        // 
        btnLoanRefresh.BackColor = Color.FromArgb(59, 130, 246);
        btnLoanRefresh.Cursor = Cursors.Hand;
        btnLoanRefresh.FlatAppearance.BorderSize = 0;
        btnLoanRefresh.FlatStyle = FlatStyle.Flat;
        btnLoanRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnLoanRefresh.ForeColor = Color.White;
        btnLoanRefresh.Location = new Point(670, 2);
        btnLoanRefresh.Margin = new Padding(3, 2, 3, 2);
        btnLoanRefresh.Name = "btnLoanRefresh";
        btnLoanRefresh.Size = new Size(90, 34);
        btnLoanRefresh.TabIndex = 0;
        btnLoanRefresh.Text = "Refresh";
        btnLoanRefresh.UseVisualStyleBackColor = false;
        // 
        // btnLoanExportCsv
        // 
        btnLoanExportCsv.BackColor = Color.FromArgb(16, 185, 129);
        btnLoanExportCsv.Cursor = Cursors.Hand;
        btnLoanExportCsv.FlatAppearance.BorderSize = 0;
        btnLoanExportCsv.FlatStyle = FlatStyle.Flat;
        btnLoanExportCsv.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnLoanExportCsv.ForeColor = Color.White;
        btnLoanExportCsv.Location = new Point(589, 2);
        btnLoanExportCsv.Margin = new Padding(3, 2, 3, 2);
        btnLoanExportCsv.Name = "btnLoanExportCsv";
        btnLoanExportCsv.Size = new Size(75, 34);
        btnLoanExportCsv.TabIndex = 1;
        btnLoanExportCsv.Text = "Save";
        btnLoanExportCsv.UseVisualStyleBackColor = false;
        // 
        // btnRecalcFines
        // 
        btnRecalcFines.BackColor = Color.FromArgb(245, 158, 11);
        btnRecalcFines.Cursor = Cursors.Hand;
        btnRecalcFines.FlatAppearance.BorderSize = 0;
        btnRecalcFines.FlatStyle = FlatStyle.Flat;
        btnRecalcFines.ForeColor = Color.FromArgb(255, 255, 255);
        btnRecalcFines.Location = new Point(463, 2);
        btnRecalcFines.Margin = new Padding(3, 2, 3, 2);
        btnRecalcFines.Name = "btnRecalcFines";
        btnRecalcFines.Size = new Size(120, 34);
        btnRecalcFines.TabIndex = 2;
        btnRecalcFines.Text = "Recalc Fines";
        btnRecalcFines.UseVisualStyleBackColor = false;
        // 
        // btnReturnBook
        // 
        btnReturnBook.BackColor = Color.FromArgb(79, 70, 229);
        btnReturnBook.Cursor = Cursors.Hand;
        btnReturnBook.Enabled = false;
        btnReturnBook.FlatAppearance.BorderSize = 0;
        btnReturnBook.FlatStyle = FlatStyle.Flat;
        btnReturnBook.ForeColor = Color.FromArgb(255, 255, 255);
        btnReturnBook.Location = new Point(342, 2);
        btnReturnBook.Margin = new Padding(3, 2, 3, 2);
        btnReturnBook.Name = "btnReturnBook";
        btnReturnBook.Size = new Size(115, 34);
        btnReturnBook.TabIndex = 3;
        btnReturnBook.Text = "Return Book";
        btnReturnBook.UseVisualStyleBackColor = false;
        // 
        // btnIssueLoan
        // 
        btnIssueLoan.BackColor = Color.FromArgb(16, 185, 129);
        btnIssueLoan.Cursor = Cursors.Hand;
        btnIssueLoan.FlatAppearance.BorderSize = 0;
        btnIssueLoan.FlatStyle = FlatStyle.Flat;
        btnIssueLoan.ForeColor = Color.FromArgb(255, 255, 255);
        btnIssueLoan.Location = new Point(221, 2);
        btnIssueLoan.Margin = new Padding(3, 2, 3, 2);
        btnIssueLoan.Name = "btnIssueLoan";
        btnIssueLoan.Size = new Size(115, 34);
        btnIssueLoan.TabIndex = 4;
        btnIssueLoan.Text = "Borrow Book";
        btnIssueLoan.UseVisualStyleBackColor = false;
        // 
        // loansFilterRow
        // 
        loansFilterRow.AutoScroll = true;
        loansFilterRow.Controls.Add(lblLoansSearch);
        loansFilterRow.Controls.Add(txtLoanSearch);
        loansFilterRow.Controls.Add(lblLoansStatus);
        loansFilterRow.Controls.Add(cmbLoanStatusFilter);
        loansFilterRow.Controls.Add(btnLoanResetFilters);
        loansFilterRow.Dock = DockStyle.Fill;
        loansFilterRow.Location = new Point(3, 51);
        loansFilterRow.Name = "loansFilterRow";
        loansFilterRow.Size = new Size(1176, 52);
        loansFilterRow.TabIndex = 1;
        loansFilterRow.WrapContents = false;
        // 
        // lblLoansSearch
        // 
        lblLoansSearch.AutoSize = true;
        lblLoansSearch.Location = new Point(0, 9);
        lblLoansSearch.Margin = new Padding(0, 9, 7, 0);
        lblLoansSearch.Name = "lblLoansSearch";
        lblLoansSearch.Size = new Size(73, 25);
        lblLoansSearch.TabIndex = 0;
        lblLoansSearch.Text = "Search:";
        // 
        // txtLoanSearch
        // 
        txtLoanSearch.Location = new Point(80, 5);
        txtLoanSearch.Margin = new Padding(0, 5, 16, 0);
        txtLoanSearch.Name = "txtLoanSearch";
        txtLoanSearch.Size = new Size(230, 33);
        txtLoanSearch.TabIndex = 1;
        // 
        // lblLoansStatus
        // 
        lblLoansStatus.AutoSize = true;
        lblLoansStatus.Location = new Point(326, 9);
        lblLoansStatus.Margin = new Padding(0, 9, 7, 0);
        lblLoansStatus.Name = "lblLoansStatus";
        lblLoansStatus.Size = new Size(66, 25);
        lblLoansStatus.TabIndex = 2;
        lblLoansStatus.Text = "Status:";
        // 
        // cmbLoanStatusFilter
        // 
        cmbLoanStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbLoanStatusFilter.Items.AddRange(new object[] { "All Loans", "Active Only", "Overdue Only", "Returned" });
        cmbLoanStatusFilter.Location = new Point(399, 5);
        cmbLoanStatusFilter.Margin = new Padding(0, 5, 16, 0);
        cmbLoanStatusFilter.Name = "cmbLoanStatusFilter";
        cmbLoanStatusFilter.Size = new Size(165, 33);
        cmbLoanStatusFilter.TabIndex = 3;
        // 
        // btnLoanResetFilters
        // 
        btnLoanResetFilters.BackColor = Color.FromArgb(241, 245, 249);
        btnLoanResetFilters.FlatStyle = FlatStyle.Flat;
        btnLoanResetFilters.Location = new Point(580, 3);
        btnLoanResetFilters.Margin = new Padding(0, 3, 0, 0);
        btnLoanResetFilters.Name = "btnLoanResetFilters";
        btnLoanResetFilters.Size = new Size(110, 30);
        btnLoanResetFilters.TabIndex = 4;
        btnLoanResetFilters.Text = "Reset Filters";
        btnLoanResetFilters.UseVisualStyleBackColor = false;
        // 
        // loansGridPanel
        // 
        loansGridPanel.Controls.Add(dgvLoans);
        loansGridPanel.Dock = DockStyle.Fill;
        loansGridPanel.Location = new Point(0, 126);
        loansGridPanel.Margin = new Padding(0);
        loansGridPanel.Name = "loansGridPanel";
        loansGridPanel.Padding = new Padding(15, 10, 15, 10);
        loansGridPanel.Size = new Size(1212, 444);
        loansGridPanel.TabIndex = 1;
        // 
        // dgvLoans
        // 
        dgvLoans.AllowUserToAddRows = false;
        dgvLoans.AllowUserToDeleteRows = false;
        dataGridViewCellStyle7.BackColor = Color.FromArgb(241, 245, 249);
        dgvLoans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
        dgvLoans.BackgroundColor = Color.White;
        dgvLoans.BorderStyle = BorderStyle.None;
        dgvLoans.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle8.BackColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle8.Font = new Font("Segoe UI", 9.25F, FontStyle.Bold);
        dataGridViewCellStyle8.ForeColor = Color.White;
        dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
        dgvLoans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
        dgvLoans.ColumnHeadersHeight = 48;
        dgvLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle9.BackColor = SystemColors.Window;
        dataGridViewCellStyle9.Font = new Font("Segoe UI", 9.25F);
        dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(199, 210, 254);
        dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
        dgvLoans.DefaultCellStyle = dataGridViewCellStyle9;
        dgvLoans.Dock = DockStyle.Fill;
        dgvLoans.EnableHeadersVisualStyles = false;
        dgvLoans.GridColor = Color.FromArgb(241, 245, 249);
        dgvLoans.Location = new Point(15, 10);
        dgvLoans.MultiSelect = false;
        dgvLoans.Name = "dgvLoans";
        dgvLoans.ReadOnly = true;
        dgvLoans.RowHeadersVisible = false;
        dgvLoans.RowHeadersWidth = 62;
        dgvLoans.RowTemplate.Height = 42;
        dgvLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvLoans.Size = new Size(1182, 424);
        dgvLoans.TabIndex = 0;
        // 
        // pageReports
        // 
        pageReports.BackColor = Color.FromArgb(248, 250, 252);
        pageReports.Controls.Add(reportsPageLayout);
        pageReports.Location = new Point(4, 44);
        pageReports.Name = "pageReports";
        pageReports.Size = new Size(1212, 570);
        pageReports.TabIndex = 4;
        pageReports.Text = "Reports & Analytics";
        // 
        // reportsPageLayout
        // 
        reportsPageLayout.ColumnCount = 1;
        reportsPageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        reportsPageLayout.Controls.Add(reportsToolbar, 0, 0);
        reportsPageLayout.Controls.Add(reportsContentLayout, 0, 1);
        reportsPageLayout.Dock = DockStyle.Fill;
        reportsPageLayout.Location = new Point(0, 0);
        reportsPageLayout.Margin = new Padding(0);
        reportsPageLayout.Name = "reportsPageLayout";
        reportsPageLayout.RowCount = 2;
        reportsPageLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
        reportsPageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        reportsPageLayout.Size = new Size(1212, 570);
        reportsPageLayout.TabIndex = 0;
        // 
        // reportsToolbar
        // 
        reportsToolbar.AutoScroll = true;
        reportsToolbar.BackColor = Color.FromArgb(241, 245, 249);
        reportsToolbar.Controls.Add(btnReportRefresh);
        reportsToolbar.Controls.Add(btnReportExportTxt);
        reportsToolbar.Controls.Add(btnReportViewFull);
        reportsToolbar.Dock = DockStyle.Fill;
        reportsToolbar.Location = new Point(0, 0);
        reportsToolbar.Margin = new Padding(0);
        reportsToolbar.Name = "reportsToolbar";
        reportsToolbar.Padding = new Padding(15, 9, 15, 7);
        reportsToolbar.Size = new Size(1212, 58);
        reportsToolbar.TabIndex = 0;
        reportsToolbar.WrapContents = false;
        // 
        // btnReportRefresh
        // 
        btnReportRefresh.BackColor = Color.FromArgb(99, 102, 241);
        btnReportRefresh.Cursor = Cursors.Hand;
        btnReportRefresh.FlatAppearance.BorderSize = 0;
        btnReportRefresh.FlatStyle = FlatStyle.Flat;
        btnReportRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnReportRefresh.ForeColor = Color.White;
        btnReportRefresh.Location = new Point(15, 9);
        btnReportRefresh.Margin = new Padding(0, 0, 10, 0);
        btnReportRefresh.Name = "btnReportRefresh";
        btnReportRefresh.Size = new Size(165, 36);
        btnReportRefresh.TabIndex = 0;
        btnReportRefresh.Text = "Refresh";
        btnReportRefresh.UseVisualStyleBackColor = false;
        // 
        // btnReportExportTxt
        // 
        btnReportExportTxt.BackColor = Color.FromArgb(16, 185, 129);
        btnReportExportTxt.Cursor = Cursors.Hand;
        btnReportExportTxt.FlatAppearance.BorderSize = 0;
        btnReportExportTxt.FlatStyle = FlatStyle.Flat;
        btnReportExportTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnReportExportTxt.ForeColor = Color.White;
        btnReportExportTxt.Location = new Point(190, 9);
        btnReportExportTxt.Margin = new Padding(0);
        btnReportExportTxt.Name = "btnReportExportTxt";
        btnReportExportTxt.Size = new Size(180, 36);
        btnReportExportTxt.TabIndex = 1;
        btnReportExportTxt.Text = "Save Report";
        btnReportExportTxt.UseVisualStyleBackColor = false;
        // 
        // btnReportViewFull
        // 
        btnReportViewFull.BackColor = Color.FromArgb(51, 65, 85);
        btnReportViewFull.Cursor = Cursors.Hand;
        btnReportViewFull.FlatAppearance.BorderSize = 0;
        btnReportViewFull.FlatStyle = FlatStyle.Flat;
        btnReportViewFull.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnReportViewFull.ForeColor = Color.White;
        btnReportViewFull.Location = new Point(380, 9);
        btnReportViewFull.Margin = new Padding(10, 0, 0, 0);
        btnReportViewFull.Name = "btnReportViewFull";
        btnReportViewFull.Size = new Size(170, 36);
        btnReportViewFull.TabIndex = 2;
        btnReportViewFull.Text = "View Full Report";
        btnReportViewFull.UseVisualStyleBackColor = false;
        // 
        // reportsContentLayout
        // 
        reportsContentLayout.BackColor = Color.FromArgb(248, 250, 252);
        reportsContentLayout.ColumnCount = 1;
        reportsContentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        reportsContentLayout.Controls.Add(reportsSummaryGroup, 0, 0);
        reportsContentLayout.Controls.Add(reportsTopBooksGroup, 0, 1);
        reportsContentLayout.Dock = DockStyle.Fill;
        reportsContentLayout.Location = new Point(0, 58);
        reportsContentLayout.Margin = new Padding(0);
        reportsContentLayout.Name = "reportsContentLayout";
        reportsContentLayout.Padding = new Padding(12, 10, 12, 10);
        reportsContentLayout.RowCount = 2;
        reportsContentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 68F));
        reportsContentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
        reportsContentLayout.Size = new Size(1212, 512);
        reportsContentLayout.TabIndex = 1;
        // 
        // reportsSummaryGroup
        // 
        reportsSummaryGroup.Controls.Add(txtReportOutput);
        reportsSummaryGroup.Dock = DockStyle.Fill;
        reportsSummaryGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        reportsSummaryGroup.Location = new Point(12, 10);
        reportsSummaryGroup.Margin = new Padding(0, 0, 0, 8);
        reportsSummaryGroup.Name = "reportsSummaryGroup";
        reportsSummaryGroup.Padding = new Padding(10);
        reportsSummaryGroup.Size = new Size(1188, 326);
        reportsSummaryGroup.TabIndex = 0;
        reportsSummaryGroup.TabStop = false;
        reportsSummaryGroup.Text = "Executive Summary Report";
        // 
        // txtReportOutput
        // 
        txtReportOutput.BackColor = Color.White;
        txtReportOutput.Dock = DockStyle.Fill;
        txtReportOutput.Font = new Font("Consolas", 9.5F);
        txtReportOutput.Location = new Point(10, 34);
        txtReportOutput.Multiline = true;
        txtReportOutput.Name = "txtReportOutput";
        txtReportOutput.ReadOnly = true;
        txtReportOutput.ScrollBars = ScrollBars.Vertical;
        txtReportOutput.Size = new Size(1168, 282);
        txtReportOutput.TabIndex = 0;
        // 
        // reportsTopBooksGroup
        // 
        reportsTopBooksGroup.Controls.Add(dgvTopBooks);
        reportsTopBooksGroup.Dock = DockStyle.Fill;
        reportsTopBooksGroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        reportsTopBooksGroup.Location = new Point(12, 344);
        reportsTopBooksGroup.Margin = new Padding(0);
        reportsTopBooksGroup.Name = "reportsTopBooksGroup";
        reportsTopBooksGroup.Padding = new Padding(10);
        reportsTopBooksGroup.Size = new Size(1188, 158);
        reportsTopBooksGroup.TabIndex = 1;
        reportsTopBooksGroup.TabStop = false;
        reportsTopBooksGroup.Text = "Most Frequently Borrowed Books (Top Circulation)";
        // 
        // dgvTopBooks
        // 
        dgvTopBooks.AllowUserToAddRows = false;
        dgvTopBooks.AllowUserToDeleteRows = false;
        dataGridViewCellStyle10.BackColor = Color.FromArgb(241, 245, 249);
        dgvTopBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
        dgvTopBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTopBooks.BackgroundColor = Color.White;
        dgvTopBooks.BorderStyle = BorderStyle.None;
        dgvTopBooks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle11.BackColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle11.Font = new Font("Segoe UI", 9.25F, FontStyle.Bold);
        dataGridViewCellStyle11.ForeColor = Color.White;
        dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
        dgvTopBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
        dgvTopBooks.ColumnHeadersHeight = 44;
        dgvTopBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle12.BackColor = SystemColors.Window;
        dataGridViewCellStyle12.Font = new Font("Segoe UI", 9.25F);
        dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(199, 210, 254);
        dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
        dgvTopBooks.DefaultCellStyle = dataGridViewCellStyle12;
        dgvTopBooks.Dock = DockStyle.Fill;
        dgvTopBooks.EnableHeadersVisualStyles = false;
        dgvTopBooks.GridColor = Color.FromArgb(241, 245, 249);
        dgvTopBooks.Location = new Point(10, 34);
        dgvTopBooks.MultiSelect = false;
        dgvTopBooks.Name = "dgvTopBooks";
        dgvTopBooks.ReadOnly = true;
        dgvTopBooks.RowHeadersVisible = false;
        dgvTopBooks.RowHeadersWidth = 62;
        dgvTopBooks.RowTemplate.Height = 36;
        dgvTopBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTopBooks.Size = new Size(1168, 114);
        dgvTopBooks.TabIndex = 0;
        // 
        // pageNetwork
        // 
        pageNetwork.BackColor = Color.FromArgb(248, 250, 252);
        pageNetwork.Controls.Add(networkSplit);
        pageNetwork.Location = new Point(4, 44);
        pageNetwork.Name = "pageNetwork";
        pageNetwork.Size = new Size(1212, 570);
        pageNetwork.TabIndex = 5;
        pageNetwork.Text = "Network & TCP Services";
        // 
        // networkSplit
        // 
        networkSplit.Dock = DockStyle.Fill;
        networkSplit.Location = new Point(0, 0);
        networkSplit.Name = "networkSplit";
        // 
        // networkSplit.Panel1
        // 
        networkSplit.Panel1.Controls.Add(networkServerGroup);
        // 
        // networkSplit.Panel2
        // 
        networkSplit.Panel2.Controls.Add(networkClientGroup);
        networkSplit.Size = new Size(1212, 570);
        networkSplit.SplitterDistance = 606;
        networkSplit.TabIndex = 0;
        // 
        // networkServerGroup
        // 
        networkServerGroup.Controls.Add(txtServerLogs);
        networkServerGroup.Controls.Add(networkServerActions);
        networkServerGroup.Dock = DockStyle.Fill;
        networkServerGroup.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        networkServerGroup.Location = new Point(0, 0);
        networkServerGroup.Name = "networkServerGroup";
        networkServerGroup.Padding = new Padding(12);
        networkServerGroup.Size = new Size(606, 570);
        networkServerGroup.TabIndex = 0;
        networkServerGroup.TabStop = false;
        networkServerGroup.Text = "Embedded TCP Network Server (Port 8888)";
        // 
        // txtServerLogs
        // 
        txtServerLogs.BackColor = Color.FromArgb(15, 23, 42);
        txtServerLogs.Dock = DockStyle.Fill;
        txtServerLogs.Font = new Font("Consolas", 9F);
        txtServerLogs.ForeColor = Color.White;
        txtServerLogs.Location = new Point(12, 90);
        txtServerLogs.Multiline = true;
        txtServerLogs.Name = "txtServerLogs";
        txtServerLogs.ReadOnly = true;
        txtServerLogs.ScrollBars = ScrollBars.Vertical;
        txtServerLogs.Size = new Size(582, 468);
        txtServerLogs.TabIndex = 0;
        // 
        // networkServerActions
        // 
        networkServerActions.Controls.Add(lblServerStatus);
        networkServerActions.Controls.Add(btnToggleServer);
        networkServerActions.Controls.Add(btnClearServerLogs);
        networkServerActions.Dock = DockStyle.Top;
        networkServerActions.Location = new Point(12, 38);
        networkServerActions.Name = "networkServerActions";
        networkServerActions.Size = new Size(582, 52);
        networkServerActions.TabIndex = 1;
        networkServerActions.WrapContents = false;
        // 
        // lblServerStatus
        // 
        lblServerStatus.AutoSize = true;
        lblServerStatus.ForeColor = Color.FromArgb(16, 185, 129);
        lblServerStatus.Location = new Point(2, 14);
        lblServerStatus.Margin = new Padding(2, 14, 18, 0);
        lblServerStatus.Name = "lblServerStatus";
        lblServerStatus.Size = new Size(185, 25);
        lblServerStatus.TabIndex = 0;
        lblServerStatus.Text = "Status: Initializing...";
        // 
        // btnToggleServer
        // 
        btnToggleServer.BackColor = Color.FromArgb(239, 68, 68);
        btnToggleServer.FlatStyle = FlatStyle.Flat;
        btnToggleServer.ForeColor = Color.White;
        btnToggleServer.Location = new Point(205, 4);
        btnToggleServer.Margin = new Padding(0, 4, 10, 0);
        btnToggleServer.Name = "btnToggleServer";
        btnToggleServer.Size = new Size(115, 34);
        btnToggleServer.TabIndex = 1;
        btnToggleServer.Text = "Stop Server";
        btnToggleServer.UseVisualStyleBackColor = false;
        // 
        // btnClearServerLogs
        // 
        btnClearServerLogs.Location = new Point(330, 4);
        btnClearServerLogs.Margin = new Padding(0, 4, 0, 0);
        btnClearServerLogs.Name = "btnClearServerLogs";
        btnClearServerLogs.Size = new Size(100, 34);
        btnClearServerLogs.TabIndex = 2;
        btnClearServerLogs.Text = "Clear Logs";
        // 
        // networkClientGroup
        // 
        networkClientGroup.Controls.Add(txtClientResponse);
        networkClientGroup.Controls.Add(networkClientInput);
        networkClientGroup.Controls.Add(lblNetworkHelp);
        networkClientGroup.Dock = DockStyle.Fill;
        networkClientGroup.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        networkClientGroup.Location = new Point(0, 0);
        networkClientGroup.Name = "networkClientGroup";
        networkClientGroup.Padding = new Padding(12);
        networkClientGroup.Size = new Size(602, 570);
        networkClientGroup.TabIndex = 0;
        networkClientGroup.TabStop = false;
        networkClientGroup.Text = "Remote TCP Query Client Console";
        // 
        // txtClientResponse
        // 
        txtClientResponse.BackColor = Color.White;
        txtClientResponse.Dock = DockStyle.Fill;
        txtClientResponse.Font = new Font("Consolas", 9F);
        txtClientResponse.Location = new Point(12, 152);
        txtClientResponse.Multiline = true;
        txtClientResponse.Name = "txtClientResponse";
        txtClientResponse.ReadOnly = true;
        txtClientResponse.ScrollBars = ScrollBars.Vertical;
        txtClientResponse.Size = new Size(578, 406);
        txtClientResponse.TabIndex = 0;
        // 
        // networkClientInput
        // 
        networkClientInput.ColumnCount = 2;
        networkClientInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        networkClientInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
        networkClientInput.Controls.Add(txtClientCommand, 0, 0);
        networkClientInput.Controls.Add(btnSendClientCommand, 1, 0);
        networkClientInput.Dock = DockStyle.Top;
        networkClientInput.Location = new Point(12, 104);
        networkClientInput.Name = "networkClientInput";
        networkClientInput.RowCount = 1;
        networkClientInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        networkClientInput.Size = new Size(578, 48);
        networkClientInput.TabIndex = 1;
        // 
        // txtClientCommand
        // 
        txtClientCommand.Dock = DockStyle.Fill;
        txtClientCommand.Location = new Point(0, 7);
        txtClientCommand.Margin = new Padding(0, 7, 8, 7);
        txtClientCommand.Name = "txtClientCommand";
        txtClientCommand.Size = new Size(465, 33);
        txtClientCommand.TabIndex = 0;
        txtClientCommand.Text = "SEARCH Clean Code";
        // 
        // btnSendClientCommand
        // 
        btnSendClientCommand.BackColor = Color.FromArgb(99, 102, 241);
        btnSendClientCommand.Dock = DockStyle.Fill;
        btnSendClientCommand.FlatStyle = FlatStyle.Flat;
        btnSendClientCommand.ForeColor = Color.White;
        btnSendClientCommand.Location = new Point(476, 3);
        btnSendClientCommand.Name = "btnSendClientCommand";
        btnSendClientCommand.Size = new Size(99, 42);
        btnSendClientCommand.TabIndex = 1;
        btnSendClientCommand.Text = "Send";
        btnSendClientCommand.UseVisualStyleBackColor = false;
        // 
        // lblNetworkHelp
        // 
        lblNetworkHelp.Dock = DockStyle.Top;
        lblNetworkHelp.ForeColor = Color.FromArgb(71, 85, 105);
        lblNetworkHelp.Location = new Point(12, 38);
        lblNetworkHelp.Name = "lblNetworkHelp";
        lblNetworkHelp.Size = new Size(578, 66);
        lblNetworkHelp.TabIndex = 2;
        lblNetworkHelp.Text = "Send commands: PING, SEARCH <query>, CHECK <isbn>, STATS, OVERDUE";
        // 
        // statusStrip
        // 
        statusStrip.ImageScalingSize = new Size(24, 24);
        statusStrip.Items.AddRange(new ToolStripItem[] { lblStatusText, lblDbStatus, lblServerIndicator });
        statusStrip.Location = new Point(0, 748);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(1220, 32);
        statusStrip.TabIndex = 1;
        // 
        // lblStatusText
        // 
        lblStatusText.Name = "lblStatusText";
        lblStatusText.Size = new Size(871, 25);
        lblStatusText.Spring = true;
        lblStatusText.Text = "Ready";
        lblStatusText.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblDbStatus
        // 
        lblDbStatus.Name = "lblDbStatus";
        lblDbStatus.Size = new Size(153, 25);
        lblDbStatus.Text = "SQLite Connected";
        // 
        // lblServerIndicator
        // 
        lblServerIndicator.Name = "lblServerIndicator";
        lblServerIndicator.Size = new Size(181, 25);
        lblServerIndicator.Text = "TCP Server: Port 8888";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(248, 250, 252);
        ClientSize = new Size(1220, 780);
        Controls.Add(rootLayout);
        Controls.Add(statusStrip);
        Font = new Font("Segoe UI", 9.25F);
        MinimumSize = new Size(1024, 680);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Digital Library Management System - [Windows Forms]";
        Load += MainForm_Load;
        rootLayout.ResumeLayout(false);
        headerPanel.ResumeLayout(false);
        headerLayout.ResumeLayout(false);
        headerTitles.ResumeLayout(false);
        quickActions.ResumeLayout(false);
        quickActions.PerformLayout();
        tabMain.ResumeLayout(false);
        pageDashboard.ResumeLayout(false);
        dashboardScroll.ResumeLayout(false);
        dashboardLayout.ResumeLayout(false);
        dashboardCards.ResumeLayout(false);
        dashboardCharts.ResumeLayout(false);
        dashboardOverduePanel.ResumeLayout(false);
        dashboardOverdueHeader.ResumeLayout(false);
        dashboardOverdueHeader.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOverdueSummary).EndInit();
        pageBooks.ResumeLayout(false);
        booksPageLayout.ResumeLayout(false);
        booksHeader.ResumeLayout(false);
        booksHeaderLayout.ResumeLayout(false);
        booksTitleRow.ResumeLayout(false);
        booksTitleRow.PerformLayout();
        booksActionRow.ResumeLayout(false);
        booksFilterRow.ResumeLayout(false);
        booksFilterRow.PerformLayout();
        booksGridPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
        pageMembers.ResumeLayout(false);
        membersPageLayout.ResumeLayout(false);
        membersHeader.ResumeLayout(false);
        membersHeaderLayout.ResumeLayout(false);
        membersFilterRow.ResumeLayout(false);
        membersFilterRow.PerformLayout();
        membersTopRow.ResumeLayout(false);
        membersTitleRow.ResumeLayout(false);
        membersTitleRow.PerformLayout();
        membersActionRow.ResumeLayout(false);
        membersGridPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
        pageCirculation.ResumeLayout(false);
        loansPageLayout.ResumeLayout(false);
        loansHeader.ResumeLayout(false);
        loansHeaderLayout.ResumeLayout(false);
        loansTopRow.ResumeLayout(false);
        loansTitleRow.ResumeLayout(false);
        loansTitleRow.PerformLayout();
        loansActionRow.ResumeLayout(false);
        loansFilterRow.ResumeLayout(false);
        loansFilterRow.PerformLayout();
        loansGridPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvLoans).EndInit();
        pageReports.ResumeLayout(false);
        reportsPageLayout.ResumeLayout(false);
        reportsToolbar.ResumeLayout(false);
        reportsContentLayout.ResumeLayout(false);
        reportsSummaryGroup.ResumeLayout(false);
        reportsSummaryGroup.PerformLayout();
        reportsTopBooksGroup.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvTopBooks).EndInit();
        pageNetwork.ResumeLayout(false);
        networkSplit.Panel1.ResumeLayout(false);
        networkSplit.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)networkSplit).EndInit();
        networkSplit.ResumeLayout(false);
        networkServerGroup.ResumeLayout(false);
        networkServerGroup.PerformLayout();
        networkServerActions.ResumeLayout(false);
        networkServerActions.PerformLayout();
        networkClientGroup.ResumeLayout(false);
        networkClientGroup.PerformLayout();
        networkClientInput.ResumeLayout(false);
        networkClientInput.PerformLayout();
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
