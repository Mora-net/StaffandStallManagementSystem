using Microsoft.Data.SqlClient;
using System.Data;

namespace StaffandStallManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PrepareCommands();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            Application.Run(new LogIn());
           
        }
        private static void PrepareCommands()
        {
            InsertStaffCommand = Connection.CreateCommand();
            InsertStaffCommand.CommandType = CommandType.StoredProcedure;
            InsertStaffCommand.CommandText = "spInsertStaff";
            InsertStaffCommand.Parameters.AddRange(
            [
        new SqlParameter("@StaffNameEN", SqlDbType.VarChar, 35)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@StaffNameKH", SqlDbType.NVarChar, 35)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Sex", SqlDbType.VarChar, 6)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@BirthDate", SqlDbType.Date)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@StaffPosition", SqlDbType.VarChar, 50)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@PhoneNumber", SqlDbType.VarChar, 20)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
         new SqlParameter("@HouseNo", SqlDbType.VarChar, 30)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@StreetNo", SqlDbType.VarChar, 30)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Province", SqlDbType.VarChar, 30)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Sangkat", SqlDbType.VarChar, 30)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Khann", SqlDbType.VarChar, 30)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@HiredDate", SqlDbType.Date)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Salary", SqlDbType.Float)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Photo", SqlDbType.VarBinary, -1)  // -1 means VARBINARY(MAX)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@IsStopwork", SqlDbType.Bit)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        }
            ]); InsertStaffCommand = Connection.CreateCommand();
            InsertStaffCommand.CommandType = CommandType.StoredProcedure;
            InsertStaffCommand.CommandText = "spInsertStaff";
            InsertStaffCommand.Parameters.AddRange(
            [
        new SqlParameter("@StaffNameEN", SqlDbType.VarChar, 35)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@StaffNameKH", SqlDbType.NVarChar, 35)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Sex", SqlDbType.VarChar, 6)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@BirthDate", SqlDbType.Date)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@StaffPosition", SqlDbType.VarChar, 50)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@PhoneNumber", SqlDbType.VarChar, 20)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
         new SqlParameter("@HouseNo", SqlDbType.VarChar, 30)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@StreetNo", SqlDbType.VarChar, 30)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Province", SqlDbType.VarChar, 30)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Sangkat", SqlDbType.VarChar, 30)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Khann", SqlDbType.VarChar, 30)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@HiredDate", SqlDbType.Date)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Salary", SqlDbType.Float)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Photo", SqlDbType.VarBinary, -1)  // -1 means VARBINARY(MAX)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@IsStopwork", SqlDbType.Bit)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        }
            ]);




            UpdateStaffCommand = Connection.CreateCommand();
            UpdateStaffCommand.CommandType = CommandType.StoredProcedure;
            UpdateStaffCommand.CommandText = "sp_UpdateStafById";
            UpdateStaffCommand.Parameters.AddRange(
            [
        new SqlParameter("@StaffID", SqlDbType.SmallInt)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@StaffNameEN", SqlDbType.VarChar, 35)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@StaffNameKH", SqlDbType.NVarChar, 35)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Sex", SqlDbType.VarChar, 6)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@BirthDate", SqlDbType.Date)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@StaffPosition", SqlDbType.VarChar, 50)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@PhoneNumber", SqlDbType.VarChar, 20)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
         new SqlParameter("@HouseNo", SqlDbType.VarChar, 30)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@StreetNo", SqlDbType.VarChar, 30)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Province", SqlDbType.VarChar, 30)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Sangkat", SqlDbType.VarChar, 30)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Khann", SqlDbType.VarChar, 30)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@HiredDate", SqlDbType.Date)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Salary", SqlDbType.Float)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@Photo", SqlDbType.VarBinary, -1)  // -1 means VARBINARY(MAX)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        },
        new SqlParameter("@IsStopwork", SqlDbType.Bit)
        {
            Direction = ParameterDirection.Input,
            IsNullable = false,
        }
            ]);


            InsertStallTypeCommand = Connection.CreateCommand();
            InsertStallTypeCommand.CommandType = CommandType.StoredProcedure;
            InsertStallTypeCommand.CommandText = "sp_InsertStallType";
            InsertStallTypeCommand.Parameters.AddRange(
            [
            new SqlParameter("@StallTypeID", SqlDbType.TinyInt)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            },
            new SqlParameter("@StallTypeName", SqlDbType.VarChar,50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            },
            new SqlParameter("@UnitPrice", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            }
        ]);

            UpdateTenantCommand = Connection.CreateCommand();
            UpdateTenantCommand.CommandType = CommandType.StoredProcedure;
            UpdateTenantCommand.CommandText = "sp_UpdateTenant";
            UpdateTenantCommand.Parameters.AddRange([
                new SqlParameter("@TenantID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            },
              new SqlParameter("@FirstName", SqlDbType.VarChar,50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            },
             new SqlParameter("@LastName", SqlDbType.VarChar,50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            },
             new SqlParameter("@Sex", SqlDbType.VarChar,6)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            },new SqlParameter("@HouseNo", SqlDbType.VarChar,20)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            },new SqlParameter("@StreetNo", SqlDbType.VarChar,20)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            },new SqlParameter("@Sangkat", SqlDbType.VarChar,100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            },new SqlParameter("@Khann", SqlDbType.VarChar,100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            },new SqlParameter("@City", SqlDbType.VarChar,100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            },new SqlParameter("@PhoneNumber", SqlDbType.VarChar,100)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            },



                ]);


            UpdateStallTypeCommand = Connection.CreateCommand();
            UpdateStallTypeCommand.CommandType = CommandType.StoredProcedure;
            UpdateStallTypeCommand.CommandText = "sp_UUpdateStallType";
            UpdateStallTypeCommand.Parameters.AddRange(
            [
            new SqlParameter("@StallTypeID", SqlDbType.TinyInt)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            },
            new SqlParameter("@StallTypeName", SqlDbType.VarChar,50)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            },
            new SqlParameter("@UnitPrice", SqlDbType.Money)
            {
                Direction = ParameterDirection.Input,
                IsNullable = false,
            }
        ]);



            InserUserCommand = Connection.CreateCommand();
            InserUserCommand.CommandType = CommandType.StoredProcedure;
            InserUserCommand.CommandText = "InsertUser";
            InserUserCommand.Parameters.AddRange(

                [
                 new SqlParameter("@UserID", SqlDbType.SmallInt)
                    {
                        Direction = ParameterDirection.Input,
                        IsNullable = false,
                    },
                new SqlParameter("@UserName", SqlDbType.VarChar,50)
                    {
                        Direction = ParameterDirection.Input,
                        IsNullable = false,
                    },
                new SqlParameter("@Password", SqlDbType.VarChar,50)
                    {
                        Direction = ParameterDirection.Input,
                        IsNullable = false,
                    },
                new SqlParameter("@StaffID", SqlDbType.SmallInt)
                    {
                        Direction = ParameterDirection.Input,
                        IsNullable = false,
                    },
                new SqlParameter("@StaffNameEN", SqlDbType.VarChar,35)
                    {
                        Direction = ParameterDirection.Input,
                        IsNullable = false,
                    },
                new SqlParameter("@StaffNameKH", SqlDbType.NVarChar,35)
                    {
                        Direction = ParameterDirection.Input,
                        IsNullable = false,
                    },
                new SqlParameter("@StaffPosition", SqlDbType.VarChar,50)
                    {
                        Direction = ParameterDirection.Input,
                        IsNullable = false,
                    },
                ]
                
            );



            UpdateUserCommand = Connection.CreateCommand();
            UpdateUserCommand.CommandType = CommandType.StoredProcedure;
            UpdateUserCommand.CommandText = "sp_UpdateUserById";
            UpdateUserCommand.Parameters.AddRange(

                [
                 new SqlParameter("@UserID", SqlDbType.SmallInt)
                    {
                        Direction = ParameterDirection.Input,
                        IsNullable = false,
                    },
                new SqlParameter("@UserName", SqlDbType.VarChar,50)
                    {
                        Direction = ParameterDirection.Input,
                        IsNullable = false,
                    },
                new SqlParameter("@Password", SqlDbType.VarChar,50)
                    {
                        Direction = ParameterDirection.Input,
                        IsNullable = false,
                    },
                new SqlParameter("@StaffID", SqlDbType.SmallInt)
                    {
                        Direction = ParameterDirection.Input,
                        IsNullable = false,
                    },
                new SqlParameter("@StaffNameEN", SqlDbType.VarChar,35)
                    {
                        Direction = ParameterDirection.Input,
                        IsNullable = false,
                    },
                new SqlParameter("@StaffNameKH", SqlDbType.NVarChar,35)
                    {
                        Direction = ParameterDirection.Input,
                        IsNullable = false,
                    },
                new SqlParameter("@StaffPosition", SqlDbType.VarChar,50)
                    {
                        Direction = ParameterDirection.Input,
                        IsNullable = false,
                    },
                ]

            );
        }
            
        public static SqlConnection Connection = new(
        @"server=DESKTOP-KPD5D9S\MSSQLSEVER2022;database=StaffAndStalldb;
        user id=immora;password=mora123; encrypt=false");
        public static SqlCommand InsertStaffCommand = default!;
        public static SqlCommand UpdateTenantCommand = default!;
        public static SqlCommand UpdateStallTypeCommand = default!;
        public static SqlCommand InsertStallTypeCommand = default!;
        public static SqlCommand UpdateStaffCommand = default!;
        public static SqlCommand UpdateUserCommand = default!;
        public static string nameStaff= default!;
        public static string positonStaff = default!;
        public static string nameStaffKh = default!;
        public static int idstaff = default!;
        public static SqlCommand InserUserCommand = default!;
    }
}




