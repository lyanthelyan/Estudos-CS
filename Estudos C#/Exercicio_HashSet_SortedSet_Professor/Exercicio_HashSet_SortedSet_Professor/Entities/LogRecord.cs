namespace Exercicio_HashSet_SortedSet_Professor.Entities
{
    internal class LogRecord
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public LogRecord(string username, DateTime instant)
        {
            Username = username;
            Instant = instant;
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LogRecord))
            {
                return false;
            }
            LogRecord other = obj as LogRecord;
            return Username.Equals(other.Username); // Retorna o username de onde estou para o username do outro
        }
    }
}
