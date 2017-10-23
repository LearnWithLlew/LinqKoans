using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
  [TestClass]
  public class UnitTest1
  {
    //[TestMethod]
    public void TestMethod1()
    {
      using (var ctx = new OrdersEntities())
      {
        var c = new Customer() {Name = "Lynn"};
        var invoice = new Invoice() {Number = 10};
        invoice.InvoiceItems.Add(new InvoiceItem()
                                   {
                                     Name = "Shoes",
                                     Price = 59.99m,
                                     Shipped = true
                                   });
        invoice.InvoiceItems.Add(new InvoiceItem()
                                   {
                                     Name = "Pants",
                                     Price = 69.99m,
                                     Shipped = true
                                   });
        invoice.Calculate();
        c.Invoices.Add(invoice);
        invoice = new Invoice() {Number = 11};
        invoice.InvoiceItems.Add(new InvoiceItem()
                                   {
                                     Name = "Shoes",
                                     Price = 59.99m,
                                     Shipped = false
                                   });
        invoice.InvoiceItems.Add(new InvoiceItem()
                                   {
                                     Name = "Pants",
                                     Price = 69.99m,
                                     Shipped = true
                                   });
        invoice.Calculate();
        c.Invoices.Add(invoice);
        invoice = new Invoice() {Number = 12};
        invoice.InvoiceItems.Add(new InvoiceItem()
                                   {
                                     Name = "Shoes",
                                     Price = 59.99m,
                                     Shipped = false
                                   });
        invoice.InvoiceItems.Add(new InvoiceItem()
                                   {
                                     Name = "Pants",
                                     Price = 69.99m,
                                     Shipped = false
                                   });
        invoice.Calculate();
        c.Invoices.Add(invoice);
        ctx.AddToCustomers(c);
        ctx.SaveChanges();

      }
    }

    [TestMethod]
      public void TestMethod2()
      {
        using (var ctx = new OrdersEntities())
        {
          Customer lynn = (from c in ctx.Customers
                       where  c.Name == "Lynn"
                       select c).Single();
         // print order # that have shipped
          Console.Write("Orders");
          foreach (var order in lynn.OrdersShipped())
          {
            Console.Write(" #" + order.Number);
          }
          Console.WriteLine(" have shipped");
          
          Console.WriteLine("Partial Orders");
          foreach (var order in lynn.OrdersPartiallyUnshipped())
          {
            Console.Write(" #" + order.Number + " awaiting ");
            foreach (var item in order.GetUnshippedItems())
            {
              Console.Write(item.Name);
            }
            Console.WriteLine();
          }
          Console.WriteLine(" are pending shipped");
        
          Console.Write("Orders");
          foreach (var order in lynn.OrdersCompletelyUnshipped())
          {
            Console.Write(" #" + order.Number);
          }
          Console.WriteLine(" are pending shipped");
        }
      }
    
  }
}
