namespace Actividad10_Diccionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Dictionary <string ,double> estudiantes = new Dictionary<string,double>();
            estudiantes.Add("Mario Rodas", 69.5);
            estudiantes.Add("Eduardo Berquefer", 40);
            estudiantes.Add("Alejandra Morales", 98.3);

            if (estudiantes.ContainsKey("Eduardo Berquefer"))
            {
                Console.WriteLine("Nota del estudiante: " + estudiantes["EduardoBerquefer"]);
            }





        }

    }
}
