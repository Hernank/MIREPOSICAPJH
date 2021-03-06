///////////////////////////////////////////////////////////
//  Modulo.cs
//  Implementation of the Class Modulo 
//  Generated by Enterprise Architect
//  Created on:      16-ago-2014 2:45:24
//  Original author: tania-jeff
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.GestionSeguridad
{



    public class Modulo
    {

        private string idModulo;
        private string mod_IdModulo;
        private string nombre;
        



        ~Modulo()
        {

        }

        public virtual void Dispose()
        {

        }

        public Modulo()
        {

        }

        /// 
        /// <param name="nombre"></param>
        /// <param name="nom_IdModulo"></param>
        /// <param name="idModulo"></param>
        public Modulo(string nombre, string mod_IdModulo, string idModulo)
        {
            IdModulo = idModulo;
            Nombre = nombre;
            Mod_IdModulo = mod_IdModulo;
        
        }

        public string IdModulo
        {
            get
            {
                return idModulo;
            }
            set
            {
                idModulo = value;
            }
        }

        public string Mod_IdModulo
        {
            get
            {
                return mod_IdModulo;
            }
            set
            {
                mod_IdModulo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

    }
}//end Modulo