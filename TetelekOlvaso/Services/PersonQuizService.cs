using TetelekOlvaso.Models;

namespace TetelekOlvaso.Services
{
    public class PersonQuizService
    {
        private readonly List<PersonQuestion> _questions = new()
        {// =====================
// 1. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 1,
    Question = "Melyik intézmény játszott kulcsszerepet a mezőgazdasági technikai újítások terjesztésében a középkorban?",
    CorrectAnswer = "kolostorok",
    Answers = new List<string>{ "kolostorok","lovagi várak","városi tanácsok","kereskedőházak"}
},

new PersonQuestion
{
    TetelNumber = 1,
    Question = "Melyik nép fejlesztette ki a csoroszlyás, kormánylemezes nehéz ekét?",
    CorrectAnswer = "germánok",
    Answers = new List<string>{ "rómaiak","germánok","arabok","bizánciak"}
},

new PersonQuestion
{
    TetelNumber = 1,
    Question = "Melyik mezőgazdasági rendszer növelte meg jelentősen a terméshozamot a középkorban?",
    CorrectAnswer = "háromnyomásos gazdálkodás",
    Answers = new List<string>{ "kétmezős gazdálkodás","háromnyomásos gazdálkodás","ültetvényes gazdálkodás","robotgazdálkodás"}
},

new PersonQuestion
{
    TetelNumber = 1,
    Question = "Melyik szervezet fogta össze az északi-tengeri és balti kereskedővárosokat?",
    CorrectAnswer = "Hanza-szövetség",
    Answers = new List<string>{ "Hanza-szövetség","Itáliai Liga","Kereskedő Tanács","Céhszövetség"}
},

new PersonQuestion
{
    TetelNumber = 1,
    Question = "Melyik város volt a középkori pénzügyi és bankélet egyik központja?",
    CorrectAnswer = "Firenze",
    Answers = new List<string>{ "Velence","Firenze","Hamburg","Brugge"}
},

new PersonQuestion
{
    TetelNumber = 1,
    Question = "Melyik társadalmi csoport szervezte meg a céheket?",
    CorrectAnswer = "kézművesek",
    Answers = new List<string>{ "nemesek","kézművesek","jobbágyok","papok"}
},

new PersonQuestion
{
    TetelNumber = 1,
    Question = "Mi biztosította a céhekben a termékek minőségét?",
    CorrectAnswer = "céhszabályzat",
    Answers = new List<string>{ "királyi törvény","céhszabályzat","püspöki rendelet","városi tanács"}
},

new PersonQuestion
{
    TetelNumber = 1,
    Question = "Melyik kereskedelmi útvonal kötötte össze a Baltikumot Nyugat-Európával?",
    CorrectAnswer = "Hanza kereskedelmi útvonal",
    Answers = new List<string>{ "Selyemút","Hanza kereskedelmi útvonal","Borostyán út","Fűszerút"}
},

new PersonQuestion
{
    TetelNumber = 1,
    Question = "Melyik társadalmi réteg kezdett megerősödni a középkori városok fejlődésével?",
    CorrectAnswer = "polgárság",
    Answers = new List<string>{ "polgárság","nemesség","jobbágyság","papság"}
},

new PersonQuestion
{
    TetelNumber = 1,
    Question = "Melyik technikai újítás segítette a mezőgazdasági termelést a középkorban?",
    CorrectAnswer = "nehézeke",
    Answers = new List<string>{ "nehézeke","gőzgép","vetőgép","traktor"}
},

new PersonQuestion
{
    TetelNumber = 1,
    Question = "Mi tette lehetővé a terményfelesleg piacra vitelét?",
    CorrectAnswer = "kereskedelem fejlődése",
    Answers = new List<string>{ "kereskedelem fejlődése","háborúk","járványok","jobbágylázadások"}
},

// =====================
// 2. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 2,
    Question = "Ki vezette be az aranyforintot Magyarországon?",
    CorrectAnswer = "Károly Róbert",
    Answers = new List<string>{ "Károly Róbert","Nagy Lajos","Zsigmond","Mátyás"}
},

new PersonQuestion
{
    TetelNumber = 2,
    Question = "Kihez köthető a kapuadó bevezetése?",
    CorrectAnswer = "Károly Róbert",
    Answers = new List<string>{ "Károly Róbert","Zsigmond","Mátyás","II. András"}
},

new PersonQuestion
{
    TetelNumber = 2,
    Question = "Ki volt Károly Róbert gazdasági reformjainak fő szervezője?",
    CorrectAnswer = "Nekcsei Demeter",
    Answers = new List<string>{ "Nekcsei Demeter","Thurzó János","Garai Miklós","Vitéz János"}
},

new PersonQuestion
{
    TetelNumber = 2,
    Question = "Ki vezette be a füstpénzt?",
    CorrectAnswer = "Hunyadi Mátyás",
    Answers = new List<string>{ "Hunyadi Mátyás","Zsigmond","Nagy Lajos","II. András"}
},

new PersonQuestion
{
    TetelNumber = 2,
    Question = "Ki szervezte meg a fekete sereget?",
    CorrectAnswer = "Hunyadi Mátyás",
    Answers = new List<string>{ "Hunyadi János","Hunyadi Mátyás","Zsigmond","Ulászló"}
},

new PersonQuestion
{
    TetelNumber = 2,
    Question = "Melyik uralkodó erősítette meg a nemesi jogokat az 1351-es törvényekkel?",
    CorrectAnswer = "Nagy Lajos",
    Answers = new List<string>{ "Károly Róbert","Nagy Lajos","Zsigmond","Mátyás"}
},

new PersonQuestion
{
    TetelNumber = 2,
    Question = "Ki hívta meg a városok képviselőit az országgyűlésre?",
    CorrectAnswer = "Luxemburgi Zsigmond",
    Answers = new List<string>{ "Nagy Lajos","Luxemburgi Zsigmond","Mátyás","II. András"}
},

new PersonQuestion
{
    TetelNumber = 2,
    Question = "Melyik adó váltotta fel a kapuadót Mátyás idején?",
    CorrectAnswer = "füstpénz",
    Answers = new List<string>{ "kilenced","füstpénz","harmincad","tized"}
},

new PersonQuestion
{
    TetelNumber = 2,
    Question = "Mi volt a fekete sereg jelentősége?",
    CorrectAnswer = "állandó zsoldoshadsereg",
    Answers = new List<string>{ "nemesi felkelés","állandó zsoldoshadsereg","jobbágyhadsereg","lovagrend"}
},
// =====================
// 3. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 3,
    Question = "Ki dolgozta ki az első világháború után a Dawes-tervet a német jóvátétel rendezésére?",
    CorrectAnswer = "Charles Dawes",
    Answers = new List<string>{ "Woodrow Wilson","Charles Dawes","Franklin Roosevelt","Jean Monnet"}
},

new PersonQuestion
{
    TetelNumber = 3,
    Question = "Ki fogalmazta meg az első világháború után a 14 pontot?",
    CorrectAnswer = "Woodrow Wilson",
    Answers = new List<string>{ "Woodrow Wilson","Winston Churchill","Roosevelt","Truman"}
},

new PersonQuestion
{
    TetelNumber = 3,
    Question = "Ki hirdette meg az USA-ban a New Deal gazdaságpolitikai programot?",
    CorrectAnswer = "Franklin Delano Roosevelt",
    Answers = new List<string>{ "Herbert Hoover","Franklin Delano Roosevelt","Truman","Wilson"}
},

new PersonQuestion
{
    TetelNumber = 3,
    Question = "Ki mondta el a híres zürichi beszédet az Európai Egyesült Államok létrehozásáról?",
    CorrectAnswer = "Winston Churchill",
    Answers = new List<string>{ "Winston Churchill","Charles de Gaulle","Schuman","Adenauer"}
},

new PersonQuestion
{
    TetelNumber = 3,
    Question = "Ki terjesztette elő az európai integrációt elindító Schuman-tervet?",
    CorrectAnswer = "Robert Schuman",
    Answers = new List<string>{ "Robert Schuman","Jean Monnet","Churchill","De Gaulle"}
},

new PersonQuestion
{
    TetelNumber = 3,
    Question = "Ki volt az USA elnöke a nagy gazdasági világválság kezdetén?",
    CorrectAnswer = "Herbert Hoover",
    Answers = new List<string>{ "Franklin Roosevelt","Herbert Hoover","Wilson","Truman"}
},

new PersonQuestion
{
    TetelNumber = 3,
    Question = "Kihez köthető az európai integráció egyik alapgondolatának kidolgozása a Schuman-terv mögött?",
    CorrectAnswer = "Jean Monnet",
    Answers = new List<string>{ "Jean Monnet","Churchill","Wilson","Dawes"}
},

new PersonQuestion
{
    TetelNumber = 3,
    Question = "Ki volt Franciaország vezetője a második világháború alatt a Szabad Franciaország élén?",
    CorrectAnswer = "Charles de Gaulle",
    Answers = new List<string>{ "Charles de Gaulle","Schuman","Adenauer","Churchill"}
},

new PersonQuestion
{
    TetelNumber = 3,
    Question = "Ki volt Nyugat-Németország első kancellárja?",
    CorrectAnswer = "Konrad Adenauer",
    Answers = new List<string>{ "Konrad Adenauer","Willy Brandt","Schuman","De Gaulle"}
},

new PersonQuestion
{
    TetelNumber = 3,
    Question = "Ki volt az USA elnöke a második világháború idején?",
    CorrectAnswer = "Franklin Delano Roosevelt",
    Answers = new List<string>{ "Roosevelt","Wilson","Truman","Hoover"}
},
// =====================
// 5. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 5,
    Question = "Ki vezette az 1437-es erdélyi parasztfelkelést?",
    CorrectAnswer = "Budai Nagy Antal",
    Answers = new List<string>{ "Budai Nagy Antal","Dózsa György","Fráter György","Báthory István" }
},
new PersonQuestion
{
    TetelNumber = 5,
    Question = "Kik kötötték meg 1437-ben a kápolnai uniót Erdélyben?",
    CorrectAnswer = "a három rendi nemzet előkelői",
    Answers = new List<string>{ "a három rendi nemzet előkelői","a jobbágyok képviselői","a négy bevett vallás vezetői","a szultán megbízottai" }
},
new PersonQuestion
{
    TetelNumber = 5,
    Question = "Kinek a vezetésével jutunk el a tétel szerint a kápolnai uniótól a későbbi nagy parasztfelkelésig?",
    CorrectAnswer = "Dózsa György",
    Answers = new List<string>{ "Budai Nagy Antal","Dózsa György","János Zsigmond","Fráter György" }
},
new PersonQuestion
{
    TetelNumber = 5,
    Question = "Ki kapta a szultántól a Tiszától keletre fekvő országrészt vazallusként?",
    CorrectAnswer = "Szapolyai János Zsigmond",
    Answers = new List<string>{ "Szapolyai János Zsigmond","Fráter György","Báthory István","I. Miksa" }
},
new PersonQuestion
{
    TetelNumber = 5,
    Question = "Ki kezdte meg az új keleti királyság igazgatásának megszervezését 1541 után?",
    CorrectAnswer = "Fráter György",
    Answers = new List<string>{ "Fráter György","János Zsigmond","Báthory Zsigmond","I. Miksa" }
},
new PersonQuestion
{
    TetelNumber = 5,
    Question = "Kivel kötötte meg János Zsigmond az 1570-es speyeri szerződést?",
    CorrectAnswer = "Habsburg I. Miksával",
    Answers = new List<string>{ "Habsburg I. Miksával","II. Rudolffal","Báthory Istvánnal","Fráter Györggyel" }
},
new PersonQuestion
{
    TetelNumber = 5,
    Question = "Ki használta elsőként a fejedelmi címet Erdélyben a tétel szerint?",
    CorrectAnswer = "Báthory István",
    Answers = new List<string>{ "János Zsigmond","Báthory István","Báthory Zsigmond","Fráter György" }
},
new PersonQuestion
{
    TetelNumber = 5,
    Question = "Ki érte el az 1594-es szövetségi szerződésben, hogy II. Rudolf Erdélyt önálló államnak ismerje el?",
    CorrectAnswer = "Báthory Zsigmond",
    Answers = new List<string>{ "Báthory István","Báthory Zsigmond","János Zsigmond","I. Miksa" }
},
new PersonQuestion
{
    TetelNumber = 5,
    Question = "Ki erősítette meg János Zsigmond királyi címét a szultáni oklevélben?",
    CorrectAnswer = "II. Szulejmán",
    Answers = new List<string>{ "II. Szulejmán","I. Miksa","II. Rudolf","Fráter György" }
},
new PersonQuestion
{
    TetelNumber = 5,
    Question = "Melyik előkelői csoport összefogását mondta ki a kápolnai unió?",
    CorrectAnswer = "magyar, székely és szász előkelők",
    Answers = new List<string>{ "magyar, székely és szász előkelők","magyar, román és szász jobbágyok","nemesek és parasztok","katolikusok és protestánsok" }
},
new PersonQuestion
{
    TetelNumber = 5,
    Question = "Kihez kötődik az a folyamat, amelyben Erdély 1541 után önálló állammá fejlődött?",
    CorrectAnswer = "János Zsigmondhoz",
    Answers = new List<string>{ "János Zsigmondhoz","Báthory Zsigmondhoz","II. Rudolfhoz","Mátyás királyhoz" }
},
new PersonQuestion
{
    TetelNumber = 5,
    Question = "Ki lett az a Habsburg uralkodó, akivel a speyeri szerződés rendezte Erdély státuszát?",
    CorrectAnswer = "I. Miksa",
    Answers = new List<string>{ "I. Miksa","II. Rudolf","III. Károly","II. József" }
},

// =====================
// 6. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 6,
    Question = "Ki iktatta törvénybe 1723-ban a Pragmatica Sanctiót?",
    CorrectAnswer = "III. Károly",
    Answers = new List<string>{ "III. Károly","Mária Terézia","II. József","II. Frigyes" }
},
new PersonQuestion
{
    TetelNumber = 6,
    Question = "Ki lépett trónra 1740-ben a Pragmatica Sanctio alapján?",
    CorrectAnswer = "Mária Terézia",
    Answers = new List<string>{ "Mária Terézia","II. József","II. Katalin","Mária Antónia" }
},
new PersonQuestion
{
    TetelNumber = 6,
    Question = "Kihez köthető a felvilágosult abszolutizmus legjellegzetesebb magyarországi képviselete az egyik uralkodóként?",
    CorrectAnswer = "Mária Terézia",
    Answers = new List<string>{ "Mária Terézia","I. Lipót","II. Rákóczi Ferenc","Ferenc József" }
},
new PersonQuestion
{
    TetelNumber = 6,
    Question = "Kihez köthető a felvilágosult abszolutizmus másik legjellegzetesebb magyarországi képviselője?",
    CorrectAnswer = "II. József",
    Answers = new List<string>{ "II. József","III. Károly","II. Rudolf","Báthory István" }
},
new PersonQuestion
{
    TetelNumber = 6,
    Question = "Ki rendelte el az 1784-es népszámlálást és birtokösszeírást?",
    CorrectAnswer = "II. József",
    Answers = new List<string>{ "Mária Terézia","II. József","III. Károly","II. Katalin" }
},
new PersonQuestion
{
    TetelNumber = 6,
    Question = "Kihez köthető a jobbágyrendelet, amely eltörölte a röghöz kötést?",
    CorrectAnswer = "II. József",
    Answers = new List<string>{ "II. József","Mária Terézia","III. Károly","Horea" }
},
new PersonQuestion
{
    TetelNumber = 6,
    Question = "Kik vezették az 1784-es erdélyi parasztfelkelést?",
    CorrectAnswer = "Horea és Kloska",
    Answers = new List<string>{ "Horea és Kloska","Dózsa György és Szapolyai","Budai Nagy Antal és Kloska","Martinovics és Kloska" }
},
new PersonQuestion
{
    TetelNumber = 6,
    Question = "Ki osztotta 10 kerületre az országot, élükön királyi biztosokkal?",
    CorrectAnswer = "II. József",
    Answers = new List<string>{ "II. József","Mária Terézia","III. Károly","Ferenc József" }
},
new PersonQuestion
{
    TetelNumber = 6,
    Question = "Ki támadta meg 1788-ban II. Katalinnal szövetségben Törökországot?",
    CorrectAnswer = "II. József",
    Answers = new List<string>{ "II. József","III. Károly","Mária Terézia","II. Frigyes" }
},
new PersonQuestion
{
    TetelNumber = 6,
    Question = "Ki volt II. József orosz szövetségese a török háborúban?",
    CorrectAnswer = "II. Katalin",
    Answers = new List<string>{ "II. Katalin","Mária Antoinette","Mária Terézia","I. Pál" }
},
new PersonQuestion
{
    TetelNumber = 6,
    Question = "Kihez kötődik a türelmi rendelet fenntartása II. József halálos ágyán visszavont rendeletei közül?",
    CorrectAnswer = "II. József",
    Answers = new List<string>{ "II. József","III. Károly","Mária Terézia","II. Frigyes" }
},
new PersonQuestion
{
    TetelNumber = 6,
    Question = "Kinek a politikája következtében nőtt az ország népessége a 18. században a tétel szerint?",
    CorrectAnswer = "Mária Terézia és II. József",
    Answers = new List<string>{ "Mária Terézia és II. József","III. Károly és II. Rákóczi","I. Lipót és II. Rudolf","Ferenc József és Deák Ferenc" }
},
new PersonQuestion
{
    TetelNumber = 6,
    Question = "Ki volt az a francia király, akitől II. József a francia forradalom miatt elvesztette szövetségesét?",
    CorrectAnswer = "XVI. Lajos",
    Answers = new List<string>{ "XVI. Lajos","XIV. Lajos","XVIII. Lajos","Napóleon" }
},
new PersonQuestion
{
    TetelNumber = 6,
    Question = "Kinek a felesége volt Mária Antoinette, II. József húga?",
    CorrectAnswer = "XVI. Lajos",
    Answers = new List<string>{ "XVI. Lajos","XV. Lajos","II. József","III. Károly" }
},
new PersonQuestion
{
    TetelNumber = 6,
    Question = "Kihez köthető a magyar rendek ellenállását kiváltó nyelvrendelet és a nemesi birtokok megadóztatásának terve?",
    CorrectAnswer = "II. József",
    Answers = new List<string>{ "II. József","Mária Terézia","III. Károly","Bocskai István" }
},

// =====================
// 7. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 7,
    Question = "Ki találta fel 1733-ban a repülő vetélőt?",
    CorrectAnswer = "John Kay",
    Answers = new List<string>{ "John Kay","Hargreaves","Arkwright","Cartwright" }
},
new PersonQuestion
{
    TetelNumber = 7,
    Question = "Kihez kötődik a fonó Jenny feltalálása?",
    CorrectAnswer = "Hargreaves",
    Answers = new List<string>{ "Hargreaves","Arkwright","Crompton","Roberts" }
},
new PersonQuestion
{
    TetelNumber = 7,
    Question = "Ki alkotta meg a vízikerék-meghajtású fonógépet?",
    CorrectAnswer = "Arkwright",
    Answers = new List<string>{ "Arkwright","Hargreaves","Cartwright","Watt" }
},
new PersonQuestion
{
    TetelNumber = 7,
    Question = "Kihez köthető a gőzhajtású fonógép a tétel szerint?",
    CorrectAnswer = "Crompton",
    Answers = new List<string>{ "Crompton","Arkwright","Hargreaves","Kay" }
},
new PersonQuestion
{
    TetelNumber = 7,
    Question = "Ki készítette el a mechanikus szövőgépet 1785-ben?",
    CorrectAnswer = "Cartwright",
    Answers = new List<string>{ "Cartwright","Jacquard","Kay","Roberts" }
},
new PersonQuestion
{
    TetelNumber = 7,
    Question = "Ki találta fel a pepita mintás szövést lehetővé tevő megoldást?",
    CorrectAnswer = "Jacquard",
    Answers = new List<string>{ "Jacquard","Cartwright","Hargreaves","Smith" }
},
new PersonQuestion
{
    TetelNumber = 7,
    Question = "Ki tökéletesítette a gőzgépet korszakváltó módon?",
    CorrectAnswer = "James Watt",
    Answers = new List<string>{ "James Watt","Thomas Savery","Thomas Newcomen","Adam Smith" }
},
new PersonQuestion
{
    TetelNumber = 7,
    Question = "Kik fejlesztették ki korábban a bányavíz kiszivattyúzására szolgáló gőzszivattyút?",
    CorrectAnswer = "Thomas Savery és Thomas Newcomen",
    Answers = new List<string>{ "Thomas Savery és Thomas Newcomen","James Watt és Stephenson","Hargreaves és Kay","Smith és Watt" }
},
new PersonQuestion
{
    TetelNumber = 7,
    Question = "Ki volt a modern közgazdaságtan alapítója a tétel szerint?",
    CorrectAnswer = "Adam Smith",
    Answers = new List<string>{ "Adam Smith","James Watt","Jean Monnet","David Ricardo" }
},
new PersonQuestion
{
    TetelNumber = 7,
    Question = "Ki hirdette a gazdaságban a 'láthatatlan kéz' szerepét?",
    CorrectAnswer = "Adam Smith",
    Answers = new List<string>{ "Adam Smith","John Kay","James Watt","Arkwright" }
},
new PersonQuestion
{
    TetelNumber = 7,
    Question = "Melyik intézmény fiókszervezetei hálózták be Angliát a tétel szerint, biztosítva a hitelt?",
    CorrectAnswer = "Angol Bank",
    Answers = new List<string>{ "Angol Bank","Bank of France","Hanza-szövetség","Kelet-indiai Társaság" }
},
new PersonQuestion
{
    TetelNumber = 7,
    Question = "Melyik országban indult meg az első ipari forradalom?",
    CorrectAnswer = "Anglia",
    Answers = new List<string>{ "Anglia","Franciaország","Németország","Hollandia" }
},
new PersonQuestion
{
    TetelNumber = 7,
    Question = "Melyik ágazat lett az első ipari forradalom húzóágazata?",
    CorrectAnswer = "textilipar",
    Answers = new List<string>{ "textilipar","bányászat","hajóépítés","mezőgazdaság" }
},
new PersonQuestion
{
    TetelNumber = 7,
    Question = "Melyik energiaforrás vált meghatározóvá az első ipari forradalom idején?",
    CorrectAnswer = "gőzenergia",
    Answers = new List<string>{ "gőzenergia","villamos energia","olaj","atomenergia" }
},
new PersonQuestion
{
    TetelNumber = 7,
    Question = "Melyik politikai folyamat hárította el a feudális akadályokat Angliában az ipari forradalom előtt?",
    CorrectAnswer = "angol polgári forradalom",
    Answers = new List<string>{ "angol polgári forradalom","francia forradalom","reformáció","restauráció" }
},
// =====================
// 8. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki állt az ország élén kormányzóként a Horthy-korszakban?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Bethlen István","Kádár János","Rákosi Mátyás" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki volt a Rákosi-rendszer névadó vezetője és a pártállami diktatúra fő alakja?",
    CorrectAnswer = "Rákosi Mátyás",
    Answers = new List<string>{ "Rákosi Mátyás","Kádár János","Gerő Ernő","Nagy Imre" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Kihez kötődik a személyi kultusz kiépítése Magyarországon a tétel szerint?",
    CorrectAnswer = "Rákosi Mátyás",
    Answers = new List<string>{ "Rákosi Mátyás","Kádár János","Horthy Miklós","Bethlen István" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki volt az a szovjet vezető, akinek mintájára a Rákosi-rendszer kiépült?",
    CorrectAnswer = "Sztálin",
    Answers = new List<string>{ "Sztálin","Lenin","Trockij","Brezsnyev" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki vezette az ÁVH-t a tétel szerint?",
    CorrectAnswer = "Péter Gábor",
    Answers = new List<string>{ "Péter Gábor","Gerő Ernő","Révai József","Farkas Mihály" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Kit tartóztattak le, mert tiltakozott az iskolák államosítása ellen?",
    CorrectAnswer = "Mindszenty József",
    Answers = new List<string>{ "Mindszenty József","Rákosi Mátyás","Kádár János","Rajk László" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Kihez köthető az 1956 utáni korszak meghatározó vezetése Magyarországon?",
    CorrectAnswer = "Kádár János",
    Answers = new List<string>{ "Kádár János","Rákosi Mátyás","Horthy Miklós","Gerő Ernő" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki volt a '4-es fogat' legismertebb vezető alakja a tétel szerint?",
    CorrectAnswer = "Rákosi Mátyás",
    Answers = new List<string>{ "Rákosi Mátyás","Gerő Ernő","Révai József","Farkas Mihály" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki volt az a politikus, akinek a neve a korszak egészét jelöli 1956 és 1988 között?",
    CorrectAnswer = "Kádár János",
    Answers = new List<string>{ "Kádár János","Nagy Imre","Gerő Ernő","Rákosi Mátyás" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Kihez kötődik a Magyar Dolgozók Pártjának tényleges irányítása a legsötétebb diktatúra időszakában?",
    CorrectAnswer = "Rákosi Mátyás",
    Answers = new List<string>{ "Rákosi Mátyás","Kádár János","Péter Gábor","Horthy Miklós" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki volt a Rákosi-rendszer egyik vezetője a '4-es fogat' tagjaként, propaganda- és ideológiai szereppel?",
    CorrectAnswer = "Révai József",
    Answers = new List<string>{ "Révai József","Péter Gábor","Rajk László","Kádár János" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki volt a '4-es fogat' tagja, aki katonai vonalon is fontos szerepet játszott?",
    CorrectAnswer = "Farkas Mihály",
    Answers = new List<string>{ "Farkas Mihály","Révai József","Péter Gábor","Mindszenty József" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki volt a '4-es fogat' tagja, aki a pártvezetés egyik kulcsfigurája volt Rákosi mellett?",
    CorrectAnswer = "Gerő Ernő",
    Answers = new List<string>{ "Gerő Ernő","Nagy Imre","Péter Gábor","Horthy Miklós" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Kihez köthető az 1956 utáni konszolidáció és a későbbi 'gulyáskommunizmus' korszaka?",
    CorrectAnswer = "Kádár János",
    Answers = new List<string>{ "Kádár János","Rákosi Mátyás","Gerő Ernő","Révai József" }
},

// =====================
// 9. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 9,
    Question = "Ki volt Magyarország kormányzója a két világháború között, amikor a revíziós politika megvalósult?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Bethlen István","Bárdossy László","Teleki Pál" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Ki nevezte ki Bárdossy Lászlót miniszterelnökké 1941-ben?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Bethlen István","Hitler","Teleki Pál" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Ki lett Magyarország miniszterelnöke, amikor az ország bekapcsolódott a Jugoszlávia elleni háborúba?",
    CorrectAnswer = "Bárdossy László",
    Answers = new List<string>{ "Bárdossy László","Bethlen István","Teleki Pál","Gömbös Gyula" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Kihez köthető a magyar revíziós politika német orientációja a második világháború előtt és alatt?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Kádár János","Rákosi Mátyás","Mindszenty József" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Ki volt az a csehszlovák politikus, aki fellépett a magyar kisebbség kitelepítésének igényével?",
    CorrectAnswer = "Edvard Beneš",
    Answers = new List<string>{ "Edvard Beneš","Masaryk","Dubček","Husák" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Kihez köthető közvetlenül az első bécsi döntés hátterét adó német támogatás?",
    CorrectAnswer = "Hitler",
    Answers = new List<string>{ "Hitler","Sztálin","Roosevelt","Churchill" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Kihez kötődik az a kormányzói rendszer, amely alatt 1938 és 1941 között több terület-visszacsatolás történt?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Ferenc József","Kádár János","Bárdossy László" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Ki volt a magyar államfő, amikor 1940-ben megszületett a második bécsi döntés?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Teleki Pál","Bárdossy László","Bethlen István" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Ki lett kormányfő 1941-ben, amikor Magyarország már egyértelműen a német oldalhoz kötődött?",
    CorrectAnswer = "Bárdossy László",
    Answers = new List<string>{ "Bárdossy László","Bethlen István","Teleki Pál","Kállay Miklós" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Kihez kapcsolódik a két világháború közötti magyar államfői szerep és a revíziós sikerek politikai kerete?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Beneš","Bárdossy László","Kádár János" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Ki képviselte a csehszlovák álláspontot a háború utáni magyar kisebbségellenes intézkedések idején?",
    CorrectAnswer = "Edvard Beneš",
    Answers = new List<string>{ "Edvard Beneš","Horthy Miklós","Bárdossy László","Mindszenty József" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Kinek a neve alatt vált Magyarország hadviselő féllé a németek oldalán 1941-ben a tétel szerint?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Rákosi Mátyás","Kádár János","Ferenc József" }
},

// =====================
// 10. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki volt a hét vezér közül a kiemelkedő fejedelmi személy a tétel szerint?",
    CorrectAnswer = "Álmos",
    Answers = new List<string>{ "Álmos","Árpád","Ond","Tas" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Kit neveztek Bíborbanszületett Konstantinosz leírásában 'nagyfejedelemnek' a magyarok közül?",
    CorrectAnswer = "Árpádot",
    Answers = new List<string>{ "Árpádot","Álmost","Gézát","Istvánt" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki írta meg a Gesta Hungarorum című művet?",
    CorrectAnswer = "Anonymus",
    Answers = new List<string>{ "Anonymus","Kézai Simon","Bíborbanszületett Konstantinosz","Sajnovics János" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki írt a vándorló magyarokról bizánci császárként a tétel szerint?",
    CorrectAnswer = "Bíborbanszületett Konstantinosz",
    Answers = new List<string>{ "Bíborbanszületett Konstantinosz","Anonymus","Kézai Simon","Pray György" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki értekezett 1770-ben a magyar és a lapp nyelv azonosságáról?",
    CorrectAnswer = "Sajnovics János",
    Answers = new List<string>{ "Sajnovics János","Pray György","Anonymus","Géza fejedelem" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki vallotta a hunok, avarok, magyarok és finnek rokonságát a tétel szerint?",
    CorrectAnswer = "Pray György",
    Answers = new List<string>{ "Pray György","Sajnovics János","Anonymus","Kézai Simon" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Kihez köthető a törzsfők és nemzetségfők hatalmának megtörése az államalapítás előtt?",
    CorrectAnswer = "Géza fejedelem",
    Answers = new List<string>{ "Géza fejedelem","Árpád","Koppány","II. András" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki építette tovább a nyugati keresztény államot Géza politikájára támaszkodva?",
    CorrectAnswer = "István",
    Answers = new List<string>{ "István","Koppány","Álmos","Könyves Kálmán" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki lépett fel Istvánnal szemben Géza halála után hatalmi igénnyel?",
    CorrectAnswer = "Koppány",
    Answers = new List<string>{ "Koppány","Ajtony","Aba Sámuel","Lehel" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Kihez köthető a keresztény királyság megszilárdítása a tétel szerint?",
    CorrectAnswer = "Szent István",
    Answers = new List<string>{ "Szent István","Géza","Koppány","Árpád" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki szilárdította meg az ország belső rendjét és külső helyzetét a 11. század végén?",
    CorrectAnswer = "I. László",
    Answers = new List<string>{ "I. László","Könyves Kálmán","II. András","IV. Béla" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Kihez köthető a feudális rend megszilárdítása I. László mellett a tételben?",
    CorrectAnswer = "Könyves Kálmán",
    Answers = new List<string>{ "Könyves Kálmán","I. László","Szent István","Géza" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki adta ki az Aranybullát a tétel szerint?",
    CorrectAnswer = "II. András",
    Answers = new List<string>{ "II. András","IV. Béla","Könyves Kálmán","I. László" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki próbálta visszaszerezni apja eladományozott birtokait, és ezért került szembe a nemességgel?",
    CorrectAnswer = "IV. Béla",
    Answers = new List<string>{ "IV. Béla","II. András","Aba Sámuel","I. László" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Kihez kötődik a tatárjárás utáni újjáépítés és várépítés politikája?",
    CorrectAnswer = "IV. Béla",
    Answers = new List<string>{ "IV. Béla","II. András","Könyves Kálmán","Géza fejedelem" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki volt Géza felesége, akinek személyén keresztül Géza keleti támogatást is szerzett?",
    CorrectAnswer = "Sarolt",
    Answers = new List<string>{ "Sarolt","Gizella","Ilona","Emese" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki lett István felesége a nyugati orientáció erősítésének részeként?",
    CorrectAnswer = "Gizella",
    Answers = new List<string>{ "Gizella","Sarolt","Ilona","Adelhaid" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki volt az a 11. századi uralkodó, akit 1083-ban szentté avattak?",
    CorrectAnswer = "István király",
    Answers = new List<string>{ "István király","Géza fejedelem","Koppány","Aba Sámuel" }
},
// =====================
// 8. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki állt az ország élén kormányzóként a Horthy-korszakban?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Bethlen István","Kádár János","Rákosi Mátyás" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki volt a Rákosi-rendszer névadó vezetője és a pártállami diktatúra fő alakja?",
    CorrectAnswer = "Rákosi Mátyás",
    Answers = new List<string>{ "Rákosi Mátyás","Kádár János","Gerő Ernő","Nagy Imre" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Kihez kötődik a személyi kultusz kiépítése Magyarországon a tétel szerint?",
    CorrectAnswer = "Rákosi Mátyás",
    Answers = new List<string>{ "Rákosi Mátyás","Kádár János","Horthy Miklós","Bethlen István" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki volt az a szovjet vezető, akinek mintájára a Rákosi-rendszer kiépült?",
    CorrectAnswer = "Sztálin",
    Answers = new List<string>{ "Sztálin","Lenin","Trockij","Brezsnyev" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki vezette az ÁVH-t a tétel szerint?",
    CorrectAnswer = "Péter Gábor",
    Answers = new List<string>{ "Péter Gábor","Gerő Ernő","Révai József","Farkas Mihály" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Kit tartóztattak le, mert tiltakozott az iskolák államosítása ellen?",
    CorrectAnswer = "Mindszenty József",
    Answers = new List<string>{ "Mindszenty József","Rákosi Mátyás","Kádár János","Rajk László" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Kihez köthető az 1956 utáni korszak meghatározó vezetése Magyarországon?",
    CorrectAnswer = "Kádár János",
    Answers = new List<string>{ "Kádár János","Rákosi Mátyás","Horthy Miklós","Gerő Ernő" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki volt a '4-es fogat' legismertebb vezető alakja a tétel szerint?",
    CorrectAnswer = "Rákosi Mátyás",
    Answers = new List<string>{ "Rákosi Mátyás","Gerő Ernő","Révai József","Farkas Mihály" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki volt az a politikus, akinek a neve a korszak egészét jelöli 1956 és 1988 között?",
    CorrectAnswer = "Kádár János",
    Answers = new List<string>{ "Kádár János","Nagy Imre","Gerő Ernő","Rákosi Mátyás" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Kihez kötődik a Magyar Dolgozók Pártjának tényleges irányítása a legsötétebb diktatúra időszakában?",
    CorrectAnswer = "Rákosi Mátyás",
    Answers = new List<string>{ "Rákosi Mátyás","Kádár János","Péter Gábor","Horthy Miklós" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki volt a Rákosi-rendszer egyik vezetője a '4-es fogat' tagjaként, propaganda- és ideológiai szereppel?",
    CorrectAnswer = "Révai József",
    Answers = new List<string>{ "Révai József","Péter Gábor","Rajk László","Kádár János" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki volt a '4-es fogat' tagja, aki katonai vonalon is fontos szerepet játszott?",
    CorrectAnswer = "Farkas Mihály",
    Answers = new List<string>{ "Farkas Mihály","Révai József","Péter Gábor","Mindszenty József" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Ki volt a '4-es fogat' tagja, aki a pártvezetés egyik kulcsfigurája volt Rákosi mellett?",
    CorrectAnswer = "Gerő Ernő",
    Answers = new List<string>{ "Gerő Ernő","Nagy Imre","Péter Gábor","Horthy Miklós" }
},
new PersonQuestion
{
    TetelNumber = 8,
    Question = "Kihez köthető az 1956 utáni konszolidáció és a későbbi 'gulyáskommunizmus' korszaka?",
    CorrectAnswer = "Kádár János",
    Answers = new List<string>{ "Kádár János","Rákosi Mátyás","Gerő Ernő","Révai József" }
},

// =====================
// 9. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 9,
    Question = "Ki volt Magyarország kormányzója a két világháború között, amikor a revíziós politika megvalósult?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Bethlen István","Bárdossy László","Teleki Pál" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Ki nevezte ki Bárdossy Lászlót miniszterelnökké 1941-ben?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Bethlen István","Hitler","Teleki Pál" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Ki lett Magyarország miniszterelnöke, amikor az ország bekapcsolódott a Jugoszlávia elleni háborúba?",
    CorrectAnswer = "Bárdossy László",
    Answers = new List<string>{ "Bárdossy László","Bethlen István","Teleki Pál","Gömbös Gyula" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Kihez köthető a magyar revíziós politika német orientációja a második világháború előtt és alatt?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Kádár János","Rákosi Mátyás","Mindszenty József" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Ki volt az a csehszlovák politikus, aki fellépett a magyar kisebbség kitelepítésének igényével?",
    CorrectAnswer = "Edvard Beneš",
    Answers = new List<string>{ "Edvard Beneš","Masaryk","Dubček","Husák" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Kihez köthető közvetlenül az első bécsi döntés hátterét adó német támogatás?",
    CorrectAnswer = "Hitler",
    Answers = new List<string>{ "Hitler","Sztálin","Roosevelt","Churchill" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Kihez kötődik az a kormányzói rendszer, amely alatt 1938 és 1941 között több terület-visszacsatolás történt?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Ferenc József","Kádár János","Bárdossy László" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Ki volt a magyar államfő, amikor 1940-ben megszületett a második bécsi döntés?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Teleki Pál","Bárdossy László","Bethlen István" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Ki lett kormányfő 1941-ben, amikor Magyarország már egyértelműen a német oldalhoz kötődött?",
    CorrectAnswer = "Bárdossy László",
    Answers = new List<string>{ "Bárdossy László","Bethlen István","Teleki Pál","Kállay Miklós" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Kihez kapcsolódik a két világháború közötti magyar államfői szerep és a revíziós sikerek politikai kerete?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Beneš","Bárdossy László","Kádár János" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Ki képviselte a csehszlovák álláspontot a háború utáni magyar kisebbségellenes intézkedések idején?",
    CorrectAnswer = "Edvard Beneš",
    Answers = new List<string>{ "Edvard Beneš","Horthy Miklós","Bárdossy László","Mindszenty József" }
},
new PersonQuestion
{
    TetelNumber = 9,
    Question = "Kinek a neve alatt vált Magyarország hadviselő féllé a németek oldalán 1941-ben a tétel szerint?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Rákosi Mátyás","Kádár János","Ferenc József" }
},

// =====================
// 10. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki volt a hét vezér közül a kiemelkedő fejedelmi személy a tétel szerint?",
    CorrectAnswer = "Álmos",
    Answers = new List<string>{ "Álmos","Árpád","Ond","Tas" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Kit neveztek Bíborbanszületett Konstantinosz leírásában 'nagyfejedelemnek' a magyarok közül?",
    CorrectAnswer = "Árpádot",
    Answers = new List<string>{ "Árpádot","Álmost","Gézát","Istvánt" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki írta meg a Gesta Hungarorum című művet?",
    CorrectAnswer = "Anonymus",
    Answers = new List<string>{ "Anonymus","Kézai Simon","Bíborbanszületett Konstantinosz","Sajnovics János" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki írt a vándorló magyarokról bizánci császárként a tétel szerint?",
    CorrectAnswer = "Bíborbanszületett Konstantinosz",
    Answers = new List<string>{ "Bíborbanszületett Konstantinosz","Anonymus","Kézai Simon","Pray György" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki értekezett 1770-ben a magyar és a lapp nyelv azonosságáról?",
    CorrectAnswer = "Sajnovics János",
    Answers = new List<string>{ "Sajnovics János","Pray György","Anonymus","Géza fejedelem" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki vallotta a hunok, avarok, magyarok és finnek rokonságát a tétel szerint?",
    CorrectAnswer = "Pray György",
    Answers = new List<string>{ "Pray György","Sajnovics János","Anonymus","Kézai Simon" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Kihez köthető a törzsfők és nemzetségfők hatalmának megtörése az államalapítás előtt?",
    CorrectAnswer = "Géza fejedelem",
    Answers = new List<string>{ "Géza fejedelem","Árpád","Koppány","II. András" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki építette tovább a nyugati keresztény államot Géza politikájára támaszkodva?",
    CorrectAnswer = "István",
    Answers = new List<string>{ "István","Koppány","Álmos","Könyves Kálmán" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki lépett fel Istvánnal szemben Géza halála után hatalmi igénnyel?",
    CorrectAnswer = "Koppány",
    Answers = new List<string>{ "Koppány","Ajtony","Aba Sámuel","Lehel" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Kihez köthető a keresztény királyság megszilárdítása a tétel szerint?",
    CorrectAnswer = "Szent István",
    Answers = new List<string>{ "Szent István","Géza","Koppány","Árpád" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki szilárdította meg az ország belső rendjét és külső helyzetét a 11. század végén?",
    CorrectAnswer = "I. László",
    Answers = new List<string>{ "I. László","Könyves Kálmán","II. András","IV. Béla" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Kihez köthető a feudális rend megszilárdítása I. László mellett a tételben?",
    CorrectAnswer = "Könyves Kálmán",
    Answers = new List<string>{ "Könyves Kálmán","I. László","Szent István","Géza" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki adta ki az Aranybullát a tétel szerint?",
    CorrectAnswer = "II. András",
    Answers = new List<string>{ "II. András","IV. Béla","Könyves Kálmán","I. László" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki próbálta visszaszerezni apja eladományozott birtokait, és ezért került szembe a nemességgel?",
    CorrectAnswer = "IV. Béla",
    Answers = new List<string>{ "IV. Béla","II. András","Aba Sámuel","I. László" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Kihez kötődik a tatárjárás utáni újjáépítés és várépítés politikája?",
    CorrectAnswer = "IV. Béla",
    Answers = new List<string>{ "IV. Béla","II. András","Könyves Kálmán","Géza fejedelem" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki volt Géza felesége, akinek személyén keresztül Géza keleti támogatást is szerzett?",
    CorrectAnswer = "Sarolt",
    Answers = new List<string>{ "Sarolt","Gizella","Ilona","Emese" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki lett István felesége a nyugati orientáció erősítésének részeként?",
    CorrectAnswer = "Gizella",
    Answers = new List<string>{ "Gizella","Sarolt","Ilona","Adelhaid" }
},
new PersonQuestion
{
    TetelNumber = 10,
    Question = "Ki volt az a 11. századi uralkodó, akit 1083-ban szentté avattak?",
    CorrectAnswer = "István király",
    Answers = new List<string>{ "István király","Géza fejedelem","Koppány","Aba Sámuel" }
},

new PersonQuestion
{
    TetelNumber = 2,
    Question = "Melyik uralkodó erősítette meg leginkább a királyi hatalmat a 15. században?",
    CorrectAnswer = "Hunyadi Mátyás",
    Answers = new List<string>{ "Nagy Lajos","Zsigmond","Hunyadi Mátyás","II. András"}
},
// =====================
// 11. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 11,
    Question = "Ki szervezte meg a vármegyerendszert és törte meg a törzsi államokat a tétel szerint?",
    CorrectAnswer = "I. István",
    Answers = new List<string>{ "I. István","I. László","Könyves Kálmán","II. András" }
},
new PersonQuestion
{
    TetelNumber = 11,
    Question = "Ki állt az Árpád-kori társadalom élén, akinek földbirtokai határozták meg hatalmát?",
    CorrectAnswer = "a király",
    Answers = new List<string>{ "a király","a nádor","az érsek","a comesek" }
},
new PersonQuestion
{
    TetelNumber = 11,
    Question = "Kihez köthető a teokratikus királyság megszilárdítása az államalapítás után?",
    CorrectAnswer = "I. István",
    Answers = new List<string>{ "I. István","Koppány","Aba Sámuel","II. András" }
},
new PersonQuestion
{
    TetelNumber = 11,
    Question = "Ki szilárdította meg az ország belső rendjét és külső helyzetét a 11. század végén?",
    CorrectAnswer = "I. László",
    Answers = new List<string>{ "I. László","Könyves Kálmán","II. András","IV. Béla" }
},
new PersonQuestion
{
    TetelNumber = 11,
    Question = "Kihez kötődik I. László mellett a feudális rend megszilárdítása?",
    CorrectAnswer = "Könyves Kálmán",
    Answers = new List<string>{ "Könyves Kálmán","I. László","I. István","II. András" }
},
new PersonQuestion
{
    TetelNumber = 11,
    Question = "Ki adta ki az Aranybullát?",
    CorrectAnswer = "II. András",
    Answers = new List<string>{ "II. András","IV. Béla","Könyves Kálmán","I. László" }
},
new PersonQuestion
{
    TetelNumber = 11,
    Question = "Ki erősítette meg az Aranybullát 1351-ben, és vezette be a kilencedet és az ősiséget?",
    CorrectAnswer = "Nagy Lajos",
    Answers = new List<string>{ "Nagy Lajos","Károly Róbert","Luxemburgi Zsigmond","Mátyás" }
},
new PersonQuestion
{
    TetelNumber = 11,
    Question = "Ki kereste a köznemesek szövetségét a bárókkal szemben a 1351-es törvényekkel?",
    CorrectAnswer = "Nagy Lajos",
    Answers = new List<string>{ "Nagy Lajos","Károly Róbert","Zsigmond","II. Ulászló" }
},
new PersonQuestion
{
    TetelNumber = 11,
    Question = "Ki pártolta kiemelkedően a városok fejlődését és hívta meg képviselőiket az 1435-ös országgyűlésre?",
    CorrectAnswer = "Luxemburgi Zsigmond",
    Answers = new List<string>{ "Luxemburgi Zsigmond","Károly Róbert","Nagy Lajos","Mátyás" }
},
new PersonQuestion
{
    TetelNumber = 11,
    Question = "Kihez köthető a súly- és mértékrendszer egységesítésének támogatása?",
    CorrectAnswer = "Luxemburgi Zsigmond",
    Answers = new List<string>{ "Luxemburgi Zsigmond","II. András","Nagy Lajos","IV. Béla" }
},
new PersonQuestion
{
    TetelNumber = 11,
    Question = "Ki kérte 3 évre visszamenőleg pénzben a tizedet, ami hozzájárult az 1437-es erdélyi felkeléshez?",
    CorrectAnswer = "Lépes György",
    Answers = new List<string>{ "Lépes György","Budai Nagy Antal","Zsigmond","Vitéz János" }
},
new PersonQuestion
{
    TetelNumber = 11,
    Question = "Ki vezette be a füstpénzt és alakította át a királyi jövedelmek szerkezetét?",
    CorrectAnswer = "Hunyadi Mátyás",
    Answers = new List<string>{ "Hunyadi Mátyás","Károly Róbert","Nagy Lajos","Zsigmond" }
},
new PersonQuestion
{
    TetelNumber = 11,
    Question = "Ki nevezte át a harmincadvámot koronavámmá és szüntette meg a korábbi mentességeket?",
    CorrectAnswer = "Hunyadi Mátyás",
    Answers = new List<string>{ "Hunyadi Mátyás","II. András","Károly Róbert","II. Ulászló" }
},
new PersonQuestion
{
    TetelNumber = 11,
    Question = "Kinek szabtak feltételeket a rendek a XV. század végén, hogy ne szedje be a rendkívüli hadiadót?",
    CorrectAnswer = "II. Ulászló",
    Answers = new List<string>{ "II. Ulászló","Mátyás","Zsigmond","Nagy Lajos" }
},
new PersonQuestion
{
    TetelNumber = 11,
    Question = "Kinek az uralkodása alatt erősödött meg a központosított királyi állam a tétel szerint?",
    CorrectAnswer = "Hunyadi Mátyás",
    Answers = new List<string>{ "Hunyadi Mátyás","II. Ulászló","Zsigmond","II. András" }
},

// =====================
// 12. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 12,
    Question = "Kihez köthető az aacheni udvar, amely a korai középkor művelődési központja volt?",
    CorrectAnswer = "Nagy Károly",
    Answers = new List<string>{ "Nagy Károly","Alkuin","Gutenberg","Luxemburgi Zsigmond" }
},
new PersonQuestion
{
    TetelNumber = 12,
    Question = "Kinek az iskolája tette Aachen városát a művelődés központjává?",
    CorrectAnswer = "Alkuin",
    Answers = new List<string>{ "Alkuin","Aquinói Tamás","Abélard","Erasmus" }
},
new PersonQuestion
{
    TetelNumber = 12,
    Question = "Kik működtették a középkor elején a kolostori iskolákat?",
    CorrectAnswer = "szerzetesek",
    Answers = new List<string>{ "szerzetesek","lovagok","céhmesterek","nemesek" }
},
new PersonQuestion
{
    TetelNumber = 12,
    Question = "Melyik városban jött létre Európa legrégebbi egyeteme a tétel szerint?",
    CorrectAnswer = "Bologna",
    Answers = new List<string>{ "Bologna","Párizs","Oxford","Prága" }
},
new PersonQuestion
{
    TetelNumber = 12,
    Question = "Melyik egyetem működött Sorbonne néven?",
    CorrectAnswer = "a párizsi egyetem",
    Answers = new List<string>{ "a párizsi egyetem","a bolognai egyetem","az oxfordi egyetem","a pécsi egyetem" }
},
new PersonQuestion
{
    TetelNumber = 12,
    Question = "Ki alapította a pécsi egyetemet a tétel szerint?",
    CorrectAnswer = "Nagy Lajos",
    Answers = new List<string>{ "Nagy Lajos","Luxemburgi Zsigmond","Hunyadi Mátyás","II. András" }
},
new PersonQuestion
{
    TetelNumber = 12,
    Question = "Ki alapította az óbudai egyetemet a tétel szerint?",
    CorrectAnswer = "Luxemburgi Zsigmond",
    Answers = new List<string>{ "Luxemburgi Zsigmond","Nagy Lajos","Mátyás","Károly Róbert" }
},
new PersonQuestion
{
    TetelNumber = 12,
    Question = "Ki volt az egyetemek vezetője, akit a tanárok választottak?",
    CorrectAnswer = "a rektor",
    Answers = new List<string>{ "a rektor","a nádor","a püspök","a kancellár" }
},
new PersonQuestion
{
    TetelNumber = 12,
    Question = "Kik alkották az universitas közösségét a tétel szerint?",
    CorrectAnswer = "tanárok és diákok",
    Answers = new List<string>{ "tanárok és diákok","papok és királyok","nemesek és jobbágyok","mesterek és inasok" }
},
new PersonQuestion
{
    TetelNumber = 12,
    Question = "Kik voltak az egyetemek fő támaszai a helyi hatalommal szemben?",
    CorrectAnswer = "a pápaság és az uralkodók",
    Answers = new List<string>{ "a pápaság és az uralkodók","a céhek","a földesurak","a városi őrség" }
},
new PersonQuestion
{
    TetelNumber = 12,
    Question = "Kihez kötődik a 42 soros Biblia és a könyvnyomtatás forradalma?",
    CorrectAnswer = "Gutenberg",
    Answers = new List<string>{ "Gutenberg","Alkuin","Leonardo da Vinci","Jan Hus" }
},
new PersonQuestion
{
    TetelNumber = 12,
    Question = "Kikhez kötődik a lovagi kultúra a középkorban?",
    CorrectAnswer = "a lovagokhoz",
    Answers = new List<string>{ "a lovagokhoz","a szerzetesekhez","a jobbágyokhoz","a polgárokhoz" }
},
new PersonQuestion
{
    TetelNumber = 12,
    Question = "Melyik intézmény őrizte és közvetítette leginkább a keresztény műveltséget a középkorban?",
    CorrectAnswer = "az egyház",
    Answers = new List<string>{ "az egyház","a céhek","a hadsereg","a vármegyék" }
},
new PersonQuestion
{
    TetelNumber = 12,
    Question = "Kik voltak az oktatók és hallgatók többsége az egyetemeken a tétel szerint?",
    CorrectAnswer = "egyházi személyek",
    Answers = new List<string>{ "egyházi személyek","nemesek","kereskedők","iparosok" }
},
new PersonQuestion
{
    TetelNumber = 12,
    Question = "Kikhez kötődött elsőként a reneszánsz műveltség magyarországi udvari központja?",
    CorrectAnswer = "Mátyás király udvarához",
    Answers = new List<string>{ "Mátyás király udvarához","I. László udvarához","II. András udvarához","Bocskai udvarához" }
},

// =====================
// 13. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 13,
    Question = "Ki jelentette be igényét a magyar trónra a mohácsi vereség után 1526. október 25-én?",
    CorrectAnswer = "Habsburg Ferdinánd",
    Answers = new List<string>{ "Habsburg Ferdinánd","Szapolyai János","II. Lajos","Habsburg Mária" }
},
new PersonQuestion
{
    TetelNumber = 13,
    Question = "Ki körül szerveződtek a Habsburg-pártiak Pozsonyban?",
    CorrectAnswer = "Habsburg Mária királyné",
    Answers = new List<string>{ "Habsburg Mária királyné","Szapolyai János","Bocskai István","Bethlen Gábor" }
},
new PersonQuestion
{
    TetelNumber = 13,
    Question = "Ki körül szerveződtek a Szapolyai-pártiak?",
    CorrectAnswer = "Szapolyai János",
    Answers = new List<string>{ "Szapolyai János","Habsburg Ferdinánd","Habsburg Mária","II. Rudolf" }
},
new PersonQuestion
{
    TetelNumber = 13,
    Question = "Kinek a támogatása állt Ferdinánd mögött a kettős királyválasztás idején?",
    CorrectAnswer = "Habsburg V. Károly császár",
    Answers = new List<string>{ "Habsburg V. Károly császár","II. Rudolf","Bocskai István","Bethlen Gábor" }
},
new PersonQuestion
{
    TetelNumber = 13,
    Question = "Ki állította fel Magyarországon a helytartótanácsot, a magyar kancelláriát és a magyar kamarát?",
    CorrectAnswer = "Habsburg Ferdinánd",
    Answers = new List<string>{ "Habsburg Ferdinánd","Szapolyai János","II. Rudolf","Mária Terézia" }
},
new PersonQuestion
{
    TetelNumber = 13,
    Question = "Ki ellen indítottak felségsértési pert, ami fej- és jószágvesztéssel végződött?",
    CorrectAnswer = "Illésházy István",
    Answers = new List<string>{ "Illésházy István","Bocskai István","Nádasdy Ferenc","Wesselényi Ferenc" }
},
new PersonQuestion
{
    TetelNumber = 13,
    Question = "Ki vezette a rendi intézményrendszer és a protestáns vallásszabadság megsértése miatt kitört felkelést?",
    CorrectAnswer = "Bocskai István",
    Answers = new List<string>{ "Bocskai István","Bethlen Gábor","Thököly Imre","Rákóczi Ferenc" }
},
new PersonQuestion
{
    TetelNumber = 13,
    Question = "Kihez köthető a bécsi békével lezárt 1604–1606-os szabadságharc?",
    CorrectAnswer = "Bocskai István",
    Answers = new List<string>{ "Bocskai István","Bethlen Gábor","Szapolyai János","II. József" }
},
new PersonQuestion
{
    TetelNumber = 13,
    Question = "Ki volt a felvilágosult abszolutizmus legjellegzetesebb magyarországi női képviselője?",
    CorrectAnswer = "Mária Terézia",
    Answers = new List<string>{ "Mária Terézia","Habsburg Mária","Mária Antónia","II. Katalin" }
},
new PersonQuestion
{
    TetelNumber = 13,
    Question = "Ki volt a felvilágosult abszolutizmus másik legjellegzetesebb magyarországi képviselője?",
    CorrectAnswer = "II. József",
    Answers = new List<string>{ "II. József","III. Károly","I. Lipót","II. Rudolf" }
},
new PersonQuestion
{
    TetelNumber = 13,
    Question = "Ki volt az a porosz uralkodó, akit a tétel a felvilágosult abszolutizmus példájaként említ?",
    CorrectAnswer = "II. Frigyes",
    Answers = new List<string>{ "II. Frigyes","I. Frigyes József","III. Frigyes","Vilmos császár" }
},
new PersonQuestion
{
    TetelNumber = 13,
    Question = "Ki volt az az orosz uralkodónő, akit a tétel a felvilágosult abszolutizmus képviselőjeként említ?",
    CorrectAnswer = "II. Katalin",
    Answers = new List<string>{ "II. Katalin","I. Nagy Péter","Erzsébet cárnő","Anna Ivanovna" }
},
new PersonQuestion
{
    TetelNumber = 13,
    Question = "Ki volt az a pápa, akit a mostani katolikus megújulás egyik fő alakjaként nevez meg a tétel?",
    CorrectAnswer = "III. Pál",
    Answers = new List<string>{ "III. Pál","VII. Gergely","X. Leó","VIII. Orbán" }
},
new PersonQuestion
{
    TetelNumber = 13,
    Question = "Kikre támaszkodott a felvilágosult abszolutizmus a rendi országgyűlés helyett?",
    CorrectAnswer = "a bürokráciára és a hivatalnoki apparátusra",
    Answers = new List<string>{ "a bürokráciára és a hivatalnoki apparátusra","a céhekre","a jobbágyokra","a papságra" }
},
new PersonQuestion
{
    TetelNumber = 13,
    Question = "Kihez köthető az a politika, amely a protestánsokkal szemben erőszakos rekatolizációt támogatott?",
    CorrectAnswer = "a Habsburg uralkodókhoz",
    Answers = new List<string>{ "a Habsburg uralkodókhoz","a magyar rendekhez","a szász városokhoz","a hajdúkhoz" }
},
// =====================
// 14. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 14,
    Question = "Ki fogalmazta meg a felvilágosodás egyik jelmondatát így: 'Sapere aude'?",
    CorrectAnswer = "Immanuel Kant",
    Answers = new List<string>{ "Immanuel Kant","Voltaire","Montesquieu","Rousseau" }
},
new PersonQuestion
{
    TetelNumber = 14,
    Question = "Ki képviselte az empirizmust, vagyis hogy minden ismeretünk forrása a tapasztalat?",
    CorrectAnswer = "Bacon",
    Answers = new List<string>{ "Bacon","Descartes","Kant","Leibniz" }
},
new PersonQuestion
{
    TetelNumber = 14,
    Question = "Kihez kötődik a racionalizmus, vagyis a világ ész általi megismerésének hangsúlyozása?",
    CorrectAnswer = "Descartes",
    Answers = new List<string>{ "Descartes","Bacon","Voltaire","Quesnay" }
},
new PersonQuestion
{
    TetelNumber = 14,
    Question = "Ki alkotta meg a heliocentrikus világképet a tétel szerint?",
    CorrectAnswer = "Kopernikusz",
    Answers = new List<string>{ "Kopernikusz","Kepler","Galilei","Newton" }
},
new PersonQuestion
{
    TetelNumber = 14,
    Question = "Ki állapította meg a bolygómozgás alaptörvényeit?",
    CorrectAnswer = "Kepler",
    Answers = new List<string>{ "Kepler","Kopernikusz","Galilei","Leibniz" }
},
new PersonQuestion
{
    TetelNumber = 14,
    Question = "Kihez köthető a mechanika megalapozása és a távcsöves csillagászati megfigyelések?",
    CorrectAnswer = "Galilei",
    Answers = new List<string>{ "Galilei","Newton","Kopernikusz","Montesquieu" }
},
new PersonQuestion
{
    TetelNumber = 14,
    Question = "Ki fogalmazta meg a gravitáció törvényét a tétel szerint?",
    CorrectAnswer = "Newton",
    Answers = new List<string>{ "Newton","Kepler","Galilei","Descartes" }
},
new PersonQuestion
{
    TetelNumber = 14,
    Question = "Ki bírálta az egyházat antiklerikusan, és írta a Candide című művet?",
    CorrectAnswer = "Voltaire",
    Answers = new List<string>{ "Voltaire","Montesquieu","Rousseau","Kant" }
},
new PersonQuestion
{
    TetelNumber = 14,
    Question = "Ki írta a Perzsa levelek és A törvények szelleméről című műveket?",
    CorrectAnswer = "Montesquieu",
    Answers = new List<string>{ "Montesquieu","Voltaire","Rousseau","Bacon" }
},
new PersonQuestion
{
    TetelNumber = 14,
    Question = "Kihez kötődik a hatalmi ágak megosztásának elve?",
    CorrectAnswer = "Montesquieu",
    Answers = new List<string>{ "Montesquieu","Rousseau","Voltaire","Kant" }
},
new PersonQuestion
{
    TetelNumber = 14,
    Question = "Ki írta Az emberek közti egyenlőtlenség eredetéről című művet?",
    CorrectAnswer = "Jean-Jacques Rousseau",
    Answers = new List<string>{ "Jean-Jacques Rousseau","Voltaire","Montesquieu","Quesnay" }
},
new PersonQuestion
{
    TetelNumber = 14,
    Question = "Kihez kötődik a Társadalmi szerződés és a népszuverenitás elve?",
    CorrectAnswer = "Jean-Jacques Rousseau",
    Answers = new List<string>{ "Jean-Jacques Rousseau","Montesquieu","Voltaire","Descartes" }
},
new PersonQuestion
{
    TetelNumber = 14,
    Question = "Ki képviselte a fiziokratizmust a tételben szereplő közgazdasági gondolkodók közül?",
    CorrectAnswer = "Francois Quesnay",
    Answers = new List<string>{ "Francois Quesnay","Adam Smith","Voltaire","Kant" }
},
new PersonQuestion
{
    TetelNumber = 14,
    Question = "Kihez kötődik az a német felvilágosodásbeli nézet, hogy ez a világ a lehetséges világok legjobbika?",
    CorrectAnswer = "Leibniz",
    Answers = new List<string>{ "Leibniz","Kant","Voltaire","Newton" }
},
new PersonQuestion
{
    TetelNumber = 14,
    Question = "Ki cáfolta irodalmi formában Leibniz optimizmusát a Candide-ban?",
    CorrectAnswer = "Voltaire",
    Answers = new List<string>{ "Voltaire","Rousseau","Montesquieu","Descartes" }
},

// =====================
// 15. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 15,
    Question = "Ki volt az angol abszolutizmus egyik Stuart uralkodója, aki 1611-től nem hívta össze a parlamentet?",
    CorrectAnswer = "I. Jakab",
    Answers = new List<string>{ "I. Jakab","I. Károly","Cromwell","III. Vilmos" }
},
new PersonQuestion
{
    TetelNumber = 15,
    Question = "Ki kormányzott I. Jakab kegyenceként a tétel szerint?",
    CorrectAnswer = "Buckingham hercege",
    Answers = new List<string>{ "Buckingham hercege","Cromwell","Jefferson","Washington" }
},
new PersonQuestion
{
    TetelNumber = 15,
    Question = "Ki folytatta apja abszolutista politikáját 1625 után?",
    CorrectAnswer = "I. Károly",
    Answers = new List<string>{ "I. Károly","I. Jakab","II. Jakab","III. Vilmos" }
},
new PersonQuestion
{
    TetelNumber = 15,
    Question = "Kihez kötődik a Petition of Rights kikényszerítése az angol alkotmányfejlődésben?",
    CorrectAnswer = "a parlamenthez I. Károllyal szemben",
    Answers = new List<string>{ "a parlamenthez I. Károllyal szemben","Cromwellhez","Washingtonhoz","Jeffersonhoz" }
},
new PersonQuestion
{
    TetelNumber = 15,
    Question = "Kik voltak a puritán parlamentpártiak elnevezése szerint?",
    CorrectAnswer = "kerekfejűek",
    Answers = new List<string>{ "kerekfejűek","gavallérok","whigek","toryk" }
},
new PersonQuestion
{
    TetelNumber = 15,
    Question = "Kik voltak a királypártiak a polgárháborúban?",
    CorrectAnswer = "gavallérok",
    Answers = new List<string>{ "gavallérok","kerekfejűek","puritánok","függetlenségiek" }
},
new PersonQuestion
{
    TetelNumber = 15,
    Question = "Ki lett az angol forradalom katonai és politikai vezetője a király kivégzése után?",
    CorrectAnswer = "Oliver Cromwell",
    Answers = new List<string>{ "Oliver Cromwell","I. Károly","I. Jakab","George Washington" }
},
new PersonQuestion
{
    TetelNumber = 15,
    Question = "Kihez köthető a protektorátus időszaka Angliában?",
    CorrectAnswer = "Oliver Cromwell",
    Answers = new List<string>{ "Oliver Cromwell","III. Vilmos","II. Jakab","Buckingham hercege" }
},
new PersonQuestion
{
    TetelNumber = 15,
    Question = "Ki ellen vívták ki az angolok az alkotmányos monarchiát megerősítő dicsőséges forradalmat?",
    CorrectAnswer = "II. Jakab ellen",
    Answers = new List<string>{ "II. Jakab ellen","I. Jakab ellen","I. Károly ellen","Cromwell ellen" }
},
new PersonQuestion
{
    TetelNumber = 15,
    Question = "Kik kerültek trónra a dicsőséges forradalom után?",
    CorrectAnswer = "Orániai Vilmos és Mária",
    Answers = new List<string>{ "Orániai Vilmos és Mária","I. Károly és Henrietta","Cromwell és fia","Washington és Jefferson" }
},
new PersonQuestion
{
    TetelNumber = 15,
    Question = "Kihez kötődik az angol Bill of Rights elfogadása uralkodóként?",
    CorrectAnswer = "Orániai Vilmos",
    Answers = new List<string>{ "Orániai Vilmos","I. Jakab","I. Károly","Oliver Cromwell" }
},
new PersonQuestion
{
    TetelNumber = 15,
    Question = "Ki fogalmazta meg az amerikai Függetlenségi Nyilatkozat szövegét?",
    CorrectAnswer = "Thomas Jefferson",
    Answers = new List<string>{ "Thomas Jefferson","George Washington","Benjamin Franklin","Hamilton" }
},
new PersonQuestion
{
    TetelNumber = 15,
    Question = "Ki volt az amerikai függetlenségi háború hadvezére és később az USA első elnöke?",
    CorrectAnswer = "George Washington",
    Answers = new List<string>{ "George Washington","Thomas Jefferson","John Adams","Oliver Cromwell" }
},
new PersonQuestion
{
    TetelNumber = 15,
    Question = "Kihez köthető az amerikai alkotmányos rendszer gyakorlati működésének elindítása első elnökként?",
    CorrectAnswer = "George Washington",
    Answers = new List<string>{ "George Washington","Thomas Jefferson","Benjamin Franklin","John Locke" }
},
new PersonQuestion
{
    TetelNumber = 15,
    Question = "Kihez köthető a természetes jogok és társadalmi szerződés elmélete, amely hatott az amerikai alkotmányosságra?",
    CorrectAnswer = "John Locke",
    Answers = new List<string>{ "John Locke","Montesquieu","Rousseau","Voltaire" }
},

// =====================
// 16. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki írta a Hitel című művet, amely a reformkor kezdetét jelképezi?",
    CorrectAnswer = "Széchenyi István",
    Answers = new List<string>{ "Széchenyi István","Kossuth Lajos","Kölcsey Ferenc","Wesselényi Miklós" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki fogalmazta meg a reformkor jelszavát így: 'Haza és haladás'?",
    CorrectAnswer = "Kölcsey Ferenc",
    Answers = new List<string>{ "Kölcsey Ferenc","Széchenyi István","Kossuth Lajos","Deák Ferenc" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki állt elő 1848. március 3-án a felirati javaslattal?",
    CorrectAnswer = "Kossuth Lajos",
    Answers = new List<string>{ "Kossuth Lajos","Széchenyi István","Batthyány Lajos","Deák Ferenc" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Kik vezették a márciusi ifjakat 1848. március 15-én?",
    CorrectAnswer = "Petőfi Sándor, Vasvári Pál és Jókai Mór",
    Answers = new List<string>{ "Petőfi Sándor, Vasvári Pál és Jókai Mór","Kossuth, Batthyány és Deák","Széchenyi, Kölcsey és Wesselényi","Bem, Görgei és Klapka" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki lett az első független, felelős magyar kormány miniszterelnöke?",
    CorrectAnswer = "Batthyány Lajos",
    Answers = new List<string>{ "Batthyány Lajos","Kossuth Lajos","Deák Ferenc","Széchenyi István" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki lett a Batthyány-kormány pénzügyminisztere?",
    CorrectAnswer = "Kossuth Lajos",
    Answers = new List<string>{ "Kossuth Lajos","Deák Ferenc","Széchenyi István","Szemere Bertalan" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki lett a Batthyány-kormány belügyminisztere?",
    CorrectAnswer = "Szemere Bertalan",
    Answers = new List<string>{ "Szemere Bertalan","Kossuth Lajos","Klauzál Gábor","Eötvös József" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki lett a Batthyány-kormány honvédelmi minisztere?",
    CorrectAnswer = "Mészáros Lázár",
    Answers = new List<string>{ "Mészáros Lázár","Kossuth Lajos","Deák Ferenc","Batthyány Lajos" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki lett a közmunka- és közlekedésügyi miniszter 1848-ban?",
    CorrectAnswer = "Széchenyi István",
    Answers = new List<string>{ "Széchenyi István","Kossuth Lajos","Eötvös József","Klauzál Gábor" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki lett a vallás- és közoktatásügyi miniszter a Batthyány-kormányban?",
    CorrectAnswer = "Eötvös József",
    Answers = new List<string>{ "Eötvös József","Deák Ferenc","Szemere Bertalan","Mészáros Lázár" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki lett az igazságügy-miniszter 1848-ban?",
    CorrectAnswer = "Deák Ferenc",
    Answers = new List<string>{ "Deák Ferenc","Kossuth Lajos","Batthyány Lajos","Klauzál Gábor" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki lett a földművelés-, ipar- és kereskedelemügyi miniszter a Batthyány-kormányban?",
    CorrectAnswer = "Klauzál Gábor",
    Answers = new List<string>{ "Klauzál Gábor","Eötvös József","Szemere Bertalan","Kölcsey Ferenc" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki lett a király személye körüli miniszter 1848-ban?",
    CorrectAnswer = "Esterházy Pál",
    Answers = new List<string>{ "Esterházy Pál","Batthyány Lajos","Deák Ferenc","Mészáros Lázár" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki volt az OHB elnöke?",
    CorrectAnswer = "Kossuth Lajos",
    Answers = new List<string>{ "Kossuth Lajos","Batthyány Lajos","Görgei Artúr","Szemere Bertalan" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki lépte át 1848. szeptember 11-én a Drávát Magyarország ellen?",
    CorrectAnswer = "Jellasics",
    Answers = new List<string>{ "Jellasics","Windischgrätz","Haynau","Latour" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki lett Magyarország katonai biztosává kinevezve 1848 októberében?",
    CorrectAnswer = "Jellasics",
    Answers = new List<string>{ "Jellasics","Windischgrätz","Haynau","Görgei" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki adott parancsot a császári támadásra, de a második bécsi forradalomban felakasztották?",
    CorrectAnswer = "Latour",
    Answers = new List<string>{ "Latour","Jellasics","Windischgrätz","Ferenc József" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Kit nyilvánítottak császárrá és magyar királlyá 1848. december 2-án?",
    CorrectAnswer = "Ferenc József",
    Answers = new List<string>{ "Ferenc József","V. Ferdinánd","Jellasics","Haynau" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki indult meg hazánk ellen a téli hadjáratban 1848 végén?",
    CorrectAnswer = "Windischgrätz",
    Answers = new List<string>{ "Windischgrätz","Jellasics","Latour","Görgei" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki lett leváltva, mert nem Aradra ment, hanem Temesvár felé indult 1849 augusztusában?",
    CorrectAnswer = "Dembinski",
    Answers = new List<string>{ "Dembinski","Bem","Görgei","Klapka" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Kit neveztek ki Dembinski helyére a temesvári csata előtt?",
    CorrectAnswer = "Bem",
    Answers = new List<string>{ "Bem","Görgei","Klapka","Batthyány" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki kapott teljhatalmat Kossuth lemondása után 1849. augusztus 11-én?",
    CorrectAnswer = "Görgei Artúr",
    Answers = new List<string>{ "Görgei Artúr","Bem","Klapka","Dembinski" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki védte Komáromot mint az utolsó ellenálló erődöt?",
    CorrectAnswer = "Klapka",
    Answers = new List<string>{ "Klapka","Bem","Görgei","Damjanich" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Ki lett a megtorlás jelképes katonai alakja 1849-ben?",
    CorrectAnswer = "Haynau",
    Answers = new List<string>{ "Haynau","Jellasics","Latour","Windischgrätz" }
},
new PersonQuestion
{
    TetelNumber = 16,
    Question = "Kit végeztek ki Pesten 1849. október 6-án a megtorlás részeként?",
    CorrectAnswer = "Batthyány Lajost",
    Answers = new List<string>{ "Batthyány Lajost","Kossuth Lajost","Deák Ferencet","Klauzál Gábort" }
},// =====================
// 17. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 17,
    Question = "Kihez köthető az Amerikai Egyesült Államok alkotmányának elfogadása mint az alkotmányos állam egyik mintája?",
    CorrectAnswer = "az amerikai alapító atyákhoz",
    Answers = new List<string>{ "az amerikai alapító atyákhoz","Napóleonhoz","Metternichhez","Bismarckhoz" }
},
new PersonQuestion
{
    TetelNumber = 17,
    Question = "Kihez köthető a magyar polgári átalakulás és a jogegyenlőség 1848-as törvényi megalapozása?",
    CorrectAnswer = "az áprilisi törvényekhez kapcsolódó reformnemzedékhez",
    Answers = new List<string>{ "az áprilisi törvényekhez kapcsolódó reformnemzedékhez","a jakobinusokhoz","a Habsburg udvarhoz","a pápasághoz" }
},
new PersonQuestion
{
    TetelNumber = 17,
    Question = "Kihez köthető az olasz nemzetállami egység politikai megteremtése a tétel logikája szerint?",
    CorrectAnswer = "az olasz nemzeti mozgalom vezetőihez",
    Answers = new List<string>{ "az olasz nemzeti mozgalom vezetőihez","a francia királyokhoz","a porosz junkerekhez","a pápai államhoz" }
},
new PersonQuestion
{
    TetelNumber = 17,
    Question = "Kihez köthető a német nemzetállam 1871-es létrejötte politikai értelemben?",
    CorrectAnswer = "Bismarckhoz",
    Answers = new List<string>{ "Bismarckhoz","Metternichhez","Kossuthhoz","Cavourhoz" }
},
new PersonQuestion
{
    TetelNumber = 17,
    Question = "Kihez köthető a magyar jogegyenlőségi és polgári reformok 1848-as programja?",
    CorrectAnswer = "a reformkori ellenzékhez",
    Answers = new List<string>{ "a reformkori ellenzékhez","a rendi főpapsághoz","a császári udvarhoz","a jobbágysághoz" }
},
new PersonQuestion
{
    TetelNumber = 17,
    Question = "Kikhez köthető az USA-ban a hatalmi ágak szétválasztására épülő modern alkotmányos berendezkedés létrehozása?",
    CorrectAnswer = "az amerikai alapító atyákhoz",
    Answers = new List<string>{ "az amerikai alapító atyákhoz","a Stuartokhoz","a jakobinusokhoz","az angol királypártiakhoz" }
},
new PersonQuestion
{
    TetelNumber = 17,
    Question = "Kihez köthető a kiegyezés, amely a magyar alkotmányosság részleges helyreállítását hozta?",
    CorrectAnswer = "Deák Ferenchez",
    Answers = new List<string>{ "Deák Ferenchez","Bismarckhoz","Metternichhez","Ferenc Ferdinándhoz" }
},
new PersonQuestion
{
    TetelNumber = 17,
    Question = "Kihez köthető a polgári nemzetállam egyik mintájaként a francia forradalom jogegyenlőségi öröksége?",
    CorrectAnswer = "a francia forradalmárokhoz",
    Answers = new List<string>{ "a francia forradalmárokhoz","a középkori céhekhez","a pápasághoz","a keresztes hadvezérekhez" }
},

// =====================
// 18. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 18,
    Question = "Ki beszélt zürichi beszédében Európai Egyesült Államokról?",
    CorrectAnswer = "Winston Churchill",
    Answers = new List<string>{ "Winston Churchill","Robert Schuman","Charles de Gaulle","Konrad Adenauer" }
},
new PersonQuestion
{
    TetelNumber = 18,
    Question = "Ki terjesztette elő 1950. május 9-én az európai integrációt elindító tervet?",
    CorrectAnswer = "Robert Schuman",
    Answers = new List<string>{ "Robert Schuman","Jean Monnet","Churchill","Adenauer" }
},
new PersonQuestion
{
    TetelNumber = 18,
    Question = "Kihez köthető a Schuman-terv szellemi előkészítése?",
    CorrectAnswer = "Jean Monnet",
    Answers = new List<string>{ "Jean Monnet","Robert Schuman","Churchill","De Gaulle" }
},
new PersonQuestion
{
    TetelNumber = 18,
    Question = "Ki lett Nyugat-Németország első kancellárja, és vált az európai integráció egyik alapfigurájává?",
    CorrectAnswer = "Konrad Adenauer",
    Answers = new List<string>{ "Konrad Adenauer","Helmut Kohl","Willy Brandt","Churchill" }
},
new PersonQuestion
{
    TetelNumber = 18,
    Question = "Kihez kötődik Franciaország részéről a német–francia megbékélés politikája a korai integráció időszakában?",
    CorrectAnswer = "Robert Schuman",
    Answers = new List<string>{ "Robert Schuman","Napóleon","Metternich","Wilson" }
},
new PersonQuestion
{
    TetelNumber = 18,
    Question = "Melyik intézményi együttműködést indította el közvetlenül Robert Schuman?",
    CorrectAnswer = "az Európai Szén- és Acélközösséget",
    Answers = new List<string>{ "az Európai Szén- és Acélközösséget","a KGST-t","a Varsói Szerződést","a NATO-t" }
},
new PersonQuestion
{
    TetelNumber = 18,
    Question = "Kihez köthető az a brit politikai gondolat, hogy Európa jövője együttműködésben van, nem újabb háborúkban?",
    CorrectAnswer = "Winston Churchill",
    Answers = new List<string>{ "Winston Churchill","Adenauer","Schuman","Monnet" }
},
new PersonQuestion
{
    TetelNumber = 18,
    Question = "Kihez köthető Magyarország euroatlanti orientációja mint történelmi cél a rendszerváltás után?",
    CorrectAnswer = "a rendszerváltó politikai elithez",
    Answers = new List<string>{ "a rendszerváltó politikai elithez","a pártállami vezetéshez","a Habsburgokhoz","a jakobinusokhoz" }
},
new PersonQuestion
{
    TetelNumber = 18,
    Question = "Kihez köthető a korai európai integrációban a francia–német gazdasági együttműködés központi szerepe?",
    CorrectAnswer = "Schumanhoz és Monnet-hoz",
    Answers = new List<string>{ "Schumanhoz és Monnet-hoz","Churchillhez és Roosevelthez","Bismarckhoz és Cavourhoz","Leninhez és Sztálinhoz" }
},
new PersonQuestion
{
    TetelNumber = 18,
    Question = "Kikhez köthető az a politikai generáció, amely a második világháború után a békét integrációval akarta biztosítani?",
    CorrectAnswer = "Schumanhoz, Monnet-hoz, Adenauerhez és Churchillhez",
    Answers = new List<string>{ "Schumanhoz, Monnet-hoz, Adenauerhez és Churchillhez","Hitlerhez és Mussolinihez","Leninhez és Sztálinhoz","Metternichhez és Talleyrand-hoz" }
},

// =====================
// 19. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 19,
    Question = "Ki választja meg Magyarországon a miniszterelnököt?",
    CorrectAnswer = "az Országgyűlés",
    Answers = new List<string>{ "az Országgyűlés","a köztársasági elnök","az Alkotmánybíróság","a Kúria" }
},
new PersonQuestion
{
    TetelNumber = 19,
    Question = "Ki javasolja a miniszterelnök személyét a parlamentáris rendszerben?",
    CorrectAnswer = "a köztársasági elnök",
    Answers = new List<string>{ "a köztársasági elnök","az Alkotmánybíróság elnöke","a Kúria elnöke","az ombudsman" }
},
new PersonQuestion
{
    TetelNumber = 19,
    Question = "Ki őrködik az államszervezet demokratikus működése felett reprezentatív államfői szerepkörben?",
    CorrectAnswer = "a köztársasági elnök",
    Answers = new List<string>{ "a köztársasági elnök","a miniszterelnök","a Kúria elnöke","az Országgyűlés elnöke" }
},
new PersonQuestion
{
    TetelNumber = 19,
    Question = "Ki vizsgálja a jogszabályok Alaptörvénnyel való összhangját?",
    CorrectAnswer = "az Alkotmánybíróság",
    Answers = new List<string>{ "az Alkotmánybíróság","a Kúria","a köztársasági elnök","az ombudsman" }
},
new PersonQuestion
{
    TetelNumber = 19,
    Question = "Ki látja el az igazságszolgáltatás csúcsszervének szerepét Magyarországon?",
    CorrectAnswer = "a Kúria",
    Answers = new List<string>{ "a Kúria","az Alkotmánybíróság","az Országgyűlés","a köztársasági elnök" }
},
new PersonQuestion
{
    TetelNumber = 19,
    Question = "Kihez lehet fordulni alapjogi sérelem esetén ombudsmani jelleggel?",
    CorrectAnswer = "az alapvető jogok biztosához",
    Answers = new List<string>{ "az alapvető jogok biztosához","a miniszterelnökhöz","a köztársasági elnökhöz","az ügyészséghez" }
},
new PersonQuestion
{
    TetelNumber = 19,
    Question = "Ki képviseli a vádat a büntetőeljárásokban a magyar államszervezetben?",
    CorrectAnswer = "az ügyészség",
    Answers = new List<string>{ "az ügyészség","a Kúria","az Alkotmánybíróság","az ombudsman" }
},
new PersonQuestion
{
    TetelNumber = 19,
    Question = "Ki gyakorolja a törvényhozó hatalmat Magyarországon?",
    CorrectAnswer = "az Országgyűlés",
    Answers = new List<string>{ "az Országgyűlés","a Kormány","az Alkotmánybíróság","a köztársasági elnök" }
},
new PersonQuestion
{
    TetelNumber = 19,
    Question = "Kihez köthető a konstruktív bizalmatlansági indítvány intézménye mint parlamenti felelősségi forma?",
    CorrectAnswer = "az Országgyűléshez",
    Answers = new List<string>{ "az Országgyűléshez","a köztársasági elnökhöz","az Alkotmánybírósághoz","a Kúriához" }
},
new PersonQuestion
{
    TetelNumber = 19,
    Question = "Ki tűzi ki az országgyűlési választások konkrét időpontját?",
    CorrectAnswer = "a köztársasági elnök",
    Answers = new List<string>{ "a köztársasági elnök","a miniszterelnök","az Országgyűlés elnöke","az Alkotmánybíróság" }
},
new PersonQuestion
{
    TetelNumber = 19,
    Question = "Ki végzi a jegybanki feladatokat Magyarországon?",
    CorrectAnswer = "a Magyar Nemzeti Bank",
    Answers = new List<string>{ "a Magyar Nemzeti Bank","az Állami Számvevőszék","az Országgyűlés","a Kormány" }
},
new PersonQuestion
{
    TetelNumber = 19,
    Question = "Ki ellenőrzi részben az állam pénzügyeit és a közpénzek felhasználását a parlament oldaláról?",
    CorrectAnswer = "az Állami Számvevőszék",
    Answers = new List<string>{ "az Állami Számvevőszék","a Kúria","az ombudsman","a köztársasági elnök" }
},
new PersonQuestion
{
    TetelNumber = 19,
    Question = "Kihez köthető az alapjogok védelmének intézményes őrzése a mai magyar rendszerben?",
    CorrectAnswer = "az alapvető jogok biztosához",
    Answers = new List<string>{ "az alapvető jogok biztosához","a miniszterelnökhöz","a köztársasági elnökhöz","a Kúriához" }
},
new PersonQuestion
{
    TetelNumber = 19,
    Question = "Ki alakít kormányt a parlamenti többség birtokában?",
    CorrectAnswer = "a miniszterelnök",
    Answers = new List<string>{ "a miniszterelnök","a köztársasági elnök","az Alkotmánybíróság elnöke","a Kúria elnöke" }
},
new PersonQuestion
{
    TetelNumber = 19,
    Question = "Kihez köthető a törvények újratárgyalásra való visszaküldésének joga?",
    CorrectAnswer = "a köztársasági elnökhöz",
    Answers = new List<string>{ "a köztársasági elnökhöz","a miniszterelnökhöz","a Kúriához","az ombudsmanhoz" }
},

// =====================
// 20. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 20,
    Question = "Ki hajtotta végre Athénban a Kr. e. 594-es reformokat?",
    CorrectAnswer = "Szolón",
    Answers = new List<string>{ "Szolón","Kleiszthenész","Periklész","Drakón" }
},
new PersonQuestion
{
    TetelNumber = 20,
    Question = "Kihez köthető az athéni demokrácia alapjainak megteremtése a phülékre épülő reformmal?",
    CorrectAnswer = "Kleiszthenész",
    Answers = new List<string>{ "Kleiszthenész","Szolón","Periklész","Caesar" }
},
new PersonQuestion
{
    TetelNumber = 20,
    Question = "Kihez köthető az athéni demokrácia virágkora?",
    CorrectAnswer = "Periklész",
    Answers = new List<string>{ "Periklész","Szolón","Kleiszthenész","Drakón" }
},
new PersonQuestion
{
    TetelNumber = 20,
    Question = "Ki lett Rómában élethosszig dictator?",
    CorrectAnswer = "Caesar",
    Answers = new List<string>{ "Caesar","Pompeius","Octavianus","Antonius" }
},
new PersonQuestion
{
    TetelNumber = 20,
    Question = "Ki lépte át a Rubicont, ezzel polgárháborút indítva el?",
    CorrectAnswer = "Caesar",
    Answers = new List<string>{ "Caesar","Augustus","Pompeius","Cicero" }
},
new PersonQuestion
{
    TetelNumber = 20,
    Question = "Ki győzte le Antoniust és Kleopátrát Actiumnál?",
    CorrectAnswer = "Octavianus",
    Answers = new List<string>{ "Octavianus","Caesar","Brutus","Pompeius" }
},
new PersonQuestion
{
    TetelNumber = 20,
    Question = "Ki kapta meg az Augustus nevet és teremtette meg a principátust?",
    CorrectAnswer = "Octavianus",
    Answers = new List<string>{ "Octavianus","Caesar","Antonius","Traianus" }
},
new PersonQuestion
{
    TetelNumber = 20,
    Question = "Kihez köthető Athénban a népgyűlés szerepének megerősítése a demokrácia fejlődésében?",
    CorrectAnswer = "Kleiszthenész",
    Answers = new List<string>{ "Kleiszthenész","Szolón","Periklész","Drakón" }
},
new PersonQuestion
{
    TetelNumber = 20,
    Question = "Kihez köthető Athénban a heliaia és a négyszázak tanácsa mint korai reformintézmények?",
    CorrectAnswer = "Szolón",
    Answers = new List<string>{ "Szolón","Periklész","Kleiszthenész","Miltiadész" }
},
new PersonQuestion
{
    TetelNumber = 20,
    Question = "Kihez köthető a hivatalviselés díjazása Athénban, ami szélesítette a politikai részvételt?",
    CorrectAnswer = "Periklész",
    Answers = new List<string>{ "Periklész","Kleiszthenész","Szolón","Drakón" }
},
new PersonQuestion
{
    TetelNumber = 20,
    Question = "Ki volt Caesar legfőbb ellenfele a polgárháború kezdetén?",
    CorrectAnswer = "Pompeius",
    Answers = new List<string>{ "Pompeius","Antonius","Octavianus","Brutus" }
},
new PersonQuestion
{
    TetelNumber = 20,
    Question = "Kihez köthető a köztársasági formák látszólagos fenntartása mellett az egyeduralom kialakítása Rómában?",
    CorrectAnswer = "Augustus",
    Answers = new List<string>{ "Augustus","Caesar","Pompeius","Marius" }
},
new PersonQuestion
{
    TetelNumber = 20,
    Question = "Kihez kötjük a római köztársaság válságának lezárását és a császárkor kezdetét?",
    CorrectAnswer = "Augustushoz",
    Answers = new List<string>{ "Augustushoz","Pompeiushoz","Ciceróhoz","Brutushoz" }
},
new PersonQuestion
{
    TetelNumber = 20,
    Question = "Kihez köthető Athénban az adósrabszolgaság eltörlése?",
    CorrectAnswer = "Szolón",
    Answers = new List<string>{ "Szolón","Kleiszthenész","Periklész","Drakón" }
},
new PersonQuestion
{
    TetelNumber = 20,
    Question = "Kihez köthető Rómában a principatus mint új államberendezkedés tényleges létrehozása?",
    CorrectAnswer = "Augustus",
    Answers = new List<string>{ "Augustus","Caesar","Antonius","Pompeius" }
},
// =====================
// 21. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 21,
    Question = "Ki hirdette a megbocsátás és a szeretet parancsát a talió-elv helyett?",
    CorrectAnswer = "Jézus Krisztus",
    Answers = new List<string>{ "Jézus Krisztus","Pál apostol","Keresztelő Szent János","Luther Márton" }
},
new PersonQuestion
{
    TetelNumber = 21,
    Question = "Ki hirdette a Megváltó közeli eljövetelét a tétel szerint?",
    CorrectAnswer = "Keresztelő Szent János",
    Answers = new List<string>{ "Keresztelő Szent János","Péter apostol","Pál apostol","X. Leó pápa" }
},
new PersonQuestion
{
    TetelNumber = 21,
    Question = "Ki vezette a jeruzsálemi első kis keresztény közösséget?",
    CorrectAnswer = "Péter apostol",
    Answers = new List<string>{ "Péter apostol","Pál apostol","János evangélista","Keresztelő Szent János" }
},
new PersonQuestion
{
    TetelNumber = 21,
    Question = "Ki lett a kereszténység terjedésének kiemelkedő alakja, a 'pogányok apostola'?",
    CorrectAnswer = "Pál apostol",
    Answers = new List<string>{ "Pál apostol","Péter apostol","Luther Márton","Kálvin János" }
},
new PersonQuestion
{
    TetelNumber = 21,
    Question = "Ki viselte eredetileg a Saul nevet a tétel szerint?",
    CorrectAnswer = "Pál apostol",
    Answers = new List<string>{ "Pál apostol","Péter apostol","Jézus Krisztus","Servét Mihály" }
},
new PersonQuestion
{
    TetelNumber = 21,
    Question = "Ki tapasztalta meg a 'pálfordulást' a Damaszkusz felé vezető úton?",
    CorrectAnswer = "Pál apostol",
    Answers = new List<string>{ "Pál apostol","Péter apostol","Keresztelő Szent János","Münzer Tamás" }
},
new PersonQuestion
{
    TetelNumber = 21,
    Question = "Ki függesztette ki 1517. október 31-én kifogásait a wittenbergi vártemplomnál?",
    CorrectAnswer = "Luther Márton",
    Answers = new List<string>{ "Luther Márton","Kálvin János","X. Leó pápa","Servét Mihály" }
},
new PersonQuestion
{
    TetelNumber = 21,
    Question = "Kihez kötődik az a tanítás, hogy az ember egyedül hit által üdvözülhet?",
    CorrectAnswer = "Luther Márton",
    Answers = new List<string>{ "Luther Márton","Kálvin János","Pál apostol","Voltaire" }
},
new PersonQuestion
{
    TetelNumber = 21,
    Question = "Ki volt az a pápa, aki a búcsúcédulák bevételéből akarta fedezni a Szent Péter-székesegyház költségeit?",
    CorrectAnswer = "X. Leó pápa",
    Answers = new List<string>{ "X. Leó pápa","III. Pál pápa","VII. Gergely","II. Orbán" }
},
new PersonQuestion
{
    TetelNumber = 21,
    Question = "Kihez kötődik a svájci reformáció legismertebb rendszere és a predestináció tana?",
    CorrectAnswer = "Kálvin János",
    Answers = new List<string>{ "Kálvin János","Luther Márton","Münzer Tamás","Pál apostol" }
},
new PersonQuestion
{
    TetelNumber = 21,
    Question = "Kihez kötődik a genfi református irányzat megszervezése?",
    CorrectAnswer = "Kálvin János",
    Answers = new List<string>{ "Kálvin János","Luther Márton","Servét Mihály","X. Leó pápa" }
},
new PersonQuestion
{
    TetelNumber = 21,
    Question = "Ki volt a népi reformáció vezetője az 1520-as években?",
    CorrectAnswer = "Münzer Tamás",
    Answers = new List<string>{ "Münzer Tamás","Kálvin János","Luther Márton","Péter apostol" }
},
new PersonQuestion
{
    TetelNumber = 21,
    Question = "Ki vezette a frankföldi parasztfelkelést 1525-ben a tétel szerint?",
    CorrectAnswer = "Geyer Flórián",
    Answers = new List<string>{ "Geyer Flórián","Münzer Tamás","Luther Márton","Servét Mihály" }
},
new PersonQuestion
{
    TetelNumber = 21,
    Question = "Ki volt a szentháromságtagadók, azaz antitrinitáriusok vezetője?",
    CorrectAnswer = "Servét Mihály",
    Answers = new List<string>{ "Servét Mihály","Kálvin János","Luther Márton","Münzer Tamás" }
},
new PersonQuestion
{
    TetelNumber = 21,
    Question = "Ki ítélte máglyahalálra Servét Mihályt?",
    CorrectAnswer = "Kálvin János",
    Answers = new List<string>{ "Kálvin János","Luther Márton","III. Pál pápa","Péter apostol" }
},

// =====================
// 22. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 22,
    Question = "Ki alapította meg az iszlám vallást a tétel szerint?",
    CorrectAnswer = "Mohamed",
    Answers = new List<string>{ "Mohamed","Jézus","Mózes","Kálvin János" }
},
new PersonQuestion
{
    TetelNumber = 22,
    Question = "Ki volt az a mekkai kereskedő, aki látomásai után kezdett prédikálni?",
    CorrectAnswer = "Mohamed",
    Answers = new List<string>{ "Mohamed","Abu Bakr","Ali","Szaladin" }
},
new PersonQuestion
{
    TetelNumber = 22,
    Question = "Melyik törzshöz tartozott Mohamed a tétel szerint?",
    CorrectAnswer = "a Kurais törzshöz",
    Answers = new List<string>{ "a Kurais törzshöz","az Omajjádokhoz","az Abbászidákhoz","a beduin szövetséghez" }
},
new PersonQuestion
{
    TetelNumber = 22,
    Question = "Ki hirdette azt, hogy Allah az egyetlen isten?",
    CorrectAnswer = "Mohamed",
    Answers = new List<string>{ "Mohamed","Ali","Abu Bakr","Mózes" }
},
new PersonQuestion
{
    TetelNumber = 22,
    Question = "Kihez kötődik a hidzsra, vagyis a Medinába való kivonulás?",
    CorrectAnswer = "Mohamed",
    Answers = new List<string>{ "Mohamed","Ali","Abu Bakr","Szaladin" }
},
new PersonQuestion
{
    TetelNumber = 22,
    Question = "Ki tért vissza katonák élén Mekkába 630-ban a tétel szerint?",
    CorrectAnswer = "Mohamed",
    Answers = new List<string>{ "Mohamed","Ali","Abu Bakr","Oszmán" }
},
new PersonQuestion
{
    TetelNumber = 22,
    Question = "Kik voltak az Arab-félsziget tevés nomád lakói a tétel szerint?",
    CorrectAnswer = "beduinok",
    Answers = new List<string>{ "beduinok","pátriárkák","janicsárok","mamelukok" }
},
new PersonQuestion
{
    TetelNumber = 22,
    Question = "Melyik város lett az iszlám bölcsője a tétel szerint?",
    CorrectAnswer = "Mekka",
    Answers = new List<string>{ "Mekka","Medina","Bagdad","Damaszkusz" }
},
new PersonQuestion
{
    TetelNumber = 22,
    Question = "Melyik városba menekült Mohamed a tétel szerint?",
    CorrectAnswer = "Medinába",
    Answers = new List<string>{ "Medinába","Bagdadba","Jeruzsálembe","Kairóba" }
},
new PersonQuestion
{
    TetelNumber = 22,
    Question = "Kik jegyezték le Mohamed tanításait?",
    CorrectAnswer = "követői",
    Answers = new List<string>{ "követői","bizánci írnokok","római papok","keresztes lovagok" }
},
new PersonQuestion
{
    TetelNumber = 22,
    Question = "Kik támogatták kezdetben leginkább Mohamed tanításait a tétel szerint?",
    CorrectAnswer = "a szegények",
    Answers = new List<string>{ "a szegények","a törzsfők","a bizánciak","a perzsák" }
},
new PersonQuestion
{
    TetelNumber = 22,
    Question = "Kihez köthető az arab törzsi ellentéteken felülemelkedő vallási egység gondolata?",
    CorrectAnswer = "Mohamed",
    Answers = new List<string>{ "Mohamed","Ali","Abu Bakr","Szaladin" }
},

// =====================
// 23. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 23,
    Question = "Ki lett a jakobinus diktatúra vezéralakja a tétel szerint?",
    CorrectAnswer = "Robespierre",
    Answers = new List<string>{ "Robespierre","Danton","Marat","Napóleon" }
},
new PersonQuestion
{
    TetelNumber = 23,
    Question = "Kihez kötődik a jakobinus terror legszélsőségesebb időszaka?",
    CorrectAnswer = "Robespierre",
    Answers = new List<string>{ "Robespierre","XVI. Lajos","Napóleon","Lafayette" }
},
new PersonQuestion
{
    TetelNumber = 23,
    Question = "Ki lett a francia forradalom utáni egyik legnépszerűbb tábornok, majd első konzul?",
    CorrectAnswer = "Bonaparte Napóleon",
    Answers = new List<string>{ "Bonaparte Napóleon","Robespierre","Danton","Mirabeau" }
},
new PersonQuestion
{
    TetelNumber = 23,
    Question = "Ki hajtott végre államcsínyt 1799. november 9-én?",
    CorrectAnswer = "Bonaparte Napóleon",
    Answers = new List<string>{ "Bonaparte Napóleon","Robespierre","Marat","XVI. Lajos" }
},
new PersonQuestion
{
    TetelNumber = 23,
    Question = "Ki támadta meg Egyiptomot 1798-ban Anglia megtörésének céljával?",
    CorrectAnswer = "Bonaparte Napóleon",
    Answers = new List<string>{ "Bonaparte Napóleon","Robespierre","Danton","Nelson admirális" }
},
new PersonQuestion
{
    TetelNumber = 23,
    Question = "Ki semmisítette meg a francia hajókat, így Napóleon Egyiptomban rekedt?",
    CorrectAnswer = "Nelson admirális",
    Answers = new List<string>{ "Nelson admirális","Wellington","Robespierre","Marat" }
},
new PersonQuestion
{
    TetelNumber = 23,
    Question = "Kihez köthető a jakobinusok által bevezetett általános hadkötelezettség időszaka?",
    CorrectAnswer = "a jakobinus vezetéshez",
    Answers = new List<string>{ "a jakobinus vezetéshez","a girondistákhoz","a királypártiakhoz","a Bourbonokhoz" }
},
new PersonQuestion
{
    TetelNumber = 23,
    Question = "Kihez köthető a Direktórium katonai sikerei után a forradalom lezárása és konszolidációja?",
    CorrectAnswer = "Bonaparte Napóleon",
    Answers = new List<string>{ "Bonaparte Napóleon","Robespierre","XVI. Lajos","Mirabeau" }
},
new PersonQuestion
{
    TetelNumber = 23,
    Question = "Ki ellen fogtak össze a jakobinusok ellenfelei 1794 júliusában?",
    CorrectAnswer = "Robespierre ellen",
    Answers = new List<string>{ "Robespierre ellen","Napóleon ellen","XVI. Lajos ellen","Danton ellen" }
},
new PersonQuestion
{
    TetelNumber = 23,
    Question = "Ki lett Franciaország vezetője konzulként, majd császárként a tétel szerint?",
    CorrectAnswer = "Bonaparte Napóleon",
    Answers = new List<string>{ "Bonaparte Napóleon","Robespierre","Danton","Nelson admirális" }
},
new PersonQuestion
{
    TetelNumber = 23,
    Question = "Kihez kötődik az itáliai hadjárat és Campoformio sikere?",
    CorrectAnswer = "Bonaparte Napóleon",
    Answers = new List<string>{ "Bonaparte Napóleon","Robespierre","Marat","Lafayette" }
},
new PersonQuestion
{
    TetelNumber = 23,
    Question = "Ki volt az a francia forradalmi vezér, akinek neve leginkább összefonódott a terrorral?",
    CorrectAnswer = "Robespierre",
    Answers = new List<string>{ "Robespierre","Napóleon","Mirabeau","Necker" }
},

// =====================
// 24. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 24,
    Question = "Ki volt a 19. századi liberalizmus egyik angol képviselője a tétel szerint?",
    CorrectAnswer = "John Stuart Mill",
    Answers = new List<string>{ "John Stuart Mill","Edmund Burke","Metternich","Marx" }
},
new PersonQuestion
{
    TetelNumber = 24,
    Question = "Kihez köthető a tolerancia, az egyéni szabadság és a különböző életformák elfogadásának hangsúlyozása?",
    CorrectAnswer = "John Stuart Mill",
    Answers = new List<string>{ "John Stuart Mill","Edmund Burke","Metternich","Lenin" }
},
new PersonQuestion
{
    TetelNumber = 24,
    Question = "Ki volt a konzervativizmus egyik legfontosabb korai gondolkodója a tételben?",
    CorrectAnswer = "Edmund Burke",
    Answers = new List<string>{ "Edmund Burke","John Stuart Mill","Marx","Voltaire" }
},
new PersonQuestion
{
    TetelNumber = 24,
    Question = "Ki képviselte a változtatásokat ellenző ókonzervatív irányzatot?",
    CorrectAnswer = "Metternich",
    Answers = new List<string>{ "Metternich","Edmund Burke","John Stuart Mill","Rousseau" }
},
new PersonQuestion
{
    TetelNumber = 24,
    Question = "Kihez köthető a 'megőrizve megújítani' gondolat a tétel szerint?",
    CorrectAnswer = "Edmund Burke",
    Answers = new List<string>{ "Edmund Burke","Metternich","Mill","Napóleon" }
},
new PersonQuestion
{
    TetelNumber = 24,
    Question = "Kihez köthető az a felfogás, hogy a túl gyors reformok terrorhoz és forradalomhoz vezethetnek?",
    CorrectAnswer = "Edmund Burke",
    Answers = new List<string>{ "Edmund Burke","John Stuart Mill","Marx","Garibaldi" }
},
new PersonQuestion
{
    TetelNumber = 24,
    Question = "Kihez köthető a liberális felfogás szerint az egyén szabadságának elsődlegessége?",
    CorrectAnswer = "John Stuart Mill",
    Answers = new List<string>{ "John Stuart Mill","Metternich","Burke","Bismarck" }
},
new PersonQuestion
{
    TetelNumber = 24,
    Question = "Kihez kapcsolja a tétel a konzervativizmus ideológiai alapjának kidolgozását?",
    CorrectAnswer = "Edmund Burke",
    Answers = new List<string>{ "Edmund Burke","John Stuart Mill","Marx","Engels" }
},
new PersonQuestion
{
    TetelNumber = 24,
    Question = "Kihez köthető a hagyományokra, vallásra és államra épülő rend védelme a tételben?",
    CorrectAnswer = "Edmund Burke",
    Answers = new List<string>{ "Edmund Burke","John Stuart Mill","Rousseau","Voltaire" }
},
new PersonQuestion
{
    TetelNumber = 24,
    Question = "Kihez köthető az a szemlélet, hogy a szabadság korlátja a másik ember szabadsága?",
    CorrectAnswer = "John Stuart Mill",
    Answers = new List<string>{ "John Stuart Mill","Edmund Burke","Metternich","Marx" }
},
new PersonQuestion
{
    TetelNumber = 24,
    Question = "Kihez köthető a Szent Szövetséghez illeszkedő nagyhatalmi ókonzervatív politika?",
    CorrectAnswer = "Metternich",
    Answers = new List<string>{ "Metternich","Burke","Mill","Napóleon" }
},
new PersonQuestion
{
    TetelNumber = 24,
    Question = "Kikhez köthető a szocializmus kialakulása a 19. századi eszmei palettán általánosan?",
    CorrectAnswer = "a munkásmozgalom gondolkodóihoz",
    Answers = new List<string>{ "a munkásmozgalom gondolkodóihoz","a középkori szerzetesekhez","a lovagi rendekhez","a pápasághoz" }
},
// =====================
// 25. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 25,
    Question = "Ki lett a második felelős magyar kormány miniszterelnöke 1867-ben?",
    CorrectAnswer = "Andrássy Gyula",
    Answers = new List<string>{ "Andrássy Gyula","Tisza Kálmán","Wekerle Sándor","Deák Ferenc" }
},
new PersonQuestion
{
    TetelNumber = 25,
    Question = "Ki volt a dualista állam uralkodója, aki miniszterelnökké nevezte ki Tisza Kálmánt?",
    CorrectAnswer = "Ferenc József",
    Answers = new List<string>{ "Ferenc József","IV. Károly","Ferenc Ferdinánd","Horthy Miklós" }
},
new PersonQuestion
{
    TetelNumber = 25,
    Question = "Ki szervezte újjá a Határozati Pártot Balközép Párt néven?",
    CorrectAnswer = "Tisza Kálmán",
    Answers = new List<string>{ "Tisza Kálmán","Deák Ferenc","Andrássy Gyula","Kossuth Lajos" }
},
new PersonQuestion
{
    TetelNumber = 25,
    Question = "Kihez kötődik a 'bihari pontok' feladása és az 1875-ös politikai váltás?",
    CorrectAnswer = "Tisza Kálmán",
    Answers = new List<string>{ "Tisza Kálmán","Wekerle Sándor","Bánffy Dezső","Andrássy Gyula" }
},
new PersonQuestion
{
    TetelNumber = 25,
    Question = "Ki lett a Szabadelvű Párt korszakának meghatározó miniszterelnöke 1875 és 1890 között?",
    CorrectAnswer = "Tisza Kálmán",
    Answers = new List<string>{ "Tisza Kálmán","Andrássy Gyula","Wekerle Sándor","Tisza István" }
},
new PersonQuestion
{
    TetelNumber = 25,
    Question = "Melyik párt lett a dualizmus következő évtizedeinek kormánypártja Tisza váltása után?",
    CorrectAnswer = "Szabadelvű Párt",
    Answers = new List<string>{ "Szabadelvű Párt","Függetlenségi Párt","Balközép Párt","Nemzeti Munkapárt" }
},
new PersonQuestion
{
    TetelNumber = 25,
    Question = "Melyik pártot alapították meg azok, akik ragaszkodtak a perszonáluniós és kossuthi elvekhez?",
    CorrectAnswer = "Függetlenségi Párt",
    Answers = new List<string>{ "Függetlenségi Párt","Szabadelvű Párt","Balközép Párt","Deák-párt" }
},
new PersonQuestion
{
    TetelNumber = 25,
    Question = "Kihez köthető a dualizmus kori parlamentáris rendszer gyakorlati megszilárdítása hosszú miniszterelnökségével?",
    CorrectAnswer = "Tisza Kálmán",
    Answers = new List<string>{ "Tisza Kálmán","Deák Ferenc","Kossuth Lajos","Baross Gábor" }
},
new PersonQuestion
{
    TetelNumber = 25,
    Question = "Kihez köthetők az egyházpolitikai törvények mint miniszterelnökhöz?",
    CorrectAnswer = "Wekerle Sándor",
    Answers = new List<string>{ "Wekerle Sándor","Bánffy Dezső","Tisza Kálmán","Andrássy Gyula" }
},
new PersonQuestion
{
    TetelNumber = 25,
    Question = "Ki idején mondták ki a kötelező polgári házasságot és az állami anyakönyvezést?",
    CorrectAnswer = "Wekerle Sándor",
    Answers = new List<string>{ "Wekerle Sándor","Tisza Kálmán","Deák Ferenc","Kossuth Lajos" }
},
new PersonQuestion
{
    TetelNumber = 25,
    Question = "Ki utódjaként fogadták el a szabad vallásgyakorlást és az izraelita vallás egyenjogúsítását?",
    CorrectAnswer = "Bánffy Dezső",
    Answers = new List<string>{ "Bánffy Dezső","Wekerle Sándor","Tisza Kálmán","Andrássy Gyula" }
},
new PersonQuestion
{
    TetelNumber = 25,
    Question = "Kihez köthető az a politikai magatartás, amely kompromisszumot vállalt a kiegyezés fenntartásáért?",
    CorrectAnswer = "Deák Ferenc",
    Answers = new List<string>{ "Deák Ferenc","Kossuth Lajos","Tisza Kálmán","Bánffy Dezső" }
},
new PersonQuestion
{
    TetelNumber = 25,
    Question = "Kihez köthető a dualizmus kori parlamenti ellenzék kossuthi irányvonalának eszmei öröksége?",
    CorrectAnswer = "Kossuth Lajos",
    Answers = new List<string>{ "Kossuth Lajos","Deák Ferenc","Andrássy Gyula","Tisza Kálmán" }
},
new PersonQuestion
{
    TetelNumber = 25,
    Question = "Kihez köthető az a korszak, amelyet a kortársak 'generális' névvel is jellemeztek?",
    CorrectAnswer = "Tisza Kálmán",
    Answers = new List<string>{ "Tisza Kálmán","Tisza István","Ferenc József","Wekerle Sándor" }
},

// =====================
// 26. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 26,
    Question = "Ki hozta létre 1919-ben a Fasci di Combattimento nevű szervezetet?",
    CorrectAnswer = "Benito Mussolini",
    Answers = new List<string>{ "Benito Mussolini","Adolf Hitler","Lenin","Sztálin" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Kihez kötődik a 'marcia su Roma', vagyis a római menet?",
    CorrectAnswer = "Benito Mussolini",
    Answers = new List<string>{ "Benito Mussolini","Adolf Hitler","Gabriele d’Annunzio","III. Viktor Emmánuel" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Ki nevezte ki Mussolinit miniszterelnökké 1922-ben?",
    CorrectAnswer = "III. Viktor Emmánuel",
    Answers = new List<string>{ "III. Viktor Emmánuel","XIII. Leó pápa","Hindenburg","Sztálin" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Ki volt az a szocialista képviselő, akit a választási csalások elleni tiltakozása után meggyilkoltak?",
    CorrectAnswer = "Matteotti",
    Answers = new List<string>{ "Matteotti","D’Annunzio","Mussolini","Gramsci" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Kihez kötődik a Fasiszta Nagytanács létrehozása?",
    CorrectAnswer = "Benito Mussolini",
    Answers = new List<string>{ "Benito Mussolini","III. Viktor Emmánuel","Lenin","Hitler" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Ki próbálta 1919-ben Fiúme elfoglalásával átírni a békekonferencia döntéseit?",
    CorrectAnswer = "Gabriele d’Annunzio",
    Answers = new List<string>{ "Gabriele d’Annunzio","Mussolini","Hitler","Stresemann" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Kihez köthető a korporatív állam kiépítése Olaszországban?",
    CorrectAnswer = "Benito Mussolini",
    Answers = new List<string>{ "Benito Mussolini","Adolf Hitler","Lenin","Sztálin" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Ki volt a náci Németország vezére, a Führer?",
    CorrectAnswer = "Adolf Hitler",
    Answers = new List<string>{ "Adolf Hitler","Benito Mussolini","Sztálin","Hindenburg" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Melyik párt nevéhez kötődik a náci mozgalom Németországban?",
    CorrectAnswer = "NSDAP",
    Answers = new List<string>{ "NSDAP","Olasz Kommunista Párt","Szociálforradalmárok","Bolsevik Párt" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Ki volt a bolsevik irányzat vezetője az OSZDMP 1903-as szakadása után?",
    CorrectAnswer = "Lenin",
    Answers = new List<string>{ "Lenin","Sztálin","Trockij","Kamenyev" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Ki fogadta el Lenin tételét a szocializmus egy országban való felépítéséről?",
    CorrectAnswer = "Sztálin",
    Answers = new List<string>{ "Sztálin","Trockij","Mussolini","Hitler" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Ki bízott továbbra is a világforradalom bekövetkeztében Sztálinnal szemben?",
    CorrectAnswer = "Trockij",
    Answers = new List<string>{ "Trockij","Lenin","Kamenyev","Zinovjev" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Kikkel lépett kezdetben titkos szövetségre Sztálin a hatalmi harcban?",
    CorrectAnswer = "Kamenyevvel és Zinovjevvel",
    Answers = new List<string>{ "Kamenyevvel és Zinovjevvel","Mussolinivel és Hitlerrel","Trockijjal és Buharinnal","Jagodával és Berijával" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Kihez köthető a sztálini diktatúra kiépítése 1927 után?",
    CorrectAnswer = "Sztálin",
    Answers = new List<string>{ "Sztálin","Lenin","Trockij","Mussolini" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Ki volt az NKVD egyik első vezetője a tétel szerint?",
    CorrectAnswer = "Jagoda",
    Answers = new List<string>{ "Jagoda","Jezsov","Berija","Trockij" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Ki vezette az NKVD-t 1936 és 1938 között?",
    CorrectAnswer = "Jezsov",
    Answers = new List<string>{ "Jezsov","Jagoda","Berija","Kamenyev" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Ki lett az NKVD vezetője 1938-tól?",
    CorrectAnswer = "Berija",
    Answers = new List<string>{ "Berija","Jezsov","Jagoda","Molotov" }
},
new PersonQuestion
{
    TetelNumber = 26,
    Question = "Kihez kötődik a 'Duce' elnevezés?",
    CorrectAnswer = "Benito Mussolini",
    Answers = new List<string>{ "Benito Mussolini","Adolf Hitler","Sztálin","Lenin" }
},

// =====================
// 27. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 27,
    Question = "Ki alapította meg az Oszmán Birodalmat a tétel szerint?",
    CorrectAnswer = "I. Oszmán",
    Answers = new List<string>{ "I. Oszmán","I. Orhán","I. Murád","I. Mehmed" }
},
new PersonQuestion
{
    TetelNumber = 27,
    Question = "Ki terjesztette ki a birodalmat szinte egész Anatóliára, és hódított Gallipolinál Európában?",
    CorrectAnswer = "I. Orhán",
    Answers = new List<string>{ "I. Orhán","I. Oszmán","I. Murád","II. Mehmed" }
},
new PersonQuestion
{
    TetelNumber = 27,
    Question = "Ki foglalta el Drinápolyt, és győzött az első rigómezei csatában?",
    CorrectAnswer = "I. Murád",
    Answers = new List<string>{ "I. Murád","I. Oszmán","I. Orhán","II. Bajezid" }
},
new PersonQuestion
{
    TetelNumber = 27,
    Question = "Ki próbálta a telekkatonaság bevezetésével megerősíteni a magyar sereget?",
    CorrectAnswer = "Luxemburgi Zsigmond",
    Answers = new List<string>{ "Luxemburgi Zsigmond","Hunyadi János","Jagelló I. Ulászló","V. László" }
},
new PersonQuestion
{
    TetelNumber = 27,
    Question = "Kinek a trónra lépéséig tartott a török interregnum 1413-ig?",
    CorrectAnswer = "I. Mehmed",
    Answers = new List<string>{ "I. Mehmed","I. Murád","II. Mehmed","I. Szulejmán" }
},
new PersonQuestion
{
    TetelNumber = 27,
    Question = "Ki vált a XV. századi törökellenes küzdelmek legfontosabb magyar hadvezérévé?",
    CorrectAnswer = "Hunyadi János",
    Answers = new List<string>{ "Hunyadi János","Luxemburgi Zsigmond","Jagelló I. Ulászló","V. László" }
},
new PersonQuestion
{
    TetelNumber = 27,
    Question = "Kinek a pártjára állt Hunyadi a trónviszályok idején?",
    CorrectAnswer = "Jagelló I. Ulászló",
    Answers = new List<string>{ "Jagelló I. Ulászló","Habsburg V. László","Luxemburgi Zsigmond","II. Ulászló" }
},
new PersonQuestion
{
    TetelNumber = 27,
    Question = "Kivel szemben támogatta Hunyadi János Ulászlót?",
    CorrectAnswer = "Habsburg V. Lászlóval szemben",
    Answers = new List<string>{ "Habsburg V. Lászlóval szemben","I. Szulejmánnal szemben","II. Mehmeddel szemben","Bocskai Istvánnal szemben" }
},
new PersonQuestion
{
    TetelNumber = 27,
    Question = "Kihez köthető a 'legjobb védekezés a támadás' elve a törökellenes harcokban?",
    CorrectAnswer = "Hunyadi János",
    Answers = new List<string>{ "Hunyadi János","Zsigmond","I. Oszmán","V. László" }
},
new PersonQuestion
{
    TetelNumber = 27,
    Question = "Ki hívta harcba Erdélyben a környék lakosságát, és alkalmazta a huszita szekérvárat?",
    CorrectAnswer = "Hunyadi János",
    Answers = new List<string>{ "Hunyadi János","Luxemburgi Zsigmond","Kapisztrán János","I. Ulászló" }
},
new PersonQuestion
{
    TetelNumber = 27,
    Question = "Ki volt a magyar trónon Hunyadi fő hadjáratainak kezdetén 1440 és 1444 között?",
    CorrectAnswer = "Jagelló I. Ulászló",
    Answers = new List<string>{ "Jagelló I. Ulászló","Habsburg V. László","Luxemburgi Zsigmond","II. Ulászló" }
},
new PersonQuestion
{
    TetelNumber = 27,
    Question = "Kinek a halála után mélyültek el a magyar trónviszályok 1437-ben?",
    CorrectAnswer = "Luxemburgi Zsigmond",
    Answers = new List<string>{ "Luxemburgi Zsigmond","Hunyadi János","I. Oszmán","I. Mehmed" }
},
new PersonQuestion
{
    TetelNumber = 27,
    Question = "Kihez köthető a végvárrendszerre támaszkodó törökellenes védekezés irányítása a 1440-es években?",
    CorrectAnswer = "Hunyadi János",
    Answers = new List<string>{ "Hunyadi János","V. László","I. Ulászló","II. András" }
},
new PersonQuestion
{
    TetelNumber = 27,
    Question = "Ki volt az a magyar hadvezér, akit a korszakban a 'kereszténység védőbástyájának' egyik jelképeként emlegettek?",
    CorrectAnswer = "Hunyadi János",
    Answers = new List<string>{ "Hunyadi János","Luxemburgi Zsigmond","Kinizsi Pál","Bocskai István" }
},
new PersonQuestion
{
    TetelNumber = 27,
    Question = "Kihez köthető az Oszmán Birodalom európai terjeszkedésének kezdete Gallipolinál?",
    CorrectAnswer = "I. Orhán",
    Answers = new List<string>{ "I. Orhán","I. Murád","I. Oszmán","II. Mehmed" }
},// =====================
// 28. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 28,
    Question = "Kihez köthető a német külpolitika agresszív, világhatalmi fordulata a tétel szerint?",
    CorrectAnswer = "II. Vilmos",
    Answers = new List<string>{ "II. Vilmos","Bismarck","Ferenc Ferdinánd","Hindenburg" }
},
new PersonQuestion
{
    TetelNumber = 28,
    Question = "Ki hozta létre 1879-ben a kettős szövetséget Németország részéről?",
    CorrectAnswer = "Bismarck",
    Answers = new List<string>{ "Bismarck","II. Vilmos","Moltke","Hindenburg" }
},
new PersonQuestion
{
    TetelNumber = 28,
    Question = "Ki fogalmazta meg a német Schlieffen-tervet?",
    CorrectAnswer = "Schlieffen",
    Answers = new List<string>{ "Schlieffen","Bismarck","Hindenburg","Ludendorff" }
},
new PersonQuestion
{
    TetelNumber = 28,
    Question = "Kihez köthető a 'Drang nach Osten' külpolitikai irány a tételben?",
    CorrectAnswer = "II. Vilmos",
    Answers = new List<string>{ "II. Vilmos","Bismarck","Ferenc József","Churchill" }
},
new PersonQuestion
{
    TetelNumber = 28,
    Question = "Ki volt az a trónörökös, akinek meggyilkolása közvetlen háborús ürügyet adott?",
    CorrectAnswer = "Ferenc Ferdinánd",
    Answers = new List<string>{ "Ferenc Ferdinánd","Ferenc József","II. Vilmos","Miklós cár" }
},
new PersonQuestion
{
    TetelNumber = 28,
    Question = "Ki lőtte le Ferenc Ferdinándot Szarajevóban?",
    CorrectAnswer = "Gavrilo Princip",
    Answers = new List<string>{ "Gavrilo Princip","Radovan Karadzsics","Schlieffen","Moltke" }
},
new PersonQuestion
{
    TetelNumber = 28,
    Question = "Ki aratott győzelmet Tannenbergnél az oroszok felett 1914-ben?",
    CorrectAnswer = "Hindenburg",
    Answers = new List<string>{ "Hindenburg","Schlieffen","Foch","Joffre" }
},
new PersonQuestion
{
    TetelNumber = 28,
    Question = "Ki volt a brit haditengerészet vezetője, aki a tengeri fölény szimbólumává vált a korszakban a tétel szemlélete szerint?",
    CorrectAnswer = "az angol haditengerészeti vezetés",
    Answers = new List<string>{ "az angol haditengerészeti vezetés","Hindenburg","Joffre","Ludendorff" }
},
new PersonQuestion
{
    TetelNumber = 28,
    Question = "Kihez kötődik a Monarchia balkáni terjeszkedési törekvéseinek irányítása uralkodóként?",
    CorrectAnswer = "Ferenc József",
    Answers = new List<string>{ "Ferenc József","Ferenc Ferdinánd","Horthy Miklós","Bismarck" }
},
new PersonQuestion
{
    TetelNumber = 28,
    Question = "Kihez kötődött a brit külpolitika az európai egyensúly fenntartásának céljával?",
    CorrectAnswer = "az angol vezetéshez",
    Answers = new List<string>{ "az angol vezetéshez","a porosz junkerekhez","a Habsburg udvarhoz","az orosz cárhoz" }
},
new PersonQuestion
{
    TetelNumber = 28,
    Question = "Ki állt Németország élén, amikor hadat üzentek Oroszországnak és Franciaországnak 1914-ben?",
    CorrectAnswer = "II. Vilmos",
    Answers = new List<string>{ "II. Vilmos","Bismarck","Hitler","Ferenc Ferdinánd" }
},
new PersonQuestion
{
    TetelNumber = 28,
    Question = "Ki vezette a német hadsereget a keleti front jelentős győzelmeinél a tétel szerint?",
    CorrectAnswer = "Hindenburg",
    Answers = new List<string>{ "Hindenburg","Joffre","Foch","Moltke" }
},
new PersonQuestion
{
    TetelNumber = 28,
    Question = "Kik hozták létre a központi hatalmak stabil magját a tétel szerint?",
    CorrectAnswer = "Németország és az Osztrák–Magyar Monarchia",
    Answers = new List<string>{ "Németország és az Osztrák–Magyar Monarchia","Franciaország és Oroszország","Anglia és Olaszország","Németország és Japán" }
},
new PersonQuestion
{
    TetelNumber = 28,
    Question = "Kikhez köthető az antant kialakítása a francia–orosz, majd angol kapcsolatok révén?",
    CorrectAnswer = "a francia, orosz és angol diplomáciához",
    Answers = new List<string>{ "a francia, orosz és angol diplomáciához","a német és olasz tengelyhez","a Hanza-városokhoz","a Balkán Szövetséghez" }
},
new PersonQuestion
{
    TetelNumber = 28,
    Question = "Kihez köthető a szarajevói merénylet utáni demars és szerbellenes fellépés a Monarchia részéről?",
    CorrectAnswer = "az Osztrák–Magyar Monarchia vezetéséhez",
    Answers = new List<string>{ "az Osztrák–Magyar Monarchia vezetéséhez","a francia hadvezetéshez","az angol külügyhöz","az olasz királyhoz" }
},

// =====================
// 29. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki került hatalomra Németországban 1933-ban, megnyitva az utat a háború felé?",
    CorrectAnswer = "Adolf Hitler",
    Answers = new List<string>{ "Adolf Hitler","Benito Mussolini","Sztálin","Hindenburg" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Kihez köthető az Anschluss és a müncheni politika nyertese a tétel szerint?",
    CorrectAnswer = "Adolf Hitler",
    Answers = new List<string>{ "Adolf Hitler","Mussolini","Churchill","Roosevelt" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki volt az a brit politikus, aki a müncheni konferencián megegyezett Hitlerrel?",
    CorrectAnswer = "Chamberlain",
    Answers = new List<string>{ "Chamberlain","Churchill","Daladier","De Gaulle" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki volt a francia politikus a müncheni konferencián Hitler és Chamberlain mellett?",
    CorrectAnswer = "Daladier",
    Answers = new List<string>{ "Daladier","Pétain","De Gaulle","Clemenceau" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki kötötte meg a Szovjetunió részéről a Molotov–Ribbentrop-paktumot?",
    CorrectAnswer = "Molotov",
    Answers = new List<string>{ "Molotov","Sztálin","Trockij","Zsukov" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki írta alá a német fél részéről a Molotov–Ribbentrop-paktumot?",
    CorrectAnswer = "Ribbentrop",
    Answers = new List<string>{ "Ribbentrop","Hitler","Goebbels","Göring" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki volt Magyarország miniszterelnöke 1939 és 1941 között, a fegyveres semlegesség politikájával?",
    CorrectAnswer = "Teleki Pál",
    Answers = new List<string>{ "Teleki Pál","Bárdossy László","Bethlen István","Gömbös Gyula" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki nevezte ki Bárdossy Lászlót Teleki halála után?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Hitler","Teleki Pál","Kállay Miklós" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki lett Magyarország miniszterelnöke Teleki öngyilkossága után?",
    CorrectAnswer = "Bárdossy László",
    Answers = new List<string>{ "Bárdossy László","Teleki Pál","Kállay Miklós","Bethlen István" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Kihez köthető a magyar fegyveres semlegesség politikája 1939-ben?",
    CorrectAnswer = "Teleki Pál",
    Answers = new List<string>{ "Teleki Pál","Bárdossy László","Horthy Miklós","Hitler" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki követte el az öngyilkosságot, amikor Magyarország Jugoszlávia megtámadásának kényszerébe került?",
    CorrectAnswer = "Teleki Pál",
    Answers = new List<string>{ "Teleki Pál","Bárdossy László","Bethlen István","Kállay Miklós" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki állt Magyarország élén kormányzóként a második világháború alatt?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Ferenc József","Kádár János","Rákosi Mátyás" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki mondta 1940 májusától, hogy 'csak vért és könnyeket ígérhetek'?",
    CorrectAnswer = "Winston Churchill",
    Answers = new List<string>{ "Winston Churchill","Neville Chamberlain","Franklin Roosevelt","De Gaulle" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki vezette a franciaországi németbarát bábkormányt Vichyben?",
    CorrectAnswer = "Pétain",
    Answers = new List<string>{ "Pétain","De Gaulle","Daladier","Clemenceau" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki vezette a Szabad Franciaország ellenállási mozgalmát?",
    CorrectAnswer = "Charles de Gaulle",
    Answers = new List<string>{ "Charles de Gaulle","Pétain","Daladier","Laval" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki vezette a német Afrikakorpsot a tétel szerint?",
    CorrectAnswer = "Rommel",
    Answers = new List<string>{ "Rommel","Montgomery","Patton","Zsukov" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki győzte le Rommelt El-Alameinnél?",
    CorrectAnswer = "Montgomery",
    Answers = new List<string>{ "Montgomery","Rommel","Patton","Eisenhower" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki volt az a brit politikus, aki a németekkel szembeni ellenállás fő jelképe lett 1940-ben?",
    CorrectAnswer = "Winston Churchill",
    Answers = new List<string>{ "Winston Churchill","Chamberlain","Daladier","Roosevelt" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Kihez köthető a magyar revíziós politika német orientációja kormányzóként?",
    CorrectAnswer = "Horthy Miklós",
    Answers = new List<string>{ "Horthy Miklós","Teleki Pál","Bárdossy László","Bethlen István" }
},
new PersonQuestion
{
    TetelNumber = 29,
    Question = "Ki vezette a náci Németországot Lengyelország megtámadásakor?",
    CorrectAnswer = "Adolf Hitler",
    Answers = new List<string>{ "Adolf Hitler","Mussolini","Hindenburg","Goebbels" }
},

// =====================
// 30. TÉTEL
// =====================

new PersonQuestion
{
    TetelNumber = 30,
    Question = "Ki mondta ki 1946-os fultoni beszédében, hogy vasfüggöny húzódik Európában?",
    CorrectAnswer = "Winston Churchill",
    Answers = new List<string>{ "Winston Churchill","Harry Truman","George Marshall","Sztálin" }
},
new PersonQuestion
{
    TetelNumber = 30,
    Question = "Ki dolgozta ki 1947-ben azt az amerikai politikai koncepciót, amely a kommunizmus feltartóztatását célozta?",
    CorrectAnswer = "Harry Truman",
    Answers = new List<string>{ "Harry Truman","Winston Churchill","George Marshall","Eisenhower" }
},
new PersonQuestion
{
    TetelNumber = 30,
    Question = "Kihez köthető név szerint a Marshall-segély?",
    CorrectAnswer = "George Marshall",
    Answers = new List<string>{ "George Marshall","Harry Truman","Winston Churchill","George Kennan" }
},
new PersonQuestion
{
    TetelNumber = 30,
    Question = "Kihez kötődik a szovjet blokk létrehozása és ellenőrzése a hidegháború kezdetén?",
    CorrectAnswer = "Sztálin",
    Answers = new List<string>{ "Sztálin","Molotov","Hruscsov","Brezsnyev" }
},
new PersonQuestion
{
    TetelNumber = 30,
    Question = "Kihez köthető az 1947 utáni amerikai feltartóztatási politika politikai vezetése?",
    CorrectAnswer = "Harry Truman",
    Answers = new List<string>{ "Harry Truman","George Marshall","Churchill","Reagan" }
},
new PersonQuestion
{
    TetelNumber = 30,
    Question = "Ki fogalmazta meg elsőként politikai nyelven a világ kettészakadását a tétel szerint?",
    CorrectAnswer = "Winston Churchill",
    Answers = new List<string>{ "Winston Churchill","Harry Truman","Sztálin","Marshall" }
},
new PersonQuestion
{
    TetelNumber = 30,
    Question = "Kihez köthető a nyugati katonai szövetségi rendszer megszervezése amerikai oldalról?",
    CorrectAnswer = "az Egyesült Államok vezetéséhez",
    Answers = new List<string>{ "az Egyesült Államok vezetéséhez","Sztálinhoz","Molotovhoz","Brezsnyevhez" }
},
new PersonQuestion
{
    TetelNumber = 30,
    Question = "Kihez köthető a keleti blokk katonai és politikai ellenőrzése a Szovjetunió részéről?",
    CorrectAnswer = "Sztálinhoz és utódaihoz",
    Answers = new List<string>{ "Sztálinhoz és utódaihoz","Churchillhez és Trumanhoz","Marshallhoz és Eisenhowerhez","De Gaulle-hoz és Adenauerhez" }
},
new PersonQuestion
{
    TetelNumber = 30,
    Question = "Kihez köthető az a politika, amely gazdasági segítséggel akarta megerősíteni Nyugat-Európát?",
    CorrectAnswer = "George Marshallhoz",
    Answers = new List<string>{ "George Marshallhoz","Sztálinhoz","Molotovhoz","Hruscsovhoz" }
},
new PersonQuestion
{
    TetelNumber = 30,
    Question = "Kihez köthető az a tételbeli felismerés, hogy a világ két blokkra szakadt?",
    CorrectAnswer = "Winston Churchillhez",
    Answers = new List<string>{ "Winston Churchillhez","Harry Trumanhoz","Sztálinhoz","George Marshallhoz" }
},
new PersonQuestion
{
    TetelNumber = 30,
    Question = "Kihez köthető a nyugati blokk politikai és katonai vezető szerepe a hidegháborúban?",
    CorrectAnswer = "az USA-hoz",
    Answers = new List<string>{ "az USA-hoz","a Szovjetunióhoz","Franciaországhoz","az NSZK-hoz" }
},
new PersonQuestion
{
    TetelNumber = 30,
    Question = "Kihez köthető a keleti blokkban a kommunista hatalomátvételek kikényszerítése a megszállás nyomán?",
    CorrectAnswer = "a Szovjetunióhoz",
    Answers = new List<string>{ "a Szovjetunióhoz","az USA-hoz","Nagy-Britanniához","a NATO-hoz" }
},
new PersonQuestion
{
    TetelNumber = 30,
    Question = "Kihez köthető a Truman-doktrína megfogalmazása?",
    CorrectAnswer = "Harry Trumanhoz",
    Answers = new List<string>{ "Harry Trumanhoz","George Marshallhoz","Winston Churchillhez","Sztálinhoz" }
},
new PersonQuestion
{
    TetelNumber = 30,
    Question = "Kihez köthető a 'vasfüggöny' metafora elterjesztése a tételben?",
    CorrectAnswer = "Winston Churchillhez",
    Answers = new List<string>{ "Winston Churchillhez","Harry Trumanhoz","Molotovhoz","Sztálinhoz" }
},
new PersonQuestion
{
    TetelNumber = 30,
    Question = "Kihez köthető a keleti blokk politikai mintája és egypárti diktatúráinak fennmaradása a korszak elején?",
    CorrectAnswer = "Sztálinhoz",
    Answers = new List<string>{ "Sztálinhoz","Marshallhoz","Churchillhez","Trumanhoz" }
}
        };

        public List<int> GetAvailableTetelNumbers()
        {
            return _questions
                .Select(q => q.TetelNumber)
                .Distinct()
                .OrderBy(x => x)
                .ToList();
        }

        public List<PersonQuestion> GetQuestionsForTetel(int tetelNumber)
        {
            return _questions
     .Where(q => q.TetelNumber == tetelNumber)
     .ToList();
        }
    }
}