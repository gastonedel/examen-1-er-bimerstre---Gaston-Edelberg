using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticapalooza : MonoBehaviour
{
    public int entradascampo;
    public int entradasplatea;
    // Start is called before the first frame update
    void Start()
    {
        int preciocampo;
        int precioplatea;
        int recaudacionplatea;
        int recaudacioncampo;
        int recaudaciontotal;
        int capacidadtotal;
        int entradasdisponibles;
        int entradastotales;
        int capacidadcampo;
        int capacidadplatea;
        capacidadcampo = 20400;
        capacidadplatea = 16200;
        if (entradascampo == 0 || entradasplatea == 0)
        {
            Debug.Log("ERROR");
            return;
        }

        else if (entradascampo >= capacidadcampo || entradasplatea >= capacidadplatea)
        {
            Debug.Log("ERROR");
            return;
        }
        
        
        entradastotales = entradascampo + entradasplatea;
        capacidadtotal = 36600;
        entradasdisponibles = capacidadtotal - entradastotales;
        precioplatea = 2000;
        preciocampo = 1200;
        recaudacioncampo = entradascampo * preciocampo;
        recaudacionplatea = entradasplatea * precioplatea;
        recaudaciontotal = recaudacionplatea + recaudacioncampo;
        Debug.Log("la recaudacion de entradas de platea es " + recaudacionplatea);
        Debug.Log("la recaudacion de entradas de campo es " + recaudacioncampo);
        Debug.Log("la recaudacion total es " + recaudaciontotal);

     

        if (entradastotales>= capacidadtotal)
        {
            Debug.Log("Sold Out!");
        }

        else
        {
            Debug.Log("quedan " + entradasdisponibles + "entradas disponibles");
        }

        if(entradastotales> capacidadtotal / 2)
        {
            Debug.Log("El festival fue un éxito!");
        }
        else
        {
            Debug.Log("Debemos mejorar la convocatoria");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
