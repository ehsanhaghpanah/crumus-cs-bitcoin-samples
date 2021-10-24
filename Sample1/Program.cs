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
			//var ky = new Key().GetWif(Network.Main);
			//Console.WriteLine($"key = {ky}");

			test1();
		}

		static void generate_key()
		{
			//
			// generating a private key
			var prKy = new Key();

			//
			// public key is calculated from private key
			var pbKy = prKy.PubKey;
			Console.WriteLine(pbKy);

			Console.WriteLine(pbKy.GetAddress(ScriptPubKeyType.Legacy, Network.TestNet));
		}

		static public void test1()
		{
			//
			// generating a private key
			var prKy = new Key();

			//
			// public key is calculated from private key
			var pbKy = prKy.PubKey;
			Console.WriteLine(pbKy);

			//
			// getting address for each network
			Console.WriteLine(pbKy.GetAddress(ScriptPubKeyType.Legacy, Network.Main));
			Console.WriteLine(pbKy.GetAddress(ScriptPubKeyType.Legacy, Network.TestNet));

			//
			// public key hash
			Console.WriteLine(pbKy.Hash);

			//
			// getting address for each network from public key hash
			var pbAdr_main = pbKy.Hash.GetAddress(Network.Main);
			var pbAdr_test = pbKy.Hash.GetAddress(Network.TestNet);
			Console.WriteLine(pbAdr_main);
			Console.WriteLine(pbAdr_test);

			//
			// script public key
			Console.WriteLine(pbAdr_main.ScriptPubKey);
			Console.WriteLine(pbAdr_test.ScriptPubKey);
		}
	}
}
