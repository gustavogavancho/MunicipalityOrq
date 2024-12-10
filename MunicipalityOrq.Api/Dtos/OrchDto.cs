using MunicipalityOrq.Api.Models;
using System.Text.Json.Serialization;

namespace MunicipalityOrq.Api.Dtos;

public class OrchDto
{
    [JsonPropertyName("municipioid")] public int Id { get; set; }
    [JsonPropertyName("Geografia")] public MunicipalityGeoDto GeoData { get; set; }
    [JsonPropertyName("Clima")] public MunicipalityWeatherResponse WeatherData { get; set; }
}