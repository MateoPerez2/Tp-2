using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string contraseniaCorrecta;
    public Text ingresoUsuario;
    string contraseniaUsiario;
    public GameObject cartelitoMsj;
    public Text textoMsj;
    
    // Start is called before the first frame update
    void Start()
    {
        contraseniaCorrecta = "12345";
        cartelitoMsj.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ValidarContrasenia()
        {
        contraseniaUsiario = ingresoUsuario.text;
        if (contraseniaUsiario == contraseniaCorrecta)
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Contraseña Incorrecta";
            Debug.Log("Contraseña Incorrecta");
        }
        }

}
