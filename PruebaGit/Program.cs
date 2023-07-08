namespace PruebaGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona()
            {
                Nombre = "Eduardo",
                Apellido = "Citelli",

            };

           var saludo = persona.Saludar();
            Console.WriteLine($"{saludo}");
        }
    }
}