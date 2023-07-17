using Newtonsoft.Json;
using Weather.Data.Net.ProofOfConcepts;
using Weather.Data.Net.Providers.WeatherApi;

namespace Weather.Data.Proof;

public class ProofOfConceptV2
{
    public Task<TemperaturesResponseModel> GetTemp()
    {
        var result = new ApiCom("https://api.weatherapi.com/v1", "8663e373364c40f7971133602231607").GetCurrent("London", true, true);
        return result;
    }
    
    

}