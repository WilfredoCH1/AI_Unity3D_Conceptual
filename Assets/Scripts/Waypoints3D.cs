using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints3D : MonoBehaviour
{
    //movimiento
    [SerializeField] private float velocidadMovimiento = 5f;
    [SerializeField] private Transform[] listaWaypoints;
    private int idWaypoint = 0;

    //rotacion
    [SerializeField] private float velociodadRotacion = 3f;
    private Vector3 direccionRotacion;
    private Quaternion anguloRotacion;

    [SerializeField] private List<bool> fila1 = new List<bool>();
    [SerializeField] private List<bool> fila2 = new List<bool>();
    [SerializeField] private List<bool> fila3 = new List<bool>();
    [SerializeField] private List<bool> fila4 = new List<bool>();
    [SerializeField] private List<bool> fila5 = new List<bool>();
    //private List<>


    void Start()
    {
        this.transform.position = listaWaypoints[idWaypoint].transform.position;

        fila1.Add(false); fila1.Add(true); fila1.Add(false); fila1.Add(false); fila1.Add(false);
        fila2.Add(false); fila2.Add(false); fila2.Add(true); fila2.Add(false); fila2.Add(false);
        fila3.Add(true);  fila3.Add(false); fila3.Add(false); fila3.Add(true); fila3.Add(false);
        fila4.Add(false); fila4.Add(false); fila4.Add(false); fila4.Add(false); fila4.Add(false);
        fila5.Add(true);  fila5.Add(false); fila5.Add(false); fila5.Add(false); fila5.Add(false);
    }

    void Update()
    {
        //movimiento
        this.transform.position = Vector3.MoveTowards(this.transform.position, listaWaypoints[idWaypoint].transform.position, velocidadMovimiento * Time.deltaTime);

        //rotacion
        direccionRotacion = (listaWaypoints[idWaypoint].transform.position - this.transform.position).normalized;
        anguloRotacion = Quaternion.LookRotation(direccionRotacion);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, anguloRotacion, velociodadRotacion * Time.deltaTime);

       
        if(this.transform.position == listaWaypoints[idWaypoint].transform.position)
        {
            idWaypoint++;

            //Caminar aleatorio
            //idWaypoint =Random.Range(0,listaWaypoints.Length-1);
        }

        if(idWaypoint == listaWaypoints.Length)
        {
            idWaypoint = 0;
            //Destroy(this.gameObject);
        }
        /*
        for (int i = 0;i<fila1.Length; i++)
        {
            if (fila1[i] == false)
            {
                this.transform.position = Vector3.MoveTowards(this.transform.position)
            }
        }
        */
    }
}
