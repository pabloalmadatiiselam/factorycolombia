﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PER10Entities : DbContext
    {
        public PER10Entities()
            : base("name=PER10Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<vwCfdiGeneraResumenDiario> vwCfdiGeneraResumenDiario { get; set; }
        public virtual DbSet<vwCfdiClienteDestinatario> vwCfdiClienteDestinatario { get; set; }
        public virtual DbSet<vwCfdiClienteObligaciones> vwCfdiClienteObligaciones { get; set; }
        public virtual DbSet<vwCfdiFacturaImpuestosCabecera> vwCfdiFacturaImpuestosCabecera { get; set; }
        public virtual DbSet<vwCfdiFacturaImpuestosDetalles> vwCfdiFacturaImpuestosDetalles { get; set; }
        public virtual DbSet<vwCfdiMediosDePago> vwCfdiMediosDePago { get; set; }
        public virtual DbSet<vwCfdiConceptos> vwCfdiConceptos { get; set; }
        public virtual DbSet<vwCfdiRelacionados> vwCfdiRelacionados { get; set; }
        public virtual DbSet<vwCfdiGeneraDocumentoDeVenta> vwCfdiGeneraDocumentoDeVenta { get; set; }
    
        [DbFunction("PER10Entities", "fCfdiParametrosTipoLeyenda")]
        public virtual IQueryable<fCfdiParametrosTipoLeyenda_Result> fCfdiParametrosTipoLeyenda(string aDRSCODE, string master_Type)
        {
            var aDRSCODEParameter = aDRSCODE != null ?
                new ObjectParameter("ADRSCODE", aDRSCODE) :
                new ObjectParameter("ADRSCODE", typeof(string));
    
            var master_TypeParameter = master_Type != null ?
                new ObjectParameter("Master_Type", master_Type) :
                new ObjectParameter("Master_Type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fCfdiParametrosTipoLeyenda_Result>("[PER10Entities].[fCfdiParametrosTipoLeyenda](@ADRSCODE, @Master_Type)", aDRSCODEParameter, master_TypeParameter);
        }
    }
}
