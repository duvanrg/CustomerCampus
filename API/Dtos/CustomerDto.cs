using System;
using System.Collections.Generic;

namespace API.Dtos;

public class CustomerDto : BaseDto
{
    public string Name { get; set; } = null!;

    public string Idcustomer { get; set; } = null!;

    public int IdTipoPersonaFk { get; set; }

    public int IdcityFk { get; set; }
}
