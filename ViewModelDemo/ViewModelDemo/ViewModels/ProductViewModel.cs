using System.Web.Mvc;
using ViewModelDemo.Models;

namespace ViewModelDemo.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public SelectList CategoryList{get; set;}
    }
}


