using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
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
      Order newOrder = new Order("Sourdough", "5 loaves","$15.00", "02/24/22");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreatesAnInstanceOfAnOrder_True()
    {
      //Arrange
      string title = "Sourdough";
      string description = "5 loaves";
      string price = "$15.00";
      string date = "02/24/2022";
      Order newOrder = new Order(title, description, price, date);

      //Act
      string instanceTitle = newOrder.Title;
      string instanceDescription = newOrder.Description;
      string instancePrice = newOrder.Price;
      string instanceDate = newOrder.Date;

      //Assert
      Assert.AreEqual(title, instanceTitle);
      Assert.AreEqual(description, instanceDescription);
      Assert.AreEqual(price, instancePrice);
      Assert.AreEqual(date, instanceDate);
    }

    public void OrderConstructor_CreatesAnInstanceOfAnOrder_False()
    {
      //Arrange
      string title = "Bagels";
      string description = "5 bagels";
      string price = "$12.00";
      string date = "02/24/2022";
      Order newOrder = new Order(title, description, price, date);

      //Act
      string instanceTitle = newOrder.Title;
      string instanceDescription = newOrder.Description;
      string instancePrice = newOrder.Price;
      string instanceDate = newOrder.Date;
      
      //Assert
      Assert.AreEqual(title, instanceTitle);
      Assert.AreEqual(description, instanceDescription);
      Assert.AreEqual(price, instancePrice);
      Assert.AreEqual(date, instanceDate);
    }

  }
}  