using ByteBank.Contas;
using ByteBank.Titular;

// ContaCorrente contaAndre = new ContaCorrente();
// contaAndre.titular = "André Silva";
// contaAndre.numeroAgencia = 15;
// contaAndre.conta = "1010-X";
// contaAndre.saldo = 100.0;

// Console.WriteLine(contaAndre.titular + ":");
// Console.WriteLine("Saldo = " + contaAndre.saldo);

// contaAndre.Depositar(100.0);
// Console.WriteLine("Saldo pós-depósito = " + contaAndre.saldo);

// contaAndre.Sacar(50.0);
// Console.WriteLine("Saldo pós-saque = " + contaAndre.saldo);

// if (contaAndre.Sacar(300.0))
// {
//     Console.WriteLine("Saldo pós-saque = " + contaAndre.saldo);
// }
// else
// {
//     Console.WriteLine("Saldo insuficiente para o saque");
// }


// ContaCorrente contaMaria = new ContaCorrente();
// contaMaria.titular = "Maria da Conceição";
// contaMaria.numeroAgencia = 17;
// contaMaria.conta = "1515-Y";
// contaMaria.saldo = 300.0;

// Console.WriteLine("\n" + contaMaria.titular + ":");
// Console.WriteLine("Saldo = " + contaMaria.saldo);

// contaAndre.Transferir(50, contaMaria);
// Console.WriteLine("Saldo " + contaAndre.titular + " pós-transferência = " + contaAndre.saldo);
// Console.WriteLine("Saldo pós-transferência = " + contaMaria.saldo);

// Cliente cliente = new Cliente();
// cliente.nome = "André";
// cliente.cpf = "000.000.000-00";
// cliente.profissao = "Analista de sistemas";

// ContaCorrente conta = new ContaCorrente();
// conta.titular = cliente;
// conta.conta = "1010-X";
// conta.numeroAgencia = 15;
// conta.saldo = 100;

// Console.WriteLine("Titular: " + conta.titular.nome);


// ContaCorrente conta2 = new ContaCorrente();
// conta2.titular = new Cliente();
// conta2.titular.nome = "José";

// Console.WriteLine("Titular: " + conta2.titular.nome);


// ContaCorrente conta3 = new ContaCorrente();

// conta3.DefinirSaldo(-10);
// Console.WriteLine(conta3.ObterSaldo());

// conta3.DefinirSaldo(200);
// Console.WriteLine(conta3.ObterSaldo());

// conta3.NumeroAgencia = 19;
// Console.WriteLine(conta3.NumeroAgencia);

// conta3.Conta = "1010-X";
// Console.WriteLine(conta3.Conta);

ContaCorrente conta4 = new ContaCorrente(18, "1015-W");
conta4.Titular = new Cliente("José", "123.456.789-10");

// Console.WriteLine(conta4.NumeroAgencia);
// Console.WriteLine(conta4.Titular.Nome);
Console.WriteLine(ContaCorrente.TotalContasCriadas);

ContaCorrente conta5 = new ContaCorrente(19, "1010-X");
Console.WriteLine(ContaCorrente.TotalContasCriadas);