using TP.SharedLibraries;

Console.WriteLine("Hello, Flights Cost App!");

List<BusinessClass> buscls_list = new()
{
    new BusinessClass() { Name = "mr bus1"  ,AirMiles=0     },
    new BusinessClass() { Name = "mr bus2"  ,AirMiles=666   },
    new BusinessClass() { Name = "mr bus3"  ,AirMiles=1420   },
};

List<EconomyClass> ecocls_list = new()
{
    new EconomyClass()  { Name = "mr peso1" ,KmsByBus=0     },
    new EconomyClass()  { Name = "mr peso2" ,KmsByBus=690    },
    new EconomyClass()  { Name = "mr peso3" ,KmsByBus=4200   },
};

List <FirstClass> firstcls_list= new()
{
    new FirstClass()    { Name = "mr ceo1"                  }
};


List<Passenger> passengers_list = new() { };
passengers_list.AddRange(buscls_list);
passengers_list.AddRange(ecocls_list);
passengers_list.AddRange(firstcls_list);

foreach (var passenger in passengers_list)
{
    decimal flight_cost = passenger switch
    {
        FirstClass _                                => 10_000M,
        BusinessClass b when b.AirMiles > 1_000     => 9_000M,
        BusinessClass b when b.AirMiles > 500       => 8_000M,
        BusinessClass _                             => 7_000M,
        EconomyClass c when c.KmsByBus  > 1_000     => 6_000M,
        EconomyClass c when c.KmsByBus  > 500       => 5_000M,
        EconomyClass _                              => 4_000M,
        _                                           => 420M,
        



    };
}

