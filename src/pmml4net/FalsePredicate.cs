﻿/*
 * Created by SharpDevelop.
 * User: Damien
 * Date: 25/04/2013
 * Time: 09:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace pmml4net
{
	/// <summary>
	/// Description of FalsePredicate.
	/// 
	/// For FalsePredicate, always returns false.
	/// </summary>
	public class FalsePredicate : AbstractPredicate
	{
		/// <summary>
		/// Evaluate the predicate
		/// </summary>
		/// <param name="dict"></param>
		/// <param name="res"></param>
		/// <returns></returns>
		public override bool Evaluate(Dictionary<string, object> dict, ScoreResult res)
		{
			return false;
		}
	}
}