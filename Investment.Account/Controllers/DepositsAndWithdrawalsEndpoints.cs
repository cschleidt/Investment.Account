using Microsoft.EntityFrameworkCore;
using Investment.Account.Models;
using Investment.Account.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
namespace Investment.Account.Controllers;

public static class DepositsAndWithdrawalsEndpoints
{
    public static void MapInvestmentAccountEntryEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/InvestmentAccountEntry").WithTags(nameof(InvestmentAccountEntry));

        group.MapGet("/", async (InvestmentAccountContext db) =>
        {
            return await db.InvestmentAccountEntry.ToListAsync();
        })
        .WithName("GetAllInvestmentAccountEntrys")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<InvestmentAccountEntry>, NotFound>> (string investmententryid, InvestmentAccountContext db) =>
        {
            return await db.InvestmentAccountEntry.AsNoTracking()
                .FirstOrDefaultAsync(model => model.InvestmentEntryId == investmententryid)
                is InvestmentAccountEntry model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetInvestmentAccountEntryById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (string investmententryid, InvestmentAccountEntry investmentAccountEntry, InvestmentAccountContext db) =>
        {
            var affected = await db.InvestmentAccountEntry
                .Where(model => model.InvestmentEntryId == investmententryid)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.InvestmentEntryId, investmentAccountEntry.InvestmentEntryId)
                  .SetProperty(m => m.InvestmentAccountNumber, investmentAccountEntry.InvestmentAccountNumber)
                  .SetProperty(m => m.CustomerReference, investmentAccountEntry.CustomerReference)
                  .SetProperty(m => m.InstrumentType, investmentAccountEntry.InstrumentType)
                  .SetProperty(m => m.InstrumentReference, investmentAccountEntry.InstrumentReference)
                  .SetProperty(m => m.Quantity, investmentAccountEntry.Quantity)
                  .SetProperty(m => m.PricePrShare, investmentAccountEntry.PricePrShare)
                  .SetProperty(m => m.TradingDate, investmentAccountEntry.TradingDate)
                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateInvestmentAccountEntry")
        .WithOpenApi();

        group.MapPost("/", async (InvestmentAccountEntry investmentAccountEntry, InvestmentAccountContext db) =>
        {
            db.InvestmentAccountEntry.Add(investmentAccountEntry);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/InvestmentAccountEntry/{investmentAccountEntry.InvestmentEntryId}",investmentAccountEntry);
        })
        .WithName("CreateInvestmentAccountEntry")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (string investmententryid, InvestmentAccountContext db) =>
        {
            var affected = await db.InvestmentAccountEntry
                .Where(model => model.InvestmentEntryId == investmententryid)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteInvestmentAccountEntry")
        .WithOpenApi();
    }
}
