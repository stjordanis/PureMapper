namespace Kritikos.PureMap.Contracts
{
	using System;
	using System.Collections.Generic;
	using System.Linq.Expressions;

	public interface IPureMapperConfig
	{
		List<(Type Source, Type Dest, string name, Func<IPureMapperResolver, LambdaExpression> Expr, int RecInlineDepth)> Maps { get; }

		IPureMapperConfig Map<TSource, TDestination>(
			Func<IPureMapperResolver, Expression<Func<TSource, TDestination>>> map,
			int recInlineDepth = 0,
			string name = "")
			where TSource : class
			where TDestination : class;
	}
}
