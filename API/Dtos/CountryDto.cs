using System;
using System.Collections.Generic;

namespace API.Dtos;

public class CountryDto : BaseDto
{

    public string Name { get; set; }

    public List<StateLstCitiesDto> States { get; set; }
}
