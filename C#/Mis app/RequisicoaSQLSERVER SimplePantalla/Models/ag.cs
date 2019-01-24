namespace RequisicaoSServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ag")]
    public partial class ag
    {
        [Required]
        [StringLength(25)]
        public string agstamp { get; set; }

        [Required]
        [StringLength(55)]
        public string nome { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal no { get; set; }

        [Required]
        [StringLength(20)]
        public string ncont { get; set; }

        [Required]
        [StringLength(55)]
        public string nome2 { get; set; }

        [Required]
        [StringLength(55)]
        public string morada { get; set; }

        [Required]
        [StringLength(43)]
        public string local { get; set; }

        [Required]
        [StringLength(45)]
        public string codpost { get; set; }

        [Required]
        [StringLength(60)]
        public string telefone { get; set; }

        [Required]
        [StringLength(30)]
        public string telex { get; set; }

        [Required]
        [StringLength(60)]
        public string fax { get; set; }

        [Required]
        [StringLength(12)]
        public string codigo { get; set; }

        [Required]
        [StringLength(40)]
        public string contacto { get; set; }

        [Required]
        [StringLength(55)]
        public string nconjuge { get; set; }

        public DateTime data1 { get; set; }

        public DateTime data2 { get; set; }

        public DateTime data3 { get; set; }

        [Required]
        [StringLength(20)]
        public string oque1 { get; set; }

        [Required]
        [StringLength(20)]
        public string oque2 { get; set; }

        [Required]
        [StringLength(20)]
        public string oque3 { get; set; }

        [Required]
        [StringLength(20)]
        public string tratamento { get; set; }

        [Required]
        [StringLength(70)]
        public string imagem { get; set; }

        [Required]
        [StringLength(20)]
        public string bino { get; set; }

        public DateTime bidata { get; set; }

        [Required]
        [StringLength(25)]
        public string bilocal { get; set; }

        [Required]
        [StringLength(15)]
        public string ecivil { get; set; }

        [Required]
        [StringLength(20)]
        public string profissao { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string obsmemo { get; set; }

        [Required]
        [StringLength(20)]
        public string cbino { get; set; }

        public DateTime cbidata { get; set; }

        [Required]
        [StringLength(25)]
        public string cbilocal { get; set; }

        [Required]
        [StringLength(25)]
        public string cregime { get; set; }

        [Required]
        [StringLength(50)]
        public string cnatural { get; set; }

        [Required]
        [StringLength(50)]
        public string natural { get; set; }

        [Required]
        [StringLength(20)]
        public string cncont { get; set; }

        public bool onoff1 { get; set; }

        public bool onoff2 { get; set; }

        public bool onoff3 { get; set; }

        [Required]
        [StringLength(20)]
        public string zona { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [StringLength(45)]
        public string tlmvl { get; set; }

        public bool ecl { get; set; }

        [Column(TypeName = "numeric")]
        public decimal clno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal clestab { get; set; }

        public bool eem { get; set; }

        [Column(TypeName = "numeric")]
        public decimal emno { get; set; }

        public bool efl { get; set; }

        [Column(TypeName = "numeric")]
        public decimal flno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal flestab { get; set; }

        [Required]
        [StringLength(100)]
        public string url { get; set; }

        [Required]
        [StringLength(45)]
        public string bizzaddress { get; set; }

        [Column(TypeName = "numeric")]
        public decimal bizzproto { get; set; }

        [Required]
        [StringLength(20)]
        public string vendnm { get; set; }

        [Column(TypeName = "numeric")]
        public decimal vendedor { get; set; }

        [Required]
        [StringLength(20)]
        public string lang { get; set; }

        [Required]
        [StringLength(35)]
        public string eanag { get; set; }

        public bool inactivo { get; set; }

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

        [Required]
        [StringLength(20)]
        public string area { get; set; }

        [Required]
        [StringLength(28)]
        public string nib { get; set; }

        [Required]
        [StringLength(2)]
        public string codpais { get; set; }

        [Required]
        [StringLength(55)]
        public string pais { get; set; }

        [Required]
        [StringLength(2)]
        public string pncont { get; set; }

        public bool consfinal { get; set; }

        public bool monitignios { get; set; }

        [Required]
        [StringLength(20)]
        public string pwportal { get; set; }

        [Required]
        [StringLength(50)]
        public string userid { get; set; }

        public DateTime dlogin { get; set; }

        [Required]
        [StringLength(8)]
        public string hlogin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal longitude { get; set; }

        [Required]
        [StringLength(40)]
        public string forgotid { get; set; }

        public DateTime forgotdate { get; set; }

        public bool termsconditions { get; set; }

        [Required]
        [StringLength(4)]
        public string egarprod { get; set; }

        [Required]
        [StringLength(11)]
        public string egarapa { get; set; }

        [Required]
        [StringLength(15)]
        public string egarpgl { get; set; }

        [Required]
        [StringLength(3)]
        public string egargrupo { get; set; }

        [Required]
        [StringLength(3)]
        public string egaropera { get; set; }

        [Required]
        [StringLength(250)]
        public string egaropdes { get; set; }
    }
}
