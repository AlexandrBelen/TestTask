using TestTask.Context;
using TestTask.Controllers;
using TestTask.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Configuration;
using Moq;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Text;

namespace TestTask.Tests
{
    public class CarControllerTests
    {
        public CarControllerTests()
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder
                .UseSqlServer("Server=DESKTOP-U9TRK5N\\SQLEXPRESS;Database=NewDB;Trusted_Connection=True;Max Pool Size=20;Connection Timeout=10");
            data = new DataContext(optionsBuilder.Options);
            controller = new CarController(data);
        }
        DataContext data;
        CarController controller;

        [Fact]
        public void FindOwnerByCarNumberTrue()
        {
            // Arrange 
            OwnerViewModel ow = new OwnerViewModel() { Name = "Олександр", LastName = "Кучер", MidName = "Олександрович" };
            CarViewModel model = new CarViewModel() { Number = "AA2545ET" };

            var expected = JsonConvert.SerializeObject(ow);

            // Act
            string actual = JsonConvert.SerializeObject(controller.GetOwner(model).Result);

            // Assert
            Assert.Contains(expected, actual);
        }

        [Fact]
        public void FindOwnerByCarNumberFalse()
        {
            // Arrange 
            OwnerViewModel ow = new OwnerViewModel() { Name = "Олександр", LastName = "Кучер", MidName = "Олександрович" };
            CarViewModel model = new CarViewModel() { Number = "AA2545AT" };

            var expected = JsonConvert.SerializeObject(ow);

            // Act
            string actual = JsonConvert.SerializeObject(controller.GetOwner(model).Result);

            // Assert
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void FindCarsByOwner()
        {

            // Arrange
            OwnerViewModel ow = new OwnerViewModel() { Name = "Дмитро", LastName = "Квадратний", MidName = "Олександрович" };
            CarViewModel[] cars = new CarViewModel[]
            {
                new CarViewModel { Number = "AA8586MO", Brand = "Volkswagen", Model = "Polo", Color = "red", Year = "2015" },
                new CarViewModel { Number = "AA6554OP", Brand = "Volkswagen", Model = "Passat", Color = "white", Year = "2016" },
                new CarViewModel { Number = "AA0001KP", Brand = "Volkswagen", Model = "Raptor", Color = "black", Year = "2018" }
            };
            string expected = "";
            for(int i = 0; i < cars.Length; i++)
            {
                expected += JsonConvert.SerializeObject(cars);
            }
            expected = JsonConvert.SerializeObject(cars);

            // Act
            string actual = JsonConvert.SerializeObject(controller.GetOwnerCars(ow).Result);

            // Assertч
            Assert.Contains(expected, actual);
        }



        IEnumerable<Car> GetCars()
        {
            return data.Cars.ToList();
        }
    }
}
