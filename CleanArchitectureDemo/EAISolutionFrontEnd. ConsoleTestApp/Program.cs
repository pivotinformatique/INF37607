using System;

using Microsoft.EntityFrameworkCore;

using EAISolutionFrontEnd.Core.Entities;
using EAISolutionFrontEnd.Infrastructure;
using System.Threading.Tasks;
using EAISolutionFrontEnd.SharedKernel.Interfaces;
using EAISolutionFrontEnd.Core.Specifications;

namespace EAISolutionFrontEnd._ConsoleTestApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Test1();
            //await Test2();
            await Test3();
        }

        static void Test1()
        {
            // dirty code
            var context = new EAISolutionFrontEndContext();

            // add a user
            User aUser = new User("Ismail", "Khriss", "ismail_khriss@uqar.ca", "toto");
            context.Add(aUser);
            context.SaveChanges();

            // add a request
            Request aRequest = new Request(aUser);
            RequestItem aRequestItem = new RequestItem("Produit bon marché", 2, 5.25M);
            aRequest.AddRequestItem(aRequestItem);
            aRequestItem = new RequestItem("Produit pas vraiment marché", 1, 1000M);
            aRequest.AddRequestItem(aRequestItem);
            context.Requests.Add(aRequest);
            foreach (RequestItem requestItem in aRequest.RequestItems)
                context.RequestItems.Add(requestItem);
            context.SaveChanges();

            // add a second request
            aRequest = new Request(aUser);
            aRequestItem = new RequestItem("Second Produit bon marché", 4, 2.00M);
            aRequest.AddRequestItem(aRequestItem);
            context.Requests.Add(aRequest);
            foreach (RequestItem requestItem in aRequest.RequestItems)
                context.RequestItems.Add(requestItem);
            context.SaveChanges();

            // add another user
            User anotherUser = new User("Toto", "Toto", "toto@uqar.ca", "toto");
            context.Add(anotherUser);
            context.SaveChanges();

            // add a request for him
            aRequest = new Request(anotherUser);
            aRequestItem = new RequestItem("Produit bon marché", 5, 5.25M);
            aRequest.AddRequestItem(aRequestItem);
            context.Requests.Add(aRequest);
            foreach (RequestItem requestItem in aRequest.RequestItems)
                context.RequestItems.Add(requestItem);
            context.SaveChanges();
        }

        static async Task Test2()
        {
            using (EAISolutionFrontEndContext context = new EAISolutionFrontEndContext())
            {
                IAsyncRepository<User> ar = new EfRepository<User>(context);
                User aUser = await ar.GetByIdAsync(1);
                if (aUser != null)
                    System.Console.WriteLine(aUser.Email);
                else System.Console.WriteLine("User not found");
            }
        }

        static async Task Test3()
        {
            using (EAISolutionFrontEndContext context = new EAISolutionFrontEndContext())
            {
                IAsyncRepository<Request> repo = new EfRepository<Request>(context);
                RequestByUser spec = new RequestByUser(1);
                var requests = await repo.ListAsync(spec);
                foreach (Request r in requests)
                {
                    // check that order total is 0 because request items are not loaded
                    System.Console.WriteLine("Id=" + r.Id + " Order date=" + r.OrderDate + "Order total=" + r.OrderTotal());

                }

                // load request items...
                foreach (Request r in requests)
                {
                    RequestRepository repo2 = new RequestRepository(context);
                    Request r2 = await repo2.GetByIdWithRequestItemsAsync(r.Id);
                    // check that order total is now is correct
                    System.Console.WriteLine("Id=" + r2.Id + " Order date=" + r2.OrderDate + "Order total=" + r2.OrderTotal());

                }

            }
        }
    }
}
