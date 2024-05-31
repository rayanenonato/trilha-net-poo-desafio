using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456789", modelo:"Modelo 5", imei:"222322", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "999582554", modelo:"Modelo 11", imei:"222322", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("tiktok");
