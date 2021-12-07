record GeoJsonModel
{
    public string Type { get; init; }

    public IEnumerable<Feature> Features { get; init; }
}

record Feature
{
    public string Type { get; init; }

    public Properties Properties { get; init; }

    public object Geometry { get; init; }
}

record Properties
{
    private string _name;

    public string Name
    {
        get => _name;
    }

    [JsonProperty("name_zh")]
    public string? NameZh
    {
        init => _name = value;
    }

    [JsonProperty("iso_a2")]
    public string IsoA2 { get; init; }

    [JsonProperty("iso_a3")]
    public string IsoA3 { get; init; }

    [JsonProperty("iso_n3")]
    public string IsoN3 { get; init; }
}