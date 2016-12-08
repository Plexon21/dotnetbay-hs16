using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
<<<<<<< HEAD
using DotNetBay.Data.Entity;
=======

using DotNetBay.Model;
>>>>>>> a1f96a6ab557bc6cbdf495008e8eb8202abbefdd

namespace DotNetBay.Interfaces
{
    public interface IMainRepository
    {
        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "We would like this to keep this as is because calling this function actually queries the store")]
        IQueryable<Auction> GetAuctions();

        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "We would like this to keep this as is because calling this function actually queries the store")]
        IQueryable<Member> GetMembers();

        Auction Add(Auction auction);

        Auction Update(Auction auction);

        Bid Add(Bid bid);

        Bid GetBidByTransactionId(Guid transactionId);

        Member Add(Member member);

        void SaveChanges();
    }
}