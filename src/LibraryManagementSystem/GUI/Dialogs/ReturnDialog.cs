namespace LibraryManagementSystem.UI.Dialogs;
public partial class ReturnDialog : Form {
    public ReturnDialog() {
        InitializeComponent();
        btnConfirmReturn.Click += (_,_) => { MessageBox.Show(this,"GUI preview only — no changes saved.","GUI Preview"); Close(); };
        btnCancel.Click += (_,_) => Close();
    }
}
