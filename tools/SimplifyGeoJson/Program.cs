global using Newtonsoft.Json;
global using Newtonsoft.Json.Serialization;
global using Microsoft.International.Converters.TraditionalChineseToSimplifiedConverter;

const string SOURCE_DIR = @"D:\";
const string INPUT_JSON_FILE_NAME = "ne_110m_admin_0_countries.geo.json";
const string OUTPUT_JSON_FILE_NAME = "world.zh.json";

var input = File.ReadAllText(Path.Combine(SOURCE_DIR, INPUT_JSON_FILE_NAME));
var geo = JsonConvert.DeserializeObject<GeoJsonModel>(input);

foreach (var feature in geo.Features)
{
    if (string.IsNullOrWhiteSpace(feature.Properties.Name))
    {
        throw new Exception("'name' is null or white space");
    }

    var traditional = feature.Properties.Name;
    feature.Properties.Name = ChineseConverter.Convert(traditional, ChineseConversionDirection.TraditionalToSimplified);

    Console.WriteLine($"{traditional} => {feature.Properties.Name}");
}

var output = JsonConvert.SerializeObject(geo, new JsonSerializerSettings()
{
    //Formatting = Formatting.Indented,
    ContractResolver = new DefaultContractResolver
    {
        NamingStrategy = new SnakeCaseNamingStrategy()
    }
});
File.WriteAllText(Path.Combine(SOURCE_DIR, OUTPUT_JSON_FILE_NAME), output);

Console.WriteLine("End");