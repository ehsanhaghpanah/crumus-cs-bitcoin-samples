/**
 * Copyright (C) crumüs, 2018.
 * All rights reserved.
 * Ehsan Haghpanah; haghpanah@crumus.com
 */

using System;
using NBitcoin;

namespace Sample1
{
	static public class Program
	{
		static void Main(string[] args)
		{
			var ky = new Key().GetWif(Network.Main);
			Console.WriteLine($"key = {ky}");
		}
	}
}
