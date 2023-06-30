using System.Data.OleDb;

namespace LaAcoustica_Final
{
    internal static class StaticClass
    {
        internal static OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Data.accdb");
        internal static string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Data.accdb";
        internal static OleDbDataAdapter da;
        internal static OleDbCommand cmd;
    }
}
