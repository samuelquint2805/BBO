using retailSalesCompany;
//factura numero 1
products vino = new prodPrEst(111, "botella de vino Cabernet Sauvignon",85000);
products Mani = new prodPrEst(222, "Bolsa de mani salado La especial", 9500);
products Chocolate = new prodPrEst(333, "Barra de chocolate Hrrshey's grande", 20000);
products uvas = new prodVarPri(444, "Uvas chilenas",13000,2.5m);
products quesoCheddar = new prodVarPri(555, "Queso Cheddar", 50000, 0.5m);

Invoice invoc1 = new Invoice();

invoc1.AddProduct(vino);
invoc1.AddProduct(Mani);
invoc1.AddProduct(Chocolate);
invoc1.AddProduct(uvas);
invoc1.AddProduct(quesoCheddar);

//factura numero 2
products Ancheta = new CompProd(666, "Ancheta", new List<products> { vino, Mani,quesoCheddar }, 12);

Invoice invoc2 = new Invoice();

invoc2.AddProduct(Ancheta);
invoc2.AddProduct(Chocolate);
invoc2.AddProduct(uvas);

Console.WriteLine(invoc1);
Console.WriteLine(invoc2);