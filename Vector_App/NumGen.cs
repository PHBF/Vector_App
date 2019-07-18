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
		byte[] data = new byte[64]; // 255 * 64 = 16320

		public int probabilityGen()
		{
			rng.GetBytes(data);
			float rng_num = 0;
			for (int i = 0; i <= 63; i++)
			{
				rng_num += data[i];
			}
			rng_num = (rng_num / (float)16320.0) * 100;


			return (int)rng_num;
		}
	}
}
