using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Tests
{
    [TestClass]
    public class TestMaterialController
    {
    
        [TestMethod]
        public void GetAllMateriais_RetornaTodosOsMateriais()
        {
            var controller = MateriaisController(); 
        }
    }
}
