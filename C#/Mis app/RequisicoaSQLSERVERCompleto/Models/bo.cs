namespace RequisicaoSServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bo")]
    public partial class bo
    {
        [Required]
        [StringLength(25)]
        public string bostamp { get; set; }

        [Required]
        [StringLength(24)]
        public string nmdos { get; set; }

        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal obrano { get; set; }

        public DateTime? dataobra { get; set; }

        [Required]
        [StringLength(55)]
        public string nome { get; set; }

        [Column(TypeName = "numeric")]
        public decimal totaldeb { get; set; }

        [Column(TypeName = "numeric")]
        public decimal etotaldeb { get; set; }

        [Required]
        [StringLength(20)]
        public string tipo { get; set; }

        public DateTime? datafinal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal smoe4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal smoe3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal smoe2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal smoe1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal moetotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sdeb2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sdeb1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sdeb4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sdeb3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sqtt14 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sqtt13 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sqtt12 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sqtt11 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sqtt24 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sqtt23 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sqtt22 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sqtt21 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal vqtt24 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal vqtt23 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal vqtt22 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal vqtt21 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal vendedor { get; set; }

        [Required]
        [StringLength(20)]
        public string vendnm { get; set; }

        [Column(TypeName = "numeric")]
        public decimal stot1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal stot2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal stot3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal stot4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal no { get; set; }

        [Required]
        [StringLength(20)]
        public string obranome { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal boano { get; set; }

        public DateTime? dataopen { get; set; }

        public DateTime? datafecho { get; set; }

        public bool fechada { get; set; }

        [Column(TypeName = "numeric")]
        public decimal nopat { get; set; }

        [Column(TypeName = "numeric")]
        public decimal total { get; set; }

        [Column(TypeName = "numeric")]
        public decimal tecnico { get; set; }

        [Required]
        [StringLength(30)]
        public string tecnnm { get; set; }

        [Column(TypeName = "numeric")]
        public decimal nomquina { get; set; }

        [Required]
        [StringLength(20)]
        public string maquina { get; set; }

        [Required]
        [StringLength(20)]
        public string marca { get; set; }

        [Required]
        [StringLength(50)]
        public string serie { get; set; }

        [Required]
        [StringLength(20)]
        public string zona { get; set; }

        [Required]
        [StringLength(67)]
        public string obs { get; set; }

        [Required]
        [StringLength(67)]
        public string trab1 { get; set; }

        [Required]
        [StringLength(67)]
        public string trab2 { get; set; }

        [Required]
        [StringLength(67)]
        public string trab3 { get; set; }

        [Required]
        [StringLength(67)]
        public string trab4 { get; set; }

        [Required]
        [StringLength(67)]
        public string trab5 { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal ndos { get; set; }

        [Column(TypeName = "numeric")]
        public decimal custo { get; set; }

        [Required]
        [StringLength(11)]
        public string moeda { get; set; }

        [Column(TypeName = "numeric")]
        public decimal estab { get; set; }

        [Required]
        [StringLength(55)]
        public string morada { get; set; }

        [Required]
        [StringLength(43)]
        public string local { get; set; }

        [Required]
        [StringLength(45)]
        public string codpost { get; set; }

        public DateTime? ultfact { get; set; }

        [Column(TypeName = "numeric")]
        public decimal period { get; set; }

        [Required]
        [StringLength(20)]
        public string tabela1 { get; set; }

        [Required]
        [StringLength(20)]
        public string ncont { get; set; }

        public bool logi1 { get; set; }

        public bool logi2 { get; set; }

        public bool logi3 { get; set; }

        public bool logi4 { get; set; }

        public bool logi5 { get; set; }

        public bool logi6 { get; set; }

        public bool logi7 { get; set; }

        public bool logi8 { get; set; }

        [Required]
        [StringLength(25)]
        public string segmento { get; set; }

        public bool impresso { get; set; }

        [Required]
        [StringLength(60)]
        public string userimpresso { get; set; }

        [Required]
        [StringLength(20)]
        public string fref { get; set; }

        [Required]
        [StringLength(20)]
        public string ccusto { get; set; }

        [Required]
        [StringLength(20)]
        public string ncusto { get; set; }

        [Required]
        [StringLength(22)]
        public string cobranca { get; set; }

        public bool infref { get; set; }

        public bool lifref { get; set; }

        [Column(TypeName = "numeric")]
        public decimal esdeb1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal esdeb2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal esdeb3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal esdeb4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal evqtt21 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal evqtt22 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal evqtt23 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal evqtt24 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal estot1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal estot2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal estot3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal estot4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal etotal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ecusto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo_2tdesc1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo_2tdesc2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo_2tdes1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo_2tdes2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal descc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal edescc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo_1tvall { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo_2tvall { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo_1tvall { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo_2tvall { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo11_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo11_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo11_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo11_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo21_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo21_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo21_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo21_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo31_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo31_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo31_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo31_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo41_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo41_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo41_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo41_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo51_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo51_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo51_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo51_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo61_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo61_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo61_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo61_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo12_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo12_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo12_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo12_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo22_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo22_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo22_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo22_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo32_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo32_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo32_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo32_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo42_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo42_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo42_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo42_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo52_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo52_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo52_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo52_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo62_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo62_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo62_bins { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo62_iva { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo_totp1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bo_totp2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo_totp1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ebo_totp2 { get; set; }

        public bool edi { get; set; }

        [Required]
        [StringLength(4)]
        public string memissao { get; set; }

        [Required]
        [StringLength(55)]
        public string nome2 { get; set; }

        [Required]
        [StringLength(25)]
        public string pastamp { get; set; }

        [Required]
        [StringLength(25)]
        public string snstamp { get; set; }

        [Required]
        [StringLength(25)]
        public string mastamp { get; set; }

        [Required]
        [StringLength(25)]
        public string origem { get; set; }

        [Column(TypeName = "numeric")]
        public decimal orinopat { get; set; }

        public bool iiva { get; set; }

        public bool iunit { get; set; }

        public bool itotais { get; set; }

        public bool iunitiva { get; set; }

        public bool itotaisiva { get; set; }

        [Required]
        [StringLength(20)]
        public string site { get; set; }

        [Required]
        [StringLength(20)]
        public string pnome { get; set; }

        [Column(TypeName = "numeric")]
        public decimal pno { get; set; }

        [Required]
        [StringLength(25)]
        public string cxstamp { get; set; }

        [Required]
        [StringLength(30)]
        public string cxusername { get; set; }

        [Required]
        [StringLength(25)]
        public string ssstamp { get; set; }

        [Required]
        [StringLength(30)]
        public string ssusername { get; set; }

        public bool alldescli { get; set; }

        public bool alldesfor { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string series { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string series2 { get; set; }

        [Required]
        [StringLength(10)]
        public string quarto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ocupacao { get; set; }

        [Required]
        [StringLength(25)]
        public string tabela2 { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string obstab2 { get; set; }

        [Required]
        [StringLength(100)]
        public string iemail { get; set; }

        [Required]
        [StringLength(50)]
        public string inome { get; set; }

        [Column(TypeName = "numeric")]
        public decimal situacao { get; set; }

        [Required]
        [StringLength(20)]
        public string lang { get; set; }

        [Required]
        [StringLength(35)]
        public string ean { get; set; }

        [Required]
        [StringLength(4)]
        public string iecacodisen { get; set; }

        public bool boclose { get; set; }

        public DateTime? dtclose { get; set; }

        [Required]
        [StringLength(25)]
        public string tpstamp { get; set; }

        [Required]
        [StringLength(55)]
        public string tpdesc { get; set; }

        public bool emconf { get; set; }

        [Required]
        [StringLength(1)]
        public string statuspda { get; set; }

        public bool aprovado { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal boid { get; set; }

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

       /* [Required]
        [StringLength(20)]
        public string u_gpgasto { get; set; }*/

        /*[Column(TypeName = "numeric")]
        public decimal u_hrs { get; set; }*/

        /*[Column(TypeName = "numeric")]
        public decimal u_kms { get; set; }*/

        [Required]
        [StringLength(12)]
        public string u_matricul { get; set; }

        /*[Required]
        [StringLength(12)]
        public string u_motorist { get; set; }*/

        /*[Required]
        [StringLength(20)]
        public string u_tpgasto { get; set; }*/

        /*[Column(TypeName = "numeric")]
        public decimal u_totaldoc { get; set; }*/
    }
}
