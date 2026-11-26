using LibraryManagementSystem.UI;
namespace LibraryManagementSystem;
internal static class Program {
    [STAThread]
    private static void Main() {
        ApplicationConfiguration.Initialize();
        Application.Run(new LoginForm());
    }
}
