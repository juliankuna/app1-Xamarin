using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Dependencies
{
    public interface IDataBase
    {
        SQLite.SQLiteConnection GetConnection();
    }
}
