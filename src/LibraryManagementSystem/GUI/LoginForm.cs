namespace LibraryManagementSystem.UI;
public partial class LoginForm : Form {
    public LoginForm() {
        InitializeComponent();
        chkShowPassword.CheckedChanged += (_, _) => txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        btnLogin.Click += (_, _) => OpenLibrary();
        txtUsername.KeyDown += EnterToLogin;
        txtPassword.KeyDown += EnterToLogin;
        lblError.Visible = false;
    }
    private void EnterToLogin(object? sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; OpenLibrary(); } }
    private void OpenLibrary() {
        // GUI DESIGN DEMONSTRATION: no real authentication or database is used.
        Hide();
        using (var main = new MainForm()) main.ShowDialog(this);
        Show();
        txtPassword.Clear();
    }
}
