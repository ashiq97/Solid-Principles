using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._1_SingleResponsibility_Principle.Example_1.BadDesign
{
    public class OrderProcessor
    {
        public void ProcessOrder(Order order) 
        {
            SendEmail(order);
            GenerateInvoice(order);
        }
        private void SendEmail(Order order)
        {
            // code to send email
        }
        private void GenerateInvoice(Order order) 
        {
            // code to generate invoice
        }

    }

    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public decimal Total { get; set; }

    }

    /*         =====================  Explanation =============
       
        This code violates the Single Responsibility Principle because the 
        OrderProcessor class is responsible for processing the order as well as sending an email 
        and generating an invoice. This violates the principle because
        
        " a class should have only one reason to change ",
        
        and if we wanted to change the way we send emails or generate invoices,
        we would need to modify the OrderProcessor class.

        */

}
