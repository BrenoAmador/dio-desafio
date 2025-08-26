class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public void CadastrarHospedes(Pessoa hospede)
    {
        Hospedes.Add(hospede);
        Console.WriteLine("Hospede");
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
        Console.WriteLine("Suite");
    }

    public int ObterQuantidadeHospedes()
    {
        return 1;
    }

    public decimal CalcularValorDiaria()
    {

        return 1;
    }

}
