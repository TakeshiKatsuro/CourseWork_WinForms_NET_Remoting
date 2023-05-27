
using System.Data;

namespace Server
{
    public interface IGuitars
    {
        DataTable findByBrand(string brand);
        DataTable findByModel(string model);
        DataTable fullTable();
        //Guitars find();
        //List<Guitars> findAll();
    }
}
