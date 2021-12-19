using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //GELEN PARAMETRELER ARAYÜZDEN GELİYOR
   public interface IProductService
    {
        IDataResult<Product> GetById(int productId);//PRODUCT TÜRÜNDE DÖNDÜRMEMİZ BİZE PRODUCT CLASI İÇERİSİNDEKİ PRODUCTID İLE PARAMETRE OLARAK GÖNDERECEĞİMİZ PRODUCTID İ EŞLEMEMİZE SAĞLIYOR.PRODUCT TÜRÜNDE KULLANMASAK O PRODUCTID YE ULAŞAMAYIZ.
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByCategory(int categoryId);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
    }
}
