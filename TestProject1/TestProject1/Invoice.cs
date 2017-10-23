using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TestProject1
{
  public partial class Invoice
  {

    internal void Calculate()
    {
      Total = InvoiceItems.Sum(i => i.Price);
    }

    internal bool IsShipped()
    {
      return InvoiceItems.All(i=>i.Shipped.Value);
    }

    public bool IsCompletelyUnshipped()
    {
      return InvoiceItems.All(i => !i.Shipped.Value);
    }

    public bool IsPartiallyShipped()
    {
      return !IsCompletelyUnshipped() && !IsShipped();
    }

    public IEnumerable<InvoiceItem> GetUnshippedItems()
    {
      return InvoiceItems.Where(i => !i.Shipped.Value);
    }
  }
}