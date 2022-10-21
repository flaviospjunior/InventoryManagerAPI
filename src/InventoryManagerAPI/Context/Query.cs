using InventoryManagerAPI.Models;

namespace InventoryManagerAPI.Context
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Material> GetMateriais([Service] AppDbContext context ) =>
            context.Materiais;
    }
}
