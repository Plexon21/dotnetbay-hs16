<<<<<<< HEAD
﻿using System;
using System.Linq;
using System.Windows;
using DotNetBay.Core;
using DotNetBay.Core.Execution;
using DotNetBay.Data.Entity;
using DotNetBay.Data.Provider.FileStorage;
using DotNetBay.Interfaces;
=======
﻿using System.Windows;
>>>>>>> a1f96a6ab557bc6cbdf495008e8eb8202abbefdd

namespace DotNetBay.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
<<<<<<< HEAD
        public IMainRepository MainRepository { get; private set; }
        public IAuctionRunner AuctionRunner { get; private set; }

        public App()
        {
            this.MainRepository = new FileSystemMainRepository("appdata.json");
            this.MainRepository.SaveChanges();

            this.FillSampleData();

            this.AuctionRunner = new AuctionRunner(this.MainRepository);
            this.AuctionRunner.Start();


        }

        private void FillSampleData()
        {
            var memberService = new SimpleMemberService(this.MainRepository);
            var service = new AuctionService(this.MainRepository, memberService);

            if (!service.GetAll().Any())
            {
                var me = memberService.GetCurrentMember();

                service.Save(new Auction
                {
                    Title = "My First Auction",
                    StartDateTimeUtc = DateTime.UtcNow.AddSeconds(10),
                    EndDateTimeUtc = DateTime.UtcNow.AddDays(14),
                    StartPrice = 72,
                    Seller = me
                });
            }
=======
        public App()
        {
>>>>>>> a1f96a6ab557bc6cbdf495008e8eb8202abbefdd
        }
    }
}
