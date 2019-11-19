using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Nicacio.Relatorio.Extensions
{
	public static class Extensions
	{
		public static TEntidade GetValue<TEntidade>(this IQueryable<TEntidade> lista, Expression<Func<TEntidade, bool>> expression)
		{
			return lista.Where(expression).FirstOrDefault();
		}
		public static string GetPropertyName<TSource, TResult>(this TSource objeto, Expression<Func<TSource, TResult>> expression)
		{
			var me = expression.Body as MemberExpression;
			var propInfo = me.Member as PropertyInfo;
			var value = propInfo.GetValue((objeto), null).ToString();
			return value;
		}

	}
}
