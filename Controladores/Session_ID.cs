using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Papema.Controladores
{
    public static class Session_ID
    {
        public static int id;

        public static void Set_ID_Session(int id_usuario)
        {
            id = id_usuario;
        }
        public static int Get_ID_Session()
        {
            return id;
        }
    }
}
