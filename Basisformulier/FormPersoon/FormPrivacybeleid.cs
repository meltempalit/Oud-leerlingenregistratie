using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormPersoon;

namespace FormPersoon
{
    public partial class FormPrivacybeleid : Form
    {
        public FormPrivacybeleid()
        {
            InitializeComponent();
        }

        private void FormPrivacybeleid_Load(object sender, EventArgs e)
        {
             richTextBox1.Text = "weerbaarheid: de innerlijke kracht om in concrete situaties het juiste 'ja' en 'neen' te zeggen " +
        " en ernaar te handelen. In een samenleving die ons voortdurend uitnodigt om zoveel " +
        "mogelijk te hebben 'nu en meteen', blijft het waardevol om te kunnen wachten en verlangen.Dit veronderstelt dus durf om tegen het groepsdenken in te gaan, bijvoorbeeld en in " +
        "het bijzonder omtrent ongezonde en verslavende(genot)middelen zoals tabak, alcohol en"+
        "alle drugs. '";
            
            richTextBox1.Text += "Door de inschrijving van uw kind in onze school verwachten we dat zij of hij vanaf de eerste " +
        "schooldag tot en met 30 juni deelneemt aan alle lessen en activiteiten van het leerjaar dat hij of"+
        " zij volgt.Bezinningsdagen, buitenschoolse activiteiten enzovoort worden als normale"+
        " schooldagen beschouwd, ook als ze meerdere dagen in beslag nemen. Ze geven je kind een "+
        " kans om zich te verrijken en zich verder te ontwikkelen.Dat betekent dan ook dat je kind"+
            "hieraan moet deelnemen."+
            "Verder verwachten we dat je kind elke schooldag tijdig aanwezig is op school. Te laat komen"+
        "kan gesanctioneerd worden met een orde - of tuchtmaatregel."+
        "Het kan altijd gebeuren dat je kind om een bepaalde reden niet kan deelnemen aan alle lessen"+
        "of lesvervangende activiteiten of dat het te laat komt. De concrete afspraken hierover vind je"+
        "terug in het schoolreglement" + "Jongeren ervaren leren en schoollopen soms om diverse redenen als lastige, minder leuke"+
        "opdrachten.Zomaar wegblijven uit de school kan echter niet. Bij moeilijkheden wil de school,"+
        "samen met het CLB, helpen ze op te lossen. De school verwacht bovendien je actieve"+
        "medewerking bij eventuele begeleidingsmaatregelen op dit vlak."+
        "Van zodra de school de spijbelproblematiek beschouwt als zorgwekkend, speelt ze het dossier"+
        "door naar het Ministerie van Onderwijs. Meer informatie over het spijbelbeleid van de school"+
        "vind je terug in het schoolreglement"+
        "We hebben de volgende afspraken over de schoolrekening:"+
        "De school bezorgt aan je ouders per trimester een schoolrekening. We verwachten dat deze"+
        "afrekening binnen de 14 dagen na factuurdatum en volledig wordt betaald.Je ouders zijn,"+
        "ongeacht hun burgerlijke staat, hoofdelijk gehouden tot betaling van de schoolrekening. Dat"+
        "betekent dat we hen allebei kunnen aanspreken om de volledige rekening te betalen. We"+
        "kunnen dus niet ingaan op een vraag om de schoolrekening te splitsen.Als je ouders het niet"+
        "eens zijn over het betalen van de schoolrekening, zullen we hen allebei een identieke"+
        "schoolrekening bezorgen. Zolang die rekening niet volledig is betaald, blijven je beide ouders"+
        "elk het volledige resterende saldo verschuldigd, ongeacht de afspraken die ze met elkaar "
         ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
