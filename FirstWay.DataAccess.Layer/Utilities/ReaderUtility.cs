using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FirstWay.DataAccess.Layer.Utilities
{
    class ReaderUtility<T>
    {

        public SqlDataReader Reader { get; private set; }

        public ReaderUtility(CommandUtility<T> command)
        {
            Reader = command.Command.ExecuteReader();
        }
    }
}
