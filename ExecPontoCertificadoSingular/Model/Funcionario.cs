namespace PontoCertificadoSingularExercicio.Model
{
    public class Funcionario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public char sexo { get; set; }
        public int cpf { get; set; }
        public int pis { get; set; }
        public decimal salario { get; set; }
        public string email { get; set; }
        public System.DateTime dataAdmissao { get; set; }
    }
}
