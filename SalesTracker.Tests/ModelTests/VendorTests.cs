using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTracker.Models;
using System.Collections.Generic;
using System;

namespace SalesTracker.Tests
{
  [TestClass]
  public class VendorTests: IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Vendor 1", "Vendor 1 description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Vendor 1";
      string description = "Vendor 1 description";
      Vendor newVendor = new Vendor(name, description);     
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescriptionString()
    {
      string name = "Vendor 1";
      string description = "Vendor 1 description";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Vendor 1";
      string description = "Vendor 1 description";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Vendor 1";
      string name02 = "Vendor 2";
      string description01 = "Vendor 1 description";
      string description02 = "Vendor 2 description";
      Vendor newVendor01 = new Vendor(name01, description01);
      Vendor newVendor02 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor01, newVendor02 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Vendor 1";
      string name02 = "Vendor 2";
      string description01 = "Vendor 1 description";
      string description02 = "Vendor 2 description";
      Vendor newVendor01 = new Vendor(name01, description01);
      Vendor newVendor02 = new Vendor(name02, description02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor02, result);
    }

    //[TestMethod]
    //public void AddOrder_AssociatesOrderWithVendor_OrderList()
    //{
      //Arrange
      //string description = "Walk the dog.";
      //Order newOrder = new Order(description);
      //List<Order> newList = new List<Order> { newOrder };
      //string name = "Work";
      //Vendor newVendor = new Vendor(name);
      //newVendor.AddOrder(newOrder);

      //Act
      //List<Order> result = newVendor.Orders;

      //Assert
      //CollectionAssert.AreEqual(newList, result);
    //}

  }
}