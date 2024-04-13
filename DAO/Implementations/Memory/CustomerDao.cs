using DAO.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.Memory
{
    public class CustomerDao : IGenericDAO<Customer>

    {
        private List<Customer> _list = new List<Customer>();

        public CustomerDao() { 
            for (int i = 0; i < 10; i++)
            {
                Customer customer = new Customer(i + 1, " Customer " + i.ToString());
                _list.Add(customer);

            }
        
        
        
        }
        public void Create(Customer entity)
        {
            //Validaciones solo en capa de negocio
            _list.Add(entity);

            
        }

        public List<Customer> GetAll()
        {
            return _list;
        }

        public Customer GetById(Guid id) 
        {
            //Estructurado, mas adelante lo veremos con LINQ
            Customer customer = default;

            foreach (var item in _list) 
            {
                if (item.ID == id)
                {
                    customer = item;
                    break;

                }

            }
            return customer;

        }

        public void Remove(Customer entity)
        {
            _list.Remove(entity);

        }

        public void Update(Customer entity)
        {
            Customer customer = GetById(entity.ID);
            if(customer != null)
            {
                customer.Code = entity.Code;
                customer.Name = entity.Name;

            }

        }
    }
}
