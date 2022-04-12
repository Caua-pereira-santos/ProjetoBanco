public class Conta
{
    public int Codigo { get;  }
    public double Saldo { get; private set; }

    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }

    public void Sacar(double valor)
    {
        Saldo = Saldo - valor;

    if (valor > Saldo) 
    {
        throw new ArgumentException ("Você está tentando sacar um valor maior que o saldo presente na sua conta");
    }

    }
     

    public void Depositar(double valor)
    {
        Saldo = Saldo + valor;
    }

    public void Transferir(Conta conta, double valor)
    {
      if(Saldo >= valor)
      {
          Saldo = Saldo - valor;
          conta.Saldo = conta.Saldo + valor;
      }
    }
}