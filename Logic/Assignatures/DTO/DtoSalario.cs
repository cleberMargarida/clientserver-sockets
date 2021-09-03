namespace Logic.Assignatures.DTO
{
    public class DtoSalario : DtoBase
    {
        public string Nome { get; set; }

        public string Nivel { get; set; }

        public double SalarioBruto { get; set; }

        public int Dependentes { get; set; }
    }
}
