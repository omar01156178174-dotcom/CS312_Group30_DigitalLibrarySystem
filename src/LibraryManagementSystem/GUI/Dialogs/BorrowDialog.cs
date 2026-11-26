namespace LibraryManagementSystem.UI.Dialogs;
public partial class BorrowDialog : Form {
    public BorrowDialog() {
        InitializeComponent();
        btnBorrow.Click += (_,_) => { MessageBox.Show(this,"GUI preview only — no changes saved.","GUI Preview"); Close(); };
        btnCancel.Click += (_,_) => Close();
    }
}
