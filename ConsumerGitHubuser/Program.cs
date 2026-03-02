using static System.Console;
using System.Text.Json;

WriteLine("Digite um número de um perfil no github ");
string num = ReadLine();

string url = $"https://api.github.com/user/{num}";
WriteLine($"Consultando o CEP: {num}.......");

try
{
    using var client = new HttpClient();
    var response = await client.GetAsync(url);
    response.EnsureSuccessStatusCode();

    var content = await response.Content.ReadAsStringAsync();
    var perfil = JsonSerializer.Deserialize<>(content);

    if (perfil != null)
    {
        WriteLine($"Empres: {Perfil.Company}");
        WriteLine($"Localidade: {Perfil.Location}");
        WriteLine($"Nome: {Perfil.Name}");
        WriteLine($"Login: {Perfil.Login}");
    }
    else
    {
        WriteLine("Perfil não encontrado :c");
    }

}
catch (Exception ex)
{
    WriteLine($"Erro ao consultar o Perfil: {ex.Message}");
}


