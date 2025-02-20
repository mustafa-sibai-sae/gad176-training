using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Week1
{
    [ExecuteInEditMode]
    public class Enemy : MonoBehaviour
    {
        [SerializeField] TMP_Text posText;
        [SerializeField] TMP_Text pos2Text;

        [SerializeField] GameObject player;

        Vector3 v2Direction;

        void Start()
        {
            Vector3 v1Direction = new Vector3(
                player.transform.position.x - transform.position.x,
                transform.position.y - transform.position.y,
                transform.position.z - transform.position.z);

            float sum = Mathf.Pow(v1Direction.x, 2) + Mathf.Pow(v1Direction.y, 2) + Mathf.Pow(v1Direction.z, 2);
            float m = Mathf.Sqrt(sum);

            posText.text = $"v1P: {transform.position.ToString()},\nv1D: {v1Direction.ToString()}\nv1M: {m}";

            //--------------------------------------------------------------------------------------------------

            v2Direction = player.transform.position - transform.position;
            float m2 = v2Direction.magnitude;

            v2Direction = new Vector3(
                v2Direction.x / m2,
                v2Direction.y / m2,
                v2Direction.z / m2
                );

            pos2Text.text = $"v1D: {v2Direction.ToString()}\nv1M: {v2Direction.magnitude}\nNV: {v2Direction.ToString()}";
        }

        void Update()
        {

        }

        void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position,
                new Vector3(player.transform.position.x,
                            transform.position.y,
                            transform.position.z));

            //-------------------------------------------------------------

            Gizmos.color = Color.green;
            Gizmos.DrawRay(transform.position, v2Direction);
        }
    }
}