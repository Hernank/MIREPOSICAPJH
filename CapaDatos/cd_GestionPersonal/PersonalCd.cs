﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Windows.Forms;
using CapaEntidades.GestionPersonal;
using System.IO;
namespace CapaDatos.cd_GestionPersonal
{
    public class PersonalCd
    {
        public static bool Existe(string ced)
        {
            CapaDatos.cd_GestionPersonal.ConexionBDDataContext DB;
            try
            {
                using (DB = new ConexionBDDataContext())
                {
                    var query = (from prov in DB.PERSONAL where prov.CEDULA == ced select prov).Count();
                    if (query == 0)
                        return false;
                    else
                        return true;
                }
            }
            catch (Exception ex)
            {
                throw new CapaDatosExcepciones("Error al Buscar la Cedula del Personal.", ex);
            }
            finally
            {
                DB = null;
            }

        }

        public static List<pa_FiltrarPersonalValoresResult> ObtenerPresonal(string valor)
        {
            ConexionBDDataContext DB;
            try
            {
                using (DB = new ConexionBDDataContext())
                {
                    return DB.pa_FiltrarPersonalValores(valor).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new CapaDatosExcepciones("Error al Listar Personal", ex);
            }
            finally
            {
                DB = null;
            }
        }
      
        public static Personal Create(Personal not)
        {
            ConexionBDDataContext bd = new ConexionBDDataContext();
           try
            {

                Personal p = new Personal();
                p.Cedula = not.Cedula;
                p.Nombre = not.Nombre;
                p.Apellido = not.Apellido;
                p.Cargo = not.Cargo;
                p.Titulo = not.Titulo;
                p.Correo = not.Correo;
                p.Sexo = not.Sexo;
                p.Ciudad = not.Ciudad;
                p.Direccion = not.Direccion;
                p.Telefono = not.Telefono;
                p.Tipo = not.Tipo;
                p.DataFoto = not.DataFoto;
               string datos = Convert.ToString(p.DataFoto);
                MessageBox.Show("p.datica:   " + "" +datos);
                bd.pa_RegistrarPersonal(p.Cedula, p.Nombre, p.Apellido, p.Cargo, p.Titulo, p.Correo, p.Sexo, p.Ciudad, p.Direccion, p.Telefono, p.Tipo, p.DataFoto);
                bd.SubmitChanges();


               }
           catch (CapaDatosExcepciones ex)
           {
               throw new CapaDatosExcepciones("Error al  Insertar Personal.", ex);
           }
           finally
           {
               bd = null;
           }
            
            return not;
        }

        public static void EliminarPersonalCedula(string cedula)
        {
            ConexionBDDataContext DB = new ConexionBDDataContext();
           try
            {
               
                DB.pa_EliminarPersonalCedula(cedula);
                DB.SubmitChanges();


               }
            catch (Exception ex)
            {
                throw new CapaDatosExcepciones("Error al Eliminar Personal", ex);
            }
            finally
            {
                DB = null;
            }
        }
  
    /////////////////////////////////////////////////////////modificar personal
        public static Personal ModificarPersonalCedula(Personal per)
        {
            ConexionBDDataContext bd = new ConexionBDDataContext();
            try
            {
                Personal p = new Personal();
                p.Cedula = per.Cedula;
                p.Nombre = per.Nombre;
                p.Apellido = per.Apellido;
                p.Cargo = per.Cargo;
                p.Titulo = per.Titulo;
                p.Correo = per.Correo;
                p.Sexo = per.Sexo;
                p.Ciudad = per.Ciudad;
                p.Direccion = per.Direccion;
                p.Telefono = per.Telefono;
                p.Tipo = per.Tipo;
                p.DataFoto = per.DataFoto;
                bd.pa_ModificarPersonalCedula(p.Cedula, p.Nombre, p.Apellido, p.Cargo, p.Titulo, p.Correo, p.Sexo, p.Ciudad, p.Direccion, p.Telefono, p.Tipo, p.DataFoto);
                bd.SubmitChanges();

            }
            catch (CapaDatosExcepciones ex)
            {
                throw new CapaDatosExcepciones("Error al Modificar Personal.", ex);
            }
            finally
            {
                bd = null;
            }

            return per;
        }

        

        public static byte[] getImageById(string id)
        {

            ConexionBDDataContext bd = new ConexionBDDataContext();
            try
            {
                //Categoria p = new Categoria();
                //p.Idcategoria = not.IdProveedor;
                PERSONAL j = (from usu in bd.PERSONAL where usu.CEDULA == id select usu).Single();
                if (j.DATAFOTO != null)
                {
                    return j.DATAFOTO.ToArray();
                }
                else
                {
                    return null;
                }

            }
            catch (CapaDatosExcepciones ex)
            {
                throw new CapaDatosExcepciones("Error al  Eliminar Usuario.", ex);
            }
            finally
            {
                bd = null;
            }
        }
       
    }
}


