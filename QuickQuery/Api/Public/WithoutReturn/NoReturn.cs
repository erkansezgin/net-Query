﻿namespace QckQuery
{
    public partial class QuickQuery
    {
        /// <summary>
        /// Runs the given query giving no return.
        /// It uses DbCommand.ExecuteNonQuery underneath.
        /// </summary>
        /// <param name="sql">Query to run</param>
        /// <param name="parameters">Parameters names and values pairs</param>
        public void NoReturn(string sql, object parameters)
        {
            WithoutReturn(sql, parameters);
        }
    }
}
