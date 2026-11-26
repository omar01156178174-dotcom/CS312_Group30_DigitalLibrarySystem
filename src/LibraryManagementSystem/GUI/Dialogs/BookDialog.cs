namespace LibraryManagementSystem.UI.Dialogs;
public partial class BookDialog : Form {
    private TextBox txtTitle = null!;
    private TextBox txtAuthor = null!;
    private TextBox txtISBN = null!;
    private ComboBox cmbCategory = null!;
    private NumericUpDown numYear = null!;
    private NumericUpDown numTotalCopies = null!;
    private NumericUpDown numAvailableCopies = null!;
    private TextBox txtLocation = null!;
    private TextBox txtDescription = null!;
    private Button btnSave = null!;
    private Button btnCancel = null!;
    private ErrorProvider errorProvider = null!;

    public BookDialog() {
        InitializeComponent();
        btnSave.Click += (_,_) => { MessageBox.Show(this,"GUI preview only — book not saved.","GUI Preview"); Close(); };
        btnCancel.Click += (_,_) => Close();
    }
}
