using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DotNetBay.Core;
using DotNetBay.Data.Entity;
using Microsoft.Win32;

namespace DotNetBay.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private App app = (App)Application.Current;
        private readonly IAuctionService auctionService;
        public ObservableCollection<Auction> Auctions { get; } = new ObservableCollection<Auction>();

        public MainWindow()
        {
            DataContext = this;
            this.auctionService = new AuctionService(app.MainRepository, new SimpleMemberService(app.MainRepository));
            this.Auctions = new ObservableCollection<Auction>(this.auctionService.GetAll());
            InitializeComponent();
        }

    }
}
