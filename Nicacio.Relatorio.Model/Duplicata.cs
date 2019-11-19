using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nicacio.Relatorio.Model
{
	public class Duplicata
	{
		public Cliente cliente { get; set; }
		public string Numero { get; set; }
		public DateTime Emissao { get; set; }
		public DateTime Vencimento { get; set; }
		public decimal Valor { get; set; }
		public decimal Saldo { get; set; }
	}
	public class ReportDuplicata
	{
		public string cliente { get; set; }
		public string Numero { get; set; }
		public string Emissao { get; set; }
		public string Vencimento { get; set; }
		public string Valor { get; set; }
		public string Saldo { get; set; }
		public string RazaoSocial { get; set; }
	}
}
