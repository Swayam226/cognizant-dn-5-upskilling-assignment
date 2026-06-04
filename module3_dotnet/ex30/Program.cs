using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static string connectionString = "Server=localhost;Database=TestDB;Trusted_Connection=True;";

    static void CreateTable(SqlConnection conn)
    {
        string sql = @"
            IF NOT EXISTS (
                SELECT * FROM sysobjects WHERE name='Employees' AND xtype='U'
            )
            CREATE TABLE Employees (
                EmployeeId INT PRIMARY KEY IDENTITY(1,1),
                Name NVARCHAR(100) NOT NULL,
                Department NVARCHAR(100) NOT NULL,
                Salary DECIMAL(10,2) NOT NULL
            )";
        using SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        Console.WriteLine("Table 'Employees' ready.");
    }

    static void InsertEmployee(SqlConnection conn, string name, string department, decimal salary)
    {
        string sql = "INSERT INTO Employees (Name, Department, Salary) VALUES (@Name, @Department, @Salary)";
        using SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Department", department);
        cmd.Parameters.AddWithValue("@Salary", salary);
        int rows = cmd.ExecuteNonQuery();
        Console.WriteLine("Inserted " + rows + " row(s). Name: " + name);
    }

    static void ReadEmployees(SqlConnection conn)
    {
        string sql = "SELECT EmployeeId, Name, Department, Salary FROM Employees";
        using SqlCommand cmd = new SqlCommand(sql, conn);
        using SqlDataReader reader = cmd.ExecuteReader();
        Console.WriteLine("\n--- Employees ---");
        while (reader.Read())
        {
            Console.WriteLine("ID: " + reader["EmployeeId"]
                + ", Name: " + reader["Name"]
                + ", Dept: " + reader["Department"]
                + ", Salary: " + reader["Salary"]);
        }
    }

    static void ReadWithDataAdapter(SqlConnection conn)
    {
        string sql = "SELECT * FROM Employees";
        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        Console.WriteLine("\n--- Employees via DataAdapter ---");
        foreach (DataRow row in dt.Rows)
        {
            Console.WriteLine("ID: " + row["EmployeeId"]
                + ", Name: " + row["Name"]
                + ", Dept: " + row["Department"]
                + ", Salary: " + row["Salary"]);
        }
    }

    static void UpdateEmployee(SqlConnection conn, int id, decimal newSalary)
    {
        string sql = "UPDATE Employees SET Salary = @Salary WHERE EmployeeId = @Id";
        using SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@Salary", newSalary);
        cmd.Parameters.AddWithValue("@Id", id);
        int rows = cmd.ExecuteNonQuery();
        Console.WriteLine("\nUpdated " + rows + " row(s) for EmployeeId " + id);
    }

    static void DeleteEmployee(SqlConnection conn, int id)
    {
        string sql = "DELETE FROM Employees WHERE EmployeeId = @Id";
        using SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@Id", id);
        int rows = cmd.ExecuteNonQuery();
        Console.WriteLine("Deleted " + rows + " row(s) for EmployeeId " + id);
    }

    static void Main()
    {
        using SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        Console.WriteLine("Connected to SQL Server.");

        CreateTable(conn);

        InsertEmployee(conn, "Alice Johnson", "Engineering", 85000);
        InsertEmployee(conn, "Bob Smith", "Marketing", 72000);
        InsertEmployee(conn, "Charlie Lee", "Finance", 90000);

        ReadEmployees(conn);
        ReadWithDataAdapter(conn);

        UpdateEmployee(conn, 1, 92000);
        ReadEmployees(conn);

        DeleteEmployee(conn, 2);
        ReadEmployees(conn);
    }
}
