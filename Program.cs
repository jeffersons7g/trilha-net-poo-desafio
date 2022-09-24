using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia1 = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111", 64);
nokia1.Ligar();
nokia1.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone1 = new Iphone(numero: "010203", modelo: "Modelo 20", imei: "9191", 128);
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Telegram");