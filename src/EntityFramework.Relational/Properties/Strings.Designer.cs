// <auto-generated />
namespace Microsoft.Data.Entity.Relational
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Strings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("EntityFramework.Relational.Strings", typeof(Strings).GetTypeInfo().Assembly);

        /// <summary>
        /// The string argument '{argumentName}' cannot be empty.
        /// </summary>
        internal static string ArgumentIsEmpty
        {
            get { return GetString("ArgumentIsEmpty"); }
        }

        /// <summary>
        /// The string argument '{argumentName}' cannot be empty.
        /// </summary>
        internal static string FormatArgumentIsEmpty(object argumentName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ArgumentIsEmpty", "argumentName"), argumentName);
        }

        /// <summary>
        /// The value provided for argument '{argumentName}' must be a valid value of enum type '{enumType}'.
        /// </summary>
        internal static string InvalidEnumValue
        {
            get { return GetString("InvalidEnumValue"); }
        }

        /// <summary>
        /// The value provided for argument '{argumentName}' must be a valid value of enum type '{enumType}'.
        /// </summary>
        internal static string FormatInvalidEnumValue(object argumentName, object enumType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidEnumValue", "argumentName", "enumType"), argumentName, enumType);
        }

        /// <summary>
        /// The schema qualified name '{name}' is invalid. Schema qualified names must be of the form [&lt;schema_name&gt;.]&lt;object_name&gt;.
        /// </summary>
        internal static string InvalidSchemaQualifiedName
        {
            get { return GetString("InvalidSchemaQualifiedName"); }
        }

        /// <summary>
        /// The schema qualified name '{name}' is invalid. Schema qualified names must be of the form [&lt;schema_name&gt;.]&lt;object_name&gt;.
        /// </summary>
        internal static string FormatInvalidSchemaQualifiedName(object name)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidSchemaQualifiedName", "name"), name);
        }

        /// <summary>
        /// Can not create a ModificationFunction for an entity in state '{entityState}'.
        /// </summary>
        internal static string ModificationFunctionInvalidEntityState
        {
            get { return GetString("ModificationFunctionInvalidEntityState"); }
        }

        /// <summary>
        /// Can not create a ModificationFunction for an entity in state '{entityState}'.
        /// </summary>
        internal static string FormatModificationFunctionInvalidEntityState(object entityState)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ModificationFunctionInvalidEntityState", "entityState"), entityState);
        }

        /// <summary>
        /// Update failed. Expected {expectedRows} row(s) but {actualRows} row(s) returned.
        /// </summary>
        internal static string UpdateConcurrencyException
        {
            get { return GetString("UpdateConcurrencyException"); }
        }

        /// <summary>
        /// Update failed. Expected {expectedRows} row(s) but {actualRows} row(s) returned.
        /// </summary>
        internal static string FormatUpdateConcurrencyException(object expectedRows, object actualRows)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UpdateConcurrencyException", "expectedRows", "actualRows"), expectedRows, actualRows);
        }

        /// <summary>
        /// Multiple relational data store configurations found. A context can only be configured to use a single data store.
        /// </summary>
        internal static string MultipleDataStoresConfigured
        {
            get { return GetString("MultipleDataStoresConfigured"); }
        }

        /// <summary>
        /// Multiple relational data store configurations found. A context can only be configured to use a single data store.
        /// </summary>
        internal static string FormatMultipleDataStoresConfigured()
        {
            return GetString("MultipleDataStoresConfigured");
        }

        /// <summary>
        /// No relational data stores are configured. Configure a data store using OnConfiguring or by creating an ImmutableDbContextOptions with a data store configured and passing it to the context.
        /// </summary>
        internal static string NoDataStoreConfigured
        {
            get { return GetString("NoDataStoreConfigured"); }
        }

        /// <summary>
        /// No relational data stores are configured. Configure a data store using OnConfiguring or by creating an ImmutableDbContextOptions with a data store configured and passing it to the context.
        /// </summary>
        internal static string FormatNoDataStoreConfigured()
        {
            return GetString("NoDataStoreConfigured");
        }

        /// <summary>
        /// Both an existing DbConnection and a connection string have been configured. When an existing DbConnection is used the connection string must be set on that connection.
        /// </summary>
        internal static string ConnectionAndConnectionString
        {
            get { return GetString("ConnectionAndConnectionString"); }
        }

        /// <summary>
        /// Both an existing DbConnection and a connection string have been configured. When an existing DbConnection is used the connection string must be set on that connection.
        /// </summary>
        internal static string FormatConnectionAndConnectionString()
        {
            return GetString("ConnectionAndConnectionString");
        }

        /// <summary>
        /// A relational store has been configured without specifying either the DbConnection or connection string to use.
        /// </summary>
        internal static string NoConnectionOrConnectionString
        {
            get { return GetString("NoConnectionOrConnectionString"); }
        }

        /// <summary>
        /// A relational store has been configured without specifying either the DbConnection or connection string to use.
        /// </summary>
        internal static string FormatNoConnectionOrConnectionString()
        {
            return GetString("NoConnectionOrConnectionString");
        }

        /// <summary>
        /// The property '{propertyName}' cannot be mapped because it is of type '{propertyType}' which is currently not supported.
        /// </summary>
        internal static string UnsupportedType
        {
            get { return GetString("UnsupportedType"); }
        }

        /// <summary>
        /// The property '{propertyName}' cannot be mapped because it is of type '{propertyType}' which is currently not supported.
        /// </summary>
        internal static string FormatUnsupportedType(object propertyName, object propertyType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnsupportedType", "propertyName", "propertyType"), propertyName, propertyType);
        }

        /// <summary>
        /// The connection string '{connectionName}' could not be found because no IConfiguration object has been configured.
        /// </summary>
        internal static string NoConfigForConnection
        {
            get { return GetString("NoConfigForConnection"); }
        }

        /// <summary>
        /// The connection string '{connectionName}' could not be found because no IConfiguration object has been configured.
        /// </summary>
        internal static string FormatNoConfigForConnection(object connectionName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoConfigForConnection", "connectionName"), connectionName);
        }

        /// <summary>
        /// The connection string '{connectionName}' could not be found in the application's configuration.
        /// </summary>
        internal static string ConnectionNotFound
        {
            get { return GetString("ConnectionNotFound"); }
        }

        /// <summary>
        /// The connection string '{connectionName}' could not be found in the application's configuration.
        /// </summary>
        internal static string FormatConnectionNotFound(object connectionName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ConnectionNotFound", "connectionName"), connectionName);
        }

        /// <summary>
        /// Relational-specific methods can only be used when the context is using a relational data store.
        /// </summary>
        internal static string RelationalNotInUse
        {
            get { return GetString("RelationalNotInUse"); }
        }

        /// <summary>
        /// Relational-specific methods can only be used when the context is using a relational data store.
        /// </summary>
        internal static string FormatRelationalNotInUse()
        {
            return GetString("RelationalNotInUse");
        }

        /// <summary>
        /// An error occurred while updating the entries. See the inner exception for details.
        /// </summary>
        internal static string UpdateStoreException
        {
            get { return GetString("UpdateStoreException"); }
        }

        /// <summary>
        /// An error occurred while updating the entries. See the inner exception for details.
        /// </summary>
        internal static string FormatUpdateStoreException()
        {
            return GetString("UpdateStoreException");
        }

        /// <summary>
        /// The property '{property}' of the argument '{argument}' cannot be null.
        /// </summary>
        internal static string ArgumentPropertyNull
        {
            get { return GetString("ArgumentPropertyNull"); }
        }

        /// <summary>
        /// The property '{property}' of the argument '{argument}' cannot be null.
        /// </summary>
        internal static string FormatArgumentPropertyNull(object property, object argument)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ArgumentPropertyNull", "property", "argument"), property, argument);
        }

        /// <summary>
        /// The collection argument '{argumentName}' must contain at least one element.
        /// </summary>
        internal static string CollectionArgumentIsEmpty
        {
            get { return GetString("CollectionArgumentIsEmpty"); }
        }

        /// <summary>
        /// The collection argument '{argumentName}' must contain at least one element.
        /// </summary>
        internal static string FormatCollectionArgumentIsEmpty(object argumentName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CollectionArgumentIsEmpty", "argumentName"), argumentName);
        }

        /// <summary>
        /// The connection is already in a transaction and cannot participate in another transaction.
        /// </summary>
        internal static string TransactionAlreadyStarted
        {
            get { return GetString("TransactionAlreadyStarted"); }
        }

        /// <summary>
        /// The connection is already in a transaction and cannot participate in another transaction.
        /// </summary>
        internal static string FormatTransactionAlreadyStarted()
        {
            return GetString("TransactionAlreadyStarted");
        }

        /// <summary>
        /// The specified transaction is not associated with the current connection. Only transactions associated with the current connection may be used.
        /// </summary>
        internal static string TransactionAssociatedWithDifferentConnection
        {
            get { return GetString("TransactionAssociatedWithDifferentConnection"); }
        }

        /// <summary>
        /// The specified transaction is not associated with the current connection. Only transactions associated with the current connection may be used.
        /// </summary>
        internal static string FormatTransactionAssociatedWithDifferentConnection()
        {
            return GetString("TransactionAssociatedWithDifferentConnection");
        }

        /// <summary>
        /// A query containing the Skip operator must include at least one OrderBy operation.
        /// </summary>
        internal static string SkipNeedsOrderBy
        {
            get { return GetString("SkipNeedsOrderBy"); }
        }

        /// <summary>
        /// A query containing the Skip operator must include at least one OrderBy operation.
        /// </summary>
        internal static string FormatSkipNeedsOrderBy()
        {
            return GetString("SkipNeedsOrderBy");
        }

        /// <summary>
        /// The SQL Server sequence '{sequenceName}' was already specified with a different definition.
        /// </summary>
        internal static string SequenceDefinitionMismatch
        {
            get { return GetString("SequenceDefinitionMismatch"); }
        }

        /// <summary>
        /// The SQL Server sequence '{sequenceName}' was already specified with a different definition.
        /// </summary>
        internal static string FormatSequenceDefinitionMismatch(object sequenceName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("SequenceDefinitionMismatch", "sequenceName"), sequenceName);
        }

        /// <summary>
        /// Creating database '{databaseName}'.
        /// </summary>
        internal static string RelationalLoggerCreatingDatabase
        {
            get { return GetString("RelationalLoggerCreatingDatabase"); }
        }

        /// <summary>
        /// Creating database '{databaseName}'.
        /// </summary>
        internal static string FormatRelationalLoggerCreatingDatabase(object databaseName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RelationalLoggerCreatingDatabase", "databaseName"), databaseName);
        }

        /// <summary>
        /// Opening connection '{connectionString}'.
        /// </summary>
        internal static string RelationalLoggerOpeningConnection
        {
            get { return GetString("RelationalLoggerOpeningConnection"); }
        }

        /// <summary>
        /// Opening connection '{connectionString}'.
        /// </summary>
        internal static string FormatRelationalLoggerOpeningConnection(object connectionString)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RelationalLoggerOpeningConnection", "connectionString"), connectionString);
        }

        /// <summary>
        /// Closing connection '{connectionString}'.
        /// </summary>
        internal static string RelationalLoggerClosingConnection
        {
            get { return GetString("RelationalLoggerClosingConnection"); }
        }

        /// <summary>
        /// Closing connection '{connectionString}'.
        /// </summary>
        internal static string FormatRelationalLoggerClosingConnection(object connectionString)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RelationalLoggerClosingConnection", "connectionString"), connectionString);
        }

        /// <summary>
        /// Beginning transaction with isolation level '{isolationLevel}'.
        /// </summary>
        internal static string RelationalLoggerBeginningTransaction
        {
            get { return GetString("RelationalLoggerBeginningTransaction"); }
        }

        /// <summary>
        /// Beginning transaction with isolation level '{isolationLevel}'.
        /// </summary>
        internal static string FormatRelationalLoggerBeginningTransaction(object isolationLevel)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RelationalLoggerBeginningTransaction", "isolationLevel"), isolationLevel);
        }

        /// <summary>
        /// Committing transaction.
        /// </summary>
        internal static string RelationalLoggerCommittingTransaction
        {
            get { return GetString("RelationalLoggerCommittingTransaction"); }
        }

        /// <summary>
        /// Committing transaction.
        /// </summary>
        internal static string FormatRelationalLoggerCommittingTransaction()
        {
            return GetString("RelationalLoggerCommittingTransaction");
        }

        /// <summary>
        /// Rolling back transaction.
        /// </summary>
        internal static string RelationalLoggerRollingbackTransaction
        {
            get { return GetString("RelationalLoggerRollingbackTransaction"); }
        }

        /// <summary>
        /// Rolling back transaction.
        /// </summary>
        internal static string FormatRelationalLoggerRollingbackTransaction()
        {
            return GetString("RelationalLoggerRollingbackTransaction");
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
