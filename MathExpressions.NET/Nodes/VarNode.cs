﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathExpressionsNET
{
	public class VarNode : MathFuncNode
	{
		public VarNode(string variable)
		{
			Name = variable;
		}

		public override MathNodeType Type
		{
			get { return MathNodeType.Variable; }
		}

		public override bool IsTerminal
		{
			get { return true; }
		}
	}
}
