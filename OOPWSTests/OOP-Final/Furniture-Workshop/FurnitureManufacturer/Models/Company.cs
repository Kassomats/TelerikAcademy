using Bytes2you.Validation;
using FurnitureManufacturer.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FurnitureManufacturer.Models
{
    // Finish the class
    public class Company : ICompany
    {
       
        private string name;
        private string registrationNumber;
        private readonly ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            Guard.WhenArgument(name, "name valid").IsNullOrWhiteSpace().Throw();
            Guard.WhenArgument(name.Length, "name valid").IsLessThan(5).Throw();
            this.Name = name;
            Guard.WhenArgument(registrationNumber.Length, "reg valid").IsLessThan(10).IsGreaterThan(10).Throw();
            foreach (var item in registrationNumber)
            {
                if (!char.IsDigit(item))
                {
                    throw new System.Exception("reg number is not only from digits");
                }
            }
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }



        public string Name { get => name; private set => name = value; }
        public string RegistrationNumber { get => registrationNumber; private set => registrationNumber = value; }

        public ICollection<IFurniture> Furnitures => this.furnitures;

  

        public void Add(IFurniture furniture)
        {
            Furnitures.Add(furniture);
            
        }

        public string Catalog()
        {
            var orderedFurnitures = Furnitures.OrderBy(x => x.Price).ThenBy(x => x.Model).ToList();
            var strBuilder = new StringBuilder();
            
            if (furnitures.Count == 0)
            {
                strBuilder.Append($"{Name} {RegistrationNumber}  - no furnitures\n");

            }
            if (furnitures.Count == 1)
            {
                strBuilder.Append($"{Name} {RegistrationNumber} {furnitures.Count} - furniture\n");

            }
            if (furnitures.Count > 1)
            {
                strBuilder.Append($"{Name} {RegistrationNumber} {furnitures.Count} - furnitures\n");

            }           
            
            foreach (var item in orderedFurnitures)
            {
                strBuilder.Append(item.ToString());
            }
            return strBuilder.ToString().Trim();

        }
        public IFurniture Find(string model)
        {
            foreach (var item in Furnitures)
            {
                if (item.Model==model)
                {
                    return item;
                }
            }
            return null;
        }

        public void Remove(IFurniture furniture)
        {
            if (Furnitures.Contains(furniture))
            {
                Furnitures.Remove(furniture);
            }
            
        }
    }
}
