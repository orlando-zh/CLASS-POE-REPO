﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace DataAccessLayer.DbConnection
{
    public class SqlDataAccess
    {
        private readonly string _connectionString;

        public SqlDataAccess()
        {
            
            _connectionString = "Data Source=LAPTOP-KFDQNCRJ\\SQLEXPRESS;Initial Catalog=PatientManagement;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
           
        }

        public SqlConnection GetConnection()
        {

            return new SqlConnection(_connectionString);
        }
    }
}