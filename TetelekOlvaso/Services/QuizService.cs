using TetelekOlvaso.Models;

namespace TetelekOlvaso.Services
{
    public class QuizService
    {
        private readonly List<YearQuestion> _questions = new()
        {
            new YearQuestion
            {
                TetelNumber = 1,
                Question = "Melyik évszám jelöli a középkor hagyományos kezdetét?",
                CorrectAnswer = "476",
                Answers = new List<string> { "476", "800", "1000", "1492" }
            },
            new YearQuestion
            {
                TetelNumber = 1,
                Question = "Melyik évszámhoz kötjük a középkor hagyományos végét és Amerika felfedezését?",
                CorrectAnswer = "1492",
                Answers = new List<string> { "1351", "1453", "1492", "1517" }
            },
            new YearQuestion
            {
                TetelNumber = 1,
                Question = "Melyik századtól indult meg jelentős fejlődés a középkori mezőgazdaságban?",
                CorrectAnswer = "10. század",
                Answers = new List<string> { "8. század", "10. század", "12. század", "16. század" }
            },
            new YearQuestion
            {
                TetelNumber = 1,
                Question = "Melyik századtól tértek át a kolostorok a nyomásos földművelésre?",
                CorrectAnswer = "8. század",
                Answers = new List<string> { "6. század", "8. század", "10. század", "11. század" }
            },
            new YearQuestion
            {
                TetelNumber = 1,
                Question = "Mikor vált általánossá Nyugat-Európában a háromnyomásos gazdálkodás?",
                CorrectAnswer = "10–11. század",
                Answers = new List<string> { "8–9. század", "10–11. század", "12–13. század", "15–16. század" }
            },
            new YearQuestion
            {
                TetelNumber = 1,
                Question = "Melyik század kedvezőbb, melegebb és csapadékosabb éghajlata segítette a gabonahozamok növekedését?",
                CorrectAnswer = "11. század",
                Answers = new List<string> { "9. század", "10. század", "11. század", "13. század" }
            },
            new YearQuestion
            {
                TetelNumber = 1,
                Question = "Melyik időszakban kezdett kialakulni Nyugat-Európában az árutermelés és a pénzgazdálkodás?",
                CorrectAnswer = "11–13. század",
                Answers = new List<string> { "8–9. század", "10–11. század", "11–13. század", "15–16. század" }
            },
            new YearQuestion
            {
                TetelNumber = 1,
                Question = "Mikor jött létre a Hanza-szövetség?",
                CorrectAnswer = "1161",
                Answers = new List<string> { "1054", "1161", "1215", "1351" }
            },
            new YearQuestion
            {
                TetelNumber = 1,
                Question = "Melyik évben írták elő Magyarországon a kilenced fizetését?",
                CorrectAnswer = "1351",
                Answers = new List<string> { "1222", "1301", "1351", "1492" }
            },
            new YearQuestion
            {
                TetelNumber = 1,
                Question = "Melyik században indult meg Európában az a gazdasági fellendülés, amelyet a 16. század egyensúlytalansága követett?",
                CorrectAnswer = "15. század",
                Answers = new List<string> { "13. század", "14. század", "15. század", "17. század" }
            },
            new YearQuestion
            {
                TetelNumber = 1,
                Question = "Melyik századhoz kötődik az árforradalom és a manufaktúrák megerősödése?",
                CorrectAnswer = "16. század",
                Answers = new List<string> { "14. század", "15. század", "16. század", "17. század" }
            },
            new YearQuestion
            {
                TetelNumber = 1,
                Question = "Mikor alapították a Brit Kelet-indiai Társaságot?",
                CorrectAnswer = "1600",
                Answers = new List<string> { "1492", "1600", "1602", "1664" }
            },
            new YearQuestion
            {
                TetelNumber = 1,
                Question = "Mikor alapították a Holland Kelet-indiai Társaságot?",
                CorrectAnswer = "1602",
                Answers = new List<string> { "1600", "1602", "1618", "1664" }
            },
            new YearQuestion
            {
                TetelNumber = 1,
                Question = "Mikor alapították a Francia Kelet-indiai Társaságot?",
                CorrectAnswer = "1664",
                Answers = new List<string> { "1602", "1620", "1648", "1664" }
            },
            // 2. tétel
new YearQuestion
{
    TetelNumber = 2,
    Question = "Mikor halt meg Károly Róbert?",
    CorrectAnswer = "1342",
    Answers = new List<string> { "1308", "1325", "1342", "1351" }
},
new YearQuestion
{
    TetelNumber = 2,
    Question = "Melyik évben készült el az első aranyforint Károly Róbert uralkodása alatt?",
    CorrectAnswer = "1325",
    Answers = new List<string> { "1301", "1325", "1336", "1351" }
},
new YearQuestion
{
    TetelNumber = 2,
    Question = "Mikor vezették be a kapuadót Károly Róbert idején?",
    CorrectAnswer = "1336",
    Answers = new List<string> { "1321", "1336", "1342", "1387" }
},
new YearQuestion
{
    TetelNumber = 2,
    Question = "Melyik évben győzte le Károly Róbert az Abákat a rozgonyi csatában?",
    CorrectAnswer = "1312",
    Answers = new List<string> { "1308", "1312", "1325", "1330" }
},
new YearQuestion
{
    TetelNumber = 2,
    Question = "Mikor uralkodott Luxemburgi Zsigmond a Magyar Királyságban?",
    CorrectAnswer = "1387–1437",
    Answers = new List<string> { "1351–1382", "1387–1437", "1437–1458", "1458–1490" }
},
new YearQuestion
{
    TetelNumber = 2,
    Question = "Melyik évben hívták meg a városok képviselőit az országgyűlésre Zsigmond idején?",
    CorrectAnswer = "1435",
    Answers = new List<string> { "1405", "1435", "1437", "1458" }
},
new YearQuestion
{
    TetelNumber = 2,
    Question = "Melyik évben tört ki a Budai Nagy Antal-féle parasztfelkelés Erdélyben?",
    CorrectAnswer = "1437",
    Answers = new List<string> { "1387", "1435", "1437", "1458" }
},
new YearQuestion
{
    TetelNumber = 2,
    Question = "Mikor uralkodott Hunyadi Mátyás?",
    CorrectAnswer = "1458–1490",
    Answers = new List<string> { "1437–1458", "1458–1490", "1490–1526", "1526–1541" }
},
new YearQuestion
{
    TetelNumber = 2,
    Question = "Melyik évben vezette be Mátyás a füstpénzt?",
    CorrectAnswer = "1467",
    Answers = new List<string> { "1458", "1467", "1479", "1490" }
},
new YearQuestion
{
    TetelNumber = 2,
    Question = "Melyik évben verték szét Kinizsi Pál csapatai a fekete sereg maradékát?",
    CorrectAnswer = "1492",
    Answers = new List<string> { "1467", "1479", "1490", "1492" }
},

// 4. tétel
new YearQuestion
{
    TetelNumber = 4,
    Question = "Melyik évben jött létre a kiegyezés?",
    CorrectAnswer = "1867",
    Answers = new List<string> { "1848", "1867", "1873", "1896" }
},
new YearQuestion
{
    TetelNumber = 4,
    Question = "Mikor jött létre a Magyar Állami Vasút (MÁV)?",
    CorrectAnswer = "1882",
    Answers = new List<string> { "1867", "1873", "1882", "1892" }
},
new YearQuestion
{
    TetelNumber = 4,
    Question = "Melyik évben egyesült Pest, Buda és Óbuda Budapestté?",
    CorrectAnswer = "1873",
    Answers = new List<string> { "1867", "1873", "1882", "1896" }
},
new YearQuestion
{
    TetelNumber = 4,
    Question = "Melyik évben tartották a millenniumi ünnepségeket?",
    CorrectAnswer = "1896",
    Answers = new List<string> { "1882", "1892", "1896", "1900" }
},
new YearQuestion
{
    TetelNumber = 4,
    Question = "Mikor vezették be a koronát aranyalapon a Monarchiában?",
    CorrectAnswer = "1892",
    Answers = new List<string> { "1867", "1882", "1892", "1896" }
},
new YearQuestion
{
    TetelNumber = 4,
    Question = "Melyik időszakban zajlott az első világháború?",
    CorrectAnswer = "1914–1918",
    Answers = new List<string> { "1912–1916", "1914–1918", "1918–1920", "1939–1945" }
},
new YearQuestion
{
    TetelNumber = 4,
    Question = "Mikor ült össze a párizsi békekonferencia Versailles-ban?",
    CorrectAnswer = "1919. január 18.",
    Answers = new List<string> { "1918. november 11.", "1919. január 18.", "1920. június 4.", "1921. március 1." }
},
new YearQuestion
{
    TetelNumber = 4,
    Question = "Melyik évben kötötték meg az olasz–magyar szerződést Bethlen idején?",
    CorrectAnswer = "1927",
    Answers = new List<string> { "1924", "1927", "1929", "1931" }
},
new YearQuestion
{
    TetelNumber = 4,
    Question = "Melyik évből indult ki a gazdasági világválság, amely Magyarországot is sújtotta?",
    CorrectAnswer = "1929",
    Answers = new List<string> { "1927", "1928", "1929", "1931" }
},
new YearQuestion
{
    TetelNumber = 4,
    Question = "Melyik évben volt a háromnapos bankzárlat Magyarországon?",
    CorrectAnswer = "1931",
    Answers = new List<string> { "1929", "1930", "1931", "1933" }
},
new YearQuestion
{
    TetelNumber = 4,
    Question = "Melyik évben alakult meg a KGST?",
    CorrectAnswer = "1949",
    Answers = new List<string> { "1947", "1948", "1949", "1951" }
},
new YearQuestion
{
    TetelNumber = 4,
    Question = "Melyik évben vezették be a jegyrendszert a Rákosi-korszakban?",
    CorrectAnswer = "1951",
    Answers = new List<string> { "1949", "1951", "1953", "1956" }
},
new YearQuestion
{
    TetelNumber = 4,
    Question = "Melyik évben utasították el szovjet nyomásra a Marshall-segélyt?",
    CorrectAnswer = "1947",
    Answers = new List<string> { "1945", "1947", "1949", "1951" }
},

// 5. tétel
new YearQuestion
{
    TetelNumber = 5,
    Question = "Melyik évben tört ki a Budai Nagy Antal-féle parasztfelkelés Erdélyben?",
    CorrectAnswer = "1437",
    Answers = new List<string> { "1435", "1437", "1456", "1526" }
},
new YearQuestion
{
    TetelNumber = 5,
    Question = "Melyik évben kötötték meg a kápolnai uniót?",
    CorrectAnswer = "1437",
    Answers = new List<string> { "1437", "1458", "1526", "1541" }
},
new YearQuestion
{
    TetelNumber = 5,
    Question = "Melyik évszám kapcsolódik a mohácsi csatához, amely után Erdély különállása felé indult a fejlődés?",
    CorrectAnswer = "1526",
    Answers = new List<string> { "1490", "1526", "1541", "1570" }
},
new YearQuestion
{
    TetelNumber = 5,
    Question = "Melyik év után alakult ki Erdély mint önálló állam?",
    CorrectAnswer = "1541",
    Answers = new List<string> { "1526", "1541", "1568", "1570" }
},
new YearQuestion
{
    TetelNumber = 5,
    Question = "Melyik évben rendezte a speyeri egyezmény Erdély államjogi helyzetét?",
    CorrectAnswer = "1570",
    Answers = new List<string> { "1541", "1568", "1570", "1606" }
},

// 7. tétel
new YearQuestion
{
    TetelNumber = 7,
    Question = "Melyik évszámhoz kötjük az angol polgári forradalom kezdetét, amely az ipari fejlődés egyik előfeltétele volt?",
    CorrectAnswer = "1640",
    Answers = new List<string> { "1600", "1640", "1694", "1750" }
},
new YearQuestion
{
    TetelNumber = 7,
    Question = "Melyik évben találta fel John Kay a repülő vetélőt?",
    CorrectAnswer = "1733",
    Answers = new List<string> { "1733", "1764", "1769", "1785" }
},
new YearQuestion
{
    TetelNumber = 7,
    Question = "Melyik évben készült el Hargreaves fonó Jennyje?",
    CorrectAnswer = "1764",
    Answers = new List<string> { "1733", "1764", "1767", "1779" }
},
new YearQuestion
{
    TetelNumber = 7,
    Question = "Melyik évben tökéletesítette James Watt a gőzgépet?",
    CorrectAnswer = "1769",
    Answers = new List<string> { "1698", "1764", "1769", "1807" }
},
new YearQuestion
{
    TetelNumber = 7,
    Question = "Melyik évben alkotta meg Arkwright a vízikerék-meghajtású fonógépet?",
    CorrectAnswer = "1767",
    Answers = new List<string> { "1764", "1767", "1779", "1785" }
},
new YearQuestion
{
    TetelNumber = 7,
    Question = "Melyik évben jelent meg Crompton fonógépe?",
    CorrectAnswer = "1779",
    Answers = new List<string> { "1767", "1779", "1785", "1807" }
},
new YearQuestion
{
    TetelNumber = 7,
    Question = "Melyik évben készült el Cartwright mechanikus szövőgépe?",
    CorrectAnswer = "1785",
    Answers = new List<string> { "1779", "1785", "1807", "1817" }
},
new YearQuestion
{
    TetelNumber = 7,
    Question = "Melyik évben alkalmaztak először gőzhajtású bányaszivattyút?",
    CorrectAnswer = "1698",
    Answers = new List<string> { "1640", "1698", "1769", "1817" }
},
new YearQuestion
{
    TetelNumber = 7,
    Question = "Melyik évben próbálták ki Fulton gőzhajóját?",
    CorrectAnswer = "1807",
    Answers = new List<string> { "1785", "1807", "1817", "1825" }
},
new YearQuestion
{
    TetelNumber = 7,
    Question = "Melyik évben jelent meg Stephenson gőzmozdonya?",
    CorrectAnswer = "1817",
    Answers = new List<string> { "1807", "1817", "1819", "1825" }
},
new YearQuestion
{
    TetelNumber = 7,
    Question = "Melyik évben próbálták ki először a Stockton–Darlington vasútvonalon a gőzmozdonyt?",
    CorrectAnswer = "1825",
    Answers = new List<string> { "1817", "1819", "1825", "1837" }
},
new YearQuestion
{
    TetelNumber = 7,
    Question = "Melyik évben készült el az első vashíd a Tweed folyón?",
    CorrectAnswer = "1819",
    Answers = new List<string> { "1807", "1817", "1819", "1837" }
},
new YearQuestion
{
    TetelNumber = 7,
    Question = "Melyik évben jelent meg Morse szikratávírója?",
    CorrectAnswer = "1837",
    Answers = new List<string> { "1819", "1825", "1837", "1850" }
},
new YearQuestion
{
    TetelNumber = 7,
    Question = "Melyik évben alapították az Angol Bankot, amely a hitelszervezet kiépülését segítette?",
    CorrectAnswer = "1694",
    Answers = new List<string> { "1640", "1694", "1733", "1769" }
},

// 8. tétel
new YearQuestion
{
    TetelNumber = 8,
    Question = "Melyik évben szervezték meg a Baloldali Blokkot?",
    CorrectAnswer = "1946",
    Answers = new List<string> { "1945", "1946", "1947", "1949" }
},
new YearQuestion
{
    TetelNumber = 8,
    Question = "Melyik évben írták alá a párizsi békét Magyarországgal?",
    CorrectAnswer = "1947. február 10.",
    Answers = new List<string> { "1946. február 10.", "1947. február 10.", "1948. március 15.", "1949. augusztus 20." }
},
new YearQuestion
{
    TetelNumber = 8,
    Question = "Melyik évre használjuk a 'fordulat éve' kifejezést?",
    CorrectAnswer = "1947",
    Answers = new List<string> { "1945", "1946", "1947", "1948" }
},
new YearQuestion
{
    TetelNumber = 8,
    Question = "Melyik évben kezdte meg működését a Magyar Televízió?",
    CorrectAnswer = "1957",
    Answers = new List<string> { "1956", "1957", "1966", "1970" }
},
new YearQuestion
{
    TetelNumber = 8,
    Question = "Melyik évben rendezték meg először a táncdalfesztivált?",
    CorrectAnswer = "1966",
    Answers = new List<string> { "1957", "1966", "1967", "1973" }
},
new YearQuestion
{
    TetelNumber = 8,
    Question = "Melyik évben vezették be a GYES-t?",
    CorrectAnswer = "1967",
    Answers = new List<string> { "1966", "1967", "1970", "1973" }
},
new YearQuestion
{
    TetelNumber = 8,
    Question = "Melyik évben építették újjá utolsóként az Erzsébet hidat?",
    CorrectAnswer = "1967",
    Answers = new List<string> { "1966", "1967", "1970", "1973" }
},
new YearQuestion
{
    TetelNumber = 8,
    Question = "Melyik évben adták át a 2-es metrót?",
    CorrectAnswer = "1970",
    Answers = new List<string> { "1967", "1970", "1973", "1975" }
},
new YearQuestion
{
    TetelNumber = 8,
    Question = "Melyik évtől sugárzott három rádióadó Magyarországon?",
    CorrectAnswer = "1973",
    Answers = new List<string> { "1967", "1970", "1973", "1976" }
},
new YearQuestion
{
    TetelNumber = 8,
    Question = "Melyik olimpián nyert a magyar csapat 16 aranyérmet, amit később sem közelített meg?",
    CorrectAnswer = "1952",
    Answers = new List<string> { "1948", "1952", "1956", "1960" }
},
// 3. tétel
new YearQuestion
{
    TetelNumber = 3,
    Question = "Melyik évben robbant ki az USA-ból induló világgazdasági válság?",
    CorrectAnswer = "1929",
    Answers = new List<string> { "1919", "1924", "1929", "1933" }
},
new YearQuestion
{
    TetelNumber = 3,
    Question = "Melyik naphoz kötjük a New York-i tőzsdekrachot, a fekete csütörtököt?",
    CorrectAnswer = "1929. október 24.",
    Answers = new List<string> { "1929. szeptember 1.", "1929. október 24.", "1930. január 1.", "1933. március 4." }
},
new YearQuestion
{
    TetelNumber = 3,
    Question = "Meddig tartott a világgazdasági válság legsúlyosabb szakasza az USA-ban a tétel szerint?",
    CorrectAnswer = "1933-ig",
    Answers = new List<string> { "1931-ig", "1932-ig", "1933-ig", "1935-ig" }
},
new YearQuestion
{
    TetelNumber = 3,
    Question = "Melyik évben lett Franklin Delano Roosevelt az USA elnöke a válság mélypontján?",
    CorrectAnswer = "1932",
    Answers = new List<string> { "1929", "1931", "1932", "1936" }
},
new YearQuestion
{
    TetelNumber = 3,
    Question = "Melyik évhez kötjük a New Deal meghirdetését?",
    CorrectAnswer = "1933",
    Answers = new List<string> { "1929", "1932", "1933", "1935" }
},
new YearQuestion
{
    TetelNumber = 3,
    Question = "Melyik évben lépett az USA diplomáciai kapcsolatba a Szovjetunióval a New Deal idején?",
    CorrectAnswer = "1933",
    Answers = new List<string> { "1929", "1931", "1933", "1945" }
},
new YearQuestion
{
    TetelNumber = 3,
    Question = "Melyik évben beszélt Churchill zürichi beszédében Európai Egyesült Államokról?",
    CorrectAnswer = "1946",
    Answers = new List<string> { "1945", "1946", "1948", "1950" }
},
new YearQuestion
{
    TetelNumber = 3,
    Question = "Melyik év óta működik Strasbourgban az Európa Tanács?",
    CorrectAnswer = "1949",
    Answers = new List<string> { "1946", "1948", "1949", "1951" }
},
new YearQuestion
{
    TetelNumber = 3,
    Question = "Melyik évben indult az európai integráció a Schuman-tervvel?",
    CorrectAnswer = "1950",
    Answers = new List<string> { "1948", "1950", "1951", "1957" }
},
new YearQuestion
{
    TetelNumber = 3,
    Question = "Mikor terjesztette elő Robert Schuman a megbékélésről és együttműködésről szóló tervét?",
    CorrectAnswer = "1950. május 9.",
    Answers = new List<string> { "1949. május 9.", "1950. május 9.", "1951. április 18.", "1957. március 25." }
},
new YearQuestion
{
    TetelNumber = 3,
    Question = "Melyik évben írták alá az Európai Szén- és Acélközösséget létrehozó szerződést?",
    CorrectAnswer = "1951",
    Answers = new List<string> { "1950", "1951", "1957", "1990" }
},
new YearQuestion
{
    TetelNumber = 3,
    Question = "Melyik évben csatlakozott Magyarország az Európa Tanácshoz a tétel szerint?",
    CorrectAnswer = "1990",
    Answers = new List<string> { "1989", "1990", "1995", "2004" }
},

// 6. tétel
new YearQuestion
{
    TetelNumber = 6,
    Question = "Melyik évben sikerült visszafoglalni Budát a töröktől?",
    CorrectAnswer = "1686",
    Answers = new List<string> { "1664", "1686", "1699", "1711" }
},
new YearQuestion
{
    TetelNumber = 6,
    Question = "Melyik béke zárta le a felszabadító háborúkat a 17. század végén?",
    CorrectAnswer = "1699-es karlócai béke",
    Answers = new List<string> { "1664-es vasvári béke", "1699-es karlócai béke", "1711-es szatmári béke", "1720-as béke" }
},
new YearQuestion
{
    TetelNumber = 6,
    Question = "Melyik évben kötötték meg a Rákóczi-szabadságharcot lezáró szatmári békét?",
    CorrectAnswer = "1711",
    Answers = new List<string> { "1699", "1711", "1720", "1740" }
},
new YearQuestion
{
    TetelNumber = 6,
    Question = "Mikor uralkodott III. Károly Magyarországon a tétel szerint?",
    CorrectAnswer = "1711–1740",
    Answers = new List<string> { "1703–1711", "1711–1740", "1740–1780", "1780–1790" }
},
new YearQuestion
{
    TetelNumber = 6,
    Question = "Melyik év körül érte el újra az ország népessége a Mátyás-korabeli szintet?",
    CorrectAnswer = "1720 körül",
    Answers = new List<string> { "1686 körül", "1711 körül", "1720 körül", "1790 körül" }
},
new YearQuestion
{
    TetelNumber = 6,
    Question = "Melyik évtől indult meg nagyobb arányban a németek szervezett betelepítése?",
    CorrectAnswer = "1720-tól",
    Answers = new List<string> { "1699-től", "1711-től", "1720-tól", "1740-től" }
},
new YearQuestion
{
    TetelNumber = 6,
    Question = "Mikor uralkodott Mária Terézia?",
    CorrectAnswer = "1740–1780",
    Answers = new List<string> { "1711–1740", "1740–1780", "1780–1790", "1790–1800" }
},
new YearQuestion
{
    TetelNumber = 6,
    Question = "Mikor uralkodott II. József?",
    CorrectAnswer = "1780–1790",
    Answers = new List<string> { "1740–1780", "1780–1790", "1790–1800", "1800–1815" }
},
new YearQuestion
{
    TetelNumber = 6,
    Question = "Melyik évben rendelt el II. József népszámlálást a 18. század végén?",
    CorrectAnswer = "1790",
    Answers = new List<string> { "1780", "1784", "1790", "1795" }
},
new YearQuestion
{
    TetelNumber = 6,
    Question = "Melyik évszám kapcsolódik a Maros–Körös közi parasztfelkeléshez?",
    CorrectAnswer = "1735",
    Answers = new List<string> { "1711", "1735", "1765", "1784" }
},
new YearQuestion
{
    TetelNumber = 6,
    Question = "Melyik években zajlott a Nyugat-Dunántúli parasztfelkelés a tétel szerint?",
    CorrectAnswer = "1765–66",
    Answers = new List<string> { "1735–36", "1765–66", "1780–81", "1784–85" }
},
new YearQuestion
{
    TetelNumber = 6,
    Question = "Melyik évben tört ki az erdélyi parasztfelkelés, amelyet a Habsburgok levertek?",
    CorrectAnswer = "1784",
    Answers = new List<string> { "1765", "1780", "1784", "1790" }
},
new YearQuestion
{
    TetelNumber = 6,
    Question = "Melyik időszakra esett a tizenöt éves háború, amely súlyos népességpusztulást okozott?",
    CorrectAnswer = "1593–1606",
    Answers = new List<string> { "1526–1541", "1568–1570", "1593–1606", "1683–1699" }
},
new YearQuestion
{
    TetelNumber = 6,
    Question = "Melyik időszakra esett a Rákóczi-szabadságharc?",
    CorrectAnswer = "1703–1711",
    Answers = new List<string> { "1683–1699", "1703–1711", "1711–1740", "1780–1790" }
},
// 9. tétel
new YearQuestion
{
    TetelNumber = 9,
    Question = "Melyik évben írták alá a trianoni békeszerződést?",
    CorrectAnswer = "1920. június 4.",
    Answers = new List<string> { "1918. november 3.", "1920. június 4.", "1921. december 14.", "1947. február 10." }
},
new YearQuestion
{
    TetelNumber = 9,
    Question = "Melyik évben készült el Teleki Pál vörös térképe és ekkor érkezett Párizsba a magyar békedelegáció?",
    CorrectAnswer = "1920",
    Answers = new List<string> { "1918", "1919", "1920", "1921" }
},
new YearQuestion
{
    TetelNumber = 9,
    Question = "Melyik évben mondta ki a második bécsi döntés Észak-Erdély visszacsatolását?",
    CorrectAnswer = "1940",
    Answers = new List<string> { "1938", "1940", "1941", "1947" }
},
new YearQuestion
{
    TetelNumber = 9,
    Question = "Mikor kapcsolódott be Magyarország a Jugoszlávia elleni hadműveletekbe?",
    CorrectAnswer = "1941. április 11.",
    Answers = new List<string> { "1940. augusztus 30.", "1941. április 11.", "1941. június 27.", "1945. május 9." }
},
new YearQuestion
{
    TetelNumber = 9,
    Question = "Melyik évben írták alá a párizsi békét, amely visszaállította a trianoni határokat?",
    CorrectAnswer = "1947. február 10.",
    Answers = new List<string> { "1945. május 8.", "1946. január 1.", "1947. február 10.", "1948. június 12." }
},
new YearQuestion
{
    TetelNumber = 9,
    Question = "Melyik évhez kötjük az 1956-os forradalom utáni nagy magyar kivándorlási hullámot?",
    CorrectAnswer = "1956",
    Answers = new List<string> { "1947", "1956", "1968", "1989" }
},
new YearQuestion
{
    TetelNumber = 9,
    Question = "Melyik népszámlálási év adatait említi a tétel a Kárpát-medencei magyarság bemutatásánál?",
    CorrectAnswer = "2011",
    Answers = new List<string> { "2001", "2010", "2011", "2014" }
},
new YearQuestion
{
    TetelNumber = 9,
    Question = "Melyik évben elfogadott választási törvényt alkalmazták először a parlamenti választáson?",
    CorrectAnswer = "2014",
    Answers = new List<string> { "2010", "2011", "2014", "2018" }
},
new YearQuestion
{
    TetelNumber = 9,
    Question = "Melyik évben született az országgyűlési képviselők választásáról szóló CCIII. törvény?",
    CorrectAnswer = "2011",
    Answers = new List<string> { "2006", "2010", "2011", "2014" }
},

// 13. tétel
new YearQuestion
{
    TetelNumber = 13,
    Question = "Melyik évben következett be a mohácsi csata, amely után a Habsburgok is bejelentették igényüket a magyar trónra?",
    CorrectAnswer = "1526",
    Answers = new List<string> { "1490", "1526", "1541", "1604" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Mikor választották Szapolyai Jánost királlyá a fehérvári országgyűlésen?",
    CorrectAnswer = "1526 novemberében",
    Answers = new List<string> { "1526 novemberében", "1526 decemberében", "1541-ben", "1608-ban" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Mikor választották Habsburg Ferdinándot királlyá a pozsonyi országgyűlésen?",
    CorrectAnswer = "1526 decemberében",
    Answers = new List<string> { "1526 novemberében", "1526 decemberében", "1541-ben", "1606-ban" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Melyik évek között zajlott a tizenöt éves háború a tétel szerint?",
    CorrectAnswer = "1591–1606",
    Answers = new List<string> { "1568–1570", "1591–1606", "1604–1606", "1703–1711" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Melyik évben tört ki a Bocskai-szabadságharc?",
    CorrectAnswer = "1604",
    Answers = new List<string> { "1591", "1604", "1606", "1608" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Melyik évben zárta le a bécsi béke a Bocskai-felkelést?",
    CorrectAnswer = "1606",
    Answers = new List<string> { "1604", "1605", "1606", "1608" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Melyik évben kötötték meg a zsitvatoroki békét?",
    CorrectAnswer = "1606",
    Answers = new List<string> { "1591", "1604", "1606", "1613" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Melyik évben választották Bethlen Gábort erdélyi fejedelemmé?",
    CorrectAnswer = "1613",
    Answers = new List<string> { "1608", "1613", "1616", "1629" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Meddig tartott Bethlen Gábor fejedelemsége a tétel szerint?",
    CorrectAnswer = "1613–1629",
    Answers = new List<string> { "1605–1606", "1608–1613", "1613–1629", "1629–1648" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Melyik évben adta át Bethlen Lippa várát a törököknek?",
    CorrectAnswer = "1616",
    Answers = new List<string> { "1608", "1613", "1616", "1620" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Melyik évben kötötték a vasvári békét?",
    CorrectAnswer = "1664",
    Answers = new List<string> { "1648", "1664", "1666", "1681" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Melyik évben halt meg Zrínyi Miklós a kursaneci vadászbalesetben?",
    CorrectAnswer = "1664",
    Answers = new List<string> { "1660", "1664", "1666", "1678" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Melyik évek között zajlott a Wesselényi-féle rendi szervezkedés?",
    CorrectAnswer = "1666–1671",
    Answers = new List<string> { "1664–1666", "1666–1671", "1672–1678", "1678–1685" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Melyik évek között zajlott a Thököly-felkelés?",
    CorrectAnswer = "1678–1685",
    Answers = new List<string> { "1666–1671", "1672–1678", "1678–1685", "1683–1699" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Melyik évben hívta össze I. Lipót a soproni országgyűlést a Thököly-felkelés hatására?",
    CorrectAnswer = "1681",
    Answers = new List<string> { "1678", "1681", "1682", "1683" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Melyik évben foglalta el Thököly Kassát és Füleket, létrehozva a Felső-magyarországi Fejedelemséget?",
    CorrectAnswer = "1682",
    Answers = new List<string> { "1681", "1682", "1683", "1686" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Melyik évben ostromolta sikertelenül Kara Musztafa Bécset?",
    CorrectAnswer = "1683",
    Answers = new List<string> { "1681", "1682", "1683", "1686" }
},
new YearQuestion
{
    TetelNumber = 13,
    Question = "Melyik évben adta ki I. Lipót a Diploma Leopoldiumot?",
    CorrectAnswer = "1691. december 4.",
    Answers = new List<string> { "1686. szeptember 2.", "1691. december 4.", "1699. január 26.", "1711. április 30." }
},

// 14. tétel
new YearQuestion
{
    TetelNumber = 14,
    Question = "Melyik században jött létre a felvilágosodás Angliában a tétel szerint?",
    CorrectAnswer = "XVII. század",
    Answers = new List<string> { "XVI. század", "XVII. század", "XVIII. század", "XIX. század" }
},
new YearQuestion
{
    TetelNumber = 14,
    Question = "Melyik században bontakozott ki a felvilágosodás Franciaországban?",
    CorrectAnswer = "XVIII. század",
    Answers = new List<string> { "XVI. század", "XVII. század", "XVIII. század", "XIX. század" }
},
new YearQuestion
{
    TetelNumber = 14,
    Question = "Melyik évben jelent meg Kopernikusz Égitestek körforgása című műve?",
    CorrectAnswer = "1543",
    Answers = new List<string> { "1516", "1543", "1620", "1637" }
},
new YearQuestion
{
    TetelNumber = 14,
    Question = "Melyik évek között élt Kopernikusz a tétel szerint?",
    CorrectAnswer = "1473–1543",
    Answers = new List<string> { "1473–1543", "1564–1642", "1643–1723", "1724–1804" }
},
new YearQuestion
{
    TetelNumber = 14,
    Question = "Melyik évek között élt Galilei?",
    CorrectAnswer = "1564–1642",
    Answers = new List<string> { "1473–1543", "1561–1626", "1564–1642", "1643–1723" }
},
new YearQuestion
{
    TetelNumber = 14,
    Question = "Melyik évek között élt Newton?",
    CorrectAnswer = "1643–1723",
    Answers = new List<string> { "1596–1650", "1632–1704", "1643–1723", "1689–1755" }
},
new YearQuestion
{
    TetelNumber = 14,
    Question = "Melyik évben írta Bacon a Novum Organumot?",
    CorrectAnswer = "1620",
    Answers = new List<string> { "1516", "1620", "1637", "1776" }
},
new YearQuestion
{
    TetelNumber = 14,
    Question = "Melyik évben jelent meg Morus Tamás Utópia című műve?",
    CorrectAnswer = "1516",
    Answers = new List<string> { "1516", "1620", "1637", "1721" }
},
new YearQuestion
{
    TetelNumber = 14,
    Question = "Melyik évben írta Descartes az Értekezés a módszerről című művét?",
    CorrectAnswer = "1637",
    Answers = new List<string> { "1620", "1637", "1721", "1748" }
},
new YearQuestion
{
    TetelNumber = 14,
    Question = "Melyik évben jelent meg Adam Smith A nemzetek gazdasága című műve?",
    CorrectAnswer = "1776",
    Answers = new List<string> { "1748", "1776", "1789", "1791" }
},
new YearQuestion
{
    TetelNumber = 14,
    Question = "Melyik évben jelent meg Montesquieu Perzsa levelek című műve?",
    CorrectAnswer = "1721",
    Answers = new List<string> { "1637", "1721", "1748", "1776" }
},
new YearQuestion
{
    TetelNumber = 14,
    Question = "Melyik évben jelent meg Montesquieu A törvények szelleméről című műve?",
    CorrectAnswer = "1748",
    Answers = new List<string> { "1721", "1748", "1776", "1789" }
},
new YearQuestion
{
    TetelNumber = 14,
    Question = "Melyik napon tört ki a francia forradalom a tétel szerint?",
    CorrectAnswer = "1789. július 14.",
    Answers = new List<string> { "1776. július 4.", "1789. július 14.", "1789. augusztus 26.", "1791. szeptember 3." }
},
new YearQuestion
{
    TetelNumber = 14,
    Question = "Melyik napon fogadta el az Alkotmányozó Nemzetgyűlés az Emberi és polgári jogok nyilatkozatát?",
    CorrectAnswer = "1789. augusztus 26.",
    Answers = new List<string> { "1789. július 14.", "1789. augusztus 26.", "1791. szeptember 3.", "1793. január 21." }
},
new YearQuestion
{
    TetelNumber = 14,
    Question = "Melyik év alkotmányát készítette elő az Emberi és polgári jogok nyilatkozata?",
    CorrectAnswer = "1791",
    Answers = new List<string> { "1789", "1791", "1793", "1804" }
},

// 15. tétel
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik időszakban uralkodott I. Jakab Angliában?",
    CorrectAnswer = "1603–1625",
    Answers = new List<string> { "1603–1625", "1625–1649", "1649–1660", "1688–1702" }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik évtől nem hívta össze I. Jakab a parlamentet a tétel szerint?",
    CorrectAnswer = "1611",
    Answers = new List<string> { "1603", "1611", "1625", "1628" }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik időszakban uralkodott I. Károly?",
    CorrectAnswer = "1625–1649",
    Answers = new List<string> { "1603–1625", "1625–1649", "1649–1660", "1660–1688" }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik évben kényszerült I. Károly elfogadni a Jogok Kérvényét?",
    CorrectAnswer = "1628",
    Answers = new List<string> { "1611", "1628", "1640", "1642" }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik napon hívták össze a Rövid parlamentet?",
    CorrectAnswer = "1640. április 13.",
    Answers = new List<string> { "1640. április 13.", "1640. november 3.", "1642. január 10.", "1649. január 30." }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik napon hívták össze a Hosszú parlamentet?",
    CorrectAnswer = "1640. november 3.",
    Answers = new List<string> { "1640. április 13.", "1640. november 3.", "1642. január 10.", "1648. december 2." }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik napon tört ki az angol polgárháború a tétel szerint?",
    CorrectAnswer = "1642. január 10.",
    Answers = new List<string> { "1640. november 3.", "1642. január 10.", "1644. július 2.", "1645. június 14." }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik évben zajlott a marston moori csata?",
    CorrectAnswer = "1644",
    Answers = new List<string> { "1642", "1644", "1645", "1648" }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik évben zajlott a nasebyi csata?",
    CorrectAnswer = "1645",
    Answers = new List<string> { "1644", "1645", "1648", "1649" }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik évben győzték le újra a királyi csapatokat Prestonnál?",
    CorrectAnswer = "1648",
    Answers = new List<string> { "1645", "1648", "1649", "1651" }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik napon végezték ki I. Károlyt?",
    CorrectAnswer = "1649. január 30.",
    Answers = new List<string> { "1648. december 2.", "1649. január 30.", "1651. január 1.", "1660. május 29." }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik időszakban állt fenn a köztársaság Angliában a tétel szerint?",
    CorrectAnswer = "1649–1660",
    Answers = new List<string> { "1642–1649", "1649–1660", "1660–1688", "1688–1689" }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik évben adták ki a Hajózási törvényeket?",
    CorrectAnswer = "1651",
    Answers = new List<string> { "1649", "1651", "1653", "1689" }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik évben lett Cromwell államvédnök?",
    CorrectAnswer = "1653",
    Answers = new List<string> { "1651", "1653", "1660", "1689" }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik évben történt a bostoni teadélután?",
    CorrectAnswer = "1773. december 16.",
    Answers = new List<string> { "1765. január 1.", "1773. december 16.", "1774. szeptember 1.", "1776. július 4." }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik évben ült össze az első Kontinentális Kongresszus?",
    CorrectAnswer = "1774",
    Answers = new List<string> { "1773", "1774", "1775", "1776" }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik időszakban zajlott az amerikai függetlenségi háború?",
    CorrectAnswer = "1775–1783",
    Answers = new List<string> { "1774–1776", "1775–1783", "1776–1789", "1783–1787" }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik évben fogadták el a Függetlenségi Nyilatkozatot?",
    CorrectAnswer = "1776",
    Answers = new List<string> { "1774", "1775", "1776", "1783" }
},
new YearQuestion
{
    TetelNumber = 15,
    Question = "Melyik napon fogadták el a Függetlenségi Nyilatkozatot?",
    CorrectAnswer = "1776. július 4.",
    Answers = new List<string> { "1775. április 19.", "1776. július 4.", "1783. szeptember 3.", "1787. szeptember 17." }
},

new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben halt ki az Árpád-ház?",
    CorrectAnswer = "1301",
    Answers = new List<string> { "1241", "1270", "1301", "1325" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben győzte le Károly Róbert az Abákat a rozgonyi csatában?",
    CorrectAnswer = "1312",
    Answers = new List<string> { "1308", "1312", "1321", "1342" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben kezdődött I. István uralkodása?",
    CorrectAnswer = "997",
    Answers = new List<string> { "895", "972", "997", "1001" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben koronázták királlyá I. Istvánt a hagyomány szerint?",
    CorrectAnswer = "1000",
    Answers = new List<string> { "997", "1000", "1001", "1038" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben halt meg Szent István?",
    CorrectAnswer = "1038",
    Answers = new List<string> { "1000", "1038", "1046", "1077" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben tört ki a Vata-féle pogánylázadás?",
    CorrectAnswer = "1046",
    Answers = new List<string> { "1038", "1046", "1077", "1095" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben került trónra I. László?",
    CorrectAnswer = "1077",
    Answers = new List<string> { "1046", "1077", "1095", "1096" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évek között uralkodott Könyves Kálmán a tétel szerint?",
    CorrectAnswer = "1095–1116",
    Answers = new List<string> { "1077–1095", "1095–1116", "1116–1131", "1172–1196" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben zajlott az első keresztes hadjárat, amelyhez Magyarország is kapcsolódott átvonulási területként?",
    CorrectAnswer = "1096",
    Answers = new List<string> { "1077", "1096", "1217", "1241" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben adta ki II. András az Aranybullát?",
    CorrectAnswer = "1222",
    Answers = new List<string> { "1205", "1217", "1222", "1241" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben indult II. András keresztes hadjárata?",
    CorrectAnswer = "1217",
    Answers = new List<string> { "1205", "1217", "1222", "1235" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben tört be a tatár sereg Magyarországra?",
    CorrectAnswer = "1241",
    Answers = new List<string> { "1222", "1235", "1241", "1242" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben vonultak ki a tatárok Magyarországról?",
    CorrectAnswer = "1242",
    Answers = new List<string> { "1241", "1242", "1246", "1270" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben halt meg IV. Béla, a második honalapító?",
    CorrectAnswer = "1270",
    Answers = new List<string> { "1242", "1270", "1272", "1301" }
},

// 11. tétel
new YearQuestion
{
    TetelNumber = 11,
    Question = "Melyik századtól működött keresztény feudális királyság Magyarországon a tétel szerint?",
    CorrectAnswer = "XI. század",
    Answers = new List<string> { "IX. század", "X. század", "XI. század", "XIII. század" }
},
new YearQuestion
{
    TetelNumber = 11,
    Question = "Melyik évek között uralkodott I. István?",
    CorrectAnswer = "997–1038",
    Answers = new List<string> { "1000–1038", "997–1038", "1038–1046", "1077–1095" }
},
new YearQuestion
{
    TetelNumber = 11,
    Question = "Melyik évben adta ki II. András az Aranybullát?",
    CorrectAnswer = "1222",
    Answers = new List<string> { "1205", "1222", "1301", "1351" }
},
new YearQuestion
{
    TetelNumber = 11,
    Question = "Melyik évben erősítették meg Nagy Lajos törvényei az Aranybullát?",
    CorrectAnswer = "1351",
    Answers = new List<string> { "1301", "1342", "1351", "1387" }
},
new YearQuestion
{
    TetelNumber = 11,
    Question = "Melyik évben halt ki az Árpád-ház?",
    CorrectAnswer = "1301",
    Answers = new List<string> { "1270", "1301", "1312", "1351" }
},
new YearQuestion
{
    TetelNumber = 11,
    Question = "Melyik időszakhoz kötjük az Anjou-kort a tétel szerint?",
    CorrectAnswer = "1308–1387",
    Answers = new List<string> { "1270–1301", "1308–1387", "1387–1437", "1458–1490" }
},
new YearQuestion
{
    TetelNumber = 11,
    Question = "Melyik évben kezdődött Károly Róbert uralkodása a tételben szereplő adatok szerint?",
    CorrectAnswer = "1308",
    Answers = new List<string> { "1301", "1308", "1312", "1342" }
},
new YearQuestion
{
    TetelNumber = 11,
    Question = "Melyik évben ért véget Károly Róbert uralkodása?",
    CorrectAnswer = "1342",
    Answers = new List<string> { "1312", "1342", "1351", "1387" }
},
new YearQuestion
{
    TetelNumber = 11,
    Question = "Melyik évben győzte le Károly Róbert az Abákat Rozgonynál?",
    CorrectAnswer = "1312",
    Answers = new List<string> { "1308", "1312", "1325", "1351" }
},
new YearQuestion
{
    TetelNumber = 11,
    Question = "Melyik évek között uralkodott Luxemburgi Zsigmond?",
    CorrectAnswer = "1387–1437",
    Answers = new List<string> { "1351–1382", "1387–1437", "1437–1458", "1458–1490" }
},
new YearQuestion
{
    TetelNumber = 11,
    Question = "Melyik évben kezdődött Hunyadi Mátyás uralkodása?",
    CorrectAnswer = "1458",
    Answers = new List<string> { "1437", "1456", "1458", "1490" }
},
new YearQuestion
{
    TetelNumber = 11,
    Question = "Melyik évben ért véget Hunyadi Mátyás uralkodása?",
    CorrectAnswer = "1490",
    Answers = new List<string> { "1458", "1479", "1490", "1492" }
},
new YearQuestion
{
    TetelNumber = 11,
    Question = "Melyik évben vezette be Mátyás a füstpénzt?",
    CorrectAnswer = "1467",
    Answers = new List<string> { "1458", "1467", "1471", "1490" }
},
new YearQuestion
{
    TetelNumber = 11,
    Question = "Melyik évben számolták fel a fekete sereg maradékát Kinizsi vezetésével?",
    CorrectAnswer = "1492",
    Answers = new List<string> { "1479", "1490", "1492", "1526" }
},

// 12. tétel
new YearQuestion
{
    TetelNumber = 12,
    Question = "Melyik évszámhoz kötjük a középkor hagyományos kezdetét?",
    CorrectAnswer = "476",
    Answers = new List<string> { "395", "476", "800", "1492" }
},
new YearQuestion
{
    TetelNumber = 12,
    Question = "Melyik évhez kötjük a középkor hagyományos végét és Amerika felfedezését?",
    CorrectAnswer = "1492",
    Answers = new List<string> { "1453", "1492", "1517", "1526" }
},
new YearQuestion
{
    TetelNumber = 12,
    Question = "Melyik évben alapították a bolognai egyetemet, az első európai egyetemet?",
    CorrectAnswer = "1088",
    Answers = new List<string> { "1054", "1088", "1150", "1206" }
},
new YearQuestion
{
    TetelNumber = 12,
    Question = "Melyik évben jött létre az oxfordi egyetem a tétel szerint?",
    CorrectAnswer = "1096",
    Answers = new List<string> { "1088", "1096", "1150", "1367" }
},
new YearQuestion
{
    TetelNumber = 12,
    Question = "Melyik évben alapították a párizsi egyetemet?",
    CorrectAnswer = "1150",
    Answers = new List<string> { "1096", "1150", "1206", "1367" }
},
new YearQuestion
{
    TetelNumber = 12,
    Question = "Melyik évben alapították a pécsi egyetemet, az első magyar egyetemet?",
    CorrectAnswer = "1367",
    Answers = new List<string> { "1150", "1206", "1367", "1458" }
},
new YearQuestion
{
    TetelNumber = 12,
    Question = "Melyik évben alapították az esztergomi egyetemet?",
    CorrectAnswer = "1395",
    Answers = new List<string> { "1367", "1395", "1458", "1467" }
},
new YearQuestion
{
    TetelNumber = 12,
    Question = "Melyik évben alapították a pozsonyi egyetemet?",
    CorrectAnswer = "1467",
    Answers = new List<string> { "1395", "1458", "1467", "1490" }
},
new YearQuestion
{
    TetelNumber = 12,
    Question = "Melyik évben jelent meg Gutenberg 42 soros Bibliája a tétel szerint?",
    CorrectAnswer = "1455",
    Answers = new List<string> { "1395", "1455", "1467", "1492" }
},
new YearQuestion
{
    TetelNumber = 12,
    Question = "Melyik évben érte el csúcspontját a reneszánsz Mátyás uralkodása idején?",
    CorrectAnswer = "1458",
    Answers = new List<string> { "1367", "1395", "1458", "1492" }
},
new YearQuestion
{
    TetelNumber = 12,
    Question = "Melyik stílushoz kötődik a 11–12. század a tétel szerint?",
    CorrectAnswer = "román",
    Answers = new List<string> { "gótikus", "barokk", "román", "reneszánsz" }
},
new YearQuestion
{
    TetelNumber = 12,
    Question = "Melyik stílushoz kötődik a 12–15. század a tétel szerint?",
    CorrectAnswer = "gótikus",
    Answers = new List<string> { "román", "gótikus", "reneszánsz", "barokk" }
},
new YearQuestion
{
    TetelNumber = 12,
    Question = "Melyik stílus bontakozott ki a 14–16. században Itáliában a tétel szerint?",
    CorrectAnswer = "reneszánsz",
    Answers = new List<string> { "román", "gótikus", "reneszánsz", "barokk" }
},
// 10. tétel – extra bővítés
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben kezdődött Géza fejedelem uralkodása a tétel szerint?",
    CorrectAnswer = "972",
    Answers = new List<string> { "895", "955", "972", "997" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évhez kötjük a magyar honfoglalás kezdetét?",
    CorrectAnswer = "895",
    Answers = new List<string> { "895", "907", "955", "972" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben szenvedtek vereséget a magyarok Augsburgnál?",
    CorrectAnswer = "955",
    Answers = new List<string> { "895", "955", "972", "997" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben kezdődött II. András uralkodása?",
    CorrectAnswer = "1205",
    Answers = new List<string> { "1172", "1205", "1217", "1222" }
},
new YearQuestion
{
    TetelNumber = 10,
    Question = "Melyik évben kezdődött IV. Béla uralkodása?",
    CorrectAnswer = "1235",
    Answers = new List<string> { "1222", "1235", "1241", "1242" }
},

// 16. tétel
new YearQuestion
{
    TetelNumber = 16,
    Question = "Melyik évben zajlott a pesti forradalom?",
    CorrectAnswer = "1848",
    Answers = new List<string> { "1831", "1847", "1848", "1849" }
},
new YearQuestion
{
    TetelNumber = 16,
    Question = "Melyik napon győzött vér nélkül a márciusi forradalom Pesten?",
    CorrectAnswer = "1848. március 15.",
    Answers = new List<string> { "1848. március 3.", "1848. március 13.", "1848. március 15.", "1848. április 11." }
},
new YearQuestion
{
    TetelNumber = 16,
    Question = "Melyik napon állt elő Kossuth a felirati javaslattal?",
    CorrectAnswer = "1848. március 3.",
    Answers = new List<string> { "1848. március 3.", "1848. március 13.", "1848. március 15.", "1848. április 11." }
},
new YearQuestion
{
    TetelNumber = 16,
    Question = "Melyik napon robbant ki a bécsi forradalom, amely felgyorsította a magyar eseményeket?",
    CorrectAnswer = "1848. március 13.",
    Answers = new List<string> { "1848. március 4.", "1848. március 11.", "1848. március 13.", "1848. március 15." }
},
new YearQuestion
{
    TetelNumber = 16,
    Question = "Melyik napon szentesítették az áprilisi törvényeket?",
    CorrectAnswer = "1848. április 11.",
    Answers = new List<string> { "1848. március 15.", "1848. április 11.", "1848. július 11.", "1848. szeptember 11." }
},
new YearQuestion
{
    TetelNumber = 16,
    Question = "Melyik évben volt a népképviseleti választás a tétel szerint?",
    CorrectAnswer = "1848 júniusának végén",
    Answers = new List<string> { "1848 márciusában", "1848 áprilisában", "1848 júniusának végén", "1848 szeptemberében" }
},
new YearQuestion
{
    TetelNumber = 16,
    Question = "Melyik napon szavazott meg az országgyűlés Kossuth javaslatára további 200 000 katonát?",
    CorrectAnswer = "1848. július 11.",
    Answers = new List<string> { "1848. április 11.", "1848. június 30.", "1848. július 11.", "1848. szeptember 11." }
},
new YearQuestion
{
    TetelNumber = 16,
    Question = "Melyik napon kapott királyi megerősítést Jellasics?",
    CorrectAnswer = "1848. szeptember 4.",
    Answers = new List<string> { "1848. augusztus 31.", "1848. szeptember 4.", "1848. szeptember 11.", "1848. szeptember 24." }
},
new YearQuestion
{
    TetelNumber = 16,
    Question = "Melyik napon mondott le a Batthyány-kormány a tétel szerint?",
    CorrectAnswer = "1848. szeptember 10.",
    Answers = new List<string> { "1848. szeptember 4.", "1848. szeptember 10.", "1848. szeptember 11.", "1848. szeptember 16." }
},
new YearQuestion
{
    TetelNumber = 16,
    Question = "Melyik napon lépte át Jellasics a Drávát?",
    CorrectAnswer = "1848. szeptember 11.",
    Answers = new List<string> { "1848. szeptember 10.", "1848. szeptember 11.", "1848. szeptember 15.", "1848. szeptember 24." }
},
new YearQuestion
{
    TetelNumber = 16,
    Question = "Melyik napon választották meg az Országos Honvédelmi Bizottmányt ideiglenes végrehajtó hatalomnak?",
    CorrectAnswer = "1848. szeptember 16.",
    Answers = new List<string> { "1848. szeptember 11.", "1848. szeptember 15.", "1848. szeptember 16.", "1848. október 6." }
},
new YearQuestion
{
    TetelNumber = 16,
    Question = "Melyik napon indult Kossuth toborzókörútra az Alföldre?",
    CorrectAnswer = "1848. szeptember 24.",
    Answers = new List<string> { "1848. szeptember 11.", "1848. szeptember 16.", "1848. szeptember 24.", "1848. október 7." }
},
new YearQuestion
{
    TetelNumber = 16,
    Question = "Melyik napon törölték el a szőlődézsmát?",
    CorrectAnswer = "1848. szeptember 15.",
    Answers = new List<string> { "1848. augusztus 31.", "1848. szeptember 4.", "1848. szeptember 15.", "1848. szeptember 24." }
},
new YearQuestion
{
    TetelNumber = 16,
    Question = "Melyik évben jelent meg az Ellenzéki Nyilatkozat, amely már kötelező örökváltságot követelt?",
    CorrectAnswer = "1847",
    Answers = new List<string> { "1831", "1832", "1847", "1848" }
},
new YearQuestion
{
    TetelNumber = 16,
    Question = "Melyik évben zajlott az 1831-es kolerafelkelés, amely ráirányította a figyelmet a jobbágykérdésre?",
    CorrectAnswer = "1831",
    Answers = new List<string> { "1825", "1831", "1832", "1847" }
},
new YearQuestion
{
    TetelNumber = 16,
    Question = "Melyik időszakban került középpontba a jobbágykérdés az országgyűlésen?",
    CorrectAnswer = "1832–36",
    Answers = new List<string> { "1825–27", "1830–31", "1832–36", "1847–48" }
},

// 21. tétel
new YearQuestion
{
    TetelNumber = 21,
    Question = "Melyik században jött létre a kereszténység a Római Birodalomban?",
    CorrectAnswer = "I. század",
    Answers = new List<string> { "Kr. e. I. század", "I. század", "III. század", "V. század" }
},
new YearQuestion
{
    TetelNumber = 21,
    Question = "Melyik időszakban született Jézus Krisztus a tétel szerint?",
    CorrectAnswer = "Augustus principátusa alatt",
    Answers = new List<string> { "Nero uralkodása alatt", "Augustus principátusa alatt", "Constantinus korában", "Theodosius idején" }
},
new YearQuestion
{
    TetelNumber = 21,
    Question = "Melyik évben tette kötelező vallássá Theodosius a kereszténységet a Római Birodalomban?",
    CorrectAnswer = "391",
    Answers = new List<string> { "313", "325", "391", "476" }
},
new YearQuestion
{
    TetelNumber = 21,
    Question = "Melyik évben hirdette ki Constantinus a milánói ediktumot?",
    CorrectAnswer = "313",
    Answers = new List<string> { "1054", "313", "391", "1517" }
},
new YearQuestion
{
    TetelNumber = 21,
    Question = "Melyik évben tartották a niceai zsinatot?",
    CorrectAnswer = "325",
    Answers = new List<string> { "313", "325", "391", "1054" }
},
new YearQuestion
{
    TetelNumber = 21,
    Question = "Melyik évben következett be a nagy egyházszakadás a keleti és nyugati kereszténység között?",
    CorrectAnswer = "1054",
    Answers = new List<string> { "476", "800", "1054", "1096" }
},
new YearQuestion
{
    TetelNumber = 21,
    Question = "Melyik évben lépett fel Luther Márton a 95 tételével?",
    CorrectAnswer = "1517",
    Answers = new List<string> { "1455", "1492", "1517", "1524" }
},
new YearQuestion
{
    TetelNumber = 21,
    Question = "Melyik napon függesztette ki Luther a 95 tételt a wittenbergi vártemplomnál?",
    CorrectAnswer = "1517. október 31.",
    Answers = new List<string> { "1517. október 31.", "1521. január 1.", "1524. május 1.", "1541. július 1." }
},
new YearQuestion
{
    TetelNumber = 21,
    Question = "Melyik évben tört ki a svábföldi parasztfelkelés az anabaptisták radikális elképzeléseihez kapcsolódva?",
    CorrectAnswer = "1524",
    Answers = new List<string> { "1517", "1524", "1525", "1541" }
},
new YearQuestion
{
    TetelNumber = 21,
    Question = "Melyik évben zajlott a frankföldi parasztfelkelés Geyer Flórián vezetésével?",
    CorrectAnswer = "1525",
    Answers = new List<string> { "1524", "1525", "1531", "1545" }
},
// 17. tétel
new YearQuestion
{
    TetelNumber = 17,
    Question = "Melyik évszázadokhoz kapcsolja a tétel a liberalizmus és a nacionalizmus kialakulását?",
    CorrectAnswer = "XVIII–XIX. század",
    Answers = new List<string> { "XVI–XVII. század", "XVII–XVIII. század", "XVIII–XIX. század", "XIX–XX. század" }
},
new YearQuestion
{
    TetelNumber = 17,
    Question = "Melyik évben fogadták el az Amerikai Egyesült Államok alkotmányát?",
    CorrectAnswer = "1787",
    Answers = new List<string> { "1776", "1787", "1789", "1791" }
},
new YearQuestion
{
    TetelNumber = 17,
    Question = "Melyik évben lépett hatályba az USA alkotmánya?",
    CorrectAnswer = "1789",
    Answers = new List<string> { "1776", "1787", "1789", "1791" }
},
new YearQuestion
{
    TetelNumber = 17,
    Question = "Melyik évben fogadták el az amerikai Bill of Rightsot?",
    CorrectAnswer = "1791",
    Answers = new List<string> { "1787", "1789", "1791", "1804" }
},
new YearQuestion
{
    TetelNumber = 17,
    Question = "Melyik évben tört ki a pesti forradalom, amely a magyar polgári átalakulás kezdőpontja volt?",
    CorrectAnswer = "1848",
    Answers = new List<string> { "1830", "1848", "1867", "1871" }
},
new YearQuestion
{
    TetelNumber = 17,
    Question = "Melyik évben jött létre a kiegyezés, amely a magyar alkotmányos rendszer új alapját jelentette?",
    CorrectAnswer = "1867",
    Answers = new List<string> { "1848", "1867", "1871", "1918" }
},
new YearQuestion
{
    TetelNumber = 17,
    Question = "Melyik évben jött létre a Német Császárság, a német nemzetállam egysége?",
    CorrectAnswer = "1871",
    Answers = new List<string> { "1848", "1867", "1871", "1919" }
},
new YearQuestion
{
    TetelNumber = 17,
    Question = "Melyik évben egyesült Olaszország döntő módon, amely a nacionalizmus egyik nagy sikere volt?",
    CorrectAnswer = "1861",
    Answers = new List<string> { "1848", "1861", "1867", "1871" }
},
new YearQuestion
{
    TetelNumber = 17,
    Question = "Melyik évben lépett életbe az Emberi és polgári jogok nyilatkozatát előkészítő francia alkotmány?",
    CorrectAnswer = "1791",
    Answers = new List<string> { "1789", "1791", "1793", "1804" }
},
new YearQuestion
{
    TetelNumber = 17,
    Question = "Melyik évhez kötjük az amerikai Függetlenségi Nyilatkozatot, amely a jogegyenlőség egyik alapdokumentuma?",
    CorrectAnswer = "1776",
    Answers = new List<string> { "1776", "1787", "1789", "1791" }
},

// 18. tétel
new YearQuestion
{
    TetelNumber = 18,
    Question = "Melyik évben beszélt Churchill zürichi beszédében Európai Egyesült Államokról?",
    CorrectAnswer = "1946",
    Answers = new List<string> { "1945", "1946", "1949", "1951" }
},
new YearQuestion
{
    TetelNumber = 18,
    Question = "Melyik év óta működik Strasbourgban az Európa Tanács?",
    CorrectAnswer = "1949",
    Answers = new List<string> { "1946", "1949", "1950", "1957" }
},
new YearQuestion
{
    TetelNumber = 18,
    Question = "Melyik évben lépett be Magyarország az Európa Tanácsba?",
    CorrectAnswer = "1990",
    Answers = new List<string> { "1989", "1990", "1992", "2004" }
},
new YearQuestion
{
    TetelNumber = 18,
    Question = "Melyik évben indult az európai integráció a Schuman-tervvel?",
    CorrectAnswer = "1950",
    Answers = new List<string> { "1949", "1950", "1951", "1957" }
},
new YearQuestion
{
    TetelNumber = 18,
    Question = "Melyik napon terjesztette elő Robert Schuman a megbékélésről és együttműködésről szóló tervét?",
    CorrectAnswer = "1950. május 9.",
    Answers = new List<string> { "1949. május 9.", "1950. május 9.", "1951. április 18.", "1957. március 25." }
},
new YearQuestion
{
    TetelNumber = 18,
    Question = "Melyik évben írták alá az Európai Szén- és Acélközösséget létrehozó szerződést?",
    CorrectAnswer = "1951",
    Answers = new List<string> { "1950", "1951", "1957", "1992" }
},
new YearQuestion
{
    TetelNumber = 18,
    Question = "Melyik évben írták alá a Római Szerződéseket?",
    CorrectAnswer = "1957",
    Answers = new List<string> { "1951", "1957", "1967", "1992" }
},
new YearQuestion
{
    TetelNumber = 18,
    Question = "Melyik évben jött létre az Európai Unió a maastrichti szerződéssel?",
    CorrectAnswer = "1992",
    Answers = new List<string> { "1989", "1990", "1992", "2004" }
},
new YearQuestion
{
    TetelNumber = 18,
    Question = "Melyik évben csatlakozott Magyarország az Európai Unióhoz?",
    CorrectAnswer = "2004",
    Answers = new List<string> { "1990", "1992", "2004", "2007" }
},
new YearQuestion
{
    TetelNumber = 18,
    Question = "Melyik dátumot ünnepeljük Európa-napként?",
    CorrectAnswer = "május 9.",
    Answers = new List<string> { "március 15.", "május 9.", "június 4.", "október 23." }
},

// 19. tétel
new YearQuestion
{
    TetelNumber = 19,
    Question = "Melyik időszakot nevezi a tétel a rendszerváltás időszakának Magyarországon?",
    CorrectAnswer = "1989–1990",
    Answers = new List<string> { "1988–1989", "1989–1990", "1990–1991", "2011–2012" }
},
new YearQuestion
{
    TetelNumber = 19,
    Question = "Mióta tartanak demokratikus választásokat a rendszerváltás után Magyarországon?",
    CorrectAnswer = "1990 óta",
    Answers = new List<string> { "1989 óta", "1990 óta", "1994 óta", "2011 óta" }
},
new YearQuestion
{
    TetelNumber = 19,
    Question = "Melyik évben fogadták el az Alaptörvényt?",
    CorrectAnswer = "2011",
    Answers = new List<string> { "1989", "1990", "2011", "2012" }
},
new YearQuestion
{
    TetelNumber = 19,
    Question = "Melyik évben lépett hatályba az Alaptörvény?",
    CorrectAnswer = "2012",
    Answers = new List<string> { "2010", "2011", "2012", "2014" }
},
new YearQuestion
{
    TetelNumber = 19,
    Question = "Melyik évben született az országgyűlési választásokat szabályozó CCIII. törvény?",
    CorrectAnswer = "2011",
    Answers = new List<string> { "1990", "2010", "2011", "2012" }
},
new YearQuestion
{
    TetelNumber = 19,
    Question = "Hány főre csökkentették az országgyűlési képviselők számát az új választási rendszerben?",
    CorrectAnswer = "199",
    Answers = new List<string> { "176", "199", "386", "400" }
},
new YearQuestion
{
    TetelNumber = 19,
    Question = "Hány fő volt korábban az országgyűlési képviselők száma a tétel szerint?",
    CorrectAnswer = "386",
    Answers = new List<string> { "199", "300", "386", "400" }
},
new YearQuestion
{
    TetelNumber = 19,
    Question = "Milyen hosszú a választási ciklus Magyarországon a tétel szerint?",
    CorrectAnswer = "négyéves",
    Answers = new List<string> { "hároméves", "négyéves", "ötéves", "hatéves" }
},
new YearQuestion
{
    TetelNumber = 19,
    Question = "Mekkora a parlamenti bejutási küszöb a tétel szerint?",
    CorrectAnswer = "5%",
    Answers = new List<string> { "3%", "4%", "5%", "10%" }
},
new YearQuestion
{
    TetelNumber = 19,
    Question = "Melyik évben rögzítette az Alkotmány, majd később az Alaptörvény a modern választójog és jogállam alapjait a tétel szerint?",
    CorrectAnswer = "1989",
    Answers = new List<string> { "1989", "1990", "2011", "2012" }
},

// 20. tétel
new YearQuestion
{
    TetelNumber = 20,
    Question = "Melyik időszakban zajlott az athéni demokrácia kialakulása a tétel szerint?",
    CorrectAnswer = "Kr.e. VII–V. század",
    Answers = new List<string> { "Kr.e. X–VIII. század", "Kr.e. VII–V. század", "Kr.e. V–III. század", "Kr.u. I–II. század" }
},
new YearQuestion
{
    TetelNumber = 20,
    Question = "Melyik évben hajtotta végre Szolón a reformjait Athénban?",
    CorrectAnswer = "Kr.e. 594",
    Answers = new List<string> { "Kr.e. 621", "Kr.e. 594", "Kr.e. 508", "Kr.e. 443" }
},
new YearQuestion
{
    TetelNumber = 20,
    Question = "Melyik évben hajtotta végre Kleiszthenész a reformjait?",
    CorrectAnswer = "Kr.e. 508",
    Answers = new List<string> { "Kr.e. 594", "Kr.e. 508", "Kr.e. 490", "Kr.e. 443" }
},
new YearQuestion
{
    TetelNumber = 20,
    Question = "Melyik időszakra teszi a tétel a periklészi virágkort?",
    CorrectAnswer = "Kr.e. 443–428",
    Answers = new List<string> { "Kr.e. 508–490", "Kr.e. 490–480", "Kr.e. 443–428", "Kr.e. 404–371" }
},
new YearQuestion
{
    TetelNumber = 20,
    Question = "Melyik korban szűkült be fokozatosan a királyság intézménye Athénban?",
    CorrectAnswer = "az archaikus kor kezdetén",
    Answers = new List<string> { "a klasszikus kor végén", "az archaikus kor kezdetén", "a hellenizmus idején", "a római uralom alatt" }
},
new YearQuestion
{
    TetelNumber = 20,
    Question = "Melyik évben lett Caesar élethosszig dictator?",
    CorrectAnswer = "Kr.e. 44",
    Answers = new List<string> { "Kr.e. 49", "Kr.e. 44", "Kr.e. 31", "Kr.e. 27" }
},
new YearQuestion
{
    TetelNumber = 20,
    Question = "Melyik évben lépte át Caesar a Rubicont?",
    CorrectAnswer = "Kr.e. 49",
    Answers = new List<string> { "Kr.e. 60", "Kr.e. 49", "Kr.e. 44", "Kr.e. 31" }
},
new YearQuestion
{
    TetelNumber = 20,
    Question = "Melyik évben győzte le Octavianus Antoniust és Kleopátrát Actiumnál?",
    CorrectAnswer = "Kr.e. 31",
    Answers = new List<string> { "Kr.e. 44", "Kr.e. 31", "Kr.e. 27", "Kr.u. 14" }
},
new YearQuestion
{
    TetelNumber = 20,
    Question = "Melyik évben kapta Octavianus az Augustus nevet, ezzel kezdve a principátust?",
    CorrectAnswer = "Kr.e. 27",
    Answers = new List<string> { "Kr.e. 31", "Kr.e. 27", "Kr.e. 14", "Kr.u. 14" }
},
new YearQuestion
{
    TetelNumber = 20,
    Question = "Melyik évben halt meg Augustus?",
    CorrectAnswer = "Kr.u. 14",
    Answers = new List<string> { "Kr.e. 27", "Kr.e. 14", "Kr.u. 14", "Kr.u. 27" }
},
// 21. tétel – extra bővítés
new YearQuestion
{
    TetelNumber = 21,
    Question = "Melyik császár uralkodása idején halt meg Jézus a tétel szerint?",
    CorrectAnswer = "Tiberius",
    Answers = new List<string> { "Augustus", "Tiberius", "Nero", "Constantinus" }
},
new YearQuestion
{
    TetelNumber = 21,
    Question = "Melyik évben ismerték el teljes jogú egyháztagnak a pogány származású keresztényeket a jeruzsálemi tanácskozáson?",
    CorrectAnswer = "48",
    Answers = new List<string> { "33", "48", "64", "1054" }
},
new YearQuestion
{
    TetelNumber = 21,
    Question = "Melyik időszakra teszi a tétel Jézus születését?",
    CorrectAnswer = "Kr. e. 8–4 között",
    Answers = new List<string> { "Kr. e. 20–10 között", "Kr. e. 8–4 között", "Kr. u. 1–4 között", "Kr. u. 8–12 között" }
},

// 22. tétel
new YearQuestion
{
    TetelNumber = 22,
    Question = "Melyik év körül lépett fel Mohamed új tanokkal Arábiában?",
    CorrectAnswer = "610 táján",
    Answers = new List<string> { "570 táján", "610 táján", "622 táján", "630 táján" }
},
new YearQuestion
{
    TetelNumber = 22,
    Question = "Melyik évben történt a hidzsra, vagyis Mohamed kivonulása Mekkából Medinába?",
    CorrectAnswer = "622",
    Answers = new List<string> { "610", "622", "630", "632" }
},
new YearQuestion
{
    TetelNumber = 22,
    Question = "Melyik év lett a mohamedán időszámítás kezdete?",
    CorrectAnswer = "622",
    Answers = new List<string> { "610", "622", "630", "711" }
},
new YearQuestion
{
    TetelNumber = 22,
    Question = "Melyik évben tért vissza Mohamed katonák élén Mekkába?",
    CorrectAnswer = "630",
    Answers = new List<string> { "622", "630", "632", "711" }
},
new YearQuestion
{
    TetelNumber = 22,
    Question = "Melyik évben halt meg Mohamed?",
    CorrectAnswer = "632",
    Answers = new List<string> { "622", "630", "632", "661" }
},
new YearQuestion
{
    TetelNumber = 22,
    Question = "Melyik évben jutottak át az arabok Gibraltárnál Európába?",
    CorrectAnswer = "711",
    Answers = new List<string> { "622", "630", "711", "732" }
},
new YearQuestion
{
    TetelNumber = 22,
    Question = "Melyik században alakult ki az iszlám a tétel szerint?",
    CorrectAnswer = "VII. század",
    Answers = new List<string> { "V. század", "VI. század", "VII. század", "IX. század" }
},
new YearQuestion
{
    TetelNumber = 22,
    Question = "Melyik évszázadokban jött létre az iszlám az Arab-félszigeten a tétel első összefoglalása szerint?",
    CorrectAnswer = "VII–VIII. század",
    Answers = new List<string> { "V–VI. század", "VI–VII. század", "VII–VIII. század", "VIII–IX. század" }
},
new YearQuestion
{
    TetelNumber = 22,
    Question = "Melyik században jelentkeztek az Arab-félszigeten azok a válságjelenségek, amelyek az iszlám kialakulásának hátterét adták?",
    CorrectAnswer = "VI. század",
    Answers = new List<string> { "V. század", "VI. század", "VII. század", "VIII. század" }
},
new YearQuestion
{
    TetelNumber = 22,
    Question = "Melyik században támadtak az arabok újabb hullámban Európa felé, főként a tengeren?",
    CorrectAnswer = "X. század",
    Answers = new List<string> { "VIII. század", "IX. század", "X. század", "XI. század" }
},
new YearQuestion
{
    TetelNumber = 22,
    Question = "Melyik időszakban élt Mohamed a tétel szerint?",
    CorrectAnswer = "kb. 570–632",
    Answers = new List<string> { "kb. 520–610", "kb. 570–632", "kb. 610–680", "kb. 632–711" }
},

// 23. tétel
new YearQuestion
{
    TetelNumber = 23,
    Question = "Melyik évben tört ki a francia forradalom?",
    CorrectAnswer = "1789",
    Answers = new List<string> { "1776", "1789", "1791", "1792" }
},
new YearQuestion
{
    TetelNumber = 23,
    Question = "Melyik napon zajlott a Bastille ostroma?",
    CorrectAnswer = "1789. július 14.",
    Answers = new List<string> { "1789. július 14.", "1789. augusztus 26.", "1791. szeptember 3.", "1792. szeptember 20." }
},
new YearQuestion
{
    TetelNumber = 23,
    Question = "Melyik napon fogadta el az Alkotmányozó Nemzetgyűlés az Emberi és polgári jogok nyilatkozatát?",
    CorrectAnswer = "1789. augusztus 26.",
    Answers = new List<string> { "1789. július 14.", "1789. augusztus 26.", "1791. szeptember 3.", "1793. január 21." }
},
new YearQuestion
{
    TetelNumber = 23,
    Question = "Melyik év alkotmányát készítette elő az Emberi és polgári jogok nyilatkozata?",
    CorrectAnswer = "1791",
    Answers = new List<string> { "1789", "1791", "1792", "1799" }
},
new YearQuestion
{
    TetelNumber = 23,
    Question = "Melyik évben lett Franciaország alkotmányos királyság a tétel szerint?",
    CorrectAnswer = "1791",
    Answers = new List<string> { "1789", "1791", "1792", "1794" }
},
new YearQuestion
{
    TetelNumber = 23,
    Question = "Melyik évben tört ki a háború Franciaország és a Habsburg Birodalom között?",
    CorrectAnswer = "1792",
    Answers = new List<string> { "1789", "1791", "1792", "1794" }
},
new YearQuestion
{
    TetelNumber = 23,
    Question = "Melyik hónapban kiáltották ki a köztársaságot Franciaországban a tétel szerint?",
    CorrectAnswer = "1792 szeptemberében",
    Answers = new List<string> { "1791 júliusában", "1792 szeptemberében", "1793 januárjában", "1794 júliusában" }
},
new YearQuestion
{
    TetelNumber = 23,
    Question = "Melyik év januárjában végezték ki XVI. Lajost?",
    CorrectAnswer = "1793",
    Answers = new List<string> { "1791", "1792", "1793", "1794" }
},
new YearQuestion
{
    TetelNumber = 23,
    Question = "Melyik időszakban tartott a jakobinus diktatúra?",
    CorrectAnswer = "1793–1794",
    Answers = new List<string> { "1789–1791", "1791–1792", "1793–1794", "1799–1804" }
},
new YearQuestion
{
    TetelNumber = 23,
    Question = "Melyik év júliusában fogták el és végezték ki Robespierre-t?",
    CorrectAnswer = "1794",
    Answers = new List<string> { "1792", "1793", "1794", "1799" }
},
new YearQuestion
{
    TetelNumber = 23,
    Question = "Melyik időszakra esett Napóleon konzulsága?",
    CorrectAnswer = "1799–1804",
    Answers = new List<string> { "1793–1794", "1794–1799", "1799–1804", "1804–1815" }
},
new YearQuestion
{
    TetelNumber = 23,
    Question = "Melyik időszakra esett Napóleon császársága?",
    CorrectAnswer = "1804–1815",
    Answers = new List<string> { "1799–1804", "1804–1815", "1815–1821", "1814–1815" }
},
new YearQuestion
{
    TetelNumber = 23,
    Question = "Melyik években ülésezett a bécsi kongresszus?",
    CorrectAnswer = "1814–1815",
    Answers = new List<string> { "1799–1804", "1804–1815", "1814–1815", "1830–1831" }
},
new YearQuestion
{
    TetelNumber = 23,
    Question = "Melyik évből való az angol Bill of Rights, amelyet a tétel a nyilatkozat egyik előzményeként említ?",
    CorrectAnswer = "1689",
    Answers = new List<string> { "1649", "1689", "1776", "1789" }
},
new YearQuestion
{
    TetelNumber = 23,
    Question = "Melyik évből való az amerikai Függetlenségi Nyilatkozat, amelyet a tétel az Emberi és polgári jogok nyilatkozata előzményeként említ?",
    CorrectAnswer = "1776",
    Answers = new List<string> { "1689", "1776", "1789", "1791" }
},

// 24. tétel
new YearQuestion
{
    TetelNumber = 24,
    Question = "Melyik századokhoz kapcsolja a tétel a liberalizmus és a konzervativizmus keletkezését?",
    CorrectAnswer = "XVIII–XIX. század",
    Answers = new List<string> { "XVII–XVIII. század", "XVIII–XIX. század", "XIX–XX. század", "XX–XXI. század" }
},
new YearQuestion
{
    TetelNumber = 24,
    Question = "Melyik században jelent meg a konzervativizmus ideológiai alapja Edmund Burke nyomán?",
    CorrectAnswer = "a 19. század első felében",
    Answers = new List<string> { "a 18. század közepén", "a 19. század első felében", "a 19. század végén", "a 20. század elején" }
},
new YearQuestion
{
    TetelNumber = 24,
    Question = "Melyik években ülésezett a bécsi kongresszus, amelyet a tétel ókonzervatív fordulatként említ?",
    CorrectAnswer = "1814–1815",
    Answers = new List<string> { "1789–1791", "1799–1804", "1814–1815", "1848–1849" }
},
new YearQuestion
{
    TetelNumber = 24,
    Question = "Melyik század első felében tűzte ki célul a liberalizmus a polgári állam megteremtését a tétel szerint?",
    CorrectAnswer = "a 19. század első felében",
    Answers = new List<string> { "a 18. század első felében", "a 18. század második felében", "a 19. század első felében", "a 20. század elején" }
},
new YearQuestion
{
    TetelNumber = 24,
    Question = "Melyik század első felében bontakozott ki Európában és Amerikában a nacionalizmus a tétel szerint?",
    CorrectAnswer = "a 19. század első felében",
    Answers = new List<string> { "a 18. század közepén", "a 19. század első felében", "a 19. század második felében", "a 20. század elején" }
},

// 26. tétel
new YearQuestion
{
    TetelNumber = 26,
    Question = "Melyik évben dolgozták ki a Dawes-tervet a jóvátételi konferencián?",
    CorrectAnswer = "1923",
    Answers = new List<string> { "1919", "1923", "1924", "1929" }
},
new YearQuestion
{
    TetelNumber = 26,
    Question = "Melyik időszakban kapott Németország milliárdos nagyságrendű hitelt az USA-tól a Dawes-terv alapján?",
    CorrectAnswer = "1924–25",
    Answers = new List<string> { "1920–21", "1923–24", "1924–25", "1929–30" }
},
new YearQuestion
{
    TetelNumber = 26,
    Question = "Melyik évből indult ki az a világgazdasági válság, amely nagyban segítette a diktatúrák megerősödését?",
    CorrectAnswer = "1929",
    Answers = new List<string> { "1923", "1925", "1929", "1933" }
},
new YearQuestion
{
    TetelNumber = 26,
    Question = "Melyik évben került Hitler hatalomra Németországban, ami a náci diktatúra kiépülésének döntő kezdete volt?",
    CorrectAnswer = "1933",
    Answers = new List<string> { "1929", "1933", "1935", "1938" }
},
new YearQuestion
{
    TetelNumber = 26,
    Question = "Melyik időszakot tekintjük a két világháború közötti korszaknak?",
    CorrectAnswer = "1918–1939",
    Answers = new List<string> { "1914–1918", "1918–1939", "1923–1945", "1933–1945" }
},

// 30. tétel
new YearQuestion
{
    TetelNumber = 30,
    Question = "Melyik évekhez köti a tétel a hidegháború és a kétpólusú világrend kezdetét?",
    CorrectAnswer = "1947 / 1948 / 1949",
    Answers = new List<string> { "1945 / 1946 / 1947", "1947 / 1948 / 1949", "1949 / 1950 / 1951", "1953 / 1955 / 1956" }
},
new YearQuestion
{
    TetelNumber = 30,
    Question = "Melyik évben kezdődött meg a szovjet megszállás, ami a kommunista hatalomátvétel kezdete is volt a keleti tömbben?",
    CorrectAnswer = "1945",
    Answers = new List<string> { "1945", "1947", "1949", "1955" }
},
new YearQuestion
{
    TetelNumber = 30,
    Question = "Melyik évhez kötődik a Marshall-segély?",
    CorrectAnswer = "1947",
    Answers = new List<string> { "1945", "1947", "1949", "1951" }
},
new YearQuestion
{
    TetelNumber = 30,
    Question = "Melyik évben alakult meg a Kominform?",
    CorrectAnswer = "1947",
    Answers = new List<string> { "1946", "1947", "1949", "1955" }
},
new YearQuestion
{
    TetelNumber = 30,
    Question = "Melyik évben alakult meg a KGST?",
    CorrectAnswer = "1949",
    Answers = new List<string> { "1947", "1948", "1949", "1955" }
},
new YearQuestion
{
    TetelNumber = 30,
    Question = "Melyik évben alakult meg a Varsói Szerződés?",
    CorrectAnswer = "1955",
    Answers = new List<string> { "1949", "1953", "1955", "1968" }
},
new YearQuestion
{
    TetelNumber = 30,
    Question = "Melyik évben tört ki a kelet-berlini szovjetellenes felkelés?",
    CorrectAnswer = "1953",
    Answers = new List<string> { "1949", "1953", "1955", "1956" }
},
new YearQuestion
{
    TetelNumber = 30,
    Question = "Melyik évben tört ki a poznani felkelés Lengyelországban és a magyar forradalom?",
    CorrectAnswer = "1956",
    Answers = new List<string> { "1953", "1955", "1956", "1968" }
},
new YearQuestion
{
    TetelNumber = 30,
    Question = "Melyik évhez kötjük a prágai tavaszt?",
    CorrectAnswer = "1968",
    Answers = new List<string> { "1956", "1961", "1968", "1981" }
},
new YearQuestion
{
    TetelNumber = 30,
    Question = "Melyik évben vezettek be rendkívüli állapotot Lengyelországban a Szolidaritás ellen?",
    CorrectAnswer = "1981",
    Answers = new List<string> { "1968", "1980", "1981", "1989" }
},
new YearQuestion
{
    TetelNumber = 30,
    Question = "Melyik évben kezdődött országos sztrájkmozgalom Lengyelországban, amelyből kinőtt a Szolidaritás?",
    CorrectAnswer = "1980",
    Answers = new List<string> { "1968", "1980", "1981", "1989" }
},
new YearQuestion
{
    TetelNumber = 30,
    Question = "Melyik évekhez köti a tétel a rendszerváltásokat a szocialista országokban?",
    CorrectAnswer = "1989 / 1990",
    Answers = new List<string> { "1980 / 1981", "1989 / 1990", "1990 / 1991", "1991 / 1992" }
},
new YearQuestion
{
    TetelNumber = 30,
    Question = "Melyik évben omlott össze a Szovjetunió?",
    CorrectAnswer = "1991",
    Answers = new List<string> { "1989", "1990", "1991", "1992" }
},
new YearQuestion
{
    TetelNumber = 30,
    Question = "Melyik tételbeli évszám jelzi a kétpólusú világrend végét a rendszerváltások mellett?",
    CorrectAnswer = "1991",
    Answers = new List<string> { "1981", "1989", "1990", "1991" }
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

        public List<YearQuestion> GetQuestionsForTetel(int tetelNumber)
        {
            return _questions
                .Where(q => q.TetelNumber == tetelNumber)
                .OrderBy(x => Guid.NewGuid())
                .ToList();
        }
    }
}