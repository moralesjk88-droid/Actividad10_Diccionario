namespace Actividad10_Diccionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Dictionary <int ,string  > estudiantes = new Dictionary<int,string>();
              estudiantes.Add(202618, "Maria");
              estudiantes.Add(202620, "Juan");
              estudiantes.Add(202619, "Carlos");

              foreach (var item in estudiantes)
              {
                  Console.WriteLine(item.Key + "-"+item.Value);   
              }
              Console.WriteLine("Nombre del estudiante en especifico:_" + estudiantes[202620]);*/

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
