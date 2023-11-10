using System;
using System.Collections.Generic;

namespace API.Dtos;

public class StateDto : BaseDto
{
    public string Name { get; set; }

    public int IdcountryFk { get; set; }
}
