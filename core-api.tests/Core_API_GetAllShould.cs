using System;
using Xunit;
using core_api.Classes;
using System.Linq;

namespace core_api.tests
{
    public class Core_API_GetAllShould
    {
        ListManager _lm;

        public Core_API_GetAllShould() 
        {
            _lm = new ListManager();
        }
        
        [Fact]
        public void Get_All_On_List()
        {
            var result = _lm.GetAllItems();
            Assert.IsType<EnumerableQuery>(result);
        }
    }
}
