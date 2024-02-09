using Bytebank.Contas;
using Bytebank.Titular;
using System.Runtime.CompilerServices;

//ContaCorrente contaDoJoao = new ContaCorrente();
//contaDoJoao.titular = "João Victor Pires";
//contaDoJoao.numeroAgencia = 15;
//contaDoJoao.conta = "1010-X";
//contaDoJoao.saldo = 100;

//Console.WriteLine("Saldo da sua conta é de R$ " + contaDoJoao.saldo + ", " + contaDoJoao.titular.Substring(0, 4) + "!");

//ContaCorrente contaDaIris = new ContaCorrente();
//contaDaIris.titular = "Iris Rodrigues Pereira";
//contaDaIris.numeroAgencia = 17;
//contaDaIris.conta = "1010-5";
//contaDaIris.saldo = 8000000;

//Console.WriteLine("Saldo da sua conta é de R$ " + contaDaIris.saldo + ", " + contaDaIris.titular.Substring(0, 4) + "!");

//contaDoJoao.Transferir(50, contaDaIris);

//Console.WriteLine("Saldo da sua conta é de R$ " + contaDoJoao.saldo + ", " + contaDoJoao.titular.Substring(0, 4) + "!");
//Console.WriteLine("Saldo da sua conta é de R$ " + contaDaIris.saldo + ", " + contaDaIris.titular.Substring(0, 4) + "!");

//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Pedro Drago";

//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numeroAgencia);
//Console.WriteLine(contaDoPedro.conta);


//Cliente cliente = new Cliente();

//cliente.nome = "João Victor Pires";
//cliente.cpf = "123.456.789-0";
//cliente.profissao = "Estudante";

//ContaCorrente conta = new ContaCorrente();

//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numeroAgencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF do titular = "+conta.titular.cpf);
//Console.WriteLine("Profissão do titular = "+conta.titular.profissao);
//Console.WriteLine("Nº da conta = " + conta.conta);
//Console.WriteLine("Nº da agência = " + conta.numeroAgencia);
//Console.WriteLine("Seu saldo é de R$ "+conta.saldo + ", " + conta.titular.nome.Substring(0,4) + "!");

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();

//conta2.titular.nome = "Iris Rodrigues";
//conta2.titular.profissao = "Professora";

ContaCorrente contaTeste = new ContaCorrente(joao , "bytebank", 12, "1010-X");

