using Nicacio.Relatorio.Design;
using Nicacio.Relatorio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nicacio.Relatorio.ITextSharp.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		private RelatorioDuplicatas getRelatorio()
		{
			var rpt = new RelatorioDuplicatas();
			rpt.BasePath = Server.MapPath("/");

			rpt.PageTitle = "Folha de Pagamento";
			rpt.ImprimirCabecalhoPadrao = true;
			rpt.ImprimirRodapePadrao = true;

			return rpt;
		}
		private RelatorioDuplicatasDynamic RelatorioDuplicatasGeneric()
		{
			var rpt = new RelatorioDuplicatasDynamic();
			rpt.BasePath = Server.MapPath("/");
			rpt.PageTitle = "Folha de Pagamento";
			rpt.ImprimirCabecalhoPadrao = true;
			rpt.Paisagem = true;
			rpt.ImprimirRodapePadrao = true;
			var lItens = new DadosRelatorio().duplicatas;
			var lItensViewModel = lItens.Select(x => new ReportDuplicata
			{
				Emissao = x.Emissao.ToString(),
				Numero = x.Numero,
				Saldo = x.Saldo.ToString(),
				Vencimento = x.Vencimento.ToString(),
				Valor = x.Valor.ToString(),
				RazaoSocial = x.cliente.RazaoSocial
			}).ToList();
			lItensViewModel.AddRange(lItens.Select(x => new ReportDuplicata
			{
				Emissao = x.Emissao.ToString(),
				Numero = x.Numero,
				Saldo = x.Saldo.ToString(),
				Vencimento = x.Vencimento.ToString(),
				Valor = x.Valor.ToString(),
				RazaoSocial = x.cliente.RazaoSocial
			}).ToList());
			lItensViewModel.AddRange(lItens.Select(x => new ReportDuplicata
			{
				Emissao = x.Emissao.ToString(),
				Numero = x.Numero,
				Saldo = x.Saldo.ToString(),
				Vencimento = x.Vencimento.ToString(),
				Valor = x.Valor.ToString(),
				RazaoSocial = x.cliente.RazaoSocial
			}).ToList());
			lItensViewModel.AddRange(lItens.Select(x => new ReportDuplicata
			{
				Emissao = x.Emissao.ToString(),
				Numero = x.Numero,
				Saldo = x.Saldo.ToString(),
				Vencimento = x.Vencimento.ToString(),
				Valor = x.Valor.ToString(),
				RazaoSocial = x.cliente.RazaoSocial
			}).ToList());
			lItensViewModel.AddRange(lItens.Select(x => new ReportDuplicata
			{
				Emissao = x.Emissao.ToString(),
				Numero = x.Numero,
				Saldo = x.Saldo.ToString(),
				Vencimento = x.Vencimento.ToString(),
				Valor = x.Valor.ToString(),
				RazaoSocial = x.cliente.RazaoSocial
			}).ToList());
			lItensViewModel.AddRange(lItens.Select(x => new ReportDuplicata
			{
				Emissao = x.Emissao.ToString(),
				Numero = x.Numero,
				Saldo = x.Saldo.ToString(),
				Vencimento = x.Vencimento.ToString(),
				Valor = x.Valor.ToString(),
				RazaoSocial = x.cliente.RazaoSocial
			}).ToList());
			lItensViewModel.AddRange(lItens.Select(x => new ReportDuplicata
			{
				Emissao = x.Emissao.ToString(),
				Numero = x.Numero,
				Saldo = x.Saldo.ToString(),
				Vencimento = x.Vencimento.ToString(),
				Valor = x.Valor.ToString(),
				RazaoSocial = x.cliente.RazaoSocial
			}).ToList());
			lItensViewModel.AddRange(lItens.Select(x => new ReportDuplicata
			{
				Emissao = x.Emissao.ToString(),
				Numero = x.Numero,
				Saldo = x.Saldo.ToString(),
				Vencimento = x.Vencimento.ToString(),
				Valor = x.Valor.ToString(),
				RazaoSocial = x.cliente.RazaoSocial
			}).ToList());
			lItensViewModel.AddRange(lItens.Select(x => new ReportDuplicata
			{
				Emissao = x.Emissao.ToString(),
				Numero = x.Numero,
				Saldo = x.Saldo.ToString(),
				Vencimento = x.Vencimento.ToString(),
				Valor = x.Valor.ToString(),
				RazaoSocial = x.cliente.RazaoSocial
			}).ToList());
			lItensViewModel.AddRange(lItens.Select(x => new ReportDuplicata
			{
				Emissao = x.Emissao.ToString(),
				Numero = x.Numero,
				Saldo = x.Saldo.ToString(),
				Vencimento = x.Vencimento.ToString(),
				Valor = x.Valor.ToString(),
				RazaoSocial = x.cliente.RazaoSocial
			}).ToList());
			rpt.MontarTitulo("Número", "Emissão", "Vencimento", "Valor", "Saldo", "Saldo Novamente");
			rpt.MontarValores<ReportDuplicata>(lItensViewModel, 
				(x) => x.RazaoSocial,
				(x) => x.Numero, 
				(x) => x.Emissao, 
				(x) => x.Vencimento, 
				(x) => x.Valor, 
				(x) => x.Saldo,
				(x) => x.Saldo);
			return rpt;
		}
		public ActionResult Preview()
		{
			var rpt = getRelatorio();

			return File(rpt.GetOutput().GetBuffer(), "application/pdf");
		}
		public ActionResult Preview2()
		{
			var rpt = RelatorioDuplicatasGeneric();

			return File(rpt.GetOutput().GetBuffer(), "application/pdf");
		}
		public FileResult BaixarPDF()
		{
			var rpt = getRelatorio();

			return File(rpt.GetOutput().GetBuffer(), "application/pdf", "Documento.pdf");
		}
	}
}