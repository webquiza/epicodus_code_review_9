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

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Order 1";
      string description = "Order 1 description";
      int price = 25;
      string Date = "Date";
      Order newOrder = new Order(title, description, price, Date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string title = "Order 1";
      string description = "Order 1 description";
      int price = 25;
      string Date = "Date";
      Order newOrder = new Order(title, description, price, Date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      string title = "Order 1";
      string description = "Order 1 description";
      int price = 25;
      string Date = "Date";
      Order newOrder = new Order(title, description, price, Date);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string title = "Order 1";
      string description = "Order 1 description";
      int price = 25;
      string Date = "Date";
      Order newOrder = new Order(title, description, price, Date);
      string result = newOrder.Date;
      Assert.AreEqual(Date, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "Order 1";
      string description = "Order 1 description";
      int price = 25;
      string Date = "Date";
      Order newOrder = new Order(title, description, price, Date);
      string updatedTitle = "Order 1 Updated";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

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