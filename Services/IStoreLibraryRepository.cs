using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core_api.Services
{
    public interface IStoreLibraryRepository
    {
        void AddProducts(Guid categoryId, ProductDetails productDetails);
        ProductDetails GetProductDetails(Guid categoryId, Guid productDetailsId);
        bool Save();


    }
}
