using ReportGeneratorLibrary;

List<Dictionary<string, string>> data = new()
{
    new Dictionary<string, string>
    {
        { "Nome", "Alice" },
        { "Idade", "30" },
        { "Cidade", "São Paulo" },
    },
    new Dictionary<string, string>
    {
        { "Nome", "Roberto" },
        { "Idade", "25" },
        { "Cidade", "Salvador" },
    },
    new Dictionary<string, string>
    {
        { "Nome", "Carlos" },
        { "Idade", "35" },
        { "Cidade", "Rio de Janeiro" }
    }
};


ReportGenerator reportGenerator = new ReportGenerator(data);
var caminhoDoArquivo = reportGenerator.GenerateReport();
Console.WriteLine($"O relatório foi gerado em: {caminhoDoArquivo}");