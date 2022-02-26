using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor", "test Description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Vendor";
      string description = "Test Description";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test Vendor";
      string description = "Test Description";
      Vendor newVendor = new Vendor(name, description);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }


    // [TestMethod]
    // public void GetAll_ReturnsAllVendorObjects_VendorList()
    // {
    //   //Arrange
    //   string name01 = "Utensils";
    //   string name02 = "Spices";
    //   Vendor newVendor1 = new Vendor(name01);
    //   Vendor newVendor2 = new Vendor(name02);
    //   List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

    //   //Act
    //   List<Vendor> result = Vendor.GetAll();

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }



  }
}