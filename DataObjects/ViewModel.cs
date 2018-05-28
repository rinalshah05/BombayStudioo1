using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DataObjects
{
    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category
    {
    }

    [MetadataType((typeof(ProductMetadata)))]
    public partial class Product
    {
    }
}
