﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Daitoshi;

namespace Daitoshi
{
    public class Office : Building
    {
        public IList<Employee> employees;
        public int employeeCapacity;
        public float fixedCost;
        public Office()
        {

        }
         public float processWork(Employee employee){
            //Revenue from employee = Building Wealth + Employee Work Quality
            return 0.0f;
        }
    }
}
