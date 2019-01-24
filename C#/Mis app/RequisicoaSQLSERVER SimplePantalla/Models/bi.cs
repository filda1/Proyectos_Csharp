namespace RequisicaoSServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bi")]
    public partial class bi
    {
        [Key]
        [StringLength(25)]
        public string bistamp { get; set; }

        [Required]
        [StringLength(24)]
        public string nmdos { get; set; }

        [Column(TypeName = "numeric")]
        public decimal obrano { get; set; }

        [Column("ref")]
        [Required]
        [StringLength(18)]
        public string _ref { get; set; }

        [Required]
        [StringLength(60)]
        public string design { get; set; }

        [Column(TypeName = "numeric")]
        public decimal qtt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal qtt2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal tabiva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal armazem { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pu { get; set; }

        [Column(TypeName = "numeric")]
        public decimal debito { get; set; }

        [Column(TypeName = "numeric")]
        public decimal prorc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal stipo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pcusto { get; set; }

        [Required]
        [StringLength(50)]
        public string serie { get; set; }

        [Column(TypeName = "numeric")]
        public decimal nomquina { get; set; }

        [Column(TypeName = "numeric")]
        public decimal nopat { get; set; }

        [Column(TypeName = "numeric")]
        public decimal fno { get; set; }

        public DateTime? fdata { get; set; }

        [Required]
        [StringLength(24)]
        public string nmdoc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ndoc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ndos { get; set; }

        [Required]
        [StringLength(20)]
        public string forref { get; set; }

        [Column(TypeName = "numeric")]
        public decimal txiva { get; set; }

        public DateTime? rdata { get; set; }

        public DateTime? dedata { get; set; }

        public DateTime? atedata { get; set; }

        [Required]
        [StringLength(40)]
        public string lobs { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ldossier { get; set; }

        [Required]
        [StringLength(20)]
        public string obranome { get; set; }

        public bool fechada { get; set; }

        public DateTime? datafinal { get; set; }

        public DateTime? dataobra { get; set; }

        public DateTime? dataopen { get; set; }

        public DateTime? datafecho { get; set; }

        [Column(TypeName = "numeric")]
        public decimal tecnico { get; set; }

        [Required]
        [StringLength(12)]
        public string maquina { get; set; }

        [Required]
        [StringLength(12)]
        public string marca { get; set; }

        [Required]
        [StringLength(20)]
        public string zona { get; set; }

        [Required]
        [StringLength(20)]
        public string litem { get; set; }

        [Column(TypeName = "numeric")]
        public decimal vumoeda { get; set; }

        public bool resfor { get; set; }

        public bool rescli { get; set; }

        public bool resrec { get; set; }

        public bool iprint { get; set; }

        [Required]
        [StringLength(40)]
        public string lobs2 { get; set; }

        [Required]
        [StringLength(40)]
        public string litem2 { get; set; }

        [Required]
        [StringLength(40)]
        public string lobs3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal estab { get; set; }

        public bool resusr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ar2mazem { get; set; }

        public bool composto { get; set; }

        public bool compostoori { get; set; }

        [Required]
        [StringLength(25)]
        public string lrecno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal lordem { get; set; }

        public bool fmarcada { get; set; }

        public bool producao { get; set; }

        [Required]
        [StringLength(43)]
        public string local { get; set; }

        [Required]
        [StringLength(55)]
        public string morada { get; set; }

        [Required]
        [StringLength(45)]
        public string codpost { get; set; }

        [Required]
        [StringLength(55)]
        public string nome { get; set; }

        [Column(TypeName = "numeric")]
        public decimal vendedor { get; set; }

        [Required]
        [StringLength(20)]
        public string vendnm { get; set; }

        public bool tabfor { get; set; }

        [Required]
        [StringLength(20)]
        public string tabela1 { get; set; }

        public bool descli { get; set; }

        [Required]
        [StringLength(18)]
        public string reff { get; set; }

        [Required]
        [StringLength(30)]
        public string lote { get; set; }

        public bool ivaincl { get; set; }

        [Required]
        [StringLength(25)]
        public string cor { get; set; }

        [Required]
        [StringLength(25)]
        public string tam { get; set; }

        [Required]
        [StringLength(25)]
        public string segmento { get; set; }

        [Required]
        [StringLength(20)]
        public string bofref { get; set; }

        [Required]
        [StringLength(20)]
        public string bifref { get; set; }

        [Column(TypeName = "numeric")]
        public decimal grau { get; set; }

        [Column(TypeName = "numeric")]
        public decimal partes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal partes2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal altura { get; set; }

        [Column(TypeName = "numeric")]
        public decimal largura { get; set; }

        [Column(TypeName = "numeric")]
        public decimal espessura { get; set; }

        [Required]
        [StringLength(50)]
        public string biserie { get; set; }

        public bool infref { get; set; }

        public bool lifref { get; set; }

        [Column(TypeName = "numeric")]
        public decimal uni2qtt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal epu { get; set; }

        [Column(TypeName = "numeric")]
        public decimal edebito { get; set; }

        [Column(TypeName = "numeric")]
        public decimal eprorc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal epcusto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ttdeb { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ettdeb { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ttmoeda { get; set; }

        [Required]
        [StringLength(20)]
        public string adoc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal binum1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal binum2 { get; set; }

        [Required]
        [StringLength(40)]
        public string codigo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal cpoc { get; set; }

        public bool stns { get; set; }

        [Required]
        [StringLength(25)]
        public string obistamp { get; set; }

        [Required]
        [StringLength(25)]
        public string oobistamp { get; set; }

        [Required]
        [StringLength(20)]
        public string usr1 { get; set; }

        [Required]
        [StringLength(20)]
        public string usr2 { get; set; }

        [Required]
        [StringLength(35)]
        public string usr3 { get; set; }

        [Required]
        [StringLength(20)]
        public string usr4 { get; set; }

        [Required]
        [StringLength(120)]
        public string usr5 { get; set; }

        [Required]
        [StringLength(30)]
        public string usr6 { get; set; }

        public bool usalote { get; set; }

        public bool texteis { get; set; }

        [Required]
        [StringLength(4)]
        public string unidade { get; set; }

        [Required]
        [StringLength(4)]
        public string unidad2 { get; set; }

        [Required]
        [StringLength(25)]
        public string oftstamp { get; set; }

        [Required]
        [StringLength(25)]
        public string ofostamp { get; set; }

        public bool promo { get; set; }

        public bool epromo { get; set; }

        [Required]
        [StringLength(18)]
        public string familia { get; set; }

        public bool sattotal { get; set; }

        public bool noserie { get; set; }

        [Column(TypeName = "numeric")]
        public decimal slvu { get; set; }

        [Column(TypeName = "numeric")]
        public decimal eslvu { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sltt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal esltt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal slvumoeda { get; set; }

        [Column(TypeName = "numeric")]
        public decimal slttmoeda { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ncmassa { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ncunsup { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ncvest { get; set; }

        [Column(TypeName = "numeric")]
        public decimal encvest { get; set; }

        [Required]
        [StringLength(13)]
        public string nccod { get; set; }

        [Required]
        [StringLength(25)]
        public string ncinteg { get; set; }

        [Column(TypeName = "numeric")]
        public decimal classif { get; set; }

        [Required]
        [StringLength(15)]
        public string classifc { get; set; }

        [Required]
        [StringLength(10)]
        public string posic { get; set; }

        [Column(TypeName = "numeric")]
        public decimal desconto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal desc2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal desc3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal desc4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal desc5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal desc6 { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string series { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string series2 { get; set; }

        [Required]
        [StringLength(20)]
        public string ccusto { get; set; }

        [Required]
        [StringLength(20)]
        public string ncusto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal num1 { get; set; }

        public bool fechabo { get; set; }

        [Required]
        [StringLength(25)]
        public string oobostamp { get; set; }

        [Required]
        [StringLength(20)]
        public string ltab1 { get; set; }

        [Required]
        [StringLength(20)]
        public string ltab2 { get; set; }

        [Required]
        [StringLength(20)]
        public string ltab3 { get; set; }

        [Required]
        [StringLength(20)]
        public string ltab4 { get; set; }

        [Required]
        [StringLength(20)]
        public string ltab5 { get; set; }

        [Required]
        [StringLength(18)]
        public string fami { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pctfami { get; set; }

        public bool adjudicada { get; set; }

        [Column(TypeName = "numeric")]
        public decimal tieca { get; set; }

        [Column(TypeName = "numeric")]
        public decimal etieca { get; set; }

        [Column(TypeName = "numeric")]
        public decimal mtieca { get; set; }

        [Column(TypeName = "numeric")]
        public decimal volume { get; set; }

        public bool iecasug { get; set; }

        [Column(TypeName = "numeric")]
        public decimal iecagrad { get; set; }

        [Required]
        [StringLength(4)]
        public string iecacodisen { get; set; }

        [Column(TypeName = "numeric")]
        public decimal peso { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pbruto { get; set; }

        [Required]
        [StringLength(20)]
        public string codfiscal { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string dgeral { get; set; }

        public bool temoci { get; set; }

        public bool temomi { get; set; }

        public bool temsubemp { get; set; }

        [Column(TypeName = "numeric")]
        public decimal encargo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal eencargo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal custoind { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ecustoind { get; set; }

        [Required]
        [StringLength(30)]
        public string tiposemp { get; set; }

        public bool pvok { get; set; }

        public bool boclose { get; set; }

        public DateTime? dtclose { get; set; }

        [Required]
        [StringLength(10)]
        public string quarto { get; set; }

        public bool emconf { get; set; }

        [Required]
        [StringLength(55)]
        public string efornecedor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal efornec { get; set; }

        [Column(TypeName = "numeric")]
        public decimal efornestab { get; set; }

        public bool cativo { get; set; }

        [Required]
        [StringLength(25)]
        public string optstamp { get; set; }

        [Required]
        [StringLength(25)]
        public string oristamp { get; set; }

        public bool temeco { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ecoval { get; set; }

        [Column(TypeName = "numeric")]
        public decimal eecoval { get; set; }

        [Column(TypeName = "numeric")]
        public decimal tecoval { get; set; }

        [Column(TypeName = "numeric")]
        public decimal etecoval { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ecoval2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal eecoval2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal tecoval2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal etecoval2 { get; set; }

        public bool econotcalc { get; set; }

        [Required]
        [StringLength(25)]
        public string bostamp { get; set; }

        [Required]
        [StringLength(30)]
        public string ousrinis { get; set; }

        public DateTime? ousrdata { get; set; }

        [Required]
        [StringLength(8)]
        public string ousrhora { get; set; }

        [Required]
        [StringLength(30)]
        public string usrinis { get; set; }

        public DateTime? usrdata { get; set; }

        [Required]
        [StringLength(8)]
        public string usrhora { get; set; }

        public bool marcada { get; set; }

        public bool mntencargos { get; set; }

        [Column(TypeName = "numeric")]
        public decimal debitoori { get; set; }

        [Column(TypeName = "numeric")]
        public decimal edebitoori { get; set; }

        public bool trocaequi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal tpromo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal valdesc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal evaldesc { get; set; }

        /*[Required]
        [StringLength(15)]
        public string u_matric { get; set; }*/
    }
}
