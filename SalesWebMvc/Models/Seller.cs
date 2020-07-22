using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email{ get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary{ get; set; }
        public Departament Departament { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddSales(SalesRecord salesRecord)
        {
            Sales.Add(salesRecord);
        }

        public void RemoveSales(SalesRecord salesRecord)
        {
            Sales.Remove(salesRecord);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            /* (sr =>               TAL QUE, DECLARACAO DA VARIAVEL
            sr.Date >= initial      SEJA MAIOR QUE A DATA INICIAL
            &&                      E
            sr.Date <= final)       SEJA MENOR QUE A DATA FINAL
            .Sum(sr => sr.Amount)   SOMA DOS RESULTADOS FILTRADOS PELO ATRIBUTO AMOUNT */
            
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
