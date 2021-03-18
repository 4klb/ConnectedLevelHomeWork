using ConnectedLevelHomeWork.Data;
using ConnectedLevelHomeWork.Services;
using System;

namespace ConnectedLevelHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            InitConfiguration();

            var dataAccess = new GruppaDataAccess();
            dataAccess.CreateTable("Gruppa");

        }

        private static void InitConfiguration()
        {
            ConfigurationService.Init();
        }
    }
}
