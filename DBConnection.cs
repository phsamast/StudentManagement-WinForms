using System.Data.SqlClient;

public class DBConnection
{
    public static SqlConnection GetConnection()
    {
        string conn = "Data Source=PHSAMAST;Initial Catalog=StudentManagement;Integrated Security=True";
        return new SqlConnection(conn);
    }
}