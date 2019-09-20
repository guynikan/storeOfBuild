
using StoreOfBuild.Domain.Dtos;

namespace StoreOfBuild.Domain.Products
{
    public class CategoryStore
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryStore(IRepository<Category> categoryRepository){

            _categoryRepository = categoryRepository;
        }
       
       public void Store(CategoryDto dto){
           
           var category = _categoryRepository.GetById(dto.Id);

           if (category == null){

               category = new Category(dto.Name);
               _categoryRepository.Save(category);
           }
           else
                category.Update(dto.Name);


       }
        
    }
}