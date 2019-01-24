namespace RequisicaoSServer.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBConnect : DbContext
    {
        public DBConnect()
            : base("name=DBConnect")
        {
        }

        public virtual DbSet<ag> ag { get; set; }
        public virtual DbSet<bi> bi { get; set; }
        public virtual DbSet<bo> bo { get; set; }
        public virtual DbSet<st> st { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ag>()
                .Property(e => e.agstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.no)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ag>()
                .Property(e => e.ncont)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.nome2)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.morada)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.local)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.codpost)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.telefone)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.telex)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.codigo)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.contacto)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.nconjuge)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.oque1)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.oque2)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.oque3)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.tratamento)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.imagem)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.bino)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.bilocal)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.ecivil)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.profissao)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.obsmemo)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.cbino)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.cbilocal)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.cregime)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.cnatural)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.natural)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.cncont)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.zona)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.tlmvl)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.clno)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ag>()
                .Property(e => e.clestab)
                .HasPrecision(3, 0);

            modelBuilder.Entity<ag>()
                .Property(e => e.emno)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ag>()
                .Property(e => e.flno)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ag>()
                .Property(e => e.flestab)
                .HasPrecision(3, 0);

            modelBuilder.Entity<ag>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.bizzaddress)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.bizzproto)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ag>()
                .Property(e => e.vendnm)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.vendedor)
                .HasPrecision(4, 0);

            modelBuilder.Entity<ag>()
                .Property(e => e.lang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.eanag)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.ousrinis)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.ousrhora)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.usrinis)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.usrhora)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.area)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.nib)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.codpais)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.pais)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.pncont)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.pwportal)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.hlogin)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.latitude)
                .HasPrecision(10, 6);

            modelBuilder.Entity<ag>()
                .Property(e => e.longitude)
                .HasPrecision(10, 6);

            modelBuilder.Entity<ag>()
                .Property(e => e.forgotid)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.egarprod)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.egarapa)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.egarpgl)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.egargrupo)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.egaropera)
                .IsUnicode(false);

            modelBuilder.Entity<ag>()
                .Property(e => e.egaropdes)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.bistamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.nmdos)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.obrano)
                .HasPrecision(10, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e._ref)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.design)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.qtt)
                .HasPrecision(14, 4);

            modelBuilder.Entity<bi>()
                .Property(e => e.qtt2)
                .HasPrecision(14, 4);

            modelBuilder.Entity<bi>()
                .Property(e => e.iva)
                .HasPrecision(5, 2);

            modelBuilder.Entity<bi>()
                .Property(e => e.tabiva)
                .HasPrecision(1, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.armazem)
                .HasPrecision(5, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.pu)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.debito)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.prorc)
                .HasPrecision(14, 3);

            modelBuilder.Entity<bi>()
                .Property(e => e.stipo)
                .HasPrecision(1, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.no)
                .HasPrecision(10, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.pcusto)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.serie)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.nomquina)
                .HasPrecision(7, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.nopat)
                .HasPrecision(10, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.fno)
                .HasPrecision(10, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.nmdoc)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.ndoc)
                .HasPrecision(3, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.ndos)
                .HasPrecision(3, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.forref)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.txiva)
                .HasPrecision(2, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.lobs)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.ldossier)
                .HasPrecision(2, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.obranome)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.tecnico)
                .HasPrecision(4, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.maquina)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.zona)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.litem)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.vumoeda)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.lobs2)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.litem2)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.lobs3)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.estab)
                .HasPrecision(3, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.ar2mazem)
                .HasPrecision(5, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.lrecno)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.lordem)
                .HasPrecision(10, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.local)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.morada)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.codpost)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.nome)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.vendedor)
                .HasPrecision(4, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.vendnm)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.tabela1)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.reff)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.lote)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.cor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.tam)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.segmento)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.bofref)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.bifref)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.grau)
                .HasPrecision(9, 3);

            modelBuilder.Entity<bi>()
                .Property(e => e.partes)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bi>()
                .Property(e => e.partes2)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bi>()
                .Property(e => e.altura)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bi>()
                .Property(e => e.largura)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bi>()
                .Property(e => e.espessura)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bi>()
                .Property(e => e.biserie)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.uni2qtt)
                .HasPrecision(14, 4);

            modelBuilder.Entity<bi>()
                .Property(e => e.epu)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.edebito)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.eprorc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.epcusto)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.ttdeb)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.ettdeb)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.ttmoeda)
                .HasPrecision(12, 2);

            modelBuilder.Entity<bi>()
                .Property(e => e.adoc)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.binum1)
                .HasPrecision(10, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.binum2)
                .HasPrecision(10, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.codigo)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.cpoc)
                .HasPrecision(6, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.obistamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.oobistamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.usr1)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.usr2)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.usr3)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.usr4)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.usr5)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.usr6)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.unidade)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.unidad2)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.oftstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.ofostamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.familia)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.slvu)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.eslvu)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.sltt)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.esltt)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.slvumoeda)
                .HasPrecision(15, 2);

            modelBuilder.Entity<bi>()
                .Property(e => e.slttmoeda)
                .HasPrecision(15, 2);

            modelBuilder.Entity<bi>()
                .Property(e => e.ncmassa)
                .HasPrecision(16, 3);

            modelBuilder.Entity<bi>()
                .Property(e => e.ncunsup)
                .HasPrecision(14, 4);

            modelBuilder.Entity<bi>()
                .Property(e => e.ncvest)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.encvest)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.nccod)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.ncinteg)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.classif)
                .HasPrecision(1, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.classifc)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.posic)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.desconto)
                .HasPrecision(6, 2);

            modelBuilder.Entity<bi>()
                .Property(e => e.desc2)
                .HasPrecision(5, 2);

            modelBuilder.Entity<bi>()
                .Property(e => e.desc3)
                .HasPrecision(5, 2);

            modelBuilder.Entity<bi>()
                .Property(e => e.desc4)
                .HasPrecision(5, 2);

            modelBuilder.Entity<bi>()
                .Property(e => e.desc5)
                .HasPrecision(5, 2);

            modelBuilder.Entity<bi>()
                .Property(e => e.desc6)
                .HasPrecision(5, 2);

            modelBuilder.Entity<bi>()
                .Property(e => e.series)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.series2)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.ccusto)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.ncusto)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.num1)
                .HasPrecision(19, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.oobostamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.ltab1)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.ltab2)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.ltab3)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.ltab4)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.ltab5)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.fami)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.pctfami)
                .HasPrecision(6, 2);

            modelBuilder.Entity<bi>()
                .Property(e => e.tieca)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.etieca)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.mtieca)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bi>()
                .Property(e => e.volume)
                .HasPrecision(11, 3);

            modelBuilder.Entity<bi>()
                .Property(e => e.iecagrad)
                .HasPrecision(7, 3);

            modelBuilder.Entity<bi>()
                .Property(e => e.iecacodisen)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.peso)
                .HasPrecision(14, 3);

            modelBuilder.Entity<bi>()
                .Property(e => e.pbruto)
                .HasPrecision(14, 3);

            modelBuilder.Entity<bi>()
                .Property(e => e.codfiscal)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.dgeral)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.encargo)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.eencargo)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.custoind)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.ecustoind)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.tiposemp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.quarto)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.efornecedor)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.efornec)
                .HasPrecision(10, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.efornestab)
                .HasPrecision(3, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.optstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.oristamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.ecoval)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.eecoval)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.tecoval)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.etecoval)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.ecoval2)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.eecoval2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.tecoval2)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.etecoval2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.bostamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.ousrinis)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.ousrhora)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.usrinis)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.usrhora)
                .IsUnicode(false);

            modelBuilder.Entity<bi>()
                .Property(e => e.debitoori)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.edebitoori)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bi>()
                .Property(e => e.tpromo)
                .HasPrecision(1, 0);

            modelBuilder.Entity<bi>()
                .Property(e => e.valdesc)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bi>()
                .Property(e => e.evaldesc)
                .HasPrecision(19, 6);

            /*modelBuilder.Entity<bi>()
                .Property(e => e.u_matric)
                .IsUnicode(false);*/

            modelBuilder.Entity<bo>()
                .Property(e => e.bostamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.nmdos)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.obrano)
                .HasPrecision(10, 0);

            modelBuilder.Entity<bo>()
                .Property(e => e.nome)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.totaldeb)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.etotaldeb)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.smoe4)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bo>()
                .Property(e => e.smoe3)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bo>()
                .Property(e => e.smoe2)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bo>()
                .Property(e => e.smoe1)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bo>()
                .Property(e => e.moetotal)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bo>()
                .Property(e => e.sdeb2)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.sdeb1)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.sdeb4)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.sdeb3)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.sqtt14)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bo>()
                .Property(e => e.sqtt13)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bo>()
                .Property(e => e.sqtt12)
                .HasPrecision(13, 2);

            modelBuilder.Entity<bo>()
                .Property(e => e.sqtt11)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bo>()
                .Property(e => e.sqtt24)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bo>()
                .Property(e => e.sqtt23)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bo>()
                .Property(e => e.sqtt22)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bo>()
                .Property(e => e.sqtt21)
                .HasPrecision(13, 3);

            modelBuilder.Entity<bo>()
                .Property(e => e.vqtt24)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.vqtt23)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.vqtt22)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.vqtt21)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.vendedor)
                .HasPrecision(4, 0);

            modelBuilder.Entity<bo>()
                .Property(e => e.vendnm)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.stot1)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.stot2)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.stot3)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.stot4)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.no)
                .HasPrecision(10, 0);

            modelBuilder.Entity<bo>()
                .Property(e => e.obranome)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.boano)
                .HasPrecision(4, 0);

            modelBuilder.Entity<bo>()
                .Property(e => e.nopat)
                .HasPrecision(10, 0);

            modelBuilder.Entity<bo>()
                .Property(e => e.total)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.tecnico)
                .HasPrecision(4, 0);

            modelBuilder.Entity<bo>()
                .Property(e => e.tecnnm)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.nomquina)
                .HasPrecision(6, 0);

            modelBuilder.Entity<bo>()
                .Property(e => e.maquina)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.serie)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.zona)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.obs)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.trab1)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.trab2)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.trab3)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.trab4)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.trab5)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.ndos)
                .HasPrecision(3, 0);

            modelBuilder.Entity<bo>()
                .Property(e => e.custo)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.moeda)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.estab)
                .HasPrecision(3, 0);

            modelBuilder.Entity<bo>()
                .Property(e => e.morada)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.local)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.codpost)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.period)
                .HasPrecision(4, 0);

            modelBuilder.Entity<bo>()
                .Property(e => e.tabela1)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.ncont)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.segmento)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.userimpresso)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.fref)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.ccusto)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.ncusto)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.cobranca)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.esdeb1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.esdeb2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.esdeb3)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.esdeb4)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.evqtt21)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.evqtt22)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.evqtt23)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.evqtt24)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.estot1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.estot2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.estot3)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.estot4)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.etotal)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.ecusto)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo_2tdesc1)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo_2tdesc2)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo_2tdes1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo_2tdes2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.descc)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.edescc)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo_1tvall)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo_2tvall)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo_1tvall)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo_2tvall)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo11_bins)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo11_iva)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo11_bins)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo11_iva)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo21_bins)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo21_iva)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo21_bins)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo21_iva)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo31_bins)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo31_iva)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo31_bins)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo31_iva)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo41_bins)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo41_iva)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo41_bins)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo41_iva)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo51_bins)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo51_iva)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo51_bins)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo51_iva)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo61_bins)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo61_iva)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo61_bins)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo61_iva)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo12_bins)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo12_iva)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo12_bins)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo12_iva)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo22_bins)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo22_iva)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo22_bins)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo22_iva)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo32_bins)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo32_iva)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo32_bins)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo32_iva)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo42_bins)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo42_iva)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo42_bins)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo42_iva)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo52_bins)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo52_iva)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo52_bins)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo52_iva)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo62_bins)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo62_iva)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo62_bins)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo62_iva)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo_totp1)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.bo_totp2)
                .HasPrecision(18, 5);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo_totp1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.ebo_totp2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<bo>()
                .Property(e => e.memissao)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.nome2)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.pastamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.snstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.mastamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.origem)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.orinopat)
                .HasPrecision(10, 0);

            modelBuilder.Entity<bo>()
                .Property(e => e.site)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.pnome)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.pno)
                .HasPrecision(3, 0);

            modelBuilder.Entity<bo>()
                .Property(e => e.cxstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.cxusername)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.ssstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.ssusername)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.series)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.series2)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.quarto)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.ocupacao)
                .HasPrecision(1, 0);

            modelBuilder.Entity<bo>()
                .Property(e => e.tabela2)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.obstab2)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.iemail)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.inome)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.situacao)
                .HasPrecision(1, 0);

            modelBuilder.Entity<bo>()
                .Property(e => e.lang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.ean)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.iecacodisen)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.tpstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.tpdesc)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.statuspda)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.boid)
                .HasPrecision(12, 0);

            modelBuilder.Entity<bo>()
                .Property(e => e.ousrinis)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.ousrhora)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.usrinis)
                .IsUnicode(false);

            modelBuilder.Entity<bo>()
                .Property(e => e.usrhora)
                .IsUnicode(false);

            /*modelBuilder.Entity<bo>()
                .Property(e => e.u_gpgasto)
                .IsUnicode(false);*/

           /* modelBuilder.Entity<bo>()
                .Property(e => e.u_hrs)
                .HasPrecision(10, 0);*/

            /*modelBuilder.Entity<bo>()
                .Property(e => e.u_kms)
                .HasPrecision(9, 0);*/

            modelBuilder.Entity<bo>()
                .Property(e => e.u_matricul)
                .IsUnicode(false);

            /*modelBuilder.Entity<bo>()
                .Property(e => e.u_motorist)
                .IsUnicode(false);*/

            /*modelBuilder.Entity<bo>()
                .Property(e => e.u_tpgasto)
                .IsUnicode(false);*/

            /*modelBuilder.Entity<bo>()
                .Property(e => e.u_totaldoc)
                .HasPrecision(12, 2);*/

            modelBuilder.Entity<st>()
                .Property(e => e.ststamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e._ref)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.design)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.familia)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.stock)
                .HasPrecision(13, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.epv1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.pv1)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.forref)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.fornecedor)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.desc3)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.desc2)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.desc1)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.usr2)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.usr1)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.usrqtt)
                .HasPrecision(13, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.eoq)
                .HasPrecision(13, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.pcult)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.pcimp)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.pcmoe)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.pvcon)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.pvultimo)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.pv3)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.pv2)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.unidade)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.ptoenc)
                .HasPrecision(10, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.tabiva)
                .HasPrecision(1, 0);

            modelBuilder.Entity<st>()
                .Property(e => e.local)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.fornec)
                .HasPrecision(10, 0);

            modelBuilder.Entity<st>()
                .Property(e => e.fornestab)
                .HasPrecision(3, 0);

            modelBuilder.Entity<st>()
                .Property(e => e.qttfor)
                .HasPrecision(13, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.qttcli)
                .HasPrecision(13, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.qttrec)
                .HasPrecision(13, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.pcusto)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.pcpond)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.qttacin)
                .HasPrecision(13, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.qttacout)
                .HasPrecision(13, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.qttvend)
                .HasPrecision(6, 0);

            modelBuilder.Entity<st>()
                .Property(e => e.pmvenda)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.valin)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.valout)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.stmax)
                .HasPrecision(13, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.stmin)
                .HasPrecision(13, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.obs)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.codigo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.uni2)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.conversao)
                .HasPrecision(15, 7);

            modelBuilder.Entity<st>()
                .Property(e => e.ecomissao)
                .HasPrecision(3, 0);

            modelBuilder.Entity<st>()
                .Property(e => e.imagem)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.pv4)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.pv5)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.cpoc)
                .HasPrecision(6, 0);

            modelBuilder.Entity<st>()
                .Property(e => e.containv)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.contacev)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.contareo)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.contacoe)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.peso)
                .HasPrecision(14, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.mfornec)
                .HasPrecision(6, 2);

            modelBuilder.Entity<st>()
                .Property(e => e.mfornec2)
                .HasPrecision(6, 2);

            modelBuilder.Entity<st>()
                .Property(e => e.pentrega)
                .HasPrecision(3, 0);

            modelBuilder.Entity<st>()
                .Property(e => e.consumo)
                .HasPrecision(13, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.despimp)
                .HasPrecision(5, 2);

            modelBuilder.Entity<st>()
                .Property(e => e.mesescon)
                .HasPrecision(3, 0);

            modelBuilder.Entity<st>()
                .Property(e => e.marg1)
                .HasPrecision(16, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.marg2)
                .HasPrecision(16, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.marg3)
                .HasPrecision(16, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.marg4)
                .HasPrecision(16, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.marg5)
                .HasPrecision(16, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.diaspto)
                .HasPrecision(3, 0);

            modelBuilder.Entity<st>()
                .Property(e => e.diaseoq)
                .HasPrecision(3, 0);

            modelBuilder.Entity<st>()
                .Property(e => e.desc4)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.desc5)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.desc6)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.pbruto)
                .HasPrecision(14, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.volume)
                .HasPrecision(11, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.garantia)
                .HasPrecision(5, 0);

            modelBuilder.Entity<st>()
                .Property(e => e.faminome)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.usr3)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.usr4)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.usr5)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.qttesp)
                .HasPrecision(11, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.epv2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.epv3)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.epv4)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.epv5)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.epcusto)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.epcpond)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.epcult)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.epmvenda)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.epvultimo)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.epvcon)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.stid)
                .HasPrecision(12, 0);

            modelBuilder.Entity<st>()
                .Property(e => e.tipodesc)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.usr6)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.convunsup)
                .HasPrecision(15, 7);

            modelBuilder.Entity<st>()
                .Property(e => e.nccod)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.massaliq)
                .HasPrecision(18, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.vaiwww)
                .HasPrecision(1, 0);

            modelBuilder.Entity<st>()
                .Property(e => e.iectin)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.eiectin)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.codfiscal)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.iecagrad)
                .HasPrecision(7, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.iecaref)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.iecarefnome)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.txieca)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.txiecanome)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.iecautt)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.site)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.txtqlook)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.imgqlook)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.lang1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.langdes1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.lang2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.langdes2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.lang3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.langdes3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.lang4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.langdes4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.lang5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.langdes5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.statuspda)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.qttcat)
                .HasPrecision(13, 3);

            modelBuilder.Entity<st>()
                .Property(e => e.eecoval)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.ecoval)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.eecopval)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.ecopval)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.eecoeval)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.ecoeval)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.eecorval)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.ecorval)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.eecooval)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.ecooval)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.ousrinis)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.ousrhora)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.usrinis)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.usrhora)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.contaieo)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.refmo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.descrmo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.pcmo)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.epcmo)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.custo)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.ecusto)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.desci)
                .HasPrecision(6, 2);

            modelBuilder.Entity<st>()
                .Property(e => e.descii)
                .HasPrecision(6, 2);

            modelBuilder.Entity<st>()
                .Property(e => e.pcdisp)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.epcdisp)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.pclab)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.epclab)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.custog)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.ecustog)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.custof)
                .HasPrecision(18, 5);

            modelBuilder.Entity<st>()
                .Property(e => e.ecustof)
                .HasPrecision(19, 6);

            modelBuilder.Entity<st>()
                .Property(e => e.unidadef)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.ofcstamp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.codcmb)
                .HasPrecision(2, 0);

            modelBuilder.Entity<st>()
                .Property(e => e.horanovpv)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.tkhclass)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.restctprep)
                .IsUnicode(false);

            modelBuilder.Entity<st>()
                .Property(e => e.idudesign)
                .IsUnicode(false);

           /* modelBuilder.Entity<st>()
                .Property(e => e.u_strt)
                .IsUnicode(false);*/
        }
    }
}
