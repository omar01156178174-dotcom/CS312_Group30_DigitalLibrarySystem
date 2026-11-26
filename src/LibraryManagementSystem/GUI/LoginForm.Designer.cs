using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI;

partial class LoginForm
{
    private System.ComponentModel.IContainer? components;
    private TableLayoutPanel loginRoot = null!;
    private Panel loginHeader = null!;
    private Label lblLogo = null!;
    private Label lblTitle = null!;
    private Label lblSubtitle = null!;
    private Panel loginBody = null!;
    private TableLayoutPanel loginCard = null!;
    private Label lblUser = null!;
    private Label lblPass = null!;
    private Label lblFooter = null!;
    private TextBox txtUsername = null!;
    private TextBox txtPassword = null!;
    private Button btnLogin = null!;
    private CheckBox chkShowPassword = null!;
    private Label lblError = null!;

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        loginRoot = new TableLayoutPanel();
        loginHeader = new Panel();
        lblLogo = new Label();
        lblTitle = new Label();
        lblSubtitle = new Label();
        loginBody = new Panel();
        loginCard = new TableLayoutPanel();
        lblUser = new Label();
        lblPass = new Label();
        lblFooter = new Label();
        txtUsername = new TextBox();
        txtPassword = new TextBox();
        btnLogin = new Button();
        chkShowPassword = new CheckBox();
        lblError = new Label();

        SuspendLayout();
        loginRoot.SuspendLayout();
        loginHeader.SuspendLayout();
        loginBody.SuspendLayout();
        loginCard.SuspendLayout();

        // Login window
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(570, 580);
        MinimumSize = new Size(520, 555);
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.Sizable;
        MaximizeBox = false;
        MinimizeBox = false;
        BackColor = Color.FromArgb(15, 23, 42);
        ForeColor = Color.White;
        Font = new Font("Segoe UI", 10F);
        Text = "Digital Library System - Login";

        // Outer responsive layout
        loginRoot.Name = "loginRoot";
        loginRoot.Dock = DockStyle.Fill;
        loginRoot.Margin = Padding.Empty;
        loginRoot.Padding = Padding.Empty;
        loginRoot.BackColor = Color.FromArgb(15, 23, 42);
        loginRoot.ColumnCount = 1;
        loginRoot.RowCount = 3;
        loginRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        loginRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 166F));
        loginRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        loginRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        loginRoot.Controls.Add(loginHeader, 0, 0);
        loginRoot.Controls.Add(loginBody, 0, 1);
        loginRoot.Controls.Add(lblFooter, 0, 2);

        loginHeader.Name = "loginHeader";
        loginHeader.Dock = DockStyle.Fill;
        loginHeader.BackColor = Color.FromArgb(15, 23, 42);
        loginHeader.Controls.Add(lblSubtitle);
        loginHeader.Controls.Add(lblTitle);
        loginHeader.Controls.Add(lblLogo);

        lblLogo.Name = "lblLogo";
        lblLogo.Text = "📚";
        lblLogo.Font = new Font("Segoe UI Emoji", 31F);
        lblLogo.TextAlign = ContentAlignment.MiddleCenter;
        lblLogo.ForeColor = Color.White;
        lblLogo.Dock = DockStyle.Top;
        lblLogo.Height = 71;
        lblTitle.Name = "lblTitle";
        lblTitle.Text = "DIGITAL LIBRARY SYSTEM";
        lblTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        lblTitle.ForeColor = Color.White;
        lblTitle.Dock = DockStyle.Top;
        lblTitle.Height = 52;
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Text = "Sign in to manage your library";
        lblSubtitle.Font = new Font("Segoe UI", 10F);
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
        lblSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
        lblSubtitle.Dock = DockStyle.Top;
        lblSubtitle.Height = 36;

        loginBody.Name = "loginBody";
        loginBody.Dock = DockStyle.Fill;
        loginBody.Padding = new Padding(36, 12, 36, 18);
        loginBody.BackColor = Color.FromArgb(15, 23, 42);
        loginBody.Controls.Add(loginCard);

        loginCard.Name = "loginCard";
        loginCard.Dock = DockStyle.Fill;
        loginCard.BackColor = Color.FromArgb(30, 41, 59);
        loginCard.Padding = new Padding(24, 17, 24, 17);
        loginCard.ColumnCount = 1;
        loginCard.RowCount = 7;
        loginCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        loginCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
        loginCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
        loginCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
        loginCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
        loginCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        loginCard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        loginCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));

        lblUser.Name = "lblUser";
        lblUser.Text = "USERNAME OR EMAIL";
        lblUser.ForeColor = Color.FromArgb(226, 232, 240);
        lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblUser.Dock = DockStyle.Fill;
        lblUser.TextAlign = ContentAlignment.BottomLeft;
        lblUser.Margin = new Padding(0, 0, 0, 6);
        loginCard.Controls.Add(lblUser, 0, 0);

        txtUsername.Name = "txtUsername";
        txtUsername.Font = new Font("Segoe UI", 11F);
        txtUsername.BackColor = Color.FromArgb(15, 23, 42);
        txtUsername.ForeColor = Color.White;
        txtUsername.BorderStyle = BorderStyle.FixedSingle;
        txtUsername.Dock = DockStyle.Fill;
        txtUsername.Margin = new Padding(0, 4, 0, 10);
        loginCard.Controls.Add(txtUsername, 0, 1);

        lblPass.Name = "lblPass";
        lblPass.Text = "PASSWORD";
        lblPass.ForeColor = Color.FromArgb(226, 232, 240);
        lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblPass.Dock = DockStyle.Fill;
        lblPass.TextAlign = ContentAlignment.BottomLeft;
        lblPass.Margin = new Padding(0, 0, 0, 6);
        loginCard.Controls.Add(lblPass, 0, 2);

        txtPassword.Name = "txtPassword";
        txtPassword.Font = new Font("Segoe UI", 11F);
        txtPassword.BackColor = Color.FromArgb(15, 23, 42);
        txtPassword.ForeColor = Color.White;
        txtPassword.BorderStyle = BorderStyle.FixedSingle;
        txtPassword.UseSystemPasswordChar = true;
        txtPassword.Dock = DockStyle.Fill;
        txtPassword.Margin = new Padding(0, 4, 0, 10);
        loginCard.Controls.Add(txtPassword, 0, 3);

        chkShowPassword.Name = "chkShowPassword";
        chkShowPassword.Text = "Show password";
        chkShowPassword.ForeColor = Color.FromArgb(203, 213, 225);
        chkShowPassword.AutoSize = true;
        chkShowPassword.Dock = DockStyle.Left;
        chkShowPassword.Margin = new Padding(0, 5, 0, 0);
        chkShowPassword.Cursor = Cursors.Hand;
        loginCard.Controls.Add(chkShowPassword, 0, 4);

        lblError.Name = "lblError";
        lblError.Text = "";
        lblError.ForeColor = Color.FromArgb(248, 113, 113);
        lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblError.Dock = DockStyle.Fill;
        lblError.TextAlign = ContentAlignment.MiddleLeft;
        lblError.Margin = new Padding(0, 0, 0, 4);
        lblError.Visible = false;
        loginCard.Controls.Add(lblError, 0, 5);

        btnLogin.Name = "btnLogin";
        btnLogin.Text = "Log In / تسجيل الدخول";
        btnLogin.BackColor = Color.FromArgb(99, 102, 241);
        btnLogin.ForeColor = Color.White;
        btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.FlatAppearance.BorderSize = 0;
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(79, 70, 229);
        btnLogin.Dock = DockStyle.Fill;
        btnLogin.Margin = new Padding(0, 8, 0, 7);
        btnLogin.Cursor = Cursors.Hand;
        loginCard.Controls.Add(btnLogin, 0, 6);

        lblFooter.Name = "lblFooter";
        lblFooter.Text = "Secure access  •  Library Management";
        lblFooter.ForeColor = Color.FromArgb(148, 163, 184);
        lblFooter.TextAlign = ContentAlignment.MiddleCenter;
        lblFooter.Dock = DockStyle.Fill;
        lblFooter.Margin = Padding.Empty;

        Controls.Add(loginRoot);
        AcceptButton = btnLogin;

        loginCard.ResumeLayout(false);
        loginCard.PerformLayout();
        loginBody.ResumeLayout(false);
        loginHeader.ResumeLayout(false);
        loginRoot.ResumeLayout(false);
        ResumeLayout(false);
    }
}
