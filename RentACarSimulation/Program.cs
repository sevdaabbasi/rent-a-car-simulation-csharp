// See https://aka.ms/new-console-template for more information


/* Rent A Car Simulation
   Bir araç kiralama firmasının araçların listelendiği siparişlerin görüntülendiği bir ortam simüle etmeniz beklenmektedir.
   ● Teknolojiler: .Net 8 ile Console Application veya (.Net Web Api)
   Tablolar:
   Car ->
   public public public public
   public public public public public public public
   int Id{ get; set; }
   int ColorId { get; set; }
   int FuelId { get; set; }
   int TransmissionId { get; set; }
   string CarState { get; set; }
   int? KiloMeter { get; set; } short? ModelYear { get; set; } string? Plate { get; set; } string? BrandName { get; set; } string? ModelName { get; set; } double? DailyPrice { get; set; }
   
    Color->
   public int Id { get; set; }
   public string? Name { get; set; }
   Fuel->
   public int Id { get; set; }
   public string? Name { get; set; }
   Transmission->
   public int Id { get; set; }
   public string? Name { get; set; }
   Bu Projede İster Record ister class kullanabilirsiniz {get; set;} olmak zorunda değil sadece ilgili alanların bir örneği gösterilmiştr.
  
   İSTERLER:
   ● CarRepository, FuelRepository, TransmissionRepository,ColorRepository ve Servislerini oluşturunuz.
   ● Bütün Repository classlarda GetById, GetAll, Update,Delete,Add metodları olmalıdır
   ● CarService ve Repository classlarında CarDetailDto türünde bazı işlemler yapmanız belenmektedir.
   
    CarDetailDto ->
   public int Id{ get; set; }
   public string? FuelName { get; set; }
   public string? TransmissionName { get; set; } public string? ColorName { get; set; }
   public string CarState { get; set; } public int? KiloMeter { get; set; } public short? ModelYear { get; set; } public string? Plate { get; set; }
   public string? BrandName { get; set; } public string? ModelName { get; set; } public double? DailyPrice { get; set; }
   CarService ve CarRepository classlarında spesifik istekler:
   ● List<CarDetailDto> GetAllDetails();
   ● List<CarDetailDto> GetAllDetailsByFuelId(int fuelId);
   ● List<CarDetailDto> GetAllDetailsByColorId(int colorId);
   ● List<CarDetailDto> GetAllDetailsByPriceRange(double min,
   double max);
   
    ● List<CarDetailDto> GetAllDetailsByBrandNameContains(string brandName);
   ● List<CarDetailDto> GetAllDetailsByModelNameContains(string modelName);
   ● CarDetailDto? GetDetailById(int categoryId);
   ● List<CarDetailDto> GetAllDetailsByKilometerRange(int min,
   int max);
   Başarılar...
   Sen Aklına koyduğun herşeyi başarırsın ;)
   */


Console.WriteLine("Hello, World!");