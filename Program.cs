Conta c1 = new Conta(1);
Conta c2 = new Conta(2);
Conta c3 = new Conta(3);


c1.Depositar(1000.00);
c1.Sacar(500.00);
Console.WriteLine(c1.Saldo);

c2.Depositar(1000.00);
c2.Sacar(500.00);
Console.WriteLine(c2.Saldo);

c2.Transferir(c3,100.00);
Console.WriteLine(c3.Saldo);

