//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cfdiEntidadesGP
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwCfdiGeneraResumenDiario
    {
        public int tipoResumenDiario { get; set; }
        public string numResumenDiario { get; set; }
        public System.DateTime docdate { get; set; }
        public string tipoDocumento { get; set; }
        public string emisorTipoDoc { get; set; }
        public string emisorNroDoc { get; set; }
        public string emisorNombre { get; set; }
        public string emisorUbigeo { get; set; }
        public string emisorDireccion { get; set; }
        public string emisorUrbanizacion { get; set; }
        public string emisorDepartamento { get; set; }
        public string emisorProvincia { get; set; }
        public string emisorDistrito { get; set; }
        public string receptorTipoDoc { get; set; }
        public string receptorNroDoc { get; set; }
        public string serie { get; set; }
        public string sopnumbe { get; set; }
        public int iniRango { get; set; }
        public int finRango { get; set; }
        public string moneda { get; set; }
        public decimal xchgrate { get; set; }
        public decimal totalIvaImponible { get; set; }
        public decimal totalIva { get; set; }
        public decimal totalInafecta { get; set; }
        public decimal totalExonerado { get; set; }
        public decimal totalGratuito { get; set; }
        public Nullable<decimal> totalDescuento { get; set; }
        public decimal ORTDISAM { get; set; }
        public decimal total { get; set; }
        public int cantidad { get; set; }
        public string formaPago { get; set; }
        public string tipoDocumentoTo { get; set; }
        public string sopnumbeTo { get; set; }
    }
}
