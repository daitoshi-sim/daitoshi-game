using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Daitoshi;

namespace Daitoshi
{
    public class Employee 
    {
        public Citizen citizen;
        public float salary;
        public Employee(Citizen citizen, float salary)
        {
            this.citizen = citizen;
            this.salary = salary;
        }

    }
}
