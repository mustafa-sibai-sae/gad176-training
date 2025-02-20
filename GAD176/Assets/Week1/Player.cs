using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Week1
{
    [ExecuteInEditMode]
    public class Player : MonoBehaviour
    {
        [SerializeField] TMP_Text posText;
        [SerializeField] GameObject enemy;

        void Start()
        {
            Vector3 direction = new Vector3(
                transform.position.x - transform.position.x,
                enemy.transform.position.y - transform.position.y,
                transform.position.z - transform.position.z);

            float sum = Mathf.Pow(direction.x, 2) + Mathf.Pow(direction.y, 2) + Mathf.Pow(direction.z, 2);
            float m = Mathf.Sqrt(sum);

            posText.text = $"P: {transform.position.ToString()},\nD: {direction.ToString()}\nM: {m}";
        }

        void Update()
        {

        }

        void OnDrawGizmos()
        {
            Gizmos.color = Color.white;
            Gizmos.DrawLine(transform.position,
                new Vector3(transform.position.x,
                            enemy.transform.position.y,
                            transform.position.z));
        }
    }
}