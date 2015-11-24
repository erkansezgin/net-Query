﻿namespace QueryLibrary
{
    using QueryLibrary.Exceptions;
    using System;

    public partial class Query
    {
        /// <summary>
        /// Runs the given query giving no return.
        /// Throws UnexpectedNumberOfRowsAffected if the number of affected rows is greater than N.
        /// It uses DbCommand.ExecuteNonQuery underneath.
        /// </summary>
        /// <param name="n">Maximum of affected rows to ensure</param>
        /// <param name="sql">Query to run</param>
        /// <param name="parameters">Parameters names and values pairs</param>
        /// <exception cref="UnexpectedNumberOfRowsAffected">
        /// If the number of affected rows is greater than N
        /// </exception>
        public void ChangeNoMoreThan(int n, string sql, object parameters = null)
        {
            if (_disposed)
                throw new ObjectDisposedException(GetType().FullName);

            WithoutReturn(sql, parameters, n, true);
        }
    }
}