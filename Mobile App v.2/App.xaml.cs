using Mobile_App_v._2.Data;

namespace Mobile_App_v._2;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    static ShoppingListDatabase database;
    public static ShoppingListDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new
               ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "ShoppingList.db3"));
            }
            return database;
        }
    }

}
