using KioskOrderingSystem.Models;

namespace KioskOrderingSystem.Repositories
{
    public class KiosDatabase
    {
        private List<KioskModel> Items { get; set; }
        public KiosDatabase()
        {
            Items = new()
            {
                new KioskModel
                {
                    Name = "Cheese Toastie",
                    Type = "Sandwhich",
                    Description = "Toasted sandwich with three types of cheese.",
                    ImageURL ="https://cdn.loveandlemons.com/wp-content/uploads/2023/01/grilled-cheese-sandwich.jpg",
                    Price = 2.50
                },
                new KioskModel
                {
                    Name = "Chicken sandwich",
                    Type = "Sandwhich",
                    Description = "Brioche bun with fried chicken and side salad.",
                    ImageURL = "https://www.cookwell.com/_next/image?url=https%3A%2F%2Fcdn.sanity.io%2Fimages%2Fg1s4qnmz%2Fproduction%2Ff8de3529e401762005059c9bdf7938fd06bd2b53-1500x1500.jpg&w=1080&q=75",
                    Price = 3.00
                },
                new KioskModel
                {
                    Name = "Veggie Wrap",
                    Type = "Sandwhich",
                    Description = "Whole wheat wrap filled with fresh vegetables and hummus.",
                    ImageURL = "https://www.eatingwell.com/thmb/BKZhWx-_Xyo6MKrh3s_gi10DQ8w=/750x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/4526733-45129f82ed554ea1be3ac980d096a6f1.jpg",
                    Price = 3.50
                },
                new KioskModel
                {
                    Name = "Cappachino",
                    Type = "Beverage",
                    Description = "Cappacino drink",
                    ImageURL = "https://www.livingnorth.com/images/media/articles/food-and-drink/eat-and-drink/coffee.png?fm=pjpg&w=1000&q=95",
                    Price = 3.50
                },

                new KioskModel {
                    Name = "Cheesecake",
                    Type = "Dessert",
                    Description = "Plain cheesecake",
                    ImageURL = "https://www.onceuponachef.com/images/2017/12/cheesecake.jpg",
                    Price = 5.00,
                },
            };
        }


        public List<KioskModel> GetAllItems()
        {
            return Items;
        }

        public List<KioskModel> GetBeverages()
        {
            return new List<KioskModel>() {
                new KioskModel
                {
                    Name = "Cappachino",
                    Type = "Beverage",
                    Description = "Cappacino drink",
                    ImageURL = "https://www.livingnorth.com/images/media/articles/food-and-drink/eat-and-drink/coffee.png?fm=pjpg&w=1000&q=95",
                    Price = 3.50
                },
            };
        }

        public List<KioskModel> GetDesserts()
        {
            return new List<KioskModel>() {
                new KioskModel {
                    Name = "Cheesecake",
                    Type = "Dessert",
                    Description = "Plain cheesecake",
                    ImageURL = "https://www.onceuponachef.com/images/2017/12/cheesecake.jpg",
                    Price = 5.00,
                },
            };
        }

        public List<KioskModel> GetSandwhiches()
        {
            return new List<KioskModel>() {
               new KioskModel
                {
                    Name = "Cheese Toastie",
                    Type = "Sandwhich",
                    Description = "Toasted sandwich with three types of cheese.",
                    ImageURL ="https://cdn.loveandlemons.com/wp-content/uploads/2023/01/grilled-cheese-sandwich.jpg",
                    Price = 2.50
                },
                new KioskModel
                {
                    Name = "Chicken sandwich",
                    Type = "Sandwhich",
                    Description = "Brioche bun with fried chicken and side salad.",
                    ImageURL = "https://www.cookwell.com/_next/image?url=https%3A%2F%2Fcdn.sanity.io%2Fimages%2Fg1s4qnmz%2Fproduction%2Ff8de3529e401762005059c9bdf7938fd06bd2b53-1500x1500.jpg&w=1080&q=75",
                    Price = 3.00
                },
                new KioskModel
                {
                    Name = "Veggie Wrap",
                    Type = "Sandwhich",
                    Description = "Whole wheat wrap filled with fresh vegetables and hummus.",
                    ImageURL = "https://www.eatingwell.com/thmb/BKZhWx-_Xyo6MKrh3s_gi10DQ8w=/750x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/4526733-45129f82ed554ea1be3ac980d096a6f1.jpg",
                    Price = 3.50
                },
            };
        }
    }
}