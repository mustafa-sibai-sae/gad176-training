using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Week2
{
    public class Dragon : Enemy
    {
        public void Water()
        {
            print("watering!");
        }

        public override void Attack()
        {
            print("attacking!");
        }

        public void NotAttack()
        {
            print("I am not attacking");
        }
    }
}
