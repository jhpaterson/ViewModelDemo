using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ViewModelDemo.ViewModels
{
    public class ProductDetailViewModel
    {
        [DisplayName("Product Name")]
        public string name { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("Retail Price")]
        public string price { get; set; } 
    }
}