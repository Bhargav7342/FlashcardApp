using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class FlashcardDetail
{
    public Guid Id { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }
}
