using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Daitoshi;

namespace Daitoshi
{
    public class Business : Building
    {
        public IList<Employee> employees;
        public int employeeCapacity;
        
        public float fixedCost;

        public float cash;

        public Business()
        {

        }
    }
}
