using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TestProject1
{
  public partial class Customer
  {

    internal IEnumerable<Invoice> OrdersShipped()
    {
      return Invoices.Where(i=>i.IsShipped());
    }

    internal IEnumerable<Invoice> OrdersCompletelyUnshipped()
    {
      return Invoices.Where(i => i.IsCompletelyUnshipped());
    }

    public IEnumerable<Invoice> OrdersPartiallyUnshipped()
    {
      return Invoices.Where(i => i.IsPartiallyShipped());
    }
  }
}