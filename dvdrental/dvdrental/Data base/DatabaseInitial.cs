
using Microsoft.Data.SqlClient;

namespace dvdrental
{
    public class DatabaseInitial
    {
        private string? connectionString;

        public DatabaseInitial(string? connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Initialize()
        {
            using (var connect = new SqlConnection(connectionString))
            {
                connect.Open();

                var command = connect.CreateCommand();
                command.CommandText = @"
                IF NOT EXISTS(SELECT * FROM SYS.TABLES WHERE NAME = 'Admin')
                BEGIN
                    CREATE TABLE Admin (
                        Id UNIQUEIDENTIFIER PRIMARY KEY,
                        Admin_Id NVARCHAR(50) NOT NULL,
                        Email NVARCHAR(100) NOT NULL,
                        Password NVARCHAR(50) NOT NULL
                    );
                END
            ";
                command.ExecuteNonQuery();
            }
        }

        public void CreateCustomerTable()
        {
            using (var connect = new SqlConnection(connectionString))
            {
                connect.Open();

                var command = connect.CreateCommand();
                command.CommandText = @"
                IF NOT EXISTS(SELECT * FROM SYS.TABLES WHERE NAME = 'Customer')
                BEGIN 
                    CREATE TABLE Customer (
                        Id UNIQUEIDENTIFIER PRIMARY KEY,
                        FirstName NVARCHAR(50) NOT NULL,
                        LastName NVARCHAR(50) NOT NULL,
                        Email NVARCHAR(100) NOT NULL,
                        Address NVARCHAR(200) NOT NULL,
                        Mobile NVARCHAR(12) NOT NULL,
                        NIC NVARCHAR(12) NOT NULL,
                        IsActive BIT NOT NULL,
                        UserName NVARCHAR(50) NOT NULL,
                        Password NVARCHAR(50) NOT NULL,
                        ConfirmPassword NVARCHAR(50) NOT NULL,
                        CreatedDate DATETIME NOT NULL
                    );
                END
            ";
                command.ExecuteNonQuery();
            }
        }

        public void CreateCategoryTable()
        {
            using (var connect = new SqlConnection(connectionString))
            {
                connect.Open();

                var command = connect.CreateCommand();
                command.CommandText = @"
                IF NOT EXISTS(SELECT * FROM SYS.TABLES WHERE NAME = 'Categories')
                BEGIN 
                    CREATE TABLE Categories (
                        CategoryId UNIQUEIDENTIFIER PRIMARY KEY,
                        CategoryName NVARCHAR(50) NOT NULL
                    );
                END
            ";
                command.ExecuteNonQuery();
            }
        }

        public void CreateMovieTable()
        {
            using (var connect = new SqlConnection(connectionString))
            {
                connect.Open();

                var command = connect.CreateCommand();
                command.CommandText = @"
                IF NOT EXISTS(SELECT * FROM SYS.TABLES WHERE NAME = 'Movies')
                BEGIN 
                    CREATE TABLE Movies (
                        Id UNIQUEIDENTIFIER PRIMARY KEY,
                        Title NVARCHAR(100) NOT NULL,
                        ReleaseDate DATETIME NOT NULL,
                        Description NVARCHAR(MAX) NOT NULL,
                        No_of_Copies INT NOT NULL,
                        IsAvailable BIT NOT NULL,
                        CategoryId UNIQUEIDENTIFIER NOT NULL,
                        ImageUrl NVARCHAR(255) NOT NULL,
                        FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
                    );
                END
            ";
                command.ExecuteNonQuery();
            }
        }

        public void CreateRentalRequestTable()
        {
            using (var connect = new SqlConnection(connectionString))
            {
                connect.Open();

                var command = connect.CreateCommand();
                command.CommandText = @"
                IF NOT EXISTS(SELECT * FROM SYS.TABLES WHERE NAME = 'RentalRequest')
                BEGIN 
                    CREATE TABLE RentalRequest (
                        Id UNIQUEIDENTIFIER PRIMARY KEY,
                        MovieId UNIQUEIDENTIFIER NOT NULL,
                        MovieTitle NVARCHAR(100) NOT NULL,
                        MovieImage NVARCHAR(255) NOT NULL,
                        MovieAvailableCopies INT NOT NULL,
                        CustomerId UNIQUEIDENTIFIER NOT NULL,
                        CustomerFirstName NVARCHAR(50) NOT NULL,
                        CategoryId UNIQUEIDENTIFIER NOT NULL,
                        Status INT NOT NULL, -- To store RentalStatus enum
                        RentDate DATETIME NOT NULL,
                        ReturnTime DATETIME NOT NULL,
                        FOREIGN KEY (MovieId) REFERENCES Movies(Id),
                        FOREIGN KEY (CustomerId) REFERENCES Customer(Id),
                        FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
                    );
                END
            ";
                command.ExecuteNonQuery();
            }
        }
    }

}