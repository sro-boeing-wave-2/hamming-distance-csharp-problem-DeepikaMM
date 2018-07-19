﻿using System;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
            int hammingDistance = 0;
            if(original == null)

            {
                throw new ArgumentNullException("original");
            }
            else if(current == null)
            {
                throw new ArgumentNullException("current");
            }
            else if(original.Length != current.Length)
            {
                throw new ArgumentException("Hamming Distance can only be calculated over strings of equal length");
            }
            else
            {
                for(int k=0;k<original.Length; k++)
                {
                    if(original[k]!= current[k])
                    {
                        hammingDistance++;
                    }
                }
                return hammingDistance;
            }
             
        }
    }
}
