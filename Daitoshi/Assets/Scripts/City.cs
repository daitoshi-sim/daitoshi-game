using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Daitoshi;

namespace Daitoshi
{
    public class City : MonoBehaviour
    {
        public IList<Business> Businesses;
        public IList<Commercial> CommercialBuildings;
        public IList<Residential> Residences;
        public IList<Citizen> Citizens;
        public City()
        {

        }
    }
}
