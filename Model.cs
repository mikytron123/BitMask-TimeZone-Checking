using System.ComponentModel.DataAnnotations;

public class CityModel
{
    [Required]
    [Range(-12,12)]
    public int Offset { get; set; }

    public List<string> Cities = new List<string>(){
        "Moscow: GMT +3",
 "Paris: GMT +2",
 "Berlin: GMT +2",
 "Brussels: GMT +2",
 "Amsterdam: GMT +2",
 "Rome: GMT +2",
 "London: GMT +1",
 "Dublin: GMT +1",
 "New York: GMT -4",
 "Washington, DC: GMT -4",
 "St. Louis: GMT -5",
 "Los Angeles: GMT -7",
 "Tokyo: GMT +9",
 "Beijing: GMT +8",
 "Ho Chi Mihn City: GMT +7",
 "Mumbai: GMT +5"
    };
    public Dictionary<string,int> CityDict = new Dictionary<string, int>{
    { "Moscow", 3 },
    { "Paris", 2 },
    { "Berlin", 2 },
    { "Brussels", 2  },
    {  "Amsterdam", 2  },
    { "Rome", 2   },
    { "London",1   },
    { "Dublin", 1   },
    { "New York", -4   },
    { "Washington, DC", -4   },
    { "St. Louis", -5   },
    { "Los Angeles", -7   },
    { "Tokyo", 9   },
    { "Beijing", 8   },
    { "Ho Chi Mihn City", 7 },
    { "Mumbai", 5   }
    };
    
}