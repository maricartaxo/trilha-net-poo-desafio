using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia (numero: "90941803", modelo: "SW2", imei: "7894561230", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone (numero: "87388708", modelo: "15 PRO-Max", imei: "321654970", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone2 = new Iphone (numero: "99859247", modelo: "11", imei: "7410852963", memoria: 32);
iphone2.Ligar();
iphone2.ReceberLigacao();

