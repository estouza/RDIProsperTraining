public class Gerente : Funcionario
{
    public double Bonus { get; set; }

    // Gerente novoGerente = new Gerente(900.00, "João", 5000.00, "29/12/2011")
    // base -> serve para passarmos informações para o construtor do pai
    public Gerente(double bonus, string nome, double salario, string data)
        : base(nome, salario, data)
    {
        Bonus = bonus;
    }

    public void MostrarNome()
    {
    }
}
