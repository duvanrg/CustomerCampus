using System;
using System.Collections.Generic;

namespace API.Dtos;

public class CityDto : BaseDto
{
    public string Name { get; set; } = null!;

    public int IdstateFk { get; set; }
}
