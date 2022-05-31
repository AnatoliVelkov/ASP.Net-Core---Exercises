    public class WebClientsModel
    {
        [Key]
        public int clientsID { get; set; }

        public string clientsName { get; set; }
        public string clientsCategory { get; set; }
        public string manager { get; set; }
        public string region { get; set; }
        public string city { get; set; }
        public string clientaddress { get; set; }
        public string phone { get; set; }
        public string mail { get; set; }
        public DateTime dateOfDomain { get; set; }
        public DateTime dateFinishOfDomain { get; set; }
        public string domainOfWebSite { get; set; }
        public string statusOfWebSite { get; set; }
        public decimal priceForMonth { get; set; }
        public int discount { get; set; }
        public string siteSubscription { get; set; }
        public DateTime priceFromDate { get; set; }
        public DateTime priceToDate { get; set; }
    }
}
