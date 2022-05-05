namespace App0003
{
    internal class Paciente
    {
        public string Nome { get; set; } = default!;
        public string Sobrenome { get; set; } = default!;
        public int Idade { get; set; }
        public long CPF { get; set; }
        public DateTime Chegada { get; set; } = default!;
        public string Urgencia { get; set; } = default!;

        public string PegarNome()
        {
            return Nome;
        }
        public string PegarSobrenome()
        {
            return Sobrenome;
        }
        public int PegarIdade()
        {
            return Idade;
        }
        public long PegarCPF()
        {
            return CPF;
        }
        public DateTime PegarChegada()
        {
            return Chegada;
        }
        public string PegarUrgencia()
        {
            return Urgencia;
        }
    }
}