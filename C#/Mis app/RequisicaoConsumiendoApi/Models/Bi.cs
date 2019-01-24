using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisicao.Models
{
    public class Bi
    {
        [JsonProperty("bistamp")]
        public string bistamp { get; set; }
        [JsonProperty("nmdos")]
        public string nmdos { get; set; }
        [JsonProperty("obrano")]
        public decimal obrano { get; set; }
        [JsonProperty("ref")]
        public string @ref { get; set; }
        [JsonProperty("design ")]
        public string design { get; set; }
        [JsonProperty("qtt")]
        public decimal qtt { get; set; }
        [JsonProperty("qtt2")]
        public decimal qtt2 { get; set; }
        [JsonProperty("iva")]
        public decimal iva { get; set; }
        [JsonProperty("tabiva")]
        public decimal tabiva { get; set; }
        [JsonProperty("armazem")]
        public decimal armazem { get; set; }
        [JsonProperty("pu")]
        public decimal pu { get; set; }
        [JsonProperty("debito")]
        public decimal debito { get; set; }
        [JsonProperty("prorc")]
        public decimal prorc { get; set; }
        [JsonProperty("stipo")]
        public decimal stipo { get; set; }
        [JsonProperty("no")]
        public decimal no { get; set; }
        [JsonProperty("pcusto")]
        public decimal pcusto { get; set; }
        [JsonProperty("serie")]
        public string serie { get; set; }
        [JsonProperty("nomquina")]
        public decimal nomquina { get; set; }
        [JsonProperty("nopat")]
        public decimal nopat { get; set; }
        [JsonProperty("fno")]
        public decimal fno { get; set; }
        [JsonProperty("fdata")]
        public DateTime? fdata { get; set; }
        [JsonProperty("nmdoc")]
        public string nmdoc { get; set; }
        [JsonProperty("ndoc")]
        public decimal ndoc { get; set; }
        [JsonProperty("ndos")]
        public decimal ndos { get; set; }
        [JsonProperty("forref")]
        public string forref { get; set; }
        [JsonProperty("txiva")]
        public decimal txiva { get; set; }
        [JsonProperty("rdata")]
        public DateTime? rdata { get; set; }
        [JsonProperty("dedata")]
        public DateTime? dedata { get; set; }
        [JsonProperty("atedata")]
        public DateTime? atedata { get; set; }
        [JsonProperty("lobs")]
        public string lobs { get; set; }
        [JsonProperty("ldossier")]
        public decimal ldossier { get; set; }
        [JsonProperty("obranome")]
        public string obranome { get; set; }
        [JsonProperty("fechada")]
        public bool fechada { get; set; }
        [JsonProperty("datafinal")]
        public DateTime? datafinal { get; set; }
        [JsonProperty("dataobra")]
        public DateTime? dataobra { get; set; }
        [JsonProperty("dataopen")]
        public DateTime? dataopen { get; set; }
        [JsonProperty("datafecho")]
        public DateTime? datafecho { get; set; }
        [JsonProperty("tecnico")]
        public decimal tecnico { get; set; }
        [JsonProperty("maquina")]
        public string maquina { get; set; }
        [JsonProperty("marca")]
        public string marca { get; set; }
        [JsonProperty("zona")]
        public string zona { get; set; }
        [JsonProperty("litem")]
        public string litem { get; set; }
        [JsonProperty("vumoeda")]
        public decimal vumoeda { get; set; }
        [JsonProperty("resfor")]
        public bool resfor { get; set; }
        [JsonProperty("rescli")]
        public bool rescli { get; set; }
        [JsonProperty("resrec")]
        public bool resrec { get; set; }      
        [JsonProperty("iprint")]
        public bool iprint { get; set; }
       //[JsonProperty("iprdecimal")]
       // public bool iprdecimal { get; set; }
        [JsonProperty("lobs2")]
        public string lobs2 { get; set; }
        [JsonProperty("litem2")]
        public string litem2 { get; set; }
        [JsonProperty("lobs3")]
        public string lobs3 { get; set; }
        [JsonProperty("estab")]
        public decimal estab { get; set; }
        [JsonProperty("resusr")]
        public bool resusr { get; set; }
        [JsonProperty("ar2mazem")]
        public decimal ar2mazem { get; set; }
        [JsonProperty("composto")]
        public bool composto { get; set; }
        [JsonProperty("compostoori")]
        public bool compostoori { get; set; }
        [JsonProperty("lrecno")]
        public string lrecno { get; set; }
        [JsonProperty("lordem")]
        public decimal lordem { get; set; }
        [JsonProperty("fmarcada")]
        public bool fmarcada { get; set; }
        [JsonProperty("producao")]
        public bool producao { get; set; }
        [JsonProperty("local")]
        public string local { get; set; }
        [JsonProperty("morada")]
        public string morada { get; set; }
        [JsonProperty("codpost")]
        public string codpost { get; set; }
        [JsonProperty("nome")]
        public string nome { get; set; }
        [JsonProperty("vendedor")]
        public decimal vendedor { get; set; }
        [JsonProperty("vendnm")]
        public string vendnm { get; set; }
        [JsonProperty("tabfor")]
        public bool tabfor { get; set; }
        [JsonProperty("tabela1")]
        public string tabela1 { get; set; }
        [JsonProperty("descli")]
        public bool descli { get; set; }
        [JsonProperty("reff")]
        public string reff { get; set; }
        [JsonProperty("lote")]
        public string lote { get; set; }
        [JsonProperty("ivaincl")]
        public bool ivaincl { get; set; }
        [JsonProperty("cor")]
        public string cor { get; set; }
        [JsonProperty("tam")]
        public string tam { get; set; }
        [JsonProperty("segmento")]
        public string segmento { get; set; }
        [JsonProperty("bofref")]
        public string bofref { get; set; }
        [JsonProperty("bifref")]
        public string bifref { get; set; }
        [JsonProperty("grau")]
        public decimal grau { get; set; }
        [JsonProperty("partes")]
        public decimal partes { get; set; }
        [JsonProperty("partes2")]
        public decimal partes2 { get; set; }
        [JsonProperty("altura")]
        public decimal altura { get; set; }
        [JsonProperty("largura")]
        public decimal largura { get; set; }
        [JsonProperty("espessura")]
        public decimal espessura { get; set; }
        [JsonProperty("biserie")]
        public string biserie { get; set; }
        [JsonProperty("infref")]
        public bool infref { get; set; }
        [JsonProperty("lifref")]
        public bool lifref { get; set; }
        [JsonProperty("uni2qtt")]
        public decimal uni2qtt { get; set; }
        [JsonProperty("epu ")]
        public decimal epu { get; set; }
        [JsonProperty("edebito")]
        public decimal edebito { get; set; }
        [JsonProperty("eprorc")]
        public decimal eprorc { get; set; }
        [JsonProperty("epcusto")]
        public decimal epcusto { get; set; }
        [JsonProperty("ttdeb")]
        public decimal ttdeb { get; set; }
        [JsonProperty("ettdeb")]
        public decimal ettdeb { get; set; }
        [JsonProperty("ttmoeda")]
        public decimal ttmoeda { get; set; }
        [JsonProperty("adoc")]
        public string adoc { get; set; }
        [JsonProperty("binum1")]
        public decimal binum1 { get; set; }
        [JsonProperty("binum2")]
        public decimal binum2 { get; set; }
        [JsonProperty("codigo")]
        public string codigo { get; set; }
        [JsonProperty("cpoc")]
        public decimal cpoc { get; set; }
        [JsonProperty("stns")]
        public bool stns { get; set; }
        [JsonProperty("obistamp")]
        public string obistamp { get; set; }
        [JsonProperty("oobistamp")]
        public string oobistamp { get; set; }
        [JsonProperty("usr1")]
        public string usr1 { get; set; }
        [JsonProperty("usr2")]
        public string usr2 { get; set; }
        [JsonProperty("usr3")]
        public string usr3 { get; set; }
        [JsonProperty("usr4")]
        public string usr4 { get; set; }
        [JsonProperty("usr5")]
        public string usr5 { get; set; }
        [JsonProperty("usr6")]
        public string usr6 { get; set; }
        [JsonProperty("usalote")]
        public bool usalote { get; set; }
        [JsonProperty("texteis")]
        public bool texteis { get; set; }
        [JsonProperty("unidade")]
        public string unidade { get; set; }
        [JsonProperty("unidad2")]
        public string unidad2 { get; set; }
        [JsonProperty("oftstamp")]
        public string oftstamp { get; set; }
        [JsonProperty("ofostamp")]
        public string ofostamp { get; set; }
        [JsonProperty("promo")]
        public bool promo { get; set; }
        [JsonProperty("epromo")]
        public bool epromo { get; set; }
        [JsonProperty("familia")]
        public string familia { get; set; }
        [JsonProperty("sattotal")]
        public bool sattotal { get; set; }
        [JsonProperty("noserie")]
        public bool noserie { get; set; }
        [JsonProperty("slvu")]
        public decimal slvu { get; set; }
        [JsonProperty("eslvu")]
        public decimal eslvu { get; set; }
        [JsonProperty("sltt")]
        public decimal sltt { get; set; }
        [JsonProperty("esltt")]
        public decimal esltt { get; set; }
        [JsonProperty("slvumoeda")]
        public decimal slvumoeda { get; set; }
        [JsonProperty("slttmoeda")]
        public decimal slttmoeda { get; set; }
        [JsonProperty("ncmassa")]
        public decimal ncmassa { get; set; }
        [JsonProperty("ncunsup")]
        public decimal ncunsup { get; set; }
        [JsonProperty("ncvest")]
        public decimal ncvest { get; set; }
        [JsonProperty("encvest")]
        public decimal encvest { get; set; }
        [JsonProperty("nccod")]
        public string nccod { get; set; }
        [JsonProperty("ncinteg")]
        public string ncinteg { get; set; }
        [JsonProperty("classif")]
        public decimal classif { get; set; }
        [JsonProperty("classifc")]
        public string classifc { get; set; }
        [JsonProperty("posic")]
        public string posic { get; set; }
        [JsonProperty("desconto")]
        public decimal desconto { get; set; }
        [JsonProperty("desc2")]
        public decimal desc2 { get; set; }
        [JsonProperty("desc3")]
        public decimal desc3 { get; set; }
        [JsonProperty("desc4")]
        public decimal desc4 { get; set; }
        [JsonProperty("desc5")]
        public decimal desc5 { get; set; }
        [JsonProperty("desc6")]
        public decimal desc6 { get; set; }
        [JsonProperty("series")]
        public string series { get; set; }
        [JsonProperty("series2")]
        public string series2 { get; set; }
        [JsonProperty("ccusto")]
        public string ccusto { get; set; }
        [JsonProperty("ncusto")]
        public string ncusto { get; set; }
        [JsonProperty("num1")]
        public decimal num1 { get; set; }
        [JsonProperty("fechabo")]
        public bool fechabo { get; set; }
        [JsonProperty("oobostamp")]
        public string oobostamp { get; set; }
        [JsonProperty("ltab1")]
        public string ltab1 { get; set; }
        [JsonProperty("ltab2")]
        public string ltab2 { get; set; }
        [JsonProperty("ltab3")]
        public string ltab3 { get; set; }
        [JsonProperty("ltab4")]
        public string ltab4 { get; set; }
        [JsonProperty("ltab5")]
        public string ltab5 { get; set; }
        [JsonProperty("fami")]
        public string fami { get; set; }
        [JsonProperty("pctfami")]
        public decimal pctfami { get; set; }
        [JsonProperty("adjudicada")]
        public bool adjudicada { get; set; }
        [JsonProperty("tieca")]
        public decimal tieca { get; set; }
        [JsonProperty("etieca")]
        public decimal etieca { get; set; }
        [JsonProperty("mtieca")]
        public decimal mtieca { get; set; }
        [JsonProperty("volume")]
        public decimal volume { get; set; }
        [JsonProperty("iecasug")]
        public bool iecasug { get; set; }
        [JsonProperty("iecagrad")]
        public decimal iecagrad { get; set; }
        [JsonProperty("iecacodisen")]
        public string iecacodisen { get; set; }
        [JsonProperty("peso")]
        public decimal peso { get; set; }
        [JsonProperty("pbruto")]
        public decimal pbruto { get; set; }
        [JsonProperty("codfiscal")]
        public string codfiscal { get; set; }
        [JsonProperty("dgeral")]
        public string dgeral { get; set; }
        [JsonProperty("temoci")]
        public bool temoci { get; set; }
        [JsonProperty("temomi")]
        public bool temomi { get; set; }
        [JsonProperty("temsubemp")]
        public bool temsubemp { get; set; }
        [JsonProperty("encargo")]
        public decimal encargo { get; set; }
        [JsonProperty("eencargo")]
        public decimal eencargo { get; set; }
        [JsonProperty("custoind ")]
        public decimal custoind { get; set; }
        [JsonProperty("ecustoind")]
        public decimal ecustoind { get; set; }
        [JsonProperty("tiposemp")]
        public string tiposemp { get; set; }
        [JsonProperty("pvok")]
        public bool pvok { get; set; }
        [JsonProperty("boclose")]
        public bool boclose { get; set; }
        [JsonProperty("dtclose")]
        public DateTime? dtclose { get; set; }
        [JsonProperty("quarto")]
        public string quarto { get; set; }
        [JsonProperty("emconf")]
        public bool emconf { get; set; }
        [JsonProperty("efornecedor")]
        public string efornecedor { get; set; }
        [JsonProperty("efornec")]
        public decimal efornec { get; set; }
        [JsonProperty("efornestab")]
        public decimal efornestab { get; set; }
        [JsonProperty("cativo")]
        public bool cativo { get; set; }
        [JsonProperty("optstamp")]
        public string optstamp { get; set; }
        [JsonProperty("oristamp")]
        public string oristamp { get; set; }
        [JsonProperty("temeco")]
        public bool temeco { get; set; }
        [JsonProperty("ecoval")]
        public decimal ecoval { get; set; }
        [JsonProperty("eecoval")]
        public decimal eecoval { get; set; }
        [JsonProperty("tecoval")]
        public decimal tecoval { get; set; }
        [JsonProperty("etecoval")]
        public decimal etecoval { get; set; }
        [JsonProperty("ecoval2")]
        public decimal ecoval2 { get; set; }
        [JsonProperty("eecoval2")]
        public decimal eecoval2 { get; set; }
        [JsonProperty("tecoval2")]
        public decimal tecoval2 { get; set; }
        [JsonProperty("etecoval2")]
        public decimal etecoval2 { get; set; }
        [JsonProperty("econotcalc")]
        public bool econotcalc { get; set; }
        [JsonProperty("bostamp")]
        public string bostamp { get; set; }
        [JsonProperty("ousrinis")]
        public string ousrinis { get; set; }
        [JsonProperty("ousrdata")]
        public DateTime? ousrdata { get; set; }
        [JsonProperty("ousrhora")]
        public string ousrhora { get; set; }
        [JsonProperty("usrinis")]
        public string usrinis { get; set; }
        [JsonProperty("usrdata")]
        public DateTime? usrdata { get; set; }
        [JsonProperty("usrhora")]
        public string usrhora { get; set; }
        [JsonProperty("marcada")]
        public bool marcada { get; set; }
        [JsonProperty("mntencargos")]
        public bool mntencargos { get; set; }
        [JsonProperty("debitoori")]
        public decimal debitoori { get; set; }
        [JsonProperty("edebitoori")]
        public decimal edebitoori { get; set; }
        [JsonProperty("trocaequi")]
        public bool trocaequi { get; set; }
        [JsonProperty("tpromo")]
        public decimal tpromo { get; set; }
        [JsonProperty("valdesc")]
        public decimal valdesc { get; set; }
        [JsonProperty("evaldesc")]
        public decimal evaldesc { get; set; }
        [JsonProperty("u_matric ")]
        public string u_matric { get; set; }
    }
}
