using core_api.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core_api.Services
{
    public class StoreLibraryRepository : IStoreLibraryRepository, IDisposable
    {
        private readonly StoreLibraryContext context;
        public StoreLibraryRepository(StoreLibraryContext context)
        {
            this.context = context ?? throw new ArgumentException(nameof(context));
        }

        public void AddProducts(Guid categoryId, ProductDetails productDetails)
        {
            if (categoryId == Guid.Empty)
            {
                throw new ArgumentException(nameof(categoryId));
            }
            if (productDetails == null)
            {
                throw new ArgumentException(nameof(productDetails));
            }
            productDetails.CategoryId = categoryId;
            this.context.ProductDetails.Add(productDetails);
        }

        public ProductDetails GetProductDetails(Guid categoryId, Guid productDetailsId)
        {
            if (categoryId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(categoryId));
            }

            if (productDetailsId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(productDetailsId));
            }

            return this.context.ProductDetails
              .Where(pd => pd.CategoryId == categoryId && pd.Id == productDetailsId).FirstOrDefault();
        }

        public bool Save()
        {
            return (this.context.SaveChanges() >= 0);
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }
    }
}
