namespace RequisicaoSServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("st")]
    public partial class st
    {
        [Required]
        [StringLength(25)]
        public string ststamp { get; set; }

        [Key]
        [Column("ref")]
        [StringLength(18)]
        public string _ref { get; set; }

        [Required]
        [StringLength(60)]
        public string design { get; set; }

        [Required]
        [StringLength(18)]
        public string familia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal stock { get; set; }

        [Column(TypeName = "numeric")]
        public decimal epv1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pv1 { get; set; }

        [Required]
        [StringLength(20)]
        public string forref { get; set; }

        [Required]
        [StringLength(55)]
        public string fornecedor { get; set; }

        [Required]
        [StringLength(60)]
        public string desc3 { get; set; }

        [Required]
        [StringLength(60)]
        public string desc2 { get; set; }

        [Required]
        [StringLength(60)]
        public string desc1 { get; set; }

        [Required]
        [StringLength(20)]
        public string usr2 { get; set; }

        [Required]
        [StringLength(20)]
        public string usr1 { get; set; }

        public DateTime validade { get; set; }

        public DateTime usaid { get; set; }

        public DateTime uintr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal usrqtt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal eoq { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pcult { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pcimp { get; set; }

        [Required]
        [StringLength(3)]
        public string pcmoe { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pvcon { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pvultimo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pv3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pv2 { get; set; }

        [Required]
        [StringLength(4)]
        public string unidade { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ptoenc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal tabiva { get; set; }

        [Required]
        [StringLength(20)]
        public string local { get; set; }

        [Column(TypeName = "numeric")]
        public decimal fornec { get; set; }

        [Column(TypeName = "numeric")]
        public decimal fornestab { get; set; }

        [Column(TypeName = "numeric")]
        public decimal qttfor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal qttcli { get; set; }

        [Column(TypeName = "numeric")]
        public decimal qttrec { get; set; }

        public DateTime udata { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pcusto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pcpond { get; set; }

        [Column(TypeName = "numeric")]
        public decimal qttacin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal qttacout { get; set; }

        [Column(TypeName = "numeric")]
        public decimal qttvend { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pmvenda { get; set; }

        [Column(TypeName = "numeric")]
        public decimal valin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal valout { get; set; }

        [Column(TypeName = "numeric")]
        public decimal stmax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal stmin { get; set; }

        [Required]
        [StringLength(68)]
        public string obs { get; set; }

        [Required]
        [StringLength(40)]
        public string codigo { get; set; }

        [Required]
        [StringLength(4)]
        public string uni2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal conversao { get; set; }

        public bool ivaincl { get; set; }

        public bool nsujpp { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ecomissao { get; set; }

        [Required]
        [StringLength(120)]
        public string imagem { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pv4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pv5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal cpoc { get; set; }

        [Required]
        [StringLength(15)]
        public string containv { get; set; }

        [Required]
        [StringLength(15)]
        public string contacev { get; set; }

        [Required]
        [StringLength(15)]
        public string contareo { get; set; }

        [Required]
        [StringLength(15)]
        public string contacoe { get; set; }

        [Column(TypeName = "numeric")]
        public decimal peso { get; set; }

        public bool bloqueado { get; set; }

        public bool fobloq { get; set; }

        [Column(TypeName = "numeric")]
        public decimal mfornec { get; set; }

        [Column(TypeName = "numeric")]
        public decimal mfornec2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pentrega { get; set; }

        [Column(TypeName = "numeric")]
        public decimal consumo { get; set; }

        public bool baixr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal despimp { get; set; }

        [Column(TypeName = "numeric")]
        public decimal mesescon { get; set; }

        [Column(TypeName = "numeric")]
        public decimal marg1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal marg2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal marg3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal marg4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal marg5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal diaspto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal diaseoq { get; set; }

        [Required]
        [StringLength(60)]
        public string desc4 { get; set; }

        [Required]
        [StringLength(60)]
        public string desc5 { get; set; }

        [Required]
        [StringLength(60)]
        public string desc6 { get; set; }

        public bool noserie { get; set; }

        public bool clinica { get; set; }

        public bool vasilhame { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pbruto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal volume { get; set; }

        public bool usalote { get; set; }

        public bool texteis { get; set; }

        [Column(TypeName = "numeric")]
        public decimal garantia { get; set; }

        public DateTime opendata { get; set; }

        [Required]
        [StringLength(60)]
        public string faminome { get; set; }

        [Required]
        [StringLength(35)]
        public string usr3 { get; set; }

        [Required]
        [StringLength(20)]
        public string usr4 { get; set; }

        [Required]
        [StringLength(120)]
        public string usr5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal qttesp { get; set; }

        [Column(TypeName = "numeric")]
        public decimal epv2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal epv3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal epv4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal epv5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal epcusto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal epcpond { get; set; }

        [Column(TypeName = "numeric")]
        public decimal epcult { get; set; }

        [Column(TypeName = "numeric")]
        public decimal epmvenda { get; set; }

        [Column(TypeName = "numeric")]
        public decimal epvultimo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal epvcon { get; set; }

        public bool iva1incl { get; set; }

        public bool iva2incl { get; set; }

        public bool iva3incl { get; set; }

        public bool iva4incl { get; set; }

        public bool iva5incl { get; set; }

        public bool ivapcincl { get; set; }

        public bool stns { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal stid { get; set; }

        [Required]
        [StringLength(60)]
        public string tipodesc { get; set; }

        [Required]
        [StringLength(30)]
        public string usr6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal convunsup { get; set; }

        [Required]
        [StringLength(8)]
        public string nccod { get; set; }

        [Column(TypeName = "numeric")]
        public decimal massaliq { get; set; }

        [Required]
        [StringLength(100)]
        public string url { get; set; }

        [Column(TypeName = "numeric")]
        public decimal vaiwww { get; set; }

        public bool iectsug { get; set; }

        [Column(TypeName = "numeric")]
        public decimal iectin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal eiectin { get; set; }

        public bool iectinii { get; set; }

        [Required]
        [StringLength(20)]
        public string codfiscal { get; set; }

        public bool iecasug { get; set; }

        [Column(TypeName = "numeric")]
        public decimal iecagrad { get; set; }

        [Required]
        [StringLength(18)]
        public string iecaref { get; set; }

        [Required]
        [StringLength(60)]
        public string iecarefnome { get; set; }

        [Required]
        [StringLength(18)]
        public string txieca { get; set; }

        [Required]
        [StringLength(115)]
        public string txiecanome { get; set; }

        [Required]
        [StringLength(4)]
        public string iecautt { get; set; }

        public bool iecamultgrad { get; set; }

        public bool iecaisref { get; set; }

        [Required]
        [StringLength(20)]
        public string site { get; set; }

        public bool qlook { get; set; }

        [Required]
        [StringLength(30)]
        public string txtqlook { get; set; }

        [Required]
        [StringLength(120)]
        public string imgqlook { get; set; }

        [Required]
        [StringLength(20)]
        public string lang1 { get; set; }

        [Required]
        [StringLength(60)]
        public string langdes1 { get; set; }

        [Required]
        [StringLength(20)]
        public string lang2 { get; set; }

        [Required]
        [StringLength(60)]
        public string langdes2 { get; set; }

        [Required]
        [StringLength(20)]
        public string lang3 { get; set; }

        [Required]
        [StringLength(60)]
        public string langdes3 { get; set; }

        [Required]
        [StringLength(20)]
        public string lang4 { get; set; }

        [Required]
        [StringLength(60)]
        public string langdes4 { get; set; }

        [Required]
        [StringLength(20)]
        public string lang5 { get; set; }

        [Required]
        [StringLength(60)]
        public string langdes5 { get; set; }

        public bool nexist { get; set; }

        [Required]
        [StringLength(1)]
        public string statuspda { get; set; }

        [Column(TypeName = "numeric")]
        public decimal qttcat { get; set; }

        public bool compnovo { get; set; }

        public bool ecovalor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal eecoval { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ecoval { get; set; }

        public bool ecopl { get; set; }

        [Column(TypeName = "numeric")]
        public decimal eecopval { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ecopval { get; set; }

        public bool ecoel { get; set; }

        [Column(TypeName = "numeric")]
        public decimal eecoeval { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ecoeval { get; set; }

        public bool ecorl { get; set; }

        [Column(TypeName = "numeric")]
        public decimal eecorval { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ecorval { get; set; }

        public bool ecool { get; set; }

        [Column(TypeName = "numeric")]
        public decimal eecooval { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ecooval { get; set; }

        public bool ecopilha { get; set; }

        public bool ecoacumulador { get; set; }

        [Required]
        [StringLength(30)]
        public string ousrinis { get; set; }

        public DateTime ousrdata { get; set; }

        [Required]
        [StringLength(8)]
        public string ousrhora { get; set; }

        [Required]
        [StringLength(30)]
        public string usrinis { get; set; }

        public DateTime usrdata { get; set; }

        [Required]
        [StringLength(8)]
        public string usrhora { get; set; }

        public bool marcada { get; set; }

        public bool qtttouch { get; set; }

        public bool semserprv { get; set; }

        [Required]
        [StringLength(15)]
        public string contaieo { get; set; }

        public bool inactivo { get; set; }

        public bool orcamento { get; set; }

        [Required]
        [StringLength(18)]
        public string refmo { get; set; }

        [Required]
        [StringLength(60)]
        public string descrmo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pcmo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal epcmo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal custo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ecusto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal desci { get; set; }

        [Column(TypeName = "numeric")]
        public decimal descii { get; set; }

        public DateTime datar { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pcdisp { get; set; }

        [Column(TypeName = "numeric")]
        public decimal epcdisp { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pclab { get; set; }

        [Column(TypeName = "numeric")]
        public decimal epclab { get; set; }

        [Column(TypeName = "numeric")]
        public decimal custog { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ecustog { get; set; }

        [Column(TypeName = "numeric")]
        public decimal custof { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ecustof { get; set; }

        [Required]
        [StringLength(4)]
        public string unidadef { get; set; }

        [Required]
        [StringLength(25)]
        public string ofcstamp { get; set; }

        [Column(TypeName = "numeric")]
        public decimal codcmb { get; set; }

        public bool cancpos { get; set; }

        public DateTime datanovpv { get; set; }

        [Required]
        [StringLength(5)]
        public string horanovpv { get; set; }

        [Required]
        [StringLength(3)]
        public string tkhclass { get; set; }

        public bool stocktch { get; set; }

        public bool mod { get; set; }

        [Required]
        [StringLength(60)]
        public string restctprep { get; set; }

        [Required]
        [StringLength(60)]
        public string idudesign { get; set; }

        public bool notimpcp { get; set; }

        public bool impfuelpos { get; set; }

        public bool amostra { get; set; }

        public bool sujinv { get; set; }

        /*[Required]
        [StringLength(50)]
        public string u_strt { get; set; }*/

        public bool sujretirs { get; set; }
    }
}
