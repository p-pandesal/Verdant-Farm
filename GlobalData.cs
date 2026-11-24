using System.Data;

namespace VerdantFarm
{
    public static class GlobalData
    {
        // This central table will store history from ALL pages
        public static DataTable MasterHistoryTable { get; set; } = new DataTable();

        // This will store the current logged-in account ID, which can be used across all pages
        public static string CurrentAccountId { get; set; }

        // Call this once when the application starts up
        public static void InitializeSchema()
        {
            if (MasterHistoryTable.Columns.Count == 0)
            {
                MasterHistoryTable.Columns.Add("LogDate", typeof(string));
                MasterHistoryTable.Columns.Add("ItemName", typeof(string));
                MasterHistoryTable.Columns.Add("Action", typeof(string));
                MasterHistoryTable.Columns.Add("Category", typeof(string));
                MasterHistoryTable.Columns.Add("TotalCost", typeof(double));
            }
        }
    }
}
