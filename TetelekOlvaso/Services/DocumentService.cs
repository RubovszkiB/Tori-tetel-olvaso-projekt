using DocumentFormat.OpenXml.Packaging;
using TetelekOlvaso.Models;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using WParagraph = DocumentFormat.OpenXml.Wordprocessing.Paragraph;
using WText = DocumentFormat.OpenXml.Wordprocessing.Text;

namespace TetelekOlvaso.Services
{
    public class DocumentService
    {
        private readonly Dictionary<int, string> _titles = new()
        {
            { 1, "A mezőgazdaság és az ipari termelés keretei és a kereskedelem a középkorban és a kora újkorban" },
            { 2, "Magyarország gazdasága a XIV-XV. század" },
            { 3, "A világgazdaság a 20-21. században" },
            { 4, "Magyarország gazdasága 1867-től napjainkig" },
            { 5, "Erdélyi Fejedelemség a 16-17. században" },
            { 6, "Demográfiai és etnikai változások Magyarországon" },
            { 7, "Az ipari forradalmak társadalmi hatásai" },
            { 8, "Életmód és mindennapok Magyarországon a 20. században" },
            { 9, "A határon túli magyarok, a magyarországi nemzetiségek és a cigányság helyzete" },
            { 10, "A magyarság és Magyarország története a XIV. század elejéig" },
            { 11, "Rendi fejlődés Magyarországon" },
            { 12, "Középkori kultúra" },
            { 13, "Rendi és abszolutista törekvések Magyarországon" },
            { 14, "Az emberi jogok és a jogegyenlőség elve" },
            { 15, "A modern demokráciák XVII-XVIII. századi gyökerei" },
            { 16, "A reformkor, a forradalom és a szabadságharc" },
            { 17, "A polgári nemzetállam jellemzői, alkotmányosság és jogegyenlőség" },
            { 18, "Az EU és Magyarország az EU-ban" },
            { 19, "A mai Magyarország politikai intézményrendszere és választási rendszere" },
            { 20, "Ókori államberendezkedések" },
            { 21, "A kereszténység története" },
            { 22, "Az iszlám vallás és az arab hódítás" },
            { 23, "A francia forradalom és következményei" },
            { 24, "A XIX. század eszméi" },
            { 25, "Politikai eszmék és pártrendszerek a dualizmus kori Magyarországon" },
            { 26, "A két világháború közötti diktatúrák" },
            { 27, "Magyar-török küzdelmek a 15-17. században" },
            { 28, "Az első világháború és következményei" },
            { 29, "A második világháború" },
            { 30, "A kétpólusú világrend jellemzői" }
        };

        public Task<List<DocumentItem>> LoadDocumentsAsync()
        {
            var documents = new List<DocumentItem>();

            foreach (var pair in _titles.OrderBy(x => x.Key))
            {
                documents.Add(new DocumentItem
                {
                    Order = pair.Key,
                    Title = pair.Value,
                    FileName = $"{pair.Key}.docx"
                });
            }

            return Task.FromResult(documents);
        }

        public async Task<string> ReadDocumentContentAsync(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var assemblyName = assembly.GetName().Name ?? "TetelekOlvaso";
            var resourceName = $"{assemblyName}.Assets.Docs.{fileName}";

            await using var resourceStream = assembly.GetManifestResourceStream(resourceName);

            if (resourceStream == null)
                return "Nem sikerült betölteni a dokumentumot.";

            using var memoryStream = new MemoryStream();
            await resourceStream.CopyToAsync(memoryStream);
            memoryStream.Position = 0;

            using var document = WordprocessingDocument.Open(memoryStream, false);
            var body = document.MainDocumentPart?.Document.Body;

            if (body == null)
                return "A dokumentum üres.";

            var sb = new StringBuilder();

            foreach (var paragraph in body.Elements<WParagraph>())
            {
                var text = string.Concat(paragraph.Descendants<WText>().Select(t => t.Text)).Trim();

                if (!string.IsNullOrWhiteSpace(text))
                {
                    sb.AppendLine(text);
                    sb.AppendLine();
                }
            }

            var result = sb.ToString().Trim();

            return string.IsNullOrWhiteSpace(result)
                ? "Nem található olvasható szöveg a dokumentumban."
                : result;
        }
    }
}