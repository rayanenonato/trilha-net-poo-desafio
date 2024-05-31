namespace DesafioPOO.Models
{
    

    public class Nokia : Smartphone
    {
        public Nokia(string modelo, string imei, string numero, int memoria) : base(modelo,imei,numero,memoria)
        {

        }
       
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }
    }
}