using Cadastro_de_hospital;
Pessoa paciente1 = new Pessoa();

paciente1.nome = "Marquinhos Antonio";
paciente1.idade = 17;
paciente1.altura = 179;
paciente1.peso = 70.4;

Console.WriteLine($"Nome do paciente: {paciente1.nome}");
Console.WriteLine($"Idade do paciente: {paciente1.idade}"+" anos");
Console.WriteLine($"Altura do paciente: {paciente1.altura}"+" cm");
Console.WriteLine($"Peso do paciente: {paciente1.peso}"+" kg");

Console.ReadKey();