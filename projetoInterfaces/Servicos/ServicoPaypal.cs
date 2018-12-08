using System;
using System.Collections.Generic;
using System.Text;

namespace projetoInterfaces.Servicos
{
	class ServicoPaypal : IServicoOnlinePagamento
	{
		public double TaxaPagamento(double quantia)
		{
			return quantia += quantia * 0.02;
		}

		public double Juros(double quantia, int numeroMeses)
		{
			return quantia * 0.01 * numeroMeses;
		}
	}
}
