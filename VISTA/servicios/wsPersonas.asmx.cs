using DATOS.daos;
using DATOS.modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace VISTA.servicios
{
    /// <summary>
    /// Descripción breve de wsPersonas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class wsPersonas : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        public string getAll()
        {
            string strJSON;

            PersonaDAO dao = new PersonaDAO();
            List<Persona> lista = dao.getAll();

            strJSON = JsonConvert.SerializeObject(lista,
                          new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            return strJSON;
        }
    }
}
