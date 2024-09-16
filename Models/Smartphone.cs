namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public override string ToString()
        {
            var tipo = this.GetType().ToString().Split(".");
            int ultimoElemento = tipo.Length;
            return $"Numero: {Numero}\nModelo: {Modelo}\nImei: {IMEI}\nMemoria: {Memoria}\nTipo: {tipo[ultimoElemento - 1]}";
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}