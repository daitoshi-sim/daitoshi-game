using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Daitoshi;

namespace Daitoshi
{
    public class Commerical : Building
    {
        public IList<Employee> employees;
        public IList<Citizen> customers;
        public CommercialType type;
        public Commerical()
        {

        }

    }
}
