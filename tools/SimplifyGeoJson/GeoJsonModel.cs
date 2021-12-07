class GeoJsonModel
{
    public string Type { get; set; }

    public IEnumerable<Feature> Features { get; set; }
}

class Feature
{
    public string Type { get; set; }

    public Properties Properties { get; set; }

    public object Geometry { get; set; }
}

class Properties
{
    private string _name;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    [JsonProperty("name_zh")]
    public string? NameZh
    {
        set => _name = value;
    }

    [JsonProperty("iso_a2")]
    public string IsoA2 { get; set; }

    [JsonProperty("iso_a3")]
    public string IsoA3 { get; set; }

    [JsonProperty("iso_n3")]
    public string IsoN3 { get; set; }
}