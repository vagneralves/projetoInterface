using System;
using System.Collections.Generic;
using System.Text;

namespace projetoInterfaces.Dominio
{
	class Contrato
	{
		public int NumeroContrato { get; set; }
		public DateTime DataContrato { get; set; }
		public double ValorTotal { get; set; }

		public Contrato(int numeroContrato, DateTime dataContrato, double valorTotal)
		{
			NumeroContrato = numeroContrato;
			DataContrato = dataContrato;
			ValorTotal = valorTotal;
		}
	}
}
