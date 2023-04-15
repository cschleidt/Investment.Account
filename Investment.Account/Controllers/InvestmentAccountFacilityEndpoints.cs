using Microsoft.EntityFrameworkCore;
using Investment.Account.Models;
using Investment.Account.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;

namespace Investment.Account.Controllers;

public static class InvestmentAccountFacilityEndpoints
{
    public static void MapInvestmentAccountFacilityEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/InvestmentAccountFacility").WithTags(nameof(InvestmentAccountFacility));

        group.MapGet("/", async (InvestmentAccountContext db) =>
        {
            return await db.InvestmentAccount.ToListAsync();
        })
        .WithName("GetAllInvestmentAccountFacilitys")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<InvestmentAccountFacility>, NotFound>> (string investmentaccountnumber, InvestmentAccountContext db) =>
        {
            return await db.InvestmentAccount.AsNoTracking()
                .FirstOrDefaultAsync(model => model.InvestmentAccountNumber == investmentaccountnumber)
                is InvestmentAccountFacility model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetInvestmentAccountFacilityById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (string investmentaccountnumber, InvestmentAccountFacility investmentAccountFacility, InvestmentAccountContext db) =>
        {
            var affected = await db.InvestmentAccount
                .Where(model => model.InvestmentAccountNumber == investmentaccountnumber)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.ProductInstanceReference, investmentAccountFacility.ProductInstanceReference)
                  .SetProperty(m => m.InvestmentAccountNumber, investmentAccountFacility.InvestmentAccountNumber)
                  .SetProperty(m => m.CustomerReference, investmentAccountFacility.CustomerReference)
                  .SetProperty(m => m.InvestmentAccountType, investmentAccountFacility.InvestmentAccountType)
                  .SetProperty(m => m.InstrumentPositionHolding, investmentAccountFacility.InstrumentPositionHolding)
                  .SetProperty(m => m.DateType, investmentAccountFacility.DateType)
                  .SetProperty(m => m.Date, investmentAccountFacility.Date)
                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateInvestmentAccountFacility")
        .WithOpenApi();

        group.MapPost("/", async (InvestmentAccountFacility investmentAccountFacility, InvestmentAccountContext db) =>
        {
            db.InvestmentAccount.Add(investmentAccountFacility);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/InvestmentAccountFacility/{investmentAccountFacility.InvestmentAccountNumber}",investmentAccountFacility);
        })
        .WithName("CreateInvestmentAccountFacility")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (string investmentaccountnumber, InvestmentAccountContext db) =>
        {
            var affected = await db.InvestmentAccount
                .Where(model => model.InvestmentAccountNumber == investmentaccountnumber)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteInvestmentAccountFacility")
        .WithOpenApi();
    }
}
