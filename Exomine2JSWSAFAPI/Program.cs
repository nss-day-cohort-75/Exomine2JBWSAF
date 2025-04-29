using Exomine2JSWSAFAPI.Models;
using Exomine2JSWSAFAPI.Models.DTOs;

List<Governor> governors = new List<Governor>
{
    new Governor
    {
        Id = 1,
        Name = "Glorb Harrington",
        IsActive = true,
        ColonyId = 1
    },
    new Governor
    {
        Id = 2,
        Name = "Margaret Thompson",
        IsActive = true,
        ColonyId = 2
    },
    new Governor
    {
        Id = 3,
        Name = "Zilliam Starr",
        IsActive = true,
        ColonyId = 3
    },
    new Governor
    {
        Id = 4,
        Name = "Lazer Razor",
        IsActive = false,
        ColonyId = 4
    },
    new Governor
    {
        Id = 5,
        Name = "Nova Thorne",
        IsActive = true,
        ColonyId = 5
    },
    new Governor
    {
        Id = 6,
        Name = "Ham Sammich",
        IsActive = true,
        ColonyId = 3
    },
    new Governor
    {
        Id = 7,
        Name = "Xena Warrior-Princess",
        IsActive = true,
        ColonyId = 4
    },
    new Governor
    {
        Id = 8,
        Name = "Krater Rubble",
        IsActive = true,
        ColonyId = 5
    }
};
List<Colony> colonies = new List<Colony>
{
    new Colony
    {
        Id = 1,
        Name = "Nova Prime"
    },
    new Colony
    {
        Id = 2,
        Name = "Kepler Outpost"
    },
    new Colony
    {
        Id = 3,
        Name = "Titan Haven"
    },
    new Colony
    {
        Id = 4,
        Name = "Andromeda Station"
    },
    new Colony
    {
        Id = 5,
        Name = "Orion's Reach"
    }
};
List<ColonyMineral> colonyMinerals = new List<ColonyMineral>
{
    new ColonyMineral
    {
        Id = 1,
        ColonyId = 1,
        MineralId = 1,
        Quantity = 503
    },
    new ColonyMineral
    {
        Id = 2,
        ColonyId = 2,
        MineralId = 2,
        Quantity = 753
    },
    new ColonyMineral
    {
        Id = 3,
        ColonyId = 3,
        MineralId = 3,
        Quantity = 1201
    },
    new ColonyMineral
    {
        Id = 4,
        ColonyId = 4,
        MineralId = 4,
        Quantity = 450
    },
    new ColonyMineral
    {
        Id = 5,
        ColonyId = 5,
        MineralId = 5,
        Quantity = 906
    },
    new ColonyMineral
    {
        Id = 6,
        ColonyId = 2,
        MineralId = 4,
        Quantity = 750
    },
    new ColonyMineral
    {
        Id = 7,
        ColonyId = 3,
        MineralId = 2,
        Quantity = 1201
    },
    new ColonyMineral
    {
        Id = 8,
        ColonyId = 4,
        MineralId = 3,
        Quantity = 451
    },
    new ColonyMineral
    {
        Id = 9,
        ColonyId = 1,
        MineralId = 5,
        Quantity = 4
    },
    new ColonyMineral
    {
        Id = 10,
        ColonyId = 2,
        MineralId = 3,
        Quantity = 7
    },
    new ColonyMineral
    {
        Id = 11,
        ColonyId = 2,
        MineralId = 1,
        Quantity = 1
    },
    new ColonyMineral
    {
        Id = 12,
        ColonyId = 2,
        MineralId = 5,
        Quantity = 1
    },
    new ColonyMineral
    {
        Id = 13,
        ColonyId = 4,
        MineralId = 5,
        Quantity = 1
    },
    new ColonyMineral
    {
        Id = 14,
        ColonyId = 3,
        MineralId = 5,
        Quantity = 2
    },
    new ColonyMineral
    {
        Id = 15,
        ColonyId = 5,
        MineralId = 3,
        Quantity = 2
    }
};
List<Mineral> minerals = new List<Mineral>
{
    new Mineral
    {
        Id = 1,
        Name = "Xenorite"
    },
    new Mineral
    {
        Id = 2,
        Name = "Voidium"
    },
    new Mineral
    {
        Id = 3,
        Name = "Nebulite"
    },
    new Mineral
    {
        Id = 4,
        Name = "Quantium Shardium"
    },
    new Mineral
    {
        Id = 5,
        Name = "Darkstar Ore"
    }
};
List<FacilityMineral> facilityMinerals = new List<FacilityMineral>
{
    new FacilityMineral
    {
        Id = 1,
        FacilityId = 1,
        MineralId = 1,
        Quantity = 98
    },
    new FacilityMineral
    {
        Id = 2,
        FacilityId = 2,
        MineralId = 2,
        Quantity = 107
    },
    new FacilityMineral
    {
        Id = 3,
        FacilityId = 3,
        MineralId = 3,
        Quantity = 148
    },
    new FacilityMineral
    {
        Id = 4,
        FacilityId = 4,
        MineralId = 4,
        Quantity = 62
    },
    new FacilityMineral
    {
        Id = 5,
        FacilityId = 5,
        MineralId = 5,
        Quantity = 593
    },
    new FacilityMineral
    {
        Id = 6,
        FacilityId = 4,
        MineralId = 1,
        Quantity = 99
    },
    new FacilityMineral
    {
        Id = 7,
        FacilityId = 3,
        MineralId = 2,
        Quantity = 102
    },
    new FacilityMineral
    {
        Id = 8,
        FacilityId = 5,
        MineralId = 3,
        Quantity = 159
    },
    new FacilityMineral
    {
        Id = 9,
        FacilityId = 2,
        MineralId = 4,
        Quantity = 62
    },
    new FacilityMineral
    {
        Id = 10,
        FacilityId = 1,
        MineralId = 5,
        Quantity = 591
    },
};
List<Facility> facilities = new List<Facility>
{
    new Facility
    {
        Id = 1,
        Name = "Celestial Excavation Hub",
        IsActive = true
    },
    new Facility
    {
        Id = 2,
        Name = "Nebula Core Refinery",
        IsActive = false
    },
    new Facility
    {
        Id = 3,
        Name = "Titan Deep Drills",
        IsActive =true
    },
    new Facility
    {
        Id = 4,
        Name = "Eclipse Ore Extractors",
        IsActive = false
    },
    new Facility
    {
        Id = 5,
        Name = "Quantum Harvest Station",
        IsActive = true
    }
};
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//START ALL ENDPOINTS

app.MapGet("/colonyMinerals", () =>
{
    return colonyMinerals.Select(cm => new ColonyMineralDTO
    {
        Id = cm.Id,
        ColonyId = cm.ColonyId,
        MineralId = cm.MineralId,
        Quantity = cm.Quantity,
        Colony = colonies.FirstOrDefault(c => c.Id == cm.ColonyId),
        Mineral = minerals.FirstOrDefault(m => m.Id == cm.MineralId)
    });
});

app.MapGet("/colonyMinerals/{id}", (int id) =>
{
    ColonyMineral colonyMineral = colonyMinerals.FirstOrDefault(cm => cm.Id == id);
    if (colonyMineral == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(new ColonyMineralDTO
    {
        Id = colonyMineral.Id,
        ColonyId = colonyMineral.ColonyId,
        MineralId = colonyMineral.MineralId,
        Quantity = colonyMineral.Quantity,
        Colony = colonies.FirstOrDefault(c => c.Id == colonyMineral.ColonyId),
        Mineral = minerals.FirstOrDefault(m => m.Id == colonyMineral.MineralId)
    });
});
// Get all governors
app.MapGet("/governors", () =>
{
    var governorDTOs = governors.Select(governor => new GovernorDTO
    {
        Id = governor.Id,
        Name = governor.Name,
        IsActive = governor.IsActive,
        ColonyId = governor.ColonyId
    });

    return Results.Ok(governorDTOs);
});

// Get all colonies
app.MapGet("/colonies", () =>
{
    var colonyDTOs = colonies.Select(colony => new ColonyDTO
    {
        Id = colony.Id,
        Name = colony.Name
    });

    return Results.Ok(colonyDTOs);
});
app.MapGet("/facilities", () =>
{
    return facilities.Select(f => new FacilityDTO
    {
        Id = f.Id,
        Name = f.Name,
        IsActive = f.IsActive
    });
});

app.MapGet("/facilities/{id}", (int id) =>
{
    Facility facility = facilities.FirstOrDefault(f => f.Id == id);
    if (facility == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(new FacilityDTO
    {
        Id = facility.Id,
        Name = facility.Name,
        IsActive = facility.IsActive
    });
});
// get all minerals
app.MapGet("/minerals", () =>
{
    var mineralDTOs = minerals.Select(mineral => new MineralDTO
    {
        Id = mineral.Id,
        Name = mineral.Name
    });

    return Results.Ok(mineralDTOs);
});
// Get all facility minerals with expanded mineral and facility data
app.MapGet("/facilityMinerals", () =>
{
    var facilityMineralDTOs = facilityMinerals.Select(facilityMineral => new FacilityMineralDTO
    {
        Id = facilityMineral.Id,
        Quantity = facilityMineral.Quantity,
        MineralId = facilityMineral.MineralId,
        FacilityId = facilityMineral.FacilityId,
        Facility = facilities.FirstOrDefault(f => f.Id == facilityMineral.FacilityId),
        Mineral = minerals.FirstOrDefault(m => m.Id == facilityMineral.MineralId)
    });

    return Results.Ok(facilityMineralDTOs);
});
// get single facility mineral by ID with expanded mineral

app.MapGet("/facilityMinerals/{id}", (int id) =>
{
    FacilityMineral facilityMineral = facilityMinerals.FirstOrDefault(fm => fm.Id == id);
    if (facilityMineral == null)
    {
        return Results.NotFound();
    }
    FacilityMineralDTO facilityMineralData = new FacilityMineralDTO
    {
        Id = facilityMineral.Id,
        Quantity = facilityMineral.Quantity,
        FacilityId = facilityMineral.FacilityId,
        MineralId = facilityMineral.MineralId,
        Facility = facilities.FirstOrDefault(f => f.Id == facilityMineral.FacilityId),
        Mineral = minerals.FirstOrDefault(m => m.Id == facilityMineral.MineralId)
    };
    return Results.Ok(facilityMineralData);
});

// updating facility mineral (decreasing after purchase)
app.MapPut("/facilityMinerals/{id}", (int id, int amountPurchased) =>
{
    FacilityMineral facilityMineral = facilityMinerals.FirstOrDefault(fm => fm.Id == id);
    if (facilityMineral == null)
    {
        return Results.NotFound();
    }
    if (amountPurchased > facilityMineral.Quantity) // checks amount trying to purchase greater than total amount
    {
        return Results.BadRequest();
    }
    facilityMineral.Quantity = facilityMineral.Quantity - amountPurchased;

    FacilityMineralDTO updatedDTO = new FacilityMineralDTO
    {
        Id = facilityMineral.Id,
        Quantity = facilityMineral.Quantity,
        FacilityId = facilityMineral.FacilityId,
        MineralId = facilityMineral.MineralId,
        Facility = facilities.FirstOrDefault(f => f.Id == facilityMineral.FacilityId),
        Mineral = minerals.FirstOrDefault(m => m.Id == facilityMineral.MineralId)
    };
    return Results.Ok(updatedDTO);



});


app.MapPost("/colonyMinerals", (ColonyMineral colonyMineral)=>
{
     var existing = colonyMinerals.FirstOrDefault(cm =>
        cm.ColonyId == colonyMineral.ColonyId &&
        cm.MineralId == colonyMineral.MineralId);

    if (existing != null)
    {
        
        return Results.Conflict($"ColonyMineral with ColonyId {colonyMineral.ColonyId} and MineralId {colonyMineral.MineralId} already exists.");
    }
    colonyMineral.Id = colonyMinerals.Max( cm => cm.Id) + 1;
    colonyMinerals.Add(colonyMineral);

    return Results.Created($"/colonyMinerals/{colonyMineral.Id}", new ColonyMineralDTO
    {
        Id = colonyMineral.Id,
        ColonyId = colonyMineral.ColonyId,
        MineralId = colonyMineral.MineralId,
        Quantity = colonyMineral.Quantity
    });
});

app.MapPut("/colonyMinerals/{id}",(int id, ColonyMineral colonyMineral)=>
{
    ColonyMineral colonyMineralToUpdate = colonyMinerals.FirstOrDefault(cm => cm.Id == id);
});

app.Run();
