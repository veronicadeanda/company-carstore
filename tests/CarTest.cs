using System;
using Xunit;
using Company.Carstore.Api.Models;

namespace tests
{
    public class CarTest
    {
        [Fact]
        public void ChangeMiles()
        {
            //Arrange
            var car = new Car()
            {
                Id = 3,
                Make = "Jeep",
                Model = "Pioneer",
                Year = 2015,
                Miles = 12345,
                Seats = 5,
                Category = "SUV",
                Price = 12345
            };

            //Act
            var newMiles = 88888;
            car.ChangeMiles(newMiles);

            //Assert
            var expectedMiles = newMiles;
            var actualMiles = car.Miles;

            Assert.Equal(expectedMiles, actualMiles);
        }

        [Fact]
        public void ChangePrice()
        {
            //Arrange
            var car = new Car()
            {
                Id = 3,
                Make = "Jeep",
                Model = "Pioneer",
                Year = 2015,
                Miles = 12345,
                Seats = 5,
                Category = "SUV",
                Price = 12345
            };

            //Act
            var newPrice = 10000;
            car.ChangePrice(newPrice);

            //Assert
            var expectedPrice = newPrice;
            var actualPrice = car.Price;
            Assert.Equal(expectedPrice, actualPrice);
        }
    }
}
