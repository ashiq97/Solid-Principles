using Microsoft.VisualBasic;
using SOLID_Principles._1_SingleResponsibility_Principle.Example_1.BadDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._1_SingleResponsibility_Principle.Example_1.GoodDesign
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Order order);
    }

    public class OrderProcessor : IOrderProcessor
    {
        public void ProcessOrder(Order order)
        {

        }
    }
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public decimal Total { get; set; }
    }
   

    public interface IEmailSender
    {
        void SendEmail(Order order);
    }

    public class EmailSender : IEmailSender
    {
        public void SendEmail(Order order)
        {
            // code to send email
        }
    }

    public interface IGenerateInvoice
    {
        void GenerateInvoice(Order order);
    }

    public class InvoiceGenerator : IGenerateInvoice
    {
        public void GenerateInvoice(Order order)
        {
            // code to generate invoice
        }
    }


   /*                ================== Explanation ====================

        This code follows the Single Responsibility Principle because 
        the OrderProcessor class only has one responsibility, which is to process orders.

        The email sending and invoice generation responsibilities are handled by separate
        classes that implement the IEmailSender and IInvoiceGenerator interfaces, respectively.
        
        This design also follows the Dependency Inversion Principle because 
        the OrderProcessor class depends on abstractions rather than concrete implementations.
        
        If we wanted to change the way we send emails or generate invoices, we could simply 
        create new classes that implement the appropriate interfaces and pass them into the
        OrderProcessor constructor without modifying the OrderProcessor class itself.

        */


}
