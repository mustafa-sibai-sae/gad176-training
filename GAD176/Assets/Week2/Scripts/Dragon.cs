using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Week3
{
    public class Dragon : Enemy
    {
        public override void WAter()
        {
            print("watering!");
        }

        public override void Attack()
        {
            print("attacking!");
        }
    }
}