using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Vector_App
{
	class NumGen
	{
		RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
		byte[] data = new byte[4];

		public int probabilityGen()
		{
			rng.GetBytes(data);
			float rng_num = (BitConverter.ToUInt32(data, 0) / (float)4294967295.0) * 100;
			return (int)rng_num;
		}
	}
}
