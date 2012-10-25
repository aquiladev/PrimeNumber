using PrimeNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace PrimeNumberService
{
    public class PrimeNumber : IPrimeNumber
    {
        public string[] GetPrimes()
        {
            return Generator.GetPrimes().ToArray();
        }

        public string[] GetPrimesStartedAt(string beginSigns)
        {
            var value = beginSigns.Trim();
            if (string.IsNullOrEmpty(value))
                return new string[0];

            return Generator.GetPrimes()
                .Where(x => x.StartsWith(value))
                .ToArray();
        }
    }
}
