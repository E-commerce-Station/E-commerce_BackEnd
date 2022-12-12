using System;

namespace Ecommerce.Examples.Dtos;

[Serializable]
public class CreateUpdateExampleDto
{
    public string Name { get; set; }

    public string Note { get; set; }
}