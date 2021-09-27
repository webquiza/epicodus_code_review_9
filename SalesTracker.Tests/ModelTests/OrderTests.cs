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

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title01 = "Order 1";
      string title02 = "Order 2";
      string description01 = "Order 1 description";
      string description02 = "Order 2 description";
      int price01 = 25;
      int price02 = 50;
      string Date01 = "Date 1";
      string Date02 = "Date 2";
      Order newOrder01 = new Order(title01, description01, price01, Date01);
      Order newOrder02 = new Order(title02, description02, price02, Date02);
      List<Order> newList = new List<Order> { newOrder01, newOrder02 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "Order 1";
      string description = "Order 1 description";
      int price = 25;
      string Date = "Date";
      Order newOrder = new Order(title, description, price, Date);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

  }
}