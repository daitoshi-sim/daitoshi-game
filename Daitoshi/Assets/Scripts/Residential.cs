using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Daitoshi;

namespace Daitoshi
{
    public class Residential : Building
    {
        public IList<Citizen> residents;
        // Start is called before the first frame update
        public Residential()
        {
            residents = new List<Citizen>();
        }

    }
}
