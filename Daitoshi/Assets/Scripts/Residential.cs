using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Daitoshi;

namespace Daitoshi
{
    public class Residential : Building
    {
        public IList<Citizen> residents;

        public Residential()
        {
            residents = new List<Citizen>();

        }

    }
}
