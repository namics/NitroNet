﻿using System;
using System.Reflection;
using Veil.Compiler;

namespace NitroNet.ViewEngine.ViewEngines
{
    [Obsolete("will be removed as soon final switch to handlebarsnet is completed")]
    public class MemberLocatorFromNamingRule : MemberLocator
	{
		private readonly INamingRule _namingRule;

		public MemberLocatorFromNamingRule(INamingRule namingRule)
		{
			_namingRule = namingRule;
		}

		public override MemberInfo FindMember(Type modelType, string name, MemberTypes types)
		{
            return base.FindMember(modelType, _namingRule.GetPropertyName(name), types);
        }

	}
}