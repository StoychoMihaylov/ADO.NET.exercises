using MiniORM.Attributes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MiniORM
{
    class EntityManager : IDbContext
    {
        private SqlConnection connection;
        private string connectionString;
        private bool isCodeFirst;

        public EntityManager(string connectionString, bool isCodeFirst)
        {
            this.connectionString = connectionString;
            this.isCodeFirst = isCodeFirst;
        }


        public void Delete<T>(object entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById<T>(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll<T>()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll<T>(string where)
        {
            throw new NotImplementedException();
        }

        public T FindById<T>(int id)
        {
            throw new NotImplementedException();
        }

        public T FindFirst<T>()
        {
            throw new NotImplementedException();
        }

        public T FindFirst<T>(string where)
        {
            throw new NotImplementedException();
        }

        public bool Persist(object entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("Cannot persist null entity");
            }

            if (isCodeFirst && !CheckIfTableExists(entity.GetType()))
            {
                this.CreateTable(entity.GetType());
            }
            Type entityType = entity.GetType();
            FieldInfo idInfo = GetId(entityType);
            int id = (int)idInfo.GetValue(entity);

            if (id <= 0)
            {
                return this.Insert(entity, idInfo);
            }

            return this.Update(entityType, idInfo);
        }

        private bool Update(Type entityType, FieldInfo idInfo)
        {
            int numberOfAffectedRows = 0;

            string updateString = PrepareEnityUpdateString(entityType);
            using (connection = new SqlConnection(this.connectionString))
            {
                this.connection.Open();
                SqlCommand updateCommand = new SqlCommand(updateString, connection);
                numberOfAffectedRows = updateCommand.ExecuteNonQuery();
            }

            return numberOfAffectedRows > 0;
        }

        private string PrepareEnityUpdateString(Type entityType)
        {
            throw new NotImplementedException();
        }

        private bool Insert(object entityType, FieldInfo idInfo)
        {
            int numberOfAffectedRows = 0;

            string insertionString = PrepareEnityInsertionString(entityType);
            using (connection = new SqlConnection(this.connectionString))
            {
                this.connection.Open();
                SqlCommand insertionCommand = new SqlCommand(insertionString, connection);
                numberOfAffectedRows = insertionCommand.ExecuteNonQuery();
            }
            
            return numberOfAffectedRows > 0;
        }

        private string PrepareEnityInsertionString(object entity)
        {
            StringBuilder insertionString = new StringBuilder();
            StringBuilder columnNamesString = new StringBuilder();
            StringBuilder valueString = new StringBuilder();
             
            insertionString.Append($"INSERT INTO {this.GetTableName(entity.GetType())}(");
            FieldInfo[] columnFields = entity.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(x => x.IsDefined(typeof(ColumnAttribute))).ToArray();

            foreach (FieldInfo columnField in columnFields)
            {
                string value = columnField.GetValue(entity).ToString();
                columnNamesString.Append($"{this.GetColumnName(columnField)}, ");
                valueString.Append($"'{value}', ");
            }
            columnNamesString = columnNamesString.Remove(columnNamesString.Length -2, 2);
            valueString = valueString.Remove(columnFields.Length -2 ,2);
            insertionString.Append(columnNamesString);
            insertionString.Append(") VALUES(");
            insertionString.Append(valueString);
            insertionString.Append(")");

            return insertionString.ToString();
        }

        private void CreateTable(Type entity)
        {
            connection.Open();
            string creationString = PrepareTableCreationString(entity);
            using (connection = new SqlConnection(this.connectionString))
            {
                SqlCommand command = new SqlCommand(creationString, connection);
                command.ExecuteNonQuery();
            }
        }

        private string PrepareTableCreationString(Type entity)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"CREATE TABLE {GetTableName(entity)} (");
            builder.Append($"Id INT PRIMARY KEY IDENTITY(1,1), ");

            FieldInfo[] columnsInfos = entity.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(x => x.IsDefined(typeof(ColumnAttribute))).ToArray();

            foreach (FieldInfo columnField in columnsInfos)
            {
                builder.Append($"{this.GetColumnName(columnField)} {this.GetTypeToDB(columnField)}, ");
            }

            builder.Remove(builder.Length - 2, 2);
            builder.Append(")");

            return builder.ToString();
        }

        private string GetTypeToDB(FieldInfo field)
        {
            switch (field.FieldType.Name)
            {
                case "Int32":
                    return "int";
                case "string":
                    return "varchar(max)";
                case "datetime":
                    return "datetime";
                case "boolean":
                    return "bit";
                default:
                    Console.WriteLine(field.FieldType.Name);
                    throw new ArgumentException("No such present type - try extending the framework!");
            }

        }

        private bool CheckIfTableExists(Type type)
        {
            string query = "SELECT COUNT(name) " +
                           "FROM sys.sysobjects " +
                           $"WHERE [Name] = '{GetTableName(type)}' AND [xtype] = 'U'";

            int numberOfTables = 0;
            using (connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, this.connection);
                numberOfTables = (int)command.ExecuteScalar();
            }

            return numberOfTables > 0;
        }

        private FieldInfo GetId(Type entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("Cannot get id for null");
            }

            FieldInfo id = entity.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .FirstOrDefault(x => x.IsDefined(typeof(IdAttribute)));

            if (id == null)
            {
                throw new ArgumentException("No if field was found the current class!");
            }

            return id;
        }

        private string GetTableName(Type entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("Table is null");
            }

            if (entity.IsDefined(typeof(EntityAttribute)))
            {
                throw new ArgumentException("Cannot get table name of entity!");
            }

            string tableName = entity.GetCustomAttribute<EntityAttribute>().TableName;

            if (tableName == null)
            {
                throw new ArgumentException("Table name cannot be null!");
            }

            return tableName;
        }

        private string GetColumnName(FieldInfo field)
        {
            if (field == null)
            {
                throw new ArgumentException("Field cannot be null!");
            }

            if (!field.IsDefined(typeof(ColumnAttribute)))
            {
                return field.Name;
            }

            string columnName = field.GetCustomAttribute<ColumnAttribute>().ColumnName;
            if (columnName == null)
            {
                throw new ArgumentException("Column name connot be null!");
            }

            return columnName;
        }

    }
}
