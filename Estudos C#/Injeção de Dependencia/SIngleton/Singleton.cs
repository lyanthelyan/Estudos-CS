namespace Injeção_de_Dependencia.SIngleton
{
    internal class Singleton : ISigleton
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Execute()
        {
            return $"Singleton Id: {Id}";
        }
    }
}
