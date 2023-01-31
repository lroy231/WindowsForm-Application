
public class Root5Day
{
    public string cod { get; set; }
    public int message { get; set; }
    public int cnt { get; set; }
    public List[] list { get; set; }
    public City city { get; set; }
}

public class City
{
    public int id { get; set; }
    public string name { get; set; }
    public Coord coord { get; set; }
    public string country { get; set; }
    public int population { get; set; }
    public int timezone { get; set; }
    public int sunrise { get; set; }
    public int sunset { get; set; }
}


public class List
{
    public int dt { get; set; }
    public Main5day main { get; set; }
    public Weather5day[] weather { get; set; }
    public Clouds clouds { get; set; }
    public int visibility { get; set; }
    public float pop { get; set; }
    public Sys5day sys { get; set; }
    public string dt_txt { get; set; }
    public Rain rain { get; set; }
}

public class Main5day
{
    public float temp { get; set; }
    public float feels_like { get; set; }
    public float temp_min { get; set; }
    public float temp_max { get; set; }
    public int pressure { get; set; }
    public int sea_level { get; set; }
    public int grnd_level { get; set; }
    public int humidity { get; set; }
    public float temp_kf { get; set; }
}

public class Clouds5day
{
    public int all { get; set; }
}


public class Sys5day
{
    public string pod { get; set; }
}

public class Rain
{
    public float _3h { get; set; }
}

public class Weather5day
{
    public int id { get; set; }
    public string main { get; set; }
    public string description { get; set; }
    public string icon { get; set; }
}
