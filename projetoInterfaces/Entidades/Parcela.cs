using System;
using System.Collections.Generic;
using System.Text;

namespace projetoInterfaces.Dominio
{
	class Parcela
	{
		public DateTime DataPagamento { get; set; }
		public double ValorParcela { get; set; }
		public Contrato Cont;

		public Parcela(DateTime dataPagamento, double valorParcela, Contrato cont)
		{
			DataPagamento = dataPagamento;
			ValorParcela = valorParcela;
			Cont = cont;
		}
	}
}
