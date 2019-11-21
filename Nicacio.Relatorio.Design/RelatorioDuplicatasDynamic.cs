using iTextSharp.text;
using iTextSharp.text.pdf;
using Nicacio.Relatorio.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Nicacio.Relatorio.Design
{
	public class RelatorioDuplicatasDynamic : Report
	{
		private int QuantidadeTitulo = 0;
		private string[] Titulos;
		private string[,] CorpoValores;
		public RelatorioDuplicatasDynamic()
		{
			Paisagem = false;
		}
		public override void MontarCorpoDados()
		{
			base.MontarCorpoDados();
			#region Cabeçalho do Relatório
			PdfPTable table = new PdfPTable(Titulos.Length);
			BaseColor preto = new BaseColor(0, 0, 0);
			BaseColor fundo = new BaseColor(200, 200, 200);
			Font font = FontFactory.GetFont("Verdana", 8, Font.NORMAL, preto);
			Font tituloFonte = FontFactory.GetFont("Verdana", 8, Font.BOLD, preto);

			//float[] colsW = { 10, 10, 10, 10, 10 };
			float[] Colunas = DefinirTamanhoColuna(Titulos.Length);
			table.SetWidths(Colunas);
			table.HeaderRows = 1;
			table.WidthPercentage = 100f;

			table.DefaultCell.Border = PdfPCell.BOTTOM_BORDER;
			table.DefaultCell.BorderColor = preto;
			table.DefaultCell.BorderColorBottom = new BaseColor(255, 255, 255);
			table.DefaultCell.Padding = 10;

			foreach (var tituloTexto in Titulos)
			{
				table.AddCell(getNewCell(tituloTexto, tituloFonte, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
			}

			for (int i = 0; i < CorpoValores.GetLength(0); i++)
			{
				for (int indexReference = 0; indexReference < 1; indexReference++)
				{
					var cell = getNewCell(CorpoValores[i, indexReference], tituloFonte, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER);
					cell.Colspan = Titulos.Length;
					table.AddCell(cell);
				}
				for (int j = 1; j < CorpoValores.GetLength(1); j++)
				{
					table.AddCell(getNewCell(CorpoValores[i, j], font, Element.ALIGN_LEFT, Colunas.First(), PdfPCell.BOTTOM_BORDER));
				}

			}
			doc.Add(table);
			#endregion
		}
		public void MontarTitulo(params string[] pTitulos)
		{
			QuantidadeTitulo = pTitulos.Length;
			Titulos = pTitulos;
		}

		public void MontarValores<TEntidade>(List<TEntidade> entidades, params Expression<Func<TEntidade, string>>[] expression)
		{
			int Altura = entidades.Count();
			int Largura = expression.Length;
			var vEntidades = entidades.ToArray();
			CorpoValores = new string[Altura, Largura];

			for (var i = 0; i < vEntidades.Length; i++)
			{
				for (int j = 0; j < Largura; j++)
				{
					var value = vEntidades[i].GetPropertyName(expression[j]).ToString();
					CorpoValores[i, j] = value.ToString();
				}
			}
		}
		private float[] DefinirTamanhoColuna(int QuantidadeColunas)
		{
			float[] retorno = new float[QuantidadeColunas];
			for (int i = 0; i < QuantidadeColunas; i++)
			{
				retorno[i] = 50 / QuantidadeColunas;
			}
			return retorno;
		}
	}
}
