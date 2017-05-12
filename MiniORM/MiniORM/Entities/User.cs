using MiniORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM.Entities
{
    [Entity(TableName = "Users")]
    class User
    {
        [Id]
        private int id;

        [Column(ColumnName = "Username")]
        private string username;

        [Column(ColumnName = "Password")]
        private string password;

        [Column(ColumnName = "Age")]
        private int age;

        [Column(ColumnName = "RegistrationDate")]
        private DateTime registrationDate;

        public User(string username, string password, int age, DateTime registrationDate)
        {
            this.Username = username;
            this.Password = password;
            this.Age = age;
            this.RegistrationDate = registrationDate;
        }
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        internal DateTime RegistrationDate
        {
            get
            {
                return registrationDate;
            }

            set
            {
                registrationDate = value;
            }
        }
    }
}
