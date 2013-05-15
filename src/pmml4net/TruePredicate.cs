﻿/*
 * Created by SharpDevelop.
 * User: Damien
 * Date: 25/04/2013
 * Time: 09:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Xml;

namespace pmml4net
{
	/// <summary>
	/// Description of TruePredicate.
	/// </summary>
	public class TruePredicate : Predicate
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="dict"></param>
		/// <returns></returns>
		public override PredicateResult Evaluate(Dictionary<string, object> dict)
		{
			return PredicateResult.True;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="writer"></param>
		public override void save(XmlWriter writer)
		{
			writer.WriteStartElement("True");
			writer.WriteEndElement();
		}
	}
}
