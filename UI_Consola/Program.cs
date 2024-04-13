using DAO.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IGenericDAO<Customer> genericDAO = new DAO.Implementations.Memory.CustomerDao();
            foreach (Customer customer in genericDAO.GetAll())
            {
                Console.WriteLine($"ID:{customer.ID} - Code: {customer.Code}  ");
            }
            Console.ReadKey();

            Console.WriteLine($"Leyendo el file path: {ConfigurationManager.AppSettings["FileLogPath"]}");
            
            Console.WriteLine($"Estoyleyendo connecction string:{ConfigurationManager.ConnectionStrings["AppSqlConnection"].ConnectionString}");
            Console.ReadKey();
        }

    }
}
