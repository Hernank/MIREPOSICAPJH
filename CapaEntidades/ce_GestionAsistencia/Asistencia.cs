///////////////////////////////////////////////////////////
//  Asistencia.cs
//  Implementation of the Class Asistencia
//  Generated by Enterprise Architect
//  Created on:      16-ago-2014 2:45:23
//  Original author: Intel
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.GestionAsistencia
{

    public class Asistencia
    {

        private DateTime fechaHoraEntrada;
        private DateTime fechaHoraSalida;
        private string idAsistencia;
        private string idCalendario;
        private string cedula;

        




        ~Asistencia()
        {

        }

        public virtual void Dispose()
        {

        }

        public Asistencia()
        {

        }

        /// 
        /// <param name="idasistencia"></param>
        /// <param name="fechahoraentrada"></param>
        /// <param name="fechahorasalida"></param>
        public Asistencia(string idasistencia, DateTime fechahoraentrada, DateTime fechahorasalida, string idCalendario, string cedula)
        {
            IdAsistencia = idasistencia;
            FechaHoraEntrada = fechahoraentrada;
            FechaHoraSalida = FechaHoraSalida;
            IdCalendario = idCalendario;
            Cedula = cedula;
        }

        public DateTime FechaHoraEntrada
        {
            get
            {
                return fechaHoraEntrada;
            }
            set
            {
                fechaHoraEntrada = value;
            }
        }

        public DateTime FechaHoraSalida
        {
            get
            {
                return fechaHoraSalida;
            }
            set
            {
                fechaHoraSalida = value;
            }
        }

        public string IdAsistencia
        {
            get
            {
                return idAsistencia;
            }
            set
            {
                idAsistencia = value;
            }
        }
        public string IdCalendario
        {
            get { return idCalendario; }
            set { idCalendario = value; }
        }
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
    }
}//end Asistencia