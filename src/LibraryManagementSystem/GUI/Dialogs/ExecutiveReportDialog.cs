namespace LibraryManagementSystem.UI.Dialogs;
public partial class ExecutiveReportDialog : Form {
    public ExecutiveReportDialog() {
        InitializeComponent();
        lblDate.Text="LIBRARY PERFORMANCE • GUI PREVIEW";
        chartCategories.SetData(new Dictionary<string,int>{{"Programming",12},{"Software",10},{"Algorithms",8}});
        chartMonthly.SetData(new Dictionary<string,int>{{"Jun",8},{"Jul",13},{"Aug",11},{"Sep",17},{"Oct",21}});
        var grid=new System.Data.DataTable();grid.Columns.Add("Title");grid.Columns.Add("Author");grid.Columns.Add("Borrow Count");
        grid.Rows.Add("Clean Code","Robert C. Martin","21");grid.Rows.Add("Design Patterns","Gamma et al.","17");
        gridTopBooks.AutoGenerateColumns=true;gridTopBooks.DataSource=grid;
    }
}
