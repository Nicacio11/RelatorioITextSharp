using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nicacio.Relatorio.Model
{
	public class DadosRelatorio
	{
		public List<Duplicata> duplicatas { get; set; }

		public DadosRelatorio()
		{
			duplicatas = new List<Duplicata>();

			var cliente = new Cliente();
			cliente.Id = 1;
			cliente.RazaoSocial = "Aristides Beltrano Silva Junior";

			var duplicata = new Duplicata();
			duplicata.cliente = cliente;
			duplicata.Numero = "0003589-01";
			duplicata.Emissao = new DateTime(2016, 6, 1);
			duplicata.Vencimento = new DateTime(2016, 6, 15);
			duplicata.Valor = 1500M;
			duplicata.Saldo = 1500M;
			duplicatas.Add(duplicata);
			duplicata = null;

			duplicata = new Duplicata();
			duplicata.cliente = cliente;
			duplicata.Numero = "0003369-01";
			duplicata.Emissao = new DateTime(2016, 6, 2);
			duplicata.Vencimento = new DateTime(2016, 6, 15);
			duplicata.Valor = 523.63M;
			duplicata.Saldo = 523.63M;
			duplicatas.Add(duplicata);
			duplicata = null;
			cliente = null;

			cliente = new Cliente();
			cliente.Id = 2;
			cliente.RazaoSocial = "Atanagildo Loureiro da Luz";

			duplicata = new Duplicata();
			duplicata.cliente = cliente;
			duplicata.Numero = "1003329-02";
			duplicata.Emissao = new DateTime(2016, 6, 2);
			duplicata.Vencimento = new DateTime(2016, 6, 5);
			duplicata.Valor = 1452M;
			duplicata.Saldo = 0M;
			duplicatas.Add(duplicata);
			duplicata = null;

			duplicata = new Duplicata();
			duplicata.cliente = cliente;
			duplicata.Numero = "1003321-01";
			duplicata.Emissao = new DateTime(2016, 6, 4);
			duplicata.Vencimento = new DateTime(2016, 6, 10);
			duplicata.Valor = 2536.63M;
			duplicata.Saldo = 1530.00M;
			duplicatas.Add(duplicata);
			duplicata = null;
			cliente = null;

			cliente = new Cliente();
			cliente.Id = 3;
			cliente.RazaoSocial = "Roger Medeiros da Silva";

			duplicata = new Duplicata();
			duplicata.cliente = cliente;
			duplicata.Numero = "0003333-01";
			duplicata.Emissao = new DateTime(2016, 6, 9);
			duplicata.Vencimento = new DateTime(2016, 7, 10);
			duplicata.Valor = 652.30M;
			duplicata.Saldo = 652.30M;
			duplicatas.Add(duplicata);
			duplicata = null;

			duplicata = new Duplicata();
			duplicata.cliente = cliente;
			duplicata.Numero = "0003336-01";
			duplicata.Emissao = new DateTime(2016, 6, 4);
			duplicata.Vencimento = new DateTime(2016, 6, 10);
			duplicata.Valor = 2536.63M;
			duplicata.Saldo = 1530.00M;
			duplicatas.Add(duplicata);
			duplicata = null;
		}
	}
}
