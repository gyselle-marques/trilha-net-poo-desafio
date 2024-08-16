using DesafioPOO.Models;

Console.WriteLine("[Smartphone Nokia]");
Smartphone nokia = new Nokia(numero: "11912345678", modelo: "Nokia Modelo 1", iMEI: "123456789123456", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("--------------------------------------------------------");

Console.WriteLine("[Smartphone iPhone]");
Smartphone iphone = new Iphone(numero: "11789456123", modelo: "Iphone Modelo 1", iMEI: "789456123789456", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");