namespace QuartosAlugados;

class Quartos
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Room { get; set; }

    public Quartos(string name, string email, int room)
    {
        Name = name;
        Email = email;
        Room = room;
    }

    // Construtor sobrecarregado sem número de quartoO construtor sobrecarregado sem o parâmetro Room serve para permitir a criação de instâncias da classe Quartos sem especificar inicialmente o número do quarto. Isso pode ser útil em situações em que você não tem imediatamente o número do quarto disponível ou se deseja atribuir o número do quarto posteriormente, por exemplo, após validar a disponibilidade do quarto.No código fornecido, este construtor pode ser útil quando o usuário deseja apenas inserir os detalhes do locatário, mas ainda não selecionou um quarto específico. Por exemplo, antes de inserir os detalhes do locatário, o usuário pode querer verificar a disponibilidade dos quartos. Nesse caso, uma instância de Quartos pode ser criada sem especificar o número do quarto e, posteriormente, o número do quarto pode ser atribuído antes de armazená-lo no array rooms.

    public Quartos(string name, string email) : this(name, email, 0)
    {
    }
}
