using DesafioPOO.Models;

Console.WriteLine("Celular Nokia:");
Nokia nokia = new Nokia(numero: "123", modelo: "Modelo 1", imei: "111111", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Celular iPhone:");
Iphone iphone = new Iphone(numero: "456", modelo: "Modelo 2", imei: "222222", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
