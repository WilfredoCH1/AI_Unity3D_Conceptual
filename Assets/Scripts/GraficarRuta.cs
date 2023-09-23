using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraficarRuta : MonoBehaviour
{
    // crear 4 puntos P0 P1 P2 P3
    [SerializeField] private Transform[] lista_PuntosControl;
    [SerializeField] private float espacioEsfera = 0.25f;
    private Vector3 gizmosPos;

    private void OnDrawGizmos()
    {
        for(float t = 0; t<=1; t += 0.05f)
        {
            gizmosPos = Mathf.Pow(1-t,3) * lista_PuntosControl[0].position +
                        3 * Mathf.Pow(1-t,2) * t * lista_PuntosControl[1].position + 
                        3 * (1-t) * Mathf.Pow(t,2) * lista_PuntosControl[2].position + 
                        Mathf.Pow(t,3) * lista_PuntosControl[3].position;

            Gizmos.DrawSphere(gizmosPos, espacioEsfera);
        }
    }

}
