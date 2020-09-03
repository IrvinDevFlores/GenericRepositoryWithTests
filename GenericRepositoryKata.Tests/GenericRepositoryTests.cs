using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericRepositoryKata.Tests.Entities;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;

namespace GenericRepositoryKata.Tests
{
    [TestClass]
    public class GenericRepositoryTests
    {
        [TestMethod]
        public void Add_WhenAddingAnEmployee_ShouldAddOneEmployee()
        {
            // Arrange
            int id = 1;
            string name = "Juan Pablo";

            Employee employee = new Employee(id, name);
            Employee employee2 = new Employee(2, "Mi nombre aqui");


            IRepository<Employee> employeeRepository = new Repository<Employee>();

            // Act
            employeeRepository.Add(employee2);
            employeeRepository.Add(employee);

            Employee storedEmployee = employeeRepository.FindById(id);

            // Assert
            storedEmployee.Name.Should().Be(name);
        }

        [TestMethod]
        public void Remove_WhenAddingAnEmployee_ShouldRemoveTheEmployee()
        {
            // Arrange
            int id = 1;
            string name = "Juan Pablo";

            Employee employee = new Employee(id, name);


            IRepository<Employee> employeeRepository = new Repository<Employee>();
            employeeRepository.Add(employee);


            // Act
            employeeRepository.RemovedById(id);

            Employee storedEmployee = employeeRepository.FindById(id);

            // Assert
            storedEmployee.Should().BeNull();
        }

        [TestMethod]
        public void GetAll_WhenThereAreExistingEmployees_ShouldReturnAllEmployees()
        {
            // Arrange
            int id1 = 1;
            string name1 = "Juan Pablo";

            Employee employee1 = new Employee(id1, name1);

            int id2 = 2;
            string name2 = "Carlos Andres";

            Employee employee2 = new Employee(id2, name2);


            IRepository<Employee> employeeRepository = new Repository<Employee>();

            employeeRepository.Add(employee1);
            employeeRepository.Add(employee2);


            // Act
            IEnumerable<Employee> storedEmployees = employeeRepository.GetAll();


            // Assert
            storedEmployees.Should().HaveCount(2);

            storedEmployees.ToList()[0].Id.Should().Be(id1);
            storedEmployees.ToList()[1].Id.Should().Be(id2);

            storedEmployees.ToList()[0].Name.Should().Be(name1);
            storedEmployees.ToList()[1].Name.Should().Be(name2);
        }


        [TestMethod]
        public void Add_WhenAddingAnItem_ShouldAddOneItem()
        {
            // Arrange
            int id = 1;
            string itemId = "2228";
            string category = "FLEECE";

            Item item = new Item(id, itemId, category);


            IRepository<Item> itemRepository = new Repository<Item>();

            // Act
            itemRepository.Add(item);

            Item storedItem = itemRepository.FindById(id);

            // Assert
            storedItem.ItemId.Should().Be(itemId);
        }

        [TestMethod]
        public void Remove_WhenAddingAnItem_ShouldRemoveTheItem()
        {
            // Arrange
            int Id = 1;
            string itemId = "2228";
            string category = "FLEECE";

            Item item = new Item(Id, itemId, category);


            IRepository<Item> itemRepository = new Repository<Item>();

            itemRepository.Add(item);


            // Act
            itemRepository.RemovedById(Id);

            Item storedItem = itemRepository.FindById(Id);

            // Assert
            storedItem.Should().BeNull();
        }

        [TestMethod]
        public void GetAll_WhenThereAreExistingItems_ShouldReturnAllItems()
        {
            // Arrange
            int id = 1;
            string itemId = "2228";
            string category = "FLEECE";

            Item item = new Item(id, itemId, category);


            IRepository<Item> itemRepository = new Repository<Item>();

            itemRepository.Add(item);


            // Act
            IEnumerable<Item> storedItems = itemRepository.GetAll();


            // Assert
            storedItems.Should().HaveCount(1);

            storedItems.ToList()[0].Id.Should().Be(id);
            storedItems.ToList()[0].ItemId.Should().Be(itemId);

            storedItems.ToList()[0].Category.Should().Be(category);
        }
    }
}
