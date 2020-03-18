﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Daitoshi;

namespace Daitoshi
{
    public class Citizen : MonoBehaviour
    {
        /// <summary>
        /// Akin to the work ethic of this person. Will affect their output at work.
        /// </summary>
       public int workQuality;
       public float cash;
       /// <summary>
       /// This value will affect how willing the person is to spend money at commercial buildings
       /// </summary>
       public int frugality;
       public int goodsNeeds;
       public int servicesNeeds;
       public int leisureNeeds;
       public Building workplace; 

       public Citizen()
        {

        }
        public void goToWork()
        {

        }
    }
}
