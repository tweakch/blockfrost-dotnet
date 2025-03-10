﻿using System;

namespace Blockfrost.Api.Extensions
{
    // from https://github.com/CardanoSharp/cardanosharp-wallet/blob/49d63543541f2a2e4797061bd5bff9e454bd11c6/CardanoSharp.Wallet/Extensions/ByteArrayExtension.cs
    public static class ByteArrayExtensions
    {
        /// <summary>
        /// Returns the last n bits of the byte
        /// </summary>
        /// <param name="b"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int LastBits(this byte b, int n)
        {
            if (n > 8)
            {
                throw new InvalidOperationException($"{nameof(n)} must be <= 8");
            }

            int mask = ~(0xff >> n << n);
            return b & mask;
        }

        public static int GetHexVal(char hex)
        {
            int val = hex;
            //For uppercase A-F letters:
            //return val - (val < 58 ? 48 : 55);
            //For lowercase a-f letters:
            //return val - (val < 58 ? 48 : 87);
            //Or the two combined, but a bit slower:
            return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
        }
        //Research speed of string to byte[]
        public static byte[] HexToByteArray(this string hex)
        {
            if (hex.Length % 2 == 1)
            {
                throw new ArgumentException("The binary key cannot have an odd number of digits");
            }

            byte[] arr = new byte[hex.Length >> 1];

            for (int i = 0; i < hex.Length >> 1; ++i)
            {
                arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + GetHexVal(hex[(i << 1) + 1]));
            }

            return arr;
        }
    }
}
