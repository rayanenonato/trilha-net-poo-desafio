namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        
        public Iphone(string modelo, string imei, string numero, int memoria) : base(modelo,imei,numero,memoria)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone");
        }
         }
}
