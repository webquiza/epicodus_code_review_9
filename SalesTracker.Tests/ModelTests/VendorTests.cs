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

    //[TestMethod]
    //public void GetId_ReturnsVendorId_Int()
    //{
      //Arrange
      //string name = "Test vendor";
      //Vendor newVendor = new Vendor(name);

      //Act
      //int result = newVendor.Id;

      //Assert
      //Assert.AreEqual(1, result);
    //}

    //[TestMethod]
    //public void GetAll_ReturnsAllVendorObjects_VendorList()
    //{
      //Arrange
      //string name01 = "Work";
      //string name02 = "School";
      //Vendor newVendor1 = new Vendor(name01);
      //Vendor newVendor2 = new Vendor(name02);
      //List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      //List<Vendor> result = Vendor.GetAll();

      //Assert
      //CollectionAssert.AreEqual(newList, result);
    //}

    //[TestMethod]
    //public void Find_ReturnsCorrectVendor_Vendor()
    //{
      //Arrange
      //string name01 = "Work";
      //string name02 = "School";
      //Vendor newVendor1 = new Vendor(name01);
      //Vendor newVendor2 = new Vendor(name02);

      //Act
      //Vendor result = Vendor.Find(2);

      //Assert
      //Assert.AreEqual(newVendor2, result);
    //}

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