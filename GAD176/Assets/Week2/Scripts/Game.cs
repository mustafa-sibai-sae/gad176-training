using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Week2
{
    public class Game : MonoBehaviour
    {
        void Start()
        {
            Enemy e = new Dragon();
            e.Attack();
        }

        void Update()
        {

        }
    }
}