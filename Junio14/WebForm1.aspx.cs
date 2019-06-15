using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Junio14
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MiClase obj = new MiClase();

            try
            {
                //hacemos una operacion
                obj.Dispose(); //esta funcion libera la memoria
            }
            catch
            {

            }
            // segunda version
            try
            {
                using (MiClase Obj2 = new MiClase())
                {
                    // aqui hacemos algo
                }
            }
            catch
            {

            }






        }
    }
}