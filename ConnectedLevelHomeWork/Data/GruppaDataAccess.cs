using ConnectedLevelHomeWork.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace ConnectedLevelHomeWork.Data
{
    public class GruppaDataAccess : DbDataAccess<Gruppa>
    {
        public void CreateTable(string name)
        {
            string createTable = $"CREATE TABLE {name} (Id INT PRIMARY KEY IDENTITY, Name NVARCHAR(MAX) NOT NULL);";

            using (var command = factory.CreateCommand())
            {
                command.CommandText = createTable;
                command.Connection = connection;

                command.ExecuteNonQuery();
            }
        }
    }
}
