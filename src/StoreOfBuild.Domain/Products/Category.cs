namespace StoreOfBuild.Domain.Products
{
    public class Category
    {
        public int Id { get; private set; }

        public string Name { get; set; }


        private void ValidateNameAndSetName(string name)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Name is required");

            this.Name = name;
        }
        public Category(string name)
        {
            ValidateNameAndSetName(name);

        }

        public void Update(string name){

            ValidateNameAndSetName(name);
        }
    }
}