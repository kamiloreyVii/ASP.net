using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service()
    {


    }

    [WebMethod]
    public string HelloWorld()

    {
        return "Hola a todos";
    }
    [WebMethod]
    public string Miprimermetodoweb(string PrimerNombre, string Apellido)
    {
        return string.Format("Bienvenido {0} {1}", PrimerNombre, Apellido);
    }

}