using Newtonsoft.Json;
using Weather.Data.Net.ProofOfConcepts;

namespace Weather.Data.Proof;

public class ProofOfConcept
{
    public Task<object> GetTemp()
    {
        var result = GetGeo();
        var temps = new Temps();
        var result2 = temps.GetTemps(result.Result.Lat.ToString(), result.Result.Lon.ToString(), "minutely,hourly,daily", "55ec0655c33712c33cfab679a061d8c3");
        return result2;
    }
    
    
    public async Task<Temperatures?> GetGeo()
    {
        var geo = new Geo();
        var result = await geo.GetGeoDataFirstExampleAsync("London", "England", "UK", 4, "55ec0655c33712c33cfab679a061d8c3");

        var values = result;

        var valuess = values
            .Where(x => x.Country == "GB")
            .Where(x => x.Name == "London")
            .FirstOrDefault();
    
        return valuess;
    }
}