using App0003;

Paciente paciente = new Paciente();

paciente.Nome = Console.ReadLine();
paciente.Sobrenome = Console.ReadLine();
paciente.Idade = int.Parse(Console.ReadLine());
paciente.CPF = long.Parse(Console.ReadLine());
paciente.Urgencia = Console.ReadLine();
paciente.Chegada = DateTime.Now;


string[] lines = { "Nome : " + paciente.PegarNome(), "Senhor(a) : " + paciente.PegarSobrenome(), 
    "Idade : " + paciente.PegarIdade(), "CPF : " + paciente.PegarCPF(), "Urgencia : " + paciente.PegarUrgencia(),
     "Chegada na UPA : " + paciente.PegarChegada()};

string docPath = @"C:\Users\Àlberto Barbòsa\Desktop\PastaImprime";

using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
{
    foreach (string line in lines)
        outputFile.WriteLine(line);
}