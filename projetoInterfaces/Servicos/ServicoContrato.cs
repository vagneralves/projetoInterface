using System;
using System.Collections.Generic;
using projetoInterfaces.Entidades;

namespace projetoInterfaces.Servicos
{
	class ServicoContrato
	{
		public Contrato Cont { get; set; }
		public int Meses { get; set; }
		private ServicoPaypal sp;

		public ServicoContrato(Contrato cont, int meses)
		{
			Cont = cont;
			Meses = meses;
		}

		public void ProcessarContrato(Contrato c, int meses)
		{
			
		}
	}
}
