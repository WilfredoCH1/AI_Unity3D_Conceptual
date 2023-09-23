using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyIA : MonoBehaviour
{
    public NavMeshAgent navMeshAgente;
    public GameObject destino;
    //public GameObject panelDerrota;
    void Start()
    {
        navMeshAgente.destination = destino.transform.position;
        //panelDerrota.SetActive(false);
    }

    void Update()
    {
        navMeshAgente.destination = destino.transform.position;
    }

        
}
