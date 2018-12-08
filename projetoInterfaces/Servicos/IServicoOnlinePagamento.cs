namespace projetoInterfaces.Servicos
{
	interface IServicoOnlinePagamento
	{
		double TaxaPagamento(double quantia);
		double Juros(double quantia, int numeroMeses);

	}
}
