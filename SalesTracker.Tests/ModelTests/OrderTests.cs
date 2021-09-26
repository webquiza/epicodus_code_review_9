using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SalesTracker.Models;
using System;

namespace SalesTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Order 1", "Order 1 description", 25, "Date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    //[TestMethod]
    //public void GetDescription_ReturnsDescription_String()
    //{
      //Arrange
      //string description = "Walk the dog.";

      //Act
      //Order newOrder = new Order(description);
      //string result = newOrder.Description;

      //Assert
      //Assert.AreEqual(description, result);
    //}

    //[TestMethod]
    //public void SetDescription_SetDescription_String()
    //{
      //Arrange
      //string description = "Walk the dog.";
      //Order newOrder = new Order(description);

      //Act
      //string updatedDescription = "Do the dishes";
      //newOrder.Description = updatedDescription;
      //string result = newOrder.Description;

      //Assert
      //Assert.AreEqual(updatedDescription, result);
    //}

    //[TestMethod]
    //public void GetAll_ReturnsEmptyOrder_OrderList()
    //{
      // Arrange
      //List<Order> newOrder = new List<Order> { };

      // Act
      //List<Order> result = Order.GetAll();

      // Assert
      //CollectionAssert.AreEqual(newOrder, result);
   // }

    //[TestMethod]
    //public void GetAll_ReturnsOrders_OrderList()
    //{
      //Arrange
      //string description01 = "Walk the dog";
      //string description02 = "Wash the dishes";
      //Order newOrder1 = new Order(description01);
      //Order newOrder2 = new Order(description02);
      //List<Order> newOrder = new List<Order> { newOrder1, newOrder2 };

      //Act
      //List<Order> result = Order.GetAll();

      //Assert
      //CollectionAssert.AreEqual(newOrder, result);
    //}

    //[TestMethod]
    //public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    //{
      //Arrange
      //string description = "Walk the dog.";
      //Order newOrder = new Order(description);

      //Act
      //int result = newOrder.Id;

      //Assert
      //Assert.AreEqual(1, result);
    //}

    //[TestMethod]
    //public void Find_ReturnsCorrectOrder_Order()
    //{
      //Arrange
      //string description01 = "Walk the dog";
      //string description02 = "Wash the dishes";
      //Order newOrder1 = new Order(description01);
      //Order newOrder2 = new Order(description02);

      //Act
      //Order result = Order.Find(2);

      //Assert
      //Assert.AreEqual(newOrder2, result);
    //}

  }
}