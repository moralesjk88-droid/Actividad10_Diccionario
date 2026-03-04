namespace Actividad10_Diccionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //ejercicios2
            Dictionary<int, string> productos = new Dictionary<int, string>();

            productos.Add(200521, "leche");
            productos.Add(201015, "Papel");
            productos.Add(200419, "Envace de Agua");

            foreach (var item in productos)
            {
                Console.WriteLine("Codigo:_ "+item.Key+" Nombre del producto:_ "+item.Value);

            }

          }

    }
}
