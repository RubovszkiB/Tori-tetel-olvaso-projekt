using TetelekOlvaso.Models;

namespace TetelekOlvaso.Services
{
    public class TetelTitleService
    {
        private readonly List<TetelListItem> _tetels = new()
        {
            new TetelListItem { Order = 1, Title = "Gazdaság és gazdasági szereplők a középkori Európában" },
            new TetelListItem { Order = 2, Title = "A középkori magyar állam gazdasága és a királyi jövedelmek" },
            new TetelListItem { Order = 3, Title = "Az 1929–1933-as világgazdasági válság és az európai integráció kezdetei" },
            new TetelListItem { Order = 4, Title = "Magyarország gazdasága 1867-től napjainkig" },
            new TetelListItem { Order = 5, Title = "Az Erdélyi Fejedelemség a 16–17. században" },
            new TetelListItem { Order = 6, Title = "A Magyar Királyság népessége és társadalma a 18. században" },
            new TetelListItem { Order = 7, Title = "Az ipari forradalom kibontakozása és jellemzői" },
            new TetelListItem { Order = 8, Title = "Társadalmi, életmódbeli és kulturális változások Magyarországon a 20. század második felében" },
            new TetelListItem { Order = 9, Title = "A határon túli magyarok, a magyarországi nemzetiségek és a cigányság helyzete napjainkban" },
            new TetelListItem { Order = 10, Title = "A magyar nép eredete, vándorlása és az államalapítás" },
            new TetelListItem { Order = 11, Title = "A rendi állam kialakulása és működése Magyarországon" },
            new TetelListItem { Order = 12, Title = "A középkori kultúra és művelődés" },
            new TetelListItem { Order = 13, Title = "Rendi küzdelmek, Habsburg-ellenes harcok és a felvilágosult abszolutizmus" },
            new TetelListItem { Order = 14, Title = "A felvilágosodás főbb eszméi és képviselői" },
            new TetelListItem { Order = 15, Title = "Az angol alkotmányos fejlődés és az amerikai alkotmányosság" },
            new TetelListItem { Order = 16, Title = "A reformkor, az 1848-as forradalom és szabadságharc" },
            new TetelListItem { Order = 17, Title = "Polgári nemzetállamok és az alkotmányosság kialakulása" },
            new TetelListItem { Order = 18, Title = "Az európai integráció története" },
            new TetelListItem { Order = 19, Title = "A mai magyar államszervezet és működése" },
            new TetelListItem { Order = 20, Title = "Az athéni demokrácia és a római államberendezkedés változásai" },
            new TetelListItem { Order = 21, Title = "A kereszténység kialakulása és a reformáció" },
            new TetelListItem { Order = 22, Title = "Az iszlám vallás kialakulása és az arab hódítás" },
            new TetelListItem { Order = 23, Title = "A francia forradalom és Napóleon kora" },
            new TetelListItem { Order = 24, Title = "A 19. század politikai eszméi" },
            new TetelListItem { Order = 25, Title = "Politikai eszmék és pártrendszer a dualizmus kori Magyarországon" },
            new TetelListItem { Order = 26, Title = "Diktatúrák a két világháború között" },
            new TetelListItem { Order = 27, Title = "Törökellenes harcok Magyarországon" },
            new TetelListItem { Order = 28, Title = "Az első világháború" },
            new TetelListItem { Order = 29, Title = "A második világháború" },
            new TetelListItem { Order = 30, Title = "A kétpólusú világrend" }
        };

        public List<TetelListItem> GetTetelsByNumbers(List<int> numbers)
        {
            return _tetels
                .Where(t => numbers.Contains(t.Order))
                .OrderBy(t => t.Order)
                .ToList();
        }

        public string GetTitleByNumber(int order)
        {
            return _tetels.FirstOrDefault(t => t.Order == order)?.Title ?? $"Tétel {order}";
        }
    }
}