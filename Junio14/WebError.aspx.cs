using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Junio14
{
    public partial class WebError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int n1 = 0;
            int n2 = 0;
            try
            {
                int n3 = n1 / n2;
                Debug.WriteLine("Esto no se va a ejecutar");
            }

            catch (Exception ex)
            {

                Debug.WriteLine("Una Excepcion");
            }
            //errores especifico
            /*catch (DivideByZeroException ex) { 

                Debug.WriteLine("Div por 0");
            }*/
            // captura todos los errores

        }
    }
}