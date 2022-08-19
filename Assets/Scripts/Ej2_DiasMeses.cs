using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2_DiasMeses : MonoBehaviour
{
    [SerializeField] string[] nombresMeses = new string [12];
    [SerializeField] int[] diasPorCadaMes = new int[12];
    public string fechaIngresada;
    // Start is called before the first frame update
    void Start()
    {
        ValidarFormatoFecha(fechaIngresada);
         
    }

    bool ValidarFormatoFecha(string fecha)
    {
        bool fechaValida = false;

        if (fecha.Length == 4)
        {
            string dia = "";
            string mes = "";
            dia += fecha[0];
            dia += fecha[1];
            int diaNumber = int.Parse(dia);
            Debug.Log(dia);
            mes += fecha[2];
            mes += fecha[3];
            int mesNumber = int.Parse(mes);
            if (diaNumber > 0 && diaNumber <= 31 && mesNumber >0 && mesNumber>=12)
            {
                fechaValida = true;
            }
        }
        else
        {
            Debug.Log("El largo de la fecha es incorrecto");
        }

        return fechaValida;
    }
}
