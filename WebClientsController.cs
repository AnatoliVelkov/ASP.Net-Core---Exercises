       public async Task<IActionResult> Index()
        {
            int count = _context.WebClientsModel.Count();
            var countOfKindergartens = new List<WebClientsModel>();
            var countOfSchools = new List<WebClientsModel>();
            var upcomingPaymentsInTheCurrentMonth = new List<WebClientsModel>();
            decimal monthIncomeMoney;
            decimal yearIncomeMoney;

            monthIncomeMoney = _context.WebClientsModel.Sum(x => x.priceForMonth);
            yearIncomeMoney = monthIncomeMoney * 12;

            foreach (var item in _context.WebClientsModel)
            {
                if (item.clientsCategory=="Детска градина")
                {
                    countOfKindergartens.Add(item);
                }
            }

            foreach (var item in _context.WebClientsModel)
            {
                if (item.clientsCategory == "Училище")
                {
                    countOfSchools.Add(item);
                }
            }

            foreach (var item in _context.WebClientsModel)
            {
                if (item.priceToDate.Month==DateTime.Now.Month)
                {
                    upcomingPaymentsInTheCurrentMonth.Add(item);
                }
            }

            ViewBag.CountOfClients = count.ToString();
            ViewBag.bagCountOfKindergartens = countOfKindergartens.Count();
            ViewBag.bagCountOfSchools = countOfSchools.Count();
            ViewBag.bagUpcomingPaymentsInTheCurrentMonth = upcomingPaymentsInTheCurrentMonth.Count();
            ViewBag.bagMonthIncomeMoney = monthIncomeMoney;
            ViewBag.bagYearIncomeMoney = yearIncomeMoney;
            return View(await _context.WebClientsModel.OrderByDescending(x=>x.dateOfDomain).ToListAsync());
        }
