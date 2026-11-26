namespace LibraryManagementSystem.UI.Dialogs;
public partial class MemberDialog : Form {
    public MemberDialog() {
        InitializeComponent();
        btnSave.Click += (_,_) => { MessageBox.Show(this,"GUI preview only — no changes saved.","GUI Preview"); Close(); };
        btnCancel.Click += (_,_) => Close();
    }
}
