﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Modelos;

namespace DeliveryApp.Controladores
{
    public class VentasTotalesCon
    {
        public static void ObtenerClientes(ref List<Cliente> Cli, ref string mensaje)
        {
            try
            {
                int max = new Cliente().cantidad();
                new Cliente().ListaClientes(max, ref Cli);

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
        }

        public static void ObtenerVentasIndi(string id, VentasTotales Vt)
        {
            try
            {
                Vt.VentasGlobales(id);

            }
            catch (Exception ex)
            {
                //mensaje = ex.Message;
            }
        }
        public static void ObtenerVentas(ref List<VentasTotales> LVtotales)
        {
            try
            {
                new VentasTotales().VentasGlobalesLista(ref LVtotales);

            }
            catch (Exception ex)
            {
                //mensaje = ex.Message;
            }
        }
        public static void ObtenerVentasIndiPeriodo(string id, VentasTotales Vt, string inicial,string final)
        {
            try
            {
                Vt.VentasGlobalesPeriodo(id,inicial,final);

            }
            catch (Exception ex)
            {
                //mensaje = ex.Message;
            }
        }
        public static void ObtenerVentasPeriodo(ref List<VentasTotales> LVtotales, string inicial, string final)
        {
            try
            {
                new VentasTotales().VentasGlobalesListaPeriodo(ref LVtotales,inicial,final);

            }
            catch (Exception ex)
            {
                //mensaje = ex.Message;
            }
        }
        public static void ReporteVentas(Ventas V)
        {
            V.VentasReporte();
        }
        public static void ReporteVentasPeriodo(Ventas V,string inicial, string final)
        {
            V.VentasReportePeriodo(inicial,final);
        }
    }
}