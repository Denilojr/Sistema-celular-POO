using DesafioPOO.Models;


Console.WriteLine("Smartphone Iphone");
Smartphone celular1 = new Iphone(numero: "31989459999", modelo: "Iphone 14PRO", imei: "1111", memoria: 256);
Console.Write($"Numero: {celular1.Numero}\n");
celular1.InstalarAplicativo("Subway Surf");
celular1.Ligar();

Console.WriteLine();

Console.WriteLine("Smartphone Nokia");
Smartphone celular2 = new Iphone(numero: "3199883030", modelo: "Nokia 1100", imei: "1111", memoria: 16);
Console.Write($"Numero: {celular2.Numero}\n");
celular2.InstalarAplicativo("Telegram");
celular2.ReceberLigacao();