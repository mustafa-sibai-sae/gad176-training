using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Delete this name space
public class Dragon : Enemy
{
    public override void NotAttack()
    {
        print("I am not attacking");
    }
}
