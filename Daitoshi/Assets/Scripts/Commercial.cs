using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Daitoshi;

namespace Daitoshi
{
    public class Commercial : Building
    {
        public IList<Employee> employees;
        public int employeeCapacity;
        public IList<Citizen> customers;
        public int customerCapacity;
        public CommercialType type;
        public float fixedCost;
        public Commercial()
        {

        }
        public float serveCustomer(Citizen citizen){
            //Revenue from customer = Buidling Wealth + Citizen Frugality + Citizen cash reserves + Employee Work Quality
            return 0.0f;
        }
    }
}
