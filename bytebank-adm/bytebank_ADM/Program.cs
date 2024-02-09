using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

#region
//Funcionario joao = new Auxiliar("123456789");
//joao.Nome = "João Vitinho";

//Console.WriteLine(joao.Nome);
//Console.WriteLine("Salário do joao = " +joao.Salario);
//Console.WriteLine(joao.GetBonificacao());

//Diretor iris = new Diretor("987654321");
//iris.Nome = "Iri Marinha";

//Console.WriteLine(iris.Nome);
//Console.WriteLine("Salário da iri = " + iris.Salario);
//Console.WriteLine(iris.GetBonificacao());

//Gerenciador_de_Bonificacao gerenciador = new Gerenciador_de_Bonificacao();

//gerenciador.Registrar(joao);
//gerenciador.Registrar(iris);

//Console.WriteLine("Total de bonificações: "+ gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

//joao.AumentarSalario();
//iris.AumentarSalario();

//Console.WriteLine("novo salario joao =" + joao.Salario);
//Console.WriteLine("novo salario iri =" + iris.Salario);
#endregion

//CalcularBonificacao();

UsarSistema();

#region
void CalcularBonificacao()
{
    Gerenciador_de_Bonificacao gerenciador = new Gerenciador_de_Bonificacao();

    Designer luiz = new Designer("cpf do luiz");
    luiz.Nome = "Luiz Podre";

    Diretor silvia = new Diretor("cpf da silvia");
    silvia.Nome = "Silbanabrs";

    Auxiliar marcos = new Auxiliar("cpf do marcos");
    marcos.Nome = "Marconha Gamer";

    GerenteDeConta bucha = new GerenteDeConta("cpf do bucha");
    bucha.Nome = "Bucharino";

    gerenciador.Registrar(luiz);
    gerenciador.Registrar(silvia);
    gerenciador.Registrar(marcos);
    gerenciador.Registrar(bucha);

    Console.WriteLine("Total de bonificação: " + gerenciador.TotalDeBonificacao);
}
#endregion

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor rubem = new Diretor("123456");
    rubem.Nome = "Rubens Emanuel";
   // rubem.Login = "Rubinho1";
    rubem.Senha = "filhodairi";

    GerenteDeConta joana = new GerenteDeConta("000000");
    joana.Nome = "Joarina";
    //joana.Login = "jou1";
    joana.Senha = "amigadairi";

    ParceiroComercial tone = new ParceiroComercial();

    tone.Senha = "tonemagico";

    sistema.Logar(rubem, "filhodairi");
    sistema.Logar(joana, "amigadairis");
    sistema.Logar(tone, "tonemagico");
}