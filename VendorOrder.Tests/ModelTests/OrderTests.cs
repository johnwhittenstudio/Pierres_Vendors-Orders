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


    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
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


    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string title = "Sourdough";
      string description = "5 loaves";
      string price = "$15.00";
      string date = "02/24/2022";
      Order newOrder = new Order(title, description, price, date);

      //Act
      string updatedDescription = "12 loaves";
      newOrder.Description = updatedDescription;
      string resultDescription = newOrder.Description;
      string updatedPrice = "$36.00";
      newOrder.Price = updatedPrice;
      string resultPrice = newOrder.Price;

      //Assert
      Assert.AreEqual(updatedDescription, resultDescription);
      Assert.AreEqual(updatedPrice, resultPrice);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string title = "Sourdough";
      string description = "5 loaves";
      string price = "$15.00";
      string date = "02/24/2022";
      Order newOrder1 = new Order(title, description, price, date);

      string title2 = "Sourdough";
      string description2 = "12 loaves";
      string price2 = "$36.00";
      string date2 = "02/24/2022";
      Order newOrder2 = new Order(title2, description2, price2, date2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string title = "Sourdough";
      string description = "5 loaves";
      string price = "$15.00";
      string date = "02/24/2022";
      Order newOrder = new Order(title, description, price, date);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

  }
}  