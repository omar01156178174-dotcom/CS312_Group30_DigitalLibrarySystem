using LibraryManagementSystem.UI.Dialogs;
using LibraryManagementSystem.UI.Controls;
namespace LibraryManagementSystem.UI;
public partial class MainForm : Form {
    public MainForm() {
        InitializeComponent();
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime) return;
        lblUserInfo.Text = "👤 GUI Preview (Admin)";
        lblDbStatus.Text = "Demo Data (No Database)";
        lblServerIndicator.Text = "HTTP Demo (Offline)";
        lblStatusText.Text = "GUI-only submission • demonstration mode";
        tabMain.SelectedTab = pageDashboard;
        InitPreview();
        btnQuickLogout.Click += (_,_) => Close();
        btnQuickAddBook.Click += (_,_) => OpenBook();
        btnQuickBorrow.Click += (_,_) => OpenBorrow();
        btnAddBook.Click += (_,_) => OpenBook();
        btnEditBook.Click += (_,_) => OpenBook();
        btnDeleteBook.Click += (_,_) => DemoNotice();
        btnBookRefresh.Click += (_,_) => InitPreview();
        btnBookResetFilters.Click += (_,_) => { txtBookSearch.Clear(); cmbBookCategoryFilter.SelectedIndex = 0; };
        btnAddMember.Click += (_,_) => OpenMember();
        btnEditMember.Click += (_,_) => OpenMember();
        btnDeleteMember.Click += (_,_) => DemoNotice();
        btnToggleMemberStatus.Click += (_,_) => DemoNotice();
        btnMemberRefresh.Click += (_,_) => InitPreview();
        btnMemberResetFilters.Click += (_,_) => txtMemberSearch.Clear();
        btnIssueLoan.Click += (_,_) => OpenBorrow();
        btnReturnBook.Click += (_,_) => OpenReturn();
        btnRecalcFines.Click += (_,_) => DemoNotice();
        btnLoanRefresh.Click += (_,_) => InitPreview();
        btnLoanResetFilters.Click += (_,_) => txtLoanSearch.Clear();
        btnReportViewFull.Click += (_,_) => new ExecutiveReportDialog().ShowDialog(this);
        btnReportRefresh.Click += (_,_) => LoadReport();
        btnToggleServer.Click += (_,_) => DemoNotice();
        btnSendClientCommand.Click += (_,_) => txtClientResponse.Text = "GUI-only preview: no HTTP server is running.";
        btnClearServerLogs.Click += (_,_) => txtServerLogs.Clear();
        txtBookSearch.TextChanged += (_,_) => ApplyFilter(dgvBooks,txtBookSearch.Text);
        txtMemberSearch.TextChanged += (_,_) => ApplyFilter(dgvMembers,txtMemberSearch.Text);
        txtLoanSearch.TextChanged += (_,_) => ApplyFilter(dgvLoans,txtLoanSearch.Text);
    }
    private void MainForm_Load(object? sender, EventArgs e) { }
    private void OpenBook() { using var dlg = new BookDialog(); dlg.ShowDialog(this); }
    private void OpenMember() { using var dlg = new MemberDialog(); dlg.ShowDialog(this); }
    private void OpenBorrow() { using var dlg = new BorrowDialog(); dlg.ShowDialog(this); }
    private void OpenReturn() { using var dlg = new ReturnDialog(); dlg.ShowDialog(this); }
    private void DemoNotice() => MessageBox.Show(this,"This is a GUI-only demonstration. Live operations are not included.","GUI Preview",MessageBoxButtons.OK,MessageBoxIcon.Information);
    private static void ApplyFilter(DataGridView grid,string text) {
        if (grid.DataSource is not System.Data.DataTable table) return;
        string escaped=text.Replace("'", "''").Replace("[", "[[]").Replace("%", "[%]");
        try { table.DefaultView.RowFilter=string.IsNullOrWhiteSpace(text)?"":string.Join(" OR ",table.Columns.Cast<System.Data.DataColumn>().Where(c=>c.DataType==typeof(string)).Select(c=>$"Convert([{c.ColumnName}], 'System.String') LIKE '%{escaped}%'")); } catch { table.DefaultView.RowFilter=""; }
    }
    private static System.Data.DataTable DemoTable(params string[] names) {
        var table=new System.Data.DataTable();
        foreach(var n in names) table.Columns.Add(n);
        return table;
    }
    private void InitPreview() {
        // Fake data is deliberate: this build is for demonstrating the Windows Forms UI only.
        var books=DemoTable("ID","Title","Author","ISBN","Category","Available","Total","Rack");
        books.Rows.Add("1","Clean Code","Robert C. Martin","9780132350884","Programming","5","8","A-01");
        books.Rows.Add("2","Design Patterns","Gamma et al.","9780201633610","Software","2","4","A-03");
        books.Rows.Add("3","Introduction to Algorithms","Cormen et al.","9780262046305","Algorithms","3","6","B-02");
        dgvBooks.AutoGenerateColumns=true;dgvBooks.DataSource=books;
        var members=DemoTable("ID","Full Name","Email","Membership","Status","Borrow Limit");
        members.Rows.Add("101","Ahmed Hassan","ahmed@example.com","Student","Active","5");
        members.Rows.Add("102","Mona Ali","mona@example.com","Faculty","Active","8");
        dgvMembers.AutoGenerateColumns=true;dgvMembers.DataSource=members;
        var loans=DemoTable("ID","Book","Member","Borrowed","Due Date","Status");
        loans.Rows.Add("1001","Clean Code","Ahmed Hassan","2026-10-22","2026-11-05","Active");
        loans.Rows.Add("1002","Design Patterns","Mona Ali","2026-10-16","2026-10-30","Overdue");
        dgvLoans.AutoGenerateColumns=true;dgvLoans.DataSource=loans;
        var top=DemoTable("Title","Author","Borrow Count");
        top.Rows.Add("Clean Code","Robert C. Martin","21");
        top.Rows.Add("Design Patterns","Gamma et al.","17");
        dgvTopBooks.AutoGenerateColumns=true;dgvTopBooks.DataSource=top;
        var overdue=DemoTable("Book","Borrower","Days Overdue");overdue.Rows.Add("Design Patterns","Mona Ali","6");
        dgvOverdueSummary.AutoGenerateColumns=true;dgvOverdueSummary.DataSource=overdue;
        chartCategories.SetData(new Dictionary<string,int>{{"Programming",12},{"Algorithms",8},{"Software",10}});
        chartTrends.SetData(new Dictionary<string,int>{{"Jun",8},{"Jul",13},{"Aug",11},{"Sep",17},{"Oct",21}});
        lblBookCountBadge.Text="3 books";lblMemberCountBadge.Text="2 members";lblLoanCountBadge.Text="2 loans";
        lblServerStatus.Text="Offline (GUI Preview)";
        LoadReport();
    }
    private void LoadReport() => txtReportOutput.Text="DIGITAL LIBRARY MANAGEMENT SYSTEM\r\nGUI DESIGN PREVIEW\r\n\r\nTotal Titles: 3\r\nRegistered Members: 2\r\nActive Loans: 2\r\nOverdue Loans: 1\r\n\r\nAll records shown are illustrative; no live database or network is connected.";
}
