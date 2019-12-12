using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using SQLite;

namespace ExpenseApp.Models
{
    public class Expense : INotifyPropertyChanged
    {
        
        private int id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                
            }
        }

        private float amount;
        public float Amount
        {
            get { return amount; }
            set
            {
                amount = value;
                
            }
        }

        

        private string description;
        [MaxLength(25)]
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                
            }
        }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                
            }
        }

        private string category;
        public string Category
        {
            get { return category; }
            set
            {
                category = value;
                
            }
        }

        public Expense()
        {
        }

        //Inserts expense into SQLite DB
        public static int InsertExpense(Expense expense)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabasePath))
            {
                conn.CreateTable<Expense>();
                return conn.Insert(expense);
            }
            
        }

        //Returns a list of expenses from DB
        public static List<Expense> GetExpenses()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabasePath))
            {
                conn.CreateTable<Expense>();
                return conn.Table<Expense>().ToList();
            }
        }

        //Returns a list of expenses in a single category
        public static List<Expense> GetExpenses(string category)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabasePath))
            {
                conn.CreateTable<Expense>();
                return conn.Table<Expense>().Where(e => e.Category == category).ToList();
            }
        }

        //Returns the total amount of expenses in DB
        public static float TotalExpensesAmount()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabasePath))
            {
                conn.CreateTable<Expense>();
                return conn.Table<Expense>().ToList().Sum(e => e.Amount);
            }
        }


        //Required implementation of propertyChangedHandler
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
